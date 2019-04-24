using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Administración.Properties;

namespace Administración
{
    public partial class CmpBajasOCambios : Component
    {
        public CmpBajasOCambios()
        {
            InitializeComponent();
        }

        public DsBajasOCambios GetAfiliadosPlanesDelGrupo(int idGrupo)
        {
            var ret = new DsBajasOCambios();
            afiliadosPlanesDelGrupoTableAdapter1.Fill(ret.AfiliadosPlanesDelGrupo, idGrupo);
            return ret;
        }

        public DsBajasOCambios UpdateBajasOCambios(DsBajasOCambios boc)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    /* Primero agrego o modifico los padres y después los hijos */
                    bajasOCambiosTableAdapter1.Update(boc.BajasOCambios.Select("", "",
                                                                               DataViewRowState.Added |
                                                                               DataViewRowState.ModifiedCurrent));
                    bajasOCambiosDetallesTableAdapter1.Update(boc.BajasOCambiosDetalles.Select("", "",
                                                                                               DataViewRowState.Added |
                                                                                               DataViewRowState.
                                                                                                   ModifiedCurrent));
                    /* Primero elimino a los hijos y después a los padres */
                    bajasOCambiosDetallesTableAdapter1.Update(boc.BajasOCambiosDetalles);
                    bajasOCambiosTableAdapter1.Update(boc.BajasOCambios);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return boc;
            }
        }

        public DsBajasOCambios GetAfiliadosDelGrupo(int idGrupo)
        {
            var ret = new DsBajasOCambios();
            afiliadosDelGrupoTableAdapter1.Fill(ret.AfiliadosDelGrupo, idGrupo);
            return ret;
        }

        public void BajasOCambios(int idBajaOCambio)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.BajasOCambiosDePlan", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xIdBajaOCambio = command.Parameters.Add("@idBajaOCambio", SqlDbType.Int);
                xIdBajaOCambio.Value = idBajaOCambio;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}