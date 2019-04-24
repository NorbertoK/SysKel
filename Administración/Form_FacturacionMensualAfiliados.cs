using System;
using System.Threading;
using Administración.WS;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormFacturacionMensualAfiliados : Form1
    {
        public FormFacturacionMensualAfiliados()
        {
            InitializeComponent();
        }

        private void FormFacturacionMensualAfiliadosLoad(object sender, EventArgs e)
        {
            dsTiposDeCobranza.Merge(new Service().GetTiposDeCobranza(Program.Pin));
            dsEntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
            var hoy = new Service().HoraActual(Program.Pin);
            var periodo = hoy.Day < 25 ? hoy : hoy.AddMonths(1);
            ultraDateTimeEditorPeriodo.Value = periodo;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            var periodo1 = ultraDateTimeEditorPeriodo.Text;
            var idTipoDeCobranza1 = (int) ultraComboTiposDeCobranza.Value;
            var idEntidadDeCobranza1 = ultraComboEntidadesDeCobranza.Value == null ? 0 : (int) ultraComboEntidadesDeCobranza.Value;
            var jubilado1 = ultraComboJubilado.Value == null || (int) ultraComboJubilado.Value == 3 ? 0 : (int) ultraComboJubilado.Value;
            ultraLabelMensaje.Text = "Espere, por favor...";
            ultraLabelMensaje.Update();
            var th = new Thread(FacturacionMensual);
            var param = new ParamsfacturacionMensual(periodo1, idTipoDeCobranza1, idEntidadDeCobranza1, jubilado1);
            th.Name = "Thread de llamada a facturación Mensual";
            th.IsBackground = true;
            th.Start(param);
        }

        private void FacturacionMensual(object data)
        {
            var datos = (ParamsfacturacionMensual) data;
            FacturacionMensual(datos.Periodo1, datos.IdTipoDeCobranza1, datos.IdEntidadDeCobranza1, datos.Jubilado1);
        }

        private void FacturacionMensual(string periodo1, int idTipoDeCobranza1, int idEntidadDeCobranza1, int jubilado1)
        {
            var aux = new Service {Timeout = (60*60*1000)};
            int cantidadComprobantes = aux.CantidadDeComprobantesRealizados(periodo1, idTipoDeCobranza1, idEntidadDeCobranza1, jubilado1, Program.Pin);
            MostrarCantidadDeComprobantesRealizados(cantidadComprobantes);
        }

        private void MostrarCantidadDeComprobantesRealizados(int cantidadComprobantes)
        {
            if (InvokeRequired)
                Invoke(new MostrarCantidadDeComprobantesRealizadosDlg(MostrarCantidadDeComprobantesRealizados),
                       new object[] {cantidadComprobantes});
            else
            {
                switch (cantidadComprobantes)
                {
                    case 0:
                        ultraLabelMensaje.Text = "No se hicieron comprobantes.";
                        break;
                    case 1:
                        ultraLabelMensaje.Text = "Se hizo 1 comprobante.";
                        break;
                    default:
                        ultraLabelMensaje.Text = "Se hicieron " +
                                                 cantidadComprobantes + " comprobantes.";
                        break;
                }
                buttonAplicar.Visible = true;
            }
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            // Es el botón Salir.
            Close();
        }

        private void UltraComboTiposDeCobranzaItemNotInList(object sender, ValidationErrorEventArgs e)
        {
            if (e.InvalidText != "") return;
            e.RetainFocus = false;
            buttonAceptar.Enabled = false;
        }

        private void UltraComboTiposDeCobranzaFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["idTipoDeCobranza"], FilterComparisionOperator.LessThan,
                                         3);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraComboTiposDeCobranzaRowSelected(object sender, RowSelectedEventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void UltraComboTiposDeCobranzaValueChanged(object sender, EventArgs e)
        {
            ultraLabelEntidad.Visible =
                dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza((int) ultraComboTiposDeCobranza.Value).idTipoDeCobranza == 2;
            ultraComboEntidadesDeCobranza.Visible =
                dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza((int) ultraComboTiposDeCobranza.Value).idTipoDeCobranza == 2;
            if ((int) ultraComboTiposDeCobranza.Value == 1)
            {
                ultraComboEntidadesDeCobranza.Value = null;
                ultraComboJubilado.Value = null;
                ultraLabelJubilado.Visible = false;
                ultraComboJubilado.Visible = false;
            }
            MostrarBotonAceptar();
        }

        private void UltraComboEntidadesDeCobranzaValueChanged(object sender, EventArgs e)
        {
            if (ultraComboEntidadesDeCobranza.Value == null) return;
            ultraLabelJubilado.Visible =
                dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza((int) ultraComboEntidadesDeCobranza.Value).
                    RequiereJubilado;
            ultraComboJubilado.Visible =
                dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza((int) ultraComboEntidadesDeCobranza.Value).
                    RequiereJubilado;
            MostrarBotonAceptar();
        }

        private void MostrarBotonAceptar()
        {
            if (ultraComboTiposDeCobranza.Value != null &&
                (ultraComboEntidadesDeCobranza.Visible == false || ultraComboEntidadesDeCobranza.Value != null) && (ultraComboJubilado.Visible == false || ultraComboJubilado.Value != null))
                buttonAceptar.Enabled = true;
            else buttonAceptar.Enabled = false;
        }

        #region Nested type: MostrarCantidadDeComprobantesRealizadosDlg

        private delegate void MostrarCantidadDeComprobantesRealizadosDlg(int cantidadComprobantes);

        #endregion

        #region Nested type: ParamsfacturacionMensual

        private class ParamsfacturacionMensual
        {
            public readonly int IdTipoDeCobranza1;
            public readonly string Periodo1;
            public readonly int IdEntidadDeCobranza1;
            public readonly int Jubilado1;

            public ParamsfacturacionMensual(string periodo1, int xIdTipoDeCobranza1, int xIdEntidadDeCobranza1, int xJubilado1)
            {
                Periodo1 = periodo1;
                IdTipoDeCobranza1 = xIdTipoDeCobranza1;
                IdEntidadDeCobranza1 = xIdEntidadDeCobranza1;
                Jubilado1 = xJubilado1;
            }
        }

        #endregion

        private void UltraComboJubiladoValueChanged(object sender, EventArgs e)
        {
            MostrarBotonAceptar();
        }
    }
}