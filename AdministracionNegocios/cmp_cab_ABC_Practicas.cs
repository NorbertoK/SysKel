using System.ComponentModel;

namespace Administración
{
    public partial class CmpCabABCPracticas : Component
    {
        public CmpCabABCPracticas()
        {
            InitializeComponent();
        }

        public DsPracticas GetPracticas()
        {
            var ret = new DsPracticas();
            practicasTableAdapter1.Fill(ret.Practicas);
            return ret;
        }

        public DsPracticas UpdatePracticas(DsPracticas practi)
        {
            try
            {
                practicasTableAdapter1.Update(practi.Practicas);
            }
            catch
            {
                return null;
            }
            return practi;
        }
    }
}