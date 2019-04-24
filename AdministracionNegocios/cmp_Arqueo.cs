namespace Administración
{
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Transactions;
    using Properties;

    public partial class CmpArqueo : Component
    {
        public CmpArqueo()
        {
            InitializeComponent();
        }

        public DsArqueos GetArqueos()
        {
            var ret = new DsArqueos();
            arqueosTableAdapter1.Fill(ret.Arqueos);
            return ret;
        }

        public DsArqueos UpdateArqueos(DsArqueos arq)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    arqueosTableAdapter1.Update(arq.Arqueos.Select(null, null,
                                                                   DataViewRowState.Added |
                                                                   DataViewRowState.ModifiedCurrent));
                    comprobantesArqueosTableAdapter1.Update(arq.ComprobantesArqueos);
                    arqueosTableAdapter1.Update(arq.Arqueos);
                }
                catch (InvalidExpressionException)
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return arq;
            }
        }

        public DsArqueos GetComprobantesArqueos()
        {
            var ret = new DsArqueos();
            comprobantesArqueosTableAdapter1.Fill(ret.ComprobantesArqueos);
            return ret;
        }

        public DsArqueos UpdateComprobantesArqueos(DsArqueos arq)
        {
            comprobantesArqueosTableAdapter1.Update(arq.ComprobantesArqueos);
            return arq;
        }

        public string RetirarONoComprobanteArqueo(int idComprobante)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT dbo.MotivoRetenerComprobanteArqueo(@idComprobante)", connection);
                var comprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                comprobante.Value = idComprobante;
                connection.Open();
                var frase = command.ExecuteScalar().ToString();
                return frase;
            }
        }

        public decimal TotalARendir(int idCobrador)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT dbo.TotalARendir(@idCobrador)",
                        connection);
                var cobrador = command.Parameters.Add("@idCobrador", SqlDbType.Int);
                cobrador.Value = idCobrador;
                connection.Open();
                var suma = (decimal) command.ExecuteScalar();
                return suma;
            }
        }

        public void ComprobantesFaltantesArqueo(int idArqueo)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.ComprobantesFaltantesArqueo", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var arqueo = command.Parameters.Add("@idArqueo", SqlDbType.Int);
                arqueo.Value = idArqueo;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void ComprobantesRetenidosPorBajaPasanACobradorBajas(int idArqueo)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.ComprobantesRetenidosPorBajaPasanACobradorBajas", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var arqueo = command.Parameters.Add("@idArqueo", SqlDbType.Int);
                arqueo.Value = idArqueo;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}