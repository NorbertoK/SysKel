using System;
using System.Windows.Forms;

namespace Cabina
{
    public partial class FormCR : Form
    {
        public FormCR()
        {
            InitializeComponent();
        }

        private void ButtonSalirClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}