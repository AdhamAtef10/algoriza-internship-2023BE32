using System.Net.Mail;
using System.Net;

namespace Vezeta.APIs.Helpers
{
    public class EmailSetting
    {
        public static void SendEmail(Email email)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("adhamatef10@gmail.com", "axjkhimnwgnuxyox");
            client.Send("adhamatef10@gmail.com", email.To, email.Subject, email.Body);
        }
    }
}
