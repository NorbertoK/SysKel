using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using Properties;

    public partial class FormReintegro : Form1
    {
        private FormPrincipal _fp;
        public FormReintegro()
        {
            InitializeComponent();
        }

        private void FormReintegroLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal)MdiParent;
            usuariosListaBindingSource.DataSource = _fp.dsUsuariosLista;
            dsEmpleadosLista.Merge(new Service().GetEmpleadosLista(Program.Pin));
            reintegrosUltraGrid.DisplayLayout.Bands[0].Columns["Fecha"].DefaultCellValue =
                new Service().HoraActual(Program.Pin);
            reintegrosUltraGrid.DisplayLayout.Bands[0].Columns["idGrabador"].DefaultCellValue = Program.IdUsuario;
            reintegrosUltraGrid.DisplayLayout.Bands[0].Columns["Importe"].DefaultCellValue = 0;
        }

        private bool Verificado()
        {
            if (reintegrosUltraGrid.Rows[0].Cells["A"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta indicar a quién se le transfieren los valores.", "Falta dato",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((decimal) reintegrosUltraGrid.Rows[0].Cells["Importe"].Value == 0)
            {
                MessageBox.Show("Faltan datos", "Faltan datos", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool Grabado()
        {
            Validate();
            reintegrosBindingSource.EndEdit();
            using (var aux = new Service().UpdateReintegro(dsReintegros, Program.Pin))
            {
                if (aux == null)
                {
                    MessageBox.Show(
                        "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                        "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                        "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    buttonAceptar.Enabled = false;
                    buttonAplicar.Enabled = false;
                    return false;
                }
                dsReintegros.Merge(aux);
            }
            ManejoDatos.AplicarUpdate(dsReintegros);
            var idReintegro = (int) dsReintegros.Reintegros.Rows[0]["idReintegro"];
            new Service().ProcesarReintegro(idReintegro, Program.Pin);
            return true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            if (Verificado())
            {
                if (Grabado())
                {
                    var f = new FormRepReintegro
                                {
                                    IdReintegro = ((int) reintegrosUltraGrid.Rows[0].Cells["idReintegro"].Value),
                                    MdiParent = MdiParent,
                                    StartPosition = FormStartPosition.Manual,
                                    Location = new Point(0, 0)
                                };
                    f.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el reintegro.", "¡Atención!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    buttonAceptar.Enabled = true;
                    buttonCancelar.Enabled = true;
                }
            }
            else
            {
                buttonAceptar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
        }

        private void ReintegrosUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "A")
            {
                if (e.Cell.Row.Cells["A"].Text != "" && e.Cell.Row.Cells["Importe"].Text != "0,00")
                {
                    buttonAceptar.Enabled = true;
                }
                else
                {
                    buttonAceptar.Enabled = false;
                }
            }
            if (e.Cell.Column.Key != "Importe" || e.Cell.Text == "0,00") return;
            if (e.Cell.Row.Cells["A"].Value != DBNull.Value)
            {
                buttonAceptar.Enabled = true;
            }
        }

        private void UltraDropDownReceptorFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void reintegrosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                reintegrosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}