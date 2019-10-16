using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace RN77.BD.Helpers
{
    public class MailHelper : IMailHelper
    {
        #region CAMPOS
        private readonly IConfiguration configuration;
        #endregion

        #region CONSTRUCTOR
        public MailHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        #endregion

        #region METODOS
        public void SendMail(string to, string subject, string body)
        {
            var from = this.configuration["Mail:From"];
            var smtp = this.configuration["Mail:Smtp"];
            var port = this.configuration["Mail:Port"];
            var password = this.configuration["Mail:Password"];

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(from));
            message.To.Add(new MailboxAddress(to));
            message.Subject = subject;
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = body;
            message.Body = bodyBuilder.ToMessageBody();
            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect(smtp, int.Parse(port), true);
                    client.Authenticate(from, password);
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (System.Exception err)
            {
                throw err;
            }
        }
        #endregion
    }
}
