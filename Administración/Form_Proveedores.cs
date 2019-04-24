using System;
using System.ComponentModel;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormProveedores : Form1
    {
        private FormPrincipal _fp;
        public int Proveedor;

        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormABCProveedoresLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            ds_Proveedores.Merge(new Service().GetProveedor(Proveedor, Program.Pin));
            dsRubros.Merge(new Service().GetRubrosQueAdmitenValores(Program.Pin));
            dsNegocios.Merge(new Service().GetNegocios(Program.Pin));
            dsParametros.Merge(new Service().GetParametros(Program.Pin));
            categoriasIVABindingSource.DataSource = _fp.dsCategoriasIVA;
            localidadesListaBindingSource.DataSource = _fp.dsLocalidadesLista;
            bindingSourceCalle.DataSource = _fp.dsCallesLista;
            barriosBindingSource.DataSource = _fp.dsBarrios;
            if (!(bool) dsParametros.Parametros.Rows[0]["UsaNegocios"])
                proveedoresUltraGrid.DisplayLayout.Bands["FK_NegociosDelProveedor_Proveedores"].Hidden = true;
        }

        private bool Grabar()
        {
            Validate();
            proveedoresBindingSource.EndEdit();
            var aux = new Service().UpdateProveedores(ds_Proveedores, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine +
                    Environment.NewLine +
                    "Póngase en contacto con el Administrador del Sistema.",
                    "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ds_Proveedores.Clear();
                ds_Proveedores.Merge(new Service().GetProveedores(Program.Pin));
                return false;
            }
            ds_Proveedores.Merge(aux);
            ManejoDatos.AplicarUpdate(ds_Proveedores);
            return true;
        }

        private bool Verificar()
        {
            var proveedores = proveedoresUltraGrid.DisplayLayout.Bands["Proveedores"]; //Proveedores
            foreach (UltraGridRow proveedor in proveedores.GetRowEnumerator(GridRowType.DataRow)) //El proveedor
            {
                if (proveedor.Cells["RazonSocial"].Value == DBNull.Value)
                {
                    MessageBox.Show(
                        "Falta la Razón Social.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (proveedor.Cells["Serie"].Value == DBNull.Value)
                {
                    MessageBox.Show(
                        "Falta la Serie.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (proveedor.Cells["Serie"].Value.ToString() != "X")
                {
                    if (proveedor.Cells["idCategoriaIva"].Value == DBNull.Value)
                    {
                        MessageBox.Show(
                            "Falta la Categoría del IVA.",
                            "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                if (proveedor.Cells["idRubro"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el rubro.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                int direccionesReales;
                int direccionesCobranza;
                if (!VerificarDirecciones(proveedor, out direccionesReales, out direccionesCobranza)) return false;
                if (proveedor.Cells["CUIT"].Text != "__-__,___,___-_" && proveedor.Cells["CUIT"].Text != "")
                {
                    var sCUIT = proveedor.Cells["CUIT"].Text.Replace(",", "").Replace("-", "");
                    if ((int) _fp.dscuitRepetibles.CUITRepetibles.Compute("Count(CUIT)", "CUIT = " + sCUIT) == 0)
                    {
                        if (!(bool) dsParametros.Parametros.Rows[0]["ProveedoresDuplicados"])
                        {
                            var nombProveedorAnterior = new Service().NombreCuitIngresadoProveedor(sCUIT,
                                (int)
                                    proveedor.Cells["idProveedor"].Value,
                                Program.Pin);
                            if (nombProveedorAnterior.Length > 0)
                            {
                                MessageBox.Show(this,
                                    "El CUIT " + proveedor.Cells["CUIT"].Text +
                                    " ya figura en nuestros registros" +
                                    Environment.NewLine + "perteneciendo a " +
                                    nombProveedorAnterior +
                                    "." +
                                    Environment.NewLine + Environment.NewLine +
                                    "No podemos ingresarlo otra vez." +
                                    Environment.NewLine,
                                    "Falta verificar el CUIT",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return false;
                            }
                        }
                        /*Validación del CUIT, que sea válido*/

                        if (sCUIT.Length == 11)
                        {
                            var xa = int.Parse(sCUIT.Substring(0, 1))*5;
                            var xb = int.Parse(sCUIT.Substring(1, 1))*4;
                            var xc = int.Parse(sCUIT.Substring(2, 1))*3;
                            var xd = int.Parse(sCUIT.Substring(3, 1))*2;
                            var xe = int.Parse(sCUIT.Substring(4, 1))*7;
                            var xf = int.Parse(sCUIT.Substring(5, 1))*6;
                            var xg = int.Parse(sCUIT.Substring(6, 1))*5;
                            var xh = int.Parse(sCUIT.Substring(7, 1))*4;
                            var xi = int.Parse(sCUIT.Substring(8, 1))*3;
                            var xj = int.Parse(sCUIT.Substring(9, 1))*2;
                            var x = xa + xb + xc + xd + xe + xf + xg + xh + xi + xj;
                            var control = (11 - (x%11))%11;
                            if (control != int.Parse(sCUIT.Substring(10, 1)))
                            {
                                MessageBox.Show("Inválido",
                                    "Falta verificar el CUIT",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                }
                // Fin de Verificación del CUIT.
                if ((bool) dsParametros.Parametros.Rows[0]["UsaNegocios"] &&
                    (Decimal)
                        proveedoresUltraGrid.Rows[0].ChildBands["FK_NegociosDelProveedor_Proveedores"].Rows
                            .SummaryValues["TotalNegocios"].Value != 100)
                {
                    MessageBox.Show("El total de los negocios no suma 100%.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private static void ValidarEmails(CancelEventArgs e, UltraGridRow renglonActivo)
        {
            if ((renglonActivo.Band.Key == "FK_Emails_Proveedores" || renglonActivo.Band.Key == "FK_Emails_Contactos") &&
                renglonActivo.Cells["Email"].Value != DBNull.Value)
            {
                if (ManejoDatos.IsValidEmail(renglonActivo.Cells["Email"].Value.ToString())) return;
                e.Cancel = true;
                MessageBox.Show(
                    "No es una dirección de e-mail válida.",
                    "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarDirecciones(UltraGridRow cadaGrupo, out int direccionesReales, out int direccionesCobranza)
        {
            direccionesReales = 0;
            direccionesCobranza = 0;
            foreach (var direccion in cadaGrupo.ChildBands["FK_Direcciones_Proveedores"].Rows)
            {
                if (direccion.Cells["Real"].Text == "True")
                {
                    direccionesReales++;
                }
                if (direccion.Cells["Cobranza"].Text == "True")
                {
                    direccionesCobranza++;
                    //var row = direccion;
                }
                if (direccion.Cells["idLocalidad"].Value == DBNull.Value)
                {
                    MessageBox.Show("Hay una dirección sin Localidad.",
                        "Imposible Grabar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!VerificarDireccionesCalle(direccion)) return false;
                if (!VerificarDireccionesEntreCalle1(direccion)) return false;
                if (!VerificarDireccionesEntreCalle2(direccion)) return false;
                if (!VerificarDireccionesBarrio(direccion)) return false;
            }
            return true;
        }

        private bool VerificarDireccionesBarrio(UltraGridRow direccion)
        {
            if (direccion.Cells["idBarrio"].Value != DBNull.Value &&
                _fp.dsBarrios.BarriosLista.FindByidBarrio((int) direccion.Cells["idBarrio"].Value).
                    idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                   "El barrio " + direccion.Cells["idBarrio"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool VerificarDireccionesEntreCalle2(UltraGridRow direccion)
        {
            if (direccion.Cells["idEntreCalle2"].Value != DBNull.Value &&
                _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle2"].Value).
                    idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                    "La calle " + direccion.Cells["idEntreCalle2"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool VerificarDireccionesEntreCalle1(UltraGridRow direccion)
        {
            if (direccion.Cells["idEntreCalle1"].Value != DBNull.Value &&
                _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idEntreCalle1"].Value).
                    idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                    "La calle " + direccion.Cells["idEntreCalle1"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool VerificarDireccionesCalle(UltraGridRow direccion)
        {
            if (direccion.Cells["idCalle"].Value != DBNull.Value &&
                _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idCalle"].Value).idLocalidad !=
                (int) direccion.Cells["idLocalidad"].Value)
            {
                MessageBox.Show(
                    "La calle " + direccion.Cells["idCalle"].Text +
                    " no pertenece a " +
                    direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (Verificar())
            {
                if (Grabar())
                {
                    Close();
                }
            }
        }

        private void ProveedoresUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }

        private void ProveedoresUltraGrid_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
        }

        private void ProveedoresUltraGrid_CellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "Serie")
            {
                if (e.Cell.Text == "" || e.Cell.Text == "Sin Factura")
                {
                    e.Cell.Row.Cells["CUIT"].Hidden = true;
                    e.Cell.Row.Cells["CUIT"].Column.TabStop = false;
                    e.Cell.Row.Cells["CUIT"].Value = DBNull.Value;
                    e.Cell.Row.Cells["idCategoriaIva"].Hidden = true;
                    e.Cell.Row.Cells["idCategoriaIva"].Column.TabStop = false;
                    e.Cell.Row.Cells["idCategoriaIva"].Value = DBNull.Value;
                }
                else
                {
                    e.Cell.Row.Cells["CUIT"].Hidden = false;
                    e.Cell.Row.Cells["CUIT"].Column.TabStop = true;
                    e.Cell.Row.Cells["idCategoriaIva"].Hidden = false;
                    e.Cell.Row.Cells["idCategoriaIva"].Column.TabStop = true;
                }
            }
            if (e.Cell.Column.Key == "idLocalidad")
            {
                ultraDropDownBarrios.DisplayLayout.RefreshFilters();
                ultraDropDownCalle.DisplayLayout.RefreshFilters();
            }
        }

        private void UltraDropDownCalleFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = proveedoresUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                    FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                    FilterComparisionOperator.Equals,
                    _fp.dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                        (int)
                            proveedoresUltraGrid.ActiveRow.Cells["idLocalidad"].Value).
                        idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownBarriosFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = proveedoresUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                ? new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                    FilterComparisionOperator.Equals, 0)
                : new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                    FilterComparisionOperator.Equals,
                    _fp.dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                        (int)
                            proveedoresUltraGrid.ActiveRow.Cells["idLocalidad"].Value).
                        idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownLocalidadesRowSelected(object sender, RowSelectedEventArgs e)
        {
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalle.DisplayLayout.RefreshFilters();
        }

        private void ProveedoresUltraGrid_AfterRowUpdate(object sender, RowEventArgs e)
        {
            if (e.Row.Band.Key == "FK_NegociosDelProveedor_Proveedores")
            {
                var negocio = (int) e.Row.Cells["idNegocio"].Value;
                var nombreNegocio = e.Row.Cells["idNegocio"].Text;
                if (
                    (int)
                        ds_Proveedores.NegociosDelProveedor.Compute("Count(idNegocio)",
                            "idNegocio = " + negocio) >
                    1)
                {
                    MessageBox.Show(
                        nombreNegocio +
                        " ya está ingresado.",
                        "Negocio", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    proveedoresUltraGrid.BeforeRowsDeleted += ProveedoresUltraGrid_BeforeRowsDeleted;
                    proveedoresUltraGrid.ActiveRow.Delete();
                    proveedoresUltraGrid.UpdateData();
                    proveedoresUltraGrid.BeforeRowsDeleted -= ProveedoresUltraGrid_BeforeRowsDeleted;
                }
            }
        }

        private void ProveedoresUltraGrid_BeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            var renglonActivo = proveedoresUltraGrid.ActiveRow;
            ValidarEmails(e, renglonActivo);
            if (renglonActivo.Band.Key == "Proveedores")
            {
                if (renglonActivo.Cells["Serie"].Value == DBNull.Value)
                {
                    MessageBox.Show(
                        "Falta el rubro.",
                        "Faltan Datos", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                // Verificación del CUIT
                if (
                    (renglonActivo.Cells["CUIT"].Value == DBNull.Value ||
                     renglonActivo.Cells["CUIT"].Text == "__-__,___,___-_"
                        ) &&
                    "AC".Contains(renglonActivo.Cells["Serie"].Value.ToString())
                    )
                {
                    MessageBox.Show("Falta el CUIT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }
                if (renglonActivo.Cells["idRubro"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el rubro.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void ProveedoresUltraGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Band.Key == "Proveedores" && !e.ReInitialize)
            {
                e.Row.Cells["CUIT"].Hidden = e.Row.Cells["Serie"].Value == DBNull.Value ||
                                             e.Row.Cells["Serie"].Value.ToString() == "X";
            }
        }

        private void proveedoresUltraGrid_BeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            if (proveedoresUltraGrid.ActiveCell.Column.Key == "CUIT")
            {
                if (proveedoresUltraGrid.ActiveCell.Text != "__-__,___,___-_" &&
                    proveedoresUltraGrid.ActiveCell.Text != "")
                {
                    var sCUIT = proveedoresUltraGrid.ActiveCell.Text.Replace(",", "").Replace("-", "");
                    if ((int) _fp.dscuitRepetibles.CUITRepetibles.Compute("Count(CUIT)", "CUIT = " + sCUIT) == 0)
                    {
                        if (!(bool) dsParametros.Parametros.Rows[0]["ProveedoresDuplicados"])
                        {
                            var nombProveedorAnterior = new Service().NombreCuitIngresadoProveedor(sCUIT,
                                (int)
                                    proveedoresUltraGrid.ActiveRow.Cells["idProveedor"].Value,
                                Program.Pin);
                            if (nombProveedorAnterior.Length > 0)
                            {
                                MessageBox.Show(this,
                                    "El CUIT " + proveedoresUltraGrid.ActiveCell.Text +
                                    " ya figura en nuestros registros" +
                                    Environment.NewLine + "perteneciendo a " +
                                    nombProveedorAnterior +
                                    "." +
                                    Environment.NewLine + Environment.NewLine +
                                    "No podemos ingresarlo otra vez." +
                                    Environment.NewLine,
                                    "Falta verificar el CUIT",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                e.Cancel = true;
                            }
                        }
                        /*Validación del CUIT, que sea válido*/

                        if (sCUIT.Length == 11)
                        {
                            var xa = int.Parse(sCUIT.Substring(0, 1))*5;
                            var xb = int.Parse(sCUIT.Substring(1, 1))*4;
                            var xc = int.Parse(sCUIT.Substring(2, 1))*3;
                            var xd = int.Parse(sCUIT.Substring(3, 1))*2;
                            var xe = int.Parse(sCUIT.Substring(4, 1))*7;
                            var xf = int.Parse(sCUIT.Substring(5, 1))*6;
                            var xg = int.Parse(sCUIT.Substring(6, 1))*5;
                            var xh = int.Parse(sCUIT.Substring(7, 1))*4;
                            var xi = int.Parse(sCUIT.Substring(8, 1))*3;
                            var xj = int.Parse(sCUIT.Substring(9, 1))*2;
                            var x = xa + xb + xc + xd + xe + xf + xg + xh + xi + xj;
                            var control = (11 - (x%11))%11;
                            if (control != int.Parse(sCUIT.Substring(10, 1)))
                            {
                                MessageBox.Show("Inválido",
                                    "Falta verificar el CUIT",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                e.Cancel = true;
                            }
                        }
                    }
                }
            }
        }

        #region BeforeDropDown

        private void UltraDropDownBarriosBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownBarrios.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownCalleBeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCalle.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void UltraDropDownCategoriasIVABeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownCategoriasIVA.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        #endregion

        #region BeforeDropDown

        private void ultraDropDownSeries_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownSeries.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownRubros_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownRubros.DisplayLayout.Bands[0].Columns["NombreCompleto"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        private void ultraDropDownNegocios_BeforeDropDown(object sender, CancelEventArgs e)
        {
            ultraDropDownNegocios.DisplayLayout.Bands[0].Columns["Nombre"].PerformAutoResize(
                PerformAutoSizeType.AllRowsInBand);
        }

        #endregion

        private void proveedoresUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                proveedoresUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}