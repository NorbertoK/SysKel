namespace Administración
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using WS;
    using Infragistics.Win.UltraWinGrid;
    using Resources = Properties.Resources;

    public partial class FormBajasOCambios : Form1
    {
        public FormBajasOCambios()
        {
            InitializeComponent();
        }

        public int IdGrupo { private get; set; }

        private void FormBajasOCambiosLoad(object sender, EventArgs e)
        {
            dsBajasOCambios.BajasOCambios.idGrabadorColumn.DefaultValue = Program.IdUsuario;
            dsBajasOCambios.Merge(new Service().GetAfiliadosPlanesDelGrupo(IdGrupo, Program.Pin));
            var padre = dsBajasOCambios.BajasOCambios.NewBajasOCambiosRow();
            var fecha = new Service().HoraActual(Program.Pin);
            padre.FechaRegistro = fecha;
            padre.Fecha = fecha;
            padre.Alta = false;
            padre.Baja = false;
            padre.EsCambioDePlan = false;
            dsBajasOCambios.BajasOCambios.AddBajasOCambiosRow(padre);
            foreach (DataRow renglon in dsBajasOCambios.AfiliadosPlanesDelGrupo.Rows)
            {
                dsBajasOCambios.BajasOCambiosDetalles.AddBajasOCambiosDetallesRow(dsBajasOCambios.BajasOCambios[0],
                                                                                  false, (int) renglon["idAfiliado"],
                                                                                  (int) renglon["idPlanDeBaja"],
                                                                                  (string) renglon["Estado"]);
            }
            dsBajasOCambios.Merge(new Service().GetAfiliadosDelGrupo(IdGrupo, Program.Pin));
            bajasOCambiosUltraGrid.Rows.ExpandAll(false);
        }

        private void UltraDropDownPlanesFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownVendedorFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownTomadoresDeBajaFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void FormBajasOCambiosActivated(object sender, EventArgs e)
        {
            dsMotivosDeBaja.Merge(new Service().GetMotivosDeBaja(Program.Pin));
            dsPlanes.Merge(new Service().GetPlanes(Program.Pin));
            dsTomadoresDeBaja.Merge(new Service().GetEmpleadosLista(Program.Pin));
            dsVendedores.Merge(new Service().GetVendedores(Program.Pin));
            dsUsuariosLista1.Merge(new Service().GetUsuariosLista(Program.Pin));
        }

        private void BajasOCambiosUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key == "BajasOCambios")
            {
                if (e.Row.Cells["Baja"].Text == "True")
                {
                    e.Row.Cells["idMotivoDeBaja"].Hidden = false;
                    e.Row.Cells["idTomadorDeBaja"].Hidden = false;
                }
                else
                {
                    e.Row.Cells["idMotivoDeBaja"].Hidden = true;
                    e.Row.Cells["idTomadorDeBaja"].Hidden = true;
                }
                if (e.Row.Cells["Alta"].Text == "True")
                {
                    e.Row.Cells["idVendedor"].Hidden = false;
                    e.Row.Cells["idPlanNuevo"].Hidden = false;
                }
                else
                {
                    e.Row.Cells["idVendedor"].Hidden = true;
                    e.Row.Cells["idPlanNuevo"].Hidden = true;
                }
            }
            if (e.Row.Band.Key != "FK_BajasOCambiosDetalles_BajasOCambios") return;
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
        }

        private void BajasOCambiosUltraGridCellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "Baja")
            {
                if (e.Cell.Text == "True")
                {
                    e.Cell.Row.Cells["idMotivoDeBaja"].Hidden = false;
                    e.Cell.Row.Cells["idTomadorDeBaja"].Hidden = false;
                }
                else
                {
                    e.Cell.Row.Cells["idMotivoDeBaja"].Hidden = true;
                    e.Cell.Row.Cells["idTomadorDeBaja"].Hidden = true;
                    e.Cell.Row.Cells["idMotivoDeBaja"].Value = DBNull.Value;
                    e.Cell.Row.Cells["idTomadorDeBaja"].Value = DBNull.Value;
                }
            }
            if (e.Cell.Column.Key != "Alta") return;
            if (e.Cell.Text == "True")
            {
                e.Cell.Row.Cells["idVendedor"].Hidden = false;
                e.Cell.Row.Cells["idPlanNuevo"].Hidden = false;
            }
            else
            {
                e.Cell.Row.Cells["idVendedor"].Hidden = true;
                e.Cell.Row.Cells["idPlanNuevo"].Hidden = true;
                e.Cell.Row.Cells["idVendedor"].Value = DBNull.Value;
                e.Cell.Row.Cells["idPlanNuevo"].Value = DBNull.Value;
            }
        }

        private bool Verificado()
        {
            if (bajasOCambiosUltraGrid.Rows[0].Cells["Baja"].Text == "True")
            {
                if (bajasOCambiosUltraGrid.Rows[0].Cells["idMotivoDeBaja"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el Motivo de Baja.", "Imposible Grabar", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
                if (bajasOCambiosUltraGrid.Rows[0].Cells["idTomadorDeBaja"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el Tomador de la Baja.", "Imposible Grabar", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            if (bajasOCambiosUltraGrid.Rows[0].Cells["Alta"].Text == "True")
            {
                if (bajasOCambiosUltraGrid.Rows[0].Cells["idVendedor"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el Vendedor.", "Imposible Grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (bajasOCambiosUltraGrid.Rows[0].Cells["idPlanNuevo"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el plan nuevo.", "Imposible Grabar", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
            }
            if (bajasOCambiosUltraGrid.Rows[0].Cells["EsCambioDePlan"].Text == "True" &&
                (bajasOCambiosUltraGrid.Rows[0].Cells["Baja"].Text == "False" ||
                 bajasOCambiosUltraGrid.Rows[0].Cells["Alta"].Text == "False"))
            {
                MessageBox.Show("Sólo puede ser Cambio de Plan si hay Baja y Alta.", "Imposible Grabar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool Updateado()
        {
            var aux = new Service().UpdateBajasOCambios(dsBajasOCambios, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(this, "No se pudo grabar", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            new Service().BajasOCambios((int) aux.BajasOCambios.Rows[0][0], Program.Pin);
            var mensajeCantidadTitulares = new Service().MensajeCantidadDeTitulares(IdGrupo, Program.Pin);
            if (mensajeCantidadTitulares.Length > 0)
            {
                MessageBox.Show(this, mensajeCantidadTitulares + Environment.NewLine + "Corríjalo donde corresponde.",
                                "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if ((int) dsBajasOCambios.AfiliadosDelGrupo.Rows[0]["idTipoDeCobranza"] == 3 &&
                new Service().HayAlgunAfiliadoActivo(IdGrupo, new Service().HoraActual(Program.Pin), Program.Pin) == 1)
            {
                MessageBox.Show(
                    "Habiendo Afiliados Propios activos" + Environment.NewLine +
                    "el Tipo De Cobranza no puede ser Contrato. " + Environment.NewLine + "Corríjalo donde corresponde.",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            new Service().ActualizarGrupoActivo(IdGrupo, Program.Pin);
            return true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            if (Verificado())
            {
                if (Updateado())
                {
                    Close();
                }
                else
                {
                    buttonAceptar.Enabled = true;
                }
            }
            else
            {
                buttonAceptar.Enabled = true;
            }
        }

        private void bajasOCambiosUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bajasOCambiosUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void bajasOCambiosUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}