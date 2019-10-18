using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using RN77.BD.Datos;
using RN77.BD.Datos.Entities;
using RN77.BD.Helpers;
using RN77.BD.Services;
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
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<RN77Context>();

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

            // Register the Swagger services
            services.AddSwaggerDocument();
            //services.AddSwaggerDocument(config =>
            //{
            //    config.PostProcess = document =>
            //    {
            //        document.Info.Version = "v1";
            //        document.Info.Title = "ToDo API";
            //        document.Info.Description = "A simple ASP.NET Core web API";
            //        document.Info.TermsOfService = "None";
            //        document.Info.Contact = new NSwag.OpenApiContact
            //        {
            //            Name = "Shayne Boyer",
            //            Email = string.Empty,
            //            Url = "https://twitter.com/spboyer"
            //        };
            //        document.Info.License = new NSwag.OpenApiLicense
            //        {
            //            Name = "Use under LICX",
            //            Url = "https://example.com/license"
            //        };
            //    };
            //});
            #region INYECCION
            services.AddScoped<IUsuarioHelper, UsuarioHelper>();
            services.AddScoped<IMailHelper, MailHelper>();
            services.AddScoped<IApiService, ApiService>();
            #endregion

            services.AddControllers().AddNewtonsoftJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // Register the Swagger generator and the Swagger UI middlewares
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
