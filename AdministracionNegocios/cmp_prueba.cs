using System.ComponentModel;

namespace Administración
{
    public partial class cmp_prueba : Component
    {
        public cmp_prueba()
        {
            InitializeComponent();
        }

        public cmp_prueba(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public DsPrueba prueba()
        {
            var ret = new DsPrueba();
            dataTable1TableAdapter1.Fill(ret.DataTable1);
            return ret;
        }
    }
}