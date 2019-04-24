namespace Administración
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using WS;
    using Infragistics.Win.UltraWinGrid;

    public partial class FormReportEstadoDeLaCobranza : Form
    {
        public FormReportEstadoDeLaCobranza()
        {
            InitializeComponent();
        }

        private void FormReportEstadoDeLaCobranzaLoad(object sender, EventArgs e)
        {
            ultraCalendarComboFecha.Value = new Service().HoraActual(Program.Pin);
            ultraNumericEditorMeses.Value = 0;
            dsEmpleadosLista.Merge(new Service().GetCobradores(Program.Pin));
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var f = new FormRepEstadoDeLaCobranza
                        {
                            Cobrador =
                                ultraComboCobradores.Value==null ? "Todos los Cobradores" : dsEmpleadosLista.EmpleadosLista.FindByidEmpleado((int) ultraComboCobradores.Value).
                                NombApel,
                            Fecha = (DateTime) ultraCalendarComboFecha.Value,
                            IdCobrador = ultraComboCobradores.Value==null ? 0 : (int) ultraComboCobradores.Value,
                            Meses = (int)ultraNumericEditorMeses.Value,
                            MostrarFuturo = ultraCheckEditorMostrarFuturo.Checked?"S":"N",
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
            Close();
        }

        private void UltraComboCobradoresFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            if (ultraCheckEditorInactivos.Checked)
            {
                e.RowFilteredOut = false;
            }
            else
            {
                e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
            }
        }

        private void UltraComboCobradoresBeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraComboCobradores.DisplayLayout.RefreshFilters();
        }

        private void UltraComboCobradoresRowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonAceptar.Enabled = true;
            ultraCheckEditorInactivos.Enabled = false;
        }

        private void UltraComboCobradoresItemNotInList(object sender, Infragistics.Win.UltraWinEditors.ValidationErrorEventArgs e)
        {
            if (e.InvalidText != "Todos") return;
            e.RetainFocus = false;
        }
    }
}