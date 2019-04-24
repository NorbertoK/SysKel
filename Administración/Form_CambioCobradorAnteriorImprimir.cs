using System;
using System.Drawing;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using WS;

    public partial class FormCambioCobradorAnteriorImprimir : Form1
    {
        public FormCambioCobradorAnteriorImprimir()
        {
            InitializeComponent();
        }

        private void FormCambioCobradorAnteriorImprimirLoad(object sender, EventArgs e)
        {
            dsListaCambiosDeCobrador.Merge(new Service().GetListaCambiosCobrador(Program.Pin));
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            /*Muestra el reporte*/
            var repo = new FormRepCambioDeCobrador
                           {
                               IdCambioDeCobrador = ((int) cambioCobradorUltraGrid.ActiveRow.Cells[0].Value),
                               MdiParent = MdiParent,
                               StartPosition = FormStartPosition.Manual,
                               Location = new Point(0, 0)
                           };
            repo.Show();
            Close();
        }

        private void CambioCobradorUltraGridClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void cambioCobradorUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cambioCobradorUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void cambioCobradorUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}