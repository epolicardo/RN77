using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Usuario.Request;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RN77.BD.Helpers
{
    public class UsuarioHelper : IUsuarioHelper
    {
        #region CAMPOS
        private readonly UserManager<Usuarios> usuarioManager;
        private readonly SignInManager<Usuarios> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        #endregion

        #region CONSTRUCTOR
        public UsuarioHelper(UserManager<Usuarios> userManager,
                             SignInManager<Usuarios> signInManager,
                             RoleManager<IdentityRole> roleManager)
        {
            this.usuarioManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        #endregion

        #region METODOS
        public async Task<IdentityResult> AddUserAsync(Usuarios usuario, string password)
        {
            return await this.usuarioManager.CreateAsync(usuario, password);
        }

        public async Task AddUsuariosToRoleAsync(Usuarios usuario, string roleName)
        {
            await this.usuarioManager.AddToRoleAsync(usuario, roleName);
        }

        public async Task<IdentityResult> ChangePasswordAsync(Usuarios usuario, string oldPassword, string newPassword)
        {
            return await this.usuarioManager.ChangePasswordAsync(usuario, oldPassword, newPassword);
        }

        public async Task CheckRoleAsync(string roleName)
        {
            var roleExists = await this.roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await this.roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }
        }

        public async Task<Usuarios> GetUserByEmailAsync(string email)
        {
            return await this.usuarioManager.FindByEmailAsync(email);
        }

        public async Task<bool> IsUserInRoleAsync(Usuarios usuario, string roleName)
        {
            return await this.usuarioManager.IsInRoleAsync(usuario, roleName);
        }

        public async Task<SignInResult> LoginAsync(LoginRequest model)
        {
            return await this.signInManager.PasswordSignInAsync(model.Usuario,
                                                                model.Password,
                                                                model.RecordarMe,
                                                                false);
        }

        public async Task LogoutAsync()
        {
            await this.signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> UpdateUserAsync(Usuarios usuario)
        {
            return await this.usuarioManager.UpdateAsync(usuario);
        }

        public async Task<SignInResult> ValidatePasswordAsync(Usuarios usuario, string password)
        {
            return await this.signInManager.CheckPasswordSignInAsync(usuario,
                                                                     password,
                                                                     false);
        }

        public async Task<IdentityResult> ConfirmEmailAsync(Usuarios usuario, string token)
        {
            return await this.usuarioManager.ConfirmEmailAsync(usuario, token);
        }

        public async Task<string> GenerateEmailConfirmationTokenAsync(Usuarios usuario)
        {
            return await this.usuarioManager.GenerateEmailConfirmationTokenAsync(usuario);
        }

        public async Task<Usuarios> GetUserByIdAsync(string usuarioId)
        {
            return await this.usuarioManager.FindByIdAsync(usuarioId);
        }

        public async Task<string> GeneratePasswordResetTokenAsync(Usuarios usuario)
        {
            return await this.usuarioManager.GeneratePasswordResetTokenAsync(usuario);
        }

        public async Task<IdentityResult> ResetPasswordAsync(Usuarios usuario, string token, string password)
        {
            return await this.usuarioManager.ResetPasswordAsync(usuario, token, password);
        }

        public async Task<List<Usuarios>> GetAllUsersAsync()
        {
            return await this.usuarioManager.Users
                .Include(u => u.Persona)
                .OrderBy(u => u.Persona.Nombre)
                .ThenBy(u => u.Persona.Apellido)
                .ToListAsync();
        }

        public async Task RemoveUserFromRoleAsync(Usuarios usuario, string roleName)
        {
            await this.usuarioManager.RemoveFromRoleAsync(usuario, roleName);
        }

        public async Task DeleteUserAsync(Usuarios usuario)
        {
            await this.usuarioManager.DeleteAsync(usuario);
        }
        #endregion
    }
}

