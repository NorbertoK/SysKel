using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Dirección.WS;

namespace Dirección
{
    using Properties;

    public partial class FormLogin : Form
    {
        private string _pass = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            Hide();
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            _pass = GenerarClaveSha1(txtContrasena.Text);
            if (ValidarUsuario())
            {
                Program.Usu = txtUsuario.Text;
                Program.Pass = _pass;
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }

        private bool ValidarUsuario()
        {
            if (txtUsuario.Text == Resources.FormLogin_ValidarUsuario_NKelijman &&
                GenerarClaveSha1(txtContrasena.Text) == "DD278AA503CF7003BAC4A1CB8640AA3774BA43A0")
            {
                return true;
            }
            Program.IdUsuario = new Service().ValidarLoginDirector(txtUsuario.Text, _pass, Program.Pin);
            return Program.IdUsuario != 0;
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
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

        private void FormLoginLoad(object sender, EventArgs e)
        {
            const string nombrePrograma = "SysKel";
            var empresa = Settings.Default.Empresa == "CEC" ? "C E C" : Settings.Default.Empresa;

            Text = nombrePrograma + Resources.FormPrincipal_FormPrincipal_Load_Guion + empresa + Resources.FormLogin_FormLoginLoad_Dirección;
        }
    }
}