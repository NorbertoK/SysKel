using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinEditors;

namespace Administración
{
    public partial class FormReportesClientes : Form1
    {
        public FormReportesClientes()
        {
            InitializeComponent();
        }

        private void FormReportesClientesLoad(object sender, EventArgs e)
        {
            dsEntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
            dsTiposDeCliente.Merge(new Service().GetTiposDeCliente(Program.Pin));
        }

        private void UltraCombo1ItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false;
            }
        }

        private bool SePuedeAceptar()
        {
            return (ultraComboReportes.Value != null && ultraComboTipoDireccion.Value != null) && ultraComboActivos.Value != null;
        }

        private void UltraComboReportesValueChanged(object sender, EventArgs e)
        {
            if (SePuedeAceptar())
            {
                buttonAceptar.Enabled = true;
            }
        }

        private void UltraComboTipoDireccionValueChanged(object sender, EventArgs e)
        {
            if (SePuedeAceptar())
            {
                buttonAceptar.Enabled = true;
            }
        }

        private void UltraComboActivosValueChanged(object sender, EventArgs e)
        {
            if (SePuedeAceptar())
            {
                buttonAceptar.Enabled = true;
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            var reporte = ultraComboReportes.Value.ToString();
            var tipoDeDireccion = ultraComboTipoDireccion.Value.ToString();
            var activos = ultraComboActivos.Value.ToString();
            var idEntidadDeCobranza = ultraComboEntidadesDeCobranza.Value == null
                                          ? 0
                                          : (int) ultraComboEntidadesDeCobranza.Value;
            var idTipoDeCliente = ultraComboRubros.Value == null ? 0 : (int) ultraComboRubros.Value;
            var proceso = new Service().GetProcesoClientes(activos, idEntidadDeCobranza, idTipoDeCliente,
                                                            Program.Pin);

            if (reporte == "ListaCorreo")
            {
                CrearFormularioHijo(new FormRepListaCorreo(), proceso, "C", tipoDeDireccion);
            }
            Close();
        }

        private void CrearFormularioHijo(FormIds f, string proceso, string afiliadosOClientes, string tipoDeDireccion)
        {
            f.MdiParent = MdiParent;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 0);
            f.Proceso = proceso;
            f.AfiliadosOClientes = afiliadosOClientes;
            f.TipoDeDireccion = tipoDeDireccion;
            f.Show();
        }

        private void UltraComboRubrosItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "")
            {
                e.RetainFocus = false;
            }
        }
    }
}