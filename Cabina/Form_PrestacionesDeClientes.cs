using System;
using System.Drawing;
using System.Windows.Forms;
using Cabina.WS;

namespace Cabina
{
    public partial class FormPrestacionesDeClientes : Form1
    {
        private FormPrincipalCabina _fp;

        public FormPrestacionesDeClientes()
        {
            InitializeComponent();
        }

        private void Form_PrestacionesDeClientes_Load(object sender, EventArgs e)
        {
            ultraCalendarCombo1.Value = new Service().HoraActual(Program.Pin);
            ultraCalendarCombo2.Value = new Service().HoraActual(Program.Pin);
            _fp = (FormPrincipalCabina) MdiParent;
            clientesListaBindingSource.DataSource = _fp.dsClientesLista;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            var desde = (DateTime) ultraCalendarCombo1.Value;
            var hasta = (DateTime) ultraCalendarCombo2.Value;
            var idCliente = (int?) ultraComboClientes.Value ?? 0;
            var proceso = new Service().GetProcesoPrestacionesCliente(desde.ToString("yyyyMMdd"),
                hasta.ToString("yyyyMMdd"),
                idCliente, Program.Pin);
            var form = new FormRepImprimirPrestacion
            {
                Proceso = proceso,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            form.Show();
            buttonAceptar.Enabled = true;
        }
    }
}