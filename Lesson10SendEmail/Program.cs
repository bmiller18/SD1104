using System;
using System.Net.Mail;

namespace Lesson10SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson 10!");

            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("myemail@email.com");
            mail.To.Add("myotheremail@email.com");
            mail.Subject = "C# Mail";
            mail.Body = "This is for testing SMTP mail from C# application.";

            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("myemail@email.com", "xxxx xxxx xxxx xxxx");
            smtpServer.EnableSsl = true;

            smtpServer.Send(mail);
        }
    }
}
