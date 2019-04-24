using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormReporteListadoPorPlan : Form
    {
        public FormReporteListadoPorPlan()
        {
            InitializeComponent();
        }

        private void FormReporteListadoPorPlanLoad(object sender, EventArgs e)
        {
            ultraCalendarCombo1.Value = new Service().HoraActual(Program.Pin);
            dsPlanes.Merge(new Service().GetPlanes(Program.Pin));
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            ultraLabelMensaje.Visible = true;
            ultraLabelMensaje.Update();
            var f = new FormRepListadoPorPlan
                        {
                            IdPlan = ((int) ultraComboPlanes.Value),
                            NombrePlan = ultraComboPlanes.Text,
                            Fecha = ((DateTime) ultraCalendarCombo1.Value),
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
            Close();
        }

        private void UltraComboPlanesRowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void UltraComboPlanesFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraComboPlanesItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false;
            }
        }
    }
}