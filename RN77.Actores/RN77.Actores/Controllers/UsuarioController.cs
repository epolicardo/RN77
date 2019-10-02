using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.BD.Helpers;
using RN77.BD.Services;
using RN77.Comun.Models.Usuario;
using RN77.Comun.Models.Usuario.Request;
using RN77.Comun.Models.Varios;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Controllers.API
{
    [Route("api/[Controller]")]
    public class AccountController : Controller
    {
        private readonly RN77Context context;
        private readonly IUsuarioHelper usuarioHelper;
        private readonly IMailHelper mailHelper;

        public AccountController(RN77Context context,
                                 IUsuarioHelper usuarioHelper,
                                 IMailHelper mailHelper)
        {
            this.context = context;
            this.usuarioHelper = usuarioHelper;
            this.mailHelper = mailHelper;
        }

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] UsuarioRequest peticion,
                                                  IApiService apiService)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta<object>
                {
                    EsExitoso = false,
                    Mensaje = "Petición Incorrecta"
                });
            }

            var usuario = await usuarioHelper.GetUserByEmailAsync(peticion.Username);
            if (usuario != null)
            {
                return BadRequest(new Respuesta<object>
                {
                    EsExitoso = false,
                    Mensaje = "El Usuario ya existe"
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

            var result = await usuarioHelper.AddUserAsync(usuario, peticion.Password);
            if (result != IdentityResult.Success)
            {
                return BadRequest(result.Errors.FirstOrDefault().Description);
            }

            var usuarioNuevo = await usuarioHelper.GetUserByEmailAsync(peticion.Username);
            await usuarioHelper.AddUsuariosToRoleAsync(usuarioNuevo, "Usuario");

            var urlBase = "";
            var servicePrefix = "";
            var PersonaModel = "";
            var tokenType = "";
            var accestoken = "";


                var personaResp = await apiService.PostAsync<Personas>(urlBase, servicePrefix, PersonaModel, tokenType, accestoken);
            //context.Owners.Add(new Owner { User = usuarioNuevo });

            await context.SaveChangesAsync();

            var myToken = await usuarioHelper.GenerateEmailConfirmationTokenAsync(usuario);
            var tokenLink = Url.Action("ConfirmEmail", "Account", new
            {
                userid = usuario.Id,
                token = myToken
            }, protocol: HttpContext.Request.Scheme);

            mailHelper.SendMail(peticion.Username, "Confirmación", $"<h1>Confirmación de eMail</h1>" +
                $"Para dar de alta el usuario, " +
                $"por favor click en este link:</br></br><a href = \"{tokenLink}\">Confirmo eMail</a>");

            return Ok(new Respuesta<object>
            {
                EsExitoso = true,
                Mensaje = "Un email ha sido enviado para confirmación. Por favor confirme su cuenta y conectese a la aplicación."
            });
        }

        [HttpPost]
        [Route("RecoverPassword")]
        public async Task<IActionResult> RecoverPassword([FromBody] EmailRequest peticion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta<object>
                {
                    EsExitoso = false,
                    Mensaje = "Petición incorrecta."
                });
            }

            var usuario = await usuarioHelper.GetUserByEmailAsync(peticion.Email);
            if (usuario == null)
            {
                return BadRequest(new Respuesta<object>
                {
                    EsExitoso = false,
                    Mensaje = "El eMail no esta asignado a ningún usuario."
                });
            }

            var myToken = await usuarioHelper.GeneratePasswordResetTokenAsync(usuario);
            var link = Url.Action("ResetPassword", "Account", new { token = myToken }, protocol: HttpContext.Request.Scheme);
            mailHelper.SendMail(peticion.Email, "Password Reset", $"<h1>Recover Password</h1>" +
                $"To reset the password click in this link:</br></br>" +
                $"<a href = \"{link}\">Reset Password</a>");

            return Ok(new Respuesta<object>
            {
                EsExitoso = true,
                Mensaje = "Un eMail con las instrucciones de cambio de password ha sido enviado."
            });
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> PutUser([FromBody] UsuarioRequest peticion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta<object>
                {
                    EsExitoso = false,
                    Mensaje = "Petición incorrecta"
                });
            }

            var usuarioEntity = await usuarioHelper.GetUserByEmailAsync(peticion.Username);
            if (usuarioEntity == null)
            {
                return BadRequest(new Respuesta<object>
                {
                    EsExitoso = false,
                    Mensaje = "Usuario no encontrado."
                });
            }

            usuarioEntity.Email = peticion.Username;
            usuarioEntity.UserName = peticion.Username;
            usuarioEntity.PhoneNumber = "";
            usuarioEntity.FechaModifReg = DateTime.UtcNow;
            usuarioEntity.FechaBajaReg = null;

            var respose = await usuarioHelper.UpdateUserAsync(usuarioEntity);
            if (!respose.Succeeded)
            {
                return BadRequest(respose.Errors.FirstOrDefault().Description);
            }

            var updatedUser = await usuarioHelper.GetUserByEmailAsync(peticion.Username);
            return Ok(updatedUser);
        }

        [HttpPost]
        [Route("ChangePassword")]
        [Authorize()]
        public async Task<IActionResult> ChangePassword([FromBody] CambiarPasswordRequest peticion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta<object>
                {
                    EsExitoso = false,
                    Mensaje = "Petición incorrecta"
                });
            }

            var user = await usuarioHelper.GetUserByEmailAsync(peticion.eMail);
            if (user == null)
            {
                return BadRequest(new Respuesta<object>
                {
                    EsExitoso = false,
                    Mensaje = "Este eMail no está asignado a ningún usuario"
                });
            }

            var result = await usuarioHelper.ChangePasswordAsync(user, peticion.oldPassword, peticion.newPassword);
            if (!result.Succeeded)
            {
                return BadRequest(new Respuesta<object>
                {
                    EsExitoso = false,
                    Mensaje = result.Errors.FirstOrDefault().Description
                });
            }

            return Ok(new Respuesta<object>
            {
                EsExitoso = true,
                Mensaje = "La password ha sido cambiada correctamente."
            });
        }
    }
}
