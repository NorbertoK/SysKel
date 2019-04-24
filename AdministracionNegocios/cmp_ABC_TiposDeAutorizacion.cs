using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCTiposDeAutorizacion : Component
    {
        public CmpABCTiposDeAutorizacion()
        {
            InitializeComponent();
        }

        public DsTiposDeAutorizacion GetTiposDeAutorizacion()
        {
            var ret = new DsTiposDeAutorizacion();
            tiposDeAutorizacionTableAdapter1.Fill(ret.TiposDeAutorizacion);
            return ret;
        }

        public DsTiposDeAutorizacion UpdateTiposDeAutorizacion(DsTiposDeAutorizacion tipos)
        {
            try
            {
                tiposDeAutorizacionTableAdapter1.Update(tipos.TiposDeAutorizacion);
            }
            catch
            {
                return null;
            }
            return tipos;
        }
    }
}