namespace RN77.BD.Datos
{
    using Microsoft.AspNetCore.Identity;
    using RN77.BD.Datos.Entities;
    using RN77.BD.Helpers;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDb
    {
        private readonly RN77Context context;
        private readonly IUsuarioHelper userHelper;
        private readonly Random random;

        public SeedDb(RN77Context context, IUsuarioHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            await this.CheckRolesAsync();

            await this.CheckUser("pepe@gmail.com", "Pepe", "Sanchez", "Docente");
            await this.CheckUser("juan@gmail.com", "Juan", "Carrizo", "Alumno");
            var usuario = await this.CheckUser("incudei@hotmail.com", "incudei", "Zulu", "Admin");

            if (!this.context.Paises.Any())
            {
                await this.AddPaisesProvinciasYCiudadesAsync(usuario);
            }
        }

        private async Task<Usuarios> CheckUser(string email, string nombre, string apellido, string role)
        {
            // Add user
            var usuario = await this.userHelper.GetUserByEmailAsync(email);
            if (usuario == null)
            {
                usuario = await this.AddUsuario(email, nombre, apellido, role);
            }

            var isInRole = await this.userHelper.IsUserInRoleAsync(usuario, role);
            if (!isInRole)
            {
                await this.userHelper.AddUsuariosToRoleAsync(usuario, role);
            }

            return usuario;
        }

        private async Task<Usuarios> AddUsuario(string email, string nombre, string apellido, string role)
        {
            var usuario = new Usuarios
            {
                Email = email,
                UserName = email,
                FechaCreaReg = DateTime.Parse("2019-01-01"),
                FechaModifReg = DateTime.Parse("2019-01-01"),
                PhoneNumber = "3516756998",
            };

            var result = await this.userHelper.AddUserAsync(usuario, "123456");
            if (result != IdentityResult.Success)
            {
                throw new InvalidOperationException("Could not create the user in seeder");
            }

            await this.userHelper.AddUsuariosToRoleAsync(usuario, role);
            var token = await this.userHelper.GenerateEmailConfirmationTokenAsync(usuario);
            await this.userHelper.ConfirmEmailAsync(usuario, token);
            return usuario;
        }

        private async Task AddPaisesProvinciasYCiudadesAsync(Usuarios usuario)
        {
            this.AddCiudad("Argentina",
                           "Córdoba",
                           new string[] { "Córdoba", "Buenos Aires", "Rosario", "Tandil", "Salta", "Mendoza" },
                           usuario);
            await this.context.SaveChangesAsync();
        }

        private void AddCiudad(string nombrePais, string nombreProvincia, string[] nombreCiudades, Usuarios usuario)
        {
            var pais = new Paises
            {
                NombrePais = nombrePais,
                ObservReg = "",
                EstadoReg = 1,
                FechaCreaReg = DateTime.Parse("2019-01-01"),
                FechaModifReg = DateTime.Parse("2019-01-01"),
                Usuario = usuario,
            };
            this.context.Paises.Add(pais);

            var ciudades = nombreCiudades.Select(c => new Ciudades
            {
                NombreCiudad = c,
                ObservReg = "",
                EstadoReg = 1,
                FechaCreaReg = DateTime.Parse("2019-01-01"),
                FechaModifReg = DateTime.Parse("2019-01-01"),
                Usuario = usuario,
            }).ToList();

            this.context.Provincias.Add(new Provincias
            {
                NombreProvincia = nombreProvincia,
                ObservReg = "",
                EstadoReg = 1,
                FechaCreaReg = DateTime.Parse("2019-01-01"),
                FechaModifReg = DateTime.Parse("2019-01-01"),
                Usuario = usuario,
                Pais = pais,
                Ciudades = ciudades,
            });
        }

        private async Task CheckRolesAsync()
        {
            await this.userHelper.CheckRoleAsync("Admin");
            await this.userHelper.CheckRoleAsync("Docente");
            await this.userHelper.CheckRoleAsync("Alumno");
        }
    }
}
