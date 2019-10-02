using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RN77.BD.Datos.Entities;
using RN77.Web.Models;

namespace RN77.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //Convierte el GET en json para visualizarlo en vista.
        public async Task<IActionResult> Aulas()
        {
            //
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://localhost:44388/api/aulas");

            var aulaList = JsonConvert.DeserializeObject<List<Aulas>>(json);

            return View(aulaList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
