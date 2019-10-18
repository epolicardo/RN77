using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RN77.Actores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InicioController : ControllerBase
    {
        public IActionResult Index()
        {
            var p = new InicioRequest();
            return Ok(p.Mensaje);
        }
    }
}
