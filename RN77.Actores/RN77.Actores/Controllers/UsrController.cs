using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RN77.BD.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.BD.Helpers;
using RN77.Comun.Models.Usuario;
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
        private readonly IMailHelper mailHelper;
        private readonly RN77Context context;

        public UsrController(IUsuarioHelper usuarioHelper,
                             IMailHelper mailHelper,
                             RN77Context context)
        {
            this.usuarioHelper = usuarioHelper;
            this.mailHelper = mailHelper;
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Respuesta>> PostUsr([FromBody] UsuarioRequest peticion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Petición Incorrecta",
                    Resultado = ModelState
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

            var entity = new Personas
            {
                Nombre = peticion.Nombre,
                Apellido = peticion.Apellido,
                Usuario = usuario
            };
            BaseController.CompletaRegistro(entity, 1, "", usuario, false);

            await this.context.Set<Personas>().AddAsync(entity);
            try
            {
                await this.context.SaveChangesAsync();
            }
            catch (Exception ee)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Perona no grabada, controlar.",
                    Resultado = null
                });
            }

            usuario.PersonaId = entity.Id;
            result = await this.usuarioHelper.UpdateUserAsync(usuario);
            if (result != IdentityResult.Success)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = result.Errors.FirstOrDefault().Description,
                    Resultado = null
                });
            }

            var myToken = await this.usuarioHelper.GenerateEmailConfirmationTokenAsync(usuario);
            var tokenLink = this.Url.Action("ConfirmaEmail", "Usr", new
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

        public async Task<ActionResult<Respuesta>> ConfirmaEmail(string userId, string token)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Datos incorrectos.",
                    Resultado = null
                });
            }

            var user = await this.usuarioHelper.GetUserByIdAsync(userId);
            if (user == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Usuario incorrecto.",
                    Resultado = null
                });
            }

            var result = await this.usuarioHelper.ConfirmaEmailAsync(user, token);
            if (!result.Succeeded)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "Usuario incorrecto.",
                    Resultado = null
                });
            }

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "Cuenta de usuario confirmado y habilitado, conectarse a la aplicación.",
                Resultado = null
            });
        }

        [HttpPost]
        [Route("RecuperarPassword")]
        public async Task<ActionResult<Respuesta>> RecuperarPassword([FromBody] EmailRequest peticion)
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
            var link = this.Url.Action("RecuperarPassword", "Usr", new { token = myToken }, protocol: HttpContext.Request.Scheme);
            this.mailHelper.SendMail(peticion.Email, "Recuperar Password", $"<h1>Recuperar Password</h1>" +
                $"Para recuperar la password click en este link:</br></br>" +
                $"<a href = \"{link}\">Recuperar Password</a>");

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "Un email con instrucciones a sido enviado para confirma el cambio de password.",
                Resultado = null
            });
        }

        [HttpPost]
        [Route("GetUserByEmail")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<Respuesta>> GetUserByEmail([FromBody] EmailRequest request)
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

            var user = await this.usuarioHelper.GetUserByEmailAsync(request.Email);
            if (user == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "El usuario no existe.",
                    Resultado = null
                });
            }

            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = user
            });
        }

        [HttpPut]
        public async Task<IActionResult> PutUser([FromBody] Usuarios user)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var userEntity = await this.usuarioHelper.GetUserByEmailAsync(user.Email);
            if (userEntity == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "El usuario no existe.",
                    Resultado = null
                });
            }

            userEntity.PhoneNumber = user.PhoneNumber;

            var respose = await this.usuarioHelper.UpdateUserAsync(userEntity);
            if (!respose.Succeeded)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "El usuario no ha sido actualizado, controlar.",
                    Resultado = null
                });
            }

            var updatedUser = await this.usuarioHelper.GetUserByEmailAsync(user.Email);
            return Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "",
                Resultado = updatedUser
            });
        }

        [HttpPost]
        [Route("CambiarPassword")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<Respuesta>> CambiarPassword([FromBody] CambiarPasswordRequest request)
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

            var user = await this.usuarioHelper.GetUserByEmailAsync(request.eMail);
            if (user == null)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = "El mail no corresponde a ningún usuario.",
                    Resultado = null
                });
            }

            var result = await this.usuarioHelper.CambiarPasswordAsync(user, request.oldPassword, request.newPassword);
            if (!result.Succeeded)
            {
                return BadRequest(new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = result.Errors.FirstOrDefault().Description,
                    Resultado = null
                });
            }

            return this.Ok(new Respuesta
            {
                EsExitoso = true,
                Mensaje = "La password a sido cambiada.",
                Resultado = null
            });
        }
    }
}