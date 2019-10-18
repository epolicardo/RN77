using System;

namespace RN77.Actores
{
    public class InicioRequest
    {
        public string Mensaje
        {
            get
            {
                return
                $"    ......API Actores iniciada....." +
                $"    Fecha: {DateTime.Now}" +
                $"    Consultar https://localhost:[port]/swagger";
            }
        }
    }
}
