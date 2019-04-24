using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormReporteInformeVentas : Form
    {
        public FormReporteInformeVentas()
        {
            InitializeComponent();
        }

        private void FormSolicitarPeriodoLoad(object sender, EventArgs e)
        {
            var hoy = new Service().HoraActual(Program.Pin);
            ultraCalendarComboDesde.Value = hoy.AddDays(-(hoy.Day - 1)).AddMonths(-1);
            ultraCalendarComboHasta.Value = hoy.AddDays(-hoy.Day);
            ultraComboEditorMes.Value = ultraCalendarComboDesde.Text.Substring(3, 2);
            var fecha = (DateTime) ultraCalendarComboDesde.Value;
            ultraNumericEditorAnyo.Value = fecha.Year;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var desde = panelMes.Enabled
                                 ? new DateTime((int) ultraNumericEditorAnyo.Value,
                                                Convert.ToInt32(ultraComboEditorMes.Value.ToString()), 1)
                                 : (DateTime) ultraCalendarComboDesde.Value;
            var hasta = panelMes.Enabled
                                 ? desde.AddMonths(1).AddDays(-1)
                                 : (DateTime) ultraCalendarComboHasta.Value;
            var f = new FormRepInformeVentas
                        {
                            MdiParent = MdiParent,
                            Desde = desde,
                            Hasta = hasta,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
            Close();
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void RadioButtonFechasCheckedChanged(object sender, EventArgs e)
        {
            panelFechas.Enabled = !panelFechas.Enabled;
            panelMes.Enabled = !panelMes.Enabled;
        }
    }
}