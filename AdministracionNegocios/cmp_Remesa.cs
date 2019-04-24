namespace Administración
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Transactions;
    using Properties;

    public partial class CmpRemesa : Component
    {
        public CmpRemesa()
        {
            InitializeComponent();
        }

        public DsRemesas UpdateRemesa(DsRemesas remesa)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    remesasTableAdapter1.Update(remesa.Remesas);
                    valoresRemesasTableAdapter1.Update(remesa.ValoresRemesas);
                    comprobantesRemesasTableAdapter1.Update(remesa.ComprobantesRemesas);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return remesa;
            }
        }

        public DsRemesas GetRemesas()
        {
            var ret = new DsRemesas();
            remesasTableAdapter1.Fill(ret.Remesas);
            return ret;
        }

        public int HacerRecibosRemesa(int idremesa)
        {
            int resultado;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.RecibosRemesa", connection) { CommandType = CommandType.StoredProcedure };
                var idRemesa = command.Parameters.Add("@idRemesa", SqlDbType.Int);
                idRemesa.Value = idremesa;
                var ret = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                ret.Direction = ParameterDirection.ReturnValue;
                connection.Open();
                command.ExecuteNonQuery();
                resultado = (int)ret.Value;
            }
            return resultado;
        }

        public int HacerRecibosLiquidacionEntidad(int idLiquidacionTercerizada)
        {
            int resultado;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.LiquidarEntidad", connection) { CommandType = CommandType.StoredProcedure };
                var xIdLiquidacionTercerizada = command.Parameters.Add("@idLiquidacionTercerizada", SqlDbType.Int);
                xIdLiquidacionTercerizada.Value = idLiquidacionTercerizada;
                var ret = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                ret.Direction = ParameterDirection.ReturnValue;
                connection.Open();
                command.ExecuteNonQuery();
                resultado = (int)ret.Value;
            }
            return resultado;
        }

        public string MensajeRemesa(int idComprobante, int idCobradorOrig, int idEntidadOrig)
        {
            string mensaje;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT dbo.MensajeRemesa(@idComprobante,@idCobradorOrig,@idEntidadOrig)",
                                             connection);
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                var xIdCobradorOrig = command.Parameters.Add("@idCobradorOrig", SqlDbType.Int);
                xIdCobradorOrig.Value = idCobradorOrig;
                var xIdEntidadOrig = command.Parameters.Add("@idEntidadOrig", SqlDbType.Int);
                xIdEntidadOrig.Value = idEntidadOrig;
                connection.Open();
                mensaje = command.ExecuteScalar().ToString();
            }
            return mensaje;
        }

        public string MensajeCambioDeCobrador(int idComprobante, int idCobradorOrig)
        {
            string mensaje;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT dbo.MensajeCambioDeCobrador(@idComprobante,@idCobradorOrig)",
                                             connection);
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                var xIdCobradorOrig = command.Parameters.Add("@idCobradorOrig", SqlDbType.Int);
                xIdCobradorOrig.Value = idCobradorOrig;
                connection.Open();
                mensaje = command.ExecuteScalar().ToString();
            }
            return mensaje;
        }

        public string MensajeLiquidacionTercerizada(int idComprobante, int idEntidadOrig, string periodo)
        {
            string mensaje;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT dbo.MensajeLiquidacionTercerizada(@idComprobante,@idEntidadOrig,@periodoOrig)",
                                             connection);
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                var xIdEntidadOrig = command.Parameters.Add("@idEntidadOrig", SqlDbType.Int);
                xIdEntidadOrig.Value = idEntidadOrig;
                var xPeriodo = command.Parameters.Add("@periodoOrig", SqlDbType.VarChar, 7);
                xPeriodo.Value = periodo;
                connection.Open();
                mensaje = command.ExecuteScalar().ToString();
            }
            return mensaje;
        }

        public string PrimerPeriodoSinLiquidar(int idEntidadDeCobranza)
        {
            string mensaje;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT dbo.PrimerPeriodoSinLiquidar(@idEntidadDeCobranza)",
                                             connection);
                var xIdEntidadDeCobranza = command.Parameters.Add("@idEntidadDeCobranza", SqlDbType.Int);
                xIdEntidadDeCobranza.Value = idEntidadDeCobranza;
                connection.Open();
                mensaje = command.ExecuteScalar().ToString();
            }
            return mensaje;
        }

        public double ImporteComprobanteRemesa(int idComprobante)
        {
            double importe;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var commandImporte =
                    new SqlCommand(
                        "SELECT Importe FROM dbo.Comprobantes WHERE idComprobante=@idComprobante3",
                        connection);
                var idComprobanteImporte = commandImporte.Parameters.Add("@idComprobante3", SqlDbType.Int);
                idComprobanteImporte.Value = idComprobante;
                connection.Open();
                importe = Convert.ToDouble(commandImporte.ExecuteScalar());
            }
            return importe;
        }


        public void CambiarCobrador(int idCambioDeCobrador)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.CambioDeCobrador", connection) { CommandType = CommandType.StoredProcedure };
                var xIdCambioDeCobrador = command.Parameters.Add("@idCambioDeCobrador", SqlDbType.Int);
                xIdCambioDeCobrador.Value = idCambioDeCobrador;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public string GetProceso()
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT CONVERT(varchar(255),newid())", connection);
                connection.Open();
                var ret = command.ExecuteScalar().ToString();
                return ret;
            }
        }

        public void EliminarProceso(string proceso)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("DELETE dbo.ids WHERE Proceso = @proceso", connection);
                var xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xProceso.Value = proceso;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void InsertarId(string proceso, int id, int id2)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("INSERT dbo.Ids(Proceso, Id, Id2) VALUES(@proceso, @id, @id2)", connection);
                SqlParameter xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xProceso.Value = proceso;
                SqlParameter xId = command.Parameters.Add("@id", SqlDbType.Int);
                xId.Value = id;
                SqlParameter xId2 = command.Parameters.Add("@id2", SqlDbType.Int);
                xId2.Value = id2;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DsIds GetIds(string proceso)
        {
            var ret = new DsIds();
            idsTableAdapter1.Fill(ret.ids, proceso);
            return ret;
        }

        public string PeriodoDelComprobante(int idComprobante)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand(
                    "SELECT Periodo FROM dbo.Comprobantes WHERE idComprobante = @idComprobante", connection);
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                connection.Open();
                var ret = command.ExecuteScalar().ToString();
                return ret;
            }
        }

        public double SaldoComprobante(int idComprobante)
        {
            double saldo;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT Saldo FROM dbo.Comprobantes WHERE idComprobante=@idComprobante",
                                             connection);
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                connection.Open();
                saldo = Convert.ToDouble(command.ExecuteScalar());
            }
            return saldo;
        }

        public DsRemesasVista GetRemesasVista(DateTime desde, DateTime hasta)
        {
            var ret = new DsRemesasVista();
            viewRemesasTableAdapter1.Fill(ret.View_Remesas, desde, hasta);
            return ret;
        }

        public DsLiquidacionEntidad UpdateLiquidacionEntidad(DsLiquidacionEntidad liquidacion)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    liquidacionesTercerizadaTableAdapter1.Update(liquidacion.LiquidacionesTercerizada.Select("", "",
                                                                           DataViewRowState.Added |
                                                                           DataViewRowState.ModifiedCurrent));
                    comprobantesLiquidacionTercerizadaTableAdapter1.Update(liquidacion.ComprobantesLiquidacionTercerizada);
                    liquidacionesTercerizadaTableAdapter1.Update(liquidacion.LiquidacionesTercerizada);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return liquidacion;
            }
        }
        public DsReportLiquidacionEntidad GetReportLiquidacionEntidad(int idEntidad)
        {
            var ret = new DsReportLiquidacionEntidad();
            reportLiquidacionTercerizadaTableAdapter1.Fill(ret.ReportLiquidacionTercerizada, idEntidad);
            reportComprobantesLiquidacionTercerizadaTableAdapter1.Fill(ret.ReportComprobantesLiquidacionTercerizada,idEntidad);
            return ret;
        }
        public DsReportLiquidacionEntidad GetReportLiquidacionEntidadTodos()
        {
            var ret = new DsReportLiquidacionEntidad();
            reportLiquidacionTercerizadaTableAdapter1.FillTodos(ret.ReportLiquidacionTercerizada);
            return ret;
        }
    }
}