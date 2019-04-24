using System;
using System.Drawing;
using System.Windows.Forms;

namespace Administración
{

    public partial class FormReporteDatosPrestaciones : Form1
    {
        public FormReporteDatosPrestaciones()
        {
            InitializeComponent();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonCancelar.Visible = false;
            buttonAceptar.Visible = false;
            labelEspere.Visible = true;
            labelEspere.Update();
            var f = new FormRepDatosPrestaciones
            {
                Desde = (DateTime)ultraDateTimeEditorDesde.Value,
                Hasta = (DateTime)ultraDateTimeEditorHasta.Value,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
            Close();
        }
    }
}
