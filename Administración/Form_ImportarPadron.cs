using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormImportarPadron : Form1
    {
        public FormImportarPadron()
        {
            InitializeComponent();
        }

        private readonly string _proceso = new Service().GetProceso(Program.Pin);
        private void FormImportarPadronLoad(object sender, EventArgs e)
        {
            ultraCalendarComboFecha.Value = new Service().HoraActual(Program.Pin);
            dsImportarPadron.Row.ProcesoColumn.DefaultValue = _proceso;
        }
        private void Actualizar(string frase)
        {
            dsBuscarPlanContrato.Clear();
            dsBuscarPlanContrato.EnforceConstraints = false;
            dsBuscarPlanContrato.Merge(new Service().GetBuscarPlanContrato(frase, Program.Pin));
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
        }

        private void ButtonRazonClick(object sender, EventArgs e)
        {
            buttonRazon.Enabled = false;
            string frase = "(";
            var seps = new[] {' '};
            foreach (string parte in textBoxRazon.Text.Split(seps))
            {
                frase += "RazonSocial LIKE '%" + parte + "%' or ";
                frase += "NombreFantasia LIKE '%" + parte + "%') and (";
            }
            frase = frase.Remove(frase.Length - 7) + ");";
            Actualizar(frase);
        }

        private void TextBoxRazonEnter(object sender, EventArgs e)
        {
            AcceptButton = buttonRazon;
        }

        private void TextBoxRazonLeave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void UltraGridClick(object sender, EventArgs e)
        {
            ManejarBotonAceptar();
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
                dsBuscarPlanContrato.Clear();
            }
            buttonAceptar.Enabled = false;
        }

        private void FormABCClientesEnter(object sender, EventArgs e)
        {
            buttonRazon.Enabled = false;
        }

        private void UltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["Estado"].Text == "Activo")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Green;
            }
            if (e.Row.Cells["Estado"].Text == "Baja")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Red;
            }
            if (e.Row.Cells["Estado"].Text == "Suspendido")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Blue;
            }
            if (e.Row.Cells["RazonSocial"].Text == "Ningún Resultado")
            {
                e.Row.Cells["RazonSocial"].Appearance.ForeColor = Color.Red;
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            var queDure = new Service { Timeout = (60 * 60 * 1000) };
            queDure.UpdateImportarPadron(dsImportarPadron, Program.Pin);
            var fecha = (DateTime)ultraCalendarComboFecha.Value;
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var aux = new Service { Timeout = (60 * 60 * 1000) };
            if (aux.ImportarPadron(_proceso, (int)ultraNumericEditor1.Value,
                                             fecha.ToString("yyyyMMdd"), Program.IdUsuario,
                                             Program.Pin) == 1)
            {
                MessageBox.Show("Se ha importado el padrón.",
                                "Importación de Padrón",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                new Service().EliminarProceso(_proceso, Program.Pin);
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la importación.",
                                "Importación de Padrón",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonCancelar.Enabled = true;
                new Service().EliminarProceso(_proceso, Program.Pin);
            }
        }

        private void ButtonExaminarClick(object sender, EventArgs e)
        {
            var oFd = new OpenFileDialog
                          {
                              Title = "Seleccionar Planilla",
                              Filter = "Ficheros XML (*.xml)|*.xml",
                              FileName = textBoxPlanilla.Text
                          };
            if (oFd.ShowDialog() == DialogResult.OK)
            {
                textBoxPlanilla.Text = oFd.FileName;
            }
        }

        

        private void ManejarBotonAceptar()
        {
            if (textBoxPlanilla.Text.EndsWith(".xml") && ultraGrid.Selected.Rows.Count > 0 && ultraGrid.DisplayLayout.Rows[0].Cells[1].Text != "Ningún Resultado")
            {
                buttonAceptar.Enabled = true;
            }
            else
            {
                buttonAceptar.Enabled = false;
            }
        }

        private void TextBoxPlanillaTextChanged(object sender, EventArgs e)
        {
            dsImportarPadron.ReadXml(textBoxPlanilla.Text, XmlReadMode.InferTypedSchema);
            //dsImportarPadron.ReadXml(textBoxPlanilla.Text);
            ManejarBotonAceptar();
        }

        private void ultraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ultraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void rowUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rowUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}