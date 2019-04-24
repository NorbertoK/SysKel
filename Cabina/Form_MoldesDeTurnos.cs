using System;
using System.ComponentModel;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Cabina.Properties.Resources;

namespace Cabina
{
    public partial class FormMoldesDeTurnos : Form1
    {
        public FormMoldesDeTurnos()
        {
            InitializeComponent();
        }

        private bool _renglonActivoOk;
        private void FormMoldesDeTurnosLoad(object sender, EventArgs e)
        {
            dsRecursos.Merge(new Service().GetMedicosLista(Program.Pin));
            dsMoldesDeTurnos.Merge(new Service().GetMoldesDeTurnos(Program.Pin));
        }

        private void MoldesDeTurnosUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["CadaSemanas"].Value == DBNull.Value || (int) e.Row.Cells["CadaSemanas"].Value < 2)
            {
                e.Row.Cells["DesdeSemanas"].Hidden = true;
                e.Row.Cells["DesdeSemanas"].Value = DBNull.Value;
                e.Row.Cells["Semana1"].Hidden = false;
                e.Row.Cells["Semana2"].Hidden = false;
                e.Row.Cells["Semana3"].Hidden = false;
                e.Row.Cells["Semana4"].Hidden = false;
                e.Row.Cells["Semana5"].Hidden = false;
            }
            else
            {
                e.Row.Cells["DesdeSemanas"].Hidden = false;
                e.Row.Cells["Semana1"].Hidden = true;
                e.Row.Cells["Semana2"].Hidden = true;
                e.Row.Cells["Semana3"].Hidden = true;
                e.Row.Cells["Semana4"].Hidden = true;
                e.Row.Cells["Semana5"].Hidden = true;
                e.Row.Cells["Semana1"].Value = false;
                e.Row.Cells["Semana2"].Value = false;
                e.Row.Cells["Semana3"].Value = false;
                e.Row.Cells["Semana4"].Value = false;
                e.Row.Cells["Semana5"].Value = false;
            }
        }

        private bool Grabar()
        {
            Validate();
            moldesDeTurnosBindingSource.EndEdit();
            moldesDeTurnosUltraGrid.ActiveRow = null;
            if (!_renglonActivoOk) return false;
            var aux = new Service().UpdateMoldesDeTurnos(dsMoldesDeTurnos, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." +
                    Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" +
                    Environment.NewLine +
                    "necesario para la integridad de la información",
                    "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsMoldesDeTurnos.Clear();
                dsMoldesDeTurnos.Merge(new Service().GetMoldesDeTurnos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsMoldesDeTurnos.Merge(aux);
            ManejoDatos.AplicarUpdate(dsMoldesDeTurnos);
            return true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            if(Grabar())
            buttonAplicar.Enabled = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (buttonAplicar.Enabled)
            {
                if (Grabar())
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void MoldesDeTurnosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void MoldesDeTurnosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void MoldesDeTurnosUltraGridBeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            if ((bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Lunes"].Value == false &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Martes"].Value == false &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Miercoles"].Value == false &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Jueves"].Value == false &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Viernes"].Value == false &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Sabado"].Value == false &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Domingo"].Value == false)
            {
                MessageBox.Show(
                    "Tiene que indicar por lo menos un día de la semana.",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                _renglonActivoOk = false;
                return;
            }
            if (moldesDeTurnosUltraGrid.ActiveRow.Cells["CadaSemanas"].Value == DBNull.Value &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Semana1"].Value == false &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Semana2"].Value == false &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Semana3"].Value == false &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Semana4"].Value == false &&
                (bool) moldesDeTurnosUltraGrid.ActiveRow.Cells["Semana5"].Value == false)
            {
                MessageBox.Show(
                    "Tiene que indicar en qué semanas se darán los turnos.",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                _renglonActivoOk = false;
                return;
            }
            if (String.CompareOrdinal(moldesDeTurnosUltraGrid.ActiveRow.Cells["De"].Value.ToString(), moldesDeTurnosUltraGrid.ActiveRow.Cells["A"].Value.ToString()) >= 0
                )
            {
                MessageBox.Show("El horario de finalización de la consulta tiene que ser posterior a su inicio.",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                _renglonActivoOk = false;
                return;
            }
            if (moldesDeTurnosUltraGrid.ActiveRow.Cells["CadaSemanas"].Value != DBNull.Value && moldesDeTurnosUltraGrid.ActiveRow.Cells["DesdeSemanas"].Value == DBNull.Value)
            {
                MessageBox.Show("Debe indicar una fecha de origen para la cuenta de las semanas alternas.",
                                "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                _renglonActivoOk = false;
                return;
            }
            _renglonActivoOk = true;
        }
    }
}