using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCOcupaciones : Component
    {
        public CmpABCOcupaciones()
        {
            InitializeComponent();
        }

        public DsOcupaciones GetOcupaciones()
        {
            var ret = new DsOcupaciones();
            ocupacionesTableAdapter1.Fill(ret.Ocupaciones);
            return ret;
        }

        public DsOcupaciones UpdateOcupaciones(DsOcupaciones ocu)
        {
            try
            {
                ocupacionesTableAdapter1.Update(ocu.Ocupaciones);
            }
            catch
            {
                return null;
            }
            return ocu;
        }
    }
}