using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace Encriptador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Encriptar(string texto)
        {
            const string key = "ABCDEFGHIJKLMÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz";
            var arregloACifrar = Encoding.UTF8.GetBytes(texto);
            var hashmd5 = new MD5CryptoServiceProvider();
            var keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            var tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            var cTransform = tdes.CreateEncryptor();
            var arrayResultado = cTransform.TransformFinalBlock(arregloACifrar, 0, arregloACifrar.Length);
            tdes.Clear();
            return Convert.ToBase64String(arrayResultado, 0, arrayResultado.Length);
        }

        private void Button1Click(object sender, EventArgs e)
        {
            var azar = new Random();
            var veces = azar.Next(7);
            var sb = new StringBuilder();
            for (var i = 0; i < veces; i++)
                sb.Append("_");
            var cadenita = sb.ToString();
            var azar1 = new Random();
            var veces1 = azar1.Next(7);
            var sb1 = new StringBuilder();
            for (var i = 0; i < veces1; i++)
                sb1.Append("_");
            var cadena = sb.ToString();
            cadena += String.Format("{0:yyyyMMdd}", (DateTime) ultraCalendarVigencia.Value);
            cadena += ultraCombo1.Text;
            cadena += cadenita;
            textBox2.Text = Encriptar(cadena);
            textBox2.Update();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            ultraCalendarVigencia.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Encriptar(textBox1.Text);
            textBox3.Update();
        }
    }
}