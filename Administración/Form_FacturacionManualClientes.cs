using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormFacturacionManualClientes : Form1
    {
        private string _primerPeriodo;

        public FormFacturacionManualClientes()
        {
            InitializeComponent();
        }

        private void FormABCClientesLoad(object sender, EventArgs e)
        {
            if (Program.Usu != "Administrador" &&
                dsAutorizacionesDelUsuario1.AutorizacionesDelUsuario.FindByCodigo("TA-0007") == null)
                buttonCuentaCorriente.Visible = false;
        }

        private void Actualizar(string frase)
        {
            dsBuscarClientes.Clear();
            dsBuscarClientes.EnforceConstraints = false;
            dsBuscarClientes.Merge(new Service().GetBuscarClientes(frase, Program.Pin));
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
            dsFacturasProFormaDelCliente.Clear();
            ultraLabelSeleccione.Visible = false;
            panelPeriodos.Visible = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            var dr =
                MessageBox.Show(
                    "Si se están haciendo estos comprobantes" +
                    Environment.NewLine +
                    "para entregárselos al cobrador, se generará" +
                    Environment.NewLine +
                    "una Facturación para registrar la recepción" +
                    Environment.NewLine +
                    "por parte del Cobrador." +
                    "Si se están haciendo para cobrarlos ahora," +
                    Environment.NewLine +
                    "por mostrador, quedarán sin Cobrador, como corresponde." +
                    Environment.NewLine +
                    Environment.NewLine + "¿Son para entregar al Cobrador?",
                    "Destino de los Comprobantes",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var ponerCobrador = dr == DialogResult.Yes;
            var n = 1;
            var cant = (int) ultraNumericEditorPeriodos.Value;
            var comprobantes = 0;
            var fechaComprobantes = new Service().HoraActual(Program.Pin);
            var proceso = new Service().GetProceso(Program.Pin);
            while (n <= cant)
            {
                var periodo =
                    new Service().PrimerPeriodoSinFacturarFacturaProforma(
                        (int) facturasProformaDelClienteUltraGrid.ActiveRow.Cells["idFacturaProforma"].Value,
                        Program.Pin);
                comprobantes = comprobantes +
                               new Service().CantidadDeComprobantesFacturasPorFacturaProforma(
                                   (int) facturasProformaDelClienteUltraGrid.ActiveRow.Cells["idFacturaProforma"].Value,
                                   periodo,
                                   fechaComprobantes.ToString("yyyyMMdd"), proceso, ponerCobrador, Program.Pin);
                n = n + 1;
            }

            if (ponerCobrador)
                new Service().FacturacionComprobantesManuales(proceso, "C", Program.Pin);
            switch (comprobantes)
            {
                case 0:
                    ultraLabelResultado.Text = "No se hicieron comprobantes.";
                    break;
                case 1:
                    ultraLabelResultado.Text =
                        "Se hizo 1 comprobante.";
                    break;
                default:
                    ultraLabelResultado.Text =
                        "Se hicieron " + comprobantes +
                        " comprobantes.";
                    break;
            }

            ultraLabelResultado.Visible = true;
            ultraLabelResultado.Update();
            if (comprobantes <= 0 || !ponerCobrador) return;
            /*Esto lo comento porque imprime la factura o el cupón y
             es de antes de la factura electrónica*/
            //var frmAImprimir = new FormRepComprobantesDeFactura
            //{
            //    MdiParent = MdiParent,
            //    Proceso = proceso,
            //    StartPosition = FormStartPosition.Manual,
            //    Location = new Point(0, 0)
            //};
            //frmAImprimir.Show();
        }

        private void ButtonRazonClick(object sender, EventArgs e)
        {
            buttonRazon.Enabled = false;
            var frase = "(";
            var seps = new[] {' '};
            foreach (var parte in textBoxRazon.Text.Split(seps))
            {
                frase += "RazonSocial LIKE '%" + parte + "%' or ";
                frase += "NombreFantasia LIKE '%" + parte + "%') and (";
            }

            frase = frase.Remove(frase.Length - 7) + ");";
            Actualizar(frase);
        }

        private void ButtonCUITClick(object sender, EventArgs e)
        {
            buttonCUIT.Enabled = false;
            Actualizar("CUIT LIKE '%" + maskedTextBoxCUIT.Text + "%';");
        }

        private void MaskedTextBoxCUITEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonCUIT;
            textBoxRazon.Text = "";
            buttonRazon.Enabled = false;
        }

        private void MaskedTextBoxCUITLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void TextBoxRazonEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonRazon;
            maskedTextBoxCUIT.Text = "";
            buttonCUIT.Enabled = false;
        }

        private void TextBoxRazonLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void MaskedTextBoxCUITKeyUp(object sender, KeyEventArgs e)
        {
            if (maskedTextBoxCUIT.Text.Length > 2)
            {
                buttonCUIT.Enabled = true;
            }
            else
            {
                buttonCUIT.Enabled = false;
                dsBuscarClientes.Clear();
                dsFacturasProFormaDelCliente.Clear();
                ultraLabelSeleccione.Visible = false;
                panelPeriodos.Visible = false;
            }

            buttonAceptar.Enabled = false;
        }

        private void MaskedTextBoxCUITClick(object sender, EventArgs e)
        {
            maskedTextBoxCUIT.Select(0, 0);
        }

        private void TextBoxRazonKeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxRazon.Text.Length > 2)
            {
                buttonRazon.Enabled = true;
            }
            else
            {
                buttonRazon.Enabled = false;
                dsBuscarClientes.Clear();
                dsFacturasProFormaDelCliente.Clear();
                ultraLabelSeleccione.Visible = false;
                panelPeriodos.Visible = false;
            }

            buttonAceptar.Enabled = false;
            buttonCuentaCorriente.Enabled = false;
        }

        private void FormABCClientesEnter(object sender, EventArgs e)
        {
            buttonCUIT.Enabled = false;
            buttonRazon.Enabled = false;
            buttonCuentaCorriente.Enabled = false;
        }

        private void UltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["Estado"].Text == "Activo") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Green;
            if (e.Row.Cells["Estado"].Text == "Baja") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Red;
            if (e.Row.Cells["Estado"].Text == "Suspendido") e.Row.Cells["Estado"].Appearance.ForeColor = Color.Blue;
            if (e.Row.Cells["RazonSocial"].Text == "Ningún Resultado")
                e.Row.Cells["RazonSocial"].Appearance.ForeColor = Color.Red;
        }

        private void ButtonCuentaCorrienteClick(object sender, EventArgs e)
        {
            buttonCuentaCorriente.Enabled = false;
            var f = new FormRepCuentaCorriente
            {
                GrupoOCliente = "C",
                Id = (int) ultraNumericEditor1.Value,
                Nombre = ultraGrid.ActiveRow.Cells["RazonSocial"].Text,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
        }

        private void UltraGridAfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            if (ultraGrid.Selected.Rows.Count > 0 &&
                ultraGrid.DisplayLayout.Rows[0].Cells[1].Text != "Ningún Resultado")
            {
                dsFacturasProFormaDelCliente.Clear();
                ultraLabelSeleccione.Visible = false;
                dsFacturasProFormaDelCliente.Merge(
                    new Service().GetFacturasProformaDelCliente((int) ultraNumericEditor1.Value, Program.Pin));
                switch (facturasProformaDelClienteUltraGrid.Rows.Count)
                {
                    case 0:
                        buttonCuentaCorriente.Enabled = false;
                        break;
                    case 1:
                        facturasProformaDelClienteUltraGrid.Rows[0].Activate();
                        facturasProformaDelClienteUltraGrid.Rows.ExpandAll(false);
                        buttonCuentaCorriente.Enabled = true;
                        HabilitarMeses();
                        break;
                    default:
                        facturasProformaDelClienteUltraGrid.Rows[0].Activate();
                        facturasProformaDelClienteUltraGrid.ActiveRow = null;
                        facturasProformaDelClienteUltraGrid.Rows.ExpandAll(false);
                        buttonCuentaCorriente.Enabled = true;
                        ultraLabelSeleccione.Visible = true;
                        break;
                }
            }
            else
            {
                buttonAceptar.Enabled = false;
                buttonCuentaCorriente.Enabled = false;
                dsFacturasProFormaDelCliente.Clear();
            }
        }

        private void FacturasProformaDelClienteUltraGridAfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            if (facturasProformaDelClienteUltraGrid.ActiveRow == null) return;
            if (facturasProformaDelClienteUltraGrid.Selected.Rows.Count == 0) return;
            if (facturasProformaDelClienteUltraGrid.ActiveRow.Band.Key ==
                "FK_FacturasProformaDelCliente_RenglonesFPFDelCliente")
                facturasProformaDelClienteUltraGrid.ActiveRow = facturasProformaDelClienteUltraGrid.ActiveRow.ParentRow;
            facturasProformaDelClienteUltraGrid.Selected.Rows.Clear();
            HabilitarMeses();
        }

        private void HabilitarMeses()
        {
            _primerPeriodo =
                new Service().PrimerPeriodoSinFacturarFacturaProforma(
                    (int) facturasProformaDelClienteUltraGrid.ActiveRow.Cells["idFacturaProforma"].Value,
                    Program.Pin);
            ultraLabelPrimerPeriodo.Text =
                "período(s) comenzando por " + _primerPeriodo +
                ".";
            ultraLabelPrimerPeriodo.Update();
            panelPeriodos.Visible = true;
            buttonAceptar.Enabled = true;
        }

        private void ultraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void facturasProformaDelClienteUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                facturasProformaDelClienteUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}