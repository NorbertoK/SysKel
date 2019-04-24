using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance230 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand24 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Clientes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn354 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn355 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn356 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn357 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva", -1, "ultraDropDownCategoriasIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn358 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.Appearance appearance259 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn359 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCobranza", -1, "ultraDropDownTiposDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn360 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza", -1, "ultraDropDownEntidadesDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn361 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCliente", -1, "ultraDropDownTiposDeCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn362 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn363 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VencimientoTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn364 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTitularTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn365 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocumentoTitularTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn366 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TelefonoTitularTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn367 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresosBrutos");
            Infragistics.Win.Appearance appearance260 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn368 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sucursal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn369 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn370 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Convenio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn371 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jubilado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn372 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpresasSueldoBcoMacro", -1, "ultraDropDownEmpresasSueldoBancoMacro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn373 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Direcciones__Clientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn374 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Clientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn375 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contratos_Clientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn376 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_FacturasProforma_Clientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn377 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_EmailsClientes_Clientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn378 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobrador", 0);
            Infragistics.Win.Appearance appearance261 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand25 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Direcciones__Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn379 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn380 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn381 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn382 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn383 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn384 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn385 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn386 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn387 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn388 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona", -1, "ultraDropDownZonas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn389 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn390 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn391 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn392 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn393 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__Direcciones");
            Infragistics.Win.Appearance appearance262 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand26 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__Direcciones", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn394 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn395 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn396 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.Appearance appearance263 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand27 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn397 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn398 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn399 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn400 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn401 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn402 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Contactos");
            Infragistics.Win.Appearance appearance264 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand28 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Contactos", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn403 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn404 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn405 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance265 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand29 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Contactos", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn406 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn407 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn408 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance266 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand30 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contratos_Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn409 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn410 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn411 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn412 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Condiciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn413 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeContrato", -1, "ultraDropDownTiposDeContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn414 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Ene");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn415 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Feb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn416 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Mar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn417 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Abr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn418 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("May");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn419 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jun");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn420 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jul");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn421 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Ago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn422 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sep");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn423 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Oct", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn424 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn425 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Dic");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn426 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn427 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio", -1, "ultraDropDownNegocios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn428 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Solicitudes_Contratos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn429 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Planes_Contratos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn430 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Contratos");
            Infragistics.Win.Appearance appearance267 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand31 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Solicitudes_Contratos", 6);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn431 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AltaBajaSusp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn432 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn433 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn434 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn435 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Renovacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn436 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRegistro", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn437 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idVendedor", -1, "ultraDropDownVendedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn438 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTomadorDeBaja", -1, "ultraDropDownTomadoresDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn439 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeBaja", -1, "ultraDropDownMotivosDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn440 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn441 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador", -1, "ultraDropDownGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn442 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idSolicitud");
            Infragistics.Win.Appearance appearance268 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand32 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Planes_Contratos", 6);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn443 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn444 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn445 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn446 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn447 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuota");
            Infragistics.Win.Appearance appearance269 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn448 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn449 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PadronExterno");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn450 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProteccion", -1, "ultraDropDownProtecciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn451 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago", -1, "ultraDropDownPrepagos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn452 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CuotaAdherente");
            Infragistics.Win.Appearance appearance270 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance271 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand33 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Contratos", 6);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn453 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn454 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn455 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn456 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn457 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn458 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn459 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn460 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn461 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn462 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn463 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn464 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__idDir__4850AF911");
            Infragistics.Win.Appearance appearance272 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand34 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__idDir__4850AF911", 9);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn465 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn466 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn467 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.Appearance appearance273 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand35 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_FacturasProforma_Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn468 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idFacturaProforma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn469 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn470 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn471 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTandaDeFacturacion", -1, "ultraDropDownTandasDeFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn472 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FacturarMes", -1, "ultraDropDownFacturarMes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn473 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_RenglonesFacturaProforma_FacturasProforma");
            Infragistics.Win.Appearance appearance274 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand36 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_RenglonesFacturaProforma_FacturasProforma", 11);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn474 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRenglonFacturaProforma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn475 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.Appearance appearance275 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn476 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario");
            Infragistics.Win.Appearance appearance276 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn477 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato", -1, "ultraDropDownContratos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn478 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RevisarMensualmente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn479 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idFacturaProforma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn480 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan", -1, "ultraDropDownPlanes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn481 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Titulares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn482 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA", -1, "ultraDropDownPorcentajeIVA");
            Infragistics.Win.Appearance appearance277 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand37 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_EmailsClientes_Clientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn483 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn484 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.Appearance appearance278 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn485 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.Appearance appearance240 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance241 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance242 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance243 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance244 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance255 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance256 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance257 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance258 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance149 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand22 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn345 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn346 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn347 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn348 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance150 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance151 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance152 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance153 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance154 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance155 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance156 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance157 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance158 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance200 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand20 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Zonas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn336 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn337 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn338 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn339 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn340 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn341 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuntoDeVenta");
            Infragistics.Win.Appearance appearance201 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance202 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance203 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance204 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand19 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeCliente", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn333 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn334 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn335 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance120 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance121 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance122 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance195 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance196 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance197 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance198 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance199 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand18 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn328 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn329 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn330 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereEntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn331 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereZonaDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn332 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereDireccionReal");
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand17 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EntidadesDeCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn313 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn314 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn315 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn316 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MascaraTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn317 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereNumero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn318 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereVencimiento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn319 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereNombreTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn320 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereDocTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn321 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereTelTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn322 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn323 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereConvenio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn324 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereSucursal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn325 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereEmpresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn326 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereJubilado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn327 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand16 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeContrato", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn310 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn311 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn312 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn303 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn304 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn305 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn306 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn307 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn308 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn309 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn296 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn297 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn298 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn299 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn300 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn301 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn302 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeBaja", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn294 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn295 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Codigos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn289 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn290 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn291 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Color");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn292 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jerarquia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn293 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TiempoDeLlegada");
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance179 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CategoriasIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn282 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn283 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn284 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn285 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExigeCUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn286 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Factura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn287 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn288 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeD");
            Infragistics.Win.Appearance appearance180 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance181 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance182 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance183 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance184 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance187 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance194 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance217 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance229 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance176 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn279 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn280 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn281 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance177 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance178 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ContratosRenglonFactura", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn236 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn237 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn238 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn239 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn240 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn241 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance159 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance170 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance171 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance172 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance173 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance174 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance175 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance160 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TandasDeFacturacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn276 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTandaDeFacturacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn277 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn278 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance162 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance163 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance164 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance165 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance166 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance167 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance168 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance169 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand21 = new Infragistics.Win.UltraWinGrid.UltraGridBand("LocalidadesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn342 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn343 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn344 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance148 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PlanesDelCliente", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn271 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn272 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn273 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn274 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn275 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Protecciones", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn266 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProteccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn267 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn268 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn269 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn270 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance207 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn260 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn261 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn262 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn263 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn264 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn265 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance208 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance209 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance210 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance211 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance212 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance213 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance214 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance215 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance216 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance218 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prepagos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn257 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn258 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn259 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance219 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance220 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance221 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance222 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance223 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance224 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance225 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance226 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance227 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto");
            Infragistics.Win.Appearance appearance245 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn255 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn256 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto");
            Infragistics.Win.Appearance appearance246 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance247 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance248 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance249 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance250 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance251 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance252 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance253 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance254 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Negocios", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn251 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn252 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn253 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn254 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand23 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PorcentajeIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn349 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn350 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoAFIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn351 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn352 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn353 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpresasSueldoBcoMacro", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn249 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpresasSueldoBcoMacro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn250 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            this.clientesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientes = new Administración.WS.DsClientes();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.ultraDropDownCalle = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.callesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCallesLista = new Administración.WS.DsCallesLista();
            this.ultraDropDownZonas = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.zonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsZonas = new Administración.WS.DsZonas();
            this.ultraDropDownTiposDeCliente = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeCliente = new Administración.WS.DsTiposDeCliente();
            this.categoriasIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCategoriasIVA = new Administración.WS.DsCategoriasIVA();
            this.ultraDropDownTiposDeCobranza = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeCobranza = new Administración.WS.DsTiposDeCobranza();
            this.ultraDropDownEntidadesDeCobranza = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.entidadesDeCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEntidadesDeCobranza = new Administración.WS.DsEntidadesDeCobranza();
            this.ultraDropDownTiposDeContrato = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeContrato = new Administración.WS.DsTiposDeContrato();
            this.ultraDropDownVendedores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.vendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVendedores = new Administración.WS.DsEmpleadosLista();
            this.ultraDropDownTomadoresDeBaja = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tomadoresDeBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTomadoresDeBaja = new Administración.WS.DsEmpleadosLista();
            this.ultraDropDownMotivosDeBaja = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDeBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeBaja = new Administración.WS.DsMotivosDeBaja();
            this.ultraDropDownCodigos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.codigosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodigos = new Administración.WS.DsCodigos();
            this.ultraDropDownCategoriasIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownBarrios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.barriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarrios1 = new Administración.WS.DsBarrios();
            this.ultraDropDownContratos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.contratosRenglonFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsContratosLista = new Administración.WS.DsContratosLista();
            this.ultraDropDownTandasDeFacturacion = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tandasDeFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTandasDeFacturacion = new Administración.WS.DsTandasDeFacturacion();
            this.dsSistemas1 = new Administración.WS.DsSistemas();
            this.ultraDropDownLocalidad = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.localidadesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalidadesLista = new Administración.WS.DsLocalidadesLista();
            this.dscuitRepetibles1 = new Administración.WS.DsCUITRepetibles();
            this.dsPlanes1 = new Administración.WS.DsPlanes();
            this.ultraDropDownPlanes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.planesDelClientebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProtecciones = new Administración.WS.DsProtecciones();
            this.proteccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownProtecciones = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownGrabador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.usuariosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuariosLista1 = new Administración.WS.DsUsuariosLista();
            this.dsPrepagos = new Administración.WS.DsPrepagos();
            this.prepagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownPrepagos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDataSourceFacturarMes = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDropDownFacturarMes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsNegocios = new Administración.WS.DsNegocios();
            this.negociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownNegocios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsPorcentajeIVA = new Administración.WS.DsPorcentajeIVA();
            this.porcentajeIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownPorcentajeIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsParametros = new Administración.WS.DsParametros();
            this.dsEmpresasSueldoBancoMacro = new Administración.WS.DsEmpresasSueldoBancoMacro();
            this.empresasSueldoBcoMacroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownEmpresasSueldoBancoMacro = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEntidadesDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesDeCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeContratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadoresDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomadoresDeBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTomadoresDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosRenglonFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTandasDeFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTandasDeFacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dscuitRepetibles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesDelClientebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownProtecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceFacturarMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownFacturarMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresasSueldoBancoMacro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSueldoBcoMacroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEmpresasSueldoBancoMacro)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(811, 13);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(730, 13);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSalir);
            this.panel1.Location = new System.Drawing.Point(1, 532);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(899, 45);
            this.panel1.Controls.SetChildIndex(this.buttonSalir, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(649, 13);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // clientesUltraGrid
            // 
            this.clientesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesUltraGrid.CalcManager = this.ultraCalcManager1;
            this.clientesUltraGrid.DataSource = this.clientesBindingSource;
            appearance230.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance230.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance230.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.clientesUltraGrid.DisplayLayout.Appearance = appearance230;
            ultraGridBand24.ColHeaderLines = 2;
            ultraGridColumn354.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn354.Header.VisiblePosition = 0;
            ultraGridColumn354.Hidden = true;
            ultraGridColumn354.Width = 15;
            ultraGridColumn355.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn355.Header.Caption = "Razón Social";
            ultraGridColumn355.Header.VisiblePosition = 1;
            ultraGridColumn355.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn355.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn355.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(215, 0);
            ultraGridColumn355.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(215, 0);
            ultraGridColumn355.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn355.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn355.Width = 39;
            ultraGridColumn356.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn356.Header.Caption = "Nombre Fantasía";
            ultraGridColumn356.Header.VisiblePosition = 2;
            ultraGridColumn356.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn356.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn356.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(213, 0);
            ultraGridColumn356.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(213, 0);
            ultraGridColumn356.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn356.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn356.Width = 37;
            ultraGridColumn357.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn357.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn357.Header.Caption = "Categoría IVA";
            ultraGridColumn357.Header.VisiblePosition = 3;
            ultraGridColumn357.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn357.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn357.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(94, 0);
            ultraGridColumn357.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(94, 0);
            ultraGridColumn357.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn357.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn357.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn357.Width = 32;
            ultraGridColumn358.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance259.TextHAlignAsString = "Center";
            ultraGridColumn358.CellAppearance = appearance259;
            ultraGridColumn358.Header.VisiblePosition = 4;
            ultraGridColumn358.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn358.MaskInput = "##-##,###,###-#";
            ultraGridColumn358.RowLayoutColumnInfo.OriginX = 15;
            ultraGridColumn358.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn358.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(106, 0);
            ultraGridColumn358.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(106, 0);
            ultraGridColumn358.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn358.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn358.Width = 37;
            ultraGridColumn359.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn359.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn359.Header.Caption = "Tipo de Cobranza";
            ultraGridColumn359.Header.VisiblePosition = 5;
            ultraGridColumn359.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn359.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn359.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(104, 0);
            ultraGridColumn359.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(104, 0);
            ultraGridColumn359.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn359.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn359.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn359.Width = 40;
            ultraGridColumn360.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn360.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn360.Header.Caption = "Entidad de Cobranza";
            ultraGridColumn360.Header.VisiblePosition = 6;
            ultraGridColumn360.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn360.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn360.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(51, 0);
            ultraGridColumn360.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(51, 0);
            ultraGridColumn360.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn360.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn360.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn360.Width = 46;
            ultraGridColumn361.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn361.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn361.Header.Caption = "Rubro";
            ultraGridColumn361.Header.VisiblePosition = 7;
            ultraGridColumn361.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn361.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn361.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(101, 0);
            ultraGridColumn361.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(101, 0);
            ultraGridColumn361.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn361.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn361.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn361.Width = 36;
            ultraGridColumn362.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn362.Header.Caption = "Número Tarjeta";
            ultraGridColumn362.Header.VisiblePosition = 8;
            ultraGridColumn362.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn362.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn362.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn362.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(118, 0);
            ultraGridColumn362.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(118, 0);
            ultraGridColumn362.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn362.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn363.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn363.Header.Caption = "Vencimiento";
            ultraGridColumn363.Header.VisiblePosition = 9;
            ultraGridColumn363.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn363.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn363.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(17, 0);
            ultraGridColumn363.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(17, 0);
            ultraGridColumn363.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn363.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn364.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn364.Header.Caption = "Nombre Titular Tarjeta";
            ultraGridColumn364.Header.VisiblePosition = 10;
            ultraGridColumn364.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn364.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn364.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(101, 0);
            ultraGridColumn364.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(101, 0);
            ultraGridColumn364.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn364.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn365.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn365.Header.Caption = " Doc. Titular Tarjeta";
            ultraGridColumn365.Header.VisiblePosition = 11;
            ultraGridColumn365.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn365.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn365.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(94, 0);
            ultraGridColumn365.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(94, 0);
            ultraGridColumn365.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn365.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn366.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn366.Header.Caption = "Tel. Titular Tarjeta";
            ultraGridColumn366.Header.VisiblePosition = 13;
            ultraGridColumn366.RowLayoutColumnInfo.OriginX = 16;
            ultraGridColumn366.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn366.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(106, 0);
            ultraGridColumn366.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(106, 0);
            ultraGridColumn366.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn366.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn367.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance260.TextHAlignAsString = "Center";
            ultraGridColumn367.CellAppearance = appearance260;
            ultraGridColumn367.Header.Caption = "Ing. Brutos";
            ultraGridColumn367.Header.VisiblePosition = 12;
            ultraGridColumn367.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn367.MaskInput = "##-######-#";
            ultraGridColumn367.RowLayoutColumnInfo.OriginX = 18;
            ultraGridColumn367.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn367.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(100, 0);
            ultraGridColumn367.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(100, 0);
            ultraGridColumn367.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn367.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn368.Header.VisiblePosition = 14;
            ultraGridColumn368.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn368.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn368.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(95, 0);
            ultraGridColumn368.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(56, 0);
            ultraGridColumn368.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn368.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn369.Header.VisiblePosition = 16;
            ultraGridColumn369.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn369.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn369.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn369.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn370.Header.VisiblePosition = 17;
            ultraGridColumn370.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn370.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn370.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn370.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn371.Header.VisiblePosition = 18;
            ultraGridColumn371.RowLayoutColumnInfo.OriginX = 16;
            ultraGridColumn371.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn371.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn371.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn372.Header.Caption = "EmpresaBcoMacro";
            ultraGridColumn372.Header.VisiblePosition = 19;
            ultraGridColumn372.RowLayoutColumnInfo.OriginX = 18;
            ultraGridColumn372.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn372.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(59, 0);
            ultraGridColumn372.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(112, 0);
            ultraGridColumn372.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn372.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn373.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn373.Header.VisiblePosition = 21;
            ultraGridColumn374.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn374.Header.VisiblePosition = 20;
            ultraGridColumn375.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn375.Header.VisiblePosition = 22;
            ultraGridColumn376.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn376.Header.VisiblePosition = 23;
            ultraGridColumn377.Header.VisiblePosition = 24;
            ultraGridColumn378.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn378.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn378.Header.VisiblePosition = 15;
            ultraGridColumn378.RowLayoutColumnInfo.OriginX = 18;
            ultraGridColumn378.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn378.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(100, 0);
            ultraGridColumn378.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(100, 0);
            ultraGridColumn378.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn378.RowLayoutColumnInfo.SpanY = 2;
            ultraGridBand24.Columns.AddRange(new object[] {
            ultraGridColumn354,
            ultraGridColumn355,
            ultraGridColumn356,
            ultraGridColumn357,
            ultraGridColumn358,
            ultraGridColumn359,
            ultraGridColumn360,
            ultraGridColumn361,
            ultraGridColumn362,
            ultraGridColumn363,
            ultraGridColumn364,
            ultraGridColumn365,
            ultraGridColumn366,
            ultraGridColumn367,
            ultraGridColumn368,
            ultraGridColumn369,
            ultraGridColumn370,
            ultraGridColumn371,
            ultraGridColumn372,
            ultraGridColumn373,
            ultraGridColumn374,
            ultraGridColumn375,
            ultraGridColumn376,
            ultraGridColumn377,
            ultraGridColumn378});
            appearance261.FontData.BoldAsString = "True";
            appearance261.FontData.SizeInPoints = 11F;
            appearance261.TextHAlignAsString = "Left";
            ultraGridBand24.Header.Appearance = appearance261;
            ultraGridBand24.Header.Caption = "Cliente";
            ultraGridBand24.HeaderVisible = true;
            ultraGridBand24.MaxRows = 1;
            ultraGridBand24.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand24.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn379.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn379.Header.VisiblePosition = 0;
            ultraGridColumn379.Hidden = true;
            ultraGridColumn379.Width = 45;
            ultraGridColumn380.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn380.DefaultCellValue = "True";
            ultraGridColumn380.Header.VisiblePosition = 1;
            ultraGridColumn380.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn380.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn380.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(76, 56);
            ultraGridColumn380.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(76, 0);
            ultraGridColumn380.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn380.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn380.Width = 25;
            ultraGridColumn381.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn381.DefaultCellValue = "True";
            ultraGridColumn381.Header.VisiblePosition = 2;
            ultraGridColumn381.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn381.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn381.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(0, 56);
            ultraGridColumn381.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn381.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn381.Width = 47;
            ultraGridColumn382.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn382.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn382.Header.Caption = "Calle";
            ultraGridColumn382.Header.VisiblePosition = 3;
            ultraGridColumn382.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn382.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn382.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(176, 0);
            ultraGridColumn382.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(176, 0);
            ultraGridColumn382.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn382.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn382.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn382.Width = 43;
            ultraGridColumn383.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn383.Header.Caption = "Número";
            ultraGridColumn383.Header.VisiblePosition = 4;
            ultraGridColumn383.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn383.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn383.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(56, 0);
            ultraGridColumn383.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn383.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn383.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn383.Width = 73;
            ultraGridColumn384.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn384.Header.VisiblePosition = 5;
            ultraGridColumn384.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn384.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn384.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(52, 0);
            ultraGridColumn384.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(34, 0);
            ultraGridColumn384.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn384.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn384.Width = 73;
            ultraGridColumn385.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn385.Header.VisiblePosition = 6;
            ultraGridColumn385.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn385.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn385.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(73, 0);
            ultraGridColumn385.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(79, 0);
            ultraGridColumn385.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn385.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn385.Width = 73;
            ultraGridColumn386.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn386.Header.Caption = "Entre";
            ultraGridColumn386.Header.VisiblePosition = 7;
            ultraGridColumn386.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn386.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn386.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(176, 0);
            ultraGridColumn386.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(176, 0);
            ultraGridColumn386.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn386.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn386.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn386.Width = 61;
            ultraGridColumn387.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn387.Header.Caption = "y";
            ultraGridColumn387.Header.VisiblePosition = 8;
            ultraGridColumn387.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn387.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn387.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(176, 0);
            ultraGridColumn387.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(176, 0);
            ultraGridColumn387.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn387.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn387.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn387.Width = 61;
            ultraGridColumn388.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn388.Header.Caption = "Zona";
            ultraGridColumn388.Header.VisiblePosition = 9;
            ultraGridColumn388.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn388.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn388.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(66, 0);
            ultraGridColumn388.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(66, 0);
            ultraGridColumn388.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn388.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn388.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn388.Width = 43;
            ultraGridColumn389.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn389.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn389.Header.VisiblePosition = 10;
            ultraGridColumn389.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn389.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn389.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(360, 55);
            ultraGridColumn389.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(56, 0);
            ultraGridColumn389.RowLayoutColumnInfo.SpanX = 10;
            ultraGridColumn389.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn389.Width = 73;
            ultraGridColumn390.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn390.Header.VisiblePosition = 11;
            ultraGridColumn390.Hidden = true;
            ultraGridColumn390.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn390.Width = 44;
            ultraGridColumn391.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn391.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn391.Header.Caption = "Barrio";
            ultraGridColumn391.Header.VisiblePosition = 12;
            ultraGridColumn391.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn391.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn391.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn391.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn391.Width = 43;
            ultraGridColumn392.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn392.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn392.Header.Caption = "Localidad";
            ultraGridColumn392.Header.VisiblePosition = 13;
            ultraGridColumn392.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn392.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn392.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(156, 0);
            ultraGridColumn392.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn392.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn392.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn393.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn393.Header.VisiblePosition = 14;
            ultraGridBand25.Columns.AddRange(new object[] {
            ultraGridColumn379,
            ultraGridColumn380,
            ultraGridColumn381,
            ultraGridColumn382,
            ultraGridColumn383,
            ultraGridColumn384,
            ultraGridColumn385,
            ultraGridColumn386,
            ultraGridColumn387,
            ultraGridColumn388,
            ultraGridColumn389,
            ultraGridColumn390,
            ultraGridColumn391,
            ultraGridColumn392,
            ultraGridColumn393});
            appearance262.FontData.BoldAsString = "True";
            appearance262.FontData.SizeInPoints = 11F;
            appearance262.TextHAlignAsString = "Left";
            ultraGridBand25.Header.Appearance = appearance262;
            ultraGridBand25.Header.Caption = "Direcciones";
            ultraGridBand25.HeaderVisible = true;
            ultraGridBand25.MaxRows = 2;
            ultraGridBand25.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand25.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand25.VisiblePosition = 1;
            ultraGridBand26.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand26.CardSettings.ShowCaption = false;
            ultraGridBand26.CardView = true;
            ultraGridBand26.ColHeadersVisible = false;
            ultraGridColumn394.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn394.Header.VisiblePosition = 0;
            ultraGridColumn394.Hidden = true;
            ultraGridColumn394.Width = 198;
            ultraGridColumn395.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn395.Header.VisiblePosition = 1;
            ultraGridColumn395.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(96, 0);
            ultraGridColumn395.Width = 283;
            ultraGridColumn396.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn396.Header.VisiblePosition = 2;
            ultraGridColumn396.Hidden = true;
            ultraGridColumn396.Width = 204;
            ultraGridBand26.Columns.AddRange(new object[] {
            ultraGridColumn394,
            ultraGridColumn395,
            ultraGridColumn396});
            appearance263.FontData.BoldAsString = "True";
            appearance263.FontData.SizeInPoints = 11F;
            appearance263.TextHAlignAsString = "Left";
            ultraGridBand26.Header.Appearance = appearance263;
            ultraGridBand26.Header.Caption = "Teléf. Dirección";
            ultraGridBand26.HeaderVisible = true;
            ultraGridBand26.MaxRows = 7;
            ultraGridBand26.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn397.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn397.Header.VisiblePosition = 0;
            ultraGridColumn397.Hidden = true;
            ultraGridColumn397.Width = 121;
            ultraGridColumn398.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn398.Header.VisiblePosition = 1;
            ultraGridColumn398.Width = 196;
            ultraGridColumn399.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn399.Header.VisiblePosition = 2;
            ultraGridColumn399.Width = 69;
            ultraGridColumn400.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn400.Header.VisiblePosition = 3;
            ultraGridColumn400.Hidden = true;
            ultraGridColumn400.Width = 179;
            ultraGridColumn401.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn401.Header.VisiblePosition = 4;
            ultraGridColumn402.Header.VisiblePosition = 5;
            ultraGridBand27.Columns.AddRange(new object[] {
            ultraGridColumn397,
            ultraGridColumn398,
            ultraGridColumn399,
            ultraGridColumn400,
            ultraGridColumn401,
            ultraGridColumn402});
            appearance264.FontData.BoldAsString = "True";
            appearance264.FontData.SizeInPoints = 11F;
            appearance264.TextHAlignAsString = "Left";
            ultraGridBand27.Header.Appearance = appearance264;
            ultraGridBand27.Header.Caption = "Referentes";
            ultraGridBand27.HeaderVisible = true;
            ultraGridBand27.VisiblePosition = 4;
            ultraGridBand28.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand28.CardSettings.ShowCaption = false;
            ultraGridBand28.CardView = true;
            ultraGridBand28.ColHeadersVisible = false;
            ultraGridColumn403.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn403.Header.VisiblePosition = 0;
            ultraGridColumn403.Hidden = true;
            ultraGridColumn403.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn403.Width = 206;
            ultraGridColumn404.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn404.Header.VisiblePosition = 1;
            ultraGridColumn404.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(93, 0);
            ultraGridColumn404.Width = 702;
            ultraGridColumn405.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn405.Header.VisiblePosition = 2;
            ultraGridColumn405.Hidden = true;
            ultraGridColumn405.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(80, 0);
            ultraGridColumn405.Width = 205;
            ultraGridBand28.Columns.AddRange(new object[] {
            ultraGridColumn403,
            ultraGridColumn404,
            ultraGridColumn405});
            appearance265.FontData.BoldAsString = "True";
            appearance265.FontData.SizeInPoints = 11F;
            appearance265.TextHAlignAsString = "Left";
            ultraGridBand28.Header.Appearance = appearance265;
            ultraGridBand28.Header.Caption = "Tel. Referente";
            ultraGridBand28.HeaderVisible = true;
            ultraGridBand28.MaxRows = 7;
            ultraGridBand28.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn406.Header.VisiblePosition = 0;
            ultraGridColumn406.Hidden = true;
            ultraGridColumn406.Width = 209;
            ultraGridColumn407.Header.VisiblePosition = 1;
            ultraGridColumn407.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(353, 0);
            ultraGridColumn407.Width = 809;
            ultraGridColumn408.Header.VisiblePosition = 2;
            ultraGridColumn408.Hidden = true;
            ultraGridColumn408.Width = 331;
            ultraGridBand29.Columns.AddRange(new object[] {
            ultraGridColumn406,
            ultraGridColumn407,
            ultraGridColumn408});
            appearance266.FontData.BoldAsString = "True";
            appearance266.FontData.SizeInPoints = 11F;
            appearance266.TextHAlignAsString = "Left";
            ultraGridBand29.Header.Appearance = appearance266;
            ultraGridBand29.Header.Caption = "e_Mail Referente";
            ultraGridBand29.HeaderVisible = true;
            ultraGridBand29.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn409.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn409.Header.VisiblePosition = 0;
            ultraGridColumn409.Hidden = true;
            ultraGridColumn409.Width = 106;
            ultraGridColumn410.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn410.Header.VisiblePosition = 1;
            ultraGridColumn410.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn410.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn410.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(297, 0);
            ultraGridColumn410.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(297, 0);
            ultraGridColumn410.RowLayoutColumnInfo.SpanX = 7;
            ultraGridColumn410.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn410.Width = 115;
            ultraGridColumn411.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn411.Header.VisiblePosition = 2;
            ultraGridColumn411.Hidden = true;
            ultraGridColumn411.Width = 130;
            ultraGridColumn412.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn412.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn412.Header.Caption = "Datos para el Despacho";
            ultraGridColumn412.Header.VisiblePosition = 3;
            ultraGridColumn412.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn412.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn412.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(211, 55);
            ultraGridColumn412.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(211, 0);
            ultraGridColumn412.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn412.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn412.Width = 129;
            ultraGridColumn413.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn413.Header.Caption = "Tipo de Contrato";
            ultraGridColumn413.Header.VisiblePosition = 4;
            ultraGridColumn413.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn413.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn413.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(109, 0);
            ultraGridColumn413.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(96, 0);
            ultraGridColumn413.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn413.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn413.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn413.Width = 135;
            ultraGridColumn414.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn414.DefaultCellValue = "100";
            ultraGridColumn414.Header.VisiblePosition = 5;
            ultraGridColumn414.LockedWidth = true;
            ultraGridColumn414.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn414.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn414.MaxLength = 27;
            ultraGridColumn414.MaxWidth = 27;
            ultraGridColumn414.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn414.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn414.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(53, 0);
            ultraGridColumn414.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(50, 0);
            ultraGridColumn414.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn414.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn414.Width = 27;
            ultraGridColumn415.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn415.DefaultCellValue = "100";
            ultraGridColumn415.Header.VisiblePosition = 6;
            ultraGridColumn415.LockedWidth = true;
            ultraGridColumn415.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn415.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn415.MaxLength = 27;
            ultraGridColumn415.MaxWidth = 27;
            ultraGridColumn415.RowLayoutColumnInfo.OriginX = 1;
            ultraGridColumn415.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn415.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(41, 0);
            ultraGridColumn415.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(41, 0);
            ultraGridColumn415.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn415.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn415.Width = 27;
            ultraGridColumn416.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn416.DefaultCellValue = "100";
            ultraGridColumn416.Header.VisiblePosition = 7;
            ultraGridColumn416.LockedWidth = true;
            ultraGridColumn416.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn416.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn416.MaxLength = 27;
            ultraGridColumn416.MaxWidth = 27;
            ultraGridColumn416.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn416.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn416.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(48, 0);
            ultraGridColumn416.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(48, 0);
            ultraGridColumn416.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn416.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn416.Width = 27;
            ultraGridColumn417.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn417.DefaultCellValue = "100";
            ultraGridColumn417.Header.VisiblePosition = 8;
            ultraGridColumn417.LockedWidth = true;
            ultraGridColumn417.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn417.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn417.MaxLength = 27;
            ultraGridColumn417.MaxWidth = 27;
            ultraGridColumn417.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn417.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn417.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(49, 0);
            ultraGridColumn417.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(49, 0);
            ultraGridColumn417.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn417.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn417.Width = 27;
            ultraGridColumn418.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn418.DefaultCellValue = "100";
            ultraGridColumn418.Header.VisiblePosition = 9;
            ultraGridColumn418.LockedWidth = true;
            ultraGridColumn418.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn418.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn418.MaxLength = 27;
            ultraGridColumn418.MaxWidth = 27;
            ultraGridColumn418.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn418.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn418.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(42, 0);
            ultraGridColumn418.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(42, 0);
            ultraGridColumn418.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn418.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn418.Width = 27;
            ultraGridColumn419.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn419.DefaultCellValue = "100";
            ultraGridColumn419.Header.VisiblePosition = 10;
            ultraGridColumn419.LockedWidth = true;
            ultraGridColumn419.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn419.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn419.MaxLength = 27;
            ultraGridColumn419.MaxWidth = 27;
            ultraGridColumn419.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn419.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn419.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(64, 0);
            ultraGridColumn419.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(64, 0);
            ultraGridColumn419.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn419.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn419.Width = 27;
            ultraGridColumn420.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn420.DefaultCellValue = "100";
            ultraGridColumn420.Header.VisiblePosition = 11;
            ultraGridColumn420.LockedWidth = true;
            ultraGridColumn420.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn420.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn420.MaxLength = 27;
            ultraGridColumn420.MaxWidth = 27;
            ultraGridColumn420.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn420.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn420.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(58, 0);
            ultraGridColumn420.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(50, 0);
            ultraGridColumn420.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn420.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn420.Width = 27;
            ultraGridColumn421.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn421.DefaultCellValue = "100";
            ultraGridColumn421.Header.VisiblePosition = 12;
            ultraGridColumn421.LockedWidth = true;
            ultraGridColumn421.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn421.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn421.MaxLength = 27;
            ultraGridColumn421.MaxWidth = 27;
            ultraGridColumn421.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn421.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn421.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(51, 0);
            ultraGridColumn421.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(32, 0);
            ultraGridColumn421.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn421.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn421.Width = 27;
            ultraGridColumn422.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn422.DefaultCellValue = "100";
            ultraGridColumn422.Header.VisiblePosition = 13;
            ultraGridColumn422.LockedWidth = true;
            ultraGridColumn422.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn422.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn422.MaxLength = 27;
            ultraGridColumn422.MaxWidth = 27;
            ultraGridColumn422.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn422.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn422.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(60, 0);
            ultraGridColumn422.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(50, 0);
            ultraGridColumn422.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn422.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn422.Width = 27;
            ultraGridColumn423.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn423.DefaultCellValue = "100";
            ultraGridColumn423.Header.VisiblePosition = 14;
            ultraGridColumn423.LockedWidth = true;
            ultraGridColumn423.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn423.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn423.MaxLength = 27;
            ultraGridColumn423.MaxWidth = 27;
            ultraGridColumn423.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn423.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn423.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(40, 0);
            ultraGridColumn423.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(40, 0);
            ultraGridColumn423.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn423.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn423.Width = 27;
            ultraGridColumn424.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn424.DefaultCellValue = "100";
            ultraGridColumn424.Header.VisiblePosition = 15;
            ultraGridColumn424.LockedWidth = true;
            ultraGridColumn424.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn424.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn424.MaxLength = 27;
            ultraGridColumn424.MaxWidth = 27;
            ultraGridColumn424.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn424.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn424.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(47, 0);
            ultraGridColumn424.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(47, 0);
            ultraGridColumn424.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn424.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn424.Width = 27;
            ultraGridColumn425.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn425.DefaultCellValue = "100";
            ultraGridColumn425.Header.VisiblePosition = 17;
            ultraGridColumn425.LockedWidth = true;
            ultraGridColumn425.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn425.MaskInput = "{LOC}nn,nnn,nnn%";
            ultraGridColumn425.MaxLength = 27;
            ultraGridColumn425.MaxWidth = 27;
            ultraGridColumn425.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn425.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn425.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(56, 0);
            ultraGridColumn425.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(50, 0);
            ultraGridColumn425.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn425.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn425.Width = 27;
            ultraGridColumn426.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn426.Header.Caption = "Observaciones Administrativas";
            ultraGridColumn426.Header.VisiblePosition = 16;
            ultraGridColumn426.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn426.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn426.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(820, 0);
            ultraGridColumn426.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(168, 0);
            ultraGridColumn426.RowLayoutColumnInfo.SpanX = 19;
            ultraGridColumn426.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn427.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn427.Header.Caption = "Negocio";
            ultraGridColumn427.Header.VisiblePosition = 18;
            ultraGridColumn427.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn427.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn427.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(203, 0);
            ultraGridColumn427.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn427.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn427.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn428.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn428.Header.VisiblePosition = 20;
            ultraGridColumn429.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn429.Header.VisiblePosition = 19;
            ultraGridColumn430.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn430.Header.VisiblePosition = 21;
            ultraGridBand30.Columns.AddRange(new object[] {
            ultraGridColumn409,
            ultraGridColumn410,
            ultraGridColumn411,
            ultraGridColumn412,
            ultraGridColumn413,
            ultraGridColumn414,
            ultraGridColumn415,
            ultraGridColumn416,
            ultraGridColumn417,
            ultraGridColumn418,
            ultraGridColumn419,
            ultraGridColumn420,
            ultraGridColumn421,
            ultraGridColumn422,
            ultraGridColumn423,
            ultraGridColumn424,
            ultraGridColumn425,
            ultraGridColumn426,
            ultraGridColumn427,
            ultraGridColumn428,
            ultraGridColumn429,
            ultraGridColumn430});
            appearance267.FontData.BoldAsString = "True";
            appearance267.FontData.SizeInPoints = 11F;
            appearance267.TextHAlignAsString = "Left";
            ultraGridBand30.Header.Appearance = appearance267;
            ultraGridBand30.Header.Caption = "Contratos";
            ultraGridBand30.HeaderVisible = true;
            ultraGridBand30.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand30.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand30.VisiblePosition = 5;
            ultraGridColumn431.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn431.Header.Caption = "Tipo";
            ultraGridColumn431.Header.VisiblePosition = 1;
            ultraGridColumn431.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn431.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn431.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn431.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn431.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn431.Width = 73;
            ultraGridColumn432.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn432.Header.VisiblePosition = 2;
            ultraGridColumn432.Hidden = true;
            ultraGridColumn432.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn432.Width = 98;
            ultraGridColumn433.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn433.Header.VisiblePosition = 3;
            ultraGridColumn433.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn433.MaskInput = "dd/mm/yyyy";
            ultraGridColumn433.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn433.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn433.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(74, 0);
            ultraGridColumn433.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(74, 0);
            ultraGridColumn433.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn433.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn433.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownCalendar;
            ultraGridColumn433.Width = 51;
            ultraGridColumn434.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn434.Header.Caption = "Fin Suspensión";
            ultraGridColumn434.Header.VisiblePosition = 4;
            ultraGridColumn434.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn434.MaskInput = "dd/mm/yyyy";
            ultraGridColumn434.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn434.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn434.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(89, 0);
            ultraGridColumn434.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(89, 0);
            ultraGridColumn434.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn434.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn434.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownCalendar;
            ultraGridColumn434.Width = 72;
            ultraGridColumn435.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn435.Header.Caption = "Renovación";
            ultraGridColumn435.Header.VisiblePosition = 5;
            ultraGridColumn435.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn435.MaskInput = "dd/mm/yyyy";
            ultraGridColumn435.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn435.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn435.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(73, 0);
            ultraGridColumn435.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(73, 0);
            ultraGridColumn435.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn435.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn435.Width = 62;
            ultraGridColumn436.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn436.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn436.Header.Caption = "Registro";
            ultraGridColumn436.Header.VisiblePosition = 7;
            ultraGridColumn436.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn436.MaskInput = "dd/mm/yyyy hh:mm";
            ultraGridColumn436.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn436.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn436.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(107, 0);
            ultraGridColumn436.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(107, 0);
            ultraGridColumn436.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn436.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn436.Width = 80;
            ultraGridColumn437.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn437.Header.Caption = "Vendedor";
            ultraGridColumn437.Header.VisiblePosition = 6;
            ultraGridColumn437.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn437.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn437.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(146, 0);
            ultraGridColumn437.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn437.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn437.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn437.Width = 125;
            ultraGridColumn438.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn438.Header.Caption = "Tomador de Baja";
            ultraGridColumn438.Header.VisiblePosition = 9;
            ultraGridColumn438.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn438.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn438.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(131, 0);
            ultraGridColumn438.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(131, 0);
            ultraGridColumn438.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn438.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn438.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn438.Width = 85;
            ultraGridColumn439.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn439.Header.Caption = "Motivo de Baja";
            ultraGridColumn439.Header.VisiblePosition = 8;
            ultraGridColumn439.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn439.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn439.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(109, 0);
            ultraGridColumn439.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(109, 0);
            ultraGridColumn439.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn439.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn439.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn439.Width = 137;
            ultraGridColumn440.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn440.Header.VisiblePosition = 10;
            ultraGridColumn440.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn440.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn440.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(689, 0);
            ultraGridColumn440.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(689, 0);
            ultraGridColumn440.RowLayoutColumnInfo.SpanX = 14;
            ultraGridColumn440.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn440.Width = 79;
            ultraGridColumn441.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn441.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn441.Header.Caption = "Grabador";
            ultraGridColumn441.Header.VisiblePosition = 11;
            ultraGridColumn441.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn441.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn441.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(107, 0);
            ultraGridColumn441.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(107, 0);
            ultraGridColumn441.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn441.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn441.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn442.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn442.Header.VisiblePosition = 0;
            ultraGridColumn442.Hidden = true;
            ultraGridColumn442.Width = 76;
            ultraGridBand31.Columns.AddRange(new object[] {
            ultraGridColumn431,
            ultraGridColumn432,
            ultraGridColumn433,
            ultraGridColumn434,
            ultraGridColumn435,
            ultraGridColumn436,
            ultraGridColumn437,
            ultraGridColumn438,
            ultraGridColumn439,
            ultraGridColumn440,
            ultraGridColumn441,
            ultraGridColumn442});
            appearance268.FontData.BoldAsString = "True";
            appearance268.FontData.SizeInPoints = 11F;
            appearance268.TextHAlignAsString = "Left";
            ultraGridBand31.Header.Appearance = appearance268;
            ultraGridBand31.Header.Caption = "Solicitudes";
            ultraGridBand31.HeaderVisible = true;
            ultraGridBand31.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand31.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn443.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn443.Header.VisiblePosition = 0;
            ultraGridColumn443.Hidden = true;
            ultraGridColumn443.Width = 127;
            ultraGridColumn444.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn444.Header.VisiblePosition = 1;
            ultraGridColumn444.Width = 177;
            ultraGridColumn445.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn445.Header.VisiblePosition = 2;
            ultraGridColumn445.Width = 69;
            ultraGridColumn446.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn446.Header.VisiblePosition = 3;
            ultraGridColumn446.Hidden = true;
            ultraGridColumn446.Width = 185;
            ultraGridColumn447.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance269.TextHAlignAsString = "Right";
            ultraGridColumn447.CellAppearance = appearance269;
            ultraGridColumn447.Header.Caption = "Cuota Titular";
            ultraGridColumn447.Header.VisiblePosition = 4;
            ultraGridColumn447.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn447.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn447.Width = 73;
            ultraGridColumn448.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn448.DefaultCellValue = "True";
            ultraGridColumn448.Header.VisiblePosition = 6;
            ultraGridColumn448.Width = 48;
            ultraGridColumn449.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn449.DefaultCellValue = "False";
            ultraGridColumn449.Header.Caption = "Padrón Externo";
            ultraGridColumn449.Header.VisiblePosition = 7;
            ultraGridColumn449.Width = 92;
            ultraGridColumn450.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn450.Header.Caption = "Protección";
            ultraGridColumn450.Header.VisiblePosition = 8;
            ultraGridColumn450.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn450.Width = 109;
            ultraGridColumn451.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn451.Header.Caption = "Prepago";
            ultraGridColumn451.Header.VisiblePosition = 9;
            ultraGridColumn451.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn451.Width = 130;
            appearance270.TextHAlignAsString = "Right";
            ultraGridColumn452.CellAppearance = appearance270;
            ultraGridColumn452.Header.Caption = "Cuota Adherente";
            ultraGridColumn452.Header.VisiblePosition = 5;
            ultraGridColumn452.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn452.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridBand32.Columns.AddRange(new object[] {
            ultraGridColumn443,
            ultraGridColumn444,
            ultraGridColumn445,
            ultraGridColumn446,
            ultraGridColumn447,
            ultraGridColumn448,
            ultraGridColumn449,
            ultraGridColumn450,
            ultraGridColumn451,
            ultraGridColumn452});
            appearance271.FontData.BoldAsString = "True";
            appearance271.FontData.SizeInPoints = 11F;
            appearance271.TextHAlignAsString = "Left";
            ultraGridBand32.Header.Appearance = appearance271;
            ultraGridBand32.Header.Caption = "Planes";
            ultraGridBand32.HeaderVisible = true;
            ultraGridColumn453.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn453.Header.VisiblePosition = 0;
            ultraGridColumn453.Hidden = true;
            ultraGridColumn453.Width = 61;
            ultraGridColumn454.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn454.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn454.Header.Caption = "Localidad";
            ultraGridColumn454.Header.VisiblePosition = 1;
            ultraGridColumn454.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn454.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn454.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(104, 0);
            ultraGridColumn454.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(104, 0);
            ultraGridColumn454.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn454.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn454.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn454.Width = 68;
            ultraGridColumn455.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn455.Header.Caption = "Calle";
            ultraGridColumn455.Header.VisiblePosition = 2;
            ultraGridColumn455.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn455.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn455.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(143, 0);
            ultraGridColumn455.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(143, 0);
            ultraGridColumn455.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn455.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn455.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn455.Width = 55;
            ultraGridColumn456.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn456.Header.Caption = "Número";
            ultraGridColumn456.Header.VisiblePosition = 3;
            ultraGridColumn456.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn456.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn456.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(54, 0);
            ultraGridColumn456.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(54, 0);
            ultraGridColumn456.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn456.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn456.Width = 92;
            ultraGridColumn457.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn457.Header.VisiblePosition = 4;
            ultraGridColumn457.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn457.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn457.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(47, 0);
            ultraGridColumn457.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(47, 0);
            ultraGridColumn457.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn457.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn457.Width = 92;
            ultraGridColumn458.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn458.Header.Caption = "Depto.";
            ultraGridColumn458.Header.VisiblePosition = 5;
            ultraGridColumn458.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn458.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn458.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(57, 0);
            ultraGridColumn458.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(57, 0);
            ultraGridColumn458.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn458.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn458.Width = 92;
            ultraGridColumn459.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn459.Header.Caption = "Entre";
            ultraGridColumn459.Header.VisiblePosition = 6;
            ultraGridColumn459.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn459.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn459.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(143, 0);
            ultraGridColumn459.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(143, 0);
            ultraGridColumn459.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn459.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn459.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn459.Width = 78;
            ultraGridColumn460.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn460.Header.Caption = "y";
            ultraGridColumn460.Header.VisiblePosition = 7;
            ultraGridColumn460.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn460.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn460.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(158, 0);
            ultraGridColumn460.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(158, 0);
            ultraGridColumn460.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn460.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn460.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn460.Width = 78;
            ultraGridColumn461.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn461.Header.VisiblePosition = 8;
            ultraGridColumn461.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn461.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn461.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(167, 55);
            ultraGridColumn461.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(167, 0);
            ultraGridColumn461.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn461.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn461.Width = 92;
            ultraGridColumn462.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn462.Header.VisiblePosition = 9;
            ultraGridColumn462.Hidden = true;
            ultraGridColumn462.Width = 63;
            ultraGridColumn463.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn463.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn463.Header.Caption = "Barrio";
            ultraGridColumn463.Header.VisiblePosition = 10;
            ultraGridColumn463.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn463.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn463.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(104, 0);
            ultraGridColumn463.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(104, 0);
            ultraGridColumn463.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn463.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn463.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn463.Width = 55;
            ultraGridColumn464.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn464.Header.VisiblePosition = 11;
            ultraGridBand33.Columns.AddRange(new object[] {
            ultraGridColumn453,
            ultraGridColumn454,
            ultraGridColumn455,
            ultraGridColumn456,
            ultraGridColumn457,
            ultraGridColumn458,
            ultraGridColumn459,
            ultraGridColumn460,
            ultraGridColumn461,
            ultraGridColumn462,
            ultraGridColumn463,
            ultraGridColumn464});
            appearance272.FontData.BoldAsString = "True";
            appearance272.FontData.SizeInPoints = 11F;
            appearance272.TextHAlignAsString = "Left";
            ultraGridBand33.Header.Appearance = appearance272;
            ultraGridBand33.Header.Caption = "Dirección del Contrato";
            ultraGridBand33.HeaderVisible = true;
            ultraGridBand33.MaxRows = 1;
            ultraGridBand33.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand33.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand34.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand34.CardSettings.ShowCaption = false;
            ultraGridBand34.CardView = true;
            ultraGridColumn465.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn465.Header.VisiblePosition = 0;
            ultraGridColumn465.Hidden = true;
            ultraGridColumn465.Width = 232;
            ultraGridColumn466.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn466.Header.VisiblePosition = 1;
            ultraGridColumn466.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(97, 0);
            ultraGridColumn466.Width = 334;
            ultraGridColumn467.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn467.Header.VisiblePosition = 2;
            ultraGridColumn467.Hidden = true;
            ultraGridColumn467.Width = 241;
            ultraGridBand34.Columns.AddRange(new object[] {
            ultraGridColumn465,
            ultraGridColumn466,
            ultraGridColumn467});
            appearance273.FontData.BoldAsString = "True";
            appearance273.FontData.SizeInPoints = 11F;
            appearance273.TextHAlignAsString = "Left";
            ultraGridBand34.Header.Appearance = appearance273;
            ultraGridBand34.Header.Caption = "Teléfonos";
            ultraGridBand34.HeaderVisible = true;
            ultraGridBand34.MaxRows = 7;
            ultraGridBand34.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand34.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn468.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn468.Header.VisiblePosition = 0;
            ultraGridColumn468.Hidden = true;
            ultraGridColumn468.Width = 260;
            ultraGridColumn469.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn469.Header.VisiblePosition = 1;
            ultraGridColumn469.Hidden = true;
            ultraGridColumn469.Width = 141;
            ultraGridColumn470.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn470.Header.VisiblePosition = 2;
            ultraGridColumn470.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn470.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn470.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(271, 0);
            ultraGridColumn470.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn470.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn470.Width = 235;
            ultraGridColumn471.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn471.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn471.Header.Caption = "Tanda de Facturación";
            ultraGridColumn471.Header.VisiblePosition = 3;
            ultraGridColumn471.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn471.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn471.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn471.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn471.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn472.Header.Caption = "Facturar Mes";
            ultraGridColumn472.Header.ToolTipText = "Las prestaciones se facturan siempre a mes vencido.";
            ultraGridColumn472.Header.VisiblePosition = 4;
            ultraGridColumn472.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn472.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn472.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn472.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn472.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn473.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn473.Header.VisiblePosition = 5;
            ultraGridBand35.Columns.AddRange(new object[] {
            ultraGridColumn468,
            ultraGridColumn469,
            ultraGridColumn470,
            ultraGridColumn471,
            ultraGridColumn472,
            ultraGridColumn473});
            appearance274.FontData.BoldAsString = "True";
            appearance274.FontData.SizeInPoints = 11F;
            appearance274.TextHAlignAsString = "Left";
            ultraGridBand35.Header.Appearance = appearance274;
            ultraGridBand35.Header.Caption = "Molde de Factura";
            ultraGridBand35.HeaderVisible = true;
            ultraGridBand35.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand35.VisiblePosition = 6;
            ultraGridColumn474.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn474.Header.VisiblePosition = 0;
            ultraGridColumn474.Hidden = true;
            ultraGridColumn474.Width = 162;
            ultraGridColumn475.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance275.TextHAlignAsString = "Right";
            ultraGridColumn475.CellAppearance = appearance275;
            ultraGridColumn475.Header.VisiblePosition = 1;
            ultraGridColumn475.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn475.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn475.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(59, 0);
            ultraGridColumn475.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn475.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn475.Width = 99;
            ultraGridColumn476.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance276.TextHAlignAsString = "Right";
            ultraGridColumn476.CellAppearance = appearance276;
            ultraGridColumn476.Header.Caption = "Precio Unitario";
            ultraGridColumn476.Header.VisiblePosition = 2;
            ultraGridColumn476.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn476.MaskInput = "{LOC}$ n,nnn,nnn.nnn";
            ultraGridColumn476.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn476.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn476.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(70, 0);
            ultraGridColumn476.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn476.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn476.Width = 138;
            ultraGridColumn477.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn477.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn477.Header.Caption = "Contrato";
            ultraGridColumn477.Header.VisiblePosition = 3;
            ultraGridColumn477.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn477.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn477.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(158, 0);
            ultraGridColumn477.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(56, 0);
            ultraGridColumn477.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn477.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn477.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn477.Width = 106;
            ultraGridColumn478.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn478.DefaultCellValue = "False";
            ultraGridColumn478.Header.Caption = "Revisar";
            ultraGridColumn478.Header.VisiblePosition = 4;
            ultraGridColumn478.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn478.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn478.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(42, 0);
            ultraGridColumn478.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn478.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn478.Width = 201;
            ultraGridColumn479.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn479.Header.VisiblePosition = 6;
            ultraGridColumn479.Hidden = true;
            ultraGridColumn479.Width = 115;
            ultraGridColumn480.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn480.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridColumn480.Header.Caption = "Plan";
            ultraGridColumn480.Header.VisiblePosition = 5;
            ultraGridColumn480.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn480.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn480.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(137, 0);
            ultraGridColumn480.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(137, 0);
            ultraGridColumn480.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn480.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn480.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn481.Header.VisiblePosition = 7;
            ultraGridColumn481.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn481.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn481.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn481.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn482.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn482.Header.Caption = "IVA";
            ultraGridColumn482.Header.VisiblePosition = 8;
            ultraGridColumn482.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn482.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn482.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(103, 0);
            ultraGridColumn482.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(103, 0);
            ultraGridColumn482.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn482.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn482.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridBand36.Columns.AddRange(new object[] {
            ultraGridColumn474,
            ultraGridColumn475,
            ultraGridColumn476,
            ultraGridColumn477,
            ultraGridColumn478,
            ultraGridColumn479,
            ultraGridColumn480,
            ultraGridColumn481,
            ultraGridColumn482});
            appearance277.FontData.BoldAsString = "True";
            appearance277.FontData.SizeInPoints = 11F;
            appearance277.TextHAlignAsString = "Left";
            ultraGridBand36.Header.Appearance = appearance277;
            ultraGridBand36.Header.Caption = "Renglones del Molde de Factura";
            ultraGridBand36.HeaderVisible = true;
            ultraGridBand36.MaxRows = 8;
            ultraGridBand36.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand36.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn483.Header.VisiblePosition = 0;
            ultraGridColumn483.Hidden = true;
            appearance278.FontData.BoldAsString = "True";
            appearance278.FontData.SizeInPoints = 11F;
            appearance278.TextHAlignAsString = "Left";
            ultraGridColumn484.Header.Appearance = appearance278;
            ultraGridColumn484.Header.Caption = "e-mail del Cliente";
            ultraGridColumn484.Header.VisiblePosition = 1;
            ultraGridColumn485.Header.VisiblePosition = 2;
            ultraGridColumn485.Hidden = true;
            ultraGridBand37.Columns.AddRange(new object[] {
            ultraGridColumn483,
            ultraGridColumn484,
            ultraGridColumn485});
            ultraGridBand37.MaxRows = 1;
            ultraGridBand37.VisiblePosition = 2;
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand24);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand25);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand26);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand27);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand28);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand29);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand30);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand31);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand32);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand33);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand34);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand35);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand36);
            this.clientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand37);
            this.clientesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.clientesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.clientesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance240.BackColor = System.Drawing.SystemColors.Window;
            this.clientesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance240;
            appearance241.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance241.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance241.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance241.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clientesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance241;
            this.clientesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.clientesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.clientesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.clientesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.clientesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.clientesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.clientesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance242.BackColor = System.Drawing.Color.Transparent;
            this.clientesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance242;
            appearance243.BackColor = System.Drawing.SystemColors.Control;
            appearance243.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance243.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.clientesUltraGrid.DisplayLayout.Override.CellAppearance = appearance243;
            this.clientesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance244.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance244.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance244.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance244.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance244.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.clientesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance244;
            this.clientesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance255.ForeColor = System.Drawing.Color.Red;
            this.clientesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance255;
            this.clientesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance256.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.clientesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance256;
            appearance257.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance257.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance257.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.clientesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance257;
            appearance258.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance258.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.clientesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance258;
            this.clientesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clientesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.clientesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.clientesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.clientesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clientesUltraGrid.Location = new System.Drawing.Point(0, 0);
            this.clientesUltraGrid.Name = "clientesUltraGrid";
            this.clientesUltraGrid.Size = new System.Drawing.Size(900, 535);
            this.clientesUltraGrid.TabIndex = 2;
            this.clientesUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ClientesUltraGridInitializeRow);
            this.clientesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.ClientesUltraGridAfterEnterEditMode);
            this.clientesUltraGrid.AfterRowActivate += new System.EventHandler(this.ClientesUltraGridAfterRowActivate);
            this.clientesUltraGrid.AfterRowsDeleted += new System.EventHandler(this.ClientesUltraGridAfterRowsDeleted);
            this.clientesUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ClientesUltraGridCellChange);
            this.clientesUltraGrid.BeforeExitEditMode += new Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventHandler(this.ClientesUltraGridBeforeExitEditMode);
            this.clientesUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.ClientesUltraGridBeforeRowDeactivate);
            this.clientesUltraGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.ClientesUltraGridBeforeRowsDeleted);
            this.clientesUltraGrid.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.clientesUltraGrid_DoubleClickCell);
            this.clientesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientesUltraGrid_KeyDown);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dsClientes;
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "DsClientes";
            this.dsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(674, 13);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Visible = false;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalirClick);
            // 
            // ultraDropDownCalle
            // 
            this.ultraDropDownCalle.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCalle.DataSource = this.callesBindingSource;
            appearance149.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance149.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance149.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalle.DisplayLayout.Appearance = appearance149;
            ultraGridBand22.ColHeadersVisible = false;
            ultraGridColumn345.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn345.Header.VisiblePosition = 0;
            ultraGridColumn345.Hidden = true;
            ultraGridColumn346.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn346.Header.VisiblePosition = 1;
            ultraGridColumn346.Hidden = true;
            ultraGridColumn347.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn347.Header.VisiblePosition = 2;
            ultraGridColumn347.Hidden = true;
            ultraGridColumn348.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn348.Header.VisiblePosition = 3;
            ultraGridBand22.Columns.AddRange(new object[] {
            ultraGridColumn345,
            ultraGridColumn346,
            ultraGridColumn347,
            ultraGridColumn348});
            ultraGridBand22.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand22.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCalle.DisplayLayout.BandsSerializer.Add(ultraGridBand22);
            this.ultraDropDownCalle.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCalle.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCalle.DisplayLayout.MaxBandDepth = 5;
            appearance150.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCalle.DisplayLayout.Override.ActiveCellAppearance = appearance150;
            appearance151.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance151.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance151.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance151.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCalle.DisplayLayout.Override.ActiveRowAppearance = appearance151;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance152.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCalle.DisplayLayout.Override.CardAreaAppearance = appearance152;
            appearance153.BackColor = System.Drawing.SystemColors.Control;
            appearance153.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance153.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalle.DisplayLayout.Override.CellAppearance = appearance153;
            this.ultraDropDownCalle.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance154.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance154.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance154.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance154.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance154.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCalle.DisplayLayout.Override.HeaderAppearance = appearance154;
            this.ultraDropDownCalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance155.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCalle.DisplayLayout.Override.RowSelectorAppearance = appearance155;
            this.ultraDropDownCalle.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance156.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCalle.DisplayLayout.Override.SelectedCellAppearance = appearance156;
            appearance157.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance157.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance157.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalle.DisplayLayout.Override.SelectedRowAppearance = appearance157;
            appearance158.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance158.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCalle.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance158;
            this.ultraDropDownCalle.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCalle.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCalle.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCalle.DisplayMember = "Nombre";
            this.ultraDropDownCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCalle.Location = new System.Drawing.Point(12, 273);
            this.ultraDropDownCalle.Name = "ultraDropDownCalle";
            this.ultraDropDownCalle.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCalle.TabIndex = 9;
            this.ultraDropDownCalle.ValueMember = "idCalle";
            this.ultraDropDownCalle.Visible = false;
            this.ultraDropDownCalle.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCalleBeforeDropDown);
            this.ultraDropDownCalle.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCalleFilterRow);
            // 
            // callesBindingSource
            // 
            this.callesBindingSource.DataMember = "Calles";
            this.callesBindingSource.DataSource = this.dsCallesLista;
            // 
            // dsCallesLista
            // 
            this.dsCallesLista.DataSetName = "DsCallesLista";
            this.dsCallesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownZonas
            // 
            this.ultraDropDownZonas.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownZonas.DataSource = this.zonasBindingSource;
            appearance200.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance200.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance200.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownZonas.DisplayLayout.Appearance = appearance200;
            ultraGridBand20.ColHeadersVisible = false;
            ultraGridColumn336.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn336.Header.VisiblePosition = 0;
            ultraGridColumn336.Hidden = true;
            ultraGridColumn337.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn337.Header.VisiblePosition = 1;
            ultraGridColumn338.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn338.Header.VisiblePosition = 2;
            ultraGridColumn338.Hidden = true;
            ultraGridColumn339.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn339.Header.VisiblePosition = 3;
            ultraGridColumn339.Hidden = true;
            ultraGridColumn340.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn340.Header.VisiblePosition = 4;
            ultraGridColumn340.Hidden = true;
            ultraGridColumn341.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn341.Header.VisiblePosition = 5;
            ultraGridColumn341.Hidden = true;
            ultraGridBand20.Columns.AddRange(new object[] {
            ultraGridColumn336,
            ultraGridColumn337,
            ultraGridColumn338,
            ultraGridColumn339,
            ultraGridColumn340,
            ultraGridColumn341});
            ultraGridBand20.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand20.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownZonas.DisplayLayout.BandsSerializer.Add(ultraGridBand20);
            this.ultraDropDownZonas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownZonas.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownZonas.DisplayLayout.MaxBandDepth = 5;
            appearance201.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownZonas.DisplayLayout.Override.ActiveCellAppearance = appearance201;
            appearance202.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance202.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance202.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance202.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownZonas.DisplayLayout.Override.ActiveRowAppearance = appearance202;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance203.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownZonas.DisplayLayout.Override.CardAreaAppearance = appearance203;
            appearance204.BackColor = System.Drawing.SystemColors.Control;
            appearance204.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance204.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownZonas.DisplayLayout.Override.CellAppearance = appearance204;
            this.ultraDropDownZonas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance134.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance134.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance134.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance134.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownZonas.DisplayLayout.Override.HeaderAppearance = appearance134;
            this.ultraDropDownZonas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance135.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownZonas.DisplayLayout.Override.RowSelectorAppearance = appearance135;
            this.ultraDropDownZonas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownZonas.DisplayLayout.Override.SelectedCellAppearance = appearance136;
            appearance137.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance137.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance137.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownZonas.DisplayLayout.Override.SelectedRowAppearance = appearance137;
            appearance138.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance138.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownZonas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance138;
            this.ultraDropDownZonas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownZonas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownZonas.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownZonas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownZonas.DisplayMember = "Nombre";
            this.ultraDropDownZonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownZonas.Location = new System.Drawing.Point(256, 233);
            this.ultraDropDownZonas.Name = "ultraDropDownZonas";
            this.ultraDropDownZonas.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownZonas.TabIndex = 17;
            this.ultraDropDownZonas.ValueMember = "idZona";
            this.ultraDropDownZonas.Visible = false;
            this.ultraDropDownZonas.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownZonasBeforeDropDown);
            this.ultraDropDownZonas.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownZonasFilterRow);
            // 
            // zonasBindingSource
            // 
            this.zonasBindingSource.DataMember = "Zonas";
            this.zonasBindingSource.DataSource = this.dsZonas;
            // 
            // dsZonas
            // 
            this.dsZonas.DataSetName = "DsZonas";
            this.dsZonas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeCliente
            // 
            this.ultraDropDownTiposDeCliente.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeCliente.DataSource = this.tiposDeClienteBindingSource;
            appearance119.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance119.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance119.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Appearance = appearance119;
            ultraGridBand19.ColHeadersVisible = false;
            ultraGridColumn333.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn333.Header.VisiblePosition = 0;
            ultraGridColumn333.Hidden = true;
            ultraGridColumn334.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn334.Header.VisiblePosition = 1;
            ultraGridColumn335.Header.VisiblePosition = 2;
            ultraGridColumn335.Hidden = true;
            ultraGridBand19.Columns.AddRange(new object[] {
            ultraGridColumn333,
            ultraGridColumn334,
            ultraGridColumn335});
            ultraGridBand19.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand19.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeCliente.DisplayLayout.BandsSerializer.Add(ultraGridBand19);
            this.ultraDropDownTiposDeCliente.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeCliente.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeCliente.DisplayLayout.MaxBandDepth = 5;
            appearance120.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.ActiveCellAppearance = appearance120;
            appearance121.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance121.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance121.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance121.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.ActiveRowAppearance = appearance121;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance122.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.CardAreaAppearance = appearance122;
            appearance123.BackColor = System.Drawing.SystemColors.Control;
            appearance123.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance123.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.CellAppearance = appearance123;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance195.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance195.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance195.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance195.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance195.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.HeaderAppearance = appearance195;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance196.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.RowSelectorAppearance = appearance196;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance197.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.SelectedCellAppearance = appearance197;
            appearance198.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance198.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance198.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.SelectedRowAppearance = appearance198;
            appearance199.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance199.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeCliente.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance199;
            this.ultraDropDownTiposDeCliente.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeCliente.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeCliente.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeCliente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeCliente.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTiposDeCliente.Location = new System.Drawing.Point(258, 353);
            this.ultraDropDownTiposDeCliente.Name = "ultraDropDownTiposDeCliente";
            this.ultraDropDownTiposDeCliente.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeCliente.TabIndex = 18;
            this.ultraDropDownTiposDeCliente.ValueMember = "idTipoDeCliente";
            this.ultraDropDownTiposDeCliente.Visible = false;
            this.ultraDropDownTiposDeCliente.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTiposDeClienteBeforeDropDown);
            // 
            // tiposDeClienteBindingSource
            // 
            this.tiposDeClienteBindingSource.DataMember = "TiposDeCliente";
            this.tiposDeClienteBindingSource.DataSource = this.dsTiposDeCliente;
            // 
            // dsTiposDeCliente
            // 
            this.dsTiposDeCliente.DataSetName = "DsTiposDeCliente";
            this.dsTiposDeCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasIVABindingSource
            // 
            this.categoriasIVABindingSource.DataMember = "CategoriasIVA";
            this.categoriasIVABindingSource.DataSource = this.dsCategoriasIVA;
            // 
            // dsCategoriasIVA
            // 
            this.dsCategoriasIVA.DataSetName = "DsCategoriasIVA";
            this.dsCategoriasIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeCobranza
            // 
            this.ultraDropDownTiposDeCobranza.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeCobranza.DataSource = this.tiposDeCobranzaBindingSource;
            appearance109.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance109.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Appearance = appearance109;
            ultraGridBand18.ColHeadersVisible = false;
            ultraGridColumn328.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn328.Header.VisiblePosition = 0;
            ultraGridColumn328.Hidden = true;
            ultraGridColumn329.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn329.Header.VisiblePosition = 1;
            ultraGridColumn330.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn330.Header.VisiblePosition = 2;
            ultraGridColumn330.Hidden = true;
            ultraGridColumn331.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn331.Header.VisiblePosition = 3;
            ultraGridColumn331.Hidden = true;
            ultraGridColumn332.Header.VisiblePosition = 4;
            ultraGridColumn332.Hidden = true;
            ultraGridBand18.Columns.AddRange(new object[] {
            ultraGridColumn328,
            ultraGridColumn329,
            ultraGridColumn330,
            ultraGridColumn331,
            ultraGridColumn332});
            ultraGridBand18.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand18.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.BandsSerializer.Add(ultraGridBand18);
            this.ultraDropDownTiposDeCobranza.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.MaxBandDepth = 5;
            appearance110.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.ActiveCellAppearance = appearance110;
            appearance111.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance111.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance111.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.ActiveRowAppearance = appearance111;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance112.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.CardAreaAppearance = appearance112;
            appearance113.BackColor = System.Drawing.SystemColors.Control;
            appearance113.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.CellAppearance = appearance113;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance114.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance114.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance114.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance114.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance114.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.HeaderAppearance = appearance114;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance115.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.RowSelectorAppearance = appearance115;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance116.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.SelectedCellAppearance = appearance116;
            appearance117.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance117.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance117.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.SelectedRowAppearance = appearance117;
            appearance118.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance118.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance118;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeCobranza.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeCobranza.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeCobranza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTiposDeCobranza.Location = new System.Drawing.Point(500, 273);
            this.ultraDropDownTiposDeCobranza.Name = "ultraDropDownTiposDeCobranza";
            this.ultraDropDownTiposDeCobranza.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeCobranza.TabIndex = 19;
            this.ultraDropDownTiposDeCobranza.ValueMember = "idTipoDeCobranza";
            this.ultraDropDownTiposDeCobranza.Visible = false;
            this.ultraDropDownTiposDeCobranza.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTiposDeCobranzaBeforeDropDown);
            this.ultraDropDownTiposDeCobranza.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownTiposDeCobranzaFilterRow);
            // 
            // tiposDeCobranzaBindingSource
            // 
            this.tiposDeCobranzaBindingSource.DataMember = "TiposDeCobranza";
            this.tiposDeCobranzaBindingSource.DataSource = this.dsTiposDeCobranza;
            // 
            // dsTiposDeCobranza
            // 
            this.dsTiposDeCobranza.DataSetName = "DsTiposDeCobranza";
            this.dsTiposDeCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownEntidadesDeCobranza
            // 
            this.ultraDropDownEntidadesDeCobranza.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownEntidadesDeCobranza.DataSource = this.entidadesDeCobranzaBindingSource;
            appearance99.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance99.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Appearance = appearance99;
            ultraGridBand17.ColHeadersVisible = false;
            ultraGridColumn313.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn313.Header.VisiblePosition = 0;
            ultraGridColumn313.Hidden = true;
            ultraGridColumn314.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn314.Header.VisiblePosition = 1;
            ultraGridColumn315.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn315.Header.VisiblePosition = 3;
            ultraGridColumn315.Hidden = true;
            ultraGridColumn316.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn316.Header.VisiblePosition = 2;
            ultraGridColumn316.Hidden = true;
            ultraGridColumn317.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn317.Header.VisiblePosition = 4;
            ultraGridColumn317.Hidden = true;
            ultraGridColumn318.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn318.Header.VisiblePosition = 5;
            ultraGridColumn318.Hidden = true;
            ultraGridColumn319.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn319.Header.VisiblePosition = 6;
            ultraGridColumn319.Hidden = true;
            ultraGridColumn320.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn320.Header.VisiblePosition = 7;
            ultraGridColumn320.Hidden = true;
            ultraGridColumn321.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn321.Header.VisiblePosition = 8;
            ultraGridColumn321.Hidden = true;
            ultraGridColumn322.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn322.Header.VisiblePosition = 9;
            ultraGridColumn322.Hidden = true;
            ultraGridColumn323.Header.VisiblePosition = 10;
            ultraGridColumn323.Hidden = true;
            ultraGridColumn324.Header.VisiblePosition = 11;
            ultraGridColumn324.Hidden = true;
            ultraGridColumn325.Header.VisiblePosition = 12;
            ultraGridColumn325.Hidden = true;
            ultraGridColumn326.Header.VisiblePosition = 13;
            ultraGridColumn326.Hidden = true;
            ultraGridColumn327.Header.VisiblePosition = 14;
            ultraGridColumn327.Hidden = true;
            ultraGridBand17.Columns.AddRange(new object[] {
            ultraGridColumn313,
            ultraGridColumn314,
            ultraGridColumn315,
            ultraGridColumn316,
            ultraGridColumn317,
            ultraGridColumn318,
            ultraGridColumn319,
            ultraGridColumn320,
            ultraGridColumn321,
            ultraGridColumn322,
            ultraGridColumn323,
            ultraGridColumn324,
            ultraGridColumn325,
            ultraGridColumn326,
            ultraGridColumn327});
            ultraGridBand17.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand17.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.BandsSerializer.Add(ultraGridBand17);
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.MaxBandDepth = 5;
            appearance100.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.ActiveCellAppearance = appearance100;
            appearance101.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance101.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance101.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.ActiveRowAppearance = appearance101;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance102.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.CardAreaAppearance = appearance102;
            appearance103.BackColor = System.Drawing.SystemColors.Control;
            appearance103.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance103.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.CellAppearance = appearance103;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance104.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance104.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance104.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance104.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.HeaderAppearance = appearance104;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance105.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.RowSelectorAppearance = appearance105;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.SelectedCellAppearance = appearance106;
            appearance107.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance107.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance107.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.SelectedRowAppearance = appearance107;
            appearance108.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance108.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance108;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownEntidadesDeCobranza.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownEntidadesDeCobranza.DisplayMember = "Nombre";
            this.ultraDropDownEntidadesDeCobranza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownEntidadesDeCobranza.Location = new System.Drawing.Point(500, 233);
            this.ultraDropDownEntidadesDeCobranza.Name = "ultraDropDownEntidadesDeCobranza";
            this.ultraDropDownEntidadesDeCobranza.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownEntidadesDeCobranza.TabIndex = 20;
            this.ultraDropDownEntidadesDeCobranza.ValueMember = "idEntidadDeCobranza";
            this.ultraDropDownEntidadesDeCobranza.Visible = false;
            this.ultraDropDownEntidadesDeCobranza.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownEntidadesDeCobranzaBeforeDropDown);
            // 
            // entidadesDeCobranzaBindingSource
            // 
            this.entidadesDeCobranzaBindingSource.DataMember = "EntidadesDeCobranza";
            this.entidadesDeCobranzaBindingSource.DataSource = this.dsEntidadesDeCobranza;
            // 
            // dsEntidadesDeCobranza
            // 
            this.dsEntidadesDeCobranza.DataSetName = "DsEntidadesDeCobranza";
            this.dsEntidadesDeCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTiposDeContrato
            // 
            this.ultraDropDownTiposDeContrato.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeContrato.DataSource = this.tiposDeContratoBindingSource;
            appearance89.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance89.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Appearance = appearance89;
            ultraGridBand16.ColHeadersVisible = false;
            ultraGridColumn310.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn310.Header.VisiblePosition = 0;
            ultraGridColumn310.Hidden = true;
            ultraGridColumn311.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn311.Header.VisiblePosition = 1;
            ultraGridColumn312.Header.VisiblePosition = 2;
            ultraGridColumn312.Hidden = true;
            ultraGridBand16.Columns.AddRange(new object[] {
            ultraGridColumn310,
            ultraGridColumn311,
            ultraGridColumn312});
            ultraGridBand16.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand16.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownTiposDeContrato.DisplayLayout.BandsSerializer.Add(ultraGridBand16);
            this.ultraDropDownTiposDeContrato.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeContrato.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeContrato.DisplayLayout.MaxBandDepth = 5;
            appearance90.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.ActiveCellAppearance = appearance90;
            appearance91.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance91.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance91.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.ActiveRowAppearance = appearance91;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance92.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.CardAreaAppearance = appearance92;
            appearance93.BackColor = System.Drawing.SystemColors.Control;
            appearance93.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.CellAppearance = appearance93;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance94.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance94.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance94.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance94.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance94.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.HeaderAppearance = appearance94;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance95.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.RowSelectorAppearance = appearance95;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.SelectedCellAppearance = appearance96;
            appearance97.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance97.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.SelectedRowAppearance = appearance97;
            appearance98.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance98.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeContrato.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance98;
            this.ultraDropDownTiposDeContrato.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeContrato.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeContrato.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeContrato.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeContrato.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTiposDeContrato.Location = new System.Drawing.Point(500, 193);
            this.ultraDropDownTiposDeContrato.Name = "ultraDropDownTiposDeContrato";
            this.ultraDropDownTiposDeContrato.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeContrato.TabIndex = 21;
            this.ultraDropDownTiposDeContrato.ValueMember = "idTipoDeContrato";
            this.ultraDropDownTiposDeContrato.Visible = false;
            this.ultraDropDownTiposDeContrato.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTiposDeContratoBeforeDropDown);
            // 
            // tiposDeContratoBindingSource
            // 
            this.tiposDeContratoBindingSource.DataMember = "TiposDeContrato";
            this.tiposDeContratoBindingSource.DataSource = this.dsTiposDeContrato;
            // 
            // dsTiposDeContrato
            // 
            this.dsTiposDeContrato.DataSetName = "DsTiposDeContrato";
            this.dsTiposDeContrato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownVendedores
            // 
            this.ultraDropDownVendedores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownVendedores.DataSource = this.vendedoresBindingSource;
            appearance79.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance79.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownVendedores.DisplayLayout.Appearance = appearance79;
            ultraGridColumn303.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn303.Header.VisiblePosition = 0;
            ultraGridColumn303.Hidden = true;
            ultraGridColumn303.Width = 30;
            ultraGridColumn304.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn304.Header.VisiblePosition = 1;
            ultraGridColumn304.Hidden = true;
            ultraGridColumn304.Width = 21;
            ultraGridColumn305.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn305.Header.VisiblePosition = 2;
            ultraGridColumn305.Hidden = true;
            ultraGridColumn305.Width = 45;
            ultraGridColumn306.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn306.Header.VisiblePosition = 3;
            ultraGridColumn306.Hidden = true;
            ultraGridColumn306.Width = 45;
            ultraGridColumn307.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn307.Header.VisiblePosition = 4;
            ultraGridColumn307.Width = 231;
            ultraGridColumn308.Header.VisiblePosition = 6;
            ultraGridColumn308.Hidden = true;
            ultraGridColumn309.Header.VisiblePosition = 5;
            ultraGridColumn309.Hidden = true;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn303,
            ultraGridColumn304,
            ultraGridColumn305,
            ultraGridColumn306,
            ultraGridColumn307,
            ultraGridColumn308,
            ultraGridColumn309});
            this.ultraDropDownVendedores.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.ultraDropDownVendedores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownVendedores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownVendedores.DisplayLayout.MaxBandDepth = 5;
            appearance80.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownVendedores.DisplayLayout.Override.ActiveCellAppearance = appearance80;
            appearance81.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance81.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance81.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownVendedores.DisplayLayout.Override.ActiveRowAppearance = appearance81;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance82.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownVendedores.DisplayLayout.Override.CardAreaAppearance = appearance82;
            appearance83.BackColor = System.Drawing.SystemColors.Control;
            appearance83.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownVendedores.DisplayLayout.Override.CellAppearance = appearance83;
            this.ultraDropDownVendedores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance84.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance84.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance84.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance84.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownVendedores.DisplayLayout.Override.HeaderAppearance = appearance84;
            this.ultraDropDownVendedores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance85.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownVendedores.DisplayLayout.Override.RowSelectorAppearance = appearance85;
            this.ultraDropDownVendedores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownVendedores.DisplayLayout.Override.SelectedCellAppearance = appearance86;
            appearance87.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance87.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownVendedores.DisplayLayout.Override.SelectedRowAppearance = appearance87;
            appearance88.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance88.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownVendedores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance88;
            this.ultraDropDownVendedores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownVendedores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownVendedores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownVendedores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownVendedores.DisplayMember = "ApelNomb";
            this.ultraDropDownVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownVendedores.Location = new System.Drawing.Point(502, 313);
            this.ultraDropDownVendedores.Name = "ultraDropDownVendedores";
            this.ultraDropDownVendedores.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownVendedores.TabIndex = 22;
            this.ultraDropDownVendedores.ValueMember = "idEmpleado";
            this.ultraDropDownVendedores.Visible = false;
            this.ultraDropDownVendedores.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownVendedoresBeforeDropDown);
            this.ultraDropDownVendedores.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownVendedoresFilterRow);
            // 
            // vendedoresBindingSource
            // 
            this.vendedoresBindingSource.DataMember = "EmpleadosLista";
            this.vendedoresBindingSource.DataSource = this.dsVendedores;
            // 
            // dsVendedores
            // 
            this.dsVendedores.DataSetName = "DsEmpleadosLista";
            this.dsVendedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTomadoresDeBaja
            // 
            this.ultraDropDownTomadoresDeBaja.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTomadoresDeBaja.DataSource = this.tomadoresDeBajaBindingSource;
            appearance69.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance69.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Appearance = appearance69;
            ultraGridColumn296.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn296.Header.VisiblePosition = 0;
            ultraGridColumn296.Hidden = true;
            ultraGridColumn296.Width = 30;
            ultraGridColumn297.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn297.Header.VisiblePosition = 1;
            ultraGridColumn297.Hidden = true;
            ultraGridColumn297.Width = 21;
            ultraGridColumn298.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn298.Header.VisiblePosition = 2;
            ultraGridColumn298.Hidden = true;
            ultraGridColumn298.Width = 45;
            ultraGridColumn299.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn299.Header.VisiblePosition = 3;
            ultraGridColumn299.Hidden = true;
            ultraGridColumn299.Width = 45;
            ultraGridColumn300.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn300.Header.VisiblePosition = 4;
            ultraGridColumn300.Width = 231;
            ultraGridColumn301.Header.VisiblePosition = 6;
            ultraGridColumn301.Hidden = true;
            ultraGridColumn302.Header.VisiblePosition = 5;
            ultraGridColumn302.Hidden = true;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn296,
            ultraGridColumn297,
            ultraGridColumn298,
            ultraGridColumn299,
            ultraGridColumn300,
            ultraGridColumn301,
            ultraGridColumn302});
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.MaxBandDepth = 5;
            appearance70.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.ActiveCellAppearance = appearance70;
            appearance71.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance71.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance71.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.ActiveRowAppearance = appearance71;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance72.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.CardAreaAppearance = appearance72;
            appearance73.BackColor = System.Drawing.SystemColors.Control;
            appearance73.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.CellAppearance = appearance73;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.EntireColumn;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance74.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance74.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance74.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance74.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.HeaderAppearance = appearance74;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance75.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.RowSelectorAppearance = appearance75;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.SelectedCellAppearance = appearance76;
            appearance77.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance77.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.SelectedRowAppearance = appearance77;
            appearance78.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance78.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance78;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTomadoresDeBaja.DisplayMember = "ApelNomb";
            this.ultraDropDownTomadoresDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTomadoresDeBaja.Location = new System.Drawing.Point(12, 313);
            this.ultraDropDownTomadoresDeBaja.Name = "ultraDropDownTomadoresDeBaja";
            this.ultraDropDownTomadoresDeBaja.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTomadoresDeBaja.TabIndex = 23;
            this.ultraDropDownTomadoresDeBaja.ValueMember = "idEmpleado";
            this.ultraDropDownTomadoresDeBaja.Visible = false;
            this.ultraDropDownTomadoresDeBaja.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTomadoresDeBajaBeforeDropDown);
            this.ultraDropDownTomadoresDeBaja.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownTomadoresDeBajaFilterRow);
            // 
            // tomadoresDeBajaBindingSource
            // 
            this.tomadoresDeBajaBindingSource.DataMember = "EmpleadosLista";
            this.tomadoresDeBajaBindingSource.DataSource = this.dsTomadoresDeBaja;
            // 
            // dsTomadoresDeBaja
            // 
            this.dsTomadoresDeBaja.DataSetName = "DsEmpleadosLista";
            this.dsTomadoresDeBaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMotivosDeBaja
            // 
            this.ultraDropDownMotivosDeBaja.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMotivosDeBaja.DataSource = this.motivosDeBajaBindingSource;
            appearance61.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance61.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Appearance = appearance61;
            ultraGridBand13.ColHeadersVisible = false;
            ultraGridColumn294.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn294.Header.VisiblePosition = 0;
            ultraGridColumn294.Hidden = true;
            ultraGridColumn295.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn295.Header.VisiblePosition = 1;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn294,
            ultraGridColumn295});
            ultraGridBand13.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand13.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.ultraDropDownMotivosDeBaja.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.MaxBandDepth = 5;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance62.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.CardAreaAppearance = appearance62;
            appearance63.BackColor = System.Drawing.SystemColors.Control;
            appearance63.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.CellAppearance = appearance63;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance64.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance64.BackColor2 = System.Drawing.SystemColors.Control;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance64.FontData.BoldAsString = "False";
            appearance64.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.HeaderAppearance = appearance64;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance65.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.RowSelectorAppearance = appearance65;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.SelectedCellAppearance = appearance66;
            appearance67.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance67.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.SelectedRowAppearance = appearance67;
            appearance68.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance68.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance68;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotivosDeBaja.DisplayMember = "Nombre";
            this.ultraDropDownMotivosDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotivosDeBaja.Location = new System.Drawing.Point(12, 353);
            this.ultraDropDownMotivosDeBaja.Name = "ultraDropDownMotivosDeBaja";
            this.ultraDropDownMotivosDeBaja.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownMotivosDeBaja.TabIndex = 24;
            this.ultraDropDownMotivosDeBaja.ValueMember = "idMotivoDeBaja";
            this.ultraDropDownMotivosDeBaja.Visible = false;
            this.ultraDropDownMotivosDeBaja.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotivosDeBajaBeforeDropDown);
            // 
            // motivosDeBajaBindingSource
            // 
            this.motivosDeBajaBindingSource.DataMember = "MotivosDeBaja";
            this.motivosDeBajaBindingSource.DataSource = this.dsMotivosDeBaja;
            // 
            // dsMotivosDeBaja
            // 
            this.dsMotivosDeBaja.DataSetName = "DsMotivosDeBaja";
            this.dsMotivosDeBaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCodigos
            // 
            this.ultraDropDownCodigos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCodigos.DataSource = this.codigosBindingSource;
            appearance51.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCodigos.DisplayLayout.Appearance = appearance51;
            ultraGridBand12.ColHeadersVisible = false;
            ultraGridColumn289.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn289.Header.VisiblePosition = 0;
            ultraGridColumn289.Hidden = true;
            ultraGridColumn290.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn290.Header.VisiblePosition = 1;
            ultraGridColumn291.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn291.Header.VisiblePosition = 2;
            ultraGridColumn291.Hidden = true;
            ultraGridColumn292.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn292.Header.VisiblePosition = 3;
            ultraGridColumn292.Hidden = true;
            ultraGridColumn293.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn293.Header.VisiblePosition = 4;
            ultraGridColumn293.Hidden = true;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn289,
            ultraGridColumn290,
            ultraGridColumn291,
            ultraGridColumn292,
            ultraGridColumn293});
            ultraGridBand12.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand12.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCodigos.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraDropDownCodigos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCodigos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCodigos.DisplayLayout.MaxBandDepth = 5;
            appearance52.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCodigos.DisplayLayout.Override.ActiveCellAppearance = appearance52;
            appearance53.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance53.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance53.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCodigos.DisplayLayout.Override.ActiveRowAppearance = appearance53;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance54.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCodigos.DisplayLayout.Override.CardAreaAppearance = appearance54;
            appearance55.BackColor = System.Drawing.SystemColors.Control;
            appearance55.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCodigos.DisplayLayout.Override.CellAppearance = appearance55;
            this.ultraDropDownCodigos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance56.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance56.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance56.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance56.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCodigos.DisplayLayout.Override.HeaderAppearance = appearance56;
            this.ultraDropDownCodigos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance57.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCodigos.DisplayLayout.Override.RowSelectorAppearance = appearance57;
            this.ultraDropDownCodigos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCodigos.DisplayLayout.Override.SelectedCellAppearance = appearance58;
            appearance59.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance59.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCodigos.DisplayLayout.Override.SelectedRowAppearance = appearance59;
            appearance60.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance60.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCodigos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance60;
            this.ultraDropDownCodigos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCodigos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCodigos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCodigos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCodigos.DisplayMember = "Nombre";
            this.ultraDropDownCodigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCodigos.Location = new System.Drawing.Point(256, 193);
            this.ultraDropDownCodigos.Name = "ultraDropDownCodigos";
            this.ultraDropDownCodigos.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCodigos.TabIndex = 25;
            this.ultraDropDownCodigos.ValueMember = "idCodigo";
            this.ultraDropDownCodigos.Visible = false;
            this.ultraDropDownCodigos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCodigosBeforeDropDown);
            // 
            // codigosBindingSource
            // 
            this.codigosBindingSource.DataMember = "Codigos";
            this.codigosBindingSource.DataSource = this.dsCodigos;
            // 
            // dsCodigos
            // 
            this.dsCodigos.DataSetName = "DsCodigos";
            this.dsCodigos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCategoriasIVA
            // 
            this.ultraDropDownCategoriasIVA.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCategoriasIVA.DataSource = this.categoriasIVABindingSource;
            appearance179.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance179.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Appearance = appearance179;
            ultraGridBand11.ColHeadersVisible = false;
            ultraGridColumn282.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn282.Header.VisiblePosition = 0;
            ultraGridColumn282.Hidden = true;
            ultraGridColumn283.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn283.Header.VisiblePosition = 1;
            ultraGridColumn284.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn284.Header.VisiblePosition = 2;
            ultraGridColumn284.Hidden = true;
            ultraGridColumn285.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn285.Header.VisiblePosition = 3;
            ultraGridColumn285.Hidden = true;
            ultraGridColumn286.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn286.Header.VisiblePosition = 4;
            ultraGridColumn286.Hidden = true;
            ultraGridColumn287.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn287.Header.VisiblePosition = 5;
            ultraGridColumn287.Hidden = true;
            ultraGridColumn288.Header.VisiblePosition = 6;
            ultraGridColumn288.Hidden = true;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn282,
            ultraGridColumn283,
            ultraGridColumn284,
            ultraGridColumn285,
            ultraGridColumn286,
            ultraGridColumn287,
            ultraGridColumn288});
            ultraGridBand11.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand11.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCategoriasIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraDropDownCategoriasIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCategoriasIVA.DisplayLayout.MaxBandDepth = 5;
            appearance180.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveCellAppearance = appearance180;
            appearance181.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance181.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance181.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance181.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveRowAppearance = appearance181;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance182.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CardAreaAppearance = appearance182;
            appearance183.BackColor = System.Drawing.SystemColors.Control;
            appearance183.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance183.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CellAppearance = appearance183;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance184.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance184.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance184.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance184.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance184.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderAppearance = appearance184;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance187.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSelectorAppearance = appearance187;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance194.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedCellAppearance = appearance194;
            appearance217.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance217.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance217.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedRowAppearance = appearance217;
            appearance229.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance229.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance229;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCategoriasIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCategoriasIVA.DisplayMember = "Nombre";
            this.ultraDropDownCategoriasIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCategoriasIVA.Location = new System.Drawing.Point(256, 273);
            this.ultraDropDownCategoriasIVA.Name = "ultraDropDownCategoriasIVA";
            this.ultraDropDownCategoriasIVA.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCategoriasIVA.TabIndex = 26;
            this.ultraDropDownCategoriasIVA.ValueMember = "idCategoriaIVA";
            this.ultraDropDownCategoriasIVA.Visible = false;
            this.ultraDropDownCategoriasIVA.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCategoriasIVABeforeDropDown);
            // 
            // ultraDropDownBarrios
            // 
            this.ultraDropDownBarrios.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownBarrios.DataSource = this.barriosBindingSource;
            appearance176.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance176.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance176.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrios.DisplayLayout.Appearance = appearance176;
            ultraGridBand10.ColHeadersVisible = false;
            ultraGridColumn279.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn279.Header.VisiblePosition = 0;
            ultraGridColumn279.Hidden = true;
            ultraGridColumn280.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn280.Header.VisiblePosition = 2;
            ultraGridColumn281.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn281.Header.VisiblePosition = 1;
            ultraGridColumn281.Hidden = true;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn279,
            ultraGridColumn280,
            ultraGridColumn281});
            ultraGridBand10.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand10.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownBarrios.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraDropDownBarrios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBarrios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBarrios.DisplayLayout.MaxBandDepth = 5;
            appearance177.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveCellAppearance = appearance177;
            appearance178.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance178.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance178.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance178.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveRowAppearance = appearance178;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance34.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.CardAreaAppearance = appearance34;
            appearance35.BackColor = System.Drawing.SystemColors.Control;
            appearance35.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.CellAppearance = appearance35;
            this.ultraDropDownBarrios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance36.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance36.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance36.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderAppearance = appearance36;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance37.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSelectorAppearance = appearance37;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedCellAppearance = appearance38;
            appearance39.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance39.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedRowAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBarrios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance40;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBarrios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBarrios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBarrios.DisplayMember = "Nombre";
            this.ultraDropDownBarrios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownBarrios.Location = new System.Drawing.Point(12, 193);
            this.ultraDropDownBarrios.Name = "ultraDropDownBarrios";
            this.ultraDropDownBarrios.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownBarrios.TabIndex = 27;
            this.ultraDropDownBarrios.ValueMember = "idBarrio";
            this.ultraDropDownBarrios.Visible = false;
            this.ultraDropDownBarrios.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownBarriosBeforeDropDown);
            this.ultraDropDownBarrios.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownBarriosFilterRow);
            // 
            // barriosBindingSource
            // 
            this.barriosBindingSource.DataSource = this.dsBarrios1;
            this.barriosBindingSource.Position = 0;
            // 
            // dsBarrios1
            // 
            this.dsBarrios1.DataSetName = "DsBarrios";
            this.dsBarrios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownContratos
            // 
            this.ultraDropDownContratos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownContratos.DataSource = this.contratosRenglonFacturaBindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownContratos.DisplayLayout.Appearance = appearance21;
            ultraGridBand9.ColHeadersVisible = false;
            ultraGridColumn236.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn236.Header.VisiblePosition = 0;
            ultraGridColumn236.Hidden = true;
            ultraGridColumn237.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn237.Header.VisiblePosition = 1;
            ultraGridColumn238.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn238.Header.VisiblePosition = 2;
            ultraGridColumn238.Hidden = true;
            ultraGridColumn239.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn239.Header.VisiblePosition = 3;
            ultraGridColumn239.Hidden = true;
            ultraGridColumn240.Header.VisiblePosition = 4;
            ultraGridColumn240.Hidden = true;
            ultraGridColumn241.Header.VisiblePosition = 5;
            ultraGridColumn241.Hidden = true;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn236,
            ultraGridColumn237,
            ultraGridColumn238,
            ultraGridColumn239,
            ultraGridColumn240,
            ultraGridColumn241});
            this.ultraDropDownContratos.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraDropDownContratos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownContratos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownContratos.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownContratos.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownContratos.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance159.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownContratos.DisplayLayout.Override.CardAreaAppearance = appearance159;
            appearance170.BackColor = System.Drawing.SystemColors.Control;
            appearance170.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance170.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownContratos.DisplayLayout.Override.CellAppearance = appearance170;
            this.ultraDropDownContratos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance171.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance171.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance171.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance171.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance171.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownContratos.DisplayLayout.Override.HeaderAppearance = appearance171;
            this.ultraDropDownContratos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance172.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownContratos.DisplayLayout.Override.RowSelectorAppearance = appearance172;
            this.ultraDropDownContratos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance173.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownContratos.DisplayLayout.Override.SelectedCellAppearance = appearance173;
            appearance174.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance174.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance174.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownContratos.DisplayLayout.Override.SelectedRowAppearance = appearance174;
            appearance175.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance175.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownContratos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance175;
            this.ultraDropDownContratos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownContratos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownContratos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownContratos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownContratos.DisplayMember = "Nombre";
            this.ultraDropDownContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownContratos.Location = new System.Drawing.Point(502, 353);
            this.ultraDropDownContratos.Name = "ultraDropDownContratos";
            this.ultraDropDownContratos.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownContratos.TabIndex = 28;
            this.ultraDropDownContratos.ValueMember = "idContrato";
            this.ultraDropDownContratos.Visible = false;
            this.ultraDropDownContratos.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.UltraDropDownContratosInitializeRow);
            this.ultraDropDownContratos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownContratosBeforeDropDown);
            this.ultraDropDownContratos.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownContratosRowSelected);
            // 
            // contratosRenglonFacturaBindingSource
            // 
            this.contratosRenglonFacturaBindingSource.DataMember = "ContratosRenglonFactura";
            this.contratosRenglonFacturaBindingSource.DataSource = this.dsContratosLista;
            // 
            // dsContratosLista
            // 
            this.dsContratosLista.DataSetName = "DsContratosLista";
            this.dsContratosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTandasDeFacturacion
            // 
            this.ultraDropDownTandasDeFacturacion.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTandasDeFacturacion.DataSource = this.tandasDeFacturacionBindingSource;
            appearance160.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance160.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance160.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Appearance = appearance160;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn276.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn276.Header.VisiblePosition = 0;
            ultraGridColumn276.Hidden = true;
            ultraGridColumn277.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn277.Header.VisiblePosition = 1;
            ultraGridColumn277.Width = 231;
            ultraGridColumn278.Header.VisiblePosition = 2;
            ultraGridColumn278.Hidden = true;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn276,
            ultraGridColumn277,
            ultraGridColumn278});
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.MaxBandDepth = 5;
            appearance161.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.ActiveCellAppearance = appearance161;
            appearance162.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance162.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance162.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance162.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.ActiveRowAppearance = appearance162;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance163.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.CardAreaAppearance = appearance163;
            appearance164.BackColor = System.Drawing.SystemColors.Control;
            appearance164.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance164.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.CellAppearance = appearance164;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance165.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance165.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance165.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance165.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance165.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.HeaderAppearance = appearance165;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance166.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.RowSelectorAppearance = appearance166;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance167.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.SelectedCellAppearance = appearance167;
            appearance168.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance168.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance168.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.SelectedRowAppearance = appearance168;
            appearance169.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance169.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance169;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTandasDeFacturacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTandasDeFacturacion.DisplayMember = "Nombre";
            this.ultraDropDownTandasDeFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTandasDeFacturacion.Location = new System.Drawing.Point(12, 393);
            this.ultraDropDownTandasDeFacturacion.Name = "ultraDropDownTandasDeFacturacion";
            this.ultraDropDownTandasDeFacturacion.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTandasDeFacturacion.TabIndex = 29;
            this.ultraDropDownTandasDeFacturacion.ValueMember = "idTandaDeFacturacion";
            this.ultraDropDownTandasDeFacturacion.Visible = false;
            this.ultraDropDownTandasDeFacturacion.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTandasDeFacturacionBeforeDropDown);
            // 
            // tandasDeFacturacionBindingSource
            // 
            this.tandasDeFacturacionBindingSource.DataMember = "TandasDeFacturacion";
            this.tandasDeFacturacionBindingSource.DataSource = this.dsTandasDeFacturacion;
            // 
            // dsTandasDeFacturacion
            // 
            this.dsTandasDeFacturacion.DataSetName = "DsTandasDeFacturacion";
            this.dsTandasDeFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSistemas1
            // 
            this.dsSistemas1.DataSetName = "DsSistemas";
            this.dsSistemas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownLocalidad
            // 
            this.ultraDropDownLocalidad.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownLocalidad.DataSource = this.localidadesListaBindingSource;
            appearance139.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance139.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance139.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidad.DisplayLayout.Appearance = appearance139;
            ultraGridBand21.ColHeadersVisible = false;
            ultraGridColumn342.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn342.Header.VisiblePosition = 0;
            ultraGridColumn342.Hidden = true;
            ultraGridColumn343.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn343.Header.VisiblePosition = 1;
            ultraGridColumn344.Header.VisiblePosition = 2;
            ultraGridColumn344.Hidden = true;
            ultraGridBand21.Columns.AddRange(new object[] {
            ultraGridColumn342,
            ultraGridColumn343,
            ultraGridColumn344});
            ultraGridBand21.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand21.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownLocalidad.DisplayLayout.BandsSerializer.Add(ultraGridBand21);
            this.ultraDropDownLocalidad.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidad.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidad.DisplayLayout.MaxBandDepth = 5;
            appearance140.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveCellAppearance = appearance140;
            appearance141.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance141.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance141.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance141.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveRowAppearance = appearance141;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance142.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CardAreaAppearance = appearance142;
            appearance143.BackColor = System.Drawing.SystemColors.Control;
            appearance143.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance143.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CellAppearance = appearance143;
            this.ultraDropDownLocalidad.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance144.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance144.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance144.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance144.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance144.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderAppearance = appearance144;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance145.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSelectorAppearance = appearance145;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance146.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedCellAppearance = appearance146;
            appearance147.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance147.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance147.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedRowAppearance = appearance147;
            appearance148.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance148.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidad.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance148;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidad.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidad.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidad.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownLocalidad.Location = new System.Drawing.Point(258, 313);
            this.ultraDropDownLocalidad.Name = "ultraDropDownLocalidad";
            this.ultraDropDownLocalidad.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownLocalidad.TabIndex = 11;
            this.ultraDropDownLocalidad.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidad.Visible = false;
            this.ultraDropDownLocalidad.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownLocalidadBeforeDropDown);
            this.ultraDropDownLocalidad.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownLocalidadRowSelected);
            // 
            // localidadesListaBindingSource
            // 
            this.localidadesListaBindingSource.DataMember = "LocalidadesLista";
            this.localidadesListaBindingSource.DataSource = this.dsLocalidadesLista;
            // 
            // dsLocalidadesLista
            // 
            this.dsLocalidadesLista.DataSetName = "DsLocalidadesLista";
            this.dsLocalidadesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dscuitRepetibles1
            // 
            this.dscuitRepetibles1.DataSetName = "DsCUITRepetibles";
            this.dscuitRepetibles1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPlanes1
            // 
            this.dsPlanes1.DataSetName = "DsPlanes";
            this.dsPlanes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPlanes
            // 
            this.ultraDropDownPlanes.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPlanes.DataSource = this.planesDelClientebindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPlanes.DisplayLayout.Appearance = appearance1;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn271.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn271.Header.VisiblePosition = 0;
            ultraGridColumn271.Hidden = true;
            ultraGridColumn271.Width = 48;
            ultraGridColumn272.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn272.Header.VisiblePosition = 1;
            ultraGridColumn272.Width = 231;
            ultraGridColumn273.Header.VisiblePosition = 2;
            ultraGridColumn273.Hidden = true;
            ultraGridColumn274.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn274.Header.VisiblePosition = 3;
            ultraGridColumn274.Hidden = true;
            ultraGridColumn274.Width = 58;
            ultraGridColumn275.Header.VisiblePosition = 4;
            ultraGridColumn275.Hidden = true;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn271,
            ultraGridColumn272,
            ultraGridColumn273,
            ultraGridColumn274,
            ultraGridColumn275});
            this.ultraDropDownPlanes.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraDropDownPlanes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPlanes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPlanes.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraDropDownPlanes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPlanes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPlanes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPlanes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPlanes.DisplayMember = "Nombre";
            this.ultraDropDownPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPlanes.Location = new System.Drawing.Point(12, 233);
            this.ultraDropDownPlanes.Name = "ultraDropDownPlanes";
            this.ultraDropDownPlanes.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownPlanes.TabIndex = 30;
            this.ultraDropDownPlanes.ValueMember = "idPlan";
            this.ultraDropDownPlanes.Visible = false;
            this.ultraDropDownPlanes.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownPlanesBeforeDropDown);
            this.ultraDropDownPlanes.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownPlanesFilterRow);
            // 
            // planesDelClientebindingSource
            // 
            this.planesDelClientebindingSource.DataMember = "PlanesDelCliente";
            this.planesDelClientebindingSource.DataSource = this.dsContratosLista;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "Planes";
            this.planesBindingSource.DataSource = this.dsPlanes1;
            // 
            // dsProtecciones
            // 
            this.dsProtecciones.DataSetName = "DsProtecciones";
            this.dsProtecciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proteccionesBindingSource
            // 
            this.proteccionesBindingSource.DataMember = "Protecciones";
            this.proteccionesBindingSource.DataSource = this.dsProtecciones;
            // 
            // ultraDropDownProtecciones
            // 
            this.ultraDropDownProtecciones.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownProtecciones.DataSource = this.proteccionesBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownProtecciones.DisplayLayout.Appearance = appearance11;
            this.ultraDropDownProtecciones.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn266.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn266.Header.VisiblePosition = 0;
            ultraGridColumn266.Hidden = true;
            ultraGridColumn267.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn267.Header.VisiblePosition = 1;
            ultraGridColumn268.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn268.Header.VisiblePosition = 2;
            ultraGridColumn268.Hidden = true;
            ultraGridColumn269.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn269.Header.VisiblePosition = 3;
            ultraGridColumn269.Hidden = true;
            ultraGridColumn270.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn270.Header.VisiblePosition = 4;
            ultraGridColumn270.Hidden = true;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn266,
            ultraGridColumn267,
            ultraGridColumn268,
            ultraGridColumn269,
            ultraGridColumn270});
            ultraGridBand6.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownProtecciones.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownProtecciones.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownProtecciones.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownProtecciones.DisplayLayout.MaxBandDepth = 5;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownProtecciones.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance13.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownProtecciones.DisplayLayout.Override.ActiveRowAppearance = appearance13;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownProtecciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownProtecciones.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownProtecciones.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraDropDownProtecciones.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance16.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownProtecciones.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraDropDownProtecciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownProtecciones.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraDropDownProtecciones.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownProtecciones.DisplayLayout.Override.SelectedCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownProtecciones.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownProtecciones.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance20;
            this.ultraDropDownProtecciones.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownProtecciones.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownProtecciones.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownProtecciones.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownProtecciones.DisplayMember = "Nombre";
            this.ultraDropDownProtecciones.DropDownWidth = 0;
            this.ultraDropDownProtecciones.Location = new System.Drawing.Point(256, 393);
            this.ultraDropDownProtecciones.Name = "ultraDropDownProtecciones";
            this.ultraDropDownProtecciones.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownProtecciones.TabIndex = 31;
            this.ultraDropDownProtecciones.ValueMember = "idProteccion";
            this.ultraDropDownProtecciones.Visible = false;
            // 
            // ultraDropDownGrabador
            // 
            this.ultraDropDownGrabador.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownGrabador.DataSource = this.usuariosListaBindingSource;
            appearance207.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance207.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance207.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownGrabador.DisplayLayout.Appearance = appearance207;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn260.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn260.Header.VisiblePosition = 0;
            ultraGridColumn260.Hidden = true;
            ultraGridColumn261.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn261.Header.VisiblePosition = 1;
            ultraGridColumn261.Hidden = true;
            ultraGridColumn262.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn262.Header.VisiblePosition = 2;
            ultraGridColumn263.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn263.Header.VisiblePosition = 3;
            ultraGridColumn263.Hidden = true;
            ultraGridColumn264.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn264.Header.VisiblePosition = 4;
            ultraGridColumn264.Hidden = true;
            ultraGridColumn265.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn265.Header.VisiblePosition = 5;
            ultraGridColumn265.Hidden = true;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn260,
            ultraGridColumn261,
            ultraGridColumn262,
            ultraGridColumn263,
            ultraGridColumn264,
            ultraGridColumn265});
            this.ultraDropDownGrabador.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownGrabador.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownGrabador.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownGrabador.DisplayLayout.MaxBandDepth = 5;
            appearance208.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveCellAppearance = appearance208;
            appearance209.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance209.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance209.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance209.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveRowAppearance = appearance209;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance210.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.CardAreaAppearance = appearance210;
            appearance211.BackColor = System.Drawing.SystemColors.Control;
            appearance211.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance211.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.CellAppearance = appearance211;
            this.ultraDropDownGrabador.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance212.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance212.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance212.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance212.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance212.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderAppearance = appearance212;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance213.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSelectorAppearance = appearance213;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance214.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedCellAppearance = appearance214;
            appearance215.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance215.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance215.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedRowAppearance = appearance215;
            appearance216.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance216.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownGrabador.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance216;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownGrabador.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownGrabador.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownGrabador.DisplayMember = "NombApel";
            this.ultraDropDownGrabador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownGrabador.Location = new System.Drawing.Point(500, 393);
            this.ultraDropDownGrabador.Name = "ultraDropDownGrabador";
            this.ultraDropDownGrabador.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownGrabador.TabIndex = 55;
            this.ultraDropDownGrabador.ValueMember = "idUsuario";
            this.ultraDropDownGrabador.Visible = false;
            // 
            // usuariosListaBindingSource
            // 
            this.usuariosListaBindingSource.DataMember = "UsuariosLista";
            this.usuariosListaBindingSource.DataSource = this.dsUsuariosLista1;
            // 
            // dsUsuariosLista1
            // 
            this.dsUsuariosLista1.DataSetName = "DsUsuariosLista";
            this.dsUsuariosLista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPrepagos
            // 
            this.dsPrepagos.DataSetName = "DsPrepagos";
            this.dsPrepagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prepagosBindingSource
            // 
            this.prepagosBindingSource.DataMember = "Prepagos";
            this.prepagosBindingSource.DataSource = this.dsPrepagos;
            // 
            // ultraDropDownPrepagos
            // 
            this.ultraDropDownPrepagos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPrepagos.DataSource = this.prepagosBindingSource;
            appearance218.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance218.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance218.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrepagos.DisplayLayout.Appearance = appearance218;
            this.ultraDropDownPrepagos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn257.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn257.Header.VisiblePosition = 0;
            ultraGridColumn257.Hidden = true;
            ultraGridColumn257.Width = 57;
            ultraGridColumn258.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn258.Header.VisiblePosition = 1;
            ultraGridColumn258.Width = 231;
            ultraGridColumn259.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn259.Header.VisiblePosition = 2;
            ultraGridColumn259.Hidden = true;
            ultraGridColumn259.Width = 87;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn257,
            ultraGridColumn258,
            ultraGridColumn259});
            this.ultraDropDownPrepagos.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownPrepagos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrepagos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrepagos.DisplayLayout.MaxBandDepth = 5;
            appearance219.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveCellAppearance = appearance219;
            appearance220.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance220.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance220.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance220.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveRowAppearance = appearance220;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance221.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CardAreaAppearance = appearance221;
            appearance222.BackColor = System.Drawing.SystemColors.Control;
            appearance222.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance222.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CellAppearance = appearance222;
            this.ultraDropDownPrepagos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance223.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance223.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance223.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance223.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance223.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderAppearance = appearance223;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance224.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSelectorAppearance = appearance224;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance225.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedCellAppearance = appearance225;
            appearance226.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance226.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance226.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedRowAppearance = appearance226;
            appearance227.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance227.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrepagos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance227;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrepagos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrepagos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrepagos.DisplayMember = "Nombre";
            this.ultraDropDownPrepagos.DropDownWidth = 250;
            this.ultraDropDownPrepagos.Location = new System.Drawing.Point(12, 433);
            this.ultraDropDownPrepagos.Name = "ultraDropDownPrepagos";
            this.ultraDropDownPrepagos.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPrepagos.TabIndex = 56;
            this.ultraDropDownPrepagos.ValueMember = "idPrepago";
            this.ultraDropDownPrepagos.Visible = false;
            // 
            // ultraDataSourceFacturarMes
            // 
            ultraDataColumn1.DataType = typeof(int);
            this.ultraDataSourceFacturarMes.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            this.ultraDataSourceFacturarMes.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Valor")),
                        ((object)(-1)),
                        ((object)("Texto")),
                        ((object)("Vencido"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Valor")),
                        ((object)(0)),
                        ((object)("Texto")),
                        ((object)("Actual"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Valor")),
                        ((object)(1)),
                        ((object)("Texto")),
                        ((object)("Siguiente"))})});
            // 
            // ultraDropDownFacturarMes
            // 
            this.ultraDropDownFacturarMes.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownFacturarMes.DataSource = this.ultraDataSourceFacturarMes;
            appearance245.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance245.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance245.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownFacturarMes.DisplayLayout.Appearance = appearance245;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn255.Header.VisiblePosition = 0;
            ultraGridColumn255.Hidden = true;
            ultraGridColumn256.Header.VisiblePosition = 1;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn255,
            ultraGridColumn256});
            this.ultraDropDownFacturarMes.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownFacturarMes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownFacturarMes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownFacturarMes.DisplayLayout.MaxBandDepth = 5;
            appearance246.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.ActiveCellAppearance = appearance246;
            appearance247.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance247.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance247.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance247.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.ActiveRowAppearance = appearance247;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance248.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.CardAreaAppearance = appearance248;
            appearance249.BackColor = System.Drawing.SystemColors.Control;
            appearance249.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance249.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.CellAppearance = appearance249;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance250.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance250.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance250.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance250.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance250.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.HeaderAppearance = appearance250;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance251.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.RowSelectorAppearance = appearance251;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance252.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.SelectedCellAppearance = appearance252;
            appearance253.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance253.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance253.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.SelectedRowAppearance = appearance253;
            appearance254.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance254.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownFacturarMes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance254;
            this.ultraDropDownFacturarMes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownFacturarMes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownFacturarMes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownFacturarMes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownFacturarMes.DisplayMember = "Texto";
            this.ultraDropDownFacturarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownFacturarMes.Location = new System.Drawing.Point(500, 431);
            this.ultraDropDownFacturarMes.Name = "ultraDropDownFacturarMes";
            this.ultraDropDownFacturarMes.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownFacturarMes.TabIndex = 57;
            this.ultraDropDownFacturarMes.ValueMember = "Valor";
            this.ultraDropDownFacturarMes.Visible = false;
            this.ultraDropDownFacturarMes.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownFacturarMes_BeforeDropDown);
            // 
            // dsNegocios
            // 
            this.dsNegocios.DataSetName = "DsNegocios";
            this.dsNegocios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // negociosBindingSource
            // 
            this.negociosBindingSource.DataMember = "Negocios";
            this.negociosBindingSource.DataSource = this.dsNegocios;
            // 
            // ultraDropDownNegocios
            // 
            this.ultraDropDownNegocios.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownNegocios.DataSource = this.negociosBindingSource;
            appearance24.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownNegocios.DisplayLayout.Appearance = appearance24;
            this.ultraDropDownNegocios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn251.Header.VisiblePosition = 0;
            ultraGridColumn251.Hidden = true;
            ultraGridColumn252.Header.VisiblePosition = 1;
            ultraGridColumn252.Hidden = true;
            ultraGridColumn253.Header.VisiblePosition = 2;
            ultraGridColumn254.Header.VisiblePosition = 3;
            ultraGridColumn254.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn251,
            ultraGridColumn252,
            ultraGridColumn253,
            ultraGridColumn254});
            ultraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownNegocios.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownNegocios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownNegocios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownNegocios.DisplayLayout.MaxBandDepth = 5;
            appearance25.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveCellAppearance = appearance25;
            appearance26.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance26.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveRowAppearance = appearance26;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance27.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.CardAreaAppearance = appearance27;
            appearance28.BackColor = System.Drawing.SystemColors.Control;
            appearance28.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.CellAppearance = appearance28;
            this.ultraDropDownNegocios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance29.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance29.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderAppearance = appearance29;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance30.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSelectorAppearance = appearance30;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedCellAppearance = appearance31;
            appearance32.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance32.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedRowAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownNegocios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance33;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownNegocios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownNegocios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownNegocios.DisplayMember = "Nombre";
            this.ultraDropDownNegocios.DropDownWidth = 0;
            this.ultraDropDownNegocios.Location = new System.Drawing.Point(258, 433);
            this.ultraDropDownNegocios.Name = "ultraDropDownNegocios";
            this.ultraDropDownNegocios.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownNegocios.TabIndex = 58;
            this.ultraDropDownNegocios.ValueMember = "idNegocio";
            this.ultraDropDownNegocios.Visible = false;
            this.ultraDropDownNegocios.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownNegocios_BeforeDropDown);
            // 
            // dsPorcentajeIVA
            // 
            this.dsPorcentajeIVA.DataSetName = "DsPorcentajeIVA";
            this.dsPorcentajeIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porcentajeIVABindingSource
            // 
            this.porcentajeIVABindingSource.DataMember = "PorcentajeIVA";
            this.porcentajeIVABindingSource.DataSource = this.dsPorcentajeIVA;
            // 
            // ultraDropDownPorcentajeIVA
            // 
            this.ultraDropDownPorcentajeIVA.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPorcentajeIVA.DataSource = this.porcentajeIVABindingSource;
            appearance124.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance124.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance124.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Appearance = appearance124;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand23.ColHeadersVisible = false;
            ultraGridColumn349.Header.VisiblePosition = 0;
            ultraGridColumn349.Hidden = true;
            ultraGridColumn349.Width = 54;
            ultraGridColumn350.Header.VisiblePosition = 1;
            ultraGridColumn350.Hidden = true;
            ultraGridColumn350.Width = 45;
            ultraGridColumn351.Header.VisiblePosition = 2;
            ultraGridColumn351.Width = 231;
            ultraGridColumn352.Header.VisiblePosition = 3;
            ultraGridColumn352.Hidden = true;
            ultraGridColumn352.Width = 27;
            ultraGridColumn353.Header.VisiblePosition = 4;
            ultraGridColumn353.Hidden = true;
            ultraGridColumn353.Width = 47;
            ultraGridBand23.Columns.AddRange(new object[] {
            ultraGridColumn349,
            ultraGridColumn350,
            ultraGridColumn351,
            ultraGridColumn352,
            ultraGridColumn353});
            this.ultraDropDownPorcentajeIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand23);
            this.ultraDropDownPorcentajeIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.MaxBandDepth = 5;
            appearance125.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveCellAppearance = appearance125;
            appearance126.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance126.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance126.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance126.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveRowAppearance = appearance126;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance127.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CardAreaAppearance = appearance127;
            appearance128.BackColor = System.Drawing.SystemColors.Control;
            appearance128.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance128.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CellAppearance = appearance128;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance129.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance129.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance129.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance129.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderAppearance = appearance129;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance130.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSelectorAppearance = appearance130;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance131.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedCellAppearance = appearance131;
            appearance132.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance132.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance132.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedRowAppearance = appearance132;
            appearance133.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance133.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance133;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPorcentajeIVA.DisplayMember = "Descripcion";
            this.ultraDropDownPorcentajeIVA.DropDownWidth = 250;
            this.ultraDropDownPorcentajeIVA.Location = new System.Drawing.Point(12, 474);
            this.ultraDropDownPorcentajeIVA.Name = "ultraDropDownPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPorcentajeIVA.TabIndex = 59;
            this.ultraDropDownPorcentajeIVA.ValueMember = "idPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Visible = false;
            // 
            // dsParametros
            // 
            this.dsParametros.DataSetName = "DsParametros";
            this.dsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsEmpresasSueldoBancoMacro
            // 
            this.dsEmpresasSueldoBancoMacro.DataSetName = "DsEmpresasSueldoBancoMacro";
            this.dsEmpresasSueldoBancoMacro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasSueldoBcoMacroBindingSource
            // 
            this.empresasSueldoBcoMacroBindingSource.DataMember = "EmpresasSueldoBcoMacro";
            this.empresasSueldoBcoMacroBindingSource.DataSource = this.dsEmpresasSueldoBancoMacro;
            // 
            // ultraDropDownEmpresasSueldoBancoMacro
            // 
            this.ultraDropDownEmpresasSueldoBancoMacro.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownEmpresasSueldoBancoMacro.DataSource = this.empresasSueldoBcoMacroBindingSource;
            appearance41.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Appearance = appearance41;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn249.Header.VisiblePosition = 0;
            ultraGridColumn249.Hidden = true;
            ultraGridColumn250.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn250.Header.VisiblePosition = 1;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn249,
            ultraGridColumn250});
            ultraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.MaxBandDepth = 5;
            appearance42.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.ActiveCellAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance43.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance43.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.ActiveRowAppearance = appearance43;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance44.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.CardAreaAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.Control;
            appearance45.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.CellAppearance = appearance45;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance46.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance46.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance46.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.HeaderAppearance = appearance46;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance47.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.RowSelectorAppearance = appearance47;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.SelectedCellAppearance = appearance48;
            appearance49.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance49.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.SelectedRowAppearance = appearance49;
            appearance50.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance50;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownEmpresasSueldoBancoMacro.DisplayMember = "Nombre";
            this.ultraDropDownEmpresasSueldoBancoMacro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownEmpresasSueldoBancoMacro.Location = new System.Drawing.Point(258, 474);
            this.ultraDropDownEmpresasSueldoBancoMacro.Name = "ultraDropDownEmpresasSueldoBancoMacro";
            this.ultraDropDownEmpresasSueldoBancoMacro.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownEmpresasSueldoBancoMacro.TabIndex = 77;
            this.ultraDropDownEmpresasSueldoBancoMacro.ValueMember = "idEmpresasSueldoBcoMacro";
            this.ultraDropDownEmpresasSueldoBancoMacro.Visible = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(900, 574);
            this.Controls.Add(this.ultraDropDownEmpresasSueldoBancoMacro);
            this.Controls.Add(this.ultraDropDownNegocios);
            this.Controls.Add(this.ultraDropDownFacturarMes);
            this.Controls.Add(this.ultraDropDownPrepagos);
            this.Controls.Add(this.ultraDropDownGrabador);
            this.Controls.Add(this.ultraDropDownProtecciones);
            this.Controls.Add(this.ultraDropDownPlanes);
            this.Controls.Add(this.ultraDropDownTandasDeFacturacion);
            this.Controls.Add(this.ultraDropDownContratos);
            this.Controls.Add(this.ultraDropDownBarrios);
            this.Controls.Add(this.ultraDropDownCategoriasIVA);
            this.Controls.Add(this.ultraDropDownCodigos);
            this.Controls.Add(this.ultraDropDownMotivosDeBaja);
            this.Controls.Add(this.ultraDropDownTomadoresDeBaja);
            this.Controls.Add(this.ultraDropDownVendedores);
            this.Controls.Add(this.ultraDropDownTiposDeContrato);
            this.Controls.Add(this.ultraDropDownEntidadesDeCobranza);
            this.Controls.Add(this.ultraDropDownTiposDeCobranza);
            this.Controls.Add(this.ultraDropDownTiposDeCliente);
            this.Controls.Add(this.ultraDropDownZonas);
            this.Controls.Add(this.ultraDropDownLocalidad);
            this.Controls.Add(this.ultraDropDownCalle);
            this.Controls.Add(this.ultraDropDownPorcentajeIVA);
            this.Controls.Add(this.clientesUltraGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(356, 193);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Activated += new System.EventHandler(this.FormClientesActivated);
            this.Load += new System.EventHandler(this.FormClientesLoad);
            this.Controls.SetChildIndex(this.clientesUltraGrid, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPorcentajeIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCalle, 0);
            this.Controls.SetChildIndex(this.ultraDropDownLocalidad, 0);
            this.Controls.SetChildIndex(this.ultraDropDownZonas, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeCliente, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeCobranza, 0);
            this.Controls.SetChildIndex(this.ultraDropDownEntidadesDeCobranza, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeContrato, 0);
            this.Controls.SetChildIndex(this.ultraDropDownVendedores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTomadoresDeBaja, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotivosDeBaja, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCodigos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCategoriasIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBarrios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownContratos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTandasDeFacturacion, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPlanes, 0);
            this.Controls.SetChildIndex(this.ultraDropDownProtecciones, 0);
            this.Controls.SetChildIndex(this.ultraDropDownGrabador, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPrepagos, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownFacturarMes, 0);
            this.Controls.SetChildIndex(this.ultraDropDownNegocios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownEmpresasSueldoBancoMacro, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEntidadesDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesDeCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeContratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadoresDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomadoresDeBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTomadoresDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosRenglonFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTandasDeFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tandasDeFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTandasDeFacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dscuitRepetibles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesDelClientebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownProtecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceFacturarMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownFacturarMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresasSueldoBancoMacro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasSueldoBcoMacroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEmpresasSueldoBancoMacro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid clientesUltraGrid;
        private System.Windows.Forms.Button buttonSalir;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private WS.DsClientes dsClientes;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCalle;
        private System.Windows.Forms.BindingSource callesBindingSource;
        private WS.DsCallesLista dsCallesLista;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownZonas;
        private System.Windows.Forms.BindingSource zonasBindingSource;
        private WS.DsZonas dsZonas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeCliente;
        private System.Windows.Forms.BindingSource categoriasIVABindingSource;
        private WS.DsCategoriasIVA dsCategoriasIVA;
        private System.Windows.Forms.BindingSource tiposDeClienteBindingSource;
        private WS.DsTiposDeCliente dsTiposDeCliente;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeCobranza;
        private System.Windows.Forms.BindingSource tiposDeCobranzaBindingSource;
        private WS.DsTiposDeCobranza dsTiposDeCobranza;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownEntidadesDeCobranza;
        private System.Windows.Forms.BindingSource entidadesDeCobranzaBindingSource;
        private WS.DsEntidadesDeCobranza dsEntidadesDeCobranza;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeContrato;
        private System.Windows.Forms.BindingSource tiposDeContratoBindingSource;
        private WS.DsTiposDeContrato dsTiposDeContrato;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownVendedores;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTomadoresDeBaja;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotivosDeBaja;
        private System.Windows.Forms.BindingSource motivosDeBajaBindingSource;
        private WS.DsMotivosDeBaja dsMotivosDeBaja;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCodigos;
        private System.Windows.Forms.BindingSource codigosBindingSource;
        private WS.DsCodigos dsCodigos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCategoriasIVA;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBarrios;
        private System.Windows.Forms.BindingSource barriosBindingSource;
        private WS.DsBarrios dsBarrios1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownContratos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTandasDeFacturacion;
        private System.Windows.Forms.BindingSource tandasDeFacturacionBindingSource;
        private WS.DsTandasDeFacturacion dsTandasDeFacturacion;
        private WS.DsSistemas dsSistemas1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLocalidad;
        private System.Windows.Forms.BindingSource localidadesListaBindingSource;
        private WS.DsLocalidadesLista dsLocalidadesLista;
        private WS.DsCUITRepetibles dscuitRepetibles1;
        private System.Windows.Forms.BindingSource vendedoresBindingSource;
        private WS.DsEmpleadosLista dsVendedores;
        private WS.DsEmpleadosLista dsTomadoresDeBaja;
        private System.Windows.Forms.BindingSource tomadoresDeBajaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPlanes;
        private WS.DsPlanes dsPlanes1;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private System.Windows.Forms.BindingSource contratosRenglonFacturaBindingSource;
        private WS.DsContratosLista dsContratosLista;
        private WS.DsProtecciones dsProtecciones;
        private System.Windows.Forms.BindingSource proteccionesBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownProtecciones;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownGrabador;
        private System.Windows.Forms.BindingSource usuariosListaBindingSource;
        private WS.DsUsuariosLista dsUsuariosLista1;
        private System.Windows.Forms.BindingSource planesDelClientebindingSource;
        private WS.DsPrepagos dsPrepagos;
        private System.Windows.Forms.BindingSource prepagosBindingSource;
        private UltraDropDown ultraDropDownPrepagos;
        private UltraDropDown ultraDropDownFacturarMes;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceFacturarMes;
        private WS.DsNegocios dsNegocios;
        private System.Windows.Forms.BindingSource negociosBindingSource;
        private UltraDropDown ultraDropDownNegocios;
        private UltraDropDown ultraDropDownPorcentajeIVA;
        private System.Windows.Forms.BindingSource porcentajeIVABindingSource;
        private WS.DsPorcentajeIVA dsPorcentajeIVA;
        private WS.DsParametros dsParametros;
        private WS.DsEmpresasSueldoBancoMacro dsEmpresasSueldoBancoMacro;
        private System.Windows.Forms.BindingSource empresasSueldoBcoMacroBindingSource;
        private UltraDropDown ultraDropDownEmpresasSueldoBancoMacro;
    }
}
