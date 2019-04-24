using System;
using System.Drawing;
using System.Windows.Forms;
using Cabina.WS;

namespace Cabina
{
    public partial class FormReportTurnosImprimir : Form1
    {
        public FormReportTurnosImprimir()
        {
            InitializeComponent();
        }

        private void FormReportTurnosImprimirLoad(object sender, EventArgs e)
        {
            ultraCalendarCombo1.Value = new Service().HoraActual(Program.Pin);
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            if (ultraCombo1.Value.ToString() == "D")
            {
                var form = new FormRepTurnos
                               {
                                   Fecha = (DateTime) ultraCalendarCombo1.Value,
                                   StartPosition = FormStartPosition.Manual,
                                   Location = new Point(1, 1)
                               };
                form.ShowDialog(this);
            }
            else
            {
                var frase = "(";
                var seps = new[] {' '};
                foreach (var parte in ultraTextEditor1.Text.Split(seps))
                {
                    frase += "ISNULL(NumeroDeDocumento,'')+ISNULL(Turnos.ApelNomb,'')+ISNULL(Telefono,'')+ISNULL(Observaciones,'') LIKE '%" +
                             parte.Replace("'", "''") + "%') AND (";
                }
                frase = frase.Remove(frase.Length - 7) + ");";
                var form = new FormRepTurnosPorFrase
                               {
                                   Frase = frase,
                                   Busqueda = ultraTextEditor1.Text,
                                   StartPosition = FormStartPosition.Manual,
                                   Location = new Point(1, 1)
                               };
                form.ShowDialog(this);
            }
            buttonCancelar.Enabled = true;
        }

        private void UltraCombo1ValueChanged(object sender, EventArgs e)
        {
            if(ultraCombo1.Value==DBNull.Value)
            {
                ultraCalendarCombo1.Visible = false;
                ultraTextEditor1.Visible = false;
            }
            else
            {
                if (ultraCombo1.Value.ToString() == "D")
                {
                    ultraCalendarCombo1.Visible = true;
                    ultraTextEditor1.Visible = false;
                }
                else
                {
                    ultraCalendarCombo1.Visible = false;
                    ultraTextEditor1.Visible = true;
                }
            }
            buttonAceptar.Enabled = ultraCombo1.Value.ToString() == "D" || ultraTextEditor1.Text.Length > 2;
        }

        private void UltraTextEditor1KeyUp(object sender, KeyEventArgs e)
        {
            buttonAceptar.Enabled = ultraTextEditor1.Text.Length > 2;
        }

        private void UltraCalendarCombo1ValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }
    }
}