using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormCaja : Form1
    {
        public FormCaja()
        {
            InitializeComponent();
        }
        private FormPrincipal _fp;
        private void FormCajaLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal)MdiParent;
            var ahora = new Service().HoraActual(Program.Pin);
            ultraDateTimeEditorDesde.Value = ahora;
            ultraDateTimeEditorHasta.Value = ahora;
            empleadosListaBindingSource.DataSource = _fp.dsEmpleadosLista;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var f = new FormRepCaja
                        {
                            IdEmpleado = ((int) ultraComboEmpleados.ActiveRow.Cells["idEmpleado"].Value),
                            Desde = ((DateTime) ultraDateTimeEditorDesde.Value),
                            Hasta = ((DateTime) ultraDateTimeEditorHasta.Value),
                            Titulo = ("Caja " + ultraComboEmpleados.ActiveRow.Cells["NombApel"].Value),
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
            Close();
        }

        private void UltraComboEmpleadosRowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonAceptar.Enabled = true;
        }
    }
}