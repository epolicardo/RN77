using System;

namespace RN77.Comun.Models.Varios
{
    public class TokenRespuesta
    {
        public string Token { get; set; }

        public DateTime Expiration { get; set; }

        public DateTime ExpirationLocal => Expiration.ToLocalTime();
    }
}
