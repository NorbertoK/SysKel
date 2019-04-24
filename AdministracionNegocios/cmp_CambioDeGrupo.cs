using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    public partial class cmp_CambioDeGrupo : Component
    {
        public cmp_CambioDeGrupo()
        {
            InitializeComponent();
        }

        public cmp_CambioDeGrupo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string FraseCambioGrupo(int idGrupo, int idAfiliado)
        {
            string Frase;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.FraseCambiarGrupo", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var grupo = command.Parameters.Add("@idGrupo", SqlDbType.Int);
                grupo.Value = idGrupo;
                var afiliado = command.Parameters.Add("@idAfiliado", SqlDbType.Int);
                afiliado.Value = idAfiliado;
                var frase = command.Parameters.Add("@frase", SqlDbType.VarChar, 200);
                frase.Direction = ParameterDirection.Output;
                connection.Open();
                command.ExecuteNonQuery();
                Frase = frase.Value.ToString();
            }
            return Frase;
        }

        public int NuevoNumeroDeGrupo(int idAfiliado, int idGrupo)
        {
            int retorno;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.CambiarAfiliadoAGrupoNuevo", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var Afiliado = command.Parameters.Add("@idAfiliado", SqlDbType.Int);
                Afiliado.Value = idAfiliado;
                var Grupo = command.Parameters.Add("@idGrupoActual", SqlDbType.Int);
                Grupo.Value = idGrupo;
                var ret = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                ret.Direction = ParameterDirection.ReturnValue;
                connection.Open();
                command.ExecuteNonQuery();
                retorno = (int) ret.Value;
            }
            return retorno;
        }

        public void CambioDeGrupo(int idAfiliado, int idGrupo)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "UPDATE dbo.Afiliados SET idGrupo = @idGrupo, Titular = 0 WHERE idAfiliado = @idAfiliado",
                        connection);
                var Afiliado = command.Parameters.Add("@idAfiliado", SqlDbType.Int);
                Afiliado.Value = idAfiliado;
                var Grupo = command.Parameters.Add("@idGrupo", SqlDbType.Int);
                Grupo.Value = idGrupo;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}