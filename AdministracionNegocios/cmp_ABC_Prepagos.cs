using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCPrepagos : Component
    {
        public CmpABCPrepagos()
        {
            InitializeComponent();
        }

        public DsPrepagos GetPrepagos()
        {
            var ret = new DsPrepagos();
            prepagosTableAdapter1.Fill(ret.Prepagos);
            return ret;
        }

        public DsPrepagos UpdatePrepagos(DsPrepagos prep)
        {
            try
            {
                prepagosTableAdapter1.Update(prep.Prepagos);
            }
            catch
            {
                return null;
            }
            return prep;
        }
    }
}