using System.Threading.Tasks;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Usuario;

namespace RN77.BD.Services
{
    public interface IApiService
    {
        Task<Respuesta> ChangePasswordAsync(string urlBase, string servicePrefix, string controller, CambiarPasswordRequest cambiarPasswordPeticion, string tokenType, string accessToken);
        Task<Respuesta> DeleteAsync(string urlBase, string servicePrefix, string controller, int id, string tokenType, string accessToken);
        Task<Respuesta> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
        Task<Respuesta> GetListAsync<T>(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken);
        Task<Usuarios> GetTokenAsync(string urlBase, string servicePrefix, string controller, PedirTokenRequest peticion);
        Task<Respuesta> GetUserByEmailAsync(string urlBase, string servicePrefix, string controller, string email, string tokenType, string accessToken);
        Task<Respuesta> PostAsync<T>(string urlBase, string servicePrefix, string controller, T model, string tokenType, string accessToken);
        Task<Respuesta> PutAsync<T>(string urlBase, string servicePrefix, string controller, int id, T model, string tokenType, string accessToken);
        Task<Respuesta> PutAsync<T>(string urlBase, string servicePrefix, string controller, T model, string tokenType, string accessToken);
        Task<Respuesta> RecoverPasswordAsync(string urlBase, string servicePrefix, string controller, RecuperarPasswordViewModel recuperarPasswordPeticion);
        Task<Respuesta> RegisterUserAsync(string urlBase, string servicePrefix, string controller, RegistrarUsuarioRequest nuevoUsuarioPeticion);
    }
}