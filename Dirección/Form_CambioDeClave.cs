using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Dirección.WS;

namespace Dirección
{
    using Properties;

    public partial class FormCambioDeClave : Form
    {
        public FormCambioDeClave()
        {
            InitializeComponent();
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private bool Verificado()
        {
            if (string.IsNullOrEmpty(textBoxClaveActual.Text))
            {
                MessageBox.Show(Resources.Falta_la_Clave_Actual_, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxClave.Text))
            {
                MessageBox.Show(Resources.Falta_la_Contraseña_, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxConfClave.Text))
            {
                MessageBox.Show(Resources.Tiene_que_confirmar_la_Nueva_Contraseña_, Resources.Error, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            if (textBoxClave.Text != textBoxConfClave.Text)
            {
                MessageBox.Show(Resources.La_Nueva_Contraseña_y_su_confirmación_no_son_iguales_, Resources.Error, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            var confirmaClave = new Service().ComprobarClave(Program.IdUsuario,
                                                             GenerarClaveSha1(textBoxClaveActual.Text), Program.Pin);
            if (!confirmaClave)
            {
                MessageBox.Show(Resources.La_Clave_Actual_no_es_correcta_, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            if (Verificado())
            {
                var pass = GenerarClaveSha1(textBoxClave.Text);
                new Service().CambiarClave(Program.IdUsuario, pass, Program.Pin);
                Program.Pass = pass;
                Hide();
                var texto = new FormTextoNuevaClave();
                texto.ShowDialog();
                Close();
            }
            else
            {
                buttonAceptar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
        }
    }
}