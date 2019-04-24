using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCTiposDeCliente : Component
    {
        public CmpABCTiposDeCliente()
        {
            InitializeComponent();
        }

        public DsTiposDeCliente GetTiposDeCliente()
        {
            var ret = new DsTiposDeCliente();
            tiposDeClienteTableAdapter1.Fill(ret.TiposDeCliente);
            return ret;
        }

        public DsTiposDeCliente UpdateTiposDeCliente(DsTiposDeCliente tipos)
        {
            try
            {
                tiposDeClienteTableAdapter1.Update(tipos.TiposDeCliente);
            }
            catch
            {
                return null;
            }
            return tipos;
        }
    }
}