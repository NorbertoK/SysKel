using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    partial class FormTomarProgramado
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("DireccionesAfiliados", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
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
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idLocalidad");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idCalle");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piso");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Departamento");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idEntreCalle1");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn7 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idEntreCalle2");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn8 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observaciones");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn9 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idBarrio");
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("LugaresLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Direccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TelefonosDeLaDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDelContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ObservacionesDelContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TelefonosDelContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Localidades", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance154 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance155 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance156 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance157 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion1 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion2 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.Appearance appearance158 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance159 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance160 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance162 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance163 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance164 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance165 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance166 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Coberturas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Edad");
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EdadEn");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sexo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Antecedentes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago", -1, "ultraDropDownPrepagos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroPrepago", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExtraCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento", -1, "ultraDropDownTiposDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeDocumento");
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CopagoSugerido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn10 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("EsAfiliado");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn11 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ApelNomb");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn12 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Edad");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn13 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("EdadEn");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn14 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sexo");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn15 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Antecedentes");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn16 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idPrepago");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn17 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroPrepago");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn18 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn19 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idAfiliado");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn20 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ExtraCobertura");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn21 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn22 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroDeDocumento");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn23 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CopagoSugerido");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn24 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idPlan");
            Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDocumento", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance148 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance149 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance150 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance151 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance152 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance153 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prepagos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance190 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ContratosRenglonFactura", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato");
            Infragistics.Win.Appearance appearance191 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance192 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance193 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance178 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance179 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance180 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance181 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance182 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance183 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance184 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance185 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance186 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance187 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance188 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance189 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Practicas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPractica");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("LugaresLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Direccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TelefonosDeLaDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDelContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ObservacionesDelContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TelefonosDelContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("DireccionesAfiliados", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidad1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalles1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios1", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn25 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idLocalidad");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn26 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idCalle");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn27 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn28 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piso");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn29 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Departamento");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn30 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idEntreCalle1");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn31 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idEntreCalle2");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn32 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observaciones");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn33 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idBarrio");
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Localidades", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand16 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion3 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion4 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion5 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn34 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn35 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observaciones");
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand17 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance120 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance121 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance122 = new Infragistics.Win.Appearance();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.buttonBuscarTelefono = new System.Windows.Forms.Button();
            this.UltraGridDireccionOrigen = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSourceDireccioneOrigen = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraGroupBoxDirección = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.UltraComboLugarOrigen = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.lugaresListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLugaresLista = new Cabina.WS.DsLugaresLista();
            this.ultraDropDownLocalidad = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.localidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalidades1 = new Cabina.WS.DsLocalidades();
            this.ultraDropDownBarrios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.barriosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarrios = new Cabina.WS.DsBarrios();
            this.ultraDropDownCalles = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.callesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCallesLista = new Cabina.WS.DsCallesLista();
            this.ultraGroupBoxCobertura = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraComboCobertura = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.coberturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCoberturas = new Cabina.WS.DsCoberturas();
            this.ultraGroupBoxPaciente = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGridPaciente = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSourcePaciente = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDropDownTiposDeDocumento = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDocumento = new Cabina.WS.DsTiposDeDocumento();
            this.buttonBuscarPaciente = new System.Windows.Forms.Button();
            this.ultraDropDownPrepagos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.prepagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrepagos = new Cabina.WS.DsPrepagos();
            this.ultraGroupBoxContrato = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraComboContratos = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsContratosLista = new Cabina.WS.DsContratosLista();
            this.ultraTextEditorCondContrato = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.buttonBuscarContrato = new System.Windows.Forms.Button();
            this.ultraGroupBoxTelefono = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraDateTimeEditorTomada = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraGroupBoxPractica = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraComboPracticas = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.practicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPracticas = new Cabina.WS.DsPracticas();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraGrid2 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.buttonAtencionesAnteriores = new System.Windows.Forms.Button();
            this.ultraGroupBoxDirecciónDestino = new Infragistics.Win.Misc.UltraGroupBox();
            this.checkBoxRetorno = new System.Windows.Forms.CheckBox();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraComboLugarDestino = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.UltraGridDireccionDestino = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSourceDireccionDestino = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDropDownLocalidad1 = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownBarrios1 = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownCalles1 = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDataSourcePrestaciones = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGridPrestaciones = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTelefonoNoEncontrado = new System.Windows.Forms.Label();
            this.tiposDeDestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDestino = new Cabina.WS.DsTiposDeDestino();
            this.dsBuscarTelefono = new Cabina.WS.DsBuscarTelefono();
            this.dsDireccionLugar = new Cabina.WS.DsDireccionLugar();
            this.buscarAfiliadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBuscarAfiliados = new Cabina.WS.DsBuscarAfiliados();
            this.dsSistemas1 = new Cabina.WS.DsSistemas();
            this.dsPacientesPrestacion1 = new Cabina.WS.DsPacientesPrestacion();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGridDireccionOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceDireccioneOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxDirección)).BeginInit();
            this.ultraGroupBoxDirección.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraComboLugarOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugaresLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidades1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxCobertura)).BeginInit();
            this.ultraGroupBoxCobertura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCobertura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoberturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxPaciente)).BeginInit();
            this.ultraGroupBoxPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourcePaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxContrato)).BeginInit();
            this.ultraGroupBoxContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorCondContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxTelefono)).BeginInit();
            this.ultraGroupBoxTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorTomada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxPractica)).BeginInit();
            this.ultraGroupBoxPractica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxDirecciónDestino)).BeginInit();
            this.ultraGroupBoxDirecciónDestino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboLugarDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGridDireccionDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceDireccionDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourcePrestaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridPrestaciones)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDireccionLugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAfiliadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarAfiliados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPacientesPrestacion1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(889, 7);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(79, 7);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAtencionesAnteriores);
            this.panel1.Location = new System.Drawing.Point(17, 626);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Size = new System.Drawing.Size(979, 35);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAtencionesAnteriores, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(806, 7);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(5, 23);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 1;
            this.textBoxTelefono.Enter += new System.EventHandler(this.TextBoxTelefonoEnter);
            this.textBoxTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTelefonoKeyDown);
            this.textBoxTelefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxTelefonoKeyUp);
            this.textBoxTelefono.Leave += new System.EventHandler(this.TextBoxTelefonoLeave);
            // 
            // buttonBuscarTelefono
            // 
            this.buttonBuscarTelefono.Enabled = false;
            this.buttonBuscarTelefono.Location = new System.Drawing.Point(114, 23);
            this.buttonBuscarTelefono.Name = "buttonBuscarTelefono";
            this.buttonBuscarTelefono.Size = new System.Drawing.Size(54, 23);
            this.buttonBuscarTelefono.TabIndex = 1;
            this.buttonBuscarTelefono.TabStop = false;
            this.buttonBuscarTelefono.Text = "Buscar";
            this.buttonBuscarTelefono.UseVisualStyleBackColor = true;
            this.buttonBuscarTelefono.Click += new System.EventHandler(this.ButtonBuscarTelefonoClick);
            // 
            // UltraGridDireccionOrigen
            // 
            this.UltraGridDireccionOrigen.DataSource = this.ultraDataSourceDireccioneOrigen;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.UltraGridDireccionOrigen.DisplayLayout.Appearance = appearance1;
            this.UltraGridDireccionOrigen.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn1.Header.Caption = "Localidad";
            ultraGridColumn1.Header.VisiblePosition = 8;
            ultraGridColumn1.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn1.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(196, 0);
            ultraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(196, 0);
            ultraGridColumn1.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn1.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn1.TabIndex = 1;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn2.Header.Caption = "Calle";
            ultraGridColumn2.Header.VisiblePosition = 0;
            ultraGridColumn2.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn2.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(182, 18);
            ultraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(182, 0);
            ultraGridColumn2.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn2.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn2.TabIndex = 2;
            ultraGridColumn2.Width = 54;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.Header.Caption = "Número";
            ultraGridColumn3.Header.VisiblePosition = 1;
            ultraGridColumn3.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(96, 18);
            ultraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(96, 0);
            ultraGridColumn3.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn3.TabIndex = 3;
            ultraGridColumn3.Width = 98;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.Header.VisiblePosition = 2;
            ultraGridColumn4.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(55, 18);
            ultraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(55, 0);
            ultraGridColumn4.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn4.TabIndex = 4;
            ultraGridColumn4.Width = 98;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.Caption = "Depto.";
            ultraGridColumn5.Header.VisiblePosition = 3;
            ultraGridColumn5.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn5.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(70, 18);
            ultraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(70, 0);
            ultraGridColumn5.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn5.TabIndex = 5;
            ultraGridColumn5.Width = 98;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn6.Header.Caption = "Entre";
            ultraGridColumn6.Header.VisiblePosition = 4;
            ultraGridColumn6.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn6.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(196, 0);
            ultraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(196, 0);
            ultraGridColumn6.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn6.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn6.TabIndex = 7;
            ultraGridColumn6.Width = 83;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn7.Header.Caption = "y";
            ultraGridColumn7.Header.VisiblePosition = 5;
            ultraGridColumn7.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn7.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(182, 0);
            ultraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(182, 0);
            ultraGridColumn7.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn7.TabIndex = 8;
            ultraGridColumn7.Width = 83;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn8.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn8.Header.VisiblePosition = 6;
            ultraGridColumn8.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn8.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(283, 55);
            ultraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(283, 0);
            ultraGridColumn8.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn8.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn8.TabIndex = 6;
            ultraGridColumn8.Width = 98;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn9.Header.Caption = "Barrio";
            ultraGridColumn9.Header.VisiblePosition = 7;
            ultraGridColumn9.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn9.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(221, 0);
            ultraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(221, 0);
            ultraGridColumn9.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn9.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn9.TabIndex = 9;
            ultraGridColumn9.Width = 58;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9});
            ultraGridBand1.MaxRows = 1;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.UltraGridDireccionOrigen.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            appearance2.TextHAlignAsString = "Left";
            this.UltraGridDireccionOrigen.DisplayLayout.CaptionAppearance = appearance2;
            this.UltraGridDireccionOrigen.DisplayLayout.GroupByBox.Hidden = true;
            this.UltraGridDireccionOrigen.DisplayLayout.InterBandSpacing = 10;
            this.UltraGridDireccionOrigen.DisplayLayout.MaxBandDepth = 5;
            appearance3.BackColor = System.Drawing.SystemColors.Window;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.ActiveCellAppearance = appearance3;
            appearance4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance4.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.ActiveRowAppearance = appearance4;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance5.BackColor = System.Drawing.Color.Transparent;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.CardAreaAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Control;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.CellAppearance = appearance6;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance7.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.HeaderAppearance = appearance7;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance8.ForeColor = System.Drawing.Color.Red;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.RowSelectorAppearance = appearance8;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.SelectedCellAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance10.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.SelectedRowAppearance = appearance10;
            appearance11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.UltraGridDireccionOrigen.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance11;
            this.UltraGridDireccionOrigen.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UltraGridDireccionOrigen.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.UltraGridDireccionOrigen.DisplayLayout.UseFixedHeaders = true;
            this.UltraGridDireccionOrigen.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.UltraGridDireccionOrigen.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.UltraGridDireccionOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltraGridDireccionOrigen.Location = new System.Drawing.Point(5, 51);
            this.UltraGridDireccionOrigen.Name = "UltraGridDireccionOrigen";
            this.UltraGridDireccionOrigen.Size = new System.Drawing.Size(541, 78);
            this.UltraGridDireccionOrigen.TabIndex = 5;
            this.UltraGridDireccionOrigen.AfterEnterEditMode += new System.EventHandler(this.UltraGridDireccionOrigen_AfterEnterEditMode);
            this.UltraGridDireccionOrigen.AfterRowActivate += new System.EventHandler(this.DireccionOrigenUltraGridAfterRowActivate);
            this.UltraGridDireccionOrigen.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.DireccionesAfiliadosUltraGridCellChange);
            this.UltraGridDireccionOrigen.Enter += new System.EventHandler(this.UltraGridDireccionOrigenEnter);
            this.UltraGridDireccionOrigen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UltraGridDireccionOrigen_KeyDown);
            // 
            // ultraDataSourceDireccioneOrigen
            // 
            ultraDataColumn1.DataType = typeof(int);
            ultraDataColumn2.DataType = typeof(int);
            ultraDataColumn6.DataType = typeof(int);
            ultraDataColumn7.DataType = typeof(int);
            ultraDataColumn9.DataType = typeof(int);
            this.ultraDataSourceDireccioneOrigen.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2,
            ultraDataColumn3,
            ultraDataColumn4,
            ultraDataColumn5,
            ultraDataColumn6,
            ultraDataColumn7,
            ultraDataColumn8,
            ultraDataColumn9});
            this.ultraDataSourceDireccioneOrigen.Band.Key = "DireccionesAfiliados";
            // 
            // ultraGroupBoxDirección
            // 
            this.ultraGroupBoxDirección.Controls.Add(this.UltraGridDireccionOrigen);
            this.ultraGroupBoxDirección.Controls.Add(this.ultraLabel1);
            this.ultraGroupBoxDirección.Controls.Add(this.UltraComboLugarOrigen);
            this.ultraGroupBoxDirección.Controls.Add(this.ultraDropDownLocalidad);
            this.ultraGroupBoxDirección.Controls.Add(this.ultraDropDownBarrios);
            this.ultraGroupBoxDirección.Controls.Add(this.ultraDropDownCalles);
            appearance42.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance42.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance42.FontData.BoldAsString = "True";
            appearance42.FontData.SizeInPoints = 9F;
            appearance42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxDirección.HeaderAppearance = appearance42;
            this.ultraGroupBoxDirección.Location = new System.Drawing.Point(13, 354);
            this.ultraGroupBoxDirección.Name = "ultraGroupBoxDirección";
            this.ultraGroupBoxDirección.Size = new System.Drawing.Size(556, 132);
            this.ultraGroupBoxDirección.TabIndex = 2;
            this.ultraGroupBoxDirección.Text = "Dirección Inicial o de Salida";
            this.ultraGroupBoxDirección.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(5, 29);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(36, 14);
            this.ultraLabel1.TabIndex = 15;
            this.ultraLabel1.Text = "Lugar:";
            // 
            // UltraComboLugarOrigen
            // 
            this.UltraComboLugarOrigen.DataSource = this.lugaresListaBindingSource;
            ultraGridColumn10.Header.VisiblePosition = 0;
            ultraGridColumn11.Header.VisiblePosition = 1;
            ultraGridColumn12.Header.Caption = "Dirección";
            ultraGridColumn12.Header.VisiblePosition = 2;
            ultraGridColumn13.Header.VisiblePosition = 3;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.Header.VisiblePosition = 4;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.Header.VisiblePosition = 5;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.Header.VisiblePosition = 6;
            ultraGridColumn16.Hidden = true;
            ultraGridColumn17.Header.VisiblePosition = 7;
            ultraGridColumn18.Header.VisiblePosition = 8;
            ultraGridColumn18.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18});
            this.UltraComboLugarOrigen.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.UltraComboLugarOrigen.DisplayMember = "Nombre";
            this.UltraComboLugarOrigen.Location = new System.Drawing.Point(47, 25);
            this.UltraComboLugarOrigen.Name = "UltraComboLugarOrigen";
            this.UltraComboLugarOrigen.Size = new System.Drawing.Size(300, 22);
            this.UltraComboLugarOrigen.TabIndex = 4;
            this.UltraComboLugarOrigen.Text = "Si es un lugar de la base de datos, elíjalo aquí.";
            this.UltraComboLugarOrigen.ValueMember = "idLugar";
            this.UltraComboLugarOrigen.AfterCloseUp += new System.EventHandler(this.UltraComboLugarOrigenAfterCloseUp);
            // 
            // lugaresListaBindingSource
            // 
            this.lugaresListaBindingSource.DataMember = "LugaresLista";
            this.lugaresListaBindingSource.DataSource = this.dsLugaresLista;
            // 
            // dsLugaresLista
            // 
            this.dsLugaresLista.DataSetName = "DsLugaresLista";
            this.dsLugaresLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownLocalidad
            // 
            this.ultraDropDownLocalidad.DataSource = this.localidadesBindingSource;
            appearance137.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance137.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance137.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidad.DisplayLayout.Appearance = appearance137;
            this.ultraDropDownLocalidad.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn19.Header.VisiblePosition = 1;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn19.Width = 51;
            ultraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn20.Header.VisiblePosition = 0;
            ultraGridColumn20.Width = 219;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn19,
            ultraGridColumn20});
            this.ultraDropDownLocalidad.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownLocalidad.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidad.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidad.DisplayLayout.MaxBandDepth = 5;
            appearance138.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveCellAppearance = appearance138;
            appearance139.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance139.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance139.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance139.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveRowAppearance = appearance139;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance140.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CardAreaAppearance = appearance140;
            appearance141.BackColor = System.Drawing.SystemColors.Control;
            appearance141.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance141.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CellAppearance = appearance141;
            this.ultraDropDownLocalidad.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance142.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance142.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance142.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance142.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance142.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderAppearance = appearance142;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance143.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSelectorAppearance = appearance143;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedCellAppearance = appearance66;
            appearance123.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance123.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance123.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedRowAppearance = appearance123;
            appearance124.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance124.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidad.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance124;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidad.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidad.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidad.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidad.DropDownWidth = 0;
            this.ultraDropDownLocalidad.Location = new System.Drawing.Point(15, 64);
            this.ultraDropDownLocalidad.Name = "ultraDropDownLocalidad";
            this.ultraDropDownLocalidad.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownLocalidad.TabIndex = 2;
            this.ultraDropDownLocalidad.TabStop = false;
            this.ultraDropDownLocalidad.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidad.Visible = false;
            this.ultraDropDownLocalidad.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownLocalidadRowSelected);
            // 
            // localidadesBindingSource
            // 
            this.localidadesBindingSource.DataMember = "Localidades";
            this.localidadesBindingSource.DataSource = this.dsLocalidades1;
            // 
            // dsLocalidades1
            // 
            this.dsLocalidades1.DataSetName = "DsLocalidades";
            this.dsLocalidades1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownBarrios
            // 
            this.ultraDropDownBarrios.DataSource = this.barriosListaBindingSource;
            appearance125.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance125.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance125.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrios.DisplayLayout.Appearance = appearance125;
            this.ultraDropDownBarrios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn21.Header.VisiblePosition = 0;
            ultraGridColumn21.Hidden = true;
            ultraGridColumn21.Width = 57;
            ultraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn22.Header.VisiblePosition = 1;
            ultraGridColumn22.Width = 219;
            ultraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn23.Header.VisiblePosition = 2;
            ultraGridColumn23.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23});
            this.ultraDropDownBarrios.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownBarrios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBarrios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBarrios.DisplayLayout.MaxBandDepth = 5;
            appearance126.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveCellAppearance = appearance126;
            appearance127.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance127.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance127.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance127.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveRowAppearance = appearance127;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance128.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.CardAreaAppearance = appearance128;
            appearance129.BackColor = System.Drawing.SystemColors.Control;
            appearance129.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.CellAppearance = appearance129;
            this.ultraDropDownBarrios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance130.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance130.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance130.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance130.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance130.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderAppearance = appearance130;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance131.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSelectorAppearance = appearance131;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance154.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedCellAppearance = appearance154;
            appearance155.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance155.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance155.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedRowAppearance = appearance155;
            appearance156.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance156.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBarrios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance156;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBarrios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBarrios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBarrios.DisplayMember = "Nombre";
            this.ultraDropDownBarrios.DropDownWidth = 0;
            this.ultraDropDownBarrios.Location = new System.Drawing.Point(285, 92);
            this.ultraDropDownBarrios.Name = "ultraDropDownBarrios";
            this.ultraDropDownBarrios.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownBarrios.TabIndex = 14;
            this.ultraDropDownBarrios.TabStop = false;
            this.ultraDropDownBarrios.ValueMember = "idBarrio";
            this.ultraDropDownBarrios.Visible = false;
            this.ultraDropDownBarrios.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownBarriosFilterRow);
            // 
            // barriosListaBindingSource
            // 
            this.barriosListaBindingSource.DataMember = "BarriosLista";
            this.barriosListaBindingSource.DataSource = this.dsBarrios;
            // 
            // dsBarrios
            // 
            this.dsBarrios.DataSetName = "DsBarrios";
            this.dsBarrios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCalles
            // 
            this.ultraDropDownCalles.DataSource = this.callesBindingSource;
            appearance157.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance157.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance157.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalles.DisplayLayout.Appearance = appearance157;
            this.ultraDropDownCalles.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn24.Header.VisiblePosition = 0;
            ultraGridColumn24.Hidden = true;
            ultraGridColumn24.Width = 37;
            ultraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn25.Header.VisiblePosition = 1;
            ultraGridColumn25.Hidden = true;
            ultraGridColumn25.Width = 69;
            ultraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn26.Header.VisiblePosition = 2;
            ultraGridColumn26.Hidden = true;
            ultraGridColumn26.Width = 48;
            ultraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn27.Header.VisiblePosition = 3;
            ultraGridColumn27.Width = 219;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27});
            this.ultraDropDownCalles.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownCalles.DisplayLayout.ColScrollRegions.Add(colScrollRegion1);
            this.ultraDropDownCalles.DisplayLayout.ColScrollRegions.Add(colScrollRegion2);
            this.ultraDropDownCalles.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCalles.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCalles.DisplayLayout.MaxBandDepth = 5;
            appearance158.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCalles.DisplayLayout.Override.ActiveCellAppearance = appearance158;
            appearance159.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance159.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance159.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance159.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCalles.DisplayLayout.Override.ActiveRowAppearance = appearance159;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance160.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCalles.DisplayLayout.Override.CardAreaAppearance = appearance160;
            appearance161.BackColor = System.Drawing.SystemColors.Control;
            appearance161.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance161.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalles.DisplayLayout.Override.CellAppearance = appearance161;
            this.ultraDropDownCalles.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance162.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance162.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance162.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance162.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance162.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCalles.DisplayLayout.Override.HeaderAppearance = appearance162;
            this.ultraDropDownCalles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance163.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCalles.DisplayLayout.Override.RowSelectorAppearance = appearance163;
            this.ultraDropDownCalles.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance164.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCalles.DisplayLayout.Override.SelectedCellAppearance = appearance164;
            appearance165.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance165.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance165.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalles.DisplayLayout.Override.SelectedRowAppearance = appearance165;
            appearance166.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance166.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCalles.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance166;
            this.ultraDropDownCalles.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCalles.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCalles.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCalles.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCalles.DisplayMember = "Nombre";
            this.ultraDropDownCalles.DropDownWidth = 0;
            this.ultraDropDownCalles.Location = new System.Drawing.Point(285, 64);
            this.ultraDropDownCalles.Name = "ultraDropDownCalles";
            this.ultraDropDownCalles.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownCalles.TabIndex = 12;
            this.ultraDropDownCalles.TabStop = false;
            this.ultraDropDownCalles.ValueMember = "idCalle";
            this.ultraDropDownCalles.Visible = false;
            this.ultraDropDownCalles.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCallesFilterRow);
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
            // ultraGroupBoxCobertura
            // 
            this.ultraGroupBoxCobertura.Controls.Add(this.ultraComboCobertura);
            appearance53.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance53.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance53.FontData.BoldAsString = "True";
            appearance53.FontData.SizeInPoints = 9F;
            appearance53.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxCobertura.HeaderAppearance = appearance53;
            this.ultraGroupBoxCobertura.Location = new System.Drawing.Point(826, 13);
            this.ultraGroupBoxCobertura.Name = "ultraGroupBoxCobertura";
            this.ultraGroupBoxCobertura.Size = new System.Drawing.Size(161, 51);
            this.ultraGroupBoxCobertura.TabIndex = 6;
            this.ultraGroupBoxCobertura.Text = "Cobertura";
            this.ultraGroupBoxCobertura.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraComboCobertura
            // 
            this.ultraComboCobertura.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboCobertura.DataSource = this.coberturasBindingSource;
            appearance43.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance43.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboCobertura.DisplayLayout.Appearance = appearance43;
            this.ultraComboCobertura.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn28.Header.VisiblePosition = 0;
            ultraGridColumn28.Hidden = true;
            ultraGridColumn28.Width = 57;
            ultraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn29.Header.VisiblePosition = 1;
            ultraGridColumn29.Width = 131;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn28,
            ultraGridColumn29});
            this.ultraComboCobertura.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraComboCobertura.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboCobertura.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboCobertura.DisplayLayout.MaxBandDepth = 5;
            appearance44.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboCobertura.DisplayLayout.Override.ActiveCellAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance45.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance45.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboCobertura.DisplayLayout.Override.ActiveRowAppearance = appearance45;
            this.ultraComboCobertura.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboCobertura.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboCobertura.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboCobertura.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboCobertura.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboCobertura.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboCobertura.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance46.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboCobertura.DisplayLayout.Override.CardAreaAppearance = appearance46;
            appearance47.BackColor = System.Drawing.SystemColors.Control;
            appearance47.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboCobertura.DisplayLayout.Override.CellAppearance = appearance47;
            this.ultraComboCobertura.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance48.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance48.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance48.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance48.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboCobertura.DisplayLayout.Override.HeaderAppearance = appearance48;
            this.ultraComboCobertura.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance49.ForeColor = System.Drawing.Color.Red;
            this.ultraComboCobertura.DisplayLayout.Override.RowSelectorAppearance = appearance49;
            this.ultraComboCobertura.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboCobertura.DisplayLayout.Override.SelectedCellAppearance = appearance50;
            appearance51.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance51.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboCobertura.DisplayLayout.Override.SelectedRowAppearance = appearance51;
            appearance52.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboCobertura.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance52;
            this.ultraComboCobertura.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboCobertura.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboCobertura.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboCobertura.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboCobertura.DisplayMember = "Nombre";
            this.ultraComboCobertura.LimitToList = true;
            this.ultraComboCobertura.Location = new System.Drawing.Point(6, 24);
            this.ultraComboCobertura.Name = "ultraComboCobertura";
            this.ultraComboCobertura.Size = new System.Drawing.Size(150, 22);
            this.ultraComboCobertura.TabIndex = 9;
            this.ultraComboCobertura.ValueMember = "idCobertura";
            this.ultraComboCobertura.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboCoberturaRowSelected);
            this.ultraComboCobertura.ItemNotInList += new Infragistics.Win.UltraWinGrid.ItemNotInListEventHandler(this.UltraComboCoberturaItemNotInList);
            // 
            // coberturasBindingSource
            // 
            this.coberturasBindingSource.DataMember = "Coberturas";
            this.coberturasBindingSource.DataSource = this.dsCoberturas;
            // 
            // dsCoberturas
            // 
            this.dsCoberturas.DataSetName = "DsCoberturas";
            this.dsCoberturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraGroupBoxPaciente
            // 
            this.ultraGroupBoxPaciente.Controls.Add(this.ultraGridPaciente);
            this.ultraGroupBoxPaciente.Controls.Add(this.ultraDropDownTiposDeDocumento);
            this.ultraGroupBoxPaciente.Controls.Add(this.buttonBuscarPaciente);
            this.ultraGroupBoxPaciente.Controls.Add(this.ultraDropDownPrepagos);
            appearance77.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance77.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance77.FontData.BoldAsString = "True";
            appearance77.FontData.SizeInPoints = 9F;
            appearance77.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxPaciente.HeaderAppearance = appearance77;
            this.ultraGroupBoxPaciente.Location = new System.Drawing.Point(12, 68);
            this.ultraGroupBoxPaciente.Name = "ultraGroupBoxPaciente";
            this.ultraGroupBoxPaciente.Size = new System.Drawing.Size(556, 176);
            this.ultraGroupBoxPaciente.TabIndex = 4;
            this.ultraGroupBoxPaciente.Text = "Paciente";
            this.ultraGroupBoxPaciente.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraGridPaciente
            // 
            this.ultraGridPaciente.DataSource = this.ultraDataSourcePaciente;
            appearance54.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance54.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridPaciente.DisplayLayout.Appearance = appearance54;
            this.ultraGridPaciente.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn30.DefaultCellValue = "False";
            ultraGridColumn30.Header.Caption = "Lista";
            ultraGridColumn30.Header.VisiblePosition = 0;
            ultraGridColumn30.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn30.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(39, 0);
            ultraGridColumn30.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(39, 0);
            ultraGridColumn30.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn30.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn30.TabStop = false;
            ultraGridColumn30.Width = 45;
            ultraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn31.Header.Caption = "Apellido, Nombre";
            ultraGridColumn31.Header.VisiblePosition = 1;
            ultraGridColumn31.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn31.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn31.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(153, 0);
            ultraGridColumn31.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(153, 0);
            ultraGridColumn31.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn31.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn31.TabIndex = 1;
            ultraGridColumn31.Width = 70;
            ultraGridColumn32.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance55.TextHAlignAsString = "Right";
            ultraGridColumn32.CellAppearance = appearance55;
            ultraGridColumn32.Header.VisiblePosition = 2;
            ultraGridColumn32.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn32.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn32.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(38, 0);
            ultraGridColumn32.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(38, 0);
            ultraGridColumn32.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn32.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn32.TabIndex = 4;
            ultraGridColumn32.Width = 33;
            ultraGridColumn33.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn33.Header.Caption = "Edad en";
            ultraGridColumn33.Header.VisiblePosition = 3;
            ultraGridColumn33.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn33.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(52, 0);
            ultraGridColumn33.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn33.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn33.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn33.TabIndex = 5;
            ultraGridColumn33.Width = 70;
            ultraGridColumn34.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn34.Header.VisiblePosition = 4;
            ultraGridColumn34.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn34.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(60, 0);
            ultraGridColumn34.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(60, 0);
            ultraGridColumn34.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn34.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn34.TabIndex = 6;
            ultraGridColumn34.Width = 70;
            ultraGridColumn35.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn35.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn35.Header.VisiblePosition = 5;
            ultraGridColumn35.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn35.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(449, 57);
            ultraGridColumn35.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(449, 0);
            ultraGridColumn35.RowLayoutColumnInfo.SpanX = 16;
            ultraGridColumn35.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn35.TabIndex = 11;
            ultraGridColumn35.Width = 70;
            ultraGridColumn36.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn36.Header.Caption = "O. Social ó Prepago";
            ultraGridColumn36.Header.VisiblePosition = 6;
            ultraGridColumn36.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn36.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(260, 0);
            ultraGridColumn36.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(260, 0);
            ultraGridColumn36.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn36.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn36.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn36.TabIndex = 7;
            ultraGridColumn37.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn37.Header.Caption = "Nº Af. Prepago";
            ultraGridColumn37.Header.VisiblePosition = 7;
            ultraGridColumn37.MaxLength = 50;
            ultraGridColumn37.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn37.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn37.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(90, 0);
            ultraGridColumn37.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(90, 0);
            ultraGridColumn37.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn37.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn37.TabIndex = 8;
            ultraGridColumn38.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance56.TextHAlignAsString = "Right";
            ultraGridColumn38.CellAppearance = appearance56;
            ultraGridColumn38.Header.VisiblePosition = 8;
            ultraGridColumn38.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn38.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn38.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn38.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(60, 0);
            ultraGridColumn38.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(60, 0);
            ultraGridColumn38.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn38.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn38.TabIndex = 9;
            ultraGridColumn39.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn39.Header.VisiblePosition = 9;
            ultraGridColumn39.Hidden = true;
            ultraGridColumn39.TabStop = false;
            ultraGridColumn40.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn40.DefaultCellValue = "False";
            ultraGridColumn40.Header.Caption = "Extra";
            ultraGridColumn40.Header.VisiblePosition = 10;
            ultraGridColumn40.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn40.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn40.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(39, 0);
            ultraGridColumn40.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(39, 0);
            ultraGridColumn40.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn40.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn40.TabIndex = 10;
            ultraGridColumn41.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn41.Header.Caption = "Doc";
            ultraGridColumn41.Header.VisiblePosition = 11;
            ultraGridColumn41.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn41.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn41.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(30, 0);
            ultraGridColumn41.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(30, 0);
            ultraGridColumn41.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn41.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn41.TabIndex = 2;
            appearance78.TextHAlignAsString = "Right";
            ultraGridColumn42.CellAppearance = appearance78;
            ultraGridColumn42.Header.Caption = "N° Doc";
            ultraGridColumn42.Header.VisiblePosition = 12;
            ultraGridColumn42.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn42.MaskInput = "{LOC}nnn,nnn,nnn,nnn";
            ultraGridColumn42.MaxLength = 9;
            ultraGridColumn42.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn42.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn42.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(77, 0);
            ultraGridColumn42.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(77, 0);
            ultraGridColumn42.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn42.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn42.TabIndex = 3;
            ultraGridColumn43.Header.VisiblePosition = 13;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn44.Header.VisiblePosition = 14;
            ultraGridColumn44.Hidden = true;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35,
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40,
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44});
            ultraGridBand7.MaxRows = 1;
            ultraGridBand7.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand7.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraGridPaciente.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraGridPaciente.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraGridPaciente.DisplayLayout.InterBandSpacing = 10;
            this.ultraGridPaciente.DisplayLayout.MaxBandDepth = 5;
            appearance57.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGridPaciente.DisplayLayout.Override.ActiveCellAppearance = appearance57;
            appearance58.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance58.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance58.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraGridPaciente.DisplayLayout.Override.ActiveRowAppearance = appearance58;
            this.ultraGridPaciente.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraGridPaciente.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGridPaciente.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridPaciente.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraGridPaciente.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridPaciente.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraGridPaciente.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance59.BackColor = System.Drawing.Color.Transparent;
            this.ultraGridPaciente.DisplayLayout.Override.CardAreaAppearance = appearance59;
            appearance60.BackColor = System.Drawing.SystemColors.Control;
            appearance60.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridPaciente.DisplayLayout.Override.CellAppearance = appearance60;
            this.ultraGridPaciente.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance61.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance61.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance61.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance61.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGridPaciente.DisplayLayout.Override.HeaderAppearance = appearance61;
            this.ultraGridPaciente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance62.ForeColor = System.Drawing.Color.Red;
            this.ultraGridPaciente.DisplayLayout.Override.RowSelectorAppearance = appearance62;
            this.ultraGridPaciente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridPaciente.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGridPaciente.DisplayLayout.Override.SelectedCellAppearance = appearance63;
            appearance64.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance64.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridPaciente.DisplayLayout.Override.SelectedRowAppearance = appearance64;
            appearance65.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance65.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraGridPaciente.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance65;
            this.ultraGridPaciente.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraGridPaciente.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGridPaciente.DisplayLayout.UseFixedHeaders = true;
            this.ultraGridPaciente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGridPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGridPaciente.Location = new System.Drawing.Point(5, 23);
            this.ultraGridPaciente.Name = "ultraGridPaciente";
            this.ultraGridPaciente.Size = new System.Drawing.Size(481, 148);
            this.ultraGridPaciente.TabIndex = 2;
            this.ultraGridPaciente.AfterEnterEditMode += new System.EventHandler(this.UltraGridPacienteAfterEnterEditMode);
            this.ultraGridPaciente.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.UltraGridPacienteCellChange);
            this.ultraGridPaciente.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.UltraGridPacienteBeforeCellDeactivate);
            this.ultraGridPaciente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraGridPaciente_KeyDown);
            this.ultraGridPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UltraGridPacienteKeyPress);
            // 
            // ultraDataSourcePaciente
            // 
            ultraDataColumn10.DataType = typeof(bool);
            ultraDataColumn12.DataType = typeof(int);
            ultraDataColumn16.DataType = typeof(int);
            ultraDataColumn18.DataType = typeof(decimal);
            ultraDataColumn18.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            ultraDataColumn19.DataType = typeof(int);
            ultraDataColumn20.DataType = typeof(bool);
            ultraDataColumn20.DefaultValue = false;
            ultraDataColumn21.DataType = typeof(int);
            ultraDataColumn23.DataType = typeof(decimal);
            ultraDataColumn24.DataType = typeof(int);
            this.ultraDataSourcePaciente.Band.Columns.AddRange(new object[] {
            ultraDataColumn10,
            ultraDataColumn11,
            ultraDataColumn12,
            ultraDataColumn13,
            ultraDataColumn14,
            ultraDataColumn15,
            ultraDataColumn16,
            ultraDataColumn17,
            ultraDataColumn18,
            ultraDataColumn19,
            ultraDataColumn20,
            ultraDataColumn21,
            ultraDataColumn22,
            ultraDataColumn23,
            ultraDataColumn24});
            // 
            // ultraDropDownTiposDeDocumento
            // 
            this.ultraDropDownTiposDeDocumento.DataSource = this.tiposDeDocumentoBindingSource;
            appearance144.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance144.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance144.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Appearance = appearance144;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn45.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn45.Header.VisiblePosition = 0;
            ultraGridColumn45.Hidden = true;
            ultraGridColumn45.Width = 85;
            ultraGridColumn46.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn46.Header.VisiblePosition = 1;
            ultraGridColumn46.Hidden = true;
            ultraGridColumn46.Width = 231;
            ultraGridColumn47.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn47.Header.VisiblePosition = 2;
            ultraGridColumn47.Width = 231;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn45,
            ultraGridColumn46,
            ultraGridColumn47});
            this.ultraDropDownTiposDeDocumento.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraDropDownTiposDeDocumento.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.MaxBandDepth = 5;
            appearance145.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.ActiveCellAppearance = appearance145;
            appearance146.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance146.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance146.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance146.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.ActiveRowAppearance = appearance146;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance147.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.CardAreaAppearance = appearance147;
            appearance148.BackColor = System.Drawing.SystemColors.Control;
            appearance148.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance148.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.CellAppearance = appearance148;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance149.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance149.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance149.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance149.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance149.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.HeaderAppearance = appearance149;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance150.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.RowSelectorAppearance = appearance150;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance151.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.SelectedCellAppearance = appearance151;
            appearance152.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance152.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance152.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.SelectedRowAppearance = appearance152;
            appearance153.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance153.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance153;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeDocumento.DisplayMember = "Iniciales";
            this.ultraDropDownTiposDeDocumento.DropDownWidth = 250;
            this.ultraDropDownTiposDeDocumento.Location = new System.Drawing.Point(182, 122);
            this.ultraDropDownTiposDeDocumento.Name = "ultraDropDownTiposDeDocumento";
            this.ultraDropDownTiposDeDocumento.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeDocumento.TabIndex = 54;
            this.ultraDropDownTiposDeDocumento.ValueMember = "idTipoDeDocumento";
            this.ultraDropDownTiposDeDocumento.Visible = false;
            // 
            // tiposDeDocumentoBindingSource
            // 
            this.tiposDeDocumentoBindingSource.DataMember = "TiposDeDocumento";
            this.tiposDeDocumentoBindingSource.DataSource = this.dsTiposDeDocumento;
            // 
            // dsTiposDeDocumento
            // 
            this.dsTiposDeDocumento.DataSetName = "DsTiposDeDocumento";
            this.dsTiposDeDocumento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonBuscarPaciente
            // 
            this.buttonBuscarPaciente.Location = new System.Drawing.Point(492, 28);
            this.buttonBuscarPaciente.Name = "buttonBuscarPaciente";
            this.buttonBuscarPaciente.Size = new System.Drawing.Size(54, 23);
            this.buttonBuscarPaciente.TabIndex = 5;
            this.buttonBuscarPaciente.TabStop = false;
            this.buttonBuscarPaciente.Text = "Buscar";
            this.buttonBuscarPaciente.UseVisualStyleBackColor = true;
            this.buttonBuscarPaciente.Click += new System.EventHandler(this.ButtonBuscarPacienteClick);
            // 
            // ultraDropDownPrepagos
            // 
            this.ultraDropDownPrepagos.DataSource = this.prepagosBindingSource;
            appearance67.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance67.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrepagos.DisplayLayout.Appearance = appearance67;
            this.ultraDropDownPrepagos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand9.ColHeadersVisible = false;
            ultraGridColumn48.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn48.Header.VisiblePosition = 0;
            ultraGridColumn48.Hidden = true;
            ultraGridColumn48.Width = 55;
            ultraGridColumn49.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn49.Header.VisiblePosition = 1;
            ultraGridColumn49.Width = 219;
            ultraGridColumn50.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn50.Header.VisiblePosition = 2;
            ultraGridColumn50.Hidden = true;
            ultraGridColumn50.Width = 109;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50});
            this.ultraDropDownPrepagos.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraDropDownPrepagos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrepagos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrepagos.DisplayLayout.MaxBandDepth = 5;
            appearance68.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveCellAppearance = appearance68;
            appearance69.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance69.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance69.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveRowAppearance = appearance69;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance70.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CardAreaAppearance = appearance70;
            appearance71.BackColor = System.Drawing.SystemColors.Control;
            appearance71.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CellAppearance = appearance71;
            this.ultraDropDownPrepagos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance72.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance72.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance72.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance72.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance72.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderAppearance = appearance72;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance73.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSelectorAppearance = appearance73;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedCellAppearance = appearance74;
            appearance75.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance75.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedRowAppearance = appearance75;
            appearance76.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance76.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrepagos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance76;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrepagos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrepagos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrepagos.DisplayMember = "Nombre";
            this.ultraDropDownPrepagos.DropDownWidth = 0;
            this.ultraDropDownPrepagos.Location = new System.Drawing.Point(182, 81);
            this.ultraDropDownPrepagos.Name = "ultraDropDownPrepagos";
            this.ultraDropDownPrepagos.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPrepagos.TabIndex = 16;
            this.ultraDropDownPrepagos.TabStop = false;
            this.ultraDropDownPrepagos.ValueMember = "idPrepago";
            this.ultraDropDownPrepagos.Visible = false;
            // 
            // prepagosBindingSource
            // 
            this.prepagosBindingSource.DataSource = this.dsPrepagos;
            this.prepagosBindingSource.Position = 0;
            // 
            // dsPrepagos
            // 
            this.dsPrepagos.DataSetName = "DsPrepagos";
            this.dsPrepagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraGroupBoxContrato
            // 
            this.ultraGroupBoxContrato.Controls.Add(this.ultraComboContratos);
            this.ultraGroupBoxContrato.Controls.Add(this.ultraTextEditorCondContrato);
            this.ultraGroupBoxContrato.Controls.Add(this.buttonBuscarContrato);
            appearance88.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance88.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance88.FontData.BoldAsString = "True";
            appearance88.FontData.SizeInPoints = 9F;
            appearance88.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxContrato.HeaderAppearance = appearance88;
            this.ultraGroupBoxContrato.Location = new System.Drawing.Point(13, 245);
            this.ultraGroupBoxContrato.Name = "ultraGroupBoxContrato";
            this.ultraGroupBoxContrato.Size = new System.Drawing.Size(556, 107);
            this.ultraGroupBoxContrato.TabIndex = 8;
            this.ultraGroupBoxContrato.Text = "Contrato";
            this.ultraGroupBoxContrato.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraComboContratos
            // 
            this.ultraComboContratos.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboContratos.DataSource = this.contratosBindingSource;
            appearance190.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance190.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance190.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboContratos.DisplayLayout.Appearance = appearance190;
            this.ultraComboContratos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand10.ColHeadersVisible = false;
            ultraGridColumn51.Header.VisiblePosition = 0;
            ultraGridColumn51.Hidden = true;
            ultraGridColumn51.Width = 244;
            ultraGridColumn52.Header.VisiblePosition = 1;
            ultraGridColumn52.Hidden = true;
            ultraGridColumn52.Width = 380;
            ultraGridColumn53.Header.VisiblePosition = 2;
            ultraGridColumn53.Hidden = true;
            ultraGridColumn53.Width = 167;
            ultraGridColumn54.Header.VisiblePosition = 3;
            ultraGridColumn54.Hidden = true;
            ultraGridColumn54.Width = 146;
            ultraGridColumn55.Header.VisiblePosition = 4;
            ultraGridColumn55.Width = 461;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55});
            this.ultraComboContratos.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraComboContratos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboContratos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance191.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance191.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance191.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance191.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboContratos.DisplayLayout.GroupByBox.Appearance = appearance191;
            appearance192.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboContratos.DisplayLayout.GroupByBox.BandLabelAppearance = appearance192;
            this.ultraComboContratos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboContratos.DisplayLayout.GroupByBox.Hidden = true;
            appearance193.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance193.BackColor2 = System.Drawing.SystemColors.Control;
            appearance193.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance193.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboContratos.DisplayLayout.GroupByBox.PromptAppearance = appearance193;
            this.ultraComboContratos.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboContratos.DisplayLayout.MaxBandDepth = 5;
            this.ultraComboContratos.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboContratos.DisplayLayout.MaxRowScrollRegions = 1;
            appearance178.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboContratos.DisplayLayout.Override.ActiveCellAppearance = appearance178;
            appearance179.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance179.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance179.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboContratos.DisplayLayout.Override.ActiveRowAppearance = appearance179;
            this.ultraComboContratos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboContratos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboContratos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboContratos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboContratos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboContratos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboContratos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboContratos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboContratos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance180.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboContratos.DisplayLayout.Override.CardAreaAppearance = appearance180;
            appearance181.BackColor = System.Drawing.SystemColors.Control;
            appearance181.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance181.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboContratos.DisplayLayout.Override.CellAppearance = appearance181;
            this.ultraComboContratos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboContratos.DisplayLayout.Override.CellPadding = 0;
            this.ultraComboContratos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance182.BackColor = System.Drawing.SystemColors.Control;
            appearance182.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance182.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance182.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance182.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboContratos.DisplayLayout.Override.GroupByRowAppearance = appearance182;
            appearance183.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance183.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance183.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance183.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance183.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboContratos.DisplayLayout.Override.HeaderAppearance = appearance183;
            this.ultraComboContratos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboContratos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance184.BackColor = System.Drawing.SystemColors.Window;
            appearance184.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboContratos.DisplayLayout.Override.RowAppearance = appearance184;
            appearance185.ForeColor = System.Drawing.Color.Red;
            this.ultraComboContratos.DisplayLayout.Override.RowSelectorAppearance = appearance185;
            this.ultraComboContratos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboContratos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance186.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboContratos.DisplayLayout.Override.SelectedCellAppearance = appearance186;
            appearance187.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance187.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance187.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboContratos.DisplayLayout.Override.SelectedRowAppearance = appearance187;
            appearance188.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboContratos.DisplayLayout.Override.TemplateAddRowAppearance = appearance188;
            appearance189.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance189.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboContratos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance189;
            this.ultraComboContratos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboContratos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboContratos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboContratos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboContratos.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboContratos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboContratos.DisplayMember = "Contrato";
            this.ultraComboContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraComboContratos.LimitToList = true;
            this.ultraComboContratos.Location = new System.Drawing.Point(5, 25);
            this.ultraComboContratos.Name = "ultraComboContratos";
            this.ultraComboContratos.Size = new System.Drawing.Size(480, 22);
            this.ultraComboContratos.TabIndex = 3;
            this.ultraComboContratos.ValueMember = "idContrato";
            this.ultraComboContratos.ValueChanged += new System.EventHandler(this.UltraComboContratosValueChanged);
            this.ultraComboContratos.ItemNotInList += new Infragistics.Win.UltraWinGrid.ItemNotInListEventHandler(this.UltraComboContratosItemNotInList);
            // 
            // contratosBindingSource
            // 
            this.contratosBindingSource.DataMember = "ContratosRenglonFactura";
            this.contratosBindingSource.DataSource = this.dsContratosLista;
            // 
            // dsContratosLista
            // 
            this.dsContratosLista.DataSetName = "DsContratosLista";
            this.dsContratosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraTextEditorCondContrato
            // 
            this.ultraTextEditorCondContrato.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.VisualStudio2005;
            this.ultraTextEditorCondContrato.Location = new System.Drawing.Point(5, 50);
            this.ultraTextEditorCondContrato.Multiline = true;
            this.ultraTextEditorCondContrato.Name = "ultraTextEditorCondContrato";
            this.ultraTextEditorCondContrato.ReadOnly = true;
            this.ultraTextEditorCondContrato.Size = new System.Drawing.Size(481, 52);
            this.ultraTextEditorCondContrato.TabIndex = 6;
            this.ultraTextEditorCondContrato.TabStop = false;
            // 
            // buttonBuscarContrato
            // 
            this.buttonBuscarContrato.Location = new System.Drawing.Point(492, 24);
            this.buttonBuscarContrato.Name = "buttonBuscarContrato";
            this.buttonBuscarContrato.Size = new System.Drawing.Size(54, 23);
            this.buttonBuscarContrato.TabIndex = 5;
            this.buttonBuscarContrato.TabStop = false;
            this.buttonBuscarContrato.Text = "Buscar";
            this.buttonBuscarContrato.UseVisualStyleBackColor = true;
            this.buttonBuscarContrato.Click += new System.EventHandler(this.ButtonBuscarContratoClick);
            // 
            // ultraGroupBoxTelefono
            // 
            this.ultraGroupBoxTelefono.Controls.Add(this.buttonBuscarTelefono);
            this.ultraGroupBoxTelefono.Controls.Add(this.textBoxTelefono);
            appearance89.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance89.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance89.FontData.BoldAsString = "True";
            appearance89.FontData.SizeInPoints = 9F;
            appearance89.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxTelefono.HeaderAppearance = appearance89;
            this.ultraGroupBoxTelefono.Location = new System.Drawing.Point(12, 12);
            this.ultraGroupBoxTelefono.Name = "ultraGroupBoxTelefono";
            this.ultraGroupBoxTelefono.Size = new System.Drawing.Size(176, 52);
            this.ultraGroupBoxTelefono.TabIndex = 0;
            this.ultraGroupBoxTelefono.Text = "Teléfono";
            this.ultraGroupBoxTelefono.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraDateTimeEditorTomada
            // 
            this.ultraDateTimeEditorTomada.DateTime = new System.DateTime(1947, 1, 21, 0, 0, 0, 0);
            this.ultraDateTimeEditorTomada.Enabled = false;
            this.ultraDateTimeEditorTomada.FormatProvider = new System.Globalization.CultureInfo("es-AR");
            this.ultraDateTimeEditorTomada.Location = new System.Drawing.Point(271, 18);
            this.ultraDateTimeEditorTomada.MaskInput = "dd/mm/yyyy hh:mm:ss";
            this.ultraDateTimeEditorTomada.Name = "ultraDateTimeEditorTomada";
            this.ultraDateTimeEditorTomada.Size = new System.Drawing.Size(144, 21);
            this.ultraDateTimeEditorTomada.TabIndex = 9;
            this.ultraDateTimeEditorTomada.Value = new System.DateTime(1947, 1, 21, 0, 0, 0, 0);
            this.ultraDateTimeEditorTomada.Visible = false;
            // 
            // ultraGroupBoxPractica
            // 
            this.ultraGroupBoxPractica.Controls.Add(this.ultraComboPracticas);
            this.ultraGroupBoxPractica.Controls.Add(this.ultraGrid1);
            this.ultraGroupBoxPractica.Controls.Add(this.ultraGrid2);
            appearance100.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance100.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance100.FontData.BoldAsString = "True";
            appearance100.FontData.SizeInPoints = 9F;
            appearance100.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxPractica.HeaderAppearance = appearance100;
            this.ultraGroupBoxPractica.Location = new System.Drawing.Point(659, 13);
            this.ultraGroupBoxPractica.Name = "ultraGroupBoxPractica";
            this.ultraGroupBoxPractica.Size = new System.Drawing.Size(161, 51);
            this.ultraGroupBoxPractica.TabIndex = 7;
            this.ultraGroupBoxPractica.Text = "Práctica";
            this.ultraGroupBoxPractica.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraComboPracticas
            // 
            this.ultraComboPracticas.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboPracticas.DataSource = this.practicasBindingSource;
            appearance90.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance90.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance90.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboPracticas.DisplayLayout.Appearance = appearance90;
            this.ultraComboPracticas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand11.ColHeadersVisible = false;
            ultraGridColumn56.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn56.Header.VisiblePosition = 0;
            ultraGridColumn56.Hidden = true;
            ultraGridColumn56.Width = 53;
            ultraGridColumn57.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn57.Header.VisiblePosition = 1;
            ultraGridColumn57.Width = 131;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn56,
            ultraGridColumn57});
            this.ultraComboPracticas.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraComboPracticas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboPracticas.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboPracticas.DisplayLayout.MaxBandDepth = 5;
            appearance91.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboPracticas.DisplayLayout.Override.ActiveCellAppearance = appearance91;
            appearance92.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance92.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance92.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance92.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboPracticas.DisplayLayout.Override.ActiveRowAppearance = appearance92;
            this.ultraComboPracticas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboPracticas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboPracticas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPracticas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboPracticas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPracticas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboPracticas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance93.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboPracticas.DisplayLayout.Override.CardAreaAppearance = appearance93;
            appearance94.BackColor = System.Drawing.SystemColors.Control;
            appearance94.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance94.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboPracticas.DisplayLayout.Override.CellAppearance = appearance94;
            this.ultraComboPracticas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance95.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance95.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance95.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance95.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboPracticas.DisplayLayout.Override.HeaderAppearance = appearance95;
            this.ultraComboPracticas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance96.ForeColor = System.Drawing.Color.Red;
            this.ultraComboPracticas.DisplayLayout.Override.RowSelectorAppearance = appearance96;
            this.ultraComboPracticas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboPracticas.DisplayLayout.Override.SelectedCellAppearance = appearance97;
            appearance98.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance98.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance98.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboPracticas.DisplayLayout.Override.SelectedRowAppearance = appearance98;
            appearance99.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance99.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboPracticas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance99;
            this.ultraComboPracticas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboPracticas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboPracticas.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboPracticas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboPracticas.DisplayMember = "Nombre";
            this.ultraComboPracticas.LimitToList = true;
            this.ultraComboPracticas.Location = new System.Drawing.Point(5, 23);
            this.ultraComboPracticas.Name = "ultraComboPracticas";
            this.ultraComboPracticas.Size = new System.Drawing.Size(150, 22);
            this.ultraComboPracticas.TabIndex = 8;
            this.ultraComboPracticas.ValueMember = "idPractica";
            this.ultraComboPracticas.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboPracticasRowSelected);
            this.ultraComboPracticas.ValueChanged += new System.EventHandler(this.UltraComboPracticasValueChanged);
            this.ultraComboPracticas.ItemNotInList += new Infragistics.Win.UltraWinGrid.ItemNotInListEventHandler(this.UltraComboPracticasItemNotInList);
            // 
            // practicasBindingSource
            // 
            this.practicasBindingSource.DataMember = "Practicas";
            this.practicasBindingSource.DataSource = this.dsPracticas;
            // 
            // dsPracticas
            // 
            this.dsPracticas.DataSetName = "DsPracticas";
            this.dsPracticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraGrid1
            // 
            this.ultraGrid1.Location = new System.Drawing.Point(-28, 22);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(28, 24);
            this.ultraGrid1.TabIndex = 13;
            this.ultraGrid1.Visible = false;
            // 
            // ultraGrid2
            // 
            this.ultraGrid2.Location = new System.Drawing.Point(-28, 1);
            this.ultraGrid2.Name = "ultraGrid2";
            this.ultraGrid2.Size = new System.Drawing.Size(22, 24);
            this.ultraGrid2.TabIndex = 12;
            this.ultraGrid2.Visible = false;
            // 
            // buttonAtencionesAnteriores
            // 
            this.buttonAtencionesAnteriores.Location = new System.Drawing.Point(649, 7);
            this.buttonAtencionesAnteriores.Name = "buttonAtencionesAnteriores";
            this.buttonAtencionesAnteriores.Size = new System.Drawing.Size(150, 23);
            this.buttonAtencionesAnteriores.TabIndex = 3;
            this.buttonAtencionesAnteriores.TabStop = false;
            this.buttonAtencionesAnteriores.Text = "Atenciones Anteriores";
            this.buttonAtencionesAnteriores.UseVisualStyleBackColor = true;
            this.buttonAtencionesAnteriores.Click += new System.EventHandler(this.ButtonAtencionesAnterioresClick);
            // 
            // ultraGroupBoxDirecciónDestino
            // 
            this.ultraGroupBoxDirecciónDestino.Controls.Add(this.checkBoxRetorno);
            this.ultraGroupBoxDirecciónDestino.Controls.Add(this.ultraLabel2);
            this.ultraGroupBoxDirecciónDestino.Controls.Add(this.ultraComboLugarDestino);
            this.ultraGroupBoxDirecciónDestino.Controls.Add(this.UltraGridDireccionDestino);
            this.ultraGroupBoxDirecciónDestino.Controls.Add(this.ultraDropDownLocalidad1);
            this.ultraGroupBoxDirecciónDestino.Controls.Add(this.ultraDropDownBarrios1);
            this.ultraGroupBoxDirecciónDestino.Controls.Add(this.ultraDropDownCalles1);
            appearance112.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance112.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance112.FontData.BoldAsString = "True";
            appearance112.FontData.SizeInPoints = 9F;
            appearance112.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxDirecciónDestino.HeaderAppearance = appearance112;
            this.ultraGroupBoxDirecciónDestino.Location = new System.Drawing.Point(13, 488);
            this.ultraGroupBoxDirecciónDestino.Name = "ultraGroupBoxDirecciónDestino";
            this.ultraGroupBoxDirecciónDestino.Size = new System.Drawing.Size(556, 136);
            this.ultraGroupBoxDirecciónDestino.TabIndex = 21;
            this.ultraGroupBoxDirecciónDestino.Text = "Dirección de Destino";
            this.ultraGroupBoxDirecciónDestino.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // checkBoxRetorno
            // 
            this.checkBoxRetorno.AutoSize = true;
            this.checkBoxRetorno.Enabled = false;
            this.checkBoxRetorno.Location = new System.Drawing.Point(412, 29);
            this.checkBoxRetorno.Name = "checkBoxRetorno";
            this.checkBoxRetorno.Size = new System.Drawing.Size(124, 17);
            this.checkBoxRetorno.TabIndex = 18;
            this.checkBoxRetorno.Text = "Con espera y retorno";
            this.checkBoxRetorno.UseVisualStyleBackColor = true;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.AutoSize = true;
            this.ultraLabel2.Location = new System.Drawing.Point(5, 29);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(36, 14);
            this.ultraLabel2.TabIndex = 17;
            this.ultraLabel2.Text = "Lugar:";
            // 
            // ultraComboLugarDestino
            // 
            this.ultraComboLugarDestino.DataSource = this.lugaresListaBindingSource;
            ultraGridColumn58.Header.VisiblePosition = 0;
            ultraGridColumn59.Header.VisiblePosition = 1;
            ultraGridColumn60.Header.Caption = "Dirección";
            ultraGridColumn60.Header.VisiblePosition = 2;
            ultraGridColumn61.Header.VisiblePosition = 3;
            ultraGridColumn61.Hidden = true;
            ultraGridColumn62.Header.VisiblePosition = 4;
            ultraGridColumn62.Hidden = true;
            ultraGridColumn63.Header.VisiblePosition = 5;
            ultraGridColumn63.Hidden = true;
            ultraGridColumn64.Header.VisiblePosition = 6;
            ultraGridColumn64.Hidden = true;
            ultraGridColumn65.Header.VisiblePosition = 7;
            ultraGridColumn66.Header.VisiblePosition = 8;
            ultraGridColumn66.Hidden = true;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66});
            this.ultraComboLugarDestino.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraComboLugarDestino.DisplayMember = "Nombre";
            this.ultraComboLugarDestino.Location = new System.Drawing.Point(47, 25);
            this.ultraComboLugarDestino.Name = "ultraComboLugarDestino";
            this.ultraComboLugarDestino.Size = new System.Drawing.Size(300, 22);
            this.ultraComboLugarDestino.TabIndex = 6;
            this.ultraComboLugarDestino.Text = "Si es un lugar de la base de datos, elíjalo aquí.";
            this.ultraComboLugarDestino.ValueMember = "idLugar";
            this.ultraComboLugarDestino.AfterCloseUp += new System.EventHandler(this.UltraComboLugarDestinoAfterCloseUp);
            this.ultraComboLugarDestino.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboLugarDestinoRowSelected);
            // 
            // UltraGridDireccionDestino
            // 
            this.UltraGridDireccionDestino.DataSource = this.ultraDataSourceDireccionDestino;
            appearance101.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance101.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.UltraGridDireccionDestino.DisplayLayout.Appearance = appearance101;
            this.UltraGridDireccionDestino.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn67.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn67.Header.Caption = "Localidad";
            ultraGridColumn67.Header.VisiblePosition = 8;
            ultraGridColumn67.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn67.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn67.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(203, 0);
            ultraGridColumn67.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(203, 0);
            ultraGridColumn67.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn67.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn67.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn67.TabIndex = 1;
            ultraGridColumn68.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn68.Header.Caption = "Calle";
            ultraGridColumn68.Header.VisiblePosition = 0;
            ultraGridColumn68.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn68.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn68.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(177, 18);
            ultraGridColumn68.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(177, 0);
            ultraGridColumn68.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn68.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn68.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn68.TabIndex = 2;
            ultraGridColumn68.Width = 54;
            ultraGridColumn69.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn69.Header.Caption = "Número";
            ultraGridColumn69.Header.VisiblePosition = 1;
            ultraGridColumn69.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn69.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn69.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(100, 18);
            ultraGridColumn69.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(100, 0);
            ultraGridColumn69.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn69.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn69.TabIndex = 3;
            ultraGridColumn69.Width = 98;
            ultraGridColumn70.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn70.Header.VisiblePosition = 2;
            ultraGridColumn70.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn70.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn70.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(55, 18);
            ultraGridColumn70.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(55, 0);
            ultraGridColumn70.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn70.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn70.TabIndex = 4;
            ultraGridColumn70.Width = 98;
            ultraGridColumn71.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn71.Header.Caption = "Depto.";
            ultraGridColumn71.Header.VisiblePosition = 3;
            ultraGridColumn71.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn71.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn71.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(70, 18);
            ultraGridColumn71.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(70, 0);
            ultraGridColumn71.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn71.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn71.TabIndex = 5;
            ultraGridColumn71.Width = 98;
            ultraGridColumn72.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn72.Header.Caption = "Entre";
            ultraGridColumn72.Header.VisiblePosition = 4;
            ultraGridColumn72.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn72.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn72.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(203, 0);
            ultraGridColumn72.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(203, 0);
            ultraGridColumn72.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn72.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn72.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn72.TabIndex = 7;
            ultraGridColumn72.Width = 83;
            ultraGridColumn73.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn73.Header.Caption = "y";
            ultraGridColumn73.Header.VisiblePosition = 5;
            ultraGridColumn73.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn73.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn73.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(177, 0);
            ultraGridColumn73.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(177, 0);
            ultraGridColumn73.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn73.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn73.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn73.TabIndex = 8;
            ultraGridColumn73.Width = 83;
            ultraGridColumn74.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn74.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn74.Header.VisiblePosition = 6;
            ultraGridColumn74.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn74.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn74.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(283, 55);
            ultraGridColumn74.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(283, 0);
            ultraGridColumn74.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn74.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn74.TabIndex = 6;
            ultraGridColumn74.Width = 98;
            ultraGridColumn75.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn75.Header.Caption = "Barrio";
            ultraGridColumn75.Header.VisiblePosition = 7;
            ultraGridColumn75.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn75.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn75.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(225, 0);
            ultraGridColumn75.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(225, 0);
            ultraGridColumn75.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn75.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn75.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn75.TabIndex = 9;
            ultraGridColumn75.Width = 58;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69,
            ultraGridColumn70,
            ultraGridColumn71,
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74,
            ultraGridColumn75});
            ultraGridBand13.MaxRows = 1;
            ultraGridBand13.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand13.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.UltraGridDireccionDestino.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            appearance102.TextHAlignAsString = "Left";
            this.UltraGridDireccionDestino.DisplayLayout.CaptionAppearance = appearance102;
            this.UltraGridDireccionDestino.DisplayLayout.GroupByBox.Hidden = true;
            this.UltraGridDireccionDestino.DisplayLayout.InterBandSpacing = 10;
            this.UltraGridDireccionDestino.DisplayLayout.MaxBandDepth = 5;
            appearance103.BackColor = System.Drawing.SystemColors.Window;
            this.UltraGridDireccionDestino.DisplayLayout.Override.ActiveCellAppearance = appearance103;
            appearance104.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance104.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance104.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UltraGridDireccionDestino.DisplayLayout.Override.ActiveRowAppearance = appearance104;
            this.UltraGridDireccionDestino.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.UltraGridDireccionDestino.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.UltraGridDireccionDestino.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.UltraGridDireccionDestino.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.UltraGridDireccionDestino.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.UltraGridDireccionDestino.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.UltraGridDireccionDestino.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance105.BackColor = System.Drawing.Color.Transparent;
            this.UltraGridDireccionDestino.DisplayLayout.Override.CardAreaAppearance = appearance105;
            appearance106.BackColor = System.Drawing.SystemColors.Control;
            appearance106.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.UltraGridDireccionDestino.DisplayLayout.Override.CellAppearance = appearance106;
            this.UltraGridDireccionDestino.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance107.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance107.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance107.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance107.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance107.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.UltraGridDireccionDestino.DisplayLayout.Override.HeaderAppearance = appearance107;
            this.UltraGridDireccionDestino.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance108.ForeColor = System.Drawing.Color.Red;
            this.UltraGridDireccionDestino.DisplayLayout.Override.RowSelectorAppearance = appearance108;
            this.UltraGridDireccionDestino.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.UltraGridDireccionDestino.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.UltraGridDireccionDestino.DisplayLayout.Override.SelectedCellAppearance = appearance109;
            appearance110.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance110.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance110.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.UltraGridDireccionDestino.DisplayLayout.Override.SelectedRowAppearance = appearance110;
            appearance111.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance111.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.UltraGridDireccionDestino.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance111;
            this.UltraGridDireccionDestino.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UltraGridDireccionDestino.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.UltraGridDireccionDestino.DisplayLayout.UseFixedHeaders = true;
            this.UltraGridDireccionDestino.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.UltraGridDireccionDestino.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.UltraGridDireccionDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltraGridDireccionDestino.Location = new System.Drawing.Point(5, 51);
            this.UltraGridDireccionDestino.Name = "UltraGridDireccionDestino";
            this.UltraGridDireccionDestino.Size = new System.Drawing.Size(541, 78);
            this.UltraGridDireccionDestino.TabIndex = 7;
            this.UltraGridDireccionDestino.AfterEnterEditMode += new System.EventHandler(this.UltraGridDireccionDestino_AfterEnterEditMode);
            this.UltraGridDireccionDestino.AfterRowActivate += new System.EventHandler(this.DireccionDestinoUltraGridAfterRowActivate);
            this.UltraGridDireccionDestino.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.UltraGridDireccionDestinoCellChange);
            this.UltraGridDireccionDestino.Enter += new System.EventHandler(this.UltraGridDireccionDestinoEnter);
            this.UltraGridDireccionDestino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UltraGridDireccionDestino_KeyDown);
            // 
            // ultraDataSourceDireccionDestino
            // 
            ultraDataColumn25.DataType = typeof(int);
            ultraDataColumn26.DataType = typeof(int);
            ultraDataColumn30.DataType = typeof(int);
            ultraDataColumn31.DataType = typeof(int);
            ultraDataColumn33.DataType = typeof(int);
            this.ultraDataSourceDireccionDestino.Band.Columns.AddRange(new object[] {
            ultraDataColumn25,
            ultraDataColumn26,
            ultraDataColumn27,
            ultraDataColumn28,
            ultraDataColumn29,
            ultraDataColumn30,
            ultraDataColumn31,
            ultraDataColumn32,
            ultraDataColumn33});
            this.ultraDataSourceDireccionDestino.Band.Key = "DireccionesAfiliados";
            // 
            // ultraDropDownLocalidad1
            // 
            this.ultraDropDownLocalidad1.DataSource = this.localidadesBindingSource;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidad1.DisplayLayout.Appearance = appearance12;
            this.ultraDropDownLocalidad1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand14.ColHeadersVisible = false;
            ultraGridColumn76.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn76.Header.VisiblePosition = 1;
            ultraGridColumn76.Hidden = true;
            ultraGridColumn76.Width = 51;
            ultraGridColumn77.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn77.Header.VisiblePosition = 0;
            ultraGridColumn77.Width = 219;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn76,
            ultraGridColumn77});
            this.ultraDropDownLocalidad1.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraDropDownLocalidad1.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidad1.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidad1.DisplayLayout.MaxBandDepth = 5;
            appearance13.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.ActiveCellAppearance = appearance13;
            appearance14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance14.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.ActiveRowAppearance = appearance14;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance15.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.CardAreaAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.Control;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.CellAppearance = appearance16;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance17.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance17.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.HeaderAppearance = appearance17;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance18.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.RowSelectorAppearance = appearance18;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.SelectedCellAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance20.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.SelectedRowAppearance = appearance20;
            appearance21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidad1.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance21;
            this.ultraDropDownLocalidad1.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidad1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidad1.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidad1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidad1.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidad1.DropDownWidth = 0;
            this.ultraDropDownLocalidad1.Location = new System.Drawing.Point(24, 53);
            this.ultraDropDownLocalidad1.Name = "ultraDropDownLocalidad1";
            this.ultraDropDownLocalidad1.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownLocalidad1.TabIndex = 19;
            this.ultraDropDownLocalidad1.TabStop = false;
            this.ultraDropDownLocalidad1.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidad1.Visible = false;
            this.ultraDropDownLocalidad1.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownLocalidad1RowSelected);
            // 
            // ultraDropDownBarrios1
            // 
            this.ultraDropDownBarrios1.DataSource = this.barriosListaBindingSource;
            appearance22.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrios1.DisplayLayout.Appearance = appearance22;
            this.ultraDropDownBarrios1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand15.ColHeadersVisible = false;
            ultraGridColumn78.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn78.Header.VisiblePosition = 0;
            ultraGridColumn78.Hidden = true;
            ultraGridColumn78.Width = 57;
            ultraGridColumn79.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn79.Header.VisiblePosition = 1;
            ultraGridColumn79.Width = 219;
            ultraGridColumn80.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn80.Header.VisiblePosition = 2;
            ultraGridColumn80.Hidden = true;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn78,
            ultraGridColumn79,
            ultraGridColumn80});
            this.ultraDropDownBarrios1.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.ultraDropDownBarrios1.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBarrios1.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBarrios1.DisplayLayout.MaxBandDepth = 5;
            appearance23.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBarrios1.DisplayLayout.Override.ActiveCellAppearance = appearance23;
            appearance24.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance24.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance24.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBarrios1.DisplayLayout.Override.ActiveRowAppearance = appearance24;
            this.ultraDropDownBarrios1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBarrios1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBarrios1.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios1.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBarrios1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios1.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBarrios1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance25.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBarrios1.DisplayLayout.Override.CardAreaAppearance = appearance25;
            appearance26.BackColor = System.Drawing.SystemColors.Control;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios1.DisplayLayout.Override.CellAppearance = appearance26;
            this.ultraDropDownBarrios1.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance27.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance27.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBarrios1.DisplayLayout.Override.HeaderAppearance = appearance27;
            this.ultraDropDownBarrios1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance28.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBarrios1.DisplayLayout.Override.RowSelectorAppearance = appearance28;
            this.ultraDropDownBarrios1.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBarrios1.DisplayLayout.Override.SelectedCellAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance30.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios1.DisplayLayout.Override.SelectedRowAppearance = appearance30;
            appearance31.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBarrios1.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance31;
            this.ultraDropDownBarrios1.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBarrios1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBarrios1.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBarrios1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBarrios1.DisplayMember = "Nombre";
            this.ultraDropDownBarrios1.DropDownWidth = 0;
            this.ultraDropDownBarrios1.Location = new System.Drawing.Point(294, 65);
            this.ultraDropDownBarrios1.Name = "ultraDropDownBarrios1";
            this.ultraDropDownBarrios1.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownBarrios1.TabIndex = 21;
            this.ultraDropDownBarrios1.TabStop = false;
            this.ultraDropDownBarrios1.ValueMember = "idBarrio";
            this.ultraDropDownBarrios1.Visible = false;
            this.ultraDropDownBarrios1.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownBarrios1FilterRow);
            // 
            // ultraDropDownCalles1
            // 
            this.ultraDropDownCalles1.DataSource = this.callesBindingSource;
            appearance32.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalles1.DisplayLayout.Appearance = appearance32;
            this.ultraDropDownCalles1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand16.ColHeadersVisible = false;
            ultraGridColumn81.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn81.Header.VisiblePosition = 0;
            ultraGridColumn81.Hidden = true;
            ultraGridColumn81.Width = 37;
            ultraGridColumn82.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn82.Header.VisiblePosition = 1;
            ultraGridColumn82.Hidden = true;
            ultraGridColumn82.Width = 69;
            ultraGridColumn83.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn83.Header.VisiblePosition = 2;
            ultraGridColumn83.Hidden = true;
            ultraGridColumn83.Width = 48;
            ultraGridColumn84.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn84.Header.VisiblePosition = 3;
            ultraGridColumn84.Width = 219;
            ultraGridBand16.Columns.AddRange(new object[] {
            ultraGridColumn81,
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn84});
            this.ultraDropDownCalles1.DisplayLayout.BandsSerializer.Add(ultraGridBand16);
            this.ultraDropDownCalles1.DisplayLayout.ColScrollRegions.Add(colScrollRegion3);
            this.ultraDropDownCalles1.DisplayLayout.ColScrollRegions.Add(colScrollRegion4);
            this.ultraDropDownCalles1.DisplayLayout.ColScrollRegions.Add(colScrollRegion5);
            this.ultraDropDownCalles1.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCalles1.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCalles1.DisplayLayout.MaxBandDepth = 5;
            appearance33.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCalles1.DisplayLayout.Override.ActiveCellAppearance = appearance33;
            appearance34.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance34.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance34.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCalles1.DisplayLayout.Override.ActiveRowAppearance = appearance34;
            this.ultraDropDownCalles1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCalles1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCalles1.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalles1.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCalles1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalles1.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCalles1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance35.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCalles1.DisplayLayout.Override.CardAreaAppearance = appearance35;
            appearance36.BackColor = System.Drawing.SystemColors.Control;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalles1.DisplayLayout.Override.CellAppearance = appearance36;
            this.ultraDropDownCalles1.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance37.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance37.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance37.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCalles1.DisplayLayout.Override.HeaderAppearance = appearance37;
            this.ultraDropDownCalles1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance38.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCalles1.DisplayLayout.Override.RowSelectorAppearance = appearance38;
            this.ultraDropDownCalles1.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCalles1.DisplayLayout.Override.SelectedCellAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance40.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalles1.DisplayLayout.Override.SelectedRowAppearance = appearance40;
            appearance41.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCalles1.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance41;
            this.ultraDropDownCalles1.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCalles1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCalles1.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCalles1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCalles1.DisplayMember = "Nombre";
            this.ultraDropDownCalles1.DropDownWidth = 0;
            this.ultraDropDownCalles1.Location = new System.Drawing.Point(294, 51);
            this.ultraDropDownCalles1.Name = "ultraDropDownCalles1";
            this.ultraDropDownCalles1.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownCalles1.TabIndex = 20;
            this.ultraDropDownCalles1.TabStop = false;
            this.ultraDropDownCalles1.ValueMember = "idCalle";
            this.ultraDropDownCalles1.Visible = false;
            this.ultraDropDownCalles1.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCalles1FilterRow);
            // 
            // ultraDataSourcePrestaciones
            // 
            ultraDataColumn34.DataType = typeof(System.DateTime);
            this.ultraDataSourcePrestaciones.Band.Columns.AddRange(new object[] {
            ultraDataColumn34,
            ultraDataColumn35});
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraGridPrestaciones);
            appearance133.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance133.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance133.FontData.BoldAsString = "True";
            appearance133.FontData.SizeInPoints = 9F;
            appearance133.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBox1.HeaderAppearance = appearance133;
            this.ultraGroupBox1.Location = new System.Drawing.Point(575, 68);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(412, 556);
            this.ultraGroupBox1.TabIndex = 23;
            this.ultraGroupBox1.Text = "Prestaciones";
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraGridPrestaciones
            // 
            this.ultraGridPrestaciones.DataSource = this.ultraDataSourcePrestaciones;
            appearance113.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance113.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridPrestaciones.DisplayLayout.Appearance = appearance113;
            this.ultraGridPrestaciones.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand17.ColHeaderLines = 2;
            ultraGridColumn85.Header.Caption = "Fecha y Hora";
            ultraGridColumn85.Header.VisiblePosition = 0;
            ultraGridColumn85.MaskInput = "{date} hh:mm";
            ultraGridColumn85.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn85.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn85.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(105, 18);
            ultraGridColumn85.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(105, 0);
            ultraGridColumn85.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn85.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn85.TabIndex = 1;
            ultraGridColumn85.Width = 107;
            ultraGridColumn86.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn86.Header.VisiblePosition = 1;
            ultraGridColumn86.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn86.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn86.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(241, 18);
            ultraGridColumn86.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(241, 0);
            ultraGridColumn86.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn86.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn86.TabIndex = 2;
            ultraGridColumn86.VertScrollBar = true;
            ultraGridColumn86.Width = 236;
            ultraGridBand17.Columns.AddRange(new object[] {
            ultraGridColumn85,
            ultraGridColumn86});
            ultraGridBand17.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement;
            ultraGridBand17.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            ultraGridBand17.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True;
            ultraGridBand17.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand17.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.ultraGridPrestaciones.DisplayLayout.BandsSerializer.Add(ultraGridBand17);
            this.ultraGridPrestaciones.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraGridPrestaciones.DisplayLayout.InterBandSpacing = 10;
            this.ultraGridPrestaciones.DisplayLayout.MaxBandDepth = 5;
            appearance114.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGridPrestaciones.DisplayLayout.Override.ActiveCellAppearance = appearance114;
            appearance115.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance115.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance115.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance115.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraGridPrestaciones.DisplayLayout.Override.ActiveRowAppearance = appearance115;
            this.ultraGridPrestaciones.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraGridPrestaciones.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGridPrestaciones.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridPrestaciones.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraGridPrestaciones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridPrestaciones.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraGridPrestaciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance116.BackColor = System.Drawing.Color.Transparent;
            this.ultraGridPrestaciones.DisplayLayout.Override.CardAreaAppearance = appearance116;
            appearance117.BackColor = System.Drawing.SystemColors.Control;
            appearance117.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance117.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridPrestaciones.DisplayLayout.Override.CellAppearance = appearance117;
            this.ultraGridPrestaciones.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance118.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance118.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance118.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance118.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance118.TextTrimming = Infragistics.Win.TextTrimming.Word;
            appearance118.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGridPrestaciones.DisplayLayout.Override.HeaderAppearance = appearance118;
            this.ultraGridPrestaciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance119.ForeColor = System.Drawing.Color.Red;
            this.ultraGridPrestaciones.DisplayLayout.Override.RowSelectorAppearance = appearance119;
            this.ultraGridPrestaciones.DisplayLayout.Override.RowSpacingAfter = 7;
            appearance120.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGridPrestaciones.DisplayLayout.Override.SelectedCellAppearance = appearance120;
            appearance121.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance121.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance121.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridPrestaciones.DisplayLayout.Override.SelectedRowAppearance = appearance121;
            appearance122.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance122.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraGridPrestaciones.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance122;
            this.ultraGridPrestaciones.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraGridPrestaciones.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGridPrestaciones.DisplayLayout.UseFixedHeaders = true;
            this.ultraGridPrestaciones.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGridPrestaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGridPrestaciones.Location = new System.Drawing.Point(5, 23);
            this.ultraGridPrestaciones.Name = "ultraGridPrestaciones";
            this.ultraGridPrestaciones.Size = new System.Drawing.Size(407, 536);
            this.ultraGridPrestaciones.TabIndex = 10;
            this.ultraGridPrestaciones.AfterEnterEditMode += new System.EventHandler(this.ultraGridPrestaciones_AfterEnterEditMode);
            this.ultraGridPrestaciones.AfterRowsDeleted += new System.EventHandler(this.UltraGridPrestacionesAfterRowsDeleted);
            this.ultraGridPrestaciones.AfterRowInsert += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.UltraGridPrestacionesAfterRowInsert);
            this.ultraGridPrestaciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraGridPrestaciones_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTelefonoNoEncontrado);
            this.panel2.Controls.Add(this.ultraDateTimeEditorTomada);
            this.panel2.Location = new System.Drawing.Point(194, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 52);
            this.panel2.TabIndex = 24;
            // 
            // labelTelefonoNoEncontrado
            // 
            this.labelTelefonoNoEncontrado.AutoSize = true;
            this.labelTelefonoNoEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonoNoEncontrado.ForeColor = System.Drawing.Color.Red;
            this.labelTelefonoNoEncontrado.Location = new System.Drawing.Point(3, 26);
            this.labelTelefonoNoEncontrado.Name = "labelTelefonoNoEncontrado";
            this.labelTelefonoNoEncontrado.Size = new System.Drawing.Size(211, 13);
            this.labelTelefonoNoEncontrado.TabIndex = 20;
            this.labelTelefonoNoEncontrado.Text = "No encontrado en la base de datos.";
            this.labelTelefonoNoEncontrado.Visible = false;
            // 
            // tiposDeDestinoBindingSource
            // 
            this.tiposDeDestinoBindingSource.DataMember = "TiposDeDestino";
            this.tiposDeDestinoBindingSource.DataSource = this.dsTiposDeDestino;
            // 
            // dsTiposDeDestino
            // 
            this.dsTiposDeDestino.DataSetName = "DsTiposDeDestino";
            this.dsTiposDeDestino.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBuscarTelefono
            // 
            this.dsBuscarTelefono.DataSetName = "DsBuscarTelefono";
            this.dsBuscarTelefono.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDireccionLugar
            // 
            this.dsDireccionLugar.DataSetName = "DsDireccionLugar";
            this.dsDireccionLugar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarAfiliadosBindingSource
            // 
            this.buscarAfiliadosBindingSource.DataMember = "BuscarAfiliados";
            this.buscarAfiliadosBindingSource.DataSource = this.dsBuscarAfiliados;
            // 
            // dsBuscarAfiliados
            // 
            this.dsBuscarAfiliados.DataSetName = "DsBuscarAfiliados";
            this.dsBuscarAfiliados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSistemas1
            // 
            this.dsSistemas1.DataSetName = "DsSistemas";
            this.dsSistemas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPacientesPrestacion1
            // 
            this.dsPacientesPrestacion1.DataSetName = "DsPacientesPrestacion";
            this.dsPacientesPrestacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormTomarProgramado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(994, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ultraGroupBox1);
            this.Controls.Add(this.ultraGroupBoxTelefono);
            this.Controls.Add(this.ultraGroupBoxDirecciónDestino);
            this.Controls.Add(this.ultraGroupBoxPractica);
            this.Controls.Add(this.ultraGroupBoxCobertura);
            this.Controls.Add(this.ultraGroupBoxPaciente);
            this.Controls.Add(this.ultraGroupBoxContrato);
            this.Controls.Add(this.ultraGroupBoxDirección);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1010, 703);
            this.MinimumSize = new System.Drawing.Size(1010, 703);
            this.Name = "FormTomarProgramado";
            this.Text = "Tomar un llamado programado";
            this.Load += new System.EventHandler(this.FormTomarLlamadoLoad);
            this.Controls.SetChildIndex(this.ultraGroupBoxDirección, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxContrato, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxPaciente, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxCobertura, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxPractica, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxDirecciónDestino, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxTelefono, 0);
            this.Controls.SetChildIndex(this.ultraGroupBox1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGridDireccionOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceDireccioneOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxDirección)).EndInit();
            this.ultraGroupBoxDirección.ResumeLayout(false);
            this.ultraGroupBoxDirección.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraComboLugarOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugaresLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidades1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxCobertura)).EndInit();
            this.ultraGroupBoxCobertura.ResumeLayout(false);
            this.ultraGroupBoxCobertura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCobertura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoberturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxPaciente)).EndInit();
            this.ultraGroupBoxPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourcePaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxContrato)).EndInit();
            this.ultraGroupBoxContrato.ResumeLayout(false);
            this.ultraGroupBoxContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorCondContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxTelefono)).EndInit();
            this.ultraGroupBoxTelefono.ResumeLayout(false);
            this.ultraGroupBoxTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorTomada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxPractica)).EndInit();
            this.ultraGroupBoxPractica.ResumeLayout(false);
            this.ultraGroupBoxPractica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxDirecciónDestino)).EndInit();
            this.ultraGroupBoxDirecciónDestino.ResumeLayout(false);
            this.ultraGroupBoxDirecciónDestino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboLugarDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGridDireccionDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceDireccionDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourcePrestaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridPrestaciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDireccionLugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAfiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarAfiliados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPacientesPrestacion1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Button buttonBuscarTelefono;
        private Infragistics.Win.UltraWinGrid.UltraGrid UltraGridDireccionOrigen;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxDirección;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxCobertura;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxPaciente;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxContrato;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxTelefono;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceDireccioneOrigen;
        private System.Windows.Forms.Button buttonBuscarContrato;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridPaciente;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourcePaciente;
        private System.Windows.Forms.Button buttonBuscarPaciente;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorCondContrato;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorTomada;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLocalidad;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCalles;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBarrios;
        private System.Windows.Forms.BindingSource barriosListaBindingSource;
        private WS.DsBarrios dsBarrios;
        private WS.DsCoberturas dsCoberturas;
        private System.Windows.Forms.BindingSource coberturasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboCobertura;
        private WS.DsBuscarTelefono dsBuscarTelefono;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxPractica;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid2;
        private System.Windows.Forms.BindingSource practicasBindingSource;
        private WS.DsPracticas dsPracticas;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboPracticas;
        private System.Windows.Forms.BindingSource tiposDeDestinoBindingSource;
        private WS.DsTiposDeDestino dsTiposDeDestino;
        private System.Windows.Forms.BindingSource buscarAfiliadosBindingSource;
        private WS.DsBuscarAfiliados dsBuscarAfiliados;
        private WS.DsContratosLista dsContratosLista;
        private System.Windows.Forms.BindingSource contratosBindingSource;
        private WS.DsSistemas dsSistemas1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPrepagos;
        private System.Windows.Forms.BindingSource prepagosBindingSource;
        private System.Windows.Forms.Button buttonAtencionesAnteriores;
        private System.Windows.Forms.BindingSource localidadesBindingSource;
        private WS.DsLocalidades dsLocalidades1;
        private System.Windows.Forms.BindingSource callesBindingSource;
        private WS.DsCallesLista dsCallesLista;
        internal WS.DsPrepagos dsPrepagos;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxDirecciónDestino;
        private Infragistics.Win.UltraWinGrid.UltraGrid UltraGridDireccionDestino;
        private UltraCombo UltraComboLugarOrigen;
        private System.Windows.Forms.BindingSource lugaresListaBindingSource;
        private Cabina.WS.DsLugaresLista dsLugaresLista;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private UltraCombo ultraComboLugarDestino;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourcePrestaciones;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private UltraGrid ultraGridPrestaciones;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceDireccionDestino;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTelefonoNoEncontrado;
        private Cabina.WS.DsDireccionLugar dsDireccionLugar;
        private System.Windows.Forms.CheckBox checkBoxRetorno;
        private UltraDropDown ultraDropDownLocalidad1;
        private UltraDropDown ultraDropDownBarrios1;
        private UltraDropDown ultraDropDownCalles1;
        private System.Windows.Forms.BindingSource tiposDeDocumentoBindingSource;
        private WS.DsTiposDeDocumento dsTiposDeDocumento;
        private UltraDropDown ultraDropDownTiposDeDocumento;
        private WS.DsPacientesPrestacion dsPacientesPrestacion1;
        private UltraCombo ultraComboContratos;
    }
}
