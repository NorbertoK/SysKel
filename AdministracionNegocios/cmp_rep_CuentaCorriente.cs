using System.ComponentModel;

namespace Administración
{
    public partial class CmpRepCuentaCorriente : Component
    {
        public CmpRepCuentaCorriente()
        {
            InitializeComponent();
        }

        public DsCuentaCorriente GetCuentaCorriente(string grupoOCliente, int id)
        {
            var ret = new DsCuentaCorriente();
            cuentaCorrienteTableAdapter1.Fill(ret.CuentaCorriente, grupoOCliente, id);
            return ret;
        }
    }
}