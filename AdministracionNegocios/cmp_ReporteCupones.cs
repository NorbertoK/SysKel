using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    public partial class CmpReporteCupones : Component
    {
        public CmpReporteCupones()
        {
            InitializeComponent();
        }

        public DsReportComprobantes GetReportComprobantes(string periodo, int idTipoDeCobranza, int idEntidadDeCobranza,
                                                           int idCobrador, string prefijo, int idZona, string desde,
                                                           string hasta, string desdeFecha, string hastaFecha,
                                                           string todosOPendientes, string tipoComprobantes)
        {
            var ret = new DsReportComprobantes();
            comprobantesTableAdapter1.SetTimeOut();
            comprobantesTableAdapter1.Fill(ret.Comprobantes, periodo, idTipoDeCobranza, idEntidadDeCobranza, idCobrador,
                                           prefijo, idZona, desde, hasta, desdeFecha, hastaFecha, todosOPendientes, tipoComprobantes);
            return ret;
        }

        public DsReportComprobantes GetReportComprobantesPorProceso(string proceso)
        {
            var ret = new DsReportComprobantes();
            comprobantesTableAdapter1.SetTimeOut();
            comprobantesTableAdapter1.FillByProceso(ret.Comprobantes, proceso);
            return ret;
        }

        public DsComprobantesDeFacturas GetComprobantesDeFacturas(string desde, string hasta,  string comprobantes, string prefijo)
        {
            var ret = new DsComprobantesDeFacturas();
            funcReporteComprobantesDeFacturasTableAdapter1.Fill(ret.Func_ReporteComprobantesDeFacturas, desde, hasta,
                                                                 comprobantes, prefijo);
            return ret;
        }


        public DsComprobantesDeFacturas GetComprobanteDeFactura(int idComprobante)
        {
            var ret = new DsComprobantesDeFacturas();
            funcReporteComprobantesDeFacturasTableAdapter1.FillByIdComprobante(ret.Func_ReporteComprobantesDeFacturas,
                                                                               idComprobante);
            return ret;
        }

        public DsComprobantesDeFacturas GetComprobantesDeFacturasPorProceso(string proceso)
        {
            var ret = new DsComprobantesDeFacturas();
            funcReporteComprobantesDeFacturasTableAdapter1.SetTimeOut();
            funcReporteComprobantesDeFacturasTableAdapter1.FillByProceso(ret.Func_ReporteComprobantesDeFacturas,
                                                                         proceso);
            return ret;
        }
 
        public DsRepIVAVentasAfiliados GetIVAVentasAfiliados(string desde, string hasta)
        {
            var ret = new DsRepIVAVentasAfiliados();
            comprobantesIVAVentasAfiliadosTableAdapter1.Fill(ret.ComprobantesIVAVentasAfiliados, desde, hasta);
            return ret;
        }

        public DsDetalleFacturasCliente GetDetalleFacturasCliente(int idCliente)
        {
            var ret = new DsDetalleFacturasCliente();
            detalleFacturasClienteTableAdapter1.Fill(ret.DetalleFacturasCliente, idCliente);
            return ret;
        }
        public DsInformeVentas GetInformeVentas(string desde, string hasta)
        {
            var ret = new DsInformeVentas();
            informeVentasTableAdapter1.Fill(ret.InformeVentas, desde, hasta);
            return ret;
        }

        public string GetComprobantesQueTieneElCobrador(int idCobrador)
        {
            string retorno;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.ComprobantesQueTieneElCobrador", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xProceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xProceso.Direction = ParameterDirection.Output;
                var xIdCobrador = command.Parameters.Add("@idCobrador", SqlDbType.Int);
                xIdCobrador.Value = idCobrador;
                connection.Open();
                command.ExecuteNonQuery();
                retorno = xProceso.Value.ToString();
            }
            return retorno;
        }
    }
}