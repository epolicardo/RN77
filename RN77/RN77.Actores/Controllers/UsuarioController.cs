using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RN77.BD.Datos.Entities;
using RN77.BD.Helpers;
using RN77.BD.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RN77.Actores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioHelper usuarioHelper;
        private readonly IMailHelper mailHelper;

        public UsuarioController(IUsuarioHelper usuarioHelper,
                                 IMailHelper mailHelper)
        {
            this.usuarioHelper = usuarioHelper;
            this.mailHelper = mailHelper;
        }


        [HttpPost]
        public async Task<IActionResult> PostUsuario([FromBody] RegistrarNuevoUsuarioViewModel peticion)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return this.BadRequest(new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = "Petición erronea."
                    });
                }

                var usuario = await this.usuarioHelper.GetUserByEmailAsync(peticion.Username);
                if (usuario != null)
                {
                    return this.BadRequest(new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = "Este usuario está registrado."
                    });
                }

                usuario = new Usuarios
                {
                    Email = peticion.Username,
                    UserName = peticion.Username,
                    PhoneNumber = "",
                    FechaCreaReg = DateTime.UtcNow,
                    FechaModifReg = DateTime.UtcNow,
                    FechaBajaReg = null
                };

                var result = await this.usuarioHelper.AddUserAsync(usuario, peticion.Password);
                if (result != IdentityResult.Success)
                {
                    return this.BadRequest(result.Errors.FirstOrDefault().Description);
                }

                var myToken = await this.usuarioHelper.GenerateEmailConfirmationTokenAsync(usuario);
                var tokenLink = this.Url.Action("ConfirmEmail", "Usuario", new
                {
                    userid = usuario.Id,
                    token = myToken
                }, protocol: HttpContext.Request.Scheme);

                //var persona = await this.Persona.GetCityAsync(peticion.CityId);


                this.mailHelper.SendMail(peticion.Username, "Email Confirmación RN77", $"<h1>Email  Confirmación RN77</h1>" +
                $"Para habilitar el usuario, " +
                $"por favor click en este link:</br></br><a href = \"{tokenLink}\">Confirme Email</a>");

                return Ok(new Respuesta
                {
                    EsExitoso = true,
                    Mensaje = "Un mail de confirmacón a sido enviado. Por favor confirmar su cuenta e ingresar en la aplicación."
                });
            }
            catch (Exception ee)
            {
                return this.BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Error en la creación del usuario.\r\n" + ee.Message
                });
            }
        }
    }
}
