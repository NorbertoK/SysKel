using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCClientes : Component
    {
        public CmpABCClientes()
        {
            InitializeComponent();
        }

        public DsBuscarClientes GetBuscarClientes(string frase)
        {
            var ret = new DsBuscarClientes();
            buscarClientesTableAdapter1.Fill(ret.BuscarClientes, frase);
            if (ret.BuscarClientes.Count == 0)
            {
                ret.BuscarClientes.Rows.Add(0);
                ret.BuscarClientes[0].RazonSocial = "Ningún Resultado";
            }
            return ret;
        }
        public DsBuscarPlanContrato GetBuscarPlanContrato(string frase)
        {
            var ret = new DsBuscarPlanContrato();
            buscarPlanesContratoTableAdapter1.Fill(ret.BuscarPlanesContrato, frase);
            if (ret.BuscarPlanesContrato.Count == 0)
            {
                ret.BuscarPlanesContrato.Rows.Add(0);
                ret.BuscarPlanesContrato[0].RazonSocial = "Ningún Resultado";
            }
            return ret;
        }
    }
}