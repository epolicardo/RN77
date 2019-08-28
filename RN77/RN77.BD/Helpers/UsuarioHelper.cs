namespace RN77.BD.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using RN77.BD.Datos.Entities;
    using System.Threading.Tasks;

    public class UsuarioHelper : IUsuarioHelper
    {
        private readonly UserManager<Usuarios> userManager;

        public UsuarioHelper(UserManager<Usuarios> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IdentityResult> AddUserAsync(Usuarios usuarios, string password)
        {
            return await this.userManager.CreateAsync(usuarios, password);
        }

        public async Task<Usuarios> GetUserByEmailAsync(string email)
        {
            return await this.userManager.FindByEmailAsync(email);
        }
    }

}

