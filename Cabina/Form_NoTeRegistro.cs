using System;
using System.Windows.Forms;

namespace Cabina
{
    public partial class FormNoTeRegistro : Form
    {
        public FormNoTeRegistro()
        {
            InitializeComponent();
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}