using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCTiposDeContrato : Component
    {
        public CmpABCTiposDeContrato()
        {
            InitializeComponent();
        }

        public DsTiposDeContrato GetTiposDeContrato()
        {
            var ret = new DsTiposDeContrato();
            tiposDeContratoTableAdapter1.Fill(ret.TiposDeContrato);
            return ret;
        }

        public DsTiposDeContrato UpdateTiposDecontrato(DsTiposDeContrato tipos)
        {
            try
            {
                tiposDeContratoTableAdapter1.Update(tipos.TiposDeContrato);
            }
            catch
            {
                return null;
            }
            return tipos;
        }
    }
}