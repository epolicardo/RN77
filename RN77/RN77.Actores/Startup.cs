using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RN77.Actores.Datos;
using RN77.BD.Datos;
using RN77.BD.Helpers;

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
                services.AddDbContext<RN77Context>(cfg =>
                {
                    cfg.UseSqlServer(this.Configuration.GetConnectionString("RN77Connection"));
                });

                #region INYECCION
                //services.AddTransient<SeedDb>();

                //services.AddScoped<IRepositorioTcharlas, RepositorioTcharlas>();
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
