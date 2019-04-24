using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCZonas : Component
    {
        public CmpABCZonas()
        {
            InitializeComponent();
        }

        public DsZonas GetZonas()
        {
            var ret = new DsZonas();
            zonasTableAdapter1.Fill(ret.Zonas);
            return ret;
        }

        public DsZonas UpdateZonas(DsZonas zon)
        {
            try
            {
                zonasTableAdapter1.Update(zon.Zonas);
            }
            catch
            {
                return null;
            }
            return zon;
        }

        public DsLocalidades GetLocalidades()
        {
            var ret = new DsLocalidades();
            localidadesTableAdapter1.Fill(ret.Localidades);
            return ret;
        }

        public DsZonasLista GetZonasLista()
        {
            var ret = new DsZonasLista();
            viewZonasTableAdapter1.Fill(ret.View_Zonas);
            return ret;
        }
    }
}