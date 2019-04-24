using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    using Properties;

    public partial class FormNuevoUsuario : Form
    {
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private bool Verificado()
        {
            if (string.IsNullOrEmpty(textBoxUsuario.Text))
            {
                MessageBox.Show("Falta el Usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxClave.Text))
            {
                MessageBox.Show("Falta la Contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxConfClave.Text))
            {
                MessageBox.Show("Tiene que confirmar la Contraseña.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            if (textBoxClave.Text != textBoxConfClave.Text)
            {
                MessageBox.Show("La Contraseña y su confirmación no son iguales.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            var existeUsuario = new Service().ExisteUsuario(textBoxUsuario.Text, Program.Pin);
            if (existeUsuario)
            {
                MessageBox.Show("El usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (!Verificado()) return;
            new Service().AgregarUsuario(textBoxUsuario.Text, GenerarClaveSha1(textBoxClave.Text), Program.Pin);
            Close();
        }

        private string GenerarClaveSha1(string clave)
        {
            // Crear una clave SHA1 como la generada por
            // FormsAuthentication.HashPasswordForStoringInConfigFile
            // Adaptada del ejemplo de la ayuda en la descripción de SHA1 (Clase)
            var enc = new UTF8Encoding();
            var data = enc.GetBytes(clave);

            var sha = new SHA1CryptoServiceProvider();
            // This is one implementation of the abstract class SHA1.
            var result = sha.ComputeHash(data);
            //
            // Convertir los valores en hexadecimal
            // cuando tiene una cifra hay que rellenarlo con cero
            // para que siempre ocupen dos dígitos.
            var sb = new StringBuilder();
            for (var i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            //
            return sb.ToString().ToUpper();
        }
    }
}