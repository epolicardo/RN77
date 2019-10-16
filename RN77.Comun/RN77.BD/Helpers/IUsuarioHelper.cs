using Microsoft.AspNetCore.Identity;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Usuario.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RN77.BD.Helpers
{
    public interface IUsuarioHelper
    {
        Task<IdentityResult> AddUserAsync(Usuarios usuario, string password);
        Task AddUsuariosToRoleAsync(Usuarios usuario, string roleName);
        Task<IdentityResult> CambiarPasswordAsync(Usuarios usuario, string oldPassword, string newPassword);
        Task CheckRoleAsync(string roleName);
        Task<IdentityResult> ConfirmaEmailAsync(Usuarios usuario, string token);
        Task DeleteUserAsync(Usuarios usuario);
        Task<string> GenerateEmailConfirmationTokenAsync(Usuarios usuario);
        Task<string> GeneratePasswordResetTokenAsync(Usuarios usuario);
        Task<List<Usuarios>> GetAllUsersAsync();
        Task<Usuarios> GetUserByEmailAsync(string email);
        Task<Usuarios> GetUserByIdAsync(string usuarioId);
        Task<bool> IsUserInRoleAsync(Usuarios usuario, string roleName);
        Task<SignInResult> LoginAsync(LoginRequest model);
        Task LogoutAsync();
        Task RemoveUserFromRoleAsync(Usuarios usuario, string roleName);
        Task<IdentityResult> RecuperarPasswordAsync(Usuarios usuario, string token, string password);
        Task<IdentityResult> UpdateUserAsync(Usuarios usuario);
        Task<SignInResult> ValidatePasswordAsync(Usuarios usuario, string password);
    }
}