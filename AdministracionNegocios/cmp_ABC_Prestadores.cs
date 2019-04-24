using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCPrestadores : Component
    {
        public CmpABCPrestadores()
        {
            InitializeComponent();
        }

        public DsPrestadores GetPrestadores()
        {
            var ret = new DsPrestadores();
            prestadoresTableAdapter1.Fill(ret.Prestadores);
            return ret;
        }

        public DsPrestadores UpdatePrestadores(DsPrestadores prest)
        {
            try
            {
                prestadoresTableAdapter1.Update(prest.Prestadores);
            }
            catch
            {
                return null;
            }
            return prest;
        }
    }
}