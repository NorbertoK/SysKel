using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCPuestos : Component
    {
        public CmpABCPuestos()
        {
            InitializeComponent();
        }

        public DsPuestos GetPuestos()
        {
            var ret = new DsPuestos();
            puestosTableAdapter1.Fill(ret.Puestos);
            return ret;
        }

        public DsPuestos UpdatePuestos(DsPuestos puestos)
        {
            try
            {
                puestosTableAdapter1.Update(puestos.Puestos);
            }
            catch
            {
                return null;
            }
            return puestos;
        }
    }
}