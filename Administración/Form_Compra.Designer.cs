namespace Administración
{
    partial class FormCompra
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
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Compras", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Comprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeComprobante");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRegistro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie", -1, "ultraDropDownSeries");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA", -1, "ultraDropDownCategoriasIVA", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaDePago");
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_NegociosCompras_Compras");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Compras_IVACompras");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Compras_LibroDiario");
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_NegociosCompras_Compras", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocioCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio", -1, "ultraDropDownNegocios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumNegocios", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Porcentaje", 3, true, "FK_NegociosCompras_Compras", 1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Porcentaje", 3, true);
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Compras_IVACompras", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idIVACompras");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn87 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn88 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA", -1, "ultraDropDownPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn89 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteNeto");
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteIVA");
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings2 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalNeto", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "ImporteNeto", 3, true, "FK_Compras_IVACompras", 2, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings3 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalIVA", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "ImporteIVA", 4, true, "FK_Compras_IVACompras", 2, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Compras_LibroDiario", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLibroDiario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCompra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro", -1, "ultraDropDownRubros");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Debe");
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Haber");
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings4 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalDebe", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Debe", 3, true, "FK_Compras_LibroDiario", 3, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance("TotalDebe");
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings5 = new Infragistics.Win.UltraWinGrid.SummarySettings("TotalHaber", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Haber", 4, true, "FK_Compras_LibroDiario", 3, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, null, -1, false);
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Proveedores", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn97 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn98 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn99 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RazonSocial");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn100 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreFantasia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn101 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn102 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn103 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn104 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn105 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIva");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn106 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresosBrutos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn107 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn108 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_NegociosDelProveedor_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn109 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn110 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn111 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Proveedores");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_NegociosDelProveedor_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn112 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocioDelProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn113 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn114 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn115 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn116 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Telefonos__idDir__4850AF91");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Telefonos__idDir__4850AF91", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn131 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Proveedores", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Contactos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn143 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn144 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn145 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Contactos", 5);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn146 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn147 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn148 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre");
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn149 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn150 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Negocios", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn151 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idNegocio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn152 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn153 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn154 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Rubros", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn155 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRubro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn156 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn157 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AdmiteValores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn158 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn159 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo");
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand16 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PorcentajeIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn160 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPorcentajeIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn161 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoAFIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn162 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn163 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn164 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje");
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand17 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CategoriasIVA", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn165 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn166 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn167 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn168 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExigeCUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn169 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Factura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn212 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn213 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NdeD");
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            this.comprasUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCompra = new Administración.WS.DsCompra();
            this.ultraLabelProveedor = new Infragistics.Win.Misc.UltraLabel();
            this.ultraComboProveedor = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProveedores = new Administración.WS.DsProveedores();
            this.ultraDataSourceSeries = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDropDownSeries = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownNegocios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.negociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNegocios = new Administración.WS.DsNegocios();
            this.ultraDropDownRubros = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRubros = new Administración.WS.DsRubros();
            this.ultraDropDownPorcentajeIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.porcentajeIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPorcentajeIVA = new Administración.WS.DsPorcentajeIVA();
            this.dsParametros = new Administración.DsParametros();
            this.ultraDropDownCategoriasIVA = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.categoriasIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCategoriasIVA = new Administración.WS.DsCategoriasIVA();
            this.dsProveedor = new Administración.WS.DsProveedores();
            this.dsSistemas = new Administración.WS.DsSistemas();
            this.sistemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(694, 16);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAceptar.Size = new System.Drawing.Size(96, 23);
            this.buttonAceptar.Text = "Aceptar y Pagar";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(538, 16);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAplicar.Size = new System.Drawing.Size(150, 23);
            this.buttonAplicar.Text = "Aceptar y Posponer el Pago";
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Size = new System.Drawing.Size(805, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(457, 16);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // comprasUltraGrid
            // 
            this.comprasUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasUltraGrid.DataSource = this.comprasBindingSource;
            appearance113.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance113.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.comprasUltraGrid.DisplayLayout.Appearance = appearance113;
            ultraGridColumn65.Header.VisiblePosition = 0;
            ultraGridColumn65.Hidden = true;
            ultraGridColumn66.Header.VisiblePosition = 1;
            ultraGridColumn66.Hidden = true;
            appearance23.TextHAlignAsString = "Center";
            ultraGridColumn67.CellAppearance = appearance23;
            ultraGridColumn67.Header.VisiblePosition = 5;
            ultraGridColumn67.RowLayoutColumnInfo.OriginX = 1;
            ultraGridColumn67.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn67.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(106, 0);
            ultraGridColumn67.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(106, 0);
            ultraGridColumn67.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn67.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn67.Width = 69;
            ultraGridColumn68.Header.Caption = "Factura";
            ultraGridColumn68.Header.VisiblePosition = 4;
            ultraGridColumn68.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn68.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn68.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn68.MaskInput = "####-########";
            ultraGridColumn68.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn68.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn68.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(92, 0);
            ultraGridColumn68.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(92, 0);
            ultraGridColumn68.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn68.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn68.Width = 83;
            appearance24.TextHAlignAsString = "Right";
            ultraGridColumn69.CellAppearance = appearance24;
            ultraGridColumn69.Header.Caption = "Importe Total";
            ultraGridColumn69.Header.VisiblePosition = 10;
            ultraGridColumn69.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn69.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn69.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn69.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn69.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(111, 0);
            ultraGridColumn69.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(111, 0);
            ultraGridColumn69.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn69.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn70.Header.VisiblePosition = 7;
            ultraGridColumn70.Hidden = true;
            ultraGridColumn71.Header.VisiblePosition = 2;
            ultraGridColumn71.Hidden = true;
            ultraGridColumn71.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn71.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn71.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn71.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn72.Header.VisiblePosition = 8;
            ultraGridColumn72.Hidden = true;
            ultraGridColumn73.Header.VisiblePosition = 6;
            ultraGridColumn73.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn73.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn73.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(307, 0);
            ultraGridColumn73.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(307, 0);
            ultraGridColumn73.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn73.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn73.Width = 69;
            ultraGridColumn74.Header.VisiblePosition = 9;
            ultraGridColumn74.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn74.MaskInput = "##-##.###.###-#";
            ultraGridColumn74.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn74.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn74.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(90, 0);
            ultraGridColumn74.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(90, 0);
            ultraGridColumn74.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn74.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn74.Width = 60;
            ultraGridColumn75.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn75.Header.VisiblePosition = 3;
            ultraGridColumn75.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn75.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn75.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(96, 0);
            ultraGridColumn75.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(96, 0);
            ultraGridColumn75.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn75.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn75.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn76.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn76.Header.Caption = "Categoría IVA";
            ultraGridColumn76.Header.VisiblePosition = 11;
            ultraGridColumn76.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn76.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn76.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(106, 0);
            ultraGridColumn76.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(106, 0);
            ultraGridColumn76.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn76.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn76.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            appearance25.TextHAlignAsString = "Center";
            ultraGridColumn77.CellAppearance = appearance25;
            ultraGridColumn77.Header.Caption = "Fech de ePago";
            ultraGridColumn77.Header.VisiblePosition = 12;
            ultraGridColumn77.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn77.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn77.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(90, 0);
            ultraGridColumn77.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(89, 0);
            ultraGridColumn77.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn77.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn78.Header.VisiblePosition = 13;
            ultraGridColumn78.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn78.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn78.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(384, 0);
            ultraGridColumn78.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(384, 0);
            ultraGridColumn78.RowLayoutColumnInfo.SpanX = 10;
            ultraGridColumn78.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn79.Header.VisiblePosition = 16;
            ultraGridColumn80.Header.VisiblePosition = 14;
            ultraGridColumn81.Header.VisiblePosition = 15;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69,
            ultraGridColumn70,
            ultraGridColumn71,
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74,
            ultraGridColumn75,
            ultraGridColumn76,
            ultraGridColumn77,
            ultraGridColumn78,
            ultraGridColumn79,
            ultraGridColumn80,
            ultraGridColumn81});
            appearance26.FontData.BoldAsString = "True";
            appearance26.FontData.SizeInPoints = 10F;
            appearance26.TextHAlignAsString = "Left";
            ultraGridBand1.Header.Appearance = appearance26;
            ultraGridBand1.Header.Caption = "Compra";
            ultraGridBand1.HeaderVisible = true;
            ultraGridBand1.MaxRows = 1;
            ultraGridBand1.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn82.Header.VisiblePosition = 0;
            ultraGridColumn82.Hidden = true;
            ultraGridColumn83.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            ultraGridColumn83.Header.Caption = "Negocio";
            ultraGridColumn83.Header.VisiblePosition = 1;
            ultraGridColumn83.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn83.Width = 141;
            ultraGridColumn84.Header.VisiblePosition = 2;
            ultraGridColumn84.Hidden = true;
            ultraGridColumn84.Width = 153;
            appearance27.TextHAlignAsString = "Right";
            ultraGridColumn85.CellAppearance = appearance27;
            ultraGridColumn85.Header.VisiblePosition = 3;
            ultraGridColumn85.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn85.MaskInput = "nnn%";
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn84,
            ultraGridColumn85});
            appearance28.FontData.BoldAsString = "True";
            appearance28.FontData.SizeInPoints = 10F;
            appearance28.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance28;
            ultraGridBand2.Header.Caption = "Negocios";
            ultraGridBand2.HeaderVisible = true;
            ultraGridBand2.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            ultraGridBand2.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance29.FontData.BoldAsString = "True";
            appearance29.TextHAlignAsString = "Right";
            summarySettings1.Appearance = appearance29;
            summarySettings1.DisplayFormat = "Total {0:###}%";
            summarySettings1.GroupBySummaryValueAppearance = appearance30;
            ultraGridBand2.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1});
            ultraGridColumn86.Header.VisiblePosition = 0;
            ultraGridColumn86.Hidden = true;
            ultraGridColumn87.Header.VisiblePosition = 1;
            ultraGridColumn87.Hidden = true;
            ultraGridColumn88.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn88.Header.Caption = "Porcentaje";
            ultraGridColumn88.Header.VisiblePosition = 2;
            ultraGridColumn88.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn88.Width = 100;
            appearance93.TextHAlignAsString = "Right";
            ultraGridColumn89.CellAppearance = appearance93;
            ultraGridColumn89.Header.Caption = "Importe Neto";
            ultraGridColumn89.Header.VisiblePosition = 3;
            ultraGridColumn89.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn89.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            appearance94.TextHAlignAsString = "Right";
            ultraGridColumn90.CellAppearance = appearance94;
            ultraGridColumn90.Header.Caption = "Importe IVA";
            ultraGridColumn90.Header.VisiblePosition = 4;
            ultraGridColumn90.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn90.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn86,
            ultraGridColumn87,
            ultraGridColumn88,
            ultraGridColumn89,
            ultraGridColumn90});
            appearance95.FontData.BoldAsString = "True";
            appearance95.FontData.SizeInPoints = 10F;
            appearance95.TextHAlignAsString = "Left";
            ultraGridBand3.Header.Appearance = appearance95;
            ultraGridBand3.Header.Caption = "IVA";
            ultraGridBand3.HeaderVisible = true;
            ultraGridBand3.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            ultraGridBand3.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance96.FontData.BoldAsString = "True";
            appearance96.TextHAlignAsString = "Right";
            summarySettings2.Appearance = appearance96;
            summarySettings2.DisplayFormat = "{0:c}";
            summarySettings2.GroupBySummaryValueAppearance = appearance97;
            appearance98.FontData.BoldAsString = "True";
            appearance98.TextHAlignAsString = "Right";
            summarySettings3.Appearance = appearance98;
            summarySettings3.DisplayFormat = "{0:c}";
            summarySettings3.GroupBySummaryValueAppearance = appearance99;
            ultraGridBand3.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings2,
            summarySettings3});
            ultraGridColumn91.Header.VisiblePosition = 0;
            ultraGridColumn91.Hidden = true;
            ultraGridColumn92.Header.VisiblePosition = 1;
            ultraGridColumn92.Hidden = true;
            ultraGridColumn93.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
            ultraGridColumn93.Header.Caption = "Rubro";
            ultraGridColumn93.Header.VisiblePosition = 2;
            ultraGridColumn93.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn93.Width = 240;
            appearance100.TextHAlignAsString = "Right";
            ultraGridColumn94.CellAppearance = appearance100;
            ultraGridColumn94.Header.VisiblePosition = 3;
            ultraGridColumn94.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn94.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            appearance101.TextHAlignAsString = "Right";
            ultraGridColumn95.CellAppearance = appearance101;
            ultraGridColumn95.Header.VisiblePosition = 4;
            ultraGridColumn95.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn95.MaskInput = "{LOC}$ -n,nnn,nnn.nn";
            ultraGridColumn96.Header.VisiblePosition = 5;
            ultraGridColumn96.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn91,
            ultraGridColumn92,
            ultraGridColumn93,
            ultraGridColumn94,
            ultraGridColumn95,
            ultraGridColumn96});
            appearance102.FontData.BoldAsString = "True";
            appearance102.FontData.SizeInPoints = 10F;
            appearance102.TextHAlignAsString = "Left";
            ultraGridBand4.Header.Appearance = appearance102;
            ultraGridBand4.Header.Caption = "Libro Diario";
            ultraGridBand4.HeaderVisible = true;
            ultraGridBand4.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            ultraGridBand4.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance103.FontData.BoldAsString = "True";
            appearance103.TextHAlignAsString = "Right";
            summarySettings4.Appearance = appearance103;
            summarySettings4.DisplayFormat = "{0:c}";
            summarySettings4.GroupBySummaryValueAppearance = appearance104;
            appearance105.FontData.BoldAsString = "True";
            appearance105.TextHAlignAsString = "Right";
            summarySettings5.Appearance = appearance105;
            summarySettings5.DisplayFormat = "{0:c}";
            summarySettings5.GroupBySummaryValueAppearance = appearance106;
            ultraGridBand4.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings4,
            summarySettings5});
            this.comprasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.comprasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.comprasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.comprasUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.comprasUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.comprasUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.comprasUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance134.BackColor = System.Drawing.SystemColors.Window;
            this.comprasUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance134;
            appearance135.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance135.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance135.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance135.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comprasUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance135;
            this.comprasUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.comprasUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.comprasUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.comprasUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.comprasUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.comprasUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.comprasUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance136.BackColor = System.Drawing.Color.Transparent;
            this.comprasUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance136;
            appearance137.BackColor = System.Drawing.SystemColors.Control;
            appearance137.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance137.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprasUltraGrid.DisplayLayout.Override.CellAppearance = appearance137;
            this.comprasUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance138.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance138.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance138.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance138.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance138.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.comprasUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance138;
            this.comprasUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance139.ForeColor = System.Drawing.Color.Red;
            this.comprasUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance139;
            this.comprasUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance140.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.comprasUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance140;
            appearance141.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance141.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance141.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.comprasUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance141;
            appearance142.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance142.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.comprasUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance142;
            this.comprasUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comprasUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.comprasUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.comprasUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.comprasUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comprasUltraGrid.Location = new System.Drawing.Point(0, 48);
            this.comprasUltraGrid.Name = "comprasUltraGrid";
            this.comprasUltraGrid.Size = new System.Drawing.Size(802, 540);
            this.comprasUltraGrid.TabIndex = 2;
            this.comprasUltraGrid.Visible = false;
            this.comprasUltraGrid.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.comprasUltraGrid_AfterCellUpdate);
            this.comprasUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.comprasUltraGrid_InitializeRow);
            this.comprasUltraGrid.AfterEnterEditMode += new System.EventHandler(this.comprasUltraGrid_AfterEnterEditMode);
            this.comprasUltraGrid.AfterExitEditMode += new System.EventHandler(this.comprasUltraGrid_AfterExitEditMode);
            this.comprasUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.comprasUltraGrid_CellChange);
            this.comprasUltraGrid.SummaryValueChanged += new Infragistics.Win.UltraWinGrid.SummaryValueChangedEventHandler(this.comprasUltraGrid_SummaryValueChanged);
            this.comprasUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comprasUltraGrid_KeyDown);
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.dsCompra;
            // 
            // dsCompra
            // 
            this.dsCompra.DataSetName = "DsCompra";
            this.dsCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraLabelProveedor
            // 
            this.ultraLabelProveedor.AutoSize = true;
            this.ultraLabelProveedor.Location = new System.Drawing.Point(13, 13);
            this.ultraLabelProveedor.Name = "ultraLabelProveedor";
            this.ultraLabelProveedor.Size = new System.Drawing.Size(56, 14);
            this.ultraLabelProveedor.TabIndex = 3;
            this.ultraLabelProveedor.Text = "Proveedor";
            // 
            // ultraComboProveedor
            // 
            this.ultraComboProveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboProveedor.DataSource = this.proveedoresBindingSource;
            appearance31.BackColor = System.Drawing.SystemColors.Window;
            appearance31.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraComboProveedor.DisplayLayout.Appearance = appearance31;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn97.Header.VisiblePosition = 0;
            ultraGridColumn97.Hidden = true;
            ultraGridColumn98.Header.VisiblePosition = 1;
            ultraGridColumn98.Hidden = true;
            ultraGridColumn99.Header.VisiblePosition = 2;
            ultraGridColumn99.Hidden = true;
            ultraGridColumn100.Header.VisiblePosition = 3;
            ultraGridColumn100.Hidden = true;
            ultraGridColumn101.Header.VisiblePosition = 4;
            ultraGridColumn101.Hidden = true;
            ultraGridColumn102.Header.VisiblePosition = 5;
            ultraGridColumn103.Header.VisiblePosition = 6;
            ultraGridColumn103.Hidden = true;
            ultraGridColumn104.Header.VisiblePosition = 7;
            ultraGridColumn104.Hidden = true;
            ultraGridColumn105.Header.VisiblePosition = 8;
            ultraGridColumn105.Hidden = true;
            ultraGridColumn106.Header.VisiblePosition = 9;
            ultraGridColumn106.Hidden = true;
            ultraGridColumn107.Header.VisiblePosition = 10;
            ultraGridColumn107.Hidden = true;
            ultraGridColumn108.Header.VisiblePosition = 11;
            ultraGridColumn109.Header.VisiblePosition = 12;
            ultraGridColumn110.Header.VisiblePosition = 13;
            ultraGridColumn111.Header.VisiblePosition = 14;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn97,
            ultraGridColumn98,
            ultraGridColumn99,
            ultraGridColumn100,
            ultraGridColumn101,
            ultraGridColumn102,
            ultraGridColumn103,
            ultraGridColumn104,
            ultraGridColumn105,
            ultraGridColumn106,
            ultraGridColumn107,
            ultraGridColumn108,
            ultraGridColumn109,
            ultraGridColumn110,
            ultraGridColumn111});
            ultraGridColumn112.Header.VisiblePosition = 0;
            ultraGridColumn113.Header.VisiblePosition = 1;
            ultraGridColumn114.Header.VisiblePosition = 2;
            ultraGridColumn115.Header.VisiblePosition = 3;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn112,
            ultraGridColumn113,
            ultraGridColumn114,
            ultraGridColumn115});
            ultraGridColumn116.Header.VisiblePosition = 0;
            ultraGridColumn117.Header.VisiblePosition = 1;
            ultraGridColumn118.Header.VisiblePosition = 2;
            ultraGridColumn119.Header.VisiblePosition = 3;
            ultraGridColumn120.Header.VisiblePosition = 4;
            ultraGridColumn121.Header.VisiblePosition = 5;
            ultraGridColumn122.Header.VisiblePosition = 6;
            ultraGridColumn123.Header.VisiblePosition = 7;
            ultraGridColumn124.Header.VisiblePosition = 8;
            ultraGridColumn125.Header.VisiblePosition = 9;
            ultraGridColumn126.Header.VisiblePosition = 10;
            ultraGridColumn127.Header.VisiblePosition = 11;
            ultraGridColumn128.Header.VisiblePosition = 12;
            ultraGridColumn129.Header.VisiblePosition = 13;
            ultraGridColumn130.Header.VisiblePosition = 14;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn116,
            ultraGridColumn117,
            ultraGridColumn118,
            ultraGridColumn119,
            ultraGridColumn120,
            ultraGridColumn121,
            ultraGridColumn122,
            ultraGridColumn123,
            ultraGridColumn124,
            ultraGridColumn125,
            ultraGridColumn126,
            ultraGridColumn127,
            ultraGridColumn128,
            ultraGridColumn129,
            ultraGridColumn130});
            ultraGridColumn131.Header.VisiblePosition = 0;
            ultraGridColumn132.Header.VisiblePosition = 1;
            ultraGridColumn133.Header.VisiblePosition = 2;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn131,
            ultraGridColumn132,
            ultraGridColumn133});
            ultraGridColumn134.Header.VisiblePosition = 0;
            ultraGridColumn135.Header.VisiblePosition = 1;
            ultraGridColumn136.Header.VisiblePosition = 2;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn134,
            ultraGridColumn135,
            ultraGridColumn136});
            ultraGridColumn137.Header.VisiblePosition = 0;
            ultraGridColumn138.Header.VisiblePosition = 1;
            ultraGridColumn139.Header.VisiblePosition = 2;
            ultraGridColumn140.Header.VisiblePosition = 3;
            ultraGridColumn141.Header.VisiblePosition = 4;
            ultraGridColumn142.Header.VisiblePosition = 5;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn137,
            ultraGridColumn138,
            ultraGridColumn139,
            ultraGridColumn140,
            ultraGridColumn141,
            ultraGridColumn142});
            ultraGridColumn143.Header.VisiblePosition = 0;
            ultraGridColumn144.Header.VisiblePosition = 1;
            ultraGridColumn145.Header.VisiblePosition = 2;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn143,
            ultraGridColumn144,
            ultraGridColumn145});
            ultraGridColumn146.Header.VisiblePosition = 0;
            ultraGridColumn147.Header.VisiblePosition = 1;
            ultraGridColumn148.Header.VisiblePosition = 2;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn146,
            ultraGridColumn147,
            ultraGridColumn148});
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraComboProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraComboProveedor.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance32.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboProveedor.DisplayLayout.GroupByBox.Appearance = appearance32;
            appearance33.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboProveedor.DisplayLayout.GroupByBox.BandLabelAppearance = appearance33;
            this.ultraComboProveedor.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance34.BackColor2 = System.Drawing.SystemColors.Control;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance34.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboProveedor.DisplayLayout.GroupByBox.PromptAppearance = appearance34;
            this.ultraComboProveedor.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboProveedor.DisplayLayout.MaxRowScrollRegions = 1;
            appearance35.BackColor = System.Drawing.SystemColors.Window;
            appearance35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraComboProveedor.DisplayLayout.Override.ActiveCellAppearance = appearance35;
            appearance36.BackColor = System.Drawing.SystemColors.Highlight;
            appearance36.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraComboProveedor.DisplayLayout.Override.ActiveRowAppearance = appearance36;
            this.ultraComboProveedor.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboProveedor.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance37.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboProveedor.DisplayLayout.Override.CardAreaAppearance = appearance37;
            appearance38.BorderColor = System.Drawing.Color.Silver;
            appearance38.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraComboProveedor.DisplayLayout.Override.CellAppearance = appearance38;
            this.ultraComboProveedor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboProveedor.DisplayLayout.Override.CellPadding = 0;
            appearance39.BackColor = System.Drawing.SystemColors.Control;
            appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance39.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance39.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboProveedor.DisplayLayout.Override.GroupByRowAppearance = appearance39;
            appearance40.TextHAlignAsString = "Left";
            this.ultraComboProveedor.DisplayLayout.Override.HeaderAppearance = appearance40;
            this.ultraComboProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboProveedor.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance41.BackColor = System.Drawing.SystemColors.Window;
            appearance41.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboProveedor.DisplayLayout.Override.RowAppearance = appearance41;
            this.ultraComboProveedor.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance42.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboProveedor.DisplayLayout.Override.TemplateAddRowAppearance = appearance42;
            this.ultraComboProveedor.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboProveedor.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboProveedor.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboProveedor.DisplayMember = "NombreCompleto";
            this.ultraComboProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraComboProveedor.LimitToList = true;
            this.ultraComboProveedor.Location = new System.Drawing.Point(75, 9);
            this.ultraComboProveedor.Name = "ultraComboProveedor";
            this.ultraComboProveedor.Size = new System.Drawing.Size(543, 22);
            this.ultraComboProveedor.TabIndex = 4;
            this.ultraComboProveedor.ValueMember = "idProveedor";
            this.ultraComboProveedor.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraComboProveedor_BeforeDropDown);
            this.ultraComboProveedor.ValueChanged += new System.EventHandler(this.ultraComboProveedor_ValueChanged);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dsProveedores;
            // 
            // dsProveedores
            // 
            this.dsProveedores.DataSetName = "DsProveedores";
            this.dsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            appearance43.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance43.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownSeries.DisplayLayout.Appearance = appearance43;
            this.ultraDropDownSeries.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand13.ColHeadersVisible = false;
            ultraGridColumn149.Header.VisiblePosition = 0;
            ultraGridColumn149.Hidden = true;
            ultraGridColumn150.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn150.Header.VisiblePosition = 1;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn149,
            ultraGridColumn150});
            ultraGridBand13.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand13.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownSeries.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.ultraDropDownSeries.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownSeries.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownSeries.DisplayLayout.MaxBandDepth = 5;
            appearance44.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownSeries.DisplayLayout.Override.ActiveCellAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance45.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance45.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownSeries.DisplayLayout.Override.ActiveRowAppearance = appearance45;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownSeries.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance46.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownSeries.DisplayLayout.Override.CardAreaAppearance = appearance46;
            appearance47.BackColor = System.Drawing.SystemColors.Control;
            appearance47.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownSeries.DisplayLayout.Override.CellAppearance = appearance47;
            this.ultraDropDownSeries.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance48.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance48.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance48.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance48.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownSeries.DisplayLayout.Override.HeaderAppearance = appearance48;
            this.ultraDropDownSeries.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance49.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownSeries.DisplayLayout.Override.RowSelectorAppearance = appearance49;
            this.ultraDropDownSeries.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownSeries.DisplayLayout.Override.SelectedCellAppearance = appearance50;
            appearance51.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance51.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownSeries.DisplayLayout.Override.SelectedRowAppearance = appearance51;
            appearance52.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownSeries.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance52;
            this.ultraDropDownSeries.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownSeries.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownSeries.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownSeries.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownSeries.DisplayMember = "Nombre";
            this.ultraDropDownSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownSeries.Location = new System.Drawing.Point(65, 326);
            this.ultraDropDownSeries.Name = "ultraDropDownSeries";
            this.ultraDropDownSeries.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownSeries.TabIndex = 31;
            this.ultraDropDownSeries.ValueMember = "Codigo";
            this.ultraDropDownSeries.Visible = false;
            this.ultraDropDownSeries.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.ultraDropDownSeries_BeforeDropDown);
            // 
            // ultraDropDownNegocios
            // 
            this.ultraDropDownNegocios.DataSource = this.negociosBindingSource;
            appearance53.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance53.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownNegocios.DisplayLayout.Appearance = appearance53;
            this.ultraDropDownNegocios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand14.ColHeadersVisible = false;
            ultraGridColumn151.Header.VisiblePosition = 0;
            ultraGridColumn151.Hidden = true;
            ultraGridColumn152.Header.VisiblePosition = 1;
            ultraGridColumn152.Hidden = true;
            ultraGridColumn153.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn153.Header.VisiblePosition = 2;
            ultraGridColumn154.Header.VisiblePosition = 3;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn151,
            ultraGridColumn152,
            ultraGridColumn153,
            ultraGridColumn154});
            ultraGridBand14.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand14.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownNegocios.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraDropDownNegocios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownNegocios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownNegocios.DisplayLayout.MaxBandDepth = 5;
            appearance54.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveCellAppearance = appearance54;
            appearance55.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance55.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance55.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownNegocios.DisplayLayout.Override.ActiveRowAppearance = appearance55;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownNegocios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance56.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.CardAreaAppearance = appearance56;
            appearance57.BackColor = System.Drawing.SystemColors.Control;
            appearance57.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.CellAppearance = appearance57;
            this.ultraDropDownNegocios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance58.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance58.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance58.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance58.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderAppearance = appearance58;
            this.ultraDropDownNegocios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance59.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSelectorAppearance = appearance59;
            this.ultraDropDownNegocios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedCellAppearance = appearance60;
            appearance61.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance61.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownNegocios.DisplayLayout.Override.SelectedRowAppearance = appearance61;
            appearance62.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance62.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownNegocios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance62;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownNegocios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownNegocios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownNegocios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownNegocios.DisplayMember = "Nombre";
            this.ultraDropDownNegocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownNegocios.Location = new System.Drawing.Point(309, 366);
            this.ultraDropDownNegocios.Name = "ultraDropDownNegocios";
            this.ultraDropDownNegocios.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownNegocios.TabIndex = 33;
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
            // ultraDropDownRubros
            // 
            this.ultraDropDownRubros.DataSource = this.rubrosBindingSource;
            appearance63.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance63.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownRubros.DisplayLayout.Appearance = appearance63;
            ultraGridBand15.ColHeadersVisible = false;
            ultraGridColumn155.Header.VisiblePosition = 0;
            ultraGridColumn155.Hidden = true;
            ultraGridColumn156.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn156.Header.VisiblePosition = 1;
            ultraGridColumn156.Hidden = true;
            ultraGridColumn157.Header.VisiblePosition = 2;
            ultraGridColumn157.Hidden = true;
            ultraGridColumn158.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn158.Header.VisiblePosition = 3;
            ultraGridColumn159.Header.VisiblePosition = 4;
            ultraGridColumn159.Hidden = true;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn155,
            ultraGridColumn156,
            ultraGridColumn157,
            ultraGridColumn158,
            ultraGridColumn159});
            ultraGridBand15.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            ultraGridBand15.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand15.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownRubros.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.ultraDropDownRubros.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownRubros.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownRubros.DisplayLayout.MaxBandDepth = 5;
            appearance64.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveCellAppearance = appearance64;
            appearance65.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance65.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance65.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownRubros.DisplayLayout.Override.ActiveRowAppearance = appearance65;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownRubros.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance66.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.CardAreaAppearance = appearance66;
            appearance67.BackColor = System.Drawing.SystemColors.Control;
            appearance67.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.CellAppearance = appearance67;
            this.ultraDropDownRubros.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance68.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance68.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance68.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance68.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderAppearance = appearance68;
            this.ultraDropDownRubros.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance69.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSelectorAppearance = appearance69;
            this.ultraDropDownRubros.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedCellAppearance = appearance70;
            appearance71.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance71.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRubros.DisplayLayout.Override.SelectedRowAppearance = appearance71;
            appearance72.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance72.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownRubros.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance72;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownRubros.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownRubros.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownRubros.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownRubros.DisplayMember = "NombreCompleto";
            this.ultraDropDownRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownRubros.Location = new System.Drawing.Point(309, 326);
            this.ultraDropDownRubros.Name = "ultraDropDownRubros";
            this.ultraDropDownRubros.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownRubros.TabIndex = 32;
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
            // ultraDropDownPorcentajeIVA
            // 
            this.ultraDropDownPorcentajeIVA.DataSource = this.porcentajeIVABindingSource;
            appearance73.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance73.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Appearance = appearance73;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand16.ColHeadersVisible = false;
            ultraGridColumn160.Header.VisiblePosition = 0;
            ultraGridColumn160.Hidden = true;
            ultraGridColumn161.Header.VisiblePosition = 1;
            ultraGridColumn161.Hidden = true;
            ultraGridColumn162.Header.VisiblePosition = 2;
            ultraGridColumn163.Header.VisiblePosition = 3;
            ultraGridColumn163.Hidden = true;
            ultraGridColumn164.Header.VisiblePosition = 4;
            ultraGridColumn164.Hidden = true;
            ultraGridBand16.Columns.AddRange(new object[] {
            ultraGridColumn160,
            ultraGridColumn161,
            ultraGridColumn162,
            ultraGridColumn163,
            ultraGridColumn164});
            ultraGridBand16.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand16.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand16);
            this.ultraDropDownPorcentajeIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.MaxBandDepth = 5;
            appearance74.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveCellAppearance = appearance74;
            appearance75.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance75.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance75.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.ActiveRowAppearance = appearance75;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance76.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CardAreaAppearance = appearance76;
            appearance77.BackColor = System.Drawing.SystemColors.Control;
            appearance77.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.CellAppearance = appearance77;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance78.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance78.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance78.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance78.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderAppearance = appearance78;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance79.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSelectorAppearance = appearance79;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedCellAppearance = appearance80;
            appearance81.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance81.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.SelectedRowAppearance = appearance81;
            appearance82.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance82.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance82;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPorcentajeIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPorcentajeIVA.DisplayMember = "Descripcion";
            this.ultraDropDownPorcentajeIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPorcentajeIVA.Location = new System.Drawing.Point(65, 366);
            this.ultraDropDownPorcentajeIVA.Name = "ultraDropDownPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownPorcentajeIVA.TabIndex = 34;
            this.ultraDropDownPorcentajeIVA.ValueMember = "idPorcentajeIVA";
            this.ultraDropDownPorcentajeIVA.Visible = false;
            // 
            // porcentajeIVABindingSource
            // 
            this.porcentajeIVABindingSource.DataMember = "PorcentajeIVA";
            this.porcentajeIVABindingSource.DataSource = this.dsPorcentajeIVA;
            // 
            // dsPorcentajeIVA
            // 
            this.dsPorcentajeIVA.DataSetName = "DsPorcentajeIVA";
            this.dsPorcentajeIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsParametros
            // 
            this.dsParametros.DataSetName = "DsParametros";
            this.dsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCategoriasIVA
            // 
            this.ultraDropDownCategoriasIVA.DataSource = this.categoriasIVABindingSource;
            appearance83.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance83.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Appearance = appearance83;
            this.ultraDropDownCategoriasIVA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand17.ColHeadersVisible = false;
            ultraGridColumn165.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn165.Header.VisiblePosition = 0;
            ultraGridColumn165.Hidden = true;
            ultraGridColumn166.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn166.Header.VisiblePosition = 1;
            ultraGridColumn167.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn167.Header.VisiblePosition = 2;
            ultraGridColumn167.Hidden = true;
            ultraGridColumn168.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn168.Header.VisiblePosition = 3;
            ultraGridColumn168.Hidden = true;
            ultraGridColumn169.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn169.Header.VisiblePosition = 4;
            ultraGridColumn169.Hidden = true;
            ultraGridColumn212.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn212.Header.VisiblePosition = 5;
            ultraGridColumn212.Hidden = true;
            ultraGridColumn213.Header.VisiblePosition = 6;
            ultraGridBand17.Columns.AddRange(new object[] {
            ultraGridColumn165,
            ultraGridColumn166,
            ultraGridColumn167,
            ultraGridColumn168,
            ultraGridColumn169,
            ultraGridColumn212,
            ultraGridColumn213});
            ultraGridBand17.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand17.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCategoriasIVA.DisplayLayout.BandsSerializer.Add(ultraGridBand17);
            this.ultraDropDownCategoriasIVA.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCategoriasIVA.DisplayLayout.MaxBandDepth = 5;
            appearance84.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveCellAppearance = appearance84;
            appearance85.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance85.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance85.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance85.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.ActiveRowAppearance = appearance85;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance86.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CardAreaAppearance = appearance86;
            appearance87.BackColor = System.Drawing.SystemColors.Control;
            appearance87.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.CellAppearance = appearance87;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance88.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance88.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance88.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance88.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderAppearance = appearance88;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance89.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSelectorAppearance = appearance89;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance90.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedCellAppearance = appearance90;
            appearance91.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance91.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.SelectedRowAppearance = appearance91;
            appearance92.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance92.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance92;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCategoriasIVA.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCategoriasIVA.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCategoriasIVA.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCategoriasIVA.DisplayMember = "Nombre";
            this.ultraDropDownCategoriasIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCategoriasIVA.Location = new System.Drawing.Point(247, 285);
            this.ultraDropDownCategoriasIVA.Name = "ultraDropDownCategoriasIVA";
            this.ultraDropDownCategoriasIVA.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownCategoriasIVA.TabIndex = 77;
            this.ultraDropDownCategoriasIVA.ValueMember = "idCategoriaIVA";
            this.ultraDropDownCategoriasIVA.Visible = false;
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
            // dsProveedor
            // 
            this.dsProveedor.DataSetName = "DsProveedores";
            this.dsProveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSistemas
            // 
            this.dsSistemas.DataSetName = "DsSistemas";
            this.dsSistemas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemasBindingSource
            // 
            this.sistemasBindingSource.DataMember = "Sistemas";
            this.sistemasBindingSource.DataSource = this.dsSistemas;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(804, 626);
            this.Controls.Add(this.comprasUltraGrid);
            this.Controls.Add(this.ultraDropDownNegocios);
            this.Controls.Add(this.ultraDropDownRubros);
            this.Controls.Add(this.ultraComboProveedor);
            this.Controls.Add(this.ultraLabelProveedor);
            this.Controls.Add(this.ultraDropDownSeries);
            this.Controls.Add(this.ultraDropDownPorcentajeIVA);
            this.Controls.Add(this.ultraDropDownCategoriasIVA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(357, 194);
            this.Name = "FormCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.Shown += new System.EventHandler(this.FormCompra_Shown);
            this.Controls.SetChildIndex(this.ultraDropDownCategoriasIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPorcentajeIVA, 0);
            this.Controls.SetChildIndex(this.ultraDropDownSeries, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraLabelProveedor, 0);
            this.Controls.SetChildIndex(this.ultraComboProveedor, 0);
            this.Controls.SetChildIndex(this.ultraDropDownRubros, 0);
            this.Controls.SetChildIndex(this.ultraDropDownNegocios, 0);
            this.Controls.SetChildIndex(this.comprasUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comprasUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNegocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorcentajeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCategoriasIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Infragistics.Win.UltraWinGrid.UltraGrid comprasUltraGrid;
        private WS.DsProveedores dsProveedores;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Infragistics.Win.Misc.UltraLabel ultraLabelProveedor;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboProveedor;
        private WS.DsProveedores dsProveedor;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceSeries;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownSeries;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private WS.DsRubros dsRubros;
        private WS.DsNegocios dsNegocios;
        private System.Windows.Forms.BindingSource negociosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownNegocios;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownRubros;
        private WS.DsPorcentajeIVA dsPorcentajeIVA;
        private System.Windows.Forms.BindingSource porcentajeIVABindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPorcentajeIVA;
        private DsParametros dsParametros;
        private WS.DsSistemas dsSistemas;
        private System.Windows.Forms.BindingSource sistemasBindingSource;
        private System.Windows.Forms.BindingSource categoriasIVABindingSource;
        private WS.DsCategoriasIVA dsCategoriasIVA;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCategoriasIVA;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private WS.DsCompra dsCompra;
    }
}
