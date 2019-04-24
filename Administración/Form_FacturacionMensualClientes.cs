namespace Administración
{
    using System;
    using System.Threading;
    using WS;

    public partial class FormFacturacionMensualClientes : Form1
    {
        public FormFacturacionMensualClientes()
        {
            InitializeComponent();
        }

        private void FormFacturacionMensualAfiliadosLoad(object sender, EventArgs e)
        {
            var hoy = new Service().HoraActual(Program.Pin);
            var periodo = hoy.Day < 16 ? hoy : hoy.AddMonths(1);
            ultraDateTimeEditorPeriodo.Value = periodo;
            ultraDateTimeEditorPeriodo.Enabled = true;
            dsTandasDeFacturacion.Merge(new Service().GetTandasDeFacturacion(Program.Pin));
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Visible = false;
            buttonCancelar.Visible = false;
            var fecha1 = ultraDateTimeEditorPeriodo.Value.ToString().Substring(6, 4) +
                            ultraDateTimeEditorPeriodo.Value.ToString().Substring(3, 2) +
                            "01";
            var periodo1 = ultraDateTimeEditorPeriodo.Value.ToString().Substring(3, 7);
            var idTandaDeFacturacion1 =
                (int) ultraComboTandasDeFacturacion.SelectedRow.Cells["idTandaDeFacturacion"].Value;
            ultraLabelMensaje.Text = "Espere, por favor...";
            ultraLabelMensaje.Update();
            var th = new Thread(FacturacionMensual);
            var param = new ParamsfacturacionMensual(fecha1, periodo1, idTandaDeFacturacion1);
            th.Name = "Thread de llamada a facturación Mensual Clientes";
            th.IsBackground = true;
            th.Start(param);
        }

        private void FacturacionMensual(object data)
        {
            var datos = (ParamsfacturacionMensual) data;
            FacturacionMensual(datos.Fecha1, datos.Periodo1, datos.IdTandaDeFacturacion1);
        }

        private void FacturacionMensual(string fecha1, string periodo1, int idTandaDeFacturacion1)
        {
            var aux = new Service {Timeout = (60*60*1000)};
            var cantidadComprobantes = aux.CantidadDeComprobantesDeFacturasRealizados(idTandaDeFacturacion1, fecha1,
                                                                                      periodo1, Program.Pin);
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
                        ultraLabelMensaje.Text = "Se hicieron " + cantidadComprobantes + " comprobantes.";
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

        #region Nested type: MostrarCantidadDeComprobantesRealizadosDlg

        private delegate void MostrarCantidadDeComprobantesRealizadosDlg(int cantidadComprobantes);

        #endregion

        #region Nested type: ParamsfacturacionMensual

        private class ParamsfacturacionMensual
        {
            public readonly string Fecha1;
            public readonly int IdTandaDeFacturacion1;
            public readonly string Periodo1;

            public ParamsfacturacionMensual(string xFecha1, string xPeriodo1, int xIdTandaDeFacturacion1)
            {
                Fecha1 = xFecha1;
                Periodo1 = xPeriodo1;
                IdTandaDeFacturacion1 = xIdTandaDeFacturacion1;
            }
        }

        #endregion

        private void UltraComboTandasDeFacturacionValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = ultraComboTandasDeFacturacion.Value != null;
        }
    }
}