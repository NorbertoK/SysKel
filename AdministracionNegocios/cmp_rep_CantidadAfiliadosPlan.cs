using System.ComponentModel;

namespace Administración
{
    public partial class CmpRepCantidadAfiliadosPlan : Component
    {
        public CmpRepCantidadAfiliadosPlan()
        {
            InitializeComponent();
        }

        public DsRepCantidadAfiliadosPlan GetCantidadAfiliadosPorPlan(string fecha)
        {
            var ret = new DsRepCantidadAfiliadosPlan();
            cantidadAfiliadosPlanTableAdapter1.SetTimeOut();
            cantidadAfiliadosPlanTableAdapter1.Fill(ret.Cantidad, fecha);
            return ret;
        }

        public DsFacturadoClientes GetFacturadoClientes(string periodoDesde, string periodoHasta)
        {
            var ret = new DsFacturadoClientes();
            facturadoPorPeriodoYRubroTableAdapter1.Fill(ret.FacturadoPorPeriodoYRubro, periodoDesde, periodoHasta);
            return ret;
        }

        public DsRepListadoPorPlan GetListadoPorPlan(int idPlan, string fecha)
        {
            var ret = new DsRepListadoPorPlan();
            listadoPorPlanTableAdapter1.SetTimeOut();
            listadoPorPlanTableAdapter1.Fill(ret.ListadoPorPlan, idPlan, fecha);
            return ret;
        }
        public DsEstadisticaCantidadDeAfiliados GetEstadisticaCantidadDeAfiliados(string periodoDesde, string periodoHasta, string modo, int idPlan, string contar)
        {
            var ret = new DsEstadisticaCantidadDeAfiliados();
            estadisticaCantidadDeAfiliadosTableAdapter1.Fill(ret.EstadisticaCantidadDeAfiliados, periodoDesde,
                                                             periodoHasta, modo, idPlan, contar);
            return ret;
        }
    }
}
