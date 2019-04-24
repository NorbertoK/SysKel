using System;
using System.Windows.Forms;

namespace Administración
{
    public partial class FormCR : Form
    {
        protected FormCR()
        {
            InitializeComponent();
        }

        private void ButtonSalirClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}