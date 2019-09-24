using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using RN77.Actores.Controllers;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.BD.Datos.Repositorios;
using RN77.BD.Helpers;
using System.Text;

namespace RN77.Actores
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            try
            {
                services.AddIdentity<Usuarios, IdentityRole>(cfg =>
                {
                    cfg.Tokens.AuthenticatorTokenProvider = TokenOptions.DefaultAuthenticatorProvider;
                    cfg.SignIn.RequireConfirmedEmail = true;
                    cfg.User.RequireUniqueEmail = true;
                    cfg.Password.RequireDigit = false;
                    cfg.Password.RequiredUniqueChars = 0;
                    cfg.Password.RequireLowercase = false;
                    cfg.Password.RequireNonAlphanumeric = false;
                    cfg.Password.RequireUppercase = false;
                    cfg.Password.RequiredLength = 6;
                })
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<RN77Context>();

                services.AddAuthentication()
                    .AddCookie()
                    .AddJwtBearer(cfg =>
                    {
                        cfg.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidIssuer = this.Configuration["Tokens:Issuer"],
                            ValidAudience = this.Configuration["Tokens:Audience"],
                            IssuerSigningKey = new SymmetricSecurityKey(
                                Encoding.UTF8.GetBytes(this.Configuration["Tokens:Key"]))
                        };
                    });

                services.AddDbContext<RN77Context>(cfg =>
                {
                    cfg.UseSqlServer(this.Configuration.GetConnectionString("RN77Connection"));
                });

                #region INYECCION
                //services.AddTransient<SeedDb>();

                services.AddScoped<IUsuarioHelper, UsuarioHelper>();
                services.AddScoped<IMailHelper, MailHelper>();
                #endregion

                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            }
            catch (System.Exception err)
            {
                throw err;
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "apiactores/{controller=Home}/{action=Index}/{id?}");
            //});

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
