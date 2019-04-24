using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCTiposDeComprobante : Component
    {
        public CmpABCTiposDeComprobante()
        {
            InitializeComponent();
        }

        public DsTiposDeComprobante GetTiposDeComprobante()
        {
            var ret = new DsTiposDeComprobante();
            tiposDeComprobanteTableAdapter1.Fill(ret.TiposDeComprobante);
            return ret;
        }

        public DsTiposDeComprobante UpdateTiposDeComprobante(DsTiposDeComprobante tipos)
        {
            try
            {
                tiposDeComprobanteTableAdapter1.Update(tipos.TiposDeComprobante);
            }
            catch
            {
                return null;
            }
            return tipos;
        }
    }
}