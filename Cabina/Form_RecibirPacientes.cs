﻿using System;
using System.Data;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Resources = Cabina.Properties.Resources;

namespace Cabina
{
    public partial class FormRecibirPacientes : Form1
    {
        private readonly int _idTipoDeDocumento = new Service().DefaultDNI(Program.Pin);
        private FormPrincipalCabina _fp;

        public FormRecibirPacientes()
        {
            InitializeComponent();
        }

        private void FormRecibirPacientesLoad(object sender, EventArgs e)
        {
            dsTurnos.Merge(new Service().GetTurnosHoy(Program.Pin));
            dsRecursos.Merge(new Service().GetMedicosLista(Program.Pin));
            ManejoDatos.AplicarUpdate(dsTurnos);
            _fp = (FormPrincipalCabina) MdiParent;
            tiposDeDocumentoBindingSource.DataSource = _fp.dsTiposDeDocumento;
            usuariosListaBindingSource.DataSource = _fp.dsUsuariosLista;

            /*Que el documento por default sea DNI*/
            turnosUltraGrid.DisplayLayout.Bands["Turnos"].Columns["idTipoDeDocumento"].DefaultCellValue =
                new Service().DefaultDNI(Program.Pin);
        }

        private void TurnosUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            e.Row.Cells["idEmpleado"].Column.CellActivation = e.Row.IsAddRow ? Activation.AllowEdit : Activation.NoEdit;
            e.Row.Cells["Dia"].Column.CellActivation = e.Row.IsAddRow ? Activation.AllowEdit : Activation.NoEdit;
            e.Row.Cells["Hora"].Column.CellActivation = e.Row.IsAddRow ? Activation.AllowEdit : Activation.NoEdit;

            // Empieza Linq
            var result = from item in dsTurnos.Turnos.AsEnumerable()
                where item.Field<int?>("idTipoDeDocumento") == null
                select item;
            foreach (var item in result) item["idTipoDeDocumento"] = _idTipoDeDocumento;
            // Termina Linq

            if (e.Row.Cells["Cancelado"].Value == DBNull.Value)
            {
                e.Row.Cells["Apelnomb"].Appearance.FontData.Strikeout =
                    DefaultableBoolean.False;
                e.Row.Cells["idTipoDeDocumento"].Appearance.FontData.Strikeout =
                    DefaultableBoolean.False;
                e.Row.Cells["NumeroDeDocumento"].Appearance.FontData.Strikeout =
                    DefaultableBoolean.False;
            }
            else
            {
                e.Row.Cells["Apelnomb"].Appearance.FontData.Strikeout =
                    DefaultableBoolean.True;
                e.Row.Cells["idTipoDeDocumento"].Appearance.FontData.Strikeout =
                    DefaultableBoolean.True;
                e.Row.Cells["NumeroDeDocumento"].Appearance.FontData.Strikeout =
                    DefaultableBoolean.True;
            }

            var estado = 1;
            if (e.Row.Cells["Presente"].Value == DBNull.Value) estado = 0;
            else if (e.Row.Cells["idAfiliado"].Value != DBNull.Value) estado = 3;
            else if (e.Row.Cells["Atendido"].Value != DBNull.Value) estado = 4;
            else if (e.Row.Cells["Terminado"].Value != DBNull.Value) estado = 6;
            else if (e.Row.Cells["Cancelado"].Value != DBNull.Value) estado = 7;
            e.Row.Cells["Estado"].Appearance.Image = estado;
        }

        private void TurnosUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key != "ApelNomb" && e.Cell.Column.Key != "NumeroDeDocumento") return;
            if (turnosUltraGrid.ActiveRow.Cells["Solicitado"].Value == DBNull.Value)
            {
                turnosUltraGrid.ActiveRow.Cells["Solicitado"].Value = new Service().HoraActual(Program.Pin);
                turnosUltraGrid.ActiveRow.Cells["idTomador"].Value = Program.IdUsuario;
            }

            if (turnosUltraGrid.ActiveRow.Cells["Presente"].Value == DBNull.Value)
            {
                turnosUltraGrid.ActiveRow.Cells["Presente"].Value = new Service().HoraActual(Program.Pin);
                turnosUltraGrid.ActiveRow.Cells["idReceptor"].Value = Program.IdUsuario;
            }

            turnosUltraGrid.ActiveRow.Cells["Dia"].Value = new Service().HoraActual(Program.Pin);
        }

        private void TurnosUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void TurnosUltraGridAfterCellActivate(object sender, EventArgs e)
        {
            if (turnosUltraGrid.ActiveCell.Column.Key == "Cancelado" &&
                turnosUltraGrid.ActiveCell.Value == DBNull.Value)
                if (turnosUltraGrid.ActiveCell.Row.Cells["Apelnomb"].Value == DBNull.Value &&
                    turnosUltraGrid.ActiveCell.Row.Cells["NumeroDeDocumento"].Value == DBNull.Value)
                {
                    MessageBox.Show(
                        "No se puede cancelar un turno no asignado.",
                        "¡Atención!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    var persona = turnosUltraGrid.ActiveCell.Row.Cells["Apelnomb"].Value != DBNull.Value
                        ? turnosUltraGrid.ActiveCell.Row.Cells["Apelnomb"].Text
                        : turnosUltraGrid.ActiveCell.Row.Cells["idTipoDeDocumento"].Text +
                          " " + turnosUltraGrid.ActiveCell.Row.Cells["NumeroDeDocumento"].Text;
                    if (MessageBox.Show(
                            "¿Seguro que desea cancelar el turno de " + persona + "?",
                            "Cancelar Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        turnosUltraGrid.ActiveCell.Value = new Service().HoraActual(Program.Pin);
                        var idEmpleado = (int) turnosUltraGrid.ActiveCell.Row.Cells["idEmpleado"].Value;
                        var fecha = (DateTime) turnosUltraGrid.ActiveCell.Row.Cells["Dia"].Value;
                        var hora = turnosUltraGrid.ActiveCell.Row.Cells["Hora"].Text;
                        var turnoNuevo = turnosUltraGrid.DisplayLayout.Bands[0].AddNew();
                        turnoNuevo.Cells["idEmpleado"].Value = idEmpleado;
                        turnoNuevo.Cells["Dia"].Value = fecha;
                        turnoNuevo.Cells["Hora"].Value = hora;
                        Ordenar();
                        MessageBox.Show(
                            "Se creó un nuevo turno vacío con la misma fecha y hora del cancelado.",
                            "Turno Cancelado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            if (turnosUltraGrid.ActiveCell.Column.Key == "Presente")
                if (turnosUltraGrid.ActiveCell.Row.Cells["Apelnomb"].Value == DBNull.Value &&
                    turnosUltraGrid.ActiveCell.Row.Cells["NumeroDeDocumento"].Value == DBNull.Value)
                {
                    MessageBox.Show("Es un turno no asignado (No hay nombre ni documento)",
                        "¡Atención!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    if (turnosUltraGrid.ActiveRow.Cells["Presente"].Value == DBNull.Value)
                    {
                        turnosUltraGrid.ActiveRow.Cells["Presente"].Value = new Service().HoraActual(Program.Pin);
                        turnosUltraGrid.ActiveRow.Cells["idReceptor"].Value = Program.IdUsuario;
                    }
                }
        }

        private bool GrabarPrestacion()
        {
            Validate();
            turnosBindingSource.EndEdit();
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
            dsTurnos.Merge(new Service().GetTurnosHoy(Program.Pin));
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
            GrabarPrestacion();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (GrabarPrestacion()) Close();
        }

        private void ButtonPadronClick(object sender, EventArgs e)
        {
            if (turnosUltraGrid.ActiveRow == null) return;
            var formPadron = new FormABCGrupos
            {
                ApelNomb = turnosUltraGrid.ActiveRow.Cells["ApelNomb"].Value.ToString(),
                NumeroDeDocumento = turnosUltraGrid.ActiveRow.Cells["NumeroDeDocumento"].Value.ToString(),
                Telefono = turnosUltraGrid.ActiveRow.Cells["Telefono"].Value.ToString()
            };
            formPadron.ShowDialog(MdiParent);
            if (formPadron.DialogResult != DialogResult.OK) return;
            turnosUltraGrid.ActiveRow.Cells["idTipoDeDocumento"].Value = new Service().IntTipoDeDocumentoDesdeIniciales(
                formPadron.ultraGrid.ActiveRow.Cells["TipoDoc"].Value.ToString(), Program.Pin);
            turnosUltraGrid.ActiveRow.Cells["NumeroDeDocumento"].Value =
                formPadron.ultraGrid.ActiveRow.Cells["NroDoc"].Value;
            turnosUltraGrid.ActiveRow.Cells["ApelNomb"].Value =
                formPadron.ultraGrid.ActiveRow.Cells["Nombre"].Value;
            turnosUltraGrid.ActiveRow.Cells["idAfiliado"].Value =
                (int) formPadron.ultraGrid.ActiveRow.Cells["idAfiliado"].Value;
            turnosUltraGrid.ActiveRow.Cells["Telefono"].Value = new Service().TelefonosDelAfiliado(
                (int) formPadron.ultraGrid.ActiveRow.Cells["idAfiliado"].Value, Program.Pin);
            turnosUltraGrid.ActiveRow.Update();
            formPadron.Close();
            formPadron.Dispose();
        }

        private void ButtonColoresClick(object sender, EventArgs e)
        {
            var colores = new FormReferenciaColoresConsultorio();
            colores.ShowDialog();
        }
    }
}