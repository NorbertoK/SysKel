using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    public partial class cmp_NuevoUsuario : Component
    {
        public cmp_NuevoUsuario()
        {
            InitializeComponent();
        }

        public cmp_NuevoUsuario(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool existeUsuario(string usuario)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT count(*) FROM Usuarios WHERE Usuario = @usuario", connection);
                var _usuario = command.Parameters.Add("@usuario", SqlDbType.NVarChar);
                _usuario.Value = usuario;
                connection.Open();
                var cuantos = (int) command.ExecuteScalar();
                return cuantos != 0;
            }
        }

        public void agregarUsuario(string usuario, string clave)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("INSERT dbo.Usuarios (Usuario, Clave) VALUES (@usuario, @clave)",
                                             connection);
                var _usuario = command.Parameters.Add("@usuario", SqlDbType.NVarChar);
                _usuario.Value = usuario;
                var _clave = command.Parameters.Add("@clave", SqlDbType.NVarChar);
                _clave.Value = clave;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}