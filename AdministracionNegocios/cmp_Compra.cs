using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Administración.Properties;

namespace Administración
{
    public partial class CmpCompra : Component
    {
        public CmpCompra()
        {
            InitializeComponent();
        }

        public DsCompra UpdateCompra(DsCompra compra)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    comprasTableAdapter1.Update(compra.Compras.Select("", "",
                                                                DataViewRowState.Added |
                                                                DataViewRowState.ModifiedCurrent));
                    negociosComprasTableAdapter1.Update(compra.NegociosCompras);
                    ivaComprasTableAdapter1.Update(compra.IVACompras);
                    libroDiarioCompraTableAdapter1.Update(compra.LibroDiarioCompra);
                    comprasTableAdapter1.Update(compra.Compras);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return compra;
            }
        }

        public DsOrdenDePago GetOrdenesDePago()
        {
            var ret = new DsOrdenDePago();
            ordenesDePagoTableAdapter1.Fill(ret.OrdenesDePago);
            return ret;
        }
        public DsOrdenDePago GetOrdenDePago(int idOrdenDePago)
        {
            var ret = new DsOrdenDePago();
            ordenesDePagoTableAdapter1.FillBy(ret.OrdenesDePago, idOrdenDePago);
            comprobantesOrdenesDePagoTableAdapter1.FillBy(ret.ComprobantesOrdenesDePago, idOrdenDePago);
            valoresOrdenDePagoTableAdapter1.FillBy(ret.ValoresOrdenDePago, idOrdenDePago);
            libroDiarioOrdenDepagoTableAdapter1.FillBy(ret.LibroDiarioOrdenDePago, idOrdenDePago);
            return ret;
        }
        public DsOrdenDePago GetCompraDelPago(int idCompra)
        {
            var ret = new DsOrdenDePago();
            comprasElegidasTableAdapter1.Fill(ret.ComprasElegidas, idCompra);
            return ret;
        }
        public DsOrdenDePago GetComprasDelPago(string proceso)
        {
            var ret = new DsOrdenDePago();
            comprasElegidasTableAdapter1.FillByProceso(ret.ComprasElegidas, proceso);
            return ret;
        }
        public DsOrdenDePago UpdateOrdenDePago(DsOrdenDePago ordenDePago)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    ordenesDePagoTableAdapter1.Update(ordenDePago.OrdenesDePago.Select("", "",
                                                                DataViewRowState.Added |
                                                                DataViewRowState.ModifiedCurrent));
                    comprobantesOrdenesDePagoTableAdapter1.Update(ordenDePago.ComprobantesOrdenesDePago);
                    valoresOrdenDePagoTableAdapter1.Update(ordenDePago.ValoresOrdenDePago);
                    libroDiarioOrdenDepagoTableAdapter1.Update(ordenDePago.LibroDiarioOrdenDePago);
                    ordenesDePagoTableAdapter1.Update(ordenDePago.OrdenesDePago);
                    using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
                    {
                        var command = new SqlCommand("dbo.ProcesarOrdenDePago", connection) { CommandType = CommandType.StoredProcedure };
                        var xIdOrdenDepago = command.Parameters.Add("@idOrdenDePago", SqlDbType.Int);
                        xIdOrdenDepago.Value = ordenDePago.OrdenesDePago.Rows[0]["idOrdenDePago"];
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return ordenDePago;
            }
        }
        public DsComprasImpagas GetComprasImpagas(int idProveedor)
        {
            var ret = new DsComprasImpagas();
            comprasImpagasTableAdapter1.Fill(ret.ComprasImpagas, idProveedor);
            return ret;
        }
        public DsComprasImpagas UpdateComprobantesDePagoImpagos(DsComprasImpagas pago)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    comprasImpagasTableAdapter1.Update(pago.ComprasImpagas);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return pago;
            }
        }
        public DsRubros GetRubros()
        {
            var ret = new DsRubros();
            rubrosTableAdapter1.Fill(ret.Rubros);
            return ret;
        }

        public DsRubros GetRubrosQueAdmitenValores()
        {
            var ret = new DsRubros();
            rubrosTableAdapter1.FillByAdmiteValores(ret.Rubros);
            return ret;
        }
        public DsRubros UpdateRubros(DsRubros rub)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    rubrosTableAdapter1.Update(rub.Rubros);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return rub;
            }
        }
        public DsNegocios GetNegocios()
        {
            var ret = new DsNegocios();
            negociosTableAdapter1.Fill(ret.Negocios);
            return ret;
        }
        public DsNegocios UpdateNegocios(DsNegocios neg)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    negociosTableAdapter1.Update(neg.Negocios);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return neg;
            }
        }
        public DsReportPago GetReportPago(int idPago)
        {
            var ret = new DsReportPago();
            repPagoTableAdapter1.Fill(ret.RepPago,idPago);
            repPagoComprasTableAdapter1.Fill(ret.RepPagoCompras, idPago);
            repPagoValoresTableAdapter1.Fill(ret.RepPagoValores, idPago);
            return ret;
        }
        public DsCuentaCorrienteProveedor GetCuentaCorrienteProveedor (int idProveedor)
        {
            var ret = new DsCuentaCorrienteProveedor();
            cuentaCorrienteProveedorTableAdapter1.Fill(ret.CuentaCorrienteProveedor, idProveedor);
            return ret;
        }
        public DsReporteRubrosNegocios GetReporteRubrosNegocios(string desde, string hasta)
        {
            var ret = new DsReporteRubrosNegocios();
            reporteRubroNegociosTableAdapter1.Fill(ret.ReporteRubrosNegocios,desde,hasta);
            return ret;
        }
        public bool EsBanco(int idEmpleado)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT dbo.EsBanco(@idEmpleado)",
                        connection);
                var empleado = command.Parameters.Add("@idEmpleado", SqlDbType.Int);
                empleado.Value = idEmpleado;
                connection.Open();
                var es = (bool)command.ExecuteScalar();
                return es;
            }
        }
    }
}