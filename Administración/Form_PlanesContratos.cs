using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormPlanesContratos : Form1
    {
        private FormPrincipal _fp;

        public FormPlanesContratos()
        {
            InitializeComponent();
        }

        private void FormPlanesContratosLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal)MdiParent;
            prepagosBindingSource.DataSource = _fp.dsPrepagos;
            dsProtecciones.Merge(new Service().GetProtecciones(Program.Pin));
            dsContratosLista.Merge(new Service().GetContratosLista(Program.Pin));
            dsPlanes.Merge(new Service().GetPlanesContratos(Program.Pin));
        }

        private bool Grabar()
        {
            Validate();
            planesContratoBindingSource.EndEdit();
            var aux = new Service().UpdatePlanesContratos(dsPlanes, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsPlanes.Clear();
                dsPlanes.Merge(new Service().GetPlanesPropios(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsPlanes.Merge(aux);
            ManejoDatos.AplicarUpdate(dsPlanes);
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

        private void PlanesUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void PlanesUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        #region BeforeDropDown
        private void UltraDropDownContratosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownContratos.DisplayLayout.Bands[0].Columns["Contrato"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownPrepagosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownPrepagos.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownProteccionesBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownProtecciones.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }
        #endregion

        private void planesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                planesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}
