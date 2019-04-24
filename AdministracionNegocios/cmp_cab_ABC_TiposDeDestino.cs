using System.ComponentModel;

namespace Administración
{
    public partial class CmpCabABCTiposDeDestino : Component
    {
        public CmpCabABCTiposDeDestino()
        {
            InitializeComponent();
        }

        public DsTiposDeDestino GetTiposDeDestino()
        {
            var ret = new DsTiposDeDestino();
            tiposDeDestinoTableAdapter1.Fill(ret.TiposDeDestino);
            return ret;
        }

        public DsTiposDeDestino UpdateTiposDeDestino(DsTiposDeDestino tipos)
        {
            try
            {
                tiposDeDestinoTableAdapter1.Update(tipos.TiposDeDestino);
                return tipos;
            }
            catch
            {
                return null;
            }
        }
    }
}