using System;
using Cabina.WS;

namespace Cabina
{
    public partial class FormGenerarTurnos : Form1
    {
        public FormGenerarTurnos()
        {
            InitializeComponent();
        }

        private void FormGenerarTurnosLoad(object sender, EventArgs e)
        {
            var mesSiguiente = new Service().HoraActual(Program.Pin).AddMonths(1);
            ultraComboEditorMes.Value = mesSiguiente.Month;
            ultraNumericEditorAnyo.Value = mesSiguiente.Year;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            new Service().GenerarTurnos((int)ultraComboEditorMes.Value,(int)ultraNumericEditorAnyo.Value,Program.Pin);
            Close();
        }
    }
}
