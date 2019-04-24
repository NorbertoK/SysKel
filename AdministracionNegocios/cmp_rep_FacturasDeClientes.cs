using System.ComponentModel;

namespace Administración
{
    public partial class CmpRepFacturasDeClientes : Component
    {
        public CmpRepFacturasDeClientes()
        {
            InitializeComponent();
        }

        public DsRepFacturasDeClientes GetFacturasDeClientes(string periodo, int idPuntoDeVenta)
        {
            var ret = new DsRepFacturasDeClientes();
            facturasDeClientesTableAdapter1.SetTimeOut();
            facturasDeClientesTableAdapter1.Fill(ret.FacturasDeClientes, periodo, idPuntoDeVenta);
            return ret;
        }
    }
}