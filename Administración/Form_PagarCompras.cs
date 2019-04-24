using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormPagarCompras : Form1
    {
        private string _proceso;
        public FormPagarCompras()
        {
            InitializeComponent();
        }

        private void FormPagarComprasLoad(object sender, EventArgs e)
        {
            dsProveedores.Merge(new Service().GetProveedoresActivos(Program.Pin));
            _proceso = new Service().GetProceso(Program.Pin);
        }

        private void ProveedoresUltraComboValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            labelMensaje.Text = "Un momentito...";
            labelMensaje.Update();
            if (proveedoresUltraCombo.Value == DBNull.Value)
            {
                dsComprasImpagas.Clear();
                labelMensaje.Visible = false;
                labelMensaje.Update();
                comprasImpagasUltraGrid.Enabled = false;
            }
            else
            {
                dsComprasImpagas.Clear();
                dsComprasImpagas.Merge(
                    new Service().GetComprasImpagas((int)proveedoresUltraCombo.Value, Program.Pin));
                if (comprasImpagasUltraGrid.Rows.Count == 0)
                {
                    labelMensaje.Text = "No hay compras con saldo";
                    labelMensaje.Visible = true;
                    labelMensaje.Update();
                    comprasImpagasUltraGrid.Enabled = false;
                }
                else
                {
                    comprasImpagasUltraGrid.Enabled = true;
                    comprasImpagasUltraGrid.Rows[0].Activate();
                    comprasImpagasUltraGrid.ActiveRow = null;
                    labelMensaje.Text = "Marque las compras que pagará:";
                    labelMensaje.Visible = true;
                    labelMensaje.Update();
                }
            }
        }

        private void ComprasImpagasUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "Marca") return;
            comprasImpagasUltraGrid.Update();
            if ((bool)comprasImpagasUltraGrid.ActiveRow.Cells["Marca"].Value == false)
            {
                comprasImpagasUltraGrid.ActiveRow.Cells["Marca"].Value = true;
                buttonAceptar.Enabled = true;
            }
            else
            {
                comprasImpagasUltraGrid.ActiveRow.Cells["Marca"].Value = false;
                var marcas = 0;
                foreach (var row in comprasImpagasUltraGrid.Rows)
                {
                    if ((bool)row.Cells["Marca"].Value)
                    {
                        marcas++;
                    }
                    buttonAceptar.Enabled = marcas != 0;
                }
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            Hide();
            foreach (var row in comprasImpagasUltraGrid.Rows)
            {
                if ((bool)row.Cells["Marca"].Value)
                {
                    new Service().InsertarId(_proceso, (int)row.Cells["idCompra"].Value, 0, Program.Pin);
                }
            }
            var f = new FormOrdenDePago
            {
                Proceso = _proceso,
                Tag = "Varios",
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
            Close();
        }

        private void proveedoresUltraCombo_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            proveedoresUltraCombo.DisplayLayout.Bands[0].Columns["NombreCompleto"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void comprasImpagasUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comprasImpagasUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
