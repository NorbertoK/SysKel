using System;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;


namespace Cabina
{
    using Properties;

    public partial class FormPacientesIncompletos : Form1
    {
        private FormPrincipalCabina _fp;
        public FormPacientesIncompletos()
        {
            InitializeComponent();
        }

        private void FormPacientesIncompletosLoad(object sender, EventArgs e)
        {
            /*Llena el combo Edad en*/
            pacientesUltraGrid.DisplayLayout.ValueLists.Add("EdadEn");
            pacientesUltraGrid.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("A", "años");
            pacientesUltraGrid.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("M", "meses");
            pacientesUltraGrid.DisplayLayout.ValueLists["EdadEn"].ValueListItems.Add("D", "días");
            pacientesUltraGrid.DisplayLayout.Bands["Pacientes"].Columns["EdadEn"].ValueList =
            pacientesUltraGrid.DisplayLayout.ValueLists["EdadEn"];

            /*Llena el combo Sexo*/
            pacientesUltraGrid.DisplayLayout.ValueLists.Add("Sexo");
            pacientesUltraGrid.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add("M", "M");
            pacientesUltraGrid.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add("F", "F");
            pacientesUltraGrid.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add(" ", "");
            pacientesUltraGrid.DisplayLayout.Bands["Pacientes"].Columns["Sexo"].ValueList =
            pacientesUltraGrid.DisplayLayout.ValueLists["Sexo"];

            /*Conecta el Grid*/
            pacientesUltraGrid.DataBind();

            dsPacientesIncompletos.Merge(new WS.Service().GetPacientesIncompletos(Program.Pin));
            /*Tomo datos del padre*/
            _fp = (FormPrincipalCabina)MdiParent;
            prepagosBindingSource.DataSource = _fp.dsPrepagos;
            contratosBindingSource.DataSource = _fp.dsContratosLista;
            coberturasBindingSource.DataSource = _fp.dsCoberturas;
            practicasBindingSource.DataSource = _fp.dsPracticas;
            motivosDeLlamadoBindingSource.DataSource = _fp.dsMotivosDeLlamado;
            medicamentosBindingSource.DataSource = _fp.dsMedicamentos;
            diagnosticosBindingSource.DataSource = _fp.dsDiagnosticos;
            dsEmpleadosLista.Merge(new WS.Service().GetMedicos(Program.Pin));
            dsSistemas.Merge(new WS.Service().GetSistemas(Program.Pin));
        }

        private void PacientesIncompletosUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            dsPacientesPrestacion.Clear();
            dsPacientesPrestacion.Merge(new WS.Service().GetPaciente((int)pacientesIncompletosUltraGrid.ActiveRow.Cells["idPaciente"].Value,Program.Pin));
            pacientesUltraGrid.Rows.ExpandAll(true);
            if (pacientesIncompletosUltraGrid.Rows.Count==1)
            {
                buttonAceptar.Visible = true;
            }
        }

        private void PacientesUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if ((e.Row.Band.Key != "FK__Medicamentos__Pacientes" || e.Row.Cells["idMedicamento"].Value == DBNull.Value) ||
                e.Row.Cells["Cantidad"].Value == DBNull.Value) return;
            e.Row.Cells["Unidad"].Value = Convert.ToInt32(e.Row.Cells["Cantidad"].Text) > 1
                                              ? _fp.dsMedicamentos.Medicamentos.FindByidMedicamento(
                                                    (int)e.Row.Cells["idMedicamento"].Value).
                                                    Unidades
                                              : _fp.dsMedicamentos.Medicamentos.FindByidMedicamento(
                                                    (int)e.Row.Cells["idMedicamento"].Value).
                                                    Unidad;
            if ((int)e.Row.Cells["idMedicamento"].Value == (int)dsSistemas.Sistemas.Rows[0]["SinMedicamentos"])
            {
                e.Row.Band.MaxRows = 1;
                e.Row.Cells["Cantidad"].Value = 0;
                e.Row.Cells["Unidad"].Value = "";
                e.Row.Cells["Cantidad"].Hidden = true;
                e.Row.Cells["Unidad"].Hidden = true;
            }
            else
            {
                e.Row.Band.MaxRows = 100;
                e.Row.Cells["Cantidad"].Hidden = false;
                e.Row.Cells["Unidad"].Hidden = false;
            }
        }

        private void PacientesUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "Cantidad" && e.Cell.Text.Length > 0)
            {
                e.Cell.Row.Cells["Unidad"].Value = Convert.ToInt32(e.Cell.Text) > 1
                                                       ? _fp.dsMedicamentos.Medicamentos.FindByidMedicamento(
                                                             (int)e.Cell.Row.Cells["idMedicamento"].Value).
                                                             Unidades
                                                       : _fp.dsMedicamentos.Medicamentos.FindByidMedicamento(
                                                             (int)e.Cell.Row.Cells["idMedicamento"].Value).
                                                             Unidad;
            }
        }
        private void GrabarPacientes()
        {
            Validate();
            pacientesBindingSource.EndEdit();
            if (!dsPacientesPrestacion.HasChanges()) return;
            if(DatosCompletos())
            {
                pacientesIncompletosUltraGrid.BeforeRowsDeleted += PacientesIncompletosUltraGridBeforeRowsDeleted;
                pacientesIncompletosUltraGrid.ActiveRow.Delete();
                pacientesIncompletosUltraGrid.UpdateData();
                pacientesIncompletosUltraGrid.BeforeRowsDeleted -= PacientesIncompletosUltraGridBeforeRowsDeleted;
            }
            var cambios = new DsPacientesPrestacion();
            cambios.Merge(dsPacientesPrestacion.GetChanges());
            var pac = new WS.Service().UpdatePacientes(cambios, Program.Pin);
            if (pac == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Póngase en contacto con el Administrador del Sistema.", "Operación Rechazada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dsPacientesPrestacion.Merge(pac);
                ManejoDatos.AplicarUpdate(dsPacientesPrestacion);
            }
        }

        private bool DatosCompletos()
        {
            foreach (
                UltraGridRow paciente in
                    pacientesUltraGrid.DisplayLayout.Bands[0].GetRowEnumerator(GridRowType.DataRow))
            {
                if (paciente.ChildBands["FK__Diagnosticos__Pacientes"].Rows.Count <= 0 ||
                    paciente.ChildBands["FK__Medicamentos__Pacientes"].Rows.Count <= 0) continue;
                paciente.Cells["DatosCompletos"].Value = true;
                paciente.Update();
                return true;
            }
            return false;
        }
        private void PacientesIncompletosUltraGridBeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
        }

        private void PacientesUltraGridCellListSelect(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "idMedicamento") return;
            if ((int)ultraDropDownMedicamentos.SelectedRow.Cells["idMedicamento"].Value == (int)dsSistemas.Sistemas.Rows[0]["SinMedicamentos"])
            {
                e.Cell.Row.Band.MaxRows = 1;
                e.Cell.Row.Cells["Cantidad"].Value = 0;
                e.Cell.Row.Cells["Unidad"].Value = "";
                e.Cell.Row.Cells["Cantidad"].Hidden = true;
                e.Cell.Row.Cells["Unidad"].Hidden = true;
            }

            else
            {
                e.Cell.Row.Band.MaxRows = 100;
                e.Cell.Row.Cells["Cantidad"].Hidden = false;
                e.Cell.Row.Cells["Unidad"].Hidden = false;
            }
        }

        private void PacientesIncompletosUltraGridBeforeRowDeactivate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GrabarPacientes();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            GrabarPacientes();
        }
    }
}
