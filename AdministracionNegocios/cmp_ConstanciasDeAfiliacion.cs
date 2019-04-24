using System.ComponentModel;

namespace Administración
{
    public partial class CmpConstanciasDeAfiliacion : Component
    {
        public CmpConstanciasDeAfiliacion()
        {
            InitializeComponent();
        }


        public DsClientesConContratoActivoYPlan GetClientesConContratoActivoYPlan()
        {
            var ret = new DsClientesConContratoActivoYPlan();
            clientesConContratoActivoYPlanTableAdapter1.Fill(ret.Clientes);
            return ret;
        }

        public DsClientesConContratoActivoYPlan GetContratosActivosConPlan(int idCliente)
        {
            var ret = new DsClientesConContratoActivoYPlan();
            contratosActivosConPlanTableAdapter1.Fill(ret.Contratos, idCliente);
            return ret;
        }

        public DsClientesConContratoActivoYPlan GetPlanesDeUnContrato(int idContrato)
        {
            var ret = new DsClientesConContratoActivoYPlan();
            planesDeUnContratoTableAdapter1.Fill(ret.Planes, idContrato);
            return ret;
        }

        public DsRepConstanciasAfiliacion GetConstanciasAfiliacion(string periodo, int idCliente, int idContrato,
                                                                     int idPlan)
        {
            var ret = new DsRepConstanciasAfiliacion();
            constanciasAfiliacionTableAdapter1.SetTimeOut();
            constanciasAfiliacionTableAdapter1.Fill(ret.ConstanciasAfiliacion, periodo, idCliente, idContrato, idPlan);
            return ret;
        }
    }
}