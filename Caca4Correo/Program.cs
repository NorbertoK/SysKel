using System;
namespace Caca4Correo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            dynamic PyEmail = Activator.CreateInstance(Type.GetTypeFromProgID("PyEmail"));

// Primer paso: conexión al servidor (por unica vez)
            const string servidor = "mail.kelijman.com";
            const string usuario = "norberto@kelijman.com";
            const string clave = "mFqzHGKPLmb3";
            PyEmail.Conectar(servidor, usuario, clave);

// Envio el o los correos (repetir por cada FE)
            var remitente = "norberto@kelijman.com";
            var motivo = "Factura 1";
            var destinatario = "norberto@kelijman.com";
            var mensaje = "Se envia factura electronica adjunta";
            var archivo = "D:\\PDFs\\FacturaA-0003-00000001.pdf";

            PyEmail.Enviar(remitente, motivo, destinatario, mensaje, archivo);
        }
    }
}