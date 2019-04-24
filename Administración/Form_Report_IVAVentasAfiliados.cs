using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormReportIVAVentasAfiliados : Form
    {
        public FormReportIVAVentasAfiliados()
        {
            InitializeComponent();
        }

        private void FormReportIVAVentasAfiliadosLoad(object sender, EventArgs e)
        {
            dsPuntosDeVenta.Merge(new Service().GetPuntosDeVenta(Program.Pin));
            ultraCalendarComboDesde.Value =
                new Service().HoraActual(Program.Pin).AddMonths(-1).AddDays(
                    -(new Service().HoraActual(Program.Pin).Day - 1));
            ultraCalendarComboHasta.Value =
                new Service().HoraActual(Program.Pin).AddDays(-new Service().HoraActual(Program.Pin).Day);
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            var f = new FormRepIVAVentasAfiliados
                        {
                            Desde = ((DateTime) ultraCalendarComboDesde.Value),
                            Hasta = ((DateTime) ultraCalendarComboHasta.Value),
                            UltimaPaginaImpresa = ((int) ultraNumericEditorUltimaPaginaImpresa.Value),
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
            Close();
        }
    }
}