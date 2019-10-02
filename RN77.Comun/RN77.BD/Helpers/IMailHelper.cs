namespace RN77.BD.Helpers
{
    public interface IMailHelper
    {
        void SendMail(string to, string subject, string body);
    }
}