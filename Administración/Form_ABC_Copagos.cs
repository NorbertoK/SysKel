using System;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormABCCopagos : Form1
    {
        private FormPrincipal _fp;
        public FormABCCopagos()
        {
            InitializeComponent();
        }

        private void FormABCCopagosLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal)MdiParent;
            dsClientes.Merge(new Service().GetClientes(Program.Pin));
            dsContratosLista.Merge(new Service().GetContratosLista(Program.Pin));
            planesBindingSource.DataSource = _fp.dsPlanes;
            dsTiposDeDestino.Merge(new Service().GetTiposDeDestino(Program.Pin));
            codigosBindingSource.DataSource = _fp.dsCodigos;
            tiposDeContratoBindingSource.DataSource = _fp.dsTiposDeContrato;
            dsPracticas.Merge(new Service().GetPracticas(Program.Pin));
            dsCopagos.Merge(new Service().GetCopagos(Program.Pin));
        }
        private bool Grabar()
        {
            Validate();
            copagosBindingSource.EndEdit();
            var aux = new Service().UpdateCopagos(dsCopagos, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsCopagos.Clear();
                dsCopagos.Merge(new Service().GetCopagos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsCopagos.Merge(aux);
            ManejoDatos.AplicarUpdate(dsCopagos);
            return true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            Grabar();
            buttonAplicar.Enabled = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (buttonAplicar.Enabled)
            {
                if (Grabar())
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void CopagosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            if (copagosUltraGrid.ActiveCell.Value.GetType().ToString() == "System.Boolean" ||
                copagosUltraGrid.ActiveCell.Value.GetType().ToString() == "System.DBNull") return;
            copagosUltraGrid.ActiveCell.SelStart = 0;
            copagosUltraGrid.ActiveCell.SelLength = copagosUltraGrid.ActiveCell.Value == DBNull.Value
                ? 0
                : copagosUltraGrid.ActiveCell.Text.Length;
        }

        private void CopagosUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void UltraDropDownClienteBeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownCliente.DisplayLayout.Bands[0].Columns["RazonSocial"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);

        }

        private void UltraDropDownContratoBeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownContrato.DisplayLayout.Bands[0].Columns["Contrato"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);

        }

        private void UltraDropDownPlanInitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            ultraDropDownPlan.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);

        }

        private void UltraDropDownDestinoBeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownDestino.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);

        }

        private void UltraDropDownCodigoBeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownCodigo.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);

        }

        private void UltraDropDownPracticaBeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownPractica.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }
        private void ultraDropDownTiposDeContrato_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ultraDropDownPractica.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }
        private void copagosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                copagosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
