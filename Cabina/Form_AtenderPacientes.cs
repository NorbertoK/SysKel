using System;
using System.Data;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Resources = Cabina.Properties.Resources;

namespace Cabina
{
    public partial class FormAtenderPacientes : Form1
    {
        private readonly int _idTipoDeDocumento = new Service().DefaultDNI(Program.Pin);
        private FormPrincipalCabina _fp;

        public FormAtenderPacientes()
        {
            InitializeComponent();
        }

        private void FormAtenderPacientesLoad(object sender, EventArgs e)
        {
            dsRecursos.Merge(new Service().GetMedicosLista(Program.Pin));
            _fp = (FormPrincipalCabina) MdiParent;
            tiposDeDocumentoBindingSource.DataSource = _fp.dsTiposDeDocumento;
            motivosDeLlamadoBindingSource.DataSource = _fp.dsMotivosDeLlamado;
            diagnosticosBindingSource.DataSource = _fp.dsDiagnosticos;
            usuariosListaBindingSource.DataSource = _fp.dsUsuariosLista;
            if (_fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(Program.IdUsuario).IsidEmpleadoNull())
            {
                MessageBox.Show(
                    "Su usuario no tiene asignado a un médico.",
                    "No está autorizado");
                buttonAceptar.Enabled = false;
                return;
            }
            dsTurnos.Merge(new Service().GetTurnosHoyPorMedico(Program.Pin,
                                                               _fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(
                                                                   Program.IdUsuario).idEmpleado));
            //ManejoDatos.AplicarUpdate(dsTurnos);
            /*Que el documento por default sea DNI*/
            turnosUltraGrid.DisplayLayout.Bands["Turnos"].Columns["idTipoDeDocumento"].DefaultCellValue =
                new Service().DefaultDNI(Program.Pin);
        }

        private void TurnosUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key == "Turnos")
            {
                e.Row.Cells["idEmpleado"].Column.CellActivation = e.Row.IsAddRow ? Activation.AllowEdit : Activation.NoEdit;
                e.Row.Cells["Dia"].Column.CellActivation = e.Row.IsAddRow ? Activation.AllowEdit : Activation.NoEdit;
                e.Row.Cells["Hora"].Column.CellActivation = e.Row.IsAddRow ? Activation.AllowEdit : Activation.NoEdit;

                // Empieza Linq
                var result = from item in dsTurnos.Turnos.AsEnumerable()
                             where item.Field<int?>("idTipoDeDocumento") == null
                             select item;
                foreach (var item in result)
                {
                    item["idTipoDeDocumento"] = _idTipoDeDocumento;
                }
                // Termina Linq

                if (e.Row.Cells["Cancelado"].Value == DBNull.Value)
                {
                    e.Row.Activation = Activation.AllowEdit;
                    e.Row.Cells["Apelnomb"].Appearance.FontData.Strikeout =
                        DefaultableBoolean.False;
                    e.Row.Cells["idTipoDeDocumento"].Appearance.FontData.Strikeout =
                        DefaultableBoolean.False;
                    e.Row.Cells["NumeroDeDocumento"].Appearance.FontData.Strikeout =
                        DefaultableBoolean.False;
                }
                else
                {
                    e.Row.Activation = Activation.Disabled;
                    e.Row.Cells["Apelnomb"].Appearance.FontData.Strikeout =
                        DefaultableBoolean.True;
                    e.Row.Cells["idTipoDeDocumento"].Appearance.FontData.Strikeout =
                        DefaultableBoolean.True;
                    e.Row.Cells["NumeroDeDocumento"].Appearance.FontData.Strikeout =
                        DefaultableBoolean.True;
                }
                var estado = 7;
                if (e.Row.Cells["Presente"].Value == DBNull.Value) estado = 0;
                if (e.Row.Cells["idAfiliado"].Value != DBNull.Value) estado = 3;
                if (e.Row.Cells["Atendido"].Value != DBNull.Value) estado = 4;
                if (e.Row.Cells["Terminado"].Value != DBNull.Value) estado = 6;
                if (e.Row.Cells["Cancelado"].Value != DBNull.Value) estado = 7;
                e.Row.Cells["Estado"].Appearance.Image = estado;
            }
        }

        private void TurnosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private bool Grabar()
        {
            Validate();
            turnosBindingSource.EndEdit();
            motivosDeLlamadoBindingSource.EndEdit();
            diagnosticosBindingSource.EndEdit();
            var turn = new Service().UpdateTurnos(dsTurnos, Program.Pin);
            if (turn == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." +
                    Environment.NewLine + Environment.NewLine +
                    "Póngase en contacto con el Administrador del Sistema.",
                    "Operación Rechazada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            dsTurnos.Clear();
            dsTurnos.Merge(new Service().GetTurnosHoyPorMedico(Program.Pin,
                                                               _fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(
                                                                   Program.IdUsuario).idEmpleado));
            Ordenar();
            return true;
        }

        private void Ordenar()
        {
            turnosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
            turnosUltraGrid.UpdateData();
            turnosUltraGrid.ActiveRow = null;
            var band = turnosUltraGrid.DisplayLayout.Bands[0];
            band.Columns["idEmpleado"].SortIndicator = SortIndicator.Ascending;
            band.Columns["Dia"].SortIndicator = SortIndicator.Ascending;
            band.Columns["Hora"].SortIndicator = SortIndicator.Ascending;
            band.Columns["Cancelado"].SortIndicator = SortIndicator.Descending;
            turnosUltraGrid.Update();
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            Grabar();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (Grabar()) Close();
        }

        private void ButtonColoresClick(object sender, EventArgs e)
        {
            var colores = new FormReferenciaColoresConsultorio();
            colores.ShowDialog();
        }

        private void TurnosUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            if (turnosUltraGrid.ActiveRow.Band.Key != turnosUltraGrid.DisplayLayout.Bands[0].Key) return;
            dsAntecedentesConsultorio.Clear();
            if (turnosUltraGrid.ActiveRow.Cells["NumeroDeDocumento"].Value == DBNull.Value ||
                turnosUltraGrid.ActiveRow.Cells["idAfiliado"].Value == DBNull.Value) return;
            dsAntecedentesConsultorio.Merge(
                new Service().GetDatosFiliatorios(turnosUltraGrid.ActiveRow.Cells["NumeroDeDocumento"].Value.ToString(),
                                                  (int) turnosUltraGrid.ActiveRow.Cells["idAfiliado"].Value, Program.Pin));
            dsAntecedentesConsultorio.Merge(
                new Service().GetAtencionesAnterioresConsultorio((int) turnosUltraGrid.ActiveRow.Cells["idTurno"].Value,
                                                                 turnosUltraGrid.ActiveRow.Cells["NumeroDeDocumento"].Value.ToString(),
                                                                 Program.Pin));
        }

        private void AtencionesAnterioresUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            //if ((e.Row.Cells["Motivo"].Value == DBNull.Value || e.Row.Cells["Motivo"].Value.ToString() == "") &&
            //    (e.Row.Cells["Diagnostico"].Value == DBNull.Value || e.Row.Cells["Diagnostico"].Value.ToString() == ""))
            //{
            //    e.Row.Cells["Motivo"].Hidden = true;
            //    e.Row.Cells["Diagnostico"].Hidden = true;
            //}
            //else
            //{
            //    e.Row.Cells["Motivo"].Hidden = false;
            //    e.Row.Cells["Diagnostico"].Hidden = false;
            //}

            //if (e.Row.Cells["Evolucion"].Value == DBNull.Value || e.Row.Cells["Evolucion"].Value.ToString() == "")
            //    e.Row.Cells["Evolucion"].Column.Hidden = true;
            //else
            //    e.Row.Cells["Evolucion"].Column.Hidden = false;
        }

        private void TurnosUltraGridAfterCellActivate(object sender, EventArgs e)
        {
            if (turnosUltraGrid.ActiveCell != null && turnosUltraGrid.ActiveCell.Column.Key == "Atendido" &&
                turnosUltraGrid.ActiveRow.Cells["Atendido"].Value == DBNull.Value)
            {
                turnosUltraGrid.ActiveRow.Cells["Atendido"].Value = new Service().HoraActual(Program.Pin);
                Grabar();
            }

            if (turnosUltraGrid.ActiveCell != null && turnosUltraGrid.ActiveCell.Column.Key == "Terminado" &&
                turnosUltraGrid.ActiveRow.Cells["Terminado"].Value == DBNull.Value)
            {
                turnosUltraGrid.ActiveRow.Cells["Terminado"].Value = new Service().HoraActual(Program.Pin);
                Grabar();
            }
            if (turnosUltraGrid.ActiveCell != null && Equals(turnosUltraGrid.ActiveCell.Column.Header.Caption, "Evolución"))
                turnosUltraGrid.ActiveRow.ExpandAll();
        }

        private void turnosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                turnosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void datosFiliatoriosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                datosFiliatoriosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void AtencinesAnterioresUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AtencinesAnterioresUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void datosFiliatoriosUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }

        private void AtencinesAnterioresUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}