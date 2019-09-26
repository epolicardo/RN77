namespace RN77.Actores.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using BD.Datos.Entities;
    using BD.Helpers;
    using BD.Models;
    
    public class CuentaController : Controller
    {
        private readonly IUsuarioHelper usuarioHelper;

        public CuentaController(IUsuarioHelper usuarioHelper)
        {
            this.usuarioHelper = usuarioHelper;
        }

        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var result = await this.usuarioHelper.LoginAsync(model);
                if (result.Succeeded)
                {
                    if (this.Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return this.Redirect(this.Request.Query["ReturnUrl"].First());
                    }

                    return this.RedirectToAction("Index", "Home");
                }
            }

            this.ModelState.AddModelError(string.Empty, "Error al iniciar sesión.");
            return this.View(model);
        }


        public async Task<IActionResult> Logout()
        {
            await this.usuarioHelper.LogoutAsync();
            return this.RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistrarNuevoUsuarioViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.usuarioHelper.GetUserByEmailAsync(model.Username);
                if (user == null)
                {
                    user = new Usuarios
                    {                      
                        Email = model.Username,
                        UserName = model.Username
                    };

                    var result = await this.usuarioHelper.AddUserAsync(user, model.Password);
                    if (result != IdentityResult.Success)
                    {
                        this.ModelState.AddModelError(string.Empty, "No se pudo creae el usuario.");
                        return this.View(model);
                    }


                    var loginViewModel = new LoginViewModel
                    {
                        Password = model.Password,
                        RecordarMe = false,
                        Usuario = model.Username
                    };

                    var result2 = await this.usuarioHelper.LoginAsync(loginViewModel);

                    if (result2.Succeeded)
                    {
                        return this.RedirectToAction("Index", "Home");
                    }

                    this.ModelState.AddModelError(string.Empty, "No se pudo iniciar sesión.");
                    return this.View(model);
                }

                this.ModelState.AddModelError(string.Empty, "El Usuario ya existe.");
            }

            return this.View(model);
        }

        public async Task<IActionResult> ChangeUser()
        {
            var user = await this.usuarioHelper.GetUserByEmailAsync(this.User.Identity.Name);
            var model = new ChangeUserViewModel();
            if (user != null)
            {
                model.Nombre = user.Persona.Nombre;
                model.Apellido = user.Persona.Apellido;
            }

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeUser(ChangeUserViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.usuarioHelper.GetUserByEmailAsync(this.User.Identity.Name);
                if (user != null)
                {
                    user.Persona.Nombre = model.Nombre;
                    user.Persona.Apellido = model.Apellido;
                    var respose = await this.usuarioHelper.UpdateUserAsync(user);
                    if (respose.Succeeded)
                    {
                        this.ViewBag.UserMessage = "Actualizado!";
                    }
                    else
                    {
                        this.ModelState.AddModelError(string.Empty, respose.Errors.FirstOrDefault().Description);
                    }
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, "No se encontró el usuario.");
                }
            }

            return this.View(model);
        }

        public IActionResult ChangePassword()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(CambiarPasswordViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.usuarioHelper.GetUserByEmailAsync(this.User.Identity.Name);
                if (user != null)
                {
                    var result = await this.usuarioHelper.ChangePasswordAsync(user, model.oldPassword, model.newPassword);
                    if (result.Succeeded)
                    {
                        return this.RedirectToAction("ChangeUser");
                    }
                    else
                    {
                        this.ModelState.AddModelError(string.Empty, result.Errors.FirstOrDefault().Description);
                    }
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, "No se encontro el Usuario.");
                }
            }

            return this.View(model);
        }



    }

}
