using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCTiposDeCobranza : Component
    {
        public CmpABCTiposDeCobranza()
        {
            InitializeComponent();
        }

        public DsTiposDeCobranza GetTiposDeCobranza()
        {
            var ret = new DsTiposDeCobranza();
            tiposDeCobranzaTableAdapter1.Fill(ret.TiposDeCobranza);
            return ret;
        }

        public DsTiposDeCobranza UpdateTiposDeCobranza(DsTiposDeCobranza tipos)
        {
            try
            {
                tiposDeCobranzaTableAdapter1.Update(tipos.TiposDeCobranza);
            }
            catch
            {
                return null;
            }
            return tipos;
        }
    }
}