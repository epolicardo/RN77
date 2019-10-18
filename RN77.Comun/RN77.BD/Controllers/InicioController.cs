using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RN77.Comun.Models.Varios;

namespace RN77.BD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InicioController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public InicioController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            var p = new InicioRequest(this.configuration["API"]);
            return Ok(p.Mensaje);
        }
    }
}
