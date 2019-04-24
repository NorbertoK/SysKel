using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormReportHistRenglonesMoldesFactutra : Form1
    {
        private FormPrincipal _fp;

        public FormReportHistRenglonesMoldesFactutra()
        {
            InitializeComponent();
        }

        private void FormReportHistRenglonesMoldesFactutraLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            clientesListaBindingSource.DataSource = _fp.dsClientesLista;
            ultraCalendarCombo1.Value = new Service().Hoy(Program.Pin);
        }

        private void UltraCombo1ValueChanged(object sender, EventArgs e)
        {
            if (ultraCombo1.Value.ToString() == "Cliente")
            {
                clientesListaUltraCombo.Visible = true;
                ultraCalendarCombo1.Visible = false;
                buttonAceptar.Enabled = clientesListaUltraCombo.Value != DBNull.Value;
            }
            else
            {
                clientesListaUltraCombo.Visible = false;
                ultraCalendarCombo1.Visible = true;
                buttonAceptar.Enabled = true;
            }
        }

        private void ClientesListaUltraComboValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = clientesListaUltraCombo.Value != DBNull.Value;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var rep = new FormRepHistRenglonesFacturaModelo
            {
                Filtro = ultraCombo1.Value.ToString(),
                Titulo = ultraCombo1.Value.ToString() == "Cliente"
                    ? "Modificaciones de los Renglones de Factura de " + clientesListaUltraCombo.Text
                    : ultraCombo1.Value.ToString() == "Fecha"
                        ? "Modificaciones de los Renglones de Factura desde el " + ultraCalendarCombo1.Text
                        : "Modificaciones de los Renglones de Factura sin actualizar desde el "
                          + ultraCalendarCombo1.Text + ". No se incluyen los planes",
                Cliente = clientesListaUltraCombo.Text,
                Desde = (DateTime) ultraCalendarCombo1.Value,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            rep.Show();
            Close();
        }
    }
}