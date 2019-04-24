using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace EnviarCorreo
{
    internal class ClsMail
    {
        public static void Main(string[] args)
        {
            if(Enviar())
                Console.WriteLine("OK");
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();
        }

        public static bool Enviar()
        {
            //Ruta de archivo adjunto (Si lo lleva)
            const string pathFile = @"D:\PDFs\FacturaA-0003-00000001.pdf";

            //Creo el mensaje del mail.
            var msg = new MailMessage();

            //Agrego los destinatarios, pueden ir varios
            msg.To.Add("norberto@kelijman.com");

            //Agrego la direccion del que manda el email, puede ser falsa o verdadera, pero si es falsa puede que el servidor de correo lo detecte como spam, tambien depende de las credenciales que se ponen mas abajo
            msg.From = new MailAddress("estelayasky@gmail.com", "Estela Yasky", Encoding.UTF8);

            //Pongo el asunto
            msg.Subject = "Factura";
            msg.SubjectEncoding = Encoding.UTF8;

            //Escribo el mensaje Y su codificacion
            msg.Body = "Adjuntamos su factura.";
            msg.BodyEncoding = Encoding.UTF8;

            //Especifico si va ha ser interpertado con HTML
            msg.IsBodyHtml = false;

            //Agrego el archivo que puse en la ruta anterior "PathFile", y su tipo.
            var data = new Attachment(pathFile, MediaTypeNames.Application.Pdf);

            //Obtengo las propiedades del archivo.
            var disposition = data.ContentDisposition;
            disposition.CreationDate = File.GetCreationTime(pathFile);
            disposition.ModificationDate = File.GetLastWriteTime(pathFile);
            disposition.ReadDate = File.GetLastAccessTime(pathFile);
            //Agrego el archivo al mensaje
            msg.Attachments.Add(data);

            //Creo un objeto de tipo cliente de correo (Por donde se enviara el correo)
            var client = new SmtpClient
            {
                Credentials = new NetworkCredential("estelayasky@gmail.com", "19estela"),
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true
            };
            try
            {
                //Envio el mensaje
                client.Send(msg);
                return true;
            }
            catch (SmtpException)
            {
                return false;
            }
        }
    }
}