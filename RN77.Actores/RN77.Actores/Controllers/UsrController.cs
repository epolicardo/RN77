using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RN77.BD.Datos.Entities;
using RN77.BD.Helpers;
using RN77.Comun.Models.Persona.Request;
using RN77.Comun.Models.Usuario.Request;
using RN77.Comun.Models.Varios;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RN77.Actores.Controllers
{
    [Route("api/[Controller]")]
    public class UsrController : Controller
    {
        private readonly IUsuarioHelper usuarioHelper;
        private readonly PersonasController personaCtrl;
        private readonly IMailHelper mailHelper;

        public UsrController(
            IUsuarioHelper usuarioHelper,
            PersonasController personaCtrl,
            IMailHelper mailHelper)
        {
            this.usuarioHelper = usuarioHelper;
            this.personaCtrl = personaCtrl;
            this.mailHelper = mailHelper;
        }

        [HttpPost]
        public async Task<IActionResult> PostUsr([FromBody] UsuarioRequest peticion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Petición Incorrecta",
                    Resultado = null
                });
            }

            var usuario = await this.usuarioHelper.GetUserByEmailAsync(peticion.Username);
            if (usuario != null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "El usuario ya existe.",
                    Resultado = null
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
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = result.Errors.FirstOrDefault().Description,
                    Resultado = null
                });
            }

            var persona = new PersonaRequest
            {
                Nombre = peticion.Nombre,
                Apellido = peticion.Apellido
            };

            var respuesta = (Respuesta)await this.personaCtrl.PostPersona(persona);
            if (!respuesta.EsExitoso)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Registro no grabado, controlar.",
                    Resultado = null
                });
            }

            var myToken = await this.usuarioHelper.GenerateEmailConfirmationTokenAsync(usuario);
            var tokenLink = this.Url.Action("ConfirmEmail", "Account", new
            {
                userid = usuario.Id,
                token = myToken
            }, protocol: HttpContext.Request.Scheme);

            this.mailHelper.SendMail(peticion.Username, "Email para confirmación", $"<h1>Email para confirmación</h1>" +
                $"Para habilitar el usario, " +
                $"por favor hacer click en este link:</br></br><a href = \"{tokenLink}\">Confirmar email</a>");

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "Un eMail para confirmación a sido enviado. Por favor confirme su cuenta y conectesé a la aplicación.",
                Resultado = null
            });
        }

        [HttpPost]
        [Route("RecoverPassword")]
        public async Task<IActionResult> RecoverPassword([FromBody] EmailRequest peticion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Petición incorrecta.",
                    Resultado = null
                });
            }

            var user = await this.usuarioHelper.GetUserByEmailAsync(peticion.Email);
            if (user == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "El email no está asignado a ningún usuario.",
                    Resultado = null
                });
            }

            var myToken = await this.usuarioHelper.GeneratePasswordResetTokenAsync(user);
            var link = this.Url.Action("ResetPassword", "Account", new { token = myToken }, protocol: HttpContext.Request.Scheme);
            this.mailHelper.SendMail(peticion.Email, "Resetear Password", $"<h1>Resetear Password</h1>" +
                $"Para resetear la password click en este link:</br></br>" +
                $"<a href = \"{link}\">Resetear Password</a>");

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "Un email con instrucciones a sido enviado para confirma el cambio de password.",
                Resultado = null
            });
        }

        //[HttpPost]
        //[Route("GetUserByEmail")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        //public async Task<IActionResult> GetUserByEmail([FromBody] EmailRequest request)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(new Respuesta
        //        {
        //            EsExitoso = false,
        //            Mensaje = "Petición incorrecta.",
        //            Resultado = null
        //        });
        //    }

        //    var user = await this.usuarioHelper.GetUserByEmailAsync(request.Email);
        //    if (user == null)
        //    {
        //        return BadRequest(new Respuesta
        //        {
        //            EsExitoso = false,
        //            Mensaje = "El usuario no existe.",
        //            Resultado = null
        //        });
        //    }

        //    return Ok(user);
        //}

        //[HttpPut]
        //public async Task<IActionResult> PutUser([FromBody] Usuarios user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return this.BadRequest(ModelState);
        //    }

        //    var userEntity = await this.usuarioHelper.GetUserByEmailAsync(user.Email);
        //    if (userEntity == null)
        //    {
        //        return BadRequest(new Respuesta
        //        {
        //            EsExitoso = false,
        //            Mensaje = "El usuario no existe.",
        //            Resultado = null
        //        });
        //    }

        //    userEntity.PhoneNumber = user.PhoneNumber;

        //    var respose = await this.usuarioHelper.UpdateUserAsync(userEntity);
        //    if (!respose.Succeeded)
        //    {
        //        return this.BadRequest(respose.Errors.FirstOrDefault().Description);
        //    }

        //    var updatedUser = await this.usuarioHelper.GetUserByEmailAsync(user.Email);
        //    return Ok(updatedUser);
        //}

        //[HttpPost]
        //[Route("ChangePassword")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        //public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return this.BadRequest(new Response
        //        {
        //            IsSuccess = false,
        //            Message = "Bad request"
        //        });
        //    }

        //    var user = await this.usuarioHelper.GetUserByEmailAsync(request.Email);
        //    if (user == null)
        //    {
        //        return this.BadRequest(new Response
        //        {
        //            IsSuccess = false,
        //            Message = "This email is not assigned to any user."
        //        });
        //    }

        //    var result = await this.usuarioHelper.ChangePasswordAsync(user, request.OldPassword, request.NewPassword);
        //    if (!result.Succeeded)
        //    {
        //        return this.BadRequest(new Response
        //        {
        //            IsSuccess = false,
        //            Message = result.Errors.FirstOrDefault().Description
        //        });
        //    }

        //    return this.Ok(new Response
        //    {
        //        IsSuccess = true,
        //        Message = "The password was changed succesfully!"
        //    });
        //}

    }
}