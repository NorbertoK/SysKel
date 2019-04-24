using System;
using System.ComponentModel;
using System.Transactions;
using System.Windows.Forms;
using Cabina.Properties;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;
using ColumnStyle = Infragistics.Win.UltraWinGrid.ColumnStyle;
using Resources = Cabina.Properties.Resources;

namespace Cabina
{
    public partial class FormRemesaPrestacion : Form1
    {
        public FormRemesaPrestacion()
        {
            InitializeComponent();
        }

        public int IdPrestacion { get; set; }

        private void RemesasUltraGridAfterCellUpdate(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "idTipoDeValor") return;
            if (dsTiposDeValores.TiposDeValores.FindByidTipoDeValor((int) e.Cell.Value).RequiereBanco == false)
            {
                e.Cell.Row.Cells["idBanco"].Hidden = true;
                e.Cell.Row.Cells["NumeroDeCheque"].Hidden = true;
                e.Cell.Row.Cells["Vencimiento"].Hidden = true;
                e.Cell.Row.Cells["idBanco"].Value = DBNull.Value;
                e.Cell.Row.Cells["NumeroDeCheque"].Value = DBNull.Value;
                e.Cell.Row.Cells["Vencimiento"].Value = DBNull.Value;
            }
            else
            {
                e.Cell.Row.Cells["idBanco"].Hidden = false;
                e.Cell.Row.Cells["NumeroDeCheque"].Hidden = false;
                e.Cell.Row.Cells["Vencimiento"].Hidden = false;
            }
        }

        private void RemesasUltraGridSummaryValueChanged(object sender, SummaryValueChangedEventArgs e)
        {
            if (e.SummaryValue.Key == "SumComprobantes")
            {
                ultraCurrencyEditorSumComprobantes.Value = (decimal) e.SummaryValue.Value;
            }
            if (e.SummaryValue.Key == "SumValores")
            {
                ultraCurrencyEditorSumValores.Value = (decimal) e.SummaryValue.Value;
            }
            buttonAceptar.Enabled = ultraCurrencyEditorSumComprobantes.Value == ultraCurrencyEditorSumValores.Value;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if ((int) ultraCurrencyEditorSumComprobantes.Value == 0 &&
                remesasUltraGrid.ActiveRow.Cells["Observaciones"].Text == "")
            {
                MessageBox.Show("Por favor escriba en observaciones porqué no se cobró.",
                    "¿No se cobró?",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var ts = new TransactionScope())
                {
                    try
                    {
                        buttonAceptar.Visible = false;
                        ultraLabelMensaje.Visible = true;
                        Validate();
                        remesasBindingSource.EndEdit();
                        /*Updatea*/
                        var aux = new Service().UpdateRemesa(dsRemesas, Program.Pin);
                        if (aux == null)
                        {
                            MessageBox.Show(
                                "La operación fue rechazada por la Base de Datos." +
                                Environment.NewLine +
                                Environment.NewLine +
                                "Póngase en contacto con el Administrador del Sistema.",
                                "Operación Rechazada", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            dsRemesas.Merge(aux);
                            ManejoDatos.AplicarUpdate(dsRemesas);
                        }
                        /*Hace recibos si hace falta.*/
                        new Service().HacerRecibosRemesa(
                            Convert.ToInt32(remesasUltraGrid.Rows[0].Cells[0].Value.ToString()), Program.Pin);
                        ts.Complete();
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("No se registró el pago.",
                            "¡Atención!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        ts.Dispose();
                    }
                }
            }
        }

        private void RemesasUltraGridBeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            if (remesasUltraGrid.ActiveRow.Band.Key == "Remesas" &&
                remesasUltraGrid.ActiveRow.Cells["Caja"].Value == DBNull.Value && Settings.Default.Empresa == "activa")
            {
                e.Cancel = true;
                MessageBox.Show("Falta el número de recibo.",
                    "¡Atención!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (remesasUltraGrid.ActiveRow.Band.Key == "FK_ComprobantesRemesas_Remesas" &&
                remesasUltraGrid.ActiveRow.Cells[3].Text != remesasUltraGrid.ActiveRow.Cells[4].Text)
            {
                if (remesasUltraGrid.ActiveRow.Cells["Observaciones"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Escriba observaciones.",
                        "Cobró menos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            if (remesasUltraGrid.ActiveRow.Band.Key != "FK_Remesas_ValoresRemesas" ||
                !dsTiposDeValores.TiposDeValores.FindByidTipoDeValor(
                    (int) remesasUltraGrid.ActiveRow.Cells["idTipoDeValor"].Value).RequiereBanco) return;
            if (remesasUltraGrid.ActiveRow.Cells["idBanco"].Value == DBNull.Value)
            {
                e.Cancel = true;
                MessageBox.Show("Falta el Banco",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (remesasUltraGrid.ActiveRow.Cells["NumeroDeCheque"].Value == DBNull.Value)
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el Número de Cheque",
                        "¡Atención!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (remesasUltraGrid.ActiveRow.Cells["Vencimiento"].Value == DBNull.Value)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Falta el vencimiento",
                            "¡Atención!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RemesasUltraGridAfterRowExpanded(object sender, RowEventArgs e)
        {
            foreach (var celda in e.Row.Cells)
            {
                celda.Column.Style = ColumnStyle.Edit;
                celda.Column.CellActivation = Activation.NoEdit;
            }
        }

        private void FormRemesaActivated(object sender, EventArgs e)
        {
            /*Llena los combos*/
            dsTiposDeValores.Merge(new Service().GetTiposDeValores(Program.Pin));
            dsBancos.Merge(new Service().GetBancos(Program.Pin));
            dsUsuariosLista1.Merge(new Service().GetUsuariosLista(Program.Pin));
            dsComprobantePrestacion1.Merge(new Service().GetComprobantePrestacion(IdPrestacion,
                Program.Pin));
            dsPersonalPrestacion.Merge(new Service().GetPersonalPrestacion(IdPrestacion,
                Program.Pin));
        }

        private void RemesasUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key == "Remesas")
            {
                e.Row.Cells["Fecha"].Value = new Service().HoraActual(Program.Pin);
                e.Row.Cells["idGrabador"].Value = Program.IdUsuario;
            }
            if (e.Row.Band.Key == "FK_ComprobantesRemesas_Remesas")
            {
                e.Row.Cells["ImporteCobrado"].Column.MinValue = 0;
                e.Row.Cells["ImporteCobrado"].Column.MaxValue = (decimal) e.Row.Cells["ImporteReferencia"].Value;
            }
            if (e.Row.Band.Key == "FK_Remesas_ValoresRemesas")
            {
                e.Row.Cells["idEmpleado"].Value = (int) remesasUltraGrid.Rows[0].Cells["idReceptor"].Value;
            }
        }

        private void RemesasUltraGridCellListSelect(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "idReceptor") return;
            remesasBindingSource.EndEdit();
            remesasUltraGrid.ActiveRow.Update();
            var renglon = dsRemesas.ComprobantesRemesas.NewRow();
            renglon["idReferencia"] = dsComprobantePrestacion1.ComprobantePrestacion.Rows[0]["idComprobante"];
            renglon["ImporteReferencia"] = dsComprobantePrestacion1.ComprobantePrestacion.Rows[0]["Importe"];
            renglon["ImporteCobrado"] = dsComprobantePrestacion1.ComprobantePrestacion.Rows[0]["Importe"];
            renglon["idRemesa"] = dsRemesas.Remesas.Rows[0]["idRemesa"];
            renglon["idPrestacion"] = IdPrestacion;
            dsRemesas.ComprobantesRemesas.Rows.Add(renglon);
            remesasUltraGrid.Rows.ExpandAll(true);
        }

        private void remesasUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}