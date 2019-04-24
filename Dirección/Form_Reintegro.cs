using System;
using System.Drawing;
using System.Windows.Forms;
using Dirección.WS;
using Infragistics.Win.UltraWinGrid;

namespace Dirección
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
                MessageBox.Show(Resources.FormTransferencia_Verificado_Falta_indicar_a_quién_se_le_transfieren_los_valores_, Resources.FormTransferencia_Verificado_Falta_dato,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((decimal) reintegrosUltraGrid.Rows[0].Cells["Importe"].Value == 0)
            {
                MessageBox.Show(Resources.FormTransferencia_Verificado_No_está_transfiriendo_ningún_valor_, Resources.FormTransferencia_Verificado_Faltan_datos, MessageBoxButtons.OK,
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
                        Resources.Grabar_La_operación_fue_rechazada_por_la_Base_de_Datos_ + Environment.NewLine + Environment.NewLine +
                        Resources.Grabar_Probablemente_esté_intentando_eliminar_un_dato + Environment.NewLine +
                        Resources.Grabar_necesario_para_la_integridad_de_la_información, Resources.Grabar_Operación_Rechazada, MessageBoxButtons.OK,
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
                    MessageBox.Show(Resources.FormReintegro_ButtonAceptarClick_No_se_pudo_realizar_el_reintegro_, Resources.Atención, MessageBoxButtons.OK,
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
    }
}