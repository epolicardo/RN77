using Microsoft.Extensions.Configuration;
using System;

namespace RN77.Comun.Models.Varios
{
    public class InicioRequest
    {
        private readonly string api;

        public InicioRequest(string api)
        {
            this.api = api;
        }
        public string Mensaje
        {
            get
            {
                return
                $"    ......API {this.api} iniciada....." +
                $"    Fecha: {DateTime.Now}" +
                $"    Consultar https://localhost:[port]/swagger";
            }
        }
    }
}
