using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dirección
{
    using WS;

    public partial class FormReporteEstadisticaPlanes : Form1
    {
        public FormReporteEstadisticaPlanes()
        {
            InitializeComponent();
        }

        private void FormReporteEstadisticaPlanesLoad(object sender, EventArgs e)
        {
            ultraDateTimeEditorFecha.Value = new Service().HoraActual(Program.Pin);
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var f = new FormRepEstadisticaPlanes
                        {
                            Fecha = (DateTime)ultraDateTimeEditorFecha.Value,
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
            Close();
        }
    }
}
