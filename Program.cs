using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EnviarEmailSMTP
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = string.Empty;

            Console.WriteLine("Procesando...\n");

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("correo.empresa.com");

                mail.From = new MailAddress("rafael.bolanos@empresa.com.co");//desde
                mail.To.Add("bielostostzky@empresa.com.co,funcionario@empresa.com.co");//destino
                mail.Subject = "Asunto del mensaje - Test Mail";//asunto
                mail.Body = "This is for testing SMTP mail from SMTP";

                SmtpServer.Port = 25;
                //SmtpServer.UseDefaultCredentials = true;
                SmtpServer.Credentials = new System.Net.NetworkCredential("rbolanos", "Password1234");
                SmtpServer.EnableSsl = false;

                SmtpServer.Send(mail);
                mensaje = "Email enviado...\n";
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString() + "\n";
            }

            Console.WriteLine("resultado: \n" + mensaje + "\n");
            Console.WriteLine("Presione cualquier tecla para continuar");

            Console.ReadKey();
        }
    }
}
