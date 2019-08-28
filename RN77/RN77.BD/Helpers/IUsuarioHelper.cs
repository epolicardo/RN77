namespace RN77.BD.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using RN77.BD.Datos.Entities;
    using System.Threading.Tasks;

    public interface IUsuarioHelper
    {
        Task<IdentityResult> AddUserAsync(Usuarios usuarios, string password);
        Task<Usuarios> GetUserByEmailAsync(string email);
    }
}