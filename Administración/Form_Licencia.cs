using System;


namespace Administración
{
    using System.Windows.Forms;
    using WS;
    using Properties;

    public partial class FormLicencia : Form1
    {
        public FormLicencia()
        {
            InitializeComponent();
        }

        private void FormLicenciaLoad(object sender, EventArgs e)
        {
            dsLicencia.Merge(new Service().GetLicencia(Settings.Default.Empresa,Program.Pin));
            licenciasUltraGrid.Rows.TemplateAddRow.Cells["Empresa"].Column.DefaultCellValue = Settings.Default.Empresa;
        }
        private bool Grabar()
        {
            Validate();
            licenciasBindingSource.EndEdit();
            var aux = new Service().UpdateLicencia(dsLicencia, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsLicencia.Clear();
                dsLicencia.Merge(new Service().GetLicencia(Settings.Default.Empresa,Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsLicencia.Merge(aux);
            ManejoDatos.AplicarUpdate(dsLicencia);
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

        private void LicenciasUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }
    }
}
