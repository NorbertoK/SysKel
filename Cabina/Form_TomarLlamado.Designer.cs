using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    partial class FormTomarLlamado
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
            Infragistics.Win.Appearance appearance155 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("DireccionesAfiliados", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn87 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
            Infragistics.Win.Appearance appearance156 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance157 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance158 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance159 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance160 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance162 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance167 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance168 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance169 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idLocalidad");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idCalle");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piso");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Departamento");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idEntreCalle1");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn7 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idEntreCalle2");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn8 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observaciones");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn9 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idBarrio");
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDestino", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn88 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn89 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConPacienteABordo");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn97 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion1 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion2 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Localidades", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn98 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn99 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Codigos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn100 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn101 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn102 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Color");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn103 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jerarquia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn104 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TiempoDeLlegada");
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Coberturas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn105 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn106 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn107 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn108 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn109 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Edad");
            Infragistics.Win.Appearance appearance172 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn110 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EdadEn");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn111 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sexo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn112 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Antecedentes", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn113 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago", -1, "ultraDropDownPrepagos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn114 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn115 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance173 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn116 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenteExterno");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExtraCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento", -1, "ultraDropDownTiposDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeDocumento");
            Infragistics.Win.Appearance appearance174 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CopagoSugerido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
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
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn20 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenteExterno");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn21 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ExtraCobertura");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn22 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn23 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroDeDocumento");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn24 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CopagoSugerido");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn25 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idPlan");
            Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDocumento", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance148 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance149 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance150 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance151 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance152 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance153 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ContratosRenglonFactura", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato");
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance164 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance165 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance166 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeLlamado", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn131 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeLlamado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FichaDespacho");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FichaMasInfo");
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance120 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosPacientes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeLlamado", -1, "ultraDropDownMotivos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BotonDespacho", 0);
            Infragistics.Win.Appearance appearance175 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BotonMasInfo", 1);
            Infragistics.Win.Appearance appearance176 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn26 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idMotivoDeLlamado");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn27 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observaciones");
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Practicas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPractica");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prepagos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn143 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance121 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance122 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance163 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance154 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeCancelacionPrestacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeCancelacionPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.buttonBuscarTelefono = new System.Windows.Forms.Button();
            this.direccionesAfiliadosUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSourceDirecciones = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraGroupBoxDirección = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraLabelTipoDeDestino = new Infragistics.Win.Misc.UltraLabel();
            this.ultraComboTiposDeDestino = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.tiposDeDestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDestino = new Cabina.WS.DsTiposDeDestino();
            this.ultraDropDownBarrios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.barriosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarrios = new Cabina.WS.DsBarrios();
            this.ultraDropDownCalles = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.callesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCallesLista = new Cabina.WS.DsCallesLista();
            this.ultraDropDownLocalidad = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.localidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalidades1 = new Cabina.WS.DsLocalidades();
            this.buttonBuscarDireccion = new System.Windows.Forms.Button();
            this.ultraGroupBoxCodigo = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraComboCodigos = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.codigosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodigos = new Cabina.WS.DsCodigos();
            this.ultraGroupBoxCobertura = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraComboCobertura = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.coberturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCoberturas = new Cabina.WS.DsCoberturas();
            this.ultraGroupBoxPaciente = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGridPaciente = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSourcePaciente = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.buttonBuscarPaciente = new System.Windows.Forms.Button();
            this.ultraDropDownTiposDeDocumento = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDocumento = new Cabina.WS.DsTiposDeDocumento();
            this.ultraGroupBoxContrato = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraComboContratos = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsContratosLista = new Cabina.WS.DsContratosLista();
            this.ultraTextEditorCondContrato = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.buttonBuscarContrato = new System.Windows.Forms.Button();
            this.ultraGroupBoxObservaciones = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraTextEditorObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraGroupBoxMotivos = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraDropDownMotivos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDeLlamadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeLlamado = new Cabina.WS.DsMotivosDeLlamado();
            this.motivosPacientesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSourceMotivos = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraGroupBoxTelefono = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraDateTimeEditorTomada = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTelefonoNoEncontrado = new System.Windows.Forms.Label();
            this.ultraGroupBoxPractica = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraComboPracticas = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.practicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPracticas = new Cabina.WS.DsPracticas();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraGrid2 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDropDownPrepagos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.prepagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrepagos = new Cabina.WS.DsPrepagos();
            this.buttonAtencionesAnteriores = new System.Windows.Forms.Button();
            this.ultraComboMotivoDeCancelacion = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.motivosDeCancelacionPrestacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeCancelacionPrestacion = new Cabina.WS.DsMotivosDeCancelacionPrestacion();
            this.labelMotivoCancelacion = new System.Windows.Forms.Label();
            this.buttonCancelarNuevo = new System.Windows.Forms.Button();
            this.dsBuscarAfiliados = new Cabina.WS.DsBuscarAfiliados();
            this.buscarAfiliadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBuscarTelefono = new Cabina.WS.DsBuscarTelefono();
            this.dsSistemas = new Cabina.WS.DsSistemas();
            this.sistemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPacientesPrestacion1 = new Cabina.WS.DsPacientesPrestacion();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.direccionesAfiliadosUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceDirecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxDirección)).BeginInit();
            this.ultraGroupBoxDirección.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidades1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxCodigo)).BeginInit();
            this.ultraGroupBoxCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxContrato)).BeginInit();
            this.ultraGroupBoxContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorCondContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxObservaciones)).BeginInit();
            this.ultraGroupBoxObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxMotivos)).BeginInit();
            this.ultraGroupBoxMotivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeLlamadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeLlamado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosPacientesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceMotivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxTelefono)).BeginInit();
            this.ultraGroupBoxTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorTomada)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxPractica)).BeginInit();
            this.ultraGroupBoxPractica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboMotivoDeCancelacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeCancelacionPrestacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeCancelacionPrestacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarAfiliados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAfiliadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPacientesPrestacion1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(652, 13);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(415, 13);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancelarNuevo);
            this.panel1.Controls.Add(this.labelMotivoCancelacion);
            this.panel1.Controls.Add(this.ultraComboMotivoDeCancelacion);
            this.panel1.Controls.Add(this.buttonAtencionesAnteriores);
            this.panel1.Location = new System.Drawing.Point(0, 610);
            this.panel1.Size = new System.Drawing.Size(743, 47);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAtencionesAnteriores, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.ultraComboMotivoDeCancelacion, 0);
            this.panel1.Controls.SetChildIndex(this.labelMotivoCancelacion, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelarNuevo, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Location = new System.Drawing.Point(415, 13);
            this.buttonCancelar.Text = "Anulado";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            this.buttonCancelar.Visible = false;
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
            this.buttonBuscarTelefono.Location = new System.Drawing.Point(114, 23);
            this.buttonBuscarTelefono.Name = "buttonBuscarTelefono";
            this.buttonBuscarTelefono.Size = new System.Drawing.Size(54, 23);
            this.buttonBuscarTelefono.TabIndex = 1;
            this.buttonBuscarTelefono.TabStop = false;
            this.buttonBuscarTelefono.Text = "Buscar";
            this.buttonBuscarTelefono.UseVisualStyleBackColor = true;
            this.buttonBuscarTelefono.Click += new System.EventHandler(this.ButtonBuscarTelefonoClick);
            // 
            // direccionesAfiliadosUltraGrid
            // 
            this.direccionesAfiliadosUltraGrid.DataSource = this.ultraDataSourceDirecciones;
            appearance155.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance155.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance155.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Appearance = appearance155;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn79.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn79.Header.Caption = "Localidad";
            ultraGridColumn79.Header.VisiblePosition = 8;
            ultraGridColumn79.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn79.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn79.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(244, 0);
            ultraGridColumn79.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(244, 0);
            ultraGridColumn79.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn79.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn79.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn80.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn80.Header.Caption = "Calle";
            ultraGridColumn80.Header.VisiblePosition = 0;
            ultraGridColumn80.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn80.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn80.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(230, 18);
            ultraGridColumn80.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(230, 0);
            ultraGridColumn80.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn80.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn80.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn80.Width = 54;
            ultraGridColumn81.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn81.Header.Caption = "Número";
            ultraGridColumn81.Header.VisiblePosition = 1;
            ultraGridColumn81.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn81.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn81.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(89, 18);
            ultraGridColumn81.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn81.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn81.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn81.Width = 98;
            ultraGridColumn82.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn82.Header.VisiblePosition = 2;
            ultraGridColumn82.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn82.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn82.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(55, 18);
            ultraGridColumn82.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(34, 0);
            ultraGridColumn82.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn82.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn82.Width = 98;
            ultraGridColumn83.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn83.Header.Caption = "Depto.";
            ultraGridColumn83.Header.VisiblePosition = 3;
            ultraGridColumn83.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn83.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn83.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(70, 18);
            ultraGridColumn83.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(46, 0);
            ultraGridColumn83.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn83.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn83.Width = 98;
            ultraGridColumn84.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn84.Header.Caption = "Entre";
            ultraGridColumn84.Header.VisiblePosition = 4;
            ultraGridColumn84.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn84.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn84.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(244, 0);
            ultraGridColumn84.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(244, 0);
            ultraGridColumn84.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn84.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn84.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn84.Width = 83;
            ultraGridColumn85.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn85.Header.Caption = "y";
            ultraGridColumn85.Header.VisiblePosition = 5;
            ultraGridColumn85.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn85.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn85.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(197, 0);
            ultraGridColumn85.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(18, 0);
            ultraGridColumn85.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn85.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn85.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn85.Width = 83;
            ultraGridColumn86.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn86.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn86.Header.VisiblePosition = 6;
            ultraGridColumn86.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn86.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn86.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(283, 55);
            ultraGridColumn86.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(283, 0);
            ultraGridColumn86.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn86.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn86.Width = 98;
            ultraGridColumn87.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn87.Header.Caption = "Barrio";
            ultraGridColumn87.Header.VisiblePosition = 7;
            ultraGridColumn87.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn87.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn87.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(184, 0);
            ultraGridColumn87.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(42, 0);
            ultraGridColumn87.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn87.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn87.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn87.Width = 58;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn79,
            ultraGridColumn80,
            ultraGridColumn81,
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn84,
            ultraGridColumn85,
            ultraGridColumn86,
            ultraGridColumn87});
            ultraGridBand2.MaxRows = 1;
            ultraGridBand2.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            appearance156.TextHAlignAsString = "Left";
            this.direccionesAfiliadosUltraGrid.DisplayLayout.CaptionAppearance = appearance156;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance157.BackColor = System.Drawing.SystemColors.Window;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance157;
            appearance158.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance158.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance158.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance158.ForeColor = System.Drawing.SystemColors.WindowText;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance158;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance159.BackColor = System.Drawing.Color.Transparent;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance159;
            appearance160.BackColor = System.Drawing.SystemColors.Control;
            appearance160.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance160.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.CellAppearance = appearance160;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance161.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance161.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance161.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance161.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance161.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance161;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance162.ForeColor = System.Drawing.Color.Red;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance162;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance167.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance167;
            appearance168.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance168.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance168.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance168;
            appearance169.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance169.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance169;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.direccionesAfiliadosUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.direccionesAfiliadosUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionesAfiliadosUltraGrid.Location = new System.Drawing.Point(5, 23);
            this.direccionesAfiliadosUltraGrid.Name = "direccionesAfiliadosUltraGrid";
            this.direccionesAfiliadosUltraGrid.Size = new System.Drawing.Size(708, 78);
            this.direccionesAfiliadosUltraGrid.TabIndex = 2;
            this.direccionesAfiliadosUltraGrid.AfterEnterEditMode += new System.EventHandler(this.direccionesAfiliadosUltraGrid_AfterEnterEditMode);
            this.direccionesAfiliadosUltraGrid.AfterRowActivate += new System.EventHandler(this.DireccionesAfiliadosUltraGridAfterRowActivate);
            this.direccionesAfiliadosUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.DireccionesAfiliadosUltraGridCellChange);
            this.direccionesAfiliadosUltraGrid.Enter += new System.EventHandler(this.DireccionesAfiliadosUltraGridEnter);
            this.direccionesAfiliadosUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.direccionesAfiliadosUltraGrid_KeyDown);
            // 
            // ultraDataSourceDirecciones
            // 
            ultraDataColumn1.DataType = typeof(int);
            ultraDataColumn2.DataType = typeof(int);
            ultraDataColumn6.DataType = typeof(int);
            ultraDataColumn7.DataType = typeof(int);
            ultraDataColumn9.DataType = typeof(int);
            this.ultraDataSourceDirecciones.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2,
            ultraDataColumn3,
            ultraDataColumn4,
            ultraDataColumn5,
            ultraDataColumn6,
            ultraDataColumn7,
            ultraDataColumn8,
            ultraDataColumn9});
            this.ultraDataSourceDirecciones.Band.Key = "DireccionesAfiliados";
            // 
            // ultraGroupBoxDirección
            // 
            this.ultraGroupBoxDirección.Controls.Add(this.ultraLabelTipoDeDestino);
            this.ultraGroupBoxDirección.Controls.Add(this.ultraComboTiposDeDestino);
            this.ultraGroupBoxDirección.Controls.Add(this.ultraDropDownBarrios);
            this.ultraGroupBoxDirección.Controls.Add(this.ultraDropDownCalles);
            this.ultraGroupBoxDirección.Controls.Add(this.ultraDropDownLocalidad);
            this.ultraGroupBoxDirección.Controls.Add(this.buttonBuscarDireccion);
            this.ultraGroupBoxDirección.Controls.Add(this.direccionesAfiliadosUltraGrid);
            appearance62.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance62.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance62.FontData.BoldAsString = "True";
            appearance62.FontData.SizeInPoints = 9F;
            appearance62.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxDirección.HeaderAppearance = appearance62;
            this.ultraGroupBoxDirección.Location = new System.Drawing.Point(12, 70);
            this.ultraGroupBoxDirección.Name = "ultraGroupBoxDirección";
            this.ultraGroupBoxDirección.Size = new System.Drawing.Size(722, 138);
            this.ultraGroupBoxDirección.TabIndex = 2;
            this.ultraGroupBoxDirección.Text = "Dirección";
            this.ultraGroupBoxDirección.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraLabelTipoDeDestino
            // 
            this.ultraLabelTipoDeDestino.Location = new System.Drawing.Point(20, 111);
            this.ultraLabelTipoDeDestino.Name = "ultraLabelTipoDeDestino";
            this.ultraLabelTipoDeDestino.Size = new System.Drawing.Size(83, 14);
            this.ultraLabelTipoDeDestino.TabIndex = 5;
            this.ultraLabelTipoDeDestino.Text = "Tipo de Destino";
            // 
            // ultraComboTiposDeDestino
            // 
            this.ultraComboTiposDeDestino.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboTiposDeDestino.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboTiposDeDestino.DataSource = this.tiposDeDestinoBindingSource;
            appearance22.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboTiposDeDestino.DisplayLayout.Appearance = appearance22;
            this.ultraComboTiposDeDestino.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn88.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn88.Header.VisiblePosition = 0;
            ultraGridColumn88.Hidden = true;
            ultraGridColumn88.Width = 33;
            ultraGridColumn89.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn89.Header.VisiblePosition = 1;
            ultraGridColumn89.Width = 130;
            ultraGridColumn90.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn90.Header.VisiblePosition = 2;
            ultraGridColumn90.Hidden = true;
            ultraGridColumn90.Width = 63;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn88,
            ultraGridColumn89,
            ultraGridColumn90});
            this.ultraComboTiposDeDestino.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraComboTiposDeDestino.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboTiposDeDestino.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboTiposDeDestino.DisplayLayout.MaxBandDepth = 5;
            appearance23.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.ActiveCellAppearance = appearance23;
            appearance24.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance24.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance24.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.ActiveRowAppearance = appearance24;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance25.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.CardAreaAppearance = appearance25;
            appearance26.BackColor = System.Drawing.SystemColors.Control;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.CellAppearance = appearance26;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance27.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance27.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.HeaderAppearance = appearance27;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance28.ForeColor = System.Drawing.Color.Red;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.RowSelectorAppearance = appearance28;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.SelectedCellAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance30.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.SelectedRowAppearance = appearance30;
            appearance31.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboTiposDeDestino.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance31;
            this.ultraComboTiposDeDestino.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboTiposDeDestino.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboTiposDeDestino.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboTiposDeDestino.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboTiposDeDestino.DisplayMember = "Nombre";
            this.ultraComboTiposDeDestino.LimitToList = true;
            this.ultraComboTiposDeDestino.Location = new System.Drawing.Point(109, 107);
            this.ultraComboTiposDeDestino.Name = "ultraComboTiposDeDestino";
            this.ultraComboTiposDeDestino.Size = new System.Drawing.Size(149, 22);
            this.ultraComboTiposDeDestino.TabIndex = 3;
            this.ultraComboTiposDeDestino.ValueMember = "idTipoDeDestino";
            this.ultraComboTiposDeDestino.ValueChanged += new System.EventHandler(this.UltraComboTiposDeDestinoValueChanged);
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
            // ultraDropDownBarrios
            // 
            this.ultraDropDownBarrios.DataSource = this.barriosListaBindingSource;
            appearance32.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrios.DisplayLayout.Appearance = appearance32;
            this.ultraDropDownBarrios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn91.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn91.Header.VisiblePosition = 0;
            ultraGridColumn91.Hidden = true;
            ultraGridColumn91.Width = 57;
            ultraGridColumn92.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn92.Header.VisiblePosition = 1;
            ultraGridColumn92.Width = 219;
            ultraGridColumn93.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn93.Header.VisiblePosition = 2;
            ultraGridColumn93.Hidden = true;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn91,
            ultraGridColumn92,
            ultraGridColumn93});
            this.ultraDropDownBarrios.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownBarrios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBarrios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBarrios.DisplayLayout.MaxBandDepth = 5;
            appearance33.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveCellAppearance = appearance33;
            appearance34.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance34.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance34.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveRowAppearance = appearance34;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance35.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.CardAreaAppearance = appearance35;
            appearance36.BackColor = System.Drawing.SystemColors.Control;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.CellAppearance = appearance36;
            this.ultraDropDownBarrios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance37.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance37.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance37.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderAppearance = appearance37;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance38.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSelectorAppearance = appearance38;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedCellAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance40.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedRowAppearance = appearance40;
            appearance41.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBarrios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance41;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBarrios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBarrios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBarrios.DisplayMember = "Nombre";
            this.ultraDropDownBarrios.DropDownWidth = 0;
            this.ultraDropDownBarrios.Location = new System.Drawing.Point(484, 51);
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
            appearance42.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance42.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalles.DisplayLayout.Appearance = appearance42;
            this.ultraDropDownCalles.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn94.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn94.Header.VisiblePosition = 0;
            ultraGridColumn94.Hidden = true;
            ultraGridColumn94.Width = 37;
            ultraGridColumn95.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn95.Header.VisiblePosition = 1;
            ultraGridColumn95.Hidden = true;
            ultraGridColumn95.Width = 69;
            ultraGridColumn96.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn96.Header.VisiblePosition = 2;
            ultraGridColumn96.Hidden = true;
            ultraGridColumn96.Width = 48;
            ultraGridColumn97.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn97.Header.VisiblePosition = 3;
            ultraGridColumn97.Width = 219;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn94,
            ultraGridColumn95,
            ultraGridColumn96,
            ultraGridColumn97});
            this.ultraDropDownCalles.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownCalles.DisplayLayout.ColScrollRegions.Add(colScrollRegion1);
            this.ultraDropDownCalles.DisplayLayout.ColScrollRegions.Add(colScrollRegion2);
            this.ultraDropDownCalles.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCalles.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCalles.DisplayLayout.MaxBandDepth = 5;
            appearance43.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCalles.DisplayLayout.Override.ActiveCellAppearance = appearance43;
            appearance44.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance44.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance44.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCalles.DisplayLayout.Override.ActiveRowAppearance = appearance44;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance45.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCalles.DisplayLayout.Override.CardAreaAppearance = appearance45;
            appearance46.BackColor = System.Drawing.SystemColors.Control;
            appearance46.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalles.DisplayLayout.Override.CellAppearance = appearance46;
            this.ultraDropDownCalles.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance47.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance47.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance47.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance47.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCalles.DisplayLayout.Override.HeaderAppearance = appearance47;
            this.ultraDropDownCalles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance48.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCalles.DisplayLayout.Override.RowSelectorAppearance = appearance48;
            this.ultraDropDownCalles.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCalles.DisplayLayout.Override.SelectedCellAppearance = appearance49;
            appearance50.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance50.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalles.DisplayLayout.Override.SelectedRowAppearance = appearance50;
            appearance51.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCalles.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance51;
            this.ultraDropDownCalles.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCalles.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCalles.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCalles.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCalles.DisplayMember = "Nombre";
            this.ultraDropDownCalles.DropDownWidth = 0;
            this.ultraDropDownCalles.Location = new System.Drawing.Point(484, 23);
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
            // ultraDropDownLocalidad
            // 
            this.ultraDropDownLocalidad.DataSource = this.localidadesBindingSource;
            appearance52.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidad.DisplayLayout.Appearance = appearance52;
            this.ultraDropDownLocalidad.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn98.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn98.Header.VisiblePosition = 1;
            ultraGridColumn98.Hidden = true;
            ultraGridColumn98.Width = 51;
            ultraGridColumn99.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn99.Header.VisiblePosition = 0;
            ultraGridColumn99.Width = 219;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn98,
            ultraGridColumn99});
            this.ultraDropDownLocalidad.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownLocalidad.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidad.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidad.DisplayLayout.MaxBandDepth = 5;
            appearance53.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveCellAppearance = appearance53;
            appearance54.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance54.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance54.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveRowAppearance = appearance54;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance55.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CardAreaAppearance = appearance55;
            appearance56.BackColor = System.Drawing.SystemColors.Control;
            appearance56.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CellAppearance = appearance56;
            this.ultraDropDownLocalidad.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance57.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance57.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance57.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance57.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderAppearance = appearance57;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance58.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSelectorAppearance = appearance58;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedCellAppearance = appearance59;
            appearance60.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance60.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedRowAppearance = appearance60;
            appearance61.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance61.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidad.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance61;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidad.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidad.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidad.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidad.DropDownWidth = 0;
            this.ultraDropDownLocalidad.Location = new System.Drawing.Point(484, 0);
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
            // buttonBuscarDireccion
            // 
            this.buttonBuscarDireccion.Location = new System.Drawing.Point(659, 107);
            this.buttonBuscarDireccion.Name = "buttonBuscarDireccion";
            this.buttonBuscarDireccion.Size = new System.Drawing.Size(54, 23);
            this.buttonBuscarDireccion.TabIndex = 4;
            this.buttonBuscarDireccion.TabStop = false;
            this.buttonBuscarDireccion.Text = "Buscar";
            this.buttonBuscarDireccion.UseVisualStyleBackColor = true;
            this.buttonBuscarDireccion.Visible = false;
            this.buttonBuscarDireccion.Click += new System.EventHandler(this.ButtonBuscarDireccionClick);
            // 
            // ultraGroupBoxCodigo
            // 
            this.ultraGroupBoxCodigo.Controls.Add(this.ultraComboCodigos);
            appearance73.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance73.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance73.FontData.BoldAsString = "True";
            appearance73.FontData.SizeInPoints = 9F;
            appearance73.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxCodigo.HeaderAppearance = appearance73;
            this.ultraGroupBoxCodigo.Location = new System.Drawing.Point(569, 317);
            this.ultraGroupBoxCodigo.Name = "ultraGroupBoxCodigo";
            this.ultraGroupBoxCodigo.Size = new System.Drawing.Size(161, 51);
            this.ultraGroupBoxCodigo.TabIndex = 5;
            this.ultraGroupBoxCodigo.Text = "Código";
            this.ultraGroupBoxCodigo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraComboCodigos
            // 
            this.ultraComboCodigos.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboCodigos.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboCodigos.DataSource = this.codigosBindingSource;
            appearance63.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance63.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboCodigos.DisplayLayout.Appearance = appearance63;
            this.ultraComboCodigos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn100.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn100.Header.VisiblePosition = 0;
            ultraGridColumn100.Hidden = true;
            ultraGridColumn100.Width = 25;
            ultraGridColumn101.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn101.Header.VisiblePosition = 1;
            ultraGridColumn101.Width = 130;
            ultraGridColumn102.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn102.Header.VisiblePosition = 2;
            ultraGridColumn102.Hidden = true;
            ultraGridColumn102.Width = 41;
            ultraGridColumn103.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn103.Header.VisiblePosition = 3;
            ultraGridColumn103.Hidden = true;
            ultraGridColumn103.Width = 26;
            ultraGridColumn104.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn104.Header.VisiblePosition = 4;
            ultraGridColumn104.Hidden = true;
            ultraGridColumn104.Width = 60;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn100,
            ultraGridColumn101,
            ultraGridColumn102,
            ultraGridColumn103,
            ultraGridColumn104});
            this.ultraComboCodigos.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraComboCodigos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboCodigos.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboCodigos.DisplayLayout.MaxBandDepth = 5;
            appearance64.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboCodigos.DisplayLayout.Override.ActiveCellAppearance = appearance64;
            appearance65.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance65.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance65.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboCodigos.DisplayLayout.Override.ActiveRowAppearance = appearance65;
            this.ultraComboCodigos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboCodigos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboCodigos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboCodigos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboCodigos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboCodigos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboCodigos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance66.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboCodigos.DisplayLayout.Override.CardAreaAppearance = appearance66;
            appearance67.BackColor = System.Drawing.SystemColors.Control;
            appearance67.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboCodigos.DisplayLayout.Override.CellAppearance = appearance67;
            this.ultraComboCodigos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance68.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance68.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance68.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance68.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboCodigos.DisplayLayout.Override.HeaderAppearance = appearance68;
            this.ultraComboCodigos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance69.ForeColor = System.Drawing.Color.Red;
            this.ultraComboCodigos.DisplayLayout.Override.RowSelectorAppearance = appearance69;
            this.ultraComboCodigos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboCodigos.DisplayLayout.Override.SelectedCellAppearance = appearance70;
            appearance71.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance71.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboCodigos.DisplayLayout.Override.SelectedRowAppearance = appearance71;
            appearance72.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance72.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboCodigos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance72;
            this.ultraComboCodigos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboCodigos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboCodigos.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboCodigos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboCodigos.DisplayMember = "Nombre";
            this.ultraComboCodigos.LimitToList = true;
            this.ultraComboCodigos.Location = new System.Drawing.Point(6, 24);
            this.ultraComboCodigos.Name = "ultraComboCodigos";
            this.ultraComboCodigos.Size = new System.Drawing.Size(149, 22);
            this.ultraComboCodigos.TabIndex = 5;
            this.ultraComboCodigos.ValueMember = "idCodigo";
            this.ultraComboCodigos.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboCodigosRowSelected);
            this.ultraComboCodigos.ValueChanged += new System.EventHandler(this.UltraComboCodigosValueChanged);
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
            // ultraGroupBoxCobertura
            // 
            this.ultraGroupBoxCobertura.Controls.Add(this.ultraComboCobertura);
            appearance84.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance84.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance84.FontData.BoldAsString = "True";
            appearance84.FontData.SizeInPoints = 9F;
            appearance84.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxCobertura.HeaderAppearance = appearance84;
            this.ultraGroupBoxCobertura.Location = new System.Drawing.Point(569, 379);
            this.ultraGroupBoxCobertura.Name = "ultraGroupBoxCobertura";
            this.ultraGroupBoxCobertura.Size = new System.Drawing.Size(161, 51);
            this.ultraGroupBoxCobertura.TabIndex = 6;
            this.ultraGroupBoxCobertura.Text = "Cobertura";
            this.ultraGroupBoxCobertura.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraComboCobertura
            // 
            this.ultraComboCobertura.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboCobertura.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboCobertura.DataSource = this.coberturasBindingSource;
            appearance74.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance74.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboCobertura.DisplayLayout.Appearance = appearance74;
            this.ultraComboCobertura.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn105.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn105.Header.VisiblePosition = 0;
            ultraGridColumn105.Hidden = true;
            ultraGridColumn105.Width = 57;
            ultraGridColumn106.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn106.Header.VisiblePosition = 1;
            ultraGridColumn106.Width = 131;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn105,
            ultraGridColumn106});
            this.ultraComboCobertura.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraComboCobertura.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboCobertura.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboCobertura.DisplayLayout.MaxBandDepth = 5;
            appearance75.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboCobertura.DisplayLayout.Override.ActiveCellAppearance = appearance75;
            appearance76.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance76.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance76.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboCobertura.DisplayLayout.Override.ActiveRowAppearance = appearance76;
            this.ultraComboCobertura.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboCobertura.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboCobertura.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboCobertura.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboCobertura.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboCobertura.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboCobertura.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance77.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboCobertura.DisplayLayout.Override.CardAreaAppearance = appearance77;
            appearance78.BackColor = System.Drawing.SystemColors.Control;
            appearance78.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboCobertura.DisplayLayout.Override.CellAppearance = appearance78;
            this.ultraComboCobertura.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance79.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance79.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance79.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance79.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboCobertura.DisplayLayout.Override.HeaderAppearance = appearance79;
            this.ultraComboCobertura.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance80.ForeColor = System.Drawing.Color.Red;
            this.ultraComboCobertura.DisplayLayout.Override.RowSelectorAppearance = appearance80;
            this.ultraComboCobertura.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboCobertura.DisplayLayout.Override.SelectedCellAppearance = appearance81;
            appearance82.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance82.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboCobertura.DisplayLayout.Override.SelectedRowAppearance = appearance82;
            appearance83.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance83.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboCobertura.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance83;
            this.ultraComboCobertura.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboCobertura.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboCobertura.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboCobertura.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboCobertura.DisplayMember = "Nombre";
            this.ultraComboCobertura.LimitToList = true;
            this.ultraComboCobertura.Location = new System.Drawing.Point(6, 24);
            this.ultraComboCobertura.Name = "ultraComboCobertura";
            this.ultraComboCobertura.Size = new System.Drawing.Size(150, 22);
            this.ultraComboCobertura.TabIndex = 6;
            this.ultraComboCobertura.ValueMember = "idCobertura";
            this.ultraComboCobertura.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboCoberturaRowSelected);
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
            this.ultraGroupBoxPaciente.Controls.Add(this.buttonBuscarPaciente);
            this.ultraGroupBoxPaciente.Controls.Add(this.ultraDropDownTiposDeDocumento);
            appearance97.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance97.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance97.FontData.BoldAsString = "True";
            appearance97.FontData.SizeInPoints = 9F;
            appearance97.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxPaciente.HeaderAppearance = appearance97;
            this.ultraGroupBoxPaciente.Location = new System.Drawing.Point(12, 317);
            this.ultraGroupBoxPaciente.Name = "ultraGroupBoxPaciente";
            this.ultraGroupBoxPaciente.Size = new System.Drawing.Size(551, 176);
            this.ultraGroupBoxPaciente.TabIndex = 4;
            this.ultraGroupBoxPaciente.Text = "Paciente";
            this.ultraGroupBoxPaciente.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraGridPaciente
            // 
            this.ultraGridPaciente.DataSource = this.ultraDataSourcePaciente;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridPaciente.DisplayLayout.Appearance = appearance11;
            this.ultraGridPaciente.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn107.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn107.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn107.DefaultCellValue = "False";
            ultraGridColumn107.Header.Caption = "Lista";
            ultraGridColumn107.Header.VisiblePosition = 0;
            ultraGridColumn107.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn107.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn107.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(41, 0);
            ultraGridColumn107.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(41, 0);
            ultraGridColumn107.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn107.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn107.TabStop = false;
            ultraGridColumn107.Width = 45;
            ultraGridColumn108.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn108.Header.Caption = "Apellido, Nombre";
            ultraGridColumn108.Header.VisiblePosition = 1;
            ultraGridColumn108.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn108.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn108.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(257, 0);
            ultraGridColumn108.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(257, 0);
            ultraGridColumn108.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn108.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn108.TabIndex = 1;
            ultraGridColumn108.Width = 70;
            ultraGridColumn109.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance172.TextHAlignAsString = "Right";
            ultraGridColumn109.CellAppearance = appearance172;
            ultraGridColumn109.Header.VisiblePosition = 2;
            ultraGridColumn109.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn109.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn109.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(47, 0);
            ultraGridColumn109.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(47, 0);
            ultraGridColumn109.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn109.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn109.TabIndex = 2;
            ultraGridColumn109.Width = 33;
            ultraGridColumn110.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn110.Header.Caption = "Edad en";
            ultraGridColumn110.Header.VisiblePosition = 3;
            ultraGridColumn110.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn110.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn110.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(77, 0);
            ultraGridColumn110.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(77, 0);
            ultraGridColumn110.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn110.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn110.TabIndex = 3;
            ultraGridColumn110.Width = 70;
            ultraGridColumn111.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn111.Header.VisiblePosition = 4;
            ultraGridColumn111.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn111.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn111.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn111.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(102, 0);
            ultraGridColumn111.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn111.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn111.TabIndex = 4;
            ultraGridColumn111.Width = 70;
            ultraGridColumn112.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn112.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn112.Header.VisiblePosition = 5;
            ultraGridColumn112.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn112.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn112.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(723, 57);
            ultraGridColumn112.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(723, 0);
            ultraGridColumn112.RowLayoutColumnInfo.SpanX = 16;
            ultraGridColumn112.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn112.TabIndex = 12;
            ultraGridColumn112.Width = 70;
            ultraGridColumn113.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn113.Header.Caption = "O. Social ó Prepago";
            ultraGridColumn113.Header.VisiblePosition = 6;
            ultraGridColumn113.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn113.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn113.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(257, 0);
            ultraGridColumn113.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(257, 0);
            ultraGridColumn113.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn113.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn113.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn113.TabIndex = 7;
            ultraGridColumn114.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn114.Header.Caption = "Nº Af. Prepago";
            ultraGridColumn114.Header.VisiblePosition = 7;
            ultraGridColumn114.MaxLength = 50;
            ultraGridColumn114.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn114.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn114.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(124, 0);
            ultraGridColumn114.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(124, 0);
            ultraGridColumn114.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn114.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn114.TabIndex = 8;
            ultraGridColumn115.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance173.TextHAlignAsString = "Right";
            ultraGridColumn115.CellAppearance = appearance173;
            ultraGridColumn115.Header.VisiblePosition = 8;
            ultraGridColumn115.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn115.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn115.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn115.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn115.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn115.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(102, 0);
            ultraGridColumn115.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn115.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn115.TabIndex = 9;
            ultraGridColumn116.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn116.Header.VisiblePosition = 9;
            ultraGridColumn116.Hidden = true;
            ultraGridColumn116.TabStop = false;
            ultraGridColumn117.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn117.Header.Caption = "Incidente Externo";
            ultraGridColumn117.Header.VisiblePosition = 10;
            ultraGridColumn117.MaxLength = 30;
            ultraGridColumn117.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn117.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn117.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(199, 0);
            ultraGridColumn117.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn117.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn117.TabIndex = 11;
            ultraGridColumn118.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn118.DefaultCellValue = "False";
            ultraGridColumn118.Header.Caption = "Extra";
            ultraGridColumn118.Header.VisiblePosition = 11;
            ultraGridColumn118.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn118.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn118.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(41, 0);
            ultraGridColumn118.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(41, 0);
            ultraGridColumn118.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn118.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn118.TabIndex = 10;
            ultraGridColumn119.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn119.Header.Caption = "Doc";
            ultraGridColumn119.Header.VisiblePosition = 12;
            ultraGridColumn119.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn119.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn119.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(55, 0);
            ultraGridColumn119.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(55, 0);
            ultraGridColumn119.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn119.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn119.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn119.TabIndex = 5;
            appearance174.TextHAlignAsString = "Right";
            ultraGridColumn120.CellAppearance = appearance174;
            ultraGridColumn120.Header.Caption = "N° Doc";
            ultraGridColumn120.Header.VisiblePosition = 13;
            ultraGridColumn120.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn120.MaskInput = "{LOC}nnn,nnn,nnn,nnn";
            ultraGridColumn120.MaxLength = 9;
            ultraGridColumn120.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn120.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn120.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(144, 0);
            ultraGridColumn120.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn120.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn120.TabIndex = 6;
            ultraGridColumn121.Header.VisiblePosition = 14;
            ultraGridColumn121.Hidden = true;
            ultraGridColumn122.Header.VisiblePosition = 15;
            ultraGridColumn122.Hidden = true;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn107,
            ultraGridColumn108,
            ultraGridColumn109,
            ultraGridColumn110,
            ultraGridColumn111,
            ultraGridColumn112,
            ultraGridColumn113,
            ultraGridColumn114,
            ultraGridColumn115,
            ultraGridColumn116,
            ultraGridColumn117,
            ultraGridColumn118,
            ultraGridColumn119,
            ultraGridColumn120,
            ultraGridColumn121,
            ultraGridColumn122});
            ultraGridBand9.MaxRows = 1;
            ultraGridBand9.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand9.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraGridPaciente.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraGridPaciente.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraGridPaciente.DisplayLayout.InterBandSpacing = 10;
            this.ultraGridPaciente.DisplayLayout.MaxBandDepth = 5;
            appearance14.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGridPaciente.DisplayLayout.Override.ActiveCellAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance15.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraGridPaciente.DisplayLayout.Override.ActiveRowAppearance = appearance15;
            this.ultraGridPaciente.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraGridPaciente.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGridPaciente.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridPaciente.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraGridPaciente.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridPaciente.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraGridPaciente.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance16.BackColor = System.Drawing.Color.Transparent;
            this.ultraGridPaciente.DisplayLayout.Override.CardAreaAppearance = appearance16;
            appearance17.BackColor = System.Drawing.SystemColors.Control;
            appearance17.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridPaciente.DisplayLayout.Override.CellAppearance = appearance17;
            this.ultraGridPaciente.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance18.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance18.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGridPaciente.DisplayLayout.Override.HeaderAppearance = appearance18;
            this.ultraGridPaciente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance19.ForeColor = System.Drawing.Color.Red;
            this.ultraGridPaciente.DisplayLayout.Override.RowSelectorAppearance = appearance19;
            this.ultraGridPaciente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridPaciente.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGridPaciente.DisplayLayout.Override.SelectedCellAppearance = appearance20;
            appearance21.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance21.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridPaciente.DisplayLayout.Override.SelectedRowAppearance = appearance21;
            appearance85.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance85.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraGridPaciente.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance85;
            this.ultraGridPaciente.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraGridPaciente.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGridPaciente.DisplayLayout.UseFixedHeaders = true;
            this.ultraGridPaciente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGridPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGridPaciente.Location = new System.Drawing.Point(5, 23);
            this.ultraGridPaciente.Name = "ultraGridPaciente";
            this.ultraGridPaciente.Size = new System.Drawing.Size(481, 148);
            this.ultraGridPaciente.TabIndex = 4;
            this.ultraGridPaciente.AfterEnterEditMode += new System.EventHandler(this.UltraGridPacienteAfterEnterEditMode);
            this.ultraGridPaciente.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.UltraGridPacienteCellChange);
            this.ultraGridPaciente.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.UltraGridPacienteBeforeCellDeactivate);
            this.ultraGridPaciente.Enter += new System.EventHandler(this.UltraGridPacienteEnter);
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
            ultraDataColumn21.DataType = typeof(bool);
            ultraDataColumn21.DefaultValue = false;
            ultraDataColumn22.DataType = typeof(int);
            ultraDataColumn24.DataType = typeof(decimal);
            ultraDataColumn25.DataType = typeof(int);
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
            ultraDataColumn24,
            ultraDataColumn25});
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
            // ultraDropDownTiposDeDocumento
            // 
            this.ultraDropDownTiposDeDocumento.DataSource = this.tiposDeDocumentoBindingSource;
            appearance144.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance144.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance144.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Appearance = appearance144;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand10.ColHeadersVisible = false;
            ultraGridColumn123.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn123.Header.VisiblePosition = 0;
            ultraGridColumn123.Hidden = true;
            ultraGridColumn123.Width = 85;
            ultraGridColumn124.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn124.Header.VisiblePosition = 1;
            ultraGridColumn124.Hidden = true;
            ultraGridColumn124.Width = 231;
            ultraGridColumn125.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn125.Header.VisiblePosition = 2;
            ultraGridColumn125.Width = 231;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn123,
            ultraGridColumn124,
            ultraGridColumn125});
            this.ultraDropDownTiposDeDocumento.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
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
            this.ultraDropDownTiposDeDocumento.Location = new System.Drawing.Point(156, 71);
            this.ultraDropDownTiposDeDocumento.Name = "ultraDropDownTiposDeDocumento";
            this.ultraDropDownTiposDeDocumento.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeDocumento.TabIndex = 53;
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
            // ultraGroupBoxContrato
            // 
            this.ultraGroupBoxContrato.Controls.Add(this.ultraComboContratos);
            this.ultraGroupBoxContrato.Controls.Add(this.ultraTextEditorCondContrato);
            this.ultraGroupBoxContrato.Controls.Add(this.buttonBuscarContrato);
            appearance108.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance108.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance108.FontData.BoldAsString = "True";
            appearance108.FontData.SizeInPoints = 9F;
            appearance108.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxContrato.HeaderAppearance = appearance108;
            this.ultraGroupBoxContrato.Location = new System.Drawing.Point(12, 499);
            this.ultraGroupBoxContrato.Name = "ultraGroupBoxContrato";
            this.ultraGroupBoxContrato.Size = new System.Drawing.Size(459, 113);
            this.ultraGroupBoxContrato.TabIndex = 8;
            this.ultraGroupBoxContrato.Text = "Contrato";
            this.ultraGroupBoxContrato.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraComboContratos
            // 
            this.ultraComboContratos.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboContratos.DataSource = this.contratosBindingSource;
            appearance87.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance87.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboContratos.DisplayLayout.Appearance = appearance87;
            this.ultraComboContratos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand11.ColHeadersVisible = false;
            ultraGridColumn126.Header.VisiblePosition = 0;
            ultraGridColumn126.Hidden = true;
            ultraGridColumn126.Width = 244;
            ultraGridColumn127.Header.VisiblePosition = 1;
            ultraGridColumn127.Hidden = true;
            ultraGridColumn127.Width = 55;
            ultraGridColumn128.Header.VisiblePosition = 2;
            ultraGridColumn128.Hidden = true;
            ultraGridColumn128.Width = 66;
            ultraGridColumn129.Header.VisiblePosition = 4;
            ultraGridColumn129.Width = 59;
            ultraGridColumn130.Header.VisiblePosition = 3;
            ultraGridColumn130.Width = 370;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn126,
            ultraGridColumn127,
            ultraGridColumn128,
            ultraGridColumn129,
            ultraGridColumn130});
            this.ultraComboContratos.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraComboContratos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboContratos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance88.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance88.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance88.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboContratos.DisplayLayout.GroupByBox.Appearance = appearance88;
            appearance89.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboContratos.DisplayLayout.GroupByBox.BandLabelAppearance = appearance89;
            this.ultraComboContratos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboContratos.DisplayLayout.GroupByBox.Hidden = true;
            appearance98.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance98.BackColor2 = System.Drawing.SystemColors.Control;
            appearance98.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance98.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboContratos.DisplayLayout.GroupByBox.PromptAppearance = appearance98;
            this.ultraComboContratos.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboContratos.DisplayLayout.MaxBandDepth = 5;
            this.ultraComboContratos.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboContratos.DisplayLayout.MaxRowScrollRegions = 1;
            appearance99.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboContratos.DisplayLayout.Override.ActiveCellAppearance = appearance99;
            appearance100.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance100.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance100.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboContratos.DisplayLayout.Override.ActiveRowAppearance = appearance100;
            this.ultraComboContratos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboContratos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboContratos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboContratos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboContratos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboContratos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboContratos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboContratos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboContratos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance101.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboContratos.DisplayLayout.Override.CardAreaAppearance = appearance101;
            appearance102.BackColor = System.Drawing.SystemColors.Control;
            appearance102.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboContratos.DisplayLayout.Override.CellAppearance = appearance102;
            this.ultraComboContratos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboContratos.DisplayLayout.Override.CellPadding = 0;
            this.ultraComboContratos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance103.BackColor = System.Drawing.SystemColors.Control;
            appearance103.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance103.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance103.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance103.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboContratos.DisplayLayout.Override.GroupByRowAppearance = appearance103;
            appearance104.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance104.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance104.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance104.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboContratos.DisplayLayout.Override.HeaderAppearance = appearance104;
            this.ultraComboContratos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboContratos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance105.BackColor = System.Drawing.SystemColors.Window;
            appearance105.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboContratos.DisplayLayout.Override.RowAppearance = appearance105;
            appearance106.ForeColor = System.Drawing.Color.Red;
            this.ultraComboContratos.DisplayLayout.Override.RowSelectorAppearance = appearance106;
            this.ultraComboContratos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboContratos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance107.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboContratos.DisplayLayout.Override.SelectedCellAppearance = appearance107;
            appearance164.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance164.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance164.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboContratos.DisplayLayout.Override.SelectedRowAppearance = appearance164;
            appearance165.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboContratos.DisplayLayout.Override.TemplateAddRowAppearance = appearance165;
            appearance166.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance166.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboContratos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance166;
            this.ultraComboContratos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboContratos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboContratos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboContratos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboContratos.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboContratos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboContratos.DisplayMember = "Contrato";
            this.ultraComboContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraComboContratos.LimitToList = true;
            this.ultraComboContratos.Location = new System.Drawing.Point(6, 23);
            this.ultraComboContratos.Name = "ultraComboContratos";
            this.ultraComboContratos.Size = new System.Drawing.Size(448, 22);
            this.ultraComboContratos.TabIndex = 8;
            this.ultraComboContratos.ValueMember = "idContrato";
            this.ultraComboContratos.ValueChanged += new System.EventHandler(this.UltraComboContratosValueChanged);
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
            this.ultraTextEditorCondContrato.Size = new System.Drawing.Size(389, 58);
            this.ultraTextEditorCondContrato.TabIndex = 6;
            this.ultraTextEditorCondContrato.TabStop = false;
            // 
            // buttonBuscarContrato
            // 
            this.buttonBuscarContrato.Location = new System.Drawing.Point(400, 85);
            this.buttonBuscarContrato.Name = "buttonBuscarContrato";
            this.buttonBuscarContrato.Size = new System.Drawing.Size(54, 23);
            this.buttonBuscarContrato.TabIndex = 5;
            this.buttonBuscarContrato.TabStop = false;
            this.buttonBuscarContrato.Text = "Buscar";
            this.buttonBuscarContrato.UseVisualStyleBackColor = true;
            this.buttonBuscarContrato.Click += new System.EventHandler(this.ButtonBuscarContratoClick);
            // 
            // ultraGroupBoxObservaciones
            // 
            this.ultraGroupBoxObservaciones.Controls.Add(this.ultraTextEditorObservaciones);
            appearance109.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance109.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance109.FontData.BoldAsString = "True";
            appearance109.FontData.SizeInPoints = 9F;
            appearance109.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxObservaciones.HeaderAppearance = appearance109;
            this.ultraGroupBoxObservaciones.Location = new System.Drawing.Point(481, 499);
            this.ultraGroupBoxObservaciones.Name = "ultraGroupBoxObservaciones";
            this.ultraGroupBoxObservaciones.Size = new System.Drawing.Size(253, 114);
            this.ultraGroupBoxObservaciones.TabIndex = 9;
            this.ultraGroupBoxObservaciones.Text = "Observaciones de la Prestación";
            this.ultraGroupBoxObservaciones.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraTextEditorObservaciones
            // 
            this.ultraTextEditorObservaciones.AcceptsReturn = true;
            this.ultraTextEditorObservaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.VisualStudio2005;
            this.ultraTextEditorObservaciones.Location = new System.Drawing.Point(6, 23);
            this.ultraTextEditorObservaciones.Multiline = true;
            this.ultraTextEditorObservaciones.Name = "ultraTextEditorObservaciones";
            this.ultraTextEditorObservaciones.Scrollbars = System.Windows.Forms.ScrollBars.Vertical;
            this.ultraTextEditorObservaciones.Size = new System.Drawing.Size(243, 86);
            this.ultraTextEditorObservaciones.TabIndex = 9;
            this.ultraTextEditorObservaciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UltraTextEditorObservacionesKeyDown);
            // 
            // ultraGroupBoxMotivos
            // 
            this.ultraGroupBoxMotivos.Controls.Add(this.ultraDropDownMotivos);
            this.ultraGroupBoxMotivos.Controls.Add(this.motivosPacientesUltraGrid);
            appearance132.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance132.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance132.FontData.BoldAsString = "True";
            appearance132.FontData.SizeInPoints = 9F;
            appearance132.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxMotivos.HeaderAppearance = appearance132;
            this.ultraGroupBoxMotivos.Location = new System.Drawing.Point(12, 214);
            this.ultraGroupBoxMotivos.Name = "ultraGroupBoxMotivos";
            this.ultraGroupBoxMotivos.Size = new System.Drawing.Size(718, 93);
            this.ultraGroupBoxMotivos.TabIndex = 3;
            this.ultraGroupBoxMotivos.Text = "Motivos de Llamado";
            this.ultraGroupBoxMotivos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraDropDownMotivos
            // 
            this.ultraDropDownMotivos.DataSource = this.motivosDeLlamadoBindingSource;
            appearance110.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance110.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance110.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotivos.DisplayLayout.Appearance = appearance110;
            this.ultraDropDownMotivos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand12.ColHeadersVisible = false;
            ultraGridColumn131.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn131.Header.VisiblePosition = 0;
            ultraGridColumn131.Hidden = true;
            ultraGridColumn131.Width = 60;
            ultraGridColumn132.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn132.Header.VisiblePosition = 1;
            ultraGridColumn132.Width = 219;
            ultraGridColumn133.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn133.Header.VisiblePosition = 2;
            ultraGridColumn133.Hidden = true;
            ultraGridColumn133.Width = 53;
            ultraGridColumn134.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn134.Header.VisiblePosition = 3;
            ultraGridColumn134.Hidden = true;
            ultraGridColumn134.Width = 53;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn131,
            ultraGridColumn132,
            ultraGridColumn133,
            ultraGridColumn134});
            this.ultraDropDownMotivos.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraDropDownMotivos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotivos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotivos.DisplayLayout.MaxBandDepth = 5;
            appearance111.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotivos.DisplayLayout.Override.ActiveCellAppearance = appearance111;
            appearance112.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance112.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance112.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotivos.DisplayLayout.Override.ActiveRowAppearance = appearance112;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance113.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotivos.DisplayLayout.Override.CardAreaAppearance = appearance113;
            appearance114.BackColor = System.Drawing.SystemColors.Control;
            appearance114.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance114.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivos.DisplayLayout.Override.CellAppearance = appearance114;
            this.ultraDropDownMotivos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance115.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance115.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance115.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance115.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance115.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotivos.DisplayLayout.Override.HeaderAppearance = appearance115;
            this.ultraDropDownMotivos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance116.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotivos.DisplayLayout.Override.RowSelectorAppearance = appearance116;
            this.ultraDropDownMotivos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance117.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotivos.DisplayLayout.Override.SelectedCellAppearance = appearance117;
            appearance118.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance118.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance118.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivos.DisplayLayout.Override.SelectedRowAppearance = appearance118;
            appearance119.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance119.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotivos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance119;
            this.ultraDropDownMotivos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotivos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotivos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotivos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotivos.DisplayMember = "Nombre";
            this.ultraDropDownMotivos.DropDownWidth = 0;
            this.ultraDropDownMotivos.Location = new System.Drawing.Point(479, 23);
            this.ultraDropDownMotivos.Name = "ultraDropDownMotivos";
            this.ultraDropDownMotivos.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownMotivos.TabIndex = 15;
            this.ultraDropDownMotivos.TabStop = false;
            this.ultraDropDownMotivos.ValueMember = "idMotivoDeLlamado";
            this.ultraDropDownMotivos.Visible = false;
            this.ultraDropDownMotivos.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownMotivosRowSelected);
            // 
            // motivosDeLlamadoBindingSource
            // 
            this.motivosDeLlamadoBindingSource.DataMember = "MotivosDeLlamado";
            this.motivosDeLlamadoBindingSource.DataSource = this.dsMotivosDeLlamado;
            // 
            // dsMotivosDeLlamado
            // 
            this.dsMotivosDeLlamado.DataSetName = "DsMotivosDeLlamado";
            this.dsMotivosDeLlamado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motivosPacientesUltraGrid
            // 
            this.motivosPacientesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.motivosPacientesUltraGrid.DataSource = this.ultraDataSourceMotivos;
            appearance120.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance120.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance120.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.motivosPacientesUltraGrid.DisplayLayout.Appearance = appearance120;
            this.motivosPacientesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand13.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand13.CardSettings.ShowCaption = false;
            ultraGridBand13.CardView = true;
            ultraGridColumn135.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn135.Header.VisiblePosition = 0;
            ultraGridColumn135.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn135.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn135.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(172, 0);
            ultraGridColumn135.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn135.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn135.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn135.Width = 360;
            ultraGridColumn136.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn136.Header.VisiblePosition = 1;
            ultraGridColumn136.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn136.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn136.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(172, 0);
            ultraGridColumn136.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn136.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn136.Width = 310;
            ultraGridColumn137.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance175.TextHAlignAsString = "Center";
            ultraGridColumn137.CellAppearance = appearance175;
            ultraGridColumn137.Header.VisiblePosition = 2;
            ultraGridColumn137.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn137.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn137.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn137.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn137.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn137.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn138.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance176.TextHAlignAsString = "Center";
            ultraGridColumn138.CellAppearance = appearance176;
            ultraGridColumn138.Header.VisiblePosition = 3;
            ultraGridColumn138.RowLayoutColumnInfo.OriginX = 1;
            ultraGridColumn138.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn138.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn138.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn138.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn138.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn135,
            ultraGridColumn136,
            ultraGridColumn137,
            ultraGridColumn138});
            ultraGridBand13.MaxRows = 4;
            ultraGridBand13.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand13.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.motivosPacientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.motivosPacientesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.motivosPacientesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.motivosPacientesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance123.BackColor = System.Drawing.SystemColors.Window;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance123;
            appearance124.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance124.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance124.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance124.ForeColor = System.Drawing.SystemColors.WindowText;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance124;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance125.BackColor = System.Drawing.Color.Transparent;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance125;
            appearance126.BackColor = System.Drawing.SystemColors.Control;
            appearance126.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance126.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.CellAppearance = appearance126;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance127.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance127.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance127.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance127.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance127.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance127;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance128.ForeColor = System.Drawing.Color.Red;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance128;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance129;
            appearance130.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance130.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance130.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance130;
            appearance131.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance131.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.motivosPacientesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance131;
            this.motivosPacientesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.motivosPacientesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.motivosPacientesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.motivosPacientesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.motivosPacientesUltraGrid.Location = new System.Drawing.Point(5, 23);
            this.motivosPacientesUltraGrid.Name = "motivosPacientesUltraGrid";
            this.motivosPacientesUltraGrid.Size = new System.Drawing.Size(708, 65);
            this.motivosPacientesUltraGrid.TabIndex = 0;
            this.motivosPacientesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.motivosPacientesUltraGrid_AfterEnterEditMode);
            this.motivosPacientesUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.MotivosPacientesUltraGridCellChange);
            this.motivosPacientesUltraGrid.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.MotivosPacientesUltraGridClickCellButton);
            this.motivosPacientesUltraGrid.Enter += new System.EventHandler(this.MotivosPacientesUltraGridEnter);
            this.motivosPacientesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.motivosPacientesUltraGrid_KeyDown);
            // 
            // ultraDataSourceMotivos
            // 
            ultraDataColumn26.DataType = typeof(int);
            this.ultraDataSourceMotivos.Band.Columns.AddRange(new object[] {
            ultraDataColumn26,
            ultraDataColumn27});
            this.ultraDataSourceMotivos.Band.Key = "MotivosPacientes";
            // 
            // ultraGroupBoxTelefono
            // 
            this.ultraGroupBoxTelefono.Controls.Add(this.buttonBuscarTelefono);
            this.ultraGroupBoxTelefono.Controls.Add(this.textBoxTelefono);
            appearance133.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance133.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance133.FontData.BoldAsString = "True";
            appearance133.FontData.SizeInPoints = 9F;
            appearance133.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxTelefono.HeaderAppearance = appearance133;
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
            this.ultraDateTimeEditorTomada.Location = new System.Drawing.Point(569, 26);
            this.ultraDateTimeEditorTomada.MaskInput = "dd/mm/yyyy hh:mm:ss";
            this.ultraDateTimeEditorTomada.Name = "ultraDateTimeEditorTomada";
            this.ultraDateTimeEditorTomada.Size = new System.Drawing.Size(144, 21);
            this.ultraDateTimeEditorTomada.TabIndex = 9;
            this.ultraDateTimeEditorTomada.Value = new System.DateTime(1947, 1, 21, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTelefonoNoEncontrado);
            this.panel2.Location = new System.Drawing.Point(194, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 52);
            this.panel2.TabIndex = 20;
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
            // ultraGroupBoxPractica
            // 
            this.ultraGroupBoxPractica.Controls.Add(this.ultraComboPracticas);
            this.ultraGroupBoxPractica.Controls.Add(this.ultraGrid1);
            this.ultraGroupBoxPractica.Controls.Add(this.ultraGrid2);
            appearance90.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance90.BackColor2 = System.Drawing.SystemColors.InactiveCaption;
            appearance90.FontData.BoldAsString = "True";
            appearance90.FontData.SizeInPoints = 9F;
            appearance90.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraGroupBoxPractica.HeaderAppearance = appearance90;
            this.ultraGroupBoxPractica.Location = new System.Drawing.Point(569, 441);
            this.ultraGroupBoxPractica.Name = "ultraGroupBoxPractica";
            this.ultraGroupBoxPractica.Size = new System.Drawing.Size(161, 51);
            this.ultraGroupBoxPractica.TabIndex = 7;
            this.ultraGroupBoxPractica.Text = "Práctica";
            this.ultraGroupBoxPractica.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005;
            // 
            // ultraComboPracticas
            // 
            this.ultraComboPracticas.AllowNull = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboPracticas.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboPracticas.DataSource = this.practicasBindingSource;
            appearance134.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance134.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboPracticas.DisplayLayout.Appearance = appearance134;
            this.ultraComboPracticas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand14.ColHeadersVisible = false;
            ultraGridColumn139.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn139.Header.VisiblePosition = 0;
            ultraGridColumn139.Hidden = true;
            ultraGridColumn139.Width = 53;
            ultraGridColumn140.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn140.Header.VisiblePosition = 1;
            ultraGridColumn140.Width = 131;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn139,
            ultraGridColumn140});
            this.ultraComboPracticas.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraComboPracticas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboPracticas.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboPracticas.DisplayLayout.MaxBandDepth = 5;
            appearance135.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboPracticas.DisplayLayout.Override.ActiveCellAppearance = appearance135;
            appearance136.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance136.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance136.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboPracticas.DisplayLayout.Override.ActiveRowAppearance = appearance136;
            this.ultraComboPracticas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboPracticas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboPracticas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPracticas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboPracticas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboPracticas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboPracticas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance137.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboPracticas.DisplayLayout.Override.CardAreaAppearance = appearance137;
            appearance138.BackColor = System.Drawing.SystemColors.Control;
            appearance138.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance138.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboPracticas.DisplayLayout.Override.CellAppearance = appearance138;
            this.ultraComboPracticas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance139.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance139.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance139.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance139.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance139.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboPracticas.DisplayLayout.Override.HeaderAppearance = appearance139;
            this.ultraComboPracticas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance140.ForeColor = System.Drawing.Color.Red;
            this.ultraComboPracticas.DisplayLayout.Override.RowSelectorAppearance = appearance140;
            this.ultraComboPracticas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance141.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboPracticas.DisplayLayout.Override.SelectedCellAppearance = appearance141;
            appearance142.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance142.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance142.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboPracticas.DisplayLayout.Override.SelectedRowAppearance = appearance142;
            appearance143.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance143.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboPracticas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance143;
            this.ultraComboPracticas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboPracticas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboPracticas.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboPracticas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboPracticas.DisplayMember = "Nombre";
            this.ultraComboPracticas.LimitToList = true;
            this.ultraComboPracticas.Location = new System.Drawing.Point(5, 23);
            this.ultraComboPracticas.Name = "ultraComboPracticas";
            this.ultraComboPracticas.Size = new System.Drawing.Size(150, 22);
            this.ultraComboPracticas.TabIndex = 7;
            this.ultraComboPracticas.ValueMember = "idPractica";
            this.ultraComboPracticas.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboPracticasRowSelected);
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
            // ultraDropDownPrepagos
            // 
            this.ultraDropDownPrepagos.DataSource = this.prepagosBindingSource;
            appearance91.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance91.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrepagos.DisplayLayout.Appearance = appearance91;
            this.ultraDropDownPrepagos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand15.ColHeadersVisible = false;
            ultraGridColumn141.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn141.Header.VisiblePosition = 0;
            ultraGridColumn141.Hidden = true;
            ultraGridColumn141.Width = 55;
            ultraGridColumn142.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn142.Header.VisiblePosition = 1;
            ultraGridColumn142.Width = 219;
            ultraGridColumn143.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn143.Header.VisiblePosition = 2;
            ultraGridColumn143.Hidden = true;
            ultraGridColumn143.Width = 109;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn141,
            ultraGridColumn142,
            ultraGridColumn143});
            this.ultraDropDownPrepagos.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.ultraDropDownPrepagos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrepagos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrepagos.DisplayLayout.MaxBandDepth = 5;
            appearance92.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveCellAppearance = appearance92;
            appearance93.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance93.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance93.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveRowAppearance = appearance93;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance94.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CardAreaAppearance = appearance94;
            appearance95.BackColor = System.Drawing.SystemColors.Control;
            appearance95.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CellAppearance = appearance95;
            this.ultraDropDownPrepagos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance96.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance96.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance96.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance96.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderAppearance = appearance96;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance121.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSelectorAppearance = appearance121;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance122.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedCellAppearance = appearance122;
            appearance163.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance163.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance163.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedRowAppearance = appearance163;
            appearance154.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance154.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrepagos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance154;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrepagos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrepagos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrepagos.DisplayMember = "Nombre";
            this.ultraDropDownPrepagos.DropDownWidth = 0;
            this.ultraDropDownPrepagos.Location = new System.Drawing.Point(252, 310);
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
            // buttonAtencionesAnteriores
            // 
            this.buttonAtencionesAnteriores.Location = new System.Drawing.Point(496, 13);
            this.buttonAtencionesAnteriores.Name = "buttonAtencionesAnteriores";
            this.buttonAtencionesAnteriores.Size = new System.Drawing.Size(150, 23);
            this.buttonAtencionesAnteriores.TabIndex = 3;
            this.buttonAtencionesAnteriores.TabStop = false;
            this.buttonAtencionesAnteriores.Text = "Atenciones Anteriores";
            this.buttonAtencionesAnteriores.UseVisualStyleBackColor = true;
            this.buttonAtencionesAnteriores.Click += new System.EventHandler(this.ButtonAtencionesAnterioresClick);
            // 
            // ultraComboMotivoDeCancelacion
            // 
            this.ultraComboMotivoDeCancelacion.DataSource = this.motivosDeCancelacionPrestacionBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Appearance = appearance1;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn77.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn77.Header.VisiblePosition = 0;
            ultraGridColumn77.Hidden = true;
            ultraGridColumn77.Width = 137;
            ultraGridColumn78.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn78.Header.VisiblePosition = 1;
            ultraGridColumn78.Width = 251;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn77,
            ultraGridColumn78});
            this.ultraComboMotivoDeCancelacion.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraComboMotivoDeCancelacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.MaxBandDepth = 5;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance3.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.CardAreaAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.Control;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.ForeColor = System.Drawing.Color.Red;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance9.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance10;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraComboMotivoDeCancelacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboMotivoDeCancelacion.DisplayMember = "Nombre";
            this.ultraComboMotivoDeCancelacion.LimitToList = true;
            this.ultraComboMotivoDeCancelacion.Location = new System.Drawing.Point(136, 14);
            this.ultraComboMotivoDeCancelacion.Name = "ultraComboMotivoDeCancelacion";
            this.ultraComboMotivoDeCancelacion.Size = new System.Drawing.Size(270, 22);
            this.ultraComboMotivoDeCancelacion.TabIndex = 10;
            this.ultraComboMotivoDeCancelacion.TabStop = false;
            this.ultraComboMotivoDeCancelacion.ValueMember = "idMotivoDeCancelacionPrestacion";
            this.ultraComboMotivoDeCancelacion.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraComboMotivoDeCancelacionRowSelected);
            this.ultraComboMotivoDeCancelacion.ItemNotInList += new Infragistics.Win.UltraWinGrid.ItemNotInListEventHandler(this.UltraComboMotivoDeCancelacionItemNotInList);
            // 
            // motivosDeCancelacionPrestacionBindingSource
            // 
            this.motivosDeCancelacionPrestacionBindingSource.DataMember = "MotivosDeCancelacionPrestacion";
            this.motivosDeCancelacionPrestacionBindingSource.DataSource = this.dsMotivosDeCancelacionPrestacion;
            // 
            // dsMotivosDeCancelacionPrestacion
            // 
            this.dsMotivosDeCancelacionPrestacion.DataSetName = "DsMotivosDeCancelacionPrestacion";
            this.dsMotivosDeCancelacionPrestacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelMotivoCancelacion
            // 
            this.labelMotivoCancelacion.AutoSize = true;
            this.labelMotivoCancelacion.Location = new System.Drawing.Point(14, 18);
            this.labelMotivoCancelacion.Name = "labelMotivoCancelacion";
            this.labelMotivoCancelacion.Size = new System.Drawing.Size(116, 13);
            this.labelMotivoCancelacion.TabIndex = 10;
            this.labelMotivoCancelacion.Text = "Motivo de Cancelación";
            // 
            // buttonCancelarNuevo
            // 
            this.buttonCancelarNuevo.Location = new System.Drawing.Point(415, 14);
            this.buttonCancelarNuevo.Name = "buttonCancelarNuevo";
            this.buttonCancelarNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarNuevo.TabIndex = 11;
            this.buttonCancelarNuevo.TabStop = false;
            this.buttonCancelarNuevo.Text = "Cancelar";
            this.buttonCancelarNuevo.UseVisualStyleBackColor = true;
            this.buttonCancelarNuevo.Click += new System.EventHandler(this.ButtonCancelarNuevoClick);
            // 
            // dsBuscarAfiliados
            // 
            this.dsBuscarAfiliados.DataSetName = "DsBuscarAfiliados";
            this.dsBuscarAfiliados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarAfiliadosBindingSource
            // 
            this.buscarAfiliadosBindingSource.DataMember = "BuscarAfiliados";
            this.buscarAfiliadosBindingSource.DataSource = this.dsBuscarAfiliados;
            // 
            // dsBuscarTelefono
            // 
            this.dsBuscarTelefono.DataSetName = "DsBuscarTelefono";
            this.dsBuscarTelefono.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dsPacientesPrestacion1
            // 
            this.dsPacientesPrestacion1.DataSetName = "DsPacientesPrestacion";
            this.dsPacientesPrestacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormTomarLlamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(744, 656);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ultraDateTimeEditorTomada);
            this.Controls.Add(this.ultraGroupBoxContrato);
            this.Controls.Add(this.ultraGroupBoxPaciente);
            this.Controls.Add(this.ultraGroupBoxObservaciones);
            this.Controls.Add(this.ultraGroupBoxCobertura);
            this.Controls.Add(this.ultraGroupBoxTelefono);
            this.Controls.Add(this.ultraGroupBoxMotivos);
            this.Controls.Add(this.ultraGroupBoxDirección);
            this.Controls.Add(this.ultraGroupBoxCodigo);
            this.Controls.Add(this.ultraGroupBoxPractica);
            this.Controls.Add(this.ultraDropDownPrepagos);
            this.MinimumSize = new System.Drawing.Size(751, 625);
            this.Name = "FormTomarLlamado";
            this.Text = "Tomar un llamado";
            this.Load += new System.EventHandler(this.FormTomarLlamadoLoad);
            this.Controls.SetChildIndex(this.ultraDropDownPrepagos, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxPractica, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxCodigo, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxDirección, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxMotivos, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxTelefono, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxCobertura, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxObservaciones, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxPaciente, 0);
            this.Controls.SetChildIndex(this.ultraGroupBoxContrato, 0);
            this.Controls.SetChildIndex(this.ultraDateTimeEditorTomada, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.direccionesAfiliadosUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceDirecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxDirección)).EndInit();
            this.ultraGroupBoxDirección.ResumeLayout(false);
            this.ultraGroupBoxDirección.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboTiposDeDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidades1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxCodigo)).EndInit();
            this.ultraGroupBoxCodigo.ResumeLayout(false);
            this.ultraGroupBoxCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxContrato)).EndInit();
            this.ultraGroupBoxContrato.ResumeLayout(false);
            this.ultraGroupBoxContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorCondContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxObservaciones)).EndInit();
            this.ultraGroupBoxObservaciones.ResumeLayout(false);
            this.ultraGroupBoxObservaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditorObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxMotivos)).EndInit();
            this.ultraGroupBoxMotivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeLlamadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeLlamado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosPacientesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceMotivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxTelefono)).EndInit();
            this.ultraGroupBoxTelefono.ResumeLayout(false);
            this.ultraGroupBoxTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditorTomada)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBoxPractica)).EndInit();
            this.ultraGroupBoxPractica.ResumeLayout(false);
            this.ultraGroupBoxPractica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboMotivoDeCancelacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeCancelacionPrestacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeCancelacionPrestacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarAfiliados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAfiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPacientesPrestacion1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Button buttonBuscarTelefono;
        private Infragistics.Win.UltraWinGrid.UltraGrid direccionesAfiliadosUltraGrid;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxDirección;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxCodigo;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxCobertura;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxPaciente;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxContrato;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxObservaciones;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxMotivos;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxTelefono;
        private System.Windows.Forms.Button buttonBuscarDireccion;
        private Infragistics.Win.UltraWinGrid.UltraGrid motivosPacientesUltraGrid;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceMotivos;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceDirecciones;
        private System.Windows.Forms.Button buttonBuscarContrato;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridPaciente;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourcePaciente;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorObservaciones;
        private System.Windows.Forms.Button buttonBuscarPaciente;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditorCondContrato;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditorTomada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTelefonoNoEncontrado;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLocalidad;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCalles;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBarrios;
        private System.Windows.Forms.BindingSource barriosListaBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotivos;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboCodigos;
        private System.Windows.Forms.BindingSource codigosBindingSource;
        private System.Windows.Forms.BindingSource coberturasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboCobertura;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBoxPractica;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid2;
        private System.Windows.Forms.BindingSource practicasBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboPracticas;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboTiposDeDestino;
        private Infragistics.Win.Misc.UltraLabel ultraLabelTipoDeDestino;
        private System.Windows.Forms.BindingSource tiposDeDestinoBindingSource;
        private System.Windows.Forms.BindingSource buscarAfiliadosBindingSource;
        private System.Windows.Forms.BindingSource contratosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPrepagos;
        private System.Windows.Forms.BindingSource prepagosBindingSource;
        private System.Windows.Forms.Button buttonAtencionesAnteriores;
        private Infragistics.Win.UltraWinGrid.UltraCombo ultraComboMotivoDeCancelacion;
        private System.Windows.Forms.BindingSource motivosDeCancelacionPrestacionBindingSource;
        private System.Windows.Forms.Label labelMotivoCancelacion;
        private System.Windows.Forms.Button buttonCancelarNuevo;
        private System.Windows.Forms.BindingSource localidadesBindingSource;
        private System.Windows.Forms.BindingSource callesBindingSource;
        private System.Windows.Forms.BindingSource motivosDeLlamadoBindingSource;
        private System.Windows.Forms.BindingSource tiposDeDocumentoBindingSource;
        private UltraDropDown ultraDropDownTiposDeDocumento;
        private System.Windows.Forms.BindingSource sistemasBindingSource;
        private Cabina.WS.DsBarrios dsBarrios;
        private Cabina.WS.DsCodigos dsCodigos;
        private Cabina.WS.DsCoberturas dsCoberturas;
        private Cabina.WS.DsBuscarTelefono dsBuscarTelefono;
        private Cabina.WS.DsPracticas dsPracticas;
        private Cabina.WS.DsTiposDeDestino dsTiposDeDestino;
        private Cabina.WS.DsBuscarAfiliados dsBuscarAfiliados;
        private Cabina.WS.DsContratosLista dsContratosLista;
        private Cabina.WS.DsMotivosDeCancelacionPrestacion dsMotivosDeCancelacionPrestacion;
        private Cabina.WS.DsLocalidades dsLocalidades1;
        private Cabina.WS.DsCallesLista dsCallesLista;
        private Cabina.WS.DsMotivosDeLlamado dsMotivosDeLlamado;
        internal Cabina.WS.DsPrepagos dsPrepagos;
        private Cabina.WS.DsTiposDeDocumento dsTiposDeDocumento;
        private Cabina.WS.DsSistemas dsSistemas;
        private WS.DsPacientesPrestacion dsPacientesPrestacion1;
        private UltraCombo ultraComboContratos;
    }
}
