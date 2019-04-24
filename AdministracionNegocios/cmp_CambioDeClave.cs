using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    public partial class CmpCambioDeClave : Component
    {
        public CmpCambioDeClave()
        {
            InitializeComponent();
        }

        public CmpCambioDeClave(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool ComprobarClave(int idUsuario, string clave)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand("SELECT count(*) FROM dbo.Usuarios WHERE idUsuario=@idusuario AND clave=@clave",
                                   connection);
                var xIdUsuario = command.Parameters.Add("@idUsuario", SqlDbType.Int);
                xIdUsuario.Value = idUsuario;
                var xClave = command.Parameters.Add("@clave", SqlDbType.NVarChar);
                xClave.Value = clave;
                connection.Open();
                var cuantos = (int) command.ExecuteScalar();
                return cuantos != 0;
            }
        }

        public void CambiarClave(int idUsuario, string clave)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("UPDATE dbo.Usuarios SET clave = @clave WHERE idUsuario = @idUsuario",
                                             connection);
                var xIdUsuario = command.Parameters.Add("@idUsuario", SqlDbType.Int);
                xIdUsuario.Value = idUsuario;
                var xClave = command.Parameters.Add("@clave", SqlDbType.NVarChar);
                xClave.Value = clave;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}