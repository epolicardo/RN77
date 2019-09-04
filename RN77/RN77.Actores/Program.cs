namespace RN77.Actores
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using RN77.BD.Datos;

    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            //RunSeeding(host);
            host.Run();
        }

        private static void RunSeeding(IWebHost host)
        {
            try
            {
                var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
                using (var scope = scopeFactory.CreateScope())
                {
                    var seeder = scope.ServiceProvider.GetService<SeedDb>();
                    seeder.SeedAsync().Wait();
                }

            }
            catch (System.Exception err)
            {

                throw err;
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
