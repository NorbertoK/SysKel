namespace Administración
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using WS;
    using Infragistics.Win.UltraWinEditors;
    using Infragistics.Win.UltraWinGrid;

    public partial class FormReporteComprobantesQueTieneUnCobrador : Form
    {
        public FormReporteComprobantesQueTieneUnCobrador()
        {
            InitializeComponent();
        }

        private void FormReporteComprobantesQueTieneUnCobradorLoad(object sender, EventArgs e)
        {
            dsEmpleadosLista.Merge(new Service().GetCobradores(Program.Pin));
        }

        private void UltraComboCobradoresItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false;
            }
        }

        private void UltraComboCobradoresFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var proceso = new Service().GetComprobantesQueTieneElCobrador((int) ultraComboCobradores.Value,
                                                                           Program.Pin);
            var cobrador =
                dsEmpleadosLista.EmpleadosLista.FindByidEmpleado((int) ultraComboCobradores.Value).NombApel;
            var f = new FormRepCuponesQueTieneElCobrador
                        {
                            Proceso = proceso,
                            Cobrador = cobrador,
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(1, 1)
                        };
            f.Show();
            Close();
        }
    }
}