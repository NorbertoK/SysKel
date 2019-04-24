using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    public partial class CmpLogin : Component
    {
        public CmpLogin()
        {
            InitializeComponent();
        }

        public CmpLogin(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public int ValidarLogin(string usuario, string clave, string pin)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                int idUsuario;
                var command =
                    new SqlCommand(
                        "SELECT idUsuario FROM dbo.Usuarios WHERE Usuario = @usuario AND clave = @clave AND Activo=1",
                        connection);
                var xUsuario = command.Parameters.Add("@usuario", SqlDbType.NVarChar);
                xUsuario.Value = usuario;
                var xClave = command.Parameters.Add("@clave", SqlDbType.NVarChar);
                xClave.Value = clave;
                connection.Open();
                try
                {
                    idUsuario = (int) command.ExecuteScalar();
                }
                catch
                {
                    return 0;
                }
                return idUsuario;
            }
        }

        public int ValidarLoginDirector(string usuario, string clave, string pin)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                int idUsuario;
                var command =
                    new SqlCommand(
                        "SELECT idUsuario FROM dbo.Usuarios WHERE Usuario = @usuario AND clave = @clave AND Activo=1 AND Director=1",
                        connection);
                var xUsuario = command.Parameters.Add("@usuario", SqlDbType.NVarChar);
                xUsuario.Value = usuario;
                var xClave = command.Parameters.Add("@clave", SqlDbType.NVarChar);
                xClave.Value = clave;
                connection.Open();
                try
                {
                    idUsuario = (int)command.ExecuteScalar();
                }
                catch
                {
                    return 0;
                }
                return idUsuario;
            }
        }

        public string NombreDelUsuario(int idUsuario)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT NombApel FROM dbo.Usuarios WHERE idUsuario = @idUsuario",
                                             connection);
                var xIdUsuario = command.Parameters.Add("@idUsuario", SqlDbType.Int);
                xIdUsuario.Value = idUsuario;
                connection.Open();
                var nombre = command.ExecuteScalar().ToString();
                return nombre;
            }
        }
    }
}