using System.Threading.Tasks;
using RN77.Comun.Models.Usuario;
using RN77.Comun.Models.Usuario.Request;
using RN77.Comun.Models.Varios;

namespace RN77.BD.Services
{
    public interface IApiService
    {
        Task<Respuesta> CambiarPasswordAsync(string urlBase, string servicePrefix, string controller, CambiarPasswordRequest cambiarPasswordPeticion, string tokenType, string accessToken);
        Task<Respuesta> DeleteAsync(string urlBase, string servicePrefix, string controller, int id, string tokenType, string accessToken);
        Task<Respuesta> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
        Task<Respuesta> GetListAsync<T>(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken);
        Task<Respuesta> GetTokenAsync(string urlBase, string servicePrefix, string controller, PedirTokenRequest peticion);
        Task<Respuesta> GetUserByEmailAsync(string urlBase, string servicePrefix, string controller, string email, string tokenType, string accessToken);
        Task<Respuesta> PostAsync<T>(string urlBase, string servicePrefix, string controller, T model, string tokenType, string accessToken);
        Task<Respuesta> PutAsync<T>(string urlBase, string servicePrefix, string controller, int id, T model, string tokenType, string accessToken);
        Task<Respuesta> PutAsync<T>(string urlBase, string servicePrefix, string controller, T model, string tokenType, string accessToken);
        Task<Respuesta> RecuperarPasswordAsync(string urlBase, string servicePrefix, string controller, EmailRequest peticion);
        Task<Respuesta> RegisterUserAsync(string urlBase, string servicePrefix, string controller, UsuarioRequest peticion);
    }
}