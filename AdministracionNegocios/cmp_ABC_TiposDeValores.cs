using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCTiposDeValores : Component
    {
        public CmpABCTiposDeValores()
        {
            InitializeComponent();
        }

        public DsTiposDeValores GetTiposDeValores()
        {
            var ret = new DsTiposDeValores();
            tiposDeValoresTableAdapter1.Fill(ret.TiposDeValores);
            return ret;
        }

        public DsTiposDeValores UpdateTiposDeValores(DsTiposDeValores tipos)
        {
            try
            {
                tiposDeValoresTableAdapter1.Update(tipos.TiposDeValores);
            }
            catch
            {
                return null;
            }
            return tipos;
        }
    }
}