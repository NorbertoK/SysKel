using System;
using System.Drawing;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Cabina.Properties.Resources;

namespace Cabina
{
    public partial class FormBuscarDireccionYAfiliado : Form
    {
        public string Boton;
        private DsCabBuscarTelefono _aux = new DsCabBuscarTelefono();

        public FormBuscarDireccionYAfiliado()
        {
            InitializeComponent();
        }

        public int IdAfiliado
        {
            get
            {
                try
                {
                    return (int) buscarTelefonoUltraGrid.ActiveRow.Cells["idAfiliado"].Value;
                }
                catch
                {
                    return 0;
                }
            }
        }
        public int IdPaciente
        {
            get
            {
                try
                {
                    return (int)buscarTelefonoUltraGrid.ActiveRow.Cells["idPaciente"].Value;
                }
                catch
                {
                    return 0;
                }
            }
        }
        public int IdContrato
        {
            get
            {
                try
                {
                    return (int) buscarTelefonoUltraGrid.ActiveRow.Cells["idContrato"].Value;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public int IdPlan
        {
            get
            {
                try
                {
                    return buscarTelefonoUltraGrid.ActiveRow.Cells["Estado"].Value.ToString() == "Baja" || buscarTelefonoUltraGrid.ActiveRow.Cells["Estado"].Value.ToString() == "Suspendido" ? 0 : (int)buscarTelefonoUltraGrid.ActiveRow.Cells["idPlan"].Value;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public int IdDireccion
        {
            get
            {
                try
                {
                    return (int) buscarTelefonoUltraGrid.ActiveRow.Cells["idDireccion"].Value;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public DsCabBuscarTelefono Aux
        {
            get { return _aux; }
            set { _aux = value; }
        }

        private void FormBuscarDireccionYAfiliadoLoad(object sender, EventArgs e)
        {
            dsCabBuscarTelefono.Merge(Aux);
            buscarTelefonoUltraGrid.Rows[0].Activate();
            buscarTelefonoUltraGrid.ActiveRow = null;
            buttonAfiliado.Visible = false;
            buttonDireccion.Visible = false;
            buttonDireccionYAfiliado.Visible = false;
            buttonContratoYDireccion.Visible = false;
            buttonPaciente.Visible = false;
            buttonPacienteYDireccion.Visible = false;
            buttonContrato.Visible = false;
        }

        private void BuscarTelefonoUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            buttonNingun.Visible = true;
            if (buscarTelefonoUltraGrid.ActiveRow.Cells["idAfiliado"].Value != DBNull.Value)
            {
                buttonAfiliado.Visible = true;
                if (buscarTelefonoUltraGrid.ActiveRow.Cells["idDireccion"].Value != DBNull.Value)
                {
                    buttonDireccion.Visible = true;
                    buttonDireccionYAfiliado.Visible = true;
                }
                buscarTelefonoUltraGrid.DisplayLayout.Bands[0].Columns["nPlan"].Header.Caption =
                    "Plan";
            }
            else // No es un afiliado.
            {
                if (buscarTelefonoUltraGrid.ActiveRow.Cells["idDireccion"].Value != DBNull.Value)
                {
                    buttonDireccion.Visible = true;
                }
                // Es un paciente.
                if (buscarTelefonoUltraGrid.ActiveRow.Cells["idPaciente"].Value != DBNull.Value &&
                    buscarTelefonoUltraGrid.ActiveRow.Cells["idAfiliado"].Value == DBNull.Value)
                {
                    buttonPaciente.Visible = true;
                    if (buscarTelefonoUltraGrid.ActiveRow.Cells["idDireccion"].Value != DBNull.Value)
                    {
                        buttonDireccion.Visible = true;
                        buttonPacienteYDireccion.Visible = true;
                    }
                }
                // Es un contrato.
                else if (buscarTelefonoUltraGrid.ActiveRow.Cells["idContrato"].Value != DBNull.Value &&
                    buscarTelefonoUltraGrid.ActiveRow.Cells["idAfiliado"].Value == DBNull.Value)
                {
                    buttonContrato.Visible = true;
                    if (buscarTelefonoUltraGrid.ActiveRow.Cells["idDireccion"].Value != DBNull.Value)
                    {
                        buttonDireccion.Visible = true;
                        buttonContratoYDireccion.Visible = true;
                    }
                }
                if (buscarTelefonoUltraGrid.ActiveRow.Cells["idContrato"].Value == DBNull.Value &&
                    buscarTelefonoUltraGrid.ActiveRow.Cells["idAfiliado"].Value == DBNull.Value)
                {
                    if (buscarTelefonoUltraGrid.ActiveRow.Cells["idDireccion"].Value != DBNull.Value)
                    {
                        buttonDireccion.Visible = true;
                    }
                }
                buscarTelefonoUltraGrid.DisplayLayout.Bands[0].Columns["nPlan"].Header.Caption =
                    "Contrato";
            }
        }

        private void BuscarTelefonoUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["Estado"].Text == "Activo")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Green;
            }
            if (e.Row.Cells["Estado"].Text == "Alta Reciente")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.DarkMagenta;
            }
            if (e.Row.Cells["Estado"].Text == "Baja")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Red;
            }
            if (e.Row.Cells["Estado"].Text == "Suspendido")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Blue;
            }
            e.Row.PerformAutoSize();
        }

        private void ButtonNingunClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAfiliadoClick(object sender, EventArgs e)
        {
            Boton = "Afiliado";
            Hide();
        }

        private void ButtonDireccionClick(object sender, EventArgs e)
        {
            Boton = "Direccion";
            Hide();
        }

        private void ButtonDireccionYAfiliadoClick(object sender, EventArgs e)
        {
            Boton = "Direccion y Afiliado";
            Hide();
        }

        private void BuscarTelefonoUltraGridInitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Override.RowSizing = RowSizing.Free;
        }

        private void ButtonContratoClick(object sender, EventArgs e)
        {
            Boton = "Contrato";
            Hide();
        }

        private void ButtonContratoYDireccionClick(object sender, EventArgs e)
        {
            Boton = "Contrato y Direccion";
            Hide();
        }

        private void ButtonPacienteClick(object sender, EventArgs e)
        {
            Boton = "Paciente";
            Hide();
        }

        private void ButtonPacienteYDireccionClick(object sender, EventArgs e)
        {
            Boton = "Paciente y Direccion";
            Hide();
        }

        private void buscarTelefonoUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscarTelefonoUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void buscarTelefonoUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}