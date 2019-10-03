using System;

namespace RN77.Comun.Models.Usuario.Respuesta

{
    public class TokenRespuesta
    {
        public string Token { get; set; }

        public DateTime Expiration { get; set; }

        public DateTime ExpirationLocal => Expiration.ToLocalTime();
    }
}
