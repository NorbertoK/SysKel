using System.Globalization;

namespace Cabina
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
    using WS;
    using Infragistics.Win;
    using Infragistics.Win.UltraWinGrid;
    using BeforeExitEditModeEventArgs = Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs;
    using ColumnStyle = Infragistics.Win.UltraWinGrid.ColumnStyle;
    using Resources = Properties.Resources;

    public partial class FormGrupos : Form1
    {
        private readonly int _grupo;
        private FormPrincipalCabina _fp;

        public FormGrupos(int grupo)
        {
            InitializeComponent();
            _grupo = grupo;
        }

        public string ApelNomb { get; set; }
        public string NumeroDeDocumento { get; set; }
        public string Telefono { get; set; }

        private void FormGruposLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipalCabina) Owner;
            localidadesListaBindingSource.DataSource = _fp.dsLocalidadesLista;
            bindingSourceCalle.DataSource = _fp.dsCallesLista;
            tiposDeCobranzaBindingSource.DataSource = _fp.dsTiposDeCobranza;
            medicosDeCabeceraListaBindingSource.DataSource = _fp.dsMedicosDeCabecera;
            entidadesDeCobranzaBindingSource.DataSource = _fp.dsEntidadesDeCobranza;
            ocupacionesBindingSource.DataSource = _fp.dsOcupaciones;
            vendedoresBindingSource.DataSource = _fp.dsVendedores;
            barriosBindingSource.DataSource = _fp.dsBarrios;
            tiposDeDocumentoBindingSource.DataSource = _fp.dsTiposDeDocumento;
            lugaresBindingSource.DataSource = _fp.dsLugares;
            motivosDeBajaBindingSource.DataSource = _fp.dsMotivosDeBaja;
            prepagosBindingSource.DataSource = _fp.dsPrepagos;
            zonasBindingSource.DataSource = _fp.dsZonas;
            tomadoresDeBajaBindingSource.DataSource = _fp.dsEmpleadosLista;
            usuariosListaBindingSource.DataSource = _fp.dsUsuariosLista;

            gruposUltraGrid.Rows.ExpandAll(false);

            if ((string) Tag != "N") //No es un grupo nuevo. Cargo los datos del grupo.
            {
                dsAfiliados.Merge(new Service().GetGrupo(_grupo, Program.Pin));
                buttonEstadoActualDelGrupo.Enabled = true;
            }
            else
            {
                gruposUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Afiliados"].Columns["AltaBajaSusp"].DefaultCellValue
                    = "A"; // Es un grupo nuevo, lo más probable es que las solicitudes sean de Alta.
                gruposUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Afiliados"].Columns["Fecha"].DefaultCellValue
                    = new Service().HoraActual(Program.Pin);
                gruposUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Afiliados"].Columns["idVendedor"].DefaultCellValue
                    = _fp.dsSistemas.Sistemas.Rows[0]["VendedorAfiliadosContrato"];
                gruposUltraGrid.DisplayLayout.Bands["FK_AfiliadosPlanes_Solicitudes"].Columns["idPlan"].DefaultCellValue = _fp.dsSistemas.Sistemas.Rows[0]["PlanConsultorio"];
            }

            if ((string) Tag == "V") // Visualizar.
            {
                buttonAceptar.Visible = false;
                buttonAplicar.Visible = false;
                buttonCancelar.Visible = false;
                buttonCancelarNoHeredado.Visible = false;
                buttonSalir.Visible = true;
                foreach (var banda in gruposUltraGrid.DisplayLayout.Bands)
                {
                    banda.Override.AllowAddNew = AllowAddNew.No;
                    foreach (var columna in banda.Columns)
                    {
                        columna.Style = ColumnStyle.Edit;
                    }
                }
                gruposUltraGrid.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect;
                gruposUltraGrid.DisplayLayout.Override.AllowDelete = DefaultableBoolean.False;
            }

            /*Llena el combo TipoSolicitud*/
            gruposUltraGrid.DisplayLayout.ValueLists.Add("TiposDeSolicitud");
            gruposUltraGrid.DisplayLayout.ValueLists["TiposDeSolicitud"].ValueListItems.Add("A", "Alta");
            gruposUltraGrid.DisplayLayout.ValueLists["TiposDeSolicitud"].ValueListItems.Add("B", "Baja");
            gruposUltraGrid.DisplayLayout.ValueLists["TiposDeSolicitud"].ValueListItems.Add("S", "Suspensión");
            gruposUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Afiliados"].Columns["AltaBajaSusp"].ValueList =
                gruposUltraGrid.DisplayLayout.ValueLists["TiposDeSolicitud"];

            /*Llena el combo Sexo*/
            gruposUltraGrid.DisplayLayout.ValueLists.Add("Sexo");
            gruposUltraGrid.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add("F", "Femenino");
            gruposUltraGrid.DisplayLayout.ValueLists["Sexo"].ValueListItems.Add("M", "Masculino");
            gruposUltraGrid.DisplayLayout.Bands["FK_Afiliados_Grupos"].Columns["Sexo"].ValueList =
                gruposUltraGrid.DisplayLayout.ValueLists["Sexo"];

            /*Conecta el Grid*/
            gruposUltraGrid.DataBind();

            /*Que el documento por default sea DNI*/
            gruposUltraGrid.DisplayLayout.Bands["FK_Afiliados_Grupos"].Columns["idTipoDeDocumento"].DefaultCellValue =
                new Service().DefaultDNI(Program.Pin);

            /*Que la fecha de registro de la Solicitud sea la actual*/
            gruposUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Afiliados"].Columns["FechaRegistro"].DefaultCellValue =
                new Service().HoraActual(Program.Pin);
            gruposUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Afiliados"].Columns["idGrabador"].DefaultCellValue =
                Program.IdUsuario;
            var marcador = " ";
            if (ApelNomb.IndexOf(", ", StringComparison.Ordinal) != -1) marcador = ", ";
            else if (ApelNomb.IndexOf(",", StringComparison.Ordinal) != -1) marcador = ",";
            try
            {
                gruposUltraGrid.DisplayLayout.Bands["FK_Afiliados_Grupos"].Columns["Apellido"].DefaultCellValue =
                    ApelNomb.Substring(0, ApelNomb.IndexOf(marcador, StringComparison.Ordinal));
                gruposUltraGrid.DisplayLayout.Bands["FK_Afiliados_Grupos"].Columns["Nombre"].DefaultCellValue =
                ApelNomb.Substring(ApelNomb.IndexOf(marcador, StringComparison.Ordinal) + marcador.Length);
            }
            catch (Exception)
            {
                gruposUltraGrid.DisplayLayout.Bands["FK_Afiliados_Grupos"].Columns["Apellido"].DefaultCellValue =
                    ApelNomb;
            }
            gruposUltraGrid.DisplayLayout.Bands["FK_Afiliados_Grupos"].Columns["NumeroDeDocumento"].DefaultCellValue =
                NumeroDeDocumento;
        }

        private bool Verificar()
        {
            var grupos = gruposUltraGrid.DisplayLayout.Bands["Grupos"]; //Grupos
            foreach (UltraGridRow cadaGrupo in grupos.GetRowEnumerator(GridRowType.DataRow))
                // Cada grupo, y hay uno solo.
            {
                if (cadaGrupo.Cells["idTipoDeCobranza"].Value == DBNull.Value)
                {
                    MessageBox.Show("Falta el Tipo de Cobranza.",
                                    "Grupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (
                    _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                        (int) cadaGrupo.Cells["idTipoDeCobranza"].Value).RequiereEntidadDeCobranza)
                {
                    if (cadaGrupo.Cells["idEntidadDeCobranza"].Value == DBNull.Value)
                    {
                        MessageBox.Show("Falta la Entidad de Cobranza.",
                                        "Grupo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return false;
                    }
                    if (
                        _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                            (int) cadaGrupo.Cells["idEntidadDeCobranza"].Value).RequiereDocTitular &&
                        cadaGrupo.Cells["NumeroDocumentoTitularTarjeta"].Value == DBNull.Value)
                    {
                        MessageBox.Show("Falta el Documento del Titular de la Tarjeta.",
                                        "Entidad de Cobranza",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (
                        _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                            (int) cadaGrupo.Cells["idEntidadDeCobranza"].Value).RequiereVencimiento &&
                        cadaGrupo.Cells["VencimientoTarjeta"].Value == DBNull.Value)
                    {
                        MessageBox.Show("Falta el vencimiento de la Tarjeta.",
                                        "Entidad de Cobranza",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (
                        _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                            (int) cadaGrupo.Cells["idEntidadDeCobranza"].Value).RequiereNombreTitular &&
                        cadaGrupo.Cells["NombreTitularTarjeta"].Value == DBNull.Value)
                    {
                        MessageBox.Show("Falta el nombre del Titular de la Tarjeta.",
                                        "Entidad de Cobranza",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (
                        _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                            (int) cadaGrupo.Cells["idEntidadDeCobranza"].Value).RequiereNumero &&
                        cadaGrupo.Cells["NumeroTarjeta"].Value == DBNull.Value)
                    {
                        MessageBox.Show("Falta el número de la Tarjeta.",
                                        "Entidad de Cobranza",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (
                        _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                            (int) cadaGrupo.Cells["idEntidadDeCobranza"].Value).RequiereTelTitular &&
                        cadaGrupo.Cells["TelefonoTitularTarjeta"].Value == DBNull.Value)
                    {
                        MessageBox.Show("Falta el teléfono del Titular de la Tarjeta.",
                                        "Entidad de Cobranza",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                var afiliados = 0;
                foreach (var afiliado in cadaGrupo.ChildBands["FK_Afiliados_Grupos"].Rows) //Cada Afiliado
                {
                    afiliados = afiliados + 1;
                    var nombre = afiliado.Cells["Nombre"].Text + " " + afiliado.Cells["Apellido"].Text;
                    var solicitudes = 0;
                    foreach (var solicitud in afiliado.ChildBands["FK_Solicitudes_Afiliados"].Rows)
                        //Solicitudes
                    {
                        solicitudes++;
                        if (solicitud.HasChild() == false)
                        {
                            MessageBox.Show(this,
                                            nombre +
                                            " tiene una Solicitud sin ningún Plan.",
                                            "¡Atención!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        /* Validación de otros datos de la Solicitud.*/

                        if (solicitud.Cells["AltaBajaSusp"].Text == "")
                        {
                            MessageBox.Show("Falta el Tipo de Solicitud",
                                            "Solicitud de " + nombre,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        if (solicitud.Cells["Fecha"].Text == "")
                        {
                            MessageBox.Show("Falta la Fecha",
                                            "Solicitud de " + nombre,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return false;
                        }

                        if (solicitud.Cells["AltaBajaSusp"].Text == "Alta"
                            && solicitud.Cells["idVendedor"].Text == "")
                        {
                            MessageBox.Show("Falta el Vendedor",
                                            "Solicitud de Alta de " + nombre,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        if (solicitud.Cells["AltaBajaSusp"].Text == "Baja"
                            && solicitud.Cells["idMotivoDeBaja"].Text == "")
                        {
                            MessageBox.Show("Falta el Motivo de Baja",
                                            "Solicitud de Baja de " + nombre,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        if (solicitud.Cells["AltaBajaSusp"].Text == "Baja"
                            && solicitud.Cells["idTomadorDeBaja"].Text == "")
                        {
                            MessageBox.Show("Falta el Tomador de la Baja",
                                            "Solicitud de Baja de " + nombre,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        if (solicitud.Cells["AltaBajaSusp"].Text != "Suspensión" ||
                            solicitud.Cells["FechaFinal"].Text != "") continue;
                        MessageBox.Show("Falta la Fecha Final",
                                        "Solicitud de Suspensión de " + nombre,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (solicitudes < 1)
                    {
                        MessageBox.Show(this, nombre + " no tiene ninguna Solicitud.",
                                        "Imposible Grabar",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    /* Verificación del Tipo y Número de Documento. */
                    var intIdAfiliado = (int) afiliado.Cells[0].Value;
                    int idTipoDeDocumento;
                    try
                    {
                        idTipoDeDocumento = (int) afiliado.Cells["idTipoDeDocumento"].Value;
                    }
                    catch
                    {
                        idTipoDeDocumento = 0;
                    }
                    var numeroDeDocumento = afiliado.Cells["NumeroDeDocumento"].Text.Replace(".", "").Replace("_", "");

                    if (
                        grupos.GetRowEnumerator(GridRowType.DataRow).Cast<UltraGridRow>().Any(
                            grupo1 =>
                            grupo1.ChildBands["FK_Afiliados_Grupos"].Rows.Any(
                                afiliado1 =>
                                (((!afiliado1.IsAddRow && afiliado1.Cells["NumeroDeDocumento"].Value != DBNull.Value) &&
                                  (int) afiliado1.Cells["idAfiliado"].Value != intIdAfiliado) &&
                                 (int) afiliado1.Cells["idTipoDeDocumento"].Value == idTipoDeDocumento) &&
                                Convert.ToInt32(afiliado1.Cells["NumeroDeDocumento"].Text.Replace(".", "").Replace("_",
                                                                                                                   "")).
                                    ToString(CultureInfo.InvariantCulture) == numeroDeDocumento)))
                    {
                        MessageBox.Show(
                            "El Nº de Documento " + numeroDeDocumento +
                            " está" + Environment.NewLine +
                            "más de una vez en esta ficha.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    /* Validación de la Fecha de Nacimiento */
                    try
                    {
                        if ((DateTime) afiliado.Cells["FechaDeNacimiento"].Value > new Service().HoraActual(Program.Pin))
                        {
                            MessageBox.Show("La Fecha de Nacimiento no puede ser posterior a hoy.",
                                            nombre,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        if ((DateTime) afiliado.Cells["FechaDeNacimiento"].Value <
                            new Service().HoraActual(Program.Pin).AddYears(-120))
                        {
                            MessageBox.Show("No admitimos afiliados de más de 120 años de edad.",
                                            nombre,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch (InvalidCastException)
                    {
                        //Si dejo la fecha vacía da un error;
                    }
                }
                if (afiliados == 0)
                {
                    MessageBox.Show("No se ingresó ningún Afiliado", "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return false;
                }
                var direccionesReales = 0;
                var direccionesCobranza = 0;
                foreach (var direccion in cadaGrupo.ChildBands["FK_Direcciones_Grupos"].Rows)
                {
                    if (direccion.Cells["Real"].Text == "True")
                    {
                        direccionesReales++;
                    }
                    if (direccion.Cells["Cobranza"].Text == "True")
                    {
                        direccionesCobranza++;
                        //var row = direccion;
                        if (direccion.Cells["idZona"].Value == DBNull.Value &&
                            //(fp.dsZonas.Zonas.AsEnumerable().Where(
                            //    z => z.Field<int?>("idZona") == (int) row.Cells["idZona"].Value &&
                            //         z.IsNull("idLocalidad"))).Count() == 0 &&
                            _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                                (int) gruposUltraGrid.DisplayLayout.Rows[0].Cells["idTipoDeCobranza"].Value).
                                RequiereZonaDeCobranza)
                        {
                            MessageBox.Show("Se requiere la Zona en la Dirección de Cobranza.",
                                            "Imposible Grabar",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    if (direccion.Cells["idLocalidad"].Value == DBNull.Value)
                    {
                        MessageBox.Show("Hay una dirección sin Localidad.",
                                        "Imposible Grabar",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
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
                    try
                    {
                        if (direccion.Cells["idZona"].Value != DBNull.Value &&
                            dsZonas.Zonas.FindByidZona((int) direccion.Cells["idZona"].Value).idLocalidad !=
                            (int) direccion.Cells["idLocalidad"].Value)
                        {
                            MessageBox.Show(
                                "No hay ningún Contrato." + direccion.Cells["idZona"].Text +
                                " no pertenece a " +
                                direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch (NullReferenceException)
                    {
                    }
                }
                foreach (var afiliado in cadaGrupo.ChildBands["FK_Afiliados_Grupos"].Rows)
                {
                    foreach (var direccion in afiliado.ChildBands["FK_Direcciones_Afiliados"].Rows)
                    {
                        if (direccion.Cells["idLocalidad"].Value == DBNull.Value) continue;
                        if (direccion.Cells["idCalle"].Value != DBNull.Value &&
                            _fp.dsCallesLista.Calles.FindByidCalle((int) direccion.Cells["idCalle"].Value).
                                idLocalidad != (int) direccion.Cells["idLocalidad"].Value)
                        {
                            MessageBox.Show(
                                "La calle " + direccion.Cells["idCalle"].Text +
                                " no pertenece a " +
                                direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return false;
                        }
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
                        var row = direccion;
                        if (direccion.Cells["idZona"].Value == DBNull.Value || (_fp.dsZonas.Zonas.AsEnumerable().Where(
                            z =>
                            z.Field<int?>("idZona") ==
                            (int) row.Cells["idZona"].Value &&
                            z.IsNull("idLocalidad"))).Count() ==
                                                                               1 ||
                            _fp.dsZonas.Zonas.FindByidZona((int) direccion.Cells["idZona"].Value).idLocalidad ==
                            (int) direccion.Cells["idLocalidad"].Value
                            ) continue;

                        MessageBox.Show(
                            "No hay ningún Contrato." + direccion.Cells["idZona"].Text +
                            " no pertenece a " +
                            direccion.Cells["idLocalidad"].Text + ".", "No se pudo grabar",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                if (direccionesReales < 1)
                {
                    MessageBox.Show("No hay ninguna Dirección Real del Grupo." +
                                    Environment.NewLine +
                                    "No es imprescindible.", "¡Atención!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                if (direccionesReales > 1)
                {
                    MessageBox.Show("Hay más de una Dirección Real del Grupo",
                                    "Imposible Grabar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (direccionesCobranza < 1)
                {
                    if (
                        _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                            (int) gruposUltraGrid.DisplayLayout.Rows[0].Cells["idTipoDeCobranza"].Value).
                            RequiereZonaDeCobranza)
                    {
                        MessageBox.Show("No hay ninguna Dirección de Cobranza del Grupo",
                                        "Imposible Grabar",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                if (direccionesCobranza <= 1) continue;
                MessageBox.Show("Hay más de una Dirección de Cobranza del Grupo",
                                "Imposible Grabar",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool Updatear()
        {
            var aux = new Service().UpdateGrupo(dsAfiliados, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show("No se pudo Grabar.", "¡Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            dsAfiliados.Clear();
            dsAfiliados.Merge(aux);
            ManejoDatos.AplicarUpdate(dsAfiliados);
            gruposUltraGrid.Rows.ExpandAll(true);
            var mensajeCantidadTitulares =
                new Service().MensajeCantidadDeTitulares((int) gruposUltraGrid.Rows[0].Cells[0].Value, Program.Pin);
            if (mensajeCantidadTitulares.Length > 0)
            {
                MessageBox.Show(this, mensajeCantidadTitulares, "¡Atención!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            if ((int) gruposUltraGrid.DisplayLayout.Rows[0].Cells["idTipodeCobranza"].Value == 3 &&
                new Service().HayAlgunAfiliadoActivo(
                    (int) gruposUltraGrid.DisplayLayout.Rows[0].Cells["idGrupo"].Value,
                    new Service().HoraActual(Program.Pin), Program.Pin) == 1)
            {
                MessageBox.Show(
                    "Habiendo Afiliados Propios activos" + Environment.NewLine +
                    "el Tipo De Cobranza no puede ser Contrato. ",
                    "Imposible Grabar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            new Service().ActualizarGrupoActivo((int) dsAfiliados.Grupos.Rows[0]["idGrupo"], Program.Pin);
            return true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            ActivarSolicitudYPlan();
            if (!Verificar()) return;
            if (Updatear())
            {
                buttonAplicar.Enabled = false;
            }
            buttonEstadoActualDelGrupo.Enabled = true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (buttonAplicar.Enabled)
            {
                ActivarSolicitudYPlan();
                if (Verificar())
                {
                    if (Updatear())
                    {
                        buttonAplicar.Enabled = false;
                        Close();
                    }
                }
                else
                {
                    buttonAceptar.Enabled = false;
                }
            }
            else
            {
                Close();
            }
        }

        private void GruposUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }


        private void GruposUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }

        private void ButtonSalirClick(object sender, EventArgs e)
        {
            Close();
        }

        private void GruposUltraGridBeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            var renglonActivo = gruposUltraGrid.ActiveRow;
            if (renglonActivo.Band.Key == "FK_Emails_Afiliados" || renglonActivo.Band.Key == "FK_Emails_Contactos")
            {
                if (ManejoDatos.IsValidEmail(renglonActivo.Cells["Email"].Value.ToString()) == false)
                {
                    e.Cancel = true;
                    MessageBox.Show("No es una dirección de e-mail válida.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (renglonActivo.Band.Key == "FK_Solicitudes_Afiliados")
            {
                if (renglonActivo.Cells["AltaBajaSusp"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el Tipo de Solicitud",
                                    "Solicitud",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                if (renglonActivo.Cells["Fecha"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta la Fecha",
                                    "Solicitud",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Alta"
                    && renglonActivo.Cells["idVendedor"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el Vendedor",
                                    "Solicitud de Alta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Baja"
                    && renglonActivo.Cells["idMotivoDeBaja"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el Motivo de Baja",
                                    "Solicitud de Baja",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Baja"
                    && renglonActivo.Cells["idTomadorDeBaja"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta el Tomador de la Baja",
                                    "Solicitud de Baja",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Suspensión"
                    && renglonActivo.Cells["FechaFinal"].Text == "")
                {
                    e.Cancel = true;
                    MessageBox.Show("Falta la Fecha Final",
                                    "Solicitud de Suspensión",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            if (renglonActivo.Band.Key != "Grupos") return;
            if (renglonActivo.Cells["idTipoDeCobranza"].Value == DBNull.Value)
            {
                MessageBox.Show("Falta el Tipo de Cobranza.",
                                "renglonActivo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                if (
                    _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                        (int) renglonActivo.Cells["idTipoDeCobranza"].Value).RequiereEntidadDeCobranza)
                {
                    if (renglonActivo.Cells["idEntidadDeCobranza"].Value == DBNull.Value)
                    {
                        MessageBox.Show("Falta la Entidad de Cobranza.",
                                        "renglonActivo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else
                    {
                        if (
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereNumero &&
                            renglonActivo.Cells["NumeroTarjeta"].Value == DBNull.Value)
                        {
                            MessageBox.Show("Falta el número de la Tarjeta.",
                                            "Entidad de Cobranza",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                        else
                        {
                            if (
                                _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                    (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereVencimiento &&
                                renglonActivo.Cells["VencimientoTarjeta"].Value == DBNull.Value)
                            {
                                MessageBox.Show("Falta el vencimiento de la Tarjeta.",
                                                "Entidad de Cobranza",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                                e.Cancel = true;
                            }
                            else
                            {
                                if (
                                    _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                        (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).
                                        RequiereNombreTitular &&
                                    renglonActivo.Cells["NombreTitularTarjeta"].Value == DBNull.Value)
                                {
                                    MessageBox.Show(
                                        "Falta el nombre del Titular de la Tarjeta.",
                                        "Entidad de Cobranza", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    e.Cancel = true;
                                }
                                else
                                {
                                    if (
                                        _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                            (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).
                                            RequiereDocTitular &&
                                        renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Value == DBNull.Value)
                                    {
                                        MessageBox.Show(
                                            "Falta el Documento del Titular de la Tarjeta.",
                                            "Entidad de Cobranza", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                        e.Cancel = true;
                                    }
                                    else
                                    {
                                        if (
                                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).
                                                RequiereTelTitular &&
                                            renglonActivo.Cells["TelefonoTitularTarjeta"].Value == DBNull.Value)
                                        {
                                            MessageBox.Show(
                                                "Falta el teléfono del Titular de la Tarjeta.",
                                                "Entidad de Cobranza",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                            e.Cancel = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void GruposUltraGridAfterCellUpdate(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "FechaDeNacimiento" && e.Cell.Value.ToString() != "")
            {
                e.Cell.Row.Cells["Edad"].Value = ManejoDatos.Edad((DateTime) e.Cell.Value);
            }
        }

        private void GruposUltraGridAfterRowActivate(object sender, EventArgs e)
        {
            if (gruposUltraGrid.ActiveRow.Band.Key == "FK_Direcciones_Grupos" ||
                gruposUltraGrid.ActiveRow.Band.Key == "FK_Direcciones_Afiliados")
            {
                ultraDropDownZonas.DisplayLayout.RefreshFilters();
                ultraDropDownBarrios.DisplayLayout.RefreshFilters();
                ultraDropDownCalle.DisplayLayout.RefreshFilters();
            }
            if (gruposUltraGrid.ActiveRow.Band.Key == "FK_AfiliadosPlanes_Solicitudes")
            {
                /*Rellena el combo Planes*/
                dsPlanesAfiliado.Merge(
                    new Service().GetPlanesAfiliados(
                        (int) gruposUltraGrid.ActiveRow.ParentRow.ParentRow.Cells["idAfiliado"].Value,
                        (DateTime) gruposUltraGrid.ActiveRow.ParentRow.Cells["Fecha"].Value, Program.Pin));
                gruposUltraGrid.ActiveRow.Cells["idPlan"].ValueList = ultraDropDownPlanesAfiliado;
                ultraDropDownPlanesAfiliado.DisplayLayout.RefreshFilters();
            }
            if (gruposUltraGrid.ActiveRow.Band.Key == "FK_Solicitudes_Afiliados")
            {
                gruposUltraGrid.ActiveRow.ExpandAll();
            }
        }

        private void GruposUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            var renglonActivo = e.Row;
            if (renglonActivo != null && renglonActivo.Band.Key == "Grupos")
            {
                if (renglonActivo.Cells["idTipoDeCobranza"].Value != DBNull.Value)
                {
                    if (
                        _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                            (int) renglonActivo.Cells["idTipoDeCobranza"].Value).RequiereEntidadDeCobranza != true)
                    {
                        renglonActivo.Cells["idEntidadDeCobranza"].Hidden = true;
                        renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["NombreTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["NumeroTarjeta"].Hidden = true;
                        renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["VencimientoTarjeta"].Hidden = true;
                        renglonActivo.Cells["Cobrador"].Value = Cobrador();
                        renglonActivo.Cells["Cobrador"].Hidden = (int) renglonActivo.Cells["idTipoDeCobranza"].Value !=
                                                                 1;
                    }
                    else
                    {
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereDocTitular)
                        {
                            renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereNombreTitular)
                        {
                            renglonActivo.Cells["NombreTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NombreTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereNumero)
                        {
                            renglonActivo.Cells["NumeroTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NumeroTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereTelTitular)
                        {
                            renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereVencimiento)
                        {
                            renglonActivo.Cells["VencimientoTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["VencimientoTarjeta"].Hidden = true;
                        }
                    }
                }
            }
            if (e.Row.Band != null)
            {
                if (e.Row.Band.Key == "FK_Solicitudes_Afiliados")
                {
                    e.Row.Activation = (int) e.Row.Cells["idSolicitud"].Value > 0 ? Activation.NoEdit : Activation.AllowEdit;

                    if (renglonActivo != null)
                    {
                        if (renglonActivo.Cells["AltaBajaSusp"].Text == "Alta")
                        {
                            renglonActivo.Cells["idVendedor"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["idVendedor"].Value = DBNull.Value;
                            renglonActivo.Cells["idVendedor"].Hidden = true;
                        }

                        if (renglonActivo.Cells["AltaBajaSusp"].Text == "Baja")
                        {
                            renglonActivo.Cells["idMotivoDeBaja"].Hidden = false;
                            renglonActivo.Cells["idTomadorDeBaja"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["idMotivoDeBaja"].Value = DBNull.Value;
                            renglonActivo.Cells["idMotivoDeBaja"].Hidden = true;
                            renglonActivo.Cells["idTomadorDeBaja"].Value = DBNull.Value;
                            renglonActivo.Cells["idTomadorDeBaja"].Hidden = true;
                        }

                        if (renglonActivo.Cells["AltaBajaSusp"].Text == "Suspensión")
                        {
                            renglonActivo.Cells["FechaFinal"].Hidden = false;
                            renglonActivo.Cells["EsCambioDePlan"].Value = false;
                            renglonActivo.Cells["EsCambioDePlan"].Hidden = true;
                        }
                        else
                        {
                            renglonActivo.Cells["FechaFinal"].Value = DBNull.Value;
                            renglonActivo.Cells["FechaFinal"].Hidden = true;
                            renglonActivo.Cells["EsCambioDePlan"].Hidden = false;
                        }
                    }
                }
                if (e.Row.Band.Key == "FK_AfiliadosPlanes_Solicitudes")
                {
                    ultraDropDownPlanes.DisplayLayout.RefreshFilters();
                    if ((int) e.Row.ParentRow.Cells["idSolicitud"].Value > 0)
                    {
                        //e.Row.Band.Override.AllowAddNew = AllowAddNew.No;
                        foreach (var columna in e.Row.Band.Columns)
                        {
                            columna.Style = ColumnStyle.Edit;
                            columna.CellActivation = Activation.NoEdit;
                        }
                    }
                    else
                    {
                        //e.Row.Band.Override.AllowAddNew = AllowAddNew.Yes;
                        foreach (var columna in e.Row.Band.Columns)
                        {
                            columna.Style = ColumnStyle.DropDownValidate;
                            columna.CellActivation = Activation.AllowEdit;
                        }
                    }
                }
            }

            if (e.Row.Band != null)
                if (e.Row.Band.Key == "FK_Afiliados_Grupos" && e.Row.Cells["FechaDeNacimiento"].Value.ToString() != "")
                {
                    e.Row.Cells["Edad"].Value = ManejoDatos.Edad((DateTime) e.Row.Cells["FechaDeNacimiento"].Value);
                }
        }

        private void GruposUltraGridCellChange(object sender, CellEventArgs e)
        {
            var renglonActivo = gruposUltraGrid.ActiveRow;
            var celdaActiva = gruposUltraGrid.ActiveCell;
            if (renglonActivo != null && renglonActivo.Band.Key == "FK_Solicitudes_Afiliados")
            {
                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Alta")
                {
                    renglonActivo.Cells["idVendedor"].Hidden = false;
                }
                else
                {
                    renglonActivo.Cells["idVendedor"].Value = DBNull.Value;
                    renglonActivo.Cells["idVendedor"].Hidden = true;
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Baja")
                {
                    renglonActivo.Cells["idMotivoDeBaja"].Hidden = false;
                    renglonActivo.Cells["idTomadorDeBaja"].Hidden = false;
                }
                else
                {
                    renglonActivo.Cells["idMotivoDeBaja"].Value = DBNull.Value;
                    renglonActivo.Cells["idMotivoDeBaja"].Hidden = true;
                    renglonActivo.Cells["idTomadorDeBaja"].Value = DBNull.Value;
                    renglonActivo.Cells["idTomadorDeBaja"].Hidden = true;
                }

                if (renglonActivo.Cells["AltaBajaSusp"].Text == "Suspensión")
                {
                    renglonActivo.Cells["FechaFinal"].Hidden = false;
                    renglonActivo.Cells["EsCambioDePlan"].Value = false;
                    renglonActivo.Cells["EsCambioDePlan"].Hidden = true;
                }
                else
                {
                    renglonActivo.Cells["FechaFinal"].Value = DBNull.Value;
                    renglonActivo.Cells["FechaFinal"].Hidden = true;
                    renglonActivo.Cells["EsCambioDePlan"].Hidden = false;
                }
            }
            if (e.Cell.Column.Key == "idLocalidad")
            {
                ultraDropDownZonas.DisplayLayout.RefreshFilters();
                ultraDropDownBarrios.DisplayLayout.RefreshFilters();
                ultraDropDownCalle.DisplayLayout.RefreshFilters();
            }
            if (e.Cell.Column.Key == "idTipoDeCobranza")
            {
                if (renglonActivo != null)
                {
                    renglonActivo.Update();
                    if (ultraDropDownTipoDeCobranza.SelectedRow != null &&
                        _fp.dsTiposDeCobranza.TiposDeCobranza.FindByidTipoDeCobranza(
                            (int) ultraDropDownTipoDeCobranza.SelectedRow.Cells["idTipoDeCobranza"].Value).
                            RequiereEntidadDeCobranza)
                    {
                        renglonActivo.Cells["Cobrador"].Hidden = true;
                        renglonActivo.Cells["idEntidadDeCobranza"].Hidden = false;

                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereDocTitular)
                        {
                            renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereNombreTitular)
                        {
                            renglonActivo.Cells["NombreTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NombreTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereNumero)
                        {
                            renglonActivo.Cells["NumeroTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["NumeroTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereTelTitular)
                        {
                            renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = true;
                        }
                        if (renglonActivo.Cells["idEntidadDeCobranza"].Value != DBNull.Value &&
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int) renglonActivo.Cells["idEntidadDeCobranza"].Value).RequiereVencimiento)
                        {
                            renglonActivo.Cells["VencimientoTarjeta"].Hidden = false;
                        }
                        else
                        {
                            renglonActivo.Cells["VencimientoTarjeta"].Hidden = true;
                        }
                    }
                    else // No requiere Entidad de Cobranza
                    {
                        renglonActivo.Cells["idEntidadDeCobranza"].Hidden = true;
                        renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["NombreTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["NumeroTarjeta"].Hidden = true;
                        renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = true;
                        renglonActivo.Cells["VencimientoTarjeta"].Hidden = true;
                        renglonActivo.Cells["Cobrador"].Hidden = (int) celdaActiva.Value != 1;
                    }
                }
            }
            if (e.Cell.Column.Key == "idZona")
            {
                gruposUltraGrid.ActiveRow.Update();
                gruposUltraGrid.Rows[0].Cells["Cobrador"].Value = Cobrador();
            }
            if (e.Cell.Column.Key != "idEntidadDeCobranza") return;
            if (ultraDropDownEntidadDeCobranza.SelectedRow != null &&
                _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                    (int) ultraDropDownEntidadDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value).
                    RequiereDocTitular)
            {
                if (renglonActivo != null) renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = false;
            }
            else
            {
                if (renglonActivo != null)
                {
                    renglonActivo.Cells["NumeroDocumentoTitularTarjeta"].Hidden = true;
                }
            }
            if (ultraDropDownEntidadDeCobranza.SelectedRow != null &&
                _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                    (int) ultraDropDownEntidadDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value).
                    RequiereNombreTitular)
            {
                if (renglonActivo != null) renglonActivo.Cells["NombreTitularTarjeta"].Hidden = false;
            }
            else
            {
                if (renglonActivo != null)
                {
                    renglonActivo.Cells["NombreTitularTarjeta"].Hidden = true;
                }
            }
            if (ultraDropDownEntidadDeCobranza.SelectedRow != null &&
                _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                    (int) ultraDropDownEntidadDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value).
                    RequiereNumero)
            {
                if (renglonActivo != null)
                {
                    renglonActivo.Cells["NumeroTarjeta"].Hidden = false;
                    if (_fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                        (int) ultraDropDownEntidadDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value).
                            MascaraTarjeta.Length == 0)
                    {
                        renglonActivo.Cells["NumeroTarjeta"].Column.MaskInput = null;
                    }
                    else
                    {
                        renglonActivo.Cells["NumeroTarjeta"].Column.MaskInput =
                            _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                                (int)
                                ultraDropDownEntidadDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value).
                                MascaraTarjeta;
                    }
                }
            }
            else
            {
                if (renglonActivo != null)
                {
                    renglonActivo.Cells["NumeroTarjeta"].Hidden = true;
                }
            }
            if (ultraDropDownEntidadDeCobranza.SelectedRow != null &&
                _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                    (int) ultraDropDownEntidadDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value).
                    RequiereTelTitular)
            {
                if (renglonActivo != null) renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = false;
            }
            else
            {
                if (renglonActivo != null)
                {
                    renglonActivo.Cells["TelefonoTitularTarjeta"].Hidden = true;
                }
            }
            if (ultraDropDownEntidadDeCobranza.SelectedRow != null &&
                _fp.dsEntidadesDeCobranza.EntidadesDeCobranza.FindByidEntidadDeCobranza(
                    (int) ultraDropDownEntidadDeCobranza.SelectedRow.Cells["idEntidadDeCobranza"].Value).
                    RequiereVencimiento)
            {
                if (renglonActivo != null) renglonActivo.Cells["VencimientoTarjeta"].Hidden = false;
            }
            else
            {
                if (renglonActivo != null)
                {
                    renglonActivo.Cells["VencimientoTarjeta"].Hidden = true;
                }
            }
        }

        private void UltraDropDownCalleFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = gruposUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                         ? new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals, 0)
                         : new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals,
                                               _fp.dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                                                   (int)
                                                   gruposUltraGrid.ActiveRow.Cells["idLocalidad"].Value).
                                                   idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownZonasFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc1 = new FilterCondition(e.Row.Band.Columns["idLocalidad"], FilterComparisionOperator.Equals,
                                          DBNull.Value);
            var fc = gruposUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                         ? new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals, 0)
                         : new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals,
                                               _fp.dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                                                   (int)
                                                   gruposUltraGrid.ActiveRow.Cells["idLocalidad"].Value).
                                                   idLocalidad);
            if (e.Row.MeetsCriteria(fc) || e.Row.MeetsCriteria(fc1))
                e.RowFilteredOut = false;
            else
                e.RowFilteredOut = true;
        }

        private void UltraDropDownPlanesAfiliadoFilterRow(object sender, FilterRowEventArgs e)
        {
            if (gruposUltraGrid.ActiveRow.ParentRow.Cells["AltaBajaSusp"].Value.ToString() == "A")
            {
                // Sólo muestra los planes que se pueden dar de alta.
                var fc5 = new FilterCondition(e.Row.Band.Columns["Estado"], FilterComparisionOperator.Equals, "N");
                var fc6 = new FilterCondition(e.Row.Band.Columns["Estado"], FilterComparisionOperator.Equals, "B");
                var fc7 = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, 1);
                var fc8 = new FilterCondition(e.Row.Band.Columns["PadronExterno"], FilterComparisionOperator.Equals, 0);
                if ((e.Row.MeetsCriteria(fc5) && e.Row.MeetsCriteria(fc7)) ||
                    (e.Row.MeetsCriteria(fc6) && e.Row.MeetsCriteria(fc7) && e.Row.MeetsCriteria(fc8)))
                    e.RowFilteredOut = false;
                else
                    e.RowFilteredOut = true;
            }
            if (gruposUltraGrid.ActiveRow.ParentRow.Cells["AltaBajaSusp"].Value.ToString() == "B")
            {
                // Sólo muestra los planes que se pueden dar de baja.
                var fc9 = new FilterCondition(e.Row.Band.Columns["Estado"], FilterComparisionOperator.Equals, "A");
                var fc10 = new FilterCondition(e.Row.Band.Columns["Estado"], FilterComparisionOperator.Equals, "S");
                if (e.Row.MeetsCriteria(fc9) || e.Row.MeetsCriteria(fc10))
                    e.RowFilteredOut = false;
                else
                    e.RowFilteredOut = true;
            }
            if (gruposUltraGrid.ActiveRow.ParentRow.Cells["AltaBajaSusp"].Value.ToString() != "S") return;
            // Sólo muestra los planes que se pueden suspender.
            var fc1 = new FilterCondition(e.Row.Band.Columns["Estado"], FilterComparisionOperator.Equals, "A");
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc1);
        }

        private void UltraDropDownBarriosFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = gruposUltraGrid.ActiveRow.Cells["idLocalidad"].Value == DBNull.Value
                         ? new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals, 0)
                         : new FilterCondition(e.Row.Band.Columns["idLocalidad"],
                                               FilterComparisionOperator.Equals,
                                               _fp.dsLocalidadesLista.LocalidadesLista.FindByidLocalidad(
                                                   (int)
                                                   gruposUltraGrid.ActiveRow.Cells["idLocalidad"].Value).
                                                   idLocalidad);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void ButtonEstadoActualDelGrupoClick(object sender, EventArgs e)
        {
            var frmEstado = new FormEstadoActualDelGrupo
                                {
                                    Grupo = Convert.ToInt32(gruposUltraGrid.Rows[0].Cells["idGrupo"].Value.ToString()),
                                    MdiParent = MdiParent,
                                    StartPosition = FormStartPosition.CenterParent
                                };
            frmEstado.Show();
        }

        private void ButtonCancelarNoHeredadoClick(object sender, EventArgs e)
        {
            var mensajeCantidadTitulares = "";
            try
            {
                mensajeCantidadTitulares =
                    new Service().MensajeCantidadDeTitulares((int) gruposUltraGrid.Rows[0].Cells[0].Value, Program.Pin);
            }
            catch
            {
                Close();
            }
            if (mensajeCantidadTitulares.Length > 0)
            {
                var dr = MessageBox.Show(this,
                                         mensajeCantidadTitulares + Environment.NewLine + Environment.NewLine +
                                         "¿Quiere salir sin corregirlo?", "¡Atención!",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void GruposUltraGridAfterRowUpdate(object sender, RowEventArgs e)
        {
            if (Tag.ToString() != "N") return;
            if (e.Row.Band.Key != "FK_Solicitudes_Afiliados") return;
            var nAfiliados = (from a in dsAfiliados.Afiliados.AsEnumerable()
                              select a).Count();
            if (nAfiliados != 1) return;
            gruposUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Afiliados"].Columns["Fecha"].
                DefaultCellValue = Convert.ToDateTime(e.Row.Cells["Fecha"].Value);
            gruposUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Afiliados"].Columns["idVendedor"].
                DefaultCellValue = (int) e.Row.Cells["idVendedor"].Value;
            gruposUltraGrid.DisplayLayout.Bands["FK_Solicitudes_Afiliados"].Columns["Observaciones"].
                DefaultCellValue = "Para activar esta Solicitud, borre este texto.";
        }

        private void UltraDropDownTomadoresDeBajaFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownVendedoresFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void UltraDropDownMotivosDeBajaFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["idMotivoDeBaja"], FilterComparisionOperator.Equals,
                                         _fp.dsSistemas.Sistemas.Rows[0]["MotivoDeBaja_Automatica"]);
            e.RowFilteredOut = e.Row.MeetsCriteria(fc);
        }

        private void GruposUltraGridBeforeExitEditMode(object sender, BeforeExitEditModeEventArgs e)
        {
            // Expande
            if (gruposUltraGrid.ActiveRow != null && gruposUltraGrid.ActiveRow.IsExpandable)
            {
                gruposUltraGrid.ActiveRow.ExpandAll();
            }
        }

        private void UltraDropDownLocalidadesRowSelected(object sender, RowSelectedEventArgs e)
        {
            gruposUltraGrid.Update();
            ultraDropDownZonas.DisplayLayout.RefreshFilters();
            ultraDropDownBarrios.DisplayLayout.RefreshFilters();
            ultraDropDownCalle.DisplayLayout.RefreshFilters();
        }

        private void GruposUltraGridBeforeCellDeactivate(object sender, CancelEventArgs e)
        {
            // Validación del DNI
            if ((gruposUltraGrid.ActiveCell.Band.Key == "FK_Afiliados_Grupos") &&
                ((gruposUltraGrid.ActiveCell.Column.Key == "NumeroDeDocumento" ||
                  gruposUltraGrid.ActiveCell.Column.Key == "idTipoDeDocumento")))
            {
                var intIdAfiliado = (int) gruposUltraGrid.ActiveRow.Cells[0].Value;
                int idTipoDeDocumento;
                try
                {
                    idTipoDeDocumento = (int) gruposUltraGrid.ActiveCell.Row.Cells["idTipoDeDocumento"].Value;
                }
                catch
                {
                    idTipoDeDocumento = 0;
                }
                if (gruposUltraGrid.ActiveCell.Value != DBNull.Value)
                    if (gruposUltraGrid.ActiveCell.Row.Cells["NumeroDeDocumento"].Value != DBNull.Value)
                        gruposUltraGrid.ActiveCell.Row.Cells["NumeroDeDocumento"].Value =
                            Convert.ToInt32(
                                gruposUltraGrid.ActiveCell.Row.Cells["NumeroDeDocumento"].Text.Replace(".", "").Replace(
                                    "_", "")).ToString(CultureInfo.InvariantCulture);
                // Saca los ceros de la izquierda.
                if (gruposUltraGrid.ActiveCell.Row.Cells["NumeroDeDocumento"].Value != DBNull.Value)
                {
                    var numeroDeDocumento =
                        gruposUltraGrid.ActiveCell.Row.Cells["NumeroDeDocumento"].Text.Replace(".", "").Replace("_", "");
                    var nombApel = new Service().GetAfiliadoMismoDNI(idTipoDeDocumento, numeroDeDocumento,
                                                                     intIdAfiliado,
                                                                     Program.Pin);
                    if (nombApel.Length > 0)
                    {
                        //e.Cancel = true;
                        MessageBox.Show(this,
                                        "El documento " +
                                        gruposUltraGrid.ActiveRow.Cells["NumeroDeDocumento"].Text.Replace("_", "") +
                                        " ya figura en nuestros registros" +
                                        Environment.NewLine + "perteneciendo a " +
                                        nombApel + ".",
                                        gruposUltraGrid.ActiveRow.Cells["idTipoDeDocumento"].Text,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    var grupos = gruposUltraGrid.DisplayLayout.Bands["Grupos"];
                    foreach (UltraGridRow cadaGrupo in grupos.GetRowEnumerator(GridRowType.DataRow))
                        // Cada grupo, y hay uno solo.
                    {
                        foreach (var afiliado in cadaGrupo.ChildBands["FK_Afiliados_Grupos"].Rows) //Cada Afiliado
                        {
                            if ((((afiliado.IsAddRow ||
                                   afiliado.Cells["NumeroDeDocumento"].Value == DBNull.Value) ||
                                  (int) afiliado.Cells["idAfiliado"].Value == intIdAfiliado) ||
                                 (int) afiliado.Cells["idTipoDeDocumento"].Value != idTipoDeDocumento) ||
                                Convert.ToInt32(afiliado.Cells["NumeroDeDocumento"].Text.Replace(".", "").Replace("_",
                                                                                                                  "")).
                                    ToString(CultureInfo.InvariantCulture) != numeroDeDocumento) continue;
                            MessageBox.Show(
                                "El Nº de Documento " + numeroDeDocumento +
                                " está" + Environment.NewLine +
                                "más de una vez en esta ficha.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                    }
                }
            }

            // Validación de la Fecha inicial de la Solicitud
            if ((gruposUltraGrid.ActiveCell.Band.Key == "FK_Solicitudes_Afiliados") &&
                (gruposUltraGrid.ActiveCell.Column.Key == "Fecha"))
            {
                try
                {
                    if ((DateTime) gruposUltraGrid.ActiveCell.Value > new Service().HoraActual(Program.Pin))
                    {
                        var resultado = MessageBox.Show("La Fecha es posterior a hoy." +
                                                        Environment.NewLine +
                                                        "¿Es un error?",
                                                        "¡Atención!", MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            e.Cancel = true;
                        }
                    }
                }
                catch (InvalidCastException)
                {
                    //Si dejo la fecha vacía da un error;
                }
            }
            // Validación de la Fecha de Nacimiento
            if ((gruposUltraGrid.ActiveCell.Band.Key != "FK_Afiliados_Grupos") ||
                (gruposUltraGrid.ActiveCell.Column.Key != "FechaDeNacimiento")) return;
            if (gruposUltraGrid.ActiveCell.Value != DBNull.Value &&
                (DateTime) gruposUltraGrid.ActiveCell.Value > new Service().HoraActual(Program.Pin))
            {
                e.Cancel = true;
                MessageBox.Show("La Fecha de Nacimiento no puede ser posterior a hoy.",
                                "¡Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (gruposUltraGrid.ActiveCell.Value == DBNull.Value ||
                (DateTime) gruposUltraGrid.ActiveCell.Value >= new Service().HoraActual(Program.Pin).AddYears(-120))
                return;
            e.Cancel = true;
            MessageBox.Show("No admitimos afiliados de más de 120 años de edad.",
                            "¡Atención!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string Cobrador()
        {
            var idZona = (from d in dsAfiliados.DireccionesGrupos.AsEnumerable()
                          where d.Field<bool>("Cobranza")
                          select d.Field<int?>("idZona")).SingleOrDefault();
            var cobrador = "";
            if (idZona != null)
            {
                cobrador = (from z in _fp.dsZonas.Zonas.AsEnumerable()
                            join e in _fp.dsEmpleadosLista.EmpleadosLista.AsEnumerable() on
                                z.Field<int?>("idCobrador")
                                equals e.Field<int?>("idEmpleado")
                            where z.Field<int?>("idZona") == Convert.ToInt32(idZona)
                            select e.Field<string>("ApelNomb")).SingleOrDefault();
            }
            return cobrador ?? "";
        }
         private void ActivarSolicitudYPlan()
         {
            var grupos = gruposUltraGrid.DisplayLayout.Bands["Grupos"]; //Grupos
            foreach (UltraGridRow cadaGrupo in grupos.GetRowEnumerator(GridRowType.DataRow))
                // Cada grupo, y hay uno solo.
            {
                foreach (var afiliado in cadaGrupo.ChildBands["FK_Afiliados_Grupos"].Rows) //Cada Afiliado
                {
                    if (afiliado.ChildBands["FK_Solicitudes_Afiliados"].Rows.Count != 0) continue;
                    afiliado.ChildBands["FK_Solicitudes_Afiliados"].Band.AddNew();
                    gruposUltraGrid.PerformAction(UltraGridAction.CommitRow);
                    //afiliado.ChildBands["FK_Solicitudes_Afiliados"].Rows.Refresh(RefreshRow.ReloadData);
                    foreach (var solicitud in afiliado.ChildBands["FK_Solicitudes_Afiliados"].Rows)
                    {
                        solicitud.ChildBands["FK_AfiliadosPlanes_Solicitudes"].Band.AddNew();
                        solicitud.ChildBands["FK_AfiliadosPlanes_Solicitudes"].Rows.AddRowModifiedByUser=true;
                        gruposUltraGrid.PerformAction(UltraGridAction.CommitRow);
                        gruposUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
                        gruposUltraGrid.Update();
                    }
                    if(Telefono != null)
                    {
                        afiliado.Activate();
                        var nuevoTelefono = afiliado.ChildBands["FK_Telefonos_Afiliados"].Band.AddNew();
                        nuevoTelefono.Cells["Numero"].Value = Telefono;
                        afiliado.ChildBands["FK_Telefonos_Afiliados"].Rows.AddRowModifiedByUser = true;
                        gruposUltraGrid.PerformAction(UltraGridAction.CommitRow);
                        gruposUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
                        gruposUltraGrid.Update();
                    }
                }
            }
         }

         private void gruposUltraGrid_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter)
                 gruposUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
         }
    }
}