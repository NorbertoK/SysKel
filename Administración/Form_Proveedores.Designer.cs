namespace Administración
{
    partial class FormProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Proveedores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro", -1, "ultraDropDownRubros");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie", -1, "ultraDropDownSeries");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva", -1, "ultraDropDownCategoriasIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresosBrutos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_NegociosDelProveedor_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Proveedores");
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_NegociosDelProveedor_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocioDelProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio", -1, "ultraDropDownNegocios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalNegocios", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Porcentaje", 3, true, "FK_NegociosDelProveedor_Proveedores", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance("TotalNegocios");
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidades");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__idDir__4850AF91");
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__idDir__4850AF91", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Contactos");
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Rubros", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AdmiteValores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Negocios", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre");
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CategoriasIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExigeCUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Factura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeC");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("LocalidadesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance174 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance175 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance176 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance177 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance178 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance179 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance180 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance181 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance182 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance183 = new Infragistics.Win.Appearance();
            this.proveedoresUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Proveedores = new Administración.WS.DsProveedores();
            this.ultraDropDownRubros = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRubros = new Administración.WS.DsRubros();
            this.ultraDropDownNegocios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.negociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNegocios = new Administración.WS.DsNegocios();
            this.ultraDataSourceSeries = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDropDownSeries = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.localidadesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalidadesLista = new Administración.WS.DsLocalidadesLista();
            this.dsCallesLista = new Administración.WS.DsCallesLista();
            this.bindingSourceCalle = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarrios = new Administración.WS.DsBarrios();
            this.barriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCategoriasIVA = new Administración.WS.DsCategoriasIVA();
            this.categoriasIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultraDropDownBarrios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownCategoriasIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownLocalidades = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownCalle = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.dsParametros = new Administración.DsParametros();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(889, 20);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(296, 20);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(5);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 695);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1009, 62);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(781, 20);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // proveedoresUltraGrid
            // 
            this.proveedoresUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedoresUltraGrid.DataSource = this.proveedoresBindingSource;
            appearance93.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance93.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.proveedoresUltraGrid.DisplayLayout.Appearance = appearance93;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 77;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn2.DefaultCellValue = "True";
            ultraGridColumn2.Header.VisiblePosition = 6;
            ultraGridColumn2.RowLayoutColumnInfo.OriginX = 16;
            ultraGridColumn2.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(48, 0);
            ultraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(48, 0);
            ultraGridColumn2.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn2.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn2.TabIndex = 3;
            ultraGridColumn2.Width = 72;
            ultraGridColumn3.Header.Caption = "Razón Social";
            ultraGridColumn3.Header.VisiblePosition = 1;
            ultraGridColumn3.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(376, 0);
            ultraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(376, 18);
            ultraGridColumn3.RowLayoutColumnInfo.SpanX = 11;
            ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn3.TabIndex = 1;
            ultraGridColumn3.Width = 133;
            ultraGridColumn4.Header.Caption = "Nombre Fantasía";
            ultraGridColumn4.Header.VisiblePosition = 2;
            ultraGridColumn4.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(258, 0);
            ultraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(258, 18);
            ultraGridColumn4.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn4.TabIndex = 2;
            ultraGridColumn4.Width = 127;
            ultraGridColumn5.Header.VisiblePosition = 3;
            ultraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn5.MaskInput = "##-##,###,###-#";
            ultraGridColumn5.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn5.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(93, 0);
            ultraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(93, 0);
            ultraGridColumn5.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn5.TabIndex = 6;
            ultraGridColumn5.Width = 125;
            ultraGridColumn6.Header.VisiblePosition = 4;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn6.Width = 106;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn7.Header.Caption = "Rubro";
            ultraGridColumn7.Header.VisiblePosition = 5;
            ultraGridColumn7.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn7.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(270, 0);
            ultraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(270, 0);
            ultraGridColumn7.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn7.TabIndex = 8;
            ultraGridColumn7.Width = 68;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn8.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(95, 0);
            ultraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(95, 0);
            ultraGridColumn8.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn8.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn8.TabIndex = 4;
            ultraGridColumn8.Width = 120;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn9.Header.Caption = "Categoría IVA";
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn9.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(97, 0);
            ultraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(97, 0);
            ultraGridColumn9.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn9.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn9.TabIndex = 5;
            ultraGridColumn10.Header.Caption = "Ingresos Brutos";
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn10.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(91, 0);
            ultraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(91, 0);
            ultraGridColumn10.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn10.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn10.TabIndex = 7;
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn11.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(682, 0);
            ultraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(376, 0);
            ultraGridColumn11.RowLayoutColumnInfo.SpanX = 11;
            ultraGridColumn11.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn13.Header.VisiblePosition = 12;
            ultraGridColumn14.Header.VisiblePosition = 13;
            ultraGridColumn15.Header.VisiblePosition = 14;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15});
            appearance11.FontData.BoldAsString = "True";
            appearance11.FontData.SizeInPoints = 10F;
            appearance11.TextHAlignAsString = "Left";
            ultraGridBand1.Header.Appearance = appearance11;
            ultraGridBand1.Header.Caption = "Proveedor";
            ultraGridBand1.HeaderVisible = true;
            ultraGridBand1.MaxRows = 1;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn16.Header.VisiblePosition = 0;
            ultraGridColumn16.Hidden = true;
            ultraGridColumn16.Width = 223;
            ultraGridColumn17.Header.VisiblePosition = 1;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn17.Width = 132;
            ultraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn18.Header.Caption = "Negocio";
            ultraGridColumn18.Header.VisiblePosition = 2;
            ultraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(165, 0);
            ultraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn18.Width = 431;
            appearance12.TextHAlignAsString = "Right";
            ultraGridColumn19.CellAppearance = appearance12;
            ultraGridColumn19.Header.Caption = "%";
            ultraGridColumn19.Header.VisiblePosition = 3;
            ultraGridColumn19.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn19.MaskInput = "nnn%";
            ultraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(69, 0);
            ultraGridColumn19.Width = 178;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19});
            appearance13.FontData.BoldAsString = "True";
            appearance13.FontData.SizeInPoints = 10F;
            appearance13.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance13;
            ultraGridBand2.Header.Caption = "Negocios";
            ultraGridBand2.Header.TextOrientation = new Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal);
            ultraGridBand2.HeaderVisible = true;
            ultraGridBand2.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            appearance33.FontData.BoldAsString = "True";
            appearance33.TextHAlignAsString = "Right";
            summarySettings1.Appearance = appearance33;
            summarySettings1.DisplayFormat = "Total {0:###}%";
            summarySettings1.GroupBySummaryValueAppearance = appearance34;
            ultraGridBand2.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1});
            ultraGridBand2.SummaryFooterCaption = "";
            ultraGridBand2.VisiblePosition = 10;
            ultraGridColumn20.Header.VisiblePosition = 0;
            ultraGridColumn20.Hidden = true;
            ultraGridColumn21.DefaultCellValue = "True";
            ultraGridColumn21.Header.VisiblePosition = 1;
            ultraGridColumn21.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn21.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(69, 56);
            ultraGridColumn21.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(69, 0);
            ultraGridColumn21.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn21.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn21.Width = 214;
            ultraGridColumn22.DefaultCellValue = "True";
            ultraGridColumn22.Header.Caption = "Pago";
            ultraGridColumn22.Header.VisiblePosition = 2;
            ultraGridColumn22.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn22.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(69, 56);
            ultraGridColumn22.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(69, 0);
            ultraGridColumn22.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn22.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn22.Width = 311;
            ultraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn23.Header.Caption = "Calle";
            ultraGridColumn23.Header.VisiblePosition = 3;
            ultraGridColumn23.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn23.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(162, 0);
            ultraGridColumn23.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(162, 0);
            ultraGridColumn23.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn23.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn24.Header.Caption = "Número";
            ultraGridColumn24.Header.VisiblePosition = 4;
            ultraGridColumn24.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn24.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(65, 0);
            ultraGridColumn24.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn24.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn24.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn25.Header.VisiblePosition = 5;
            ultraGridColumn25.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn25.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(43, 0);
            ultraGridColumn25.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(34, 0);
            ultraGridColumn25.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn25.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn26.Header.VisiblePosition = 6;
            ultraGridColumn26.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn26.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn26.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(90, 0);
            ultraGridColumn26.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(84, 0);
            ultraGridColumn26.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn26.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn27.Header.Caption = "entre";
            ultraGridColumn27.Header.VisiblePosition = 7;
            ultraGridColumn27.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn27.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn27.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(0, 18);
            ultraGridColumn27.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn27.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn28.Header.Caption = "y";
            ultraGridColumn28.Header.VisiblePosition = 8;
            ultraGridColumn28.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn28.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn28.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn28.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn29.Header.VisiblePosition = 9;
            ultraGridColumn29.Hidden = true;
            ultraGridColumn30.Header.VisiblePosition = 10;
            ultraGridColumn30.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn30.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(356, 56);
            ultraGridColumn30.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn30.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn31.Header.Caption = "Barrio";
            ultraGridColumn31.Header.VisiblePosition = 11;
            ultraGridColumn31.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn31.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn31.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(123, 0);
            ultraGridColumn31.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(123, 0);
            ultraGridColumn31.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn31.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn31.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn32.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn32.Header.Caption = "Localidad";
            ultraGridColumn32.Header.VisiblePosition = 12;
            ultraGridColumn32.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn32.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn32.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(138, 0);
            ultraGridColumn32.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(138, 0);
            ultraGridColumn32.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn32.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn32.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn33.Header.VisiblePosition = 13;
            ultraGridColumn33.Hidden = true;
            ultraGridColumn34.Header.VisiblePosition = 14;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34});
            appearance35.FontData.BoldAsString = "True";
            appearance35.FontData.SizeInPoints = 10F;
            appearance35.TextHAlignAsString = "Left";
            ultraGridBand3.Header.Appearance = appearance35;
            ultraGridBand3.Header.Caption = "Direcciones";
            ultraGridBand3.HeaderVisible = true;
            ultraGridBand3.MaxRows = 2;
            ultraGridBand3.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridBand4.CardSettings.ShowCaption = false;
            ultraGridBand4.CardView = true;
            ultraGridColumn35.Header.VisiblePosition = 0;
            ultraGridColumn35.Hidden = true;
            ultraGridColumn35.Width = 195;
            ultraGridColumn36.Header.VisiblePosition = 1;
            ultraGridColumn36.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn36.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(114, 0);
            ultraGridColumn36.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn36.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn36.Width = 311;
            ultraGridColumn37.Header.VisiblePosition = 2;
            ultraGridColumn37.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn35,
            ultraGridColumn36,
            ultraGridColumn37});
            appearance36.FontData.BoldAsString = "True";
            appearance36.FontData.SizeInPoints = 10F;
            appearance36.TextHAlignAsString = "Left";
            ultraGridBand4.Header.Appearance = appearance36;
            ultraGridBand4.Header.Caption = "Tel. Dirección";
            ultraGridBand4.HeaderVisible = true;
            ultraGridBand4.MaxRows = 7;
            ultraGridBand4.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn38.Header.VisiblePosition = 0;
            ultraGridColumn38.Hidden = true;
            ultraGridColumn39.Header.VisiblePosition = 1;
            ultraGridColumn39.Width = 214;
            ultraGridColumn40.Header.VisiblePosition = 2;
            ultraGridColumn40.Hidden = true;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40});
            appearance37.FontData.BoldAsString = "True";
            appearance37.FontData.SizeInPoints = 10F;
            appearance37.TextHAlignAsString = "Left";
            ultraGridBand5.Header.Appearance = appearance37;
            ultraGridBand5.Header.Caption = "e-mail";
            ultraGridBand5.HeaderVisible = true;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn41.Header.VisiblePosition = 0;
            ultraGridColumn41.Hidden = true;
            ultraGridColumn42.Header.VisiblePosition = 1;
            ultraGridColumn42.Width = 214;
            ultraGridColumn43.Header.VisiblePosition = 2;
            ultraGridColumn43.Width = 311;
            ultraGridColumn44.Header.VisiblePosition = 3;
            ultraGridColumn44.Hidden = true;
            ultraGridColumn45.Header.VisiblePosition = 4;
            ultraGridColumn46.Header.VisiblePosition = 5;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46});
            appearance38.FontData.BoldAsString = "True";
            appearance38.FontData.SizeInPoints = 10F;
            appearance38.TextHAlignAsString = "Left";
            ultraGridBand6.Header.Appearance = appearance38;
            ultraGridBand6.Header.Caption = "Contactos";
            ultraGridBand6.HeaderVisible = true;
            ultraGridBand7.CardSettings.ShowCaption = false;
            ultraGridBand7.CardView = true;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn47.Header.VisiblePosition = 0;
            ultraGridColumn47.Hidden = true;
            ultraGridColumn48.Header.VisiblePosition = 1;
            ultraGridColumn49.Header.VisiblePosition = 2;
            ultraGridColumn49.Hidden = true;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49});
            appearance39.FontData.BoldAsString = "True";
            appearance39.FontData.SizeInPoints = 10F;
            appearance39.TextHAlignAsString = "Left";
            ultraGridBand7.Header.Appearance = appearance39;
            ultraGridBand7.Header.Caption = "Teléfonos";
            ultraGridBand7.HeaderVisible = true;
            ultraGridBand7.MaxRows = 7;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn50.Header.VisiblePosition = 0;
            ultraGridColumn50.Hidden = true;
            ultraGridColumn50.Width = 120;
            ultraGridColumn51.Header.VisiblePosition = 1;
            ultraGridColumn51.Width = 195;
            ultraGridColumn52.Header.VisiblePosition = 2;
            ultraGridColumn52.Hidden = true;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52});
            appearance40.FontData.BoldAsString = "True";
            appearance40.FontData.SizeInPoints = 10F;
            appearance40.TextHAlignAsString = "Left";
            ultraGridBand8.Header.Appearance = appearance40;
            ultraGridBand8.Header.Caption = "e-mail";
            ultraGridBand8.HeaderVisible = true;
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.proveedoresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.proveedoresUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.proveedoresUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.proveedoresUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance105.BackColor = System.Drawing.SystemColors.Window;
            this.proveedoresUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance105;
            appearance106.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance106.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance106.ForeColor = System.Drawing.SystemColors.WindowText;
            this.proveedoresUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance106;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.proveedoresUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance107.BackColor = System.Drawing.Color.Transparent;
            this.proveedoresUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance107;
            appearance108.BackColor = System.Drawing.SystemColors.Control;
            appearance108.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance108.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.proveedoresUltraGrid.DisplayLayout.Override.CellAppearance = appearance108;
            this.proveedoresUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance109.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance109.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance109.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance109.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.proveedoresUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance109;
            this.proveedoresUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance110.ForeColor = System.Drawing.Color.Red;
            this.proveedoresUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance110;
            this.proveedoresUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.proveedoresUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance111;
            appearance112.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance112.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.proveedoresUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance112;
            appearance113.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance113.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.proveedoresUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance113;
            this.proveedoresUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.proveedoresUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.proveedoresUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.proveedoresUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.proveedoresUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.proveedoresUltraGrid.Location = new System.Drawing.Point(16, -5);
            this.proveedoresUltraGrid.Margin = new System.Windows.Forms.Padding(4);
            this.proveedoresUltraGrid.MaximumSize = new System.Drawing.Size(989, 713);
            this.proveedoresUltraGrid.MinimumSize = new System.Drawing.Size(989, 713);
            this.proveedoresUltraGrid.Name = "proveedoresUltraGrid";
            this.proveedoresUltraGrid.Size = new System.Drawing.Size(989, 713);
            this.proveedoresUltraGrid.TabIndex = 2;
            this.proveedoresUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.ProveedoresUltraGrid_InitializeRow);
            this.proveedoresUltraGrid.AfterEnterEditMode += new System.EventHandler(this.ProveedoresUltraGridAfterEnterEditMode);
            this.proveedoresUltraGrid.AfterRowUpdate += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.ProveedoresUltraGrid_AfterRowUpdate);
            this.proveedoresUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ProveedoresUltraGrid_CellChange);
            this.proveedoresUltraGrid.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.proveedoresUltraGrid_BeforeCellDeactivate);
            this.proveedoresUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.ProveedoresUltraGrid_BeforeRowDeactivate);
            this.proveedoresUltraGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.ProveedoresUltraGrid_BeforeRowsDeleted);
            this.proveedoresUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.proveedoresUltraGrid_KeyDown);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.ds_Proveedores;
            // 
            // ds_Proveedores
            // 
            this.ds_Proveedores.DataSetName = "DsProveedores";
            this.ds_Proveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownRubros
            // 
            this.ultraDropDownRubros.DataSource = this.rubrosBindingSource;
            appearance41.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownRubros.DisplayLayout.Appearance = appearance41;
            ultraGridBand9.ColHeadersVisible = false;
            ultraGridColumn53.Header.VisiblePosition = 0;
            ultraGridColumn53.Hidden = true;
            ultraGridColumn54.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn54.Header.VisiblePosition = 1;
            ultraGridColumn54.Hidden = true;
            ultraGridColumn55.Header.VisiblePosition = 2;
            ultraGridColumn55.Hidden = true;
            ultraGridColumn56.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn56.Header.VisiblePosition = 3;
            ultraGridColumn57.Header.VisiblePosition = 4;
            ultraGridColumn57.Hidden = true;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57});
            ultraGridBand9.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridBand9.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand9.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownRubros.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraDropDownRubros.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownRubros.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownRubros.DisplayLayout.MaxBandDepth = 5;
            appearance42.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveCellAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance43.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance43.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveRowAppearance = appearance43;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance44.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.CardAreaAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.Control;
            appearance45.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.CellAppearance = appearance45;
            this.ultraDropDownRubros.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance46.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance46.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance46.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderAppearance = appearance46;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance47.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSelectorAppearance = appearance47;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedCellAppearance = appearance48;
            appearance49.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance49.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedRowAppearance = appearance49;
            appearance50.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownRubros.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance50;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownRubros.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownRubros.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownRubros.DisplayMember = "NombreCompleto";
            this.ultraDropDownRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownRubros.Location = new System.Drawing.Point(311, 336);
            this.ultraDropDownRubros.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownRubros.Name = "ultraDropDownRubros";
            this.ultraDropDownRubros.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownRubros.TabIndex = 28;
            this.ultraDropDownRubros.ValueMember = "idRubro";
            this.ultraDropDownRubros.Visible = false;
            this.ultraDropDownRubros.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownRubros_BeforeDropDown);
            // 
            // rubrosBindingSource
            // 
            this.rubrosBindingSource.DataMember = "Rubros";
            this.rubrosBindingSource.DataSource = this.dsRubros;
            // 
            // dsRubros
            // 
            this.dsRubros.DataSetName = "DsRubros";
            this.dsRubros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownNegocios
            // 
            this.ultraDropDownNegocios.DataSource = this.negociosBindingSource;
            appearance59.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance59.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownNegocios.DisplayLayout.Appearance = appearance59;
            this.ultraDropDownNegocios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand10.ColHeadersVisible = false;
            ultraGridColumn80.Header.VisiblePosition = 0;
            ultraGridColumn80.Hidden = true;
            ultraGridColumn81.Header.VisiblePosition = 1;
            ultraGridColumn81.Hidden = true;
            ultraGridColumn82.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn82.Header.VisiblePosition = 2;
            ultraGridColumn83.Header.VisiblePosition = 3;
            ultraGridColumn83.Hidden = true;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn80,
            ultraGridColumn81,
            ultraGridColumn82,
            ultraGridColumn83});
            ultraGridBand10.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand10.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownNegocios.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraDropDownNegocios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownNegocios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownNegocios.DisplayLayout.MaxBandDepth = 5;
            appearance60.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveCellAppearance = appearance60;
            appearance81.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance81.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance81.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveRowAppearance = appearance81;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance82.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.CardAreaAppearance = appearance82;
            appearance83.BackColor = System.Drawing.SystemColors.Control;
            appearance83.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.CellAppearance = appearance83;
            this.ultraDropDownNegocios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance14.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance14.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderAppearance = appearance14;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance15.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSelectorAppearance = appearance15;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedCellAppearance = appearance16;
            appearance53.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance53.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedRowAppearance = appearance53;
            appearance54.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance54.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownNegocios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance54;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownNegocios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownNegocios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownNegocios.DisplayMember = "Nombre";
            this.ultraDropDownNegocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownNegocios.Location = new System.Drawing.Point(311, 385);
            this.ultraDropDownNegocios.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownNegocios.Name = "ultraDropDownNegocios";
            this.ultraDropDownNegocios.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownNegocios.TabIndex = 29;
            this.ultraDropDownNegocios.ValueMember = "idNegocio";
            this.ultraDropDownNegocios.Visible = false;
            this.ultraDropDownNegocios.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownNegocios_BeforeDropDown);
            // 
            // negociosBindingSource
            // 
            this.negociosBindingSource.DataMember = "Negocios";
            this.negociosBindingSource.DataSource = this.dsNegocios;
            // 
            // dsNegocios
            // 
            this.dsNegocios.DataSetName = "DsNegocios";
            this.dsNegocios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDataSourceSeries
            // 
            this.ultraDataSourceSeries.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2});
            this.ultraDataSourceSeries.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Codigo")),
                        ((object)("A")),
                        ((object)("Nombre")),
                        ((object)("Factura A"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Codigo")),
                        ((object)("C")),
                        ((object)("Nombre")),
                        ((object)("Factura C"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Codigo")),
                        ((object)("X")),
                        ((object)("Nombre")),
                        ((object)("Sin Factura"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Codigo")),
                        ((object)("B")),
                        ((object)("Nombre")),
                        ((object)("Factura B"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Codigo")),
                        ((object)("M")),
                        ((object)("Nombre")),
                        ((object)("Factura M"))})});
            // 
            // ultraDropDownSeries
            // 
            this.ultraDropDownSeries.DataSource = this.ultraDataSourceSeries;
            appearance17.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownSeries.DisplayLayout.Appearance = appearance17;
            this.ultraDropDownSeries.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand11.ColHeadersVisible = false;
            ultraGridColumn58.Header.VisiblePosition = 0;
            ultraGridColumn58.Hidden = true;
            ultraGridColumn59.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn59.Header.VisiblePosition = 1;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn58,
            ultraGridColumn59});
            ultraGridBand11.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand11.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownSeries.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraDropDownSeries.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownSeries.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownSeries.DisplayLayout.MaxBandDepth = 5;
            appearance18.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownSeries.DisplayLayout.Override.ActiveCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance19.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownSeries.DisplayLayout.Override.ActiveRowAppearance = appearance19;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance20.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownSeries.DisplayLayout.Override.CardAreaAppearance = appearance20;
            appearance55.BackColor = System.Drawing.SystemColors.Control;
            appearance55.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownSeries.DisplayLayout.Override.CellAppearance = appearance55;
            this.ultraDropDownSeries.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance56.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance56.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance56.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance56.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownSeries.DisplayLayout.Override.HeaderAppearance = appearance56;
            this.ultraDropDownSeries.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance57.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownSeries.DisplayLayout.Override.RowSelectorAppearance = appearance57;
            this.ultraDropDownSeries.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownSeries.DisplayLayout.Override.SelectedCellAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance25.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownSeries.DisplayLayout.Override.SelectedRowAppearance = appearance25;
            appearance58.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance58.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownSeries.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance58;
            this.ultraDropDownSeries.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownSeries.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownSeries.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownSeries.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownSeries.DisplayMember = "Nombre";
            this.ultraDropDownSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownSeries.Location = new System.Drawing.Point(311, 434);
            this.ultraDropDownSeries.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownSeries.Name = "ultraDropDownSeries";
            this.ultraDropDownSeries.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownSeries.TabIndex = 30;
            this.ultraDropDownSeries.ValueMember = "Codigo";
            this.ultraDropDownSeries.Visible = false;
            this.ultraDropDownSeries.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownSeries_BeforeDropDown);
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
            // dsCallesLista
            // 
            this.dsCallesLista.DataSetName = "DsCallesLista";
            this.dsCallesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceCalle
            // 
            this.bindingSourceCalle.DataMember = "Calles";
            this.bindingSourceCalle.DataSource = this.dsCallesLista;
            // 
            // dsBarrios
            // 
            this.dsBarrios.DataSetName = "DsBarrios";
            this.dsBarrios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barriosBindingSource
            // 
            this.barriosBindingSource.DataSource = this.dsBarrios;
            this.barriosBindingSource.Position = 0;
            // 
            // dsCategoriasIVA
            // 
            this.dsCategoriasIVA.DataSetName = "DsCategoriasIVA";
            this.dsCategoriasIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasIVABindingSource
            // 
            this.categoriasIVABindingSource.DataMember = "CategoriasIVA";
            this.categoriasIVABindingSource.DataSource = this.dsCategoriasIVA;
            // 
            // ultraDropDownBarrios
            // 
            this.ultraDropDownBarrios.DataSource = this.barriosBindingSource;
            appearance64.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance64.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrios.DisplayLayout.Appearance = appearance64;
            this.ultraDropDownBarrios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand12.ColHeadersVisible = false;
            ultraGridColumn60.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn60.Header.VisiblePosition = 0;
            ultraGridColumn60.Hidden = true;
            ultraGridColumn60.Width = 57;
            ultraGridColumn61.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn61.Header.VisiblePosition = 1;
            ultraGridColumn61.Width = 227;
            ultraGridColumn62.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn62.Header.VisiblePosition = 2;
            ultraGridColumn62.Hidden = true;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62});
            this.ultraDropDownBarrios.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraDropDownBarrios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBarrios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBarrios.DisplayLayout.MaxBandDepth = 5;
            appearance65.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveCellAppearance = appearance65;
            appearance66.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance66.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance66.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveRowAppearance = appearance66;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance67.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.CardAreaAppearance = appearance67;
            appearance68.BackColor = System.Drawing.SystemColors.Control;
            appearance68.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.CellAppearance = appearance68;
            this.ultraDropDownBarrios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance69.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance69.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance69.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance69.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderAppearance = appearance69;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance70.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSelectorAppearance = appearance70;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedCellAppearance = appearance71;
            appearance72.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance72.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance72.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedRowAppearance = appearance72;
            appearance73.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance73.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBarrios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance73;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBarrios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBarrios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBarrios.DisplayMember = "Nombre";
            this.ultraDropDownBarrios.DropDownWidth = 250;
            this.ultraDropDownBarrios.Location = new System.Drawing.Point(311, 484);
            this.ultraDropDownBarrios.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownBarrios.Name = "ultraDropDownBarrios";
            this.ultraDropDownBarrios.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownBarrios.TabIndex = 71;
            this.ultraDropDownBarrios.ValueMember = "idBarrio";
            this.ultraDropDownBarrios.Visible = false;
            this.ultraDropDownBarrios.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownBarriosBeforeDropDown);
            this.ultraDropDownBarrios.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownBarriosFilterRow);
            // 
            // ultraDropDownCategoriasIVA
            // 
            this.ultraDropDownCategoriasIVA.DataSource = this.categoriasIVABindingSource;
            appearance21.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Appearance = appearance21;
            this.ultraDropDownCategoriasIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand13.ColHeadersVisible = false;
            ultraGridColumn63.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn63.Header.VisiblePosition = 0;
            ultraGridColumn63.Hidden = true;
            ultraGridColumn64.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn64.Header.VisiblePosition = 1;
            ultraGridColumn65.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn65.Header.VisiblePosition = 2;
            ultraGridColumn65.Hidden = true;
            ultraGridColumn66.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn66.Header.VisiblePosition = 3;
            ultraGridColumn66.Hidden = true;
            ultraGridColumn67.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn67.Header.VisiblePosition = 4;
            ultraGridColumn67.Hidden = true;
            ultraGridColumn68.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn68.Header.VisiblePosition = 5;
            ultraGridColumn68.Hidden = true;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68});
            ultraGridBand13.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand13.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCategoriasIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.ultraDropDownCategoriasIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCategoriasIVA.DisplayLayout.MaxBandDepth = 5;
            appearance22.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveCellAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance23.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance23.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveRowAppearance = appearance23;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance26.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CardAreaAppearance = appearance26;
            appearance27.BackColor = System.Drawing.SystemColors.Control;
            appearance27.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CellAppearance = appearance27;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance28.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance28.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance28.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderAppearance = appearance28;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance29.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSelectorAppearance = appearance29;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedCellAppearance = appearance30;
            appearance31.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance31.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedRowAppearance = appearance31;
            appearance32.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance32;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCategoriasIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCategoriasIVA.DisplayMember = "Nombre";
            this.ultraDropDownCategoriasIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCategoriasIVA.Location = new System.Drawing.Point(311, 287);
            this.ultraDropDownCategoriasIVA.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownCategoriasIVA.Name = "ultraDropDownCategoriasIVA";
            this.ultraDropDownCategoriasIVA.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownCategoriasIVA.TabIndex = 76;
            this.ultraDropDownCategoriasIVA.ValueMember = "idCategoriaIVA";
            this.ultraDropDownCategoriasIVA.Visible = false;
            this.ultraDropDownCategoriasIVA.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCategoriasIVABeforeDropDown);
            // 
            // ultraDropDownLocalidades
            // 
            this.ultraDropDownLocalidades.DataSource = this.localidadesListaBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidades.DisplayLayout.Appearance = appearance1;
            this.ultraDropDownLocalidades.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand14.ColHeadersVisible = false;
            ultraGridColumn69.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn69.Header.VisiblePosition = 0;
            ultraGridColumn69.Hidden = true;
            ultraGridColumn69.Width = 91;
            ultraGridColumn70.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn70.Header.VisiblePosition = 1;
            ultraGridColumn70.Width = 294;
            ultraGridColumn71.Header.VisiblePosition = 2;
            ultraGridColumn71.Hidden = true;
            ultraGridColumn71.Width = 58;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn69,
            ultraGridColumn70,
            ultraGridColumn71});
            this.ultraDropDownLocalidades.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraDropDownLocalidades.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidades.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidades.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidades.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidades.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidades.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidades.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraDropDownLocalidades.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidades.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraDropDownLocalidades.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidades.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraDropDownLocalidades.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidades.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidades.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidades.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraDropDownLocalidades.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidades.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidades.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidades.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidades.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidades.Location = new System.Drawing.Point(311, 534);
            this.ultraDropDownLocalidades.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownLocalidades.Name = "ultraDropDownLocalidades";
            this.ultraDropDownLocalidades.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownLocalidades.TabIndex = 77;
            this.ultraDropDownLocalidades.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidades.Visible = false;
            this.ultraDropDownLocalidades.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownLocalidadesRowSelected);
            // 
            // ultraDropDownCalle
            // 
            this.ultraDropDownCalle.DataSource = this.bindingSourceCalle;
            appearance174.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance174.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance174.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalle.DisplayLayout.Appearance = appearance174;
            this.ultraDropDownCalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand15.ColHeadersVisible = false;
            ultraGridColumn72.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn72.Header.VisiblePosition = 0;
            ultraGridColumn72.Hidden = true;
            ultraGridColumn72.Width = 39;
            ultraGridColumn73.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn73.Header.VisiblePosition = 1;
            ultraGridColumn73.Hidden = true;
            ultraGridColumn73.Width = 231;
            ultraGridColumn74.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn74.Header.VisiblePosition = 2;
            ultraGridColumn74.Hidden = true;
            ultraGridColumn74.Width = 51;
            ultraGridColumn75.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn75.Header.VisiblePosition = 3;
            ultraGridColumn75.Width = 227;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74,
            ultraGridColumn75});
            this.ultraDropDownCalle.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.ultraDropDownCalle.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCalle.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCalle.DisplayLayout.MaxBandDepth = 5;
            appearance175.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCalle.DisplayLayout.Override.ActiveCellAppearance = appearance175;
            appearance176.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance176.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance176.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance176.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCalle.DisplayLayout.Override.ActiveRowAppearance = appearance176;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance177.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCalle.DisplayLayout.Override.CardAreaAppearance = appearance177;
            appearance178.BackColor = System.Drawing.SystemColors.Control;
            appearance178.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance178.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalle.DisplayLayout.Override.CellAppearance = appearance178;
            this.ultraDropDownCalle.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance179.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance179.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance179.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance179.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCalle.DisplayLayout.Override.HeaderAppearance = appearance179;
            this.ultraDropDownCalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance180.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCalle.DisplayLayout.Override.RowSelectorAppearance = appearance180;
            this.ultraDropDownCalle.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance181.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCalle.DisplayLayout.Override.SelectedCellAppearance = appearance181;
            appearance182.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance182.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance182.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalle.DisplayLayout.Override.SelectedRowAppearance = appearance182;
            appearance183.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance183.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCalle.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance183;
            this.ultraDropDownCalle.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCalle.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCalle.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCalle.DisplayMember = "Nombre";
            this.ultraDropDownCalle.DropDownWidth = 250;
            this.ultraDropDownCalle.Location = new System.Drawing.Point(311, 583);
            this.ultraDropDownCalle.Margin = new System.Windows.Forms.Padding(4);
            this.ultraDropDownCalle.Name = "ultraDropDownCalle";
            this.ultraDropDownCalle.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownCalle.TabIndex = 78;
            this.ultraDropDownCalle.ValueMember = "idCalle";
            this.ultraDropDownCalle.Visible = false;
            this.ultraDropDownCalle.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCalleBeforeDropDown);
            this.ultraDropDownCalle.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCalleFilterRow);
            // 
            // dsParametros
            // 
            this.dsParametros.DataSetName = "DsParametros";
            this.dsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1008, 745);
            this.Controls.Add(this.proveedoresUltraGrid);
            this.Controls.Add(this.ultraDropDownCalle);
            this.Controls.Add(this.ultraDropDownLocalidades);
            this.Controls.Add(this.ultraDropDownCategoriasIVA);
            this.Controls.Add(this.ultraDropDownBarrios);
            this.Controls.Add(this.ultraDropDownSeries);
            this.Controls.Add(this.ultraDropDownNegocios);
            this.Controls.Add(this.ultraDropDownRubros);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1218, 792);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormABCProveedoresLoad);
            this.Controls.SetChildIndex(this.ultraDropDownRubros, 0);
            this.Controls.SetChildIndex(this.ultraDropDownNegocios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownSeries, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBarrios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCategoriasIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownLocalidades, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCalle, 0);
            this.Controls.SetChildIndex(this.proveedoresUltraGrid, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Administración.WS.DsProveedores ds_Proveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid proveedoresUltraGrid;
        private WS.DsRubros dsRubros;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownRubros;
        private WS.DsNegocios dsNegocios;
        private System.Windows.Forms.BindingSource negociosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownNegocios;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceSeries;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownSeries;
        private System.Windows.Forms.BindingSource localidadesListaBindingSource;
        private WS.DsLocalidadesLista dsLocalidadesLista;
        private WS.DsCallesLista dsCallesLista;
        private System.Windows.Forms.BindingSource bindingSourceCalle;
        private WS.DsBarrios dsBarrios;
        private System.Windows.Forms.BindingSource barriosBindingSource;
        private WS.DsCategoriasIVA dsCategoriasIVA;
        private System.Windows.Forms.BindingSource categoriasIVABindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBarrios;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCategoriasIVA;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLocalidades;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCalle;
        private DsParametros dsParametros;
    }
}
