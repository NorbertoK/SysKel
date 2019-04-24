using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    using WS;
    static class Program
    {
        public static int IdUsuario;
        public static string Usu;
        public static string Pass;
        public static string Pin = "pipopescador";
        public static DateTime VigenciaLicencia;
        public static bool TieneLicencia;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var frmLogin = new FormLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                frmLogin.Close();
                Application.Run(new FormPrincipalCabina());
            }
            else if (frmLogin.DialogResult == DialogResult.No)
            {
                var noTeRegistro = new FormNoTeRegistro();
                noTeRegistro.ShowDialog();
            }
        }
    }
    class CCryptorEngine
    {
        private const string Key = "ABCDEFGHIJKLMÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz";
        public string Encriptar(string texto)
        {
            var arregloACifrar = Encoding.UTF8.GetBytes(texto);
            var hashmd5 = new MD5CryptoServiceProvider();
            var keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(Key));
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

        public static string Desencriptar(string textoEncriptado)
        {
            try
            {
                var arrayADescifrar = Convert.FromBase64String(textoEncriptado);
                var hashmd5 = new MD5CryptoServiceProvider();
                var keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(Key));
                hashmd5.Clear();
                var tdes = new TripleDESCryptoServiceProvider
                {
                    Key = keyArray,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
                var cTransform = tdes.CreateDecryptor();
                var resultArray = cTransform.TransformFinalBlock(arrayADescifrar, 0, arrayADescifrar.Length);
                tdes.Clear();
                var res = Encoding.UTF8.GetString(resultArray);
                return res;
            }
            catch (Exception)
            {
                return "Cualquier verdura.";
            }
        }
    }
    internal static class Encriptacion
    {
        public static DateTime FechaVigencia(string cadena)
        {
            if (CCryptorEngine.Desencriptar(cadena).Replace("_", "").Substring(8) == Properties.Settings.Default.Empresa)
            {
                try
                {
                    return DateTime.ParseExact(CCryptorEngine.Desencriptar(cadena).Replace("_", "").Substring(0, 8), "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                }
                catch
                {

                    return new DateTime(1947, 1, 21);
                }
            }
            return new DateTime(1947, 1, 21);
        }
        public static bool TieneLicenciaVigente()
        {
            var ahora = new Service().HoraActual(Program.Pin);
            return Program.TieneLicencia && Program.VigenciaLicencia.AddDays(1) > ahora;
        }
    }
    static class ManejoDatos
    {
        public static void AplicarUpdate(DataSet ds)
        {
            var lista = new System.Collections.ArrayList();

            ds.EnforceConstraints = false;
            foreach (DataTable tabla in ds.Tables)
            {
                foreach (var row in tabla.Select(null, null, DataViewRowState.Added))
                {
                    lista.Add(row);
                }
            }
            foreach (DataRow row in lista)
            {
                if (row != null)
                    row.RejectChanges();
            }
            ds.AcceptChanges();
            ds.EnforceConstraints = true;
        }
        public static string Edad(DateTime fechanac)
        {
            var ahora = new Service().HoraActual(Program.Pin);
            // Calculamos la diferencia de años
            var anyos = ahora.Year - fechanac.Year;
            // Restamos un año si estamos antes de el
            // día de nacimiento en el año actual
            if (ahora.Month < fechanac.Month || (ahora.Month == fechanac.Month && ahora.Day < fechanac.Day))
            {
                anyos--;
            }
            if (anyos > 0)
            {
                return anyos + " años";
            }
            var meses = ahora.Month - fechanac.Month;
            if (meses < 0)
            {
                meses = meses + 12;
            }
            if (ahora.Day < fechanac.Day)
            {
                meses--;
            }
            if (meses > 0)
            {
                return meses + " meses";
            }
            var dias = ahora - fechanac;
            return dias.Days + " días";
        }
        public static string SoloNumeros(string frase)
        {
            const string numeros = "0123456789";
            var ret = "";
            var n = 0;
            while (n < frase.Length)
            {
                if (numeros.Contains(frase.Substring(n, 1)))
                {
                    ret = ret + frase.Substring(n, 1);
                }
                n = n + 1;
            }
            return ret;
        }
        public static bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }
        public static void SeleccionInicio(object ugrid)
        {
            if (((UltraGrid)ugrid).ActiveCell.Value.GetType().ToString() == "System.Boolean" ||
                ((UltraGrid)ugrid).ActiveCell.Value.GetType().ToString() == "System.DBNull") return;
            ((UltraGrid)ugrid).ActiveCell.SelStart = 0;
            ((UltraGrid)ugrid).ActiveCell.SelLength = ((UltraGrid)ugrid).ActiveCell.Value == DBNull.Value
                ? 0
                : ((UltraGrid)ugrid).ActiveCell.Text.Length;
        }
    }
}