using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    partial class FormDespacho
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
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PrestacionesResumen", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn273 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn274 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn275 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.Appearance appearance271 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn276 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Direccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn277 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn278 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Edad");
            Infragistics.Win.Appearance appearance273 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn279 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Recurso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn280 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jerarquia");
            Infragistics.Win.Appearance appearance283 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn281 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Motivos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn282 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TiempoDeLlegada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn283 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Agendada");
            Infragistics.Win.Appearance appearance284 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance285 = new Infragistics.Win.Appearance();
            Infragistics.Win.ConditionValueAppearance conditionValueAppearance1 = new Infragistics.Win.ConditionValueAppearance(new Infragistics.Win.ICondition[] {
            ((Infragistics.Win.ICondition)(new Infragistics.Win.FormulaCondition("[AlertaProgramadaNoSalio] = 1"))),
            ((Infragistics.Win.ICondition)(new Infragistics.Win.FormulaCondition("[AlertaProgramadaNoSalio] = 0")))}, new Infragistics.Win.Appearance[] {
            appearance284,
            appearance285});
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn284 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlertaProgramadaNoSalio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn285 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsAgendada", 0);
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance286 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance287 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance288 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance289 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance290 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance291 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance292 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance293 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDespacho));
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prestaciones", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tomada");
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTomador", -1, "ultraDropDownTomadores");
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeCancelacion", -1, "ultraDropDownMotivosCancelacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ObservacionesTomador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Telefono");
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VistaPorElDespachador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Agendada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Terminada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo", -1, "ultraDropDownCodigos");
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe", 0);
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Imprimir", 1);
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand26 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Medicamentos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn472 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn473 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn474 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn475 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamentoCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn476 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidades");
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand27 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Diagnosticos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn477 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnostico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn478 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoCategoria");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn479 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand25 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeLlamado", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn468 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeLlamado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn469 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn470 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FichaDespacho");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn471 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FichaMasInfo");
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand24 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prepagos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn465 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn466 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn467 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance154 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand23 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Practicas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn463 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPractica");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn464 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance155 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance156 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance157 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance158 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance159 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance160 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance162 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance163 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand21 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Coberturas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn444 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn445 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance272 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand22 = new Infragistics.Win.UltraWinGrid.UltraGridBand("RecursosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn446 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRecurso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn447 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn448 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMovil");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn449 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn450 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn451 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idParamedico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn452 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idParamedico2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn453 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idChofer");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn454 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idChofer2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn455 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn456 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn457 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Color");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn458 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Direccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn459 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tripulacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn460 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestinoRecurso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn461 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Salidas");
            Infragistics.Win.Appearance appearance340 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn462 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Kolor", 0);
            Infragistics.Win.Appearance appearance341 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance274 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance275 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance276 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance277 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance278 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance279 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance280 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance281 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance282 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance174 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn340 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn341 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn342 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance175 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance176 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance177 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance178 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance179 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance180 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance181 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance182 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance183 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance184 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand31 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn490 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn491 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn492 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn493 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance185 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance186 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance187 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance188 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance189 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance190 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance191 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance192 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance193 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance194 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand30 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Localidades", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn488 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn489 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.Appearance appearance195 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance196 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance197 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance198 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance199 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance200 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance201 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance202 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance203 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance204 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand32 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Lugares", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn494 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn495 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn496 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn497 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocaldad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn498 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Lugares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn499 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Lugares");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand33 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Lugares", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn500 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn501 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn502 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn503 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn504 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn505 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn506 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn507 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn508 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn509 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn510 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn511 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn512 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Direcciones1");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand34 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Direcciones1", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn513 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn514 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn515 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn516 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn517 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand35 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Lugares", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn518 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn519 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn520 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn521 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn522 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn523 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn524 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Cotactos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand36 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Cotactos", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn525 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn526 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn527 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn528 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn529 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.Appearance appearance205 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance206 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance207 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance208 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance209 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance210 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance211 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance212 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance213 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance214 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand29 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeCancelacionPrestacion", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn486 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeCancelacionPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn487 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance215 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance216 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance217 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance218 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance219 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance220 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance221 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance222 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance223 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand20 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDestino", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn441 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn442 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn443 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConPacienteABordo");
            Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance120 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance121 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance122 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance303 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Destinos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn299 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn300 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn301 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraSolicitada");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn302 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar", -1, "ultraDropDownLugares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn303 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDestino", -1, "ultraDropDownTiposDeDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn304 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Orden");
            Infragistics.Win.Appearance appearance315 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn305 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Destinos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn306 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_DestinosRecursos_Destinos");
            Infragistics.Win.Appearance appearance316 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Destinos", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn307 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn308 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn309 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn310 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn311 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn312 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn313 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalles");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn314 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn315 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn316 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn317 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn318 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidad");
            Infragistics.Win.Appearance appearance317 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_DestinosRecursos_Destinos", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn319 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestinoRecurso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn320 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn321 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idRecurso", -1, "ultraDropDownRecursosActivos");
            Infragistics.Win.Appearance appearance318 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn322 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo");
            Infragistics.Win.Appearance appearance319 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn323 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMovil");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn324 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente", -1, "ultraDropDownPacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn325 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn326 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn327 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idParamedico1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn328 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idParamedico2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn329 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idChofer1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn330 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idChofer2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn331 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Asignado");
            Infragistics.Win.Appearance appearance320 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn332 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Salida");
            Infragistics.Win.Appearance appearance321 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn333 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Llegada");
            Infragistics.Win.Appearance appearance322 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn334 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Terminado");
            Infragistics.Win.Appearance appearance323 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn335 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cancelado");
            Infragistics.Win.Appearance appearance324 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn336 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn337 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugarDeSalida", -1, "ultraDropDownLugares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn338 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("OtroLugarDeSalida");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn339 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDespachador", -1, "ultraDropDownDespachador");
            Infragistics.Win.Appearance appearance325 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance326 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn343 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn344 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn345 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn346 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn347 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn348 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance84 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Pacientes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn349 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn350 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn351 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn352 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn353 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Edad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn354 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EdadEn");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn355 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sexo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn356 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn357 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAfiliadoPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn358 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenteExterno");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn359 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn360 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPractica");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn361 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn362 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Antecedentes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn363 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn364 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn365 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DatosCompletos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn366 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExtraCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn367 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn368 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn369 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Evolución");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn370 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CondicionesContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn371 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__MotivosPacientes__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn372 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Diagnosticos__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn373 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Medicamentos__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__MotivosPacientes__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn374 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn375 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeLlamado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn376 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn377 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Diagnosticos__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn378 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn379 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnostico");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn380 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Medicamentos__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn381 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamentosPacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn382 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn383 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn384 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn385 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn386 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn387 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion1 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion2 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(-7);
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("idEmpleado");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ApelNomb");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombApel");
            Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDocumento", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn388 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn389 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn390 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance148 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance149 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance150 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance151 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance152 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance153 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Codigos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn391 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCodigo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn392 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn393 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Color");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn394 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jerarquia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn395 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TiempoDeLlegada");
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Pacientes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn396 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn397 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrestacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn398 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn399 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn400 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Edad");
            Infragistics.Win.Appearance appearance327 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn401 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EdadEn");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn402 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sexo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn403 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago", -1, "ultraDropDownPrepagos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn404 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAfiliadoPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn405 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenteExterno");
            Infragistics.Win.Appearance appearance328 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn406 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobertura", -1, "ultraDropDownCoberturas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn407 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPractica", -1, "ultraDropDownPracticas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn408 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe");
            Infragistics.Win.Appearance appearance329 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn409 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Antecedentes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn410 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato", -1, "ultraDropDownContratos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn411 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedico", -1, "ultraDropDownMedicos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn412 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DatosCompletos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn413 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExtraCobertura");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn414 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento", -1, "ultraDropDownTiposDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn415 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeDocumento");
            Infragistics.Win.Appearance appearance330 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn416 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Evolución");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn417 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CondicionesContrato", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn418 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__MotivosPacientes__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn419 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Diagnosticos__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn420 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK__Medicamentos__Pacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn421 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BuscarAfiliado", 0);
            Infragistics.Win.Appearance appearance331 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn422 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsAfiliado", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn423 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AtencionesAnteriores", 2);
            Infragistics.Win.Appearance appearance332 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn424 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Planes", 3);
            Infragistics.Win.Appearance appearance333 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn425 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato", 4);
            Infragistics.Win.Appearance appearance334 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance335 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.RowLayout rowLayout1 = new Infragistics.Win.UltraWinGrid.RowLayout("Paciente");
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo1 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPaciente", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo2 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPrestacion", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo3 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idAfiliado", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo4 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Nombre", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo5 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Edad", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo6 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "EdadEn", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo7 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Sexo", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo8 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPrepago", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo9 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "NroAfiliadoPrepago", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo10 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenteExterno", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo11 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idCobertura", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo12 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPractica", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo13 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Importe", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo14 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Antecedentes", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo15 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idContrato", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo16 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idMedico", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo17 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DatosCompletos", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo18 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ExtraCobertura", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo19 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idTipoDeDocumento", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo20 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "NumeroDeDocumento", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo21 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Evolución", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo22 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CondicionesContrato", -1, Infragistics.Win.DefaultableBoolean.Default);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo23 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FK__MotivosPacientes__Pacientes", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo24 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FK__Diagnosticos__Pacientes", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo25 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FK__Medicamentos__Pacientes", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo26 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "BuscarAfiliado", 0, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo27 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "EsAfiliado", 1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo28 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "AtencionesAnteriores", 2, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo29 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Planes", 3, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo30 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Contrato", 4, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand16 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__MotivosPacientes__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn426 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn427 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeLlamado", -1, "ultraDropDownMotivos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn428 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn429 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.Appearance appearance336 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.RowLayout rowLayout2 = new Infragistics.Win.UltraWinGrid.RowLayout("Motivos");
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo31 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idMotivoPaciente", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo32 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idMotivoDeLlamado", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo33 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPaciente", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo34 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Observaciones", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand17 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Diagnosticos__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn430 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnosticoPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn431 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDiagnostico", -1, "ultraDropDownDiagnosticos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn432 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.Appearance appearance337 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.RowLayout rowLayout3 = new Infragistics.Win.UltraWinGrid.RowLayout("Diagnosticos");
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo35 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idDiagnosticoPaciente", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo36 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idDiagnostico", -1, Infragistics.Win.DefaultableBoolean.False);
            Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo rowLayoutColumnInfo37 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "idPaciente", -1, Infragistics.Win.DefaultableBoolean.True);
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand18 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK__Medicamentos__Pacientes", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn433 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamentosPacientes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn434 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicamento", -1, "ultraDropDownMedicamentos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn435 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPaciente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn436 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.Appearance appearance338 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn437 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidad", 0);
            Infragistics.Win.Appearance appearance339 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance235 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance255 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance256 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance257 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance164 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand19 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Contratos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn438 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn439 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Condiciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn440 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrato");
            Infragistics.Win.Appearance appearance165 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance166 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance167 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance168 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance169 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance170 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance171 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance172 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance173 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance245 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand28 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn480 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn481 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn482 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn483 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn484 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn485 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance246 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance247 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance248 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance249 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance250 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance251 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance252 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance253 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance254 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre");
            Infragistics.Win.Appearance appearance294 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand37 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn530 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Id");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn531 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance295 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance297 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance296 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance302 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance298 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance306 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance301 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance299 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance300 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance304 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance305 = new Infragistics.Win.Appearance();
            this.prestacionesResumenUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.prestacionesResumenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrestacionesResumen = new Cabina.WS.DsPrestacionesResumen();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.prestacionesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.prestacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrestacion = new Cabina.WS.DsPrestacion();
            this.ultraDropDownMedicamentos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.medicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMedicamentos = new Cabina.WS.DsMedicamentos();
            this.ultraDropDownDiagnosticos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDiagnosticos = new Cabina.WS.DsDiagnosticos();
            this.ultraDropDownMotivos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDeLlamadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeLlamado = new Cabina.WS.DsMotivosDeLlamado();
            this.ultraDropDownPrepagos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.prepagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrepagos = new Cabina.WS.DsPrepagos();
            this.ultraDropDownPracticas = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.practicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPracticas = new Cabina.WS.DsPracticas();
            this.ultraDropDownCoberturas = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.coberturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCoberturas = new Cabina.WS.DsCoberturas();
            this.ultraDropDownRecursosActivos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.recursosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecursosLista = new Cabina.WS.DsRecursosLista();
            this.ultraDropDownBarrio = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.barriosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarrios = new Cabina.WS.DsBarrios();
            this.ultraDropDownCalles = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.callesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCallesLista = new Cabina.WS.DsCallesLista();
            this.ultraDropDownLocalidad = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.localidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalidades1 = new Cabina.WS.DsLocalidades();
            this.ultraDropDownLugares = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.lugaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLugares = new Cabina.WS.DsLugares();
            this.ultraDropDownMotivosCancelacion = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDeCancelacionPrestacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeCancelacionPrestacion = new Cabina.WS.DsMotivosDeCancelacionPrestacion();
            this.ultraDropDownTiposDeDestino = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeDestinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDestino = new Cabina.WS.DsTiposDeDestino();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelEstadoGeneral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.destinosUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.destinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDestinos = new Cabina.WS.DsDestinos();
            this.ultraDropDownDespachador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.usuariosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuariosLista = new Cabina.WS.DsUsuariosLista();
            this.ultraDropDownPacientes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPacientesPrestacion = new Cabina.WS.DsPacientesPrestacion();
            this.ultraDropDownMedicos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDataSourceMedicos = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraDropDownTiposDeDocumento = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDocumento = new Cabina.WS.DsTiposDeDocumento();
            this.ultraDropDownCodigos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.codigosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodigos = new Cabina.WS.DsCodigos();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pacientesUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDropDownContratos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsContratosLista = new Cabina.WS.DsContratosLista();
            this.ultraDropDownTomadores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.buttonAgregarPaciente = new System.Windows.Forms.Button();
            this.buttonReferenciaColores = new System.Windows.Forms.Button();
            this.dsBuscarAfiliados = new Cabina.WS.DsBuscarAfiliados();
            this.buscarAfiliadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDireccionLugar1 = new Cabina.WS.DsDireccionLugar();
            this.dsCabBuscarTelefono = new Cabina.WS.DsCabBuscarTelefono();
            this.dsBuscarTelefono = new Cabina.WS.DsBuscarTelefono();
            this.dsSistemas1 = new Cabina.WS.DsSistemas();
            this.dsMedicos = new Cabina.WS.DsEmpleadosLista();
            this.dsDestinosOtro = new Cabina.WS.DsDestinos();
            this.buttonCerrarPrestacion = new System.Windows.Forms.Button();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraDataSourceVerAgendadas = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.ultraComboVerAgendadas = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.dsParametros = new Cabina.WS.DsParametros();
            this.parametrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesResumenUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesResumenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestacionesResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDiagnosticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiagnosticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeLlamadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeLlamado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCoberturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoberturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRecursosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecursosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidades1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLugares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosCancelacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeCancelacionPrestacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeCancelacionPrestacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinosUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDestinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDespachador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPacientesPrestacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarAfiliados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAfiliadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDireccionLugar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCabBuscarTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDestinosOtro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceVerAgendadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboVerAgendadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(824, 12);
            this.buttonAceptar.Text = "Grabar";
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Enabled = true;
            this.buttonAplicar.Location = new System.Drawing.Point(905, 12);
            this.buttonAplicar.Text = "Salir";
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAgregarPaciente);
            this.panel1.Controls.Add(this.buttonReferenciaColores);
            this.panel1.Controls.Add(this.ultraComboVerAgendadas);
            this.panel1.Controls.Add(this.ultraLabel1);
            this.panel1.Controls.Add(this.buttonCerrarPrestacion);
            this.panel1.Location = new System.Drawing.Point(0, 622);
            this.panel1.Size = new System.Drawing.Size(997, 42);
            this.panel1.Controls.SetChildIndex(this.buttonCerrarPrestacion, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.ultraLabel1, 0);
            this.panel1.Controls.SetChildIndex(this.ultraComboVerAgendadas, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonReferenciaColores, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAgregarPaciente, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(517, 12);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            this.buttonCancelar.Visible = false;
            // 
            // prestacionesResumenUltraGrid
            // 
            this.prestacionesResumenUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prestacionesResumenUltraGrid.CalcManager = this.ultraCalcManager1;
            this.prestacionesResumenUltraGrid.DataSource = this.prestacionesResumenBindingSource;
            appearance52.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.prestacionesResumenUltraGrid.DisplayLayout.Appearance = appearance52;
            this.prestacionesResumenUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn273.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn273.Header.VisiblePosition = 0;
            ultraGridColumn273.Hidden = true;
            ultraGridColumn273.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time;
            ultraGridColumn273.Width = 50;
            ultraGridColumn274.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn274.Header.VisiblePosition = 1;
            ultraGridColumn274.Hidden = true;
            ultraGridColumn274.Width = 46;
            ultraGridColumn275.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance271.ForeColor = System.Drawing.SystemColors.Window;
            ultraGridColumn275.CellAppearance = appearance271;
            ultraGridColumn275.Header.Caption = "";
            ultraGridColumn275.Header.VisiblePosition = 10;
            ultraGridColumn275.LockedWidth = true;
            ultraGridColumn275.MaxWidth = 15;
            ultraGridColumn275.MinWidth = 15;
            ultraGridColumn275.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(16, 0);
            ultraGridColumn275.Width = 15;
            ultraGridColumn276.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn276.Header.Caption = "Dirección";
            ultraGridColumn276.Header.VisiblePosition = 8;
            ultraGridColumn276.Width = 200;
            ultraGridColumn277.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn277.Header.VisiblePosition = 5;
            ultraGridColumn277.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(187, 0);
            ultraGridColumn277.Width = 177;
            ultraGridColumn278.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance273.TextHAlignAsString = "Right";
            ultraGridColumn278.CellAppearance = appearance273;
            ultraGridColumn278.Header.VisiblePosition = 6;
            ultraGridColumn278.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(59, 0);
            ultraGridColumn278.Width = 62;
            ultraGridColumn279.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn279.Header.VisiblePosition = 9;
            ultraGridColumn279.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(87, 0);
            ultraGridColumn279.Width = 75;
            ultraGridColumn280.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance283.ForeColor = System.Drawing.SystemColors.Window;
            ultraGridColumn280.CellAppearance = appearance283;
            ultraGridColumn280.Header.Caption = "";
            ultraGridColumn280.Header.VisiblePosition = 2;
            ultraGridColumn280.LockedWidth = true;
            ultraGridColumn280.MaxWidth = 15;
            ultraGridColumn280.MinWidth = 15;
            ultraGridColumn280.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(22, 0);
            ultraGridColumn280.Width = 15;
            ultraGridColumn281.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn281.Header.Caption = "Motivos de Llamado";
            ultraGridColumn281.Header.VisiblePosition = 7;
            ultraGridColumn281.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(213, 0);
            ultraGridColumn281.Width = 283;
            ultraGridColumn282.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn282.Header.Caption = "Tiempo";
            ultraGridColumn282.Header.VisiblePosition = 3;
            ultraGridColumn282.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn282.MaskInput = "hh:mm:ss";
            ultraGridColumn282.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(62, 0);
            ultraGridColumn282.Width = 56;
            ultraGridColumn283.Format = "dd/MM/yyyy HH:mm";
            ultraGridColumn283.Header.VisiblePosition = 4;
            ultraGridColumn283.MaskInput = "";
            ultraGridColumn283.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(123, 0);
            appearance284.BackColor = System.Drawing.Color.Yellow;
            appearance284.BackColor2 = System.Drawing.Color.Yellow;
            ultraGridColumn283.ValueBasedAppearance = conditionValueAppearance1;
            ultraGridColumn283.Width = 86;
            ultraGridColumn284.Header.VisiblePosition = 11;
            ultraGridColumn284.Hidden = true;
            ultraGridColumn285.DataType = typeof(bool);
            ultraGridColumn285.Formula = "if(isdbnull( [Agendada] ) &  [AlertaProgramadaNoSalio] = 0, 0 , 1 )";
            ultraGridColumn285.Header.VisiblePosition = 12;
            ultraGridColumn285.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn273,
            ultraGridColumn274,
            ultraGridColumn275,
            ultraGridColumn276,
            ultraGridColumn277,
            ultraGridColumn278,
            ultraGridColumn279,
            ultraGridColumn280,
            ultraGridColumn281,
            ultraGridColumn282,
            ultraGridColumn283,
            ultraGridColumn284,
            ultraGridColumn285});
            ultraGridBand1.Header.Enabled = false;
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand1.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.prestacionesResumenUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.prestacionesResumenUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.prestacionesResumenUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.prestacionesResumenUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance65.BackColor = System.Drawing.SystemColors.Window;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance65;
            appearance286.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance286.ForeColor = System.Drawing.SystemColors.WindowText;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance286;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance287.BackColor = System.Drawing.Color.Transparent;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance287;
            appearance288.BackColor = System.Drawing.SystemColors.Control;
            appearance288.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance288.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.CellAppearance = appearance288;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance289.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance289.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance289.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance289.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance289.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance289;
            appearance290.ForeColor = System.Drawing.Color.Red;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance290;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance291.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance291;
            appearance292.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance292;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            appearance293.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance293.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.prestacionesResumenUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance293;
            this.prestacionesResumenUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prestacionesResumenUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.prestacionesResumenUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.prestacionesResumenUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.prestacionesResumenUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prestacionesResumenUltraGrid.ImageList = this.imageList1;
            this.prestacionesResumenUltraGrid.Location = new System.Drawing.Point(0, 10);
            this.prestacionesResumenUltraGrid.Name = "prestacionesResumenUltraGrid";
            this.prestacionesResumenUltraGrid.Size = new System.Drawing.Size(990, 168);
            this.prestacionesResumenUltraGrid.TabIndex = 6;
            this.prestacionesResumenUltraGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.PrestacionesResumenUltraGridInitializeLayout);
            this.prestacionesResumenUltraGrid.AfterRowActivate += new System.EventHandler(this.PrestacionesResumenUltraGridAfterRowActivate);
            this.prestacionesResumenUltraGrid.AfterSortChange += new Infragistics.Win.UltraWinGrid.BandEventHandler(this.PrestacionesResumenUltraGridAfterSortChange);
            this.prestacionesResumenUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prestacionesResumenUltraGrid_KeyDown);
            this.prestacionesResumenUltraGrid.MouseEnter += new System.EventHandler(this.PrestacionesResumenUltraGridMouseEnter);
            this.prestacionesResumenUltraGrid.MouseLeave += new System.EventHandler(this.PrestacionesResumenUltraGridMouseLeave);
            this.prestacionesResumenUltraGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PrestacionesResumenUltraGridMouseUp);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // prestacionesResumenBindingSource
            // 
            this.prestacionesResumenBindingSource.DataMember = "PrestacionesResumen";
            this.prestacionesResumenBindingSource.DataSource = this.dsPrestacionesResumen;
            // 
            // dsPrestacionesResumen
            // 
            this.dsPrestacionesResumen.DataSetName = "DsPrestacionesResumen";
            this.dsPrestacionesResumen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // prestacionesUltraGrid
            // 
            this.prestacionesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prestacionesUltraGrid.CalcManager = this.ultraCalcManager1;
            this.prestacionesUltraGrid.DataSource = this.prestacionesBindingSource1;
            this.prestacionesUltraGrid.DisplayLayout.AddNewBox.Prompt = "Agregar ...";
            this.prestacionesUltraGrid.DisplayLayout.AddNewBox.Style = Infragistics.Win.UltraWinGrid.AddNewBoxStyle.Compact;
            appearance49.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.prestacionesUltraGrid.DisplayLayout.Appearance = appearance49;
            this.prestacionesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 29;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance42.TextHAlignAsString = "Center";
            ultraGridColumn2.CellAppearance = appearance42;
            ultraGridColumn2.Header.Caption = "Prestación";
            ultraGridColumn2.Header.VisiblePosition = 5;
            ultraGridColumn2.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn2.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn2.MaskInput = "{LOC}nn,nnn,nnn";
            ultraGridColumn2.RowLayoutColumnInfo.OriginX = 1;
            ultraGridColumn2.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(64, 0);
            ultraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(64, 0);
            ultraGridColumn2.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn2.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn2.Width = 48;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance43.TextHAlignAsString = "Center";
            ultraGridColumn3.CellAppearance = appearance43;
            ultraGridColumn3.Header.VisiblePosition = 1;
            ultraGridColumn3.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn3.MaskInput = "{date} hh:mm";
            ultraGridColumn3.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(97, 0);
            ultraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(97, 0);
            ultraGridColumn3.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime;
            ultraGridColumn3.Width = 43;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance44.TextHAlignAsString = "Center";
            ultraGridColumn4.CellAppearance = appearance44;
            ultraGridColumn4.Header.Caption = "Tomador";
            ultraGridColumn4.Header.VisiblePosition = 2;
            ultraGridColumn4.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(110, 0);
            ultraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(110, 0);
            ultraGridColumn4.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn4.Width = 34;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn5.Header.Caption = "Motivo Cancelación";
            ultraGridColumn5.Header.VisiblePosition = 3;
            ultraGridColumn5.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn5.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(104, 0);
            ultraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(104, 0);
            ultraGridColumn5.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn5.Width = 75;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn6.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn6.Header.Caption = "Observaciones";
            ultraGridColumn6.Header.VisiblePosition = 4;
            ultraGridColumn6.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn6.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(129, 0);
            ultraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(129, 0);
            ultraGridColumn6.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn6.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn6.VertScrollBar = true;
            ultraGridColumn6.Width = 70;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance45.TextHAlignAsString = "Center";
            ultraGridColumn7.CellAppearance = appearance45;
            ultraGridColumn7.Header.Caption = "Teléfono";
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn7.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(76, 0);
            ultraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(76, 0);
            ultraGridColumn7.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn7.Width = 38;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn8.Header.VisiblePosition = 8;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.Header.VisiblePosition = 7;
            ultraGridColumn9.MaskInput = "{date} hh:mm";
            ultraGridColumn9.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn9.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(85, 0);
            ultraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(85, 0);
            ultraGridColumn9.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn9.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance46.TextHAlignAsString = "Center";
            ultraGridColumn11.Header.Appearance = appearance46;
            ultraGridColumn11.Header.Caption = "Código";
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn11.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(64, 0);
            ultraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(64, 0);
            ultraGridColumn11.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn11.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance47.TextHAlignAsString = "Right";
            ultraGridColumn12.CellAppearance = appearance47;
            ultraGridColumn12.Formula = "if(sum([//pacientesUltraGrid/Pacientes/Importe])=0 ,\"\",\"$ \" & fixed( sum([//pacie" +
    "ntesUltraGrid/Pacientes/Importe]) , 2 , \"FALSE\" ))";
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn12.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn12.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(56, 0);
            ultraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(56, 0);
            ultraGridColumn12.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn12.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance48.TextHAlignAsString = "Center";
            ultraGridColumn13.CellAppearance = appearance48;
            ultraGridColumn13.Header.Caption = "";
            ultraGridColumn13.Header.VisiblePosition = 12;
            ultraGridColumn13.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn13.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(53, 0);
            ultraGridColumn13.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(53, 0);
            ultraGridColumn13.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn13.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridBand2.Columns.AddRange(new object[] {
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
            ultraGridColumn13});
            appearance50.FontData.BoldAsString = "True";
            appearance50.FontData.SizeInPoints = 11F;
            appearance50.ImageHAlign = Infragistics.Win.HAlign.Left;
            appearance50.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance50;
            ultraGridBand2.Header.Caption = "Prestación";
            ultraGridBand2.MaxRows = 1;
            ultraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand2.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.prestacionesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.prestacionesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.prestacionesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.prestacionesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance53.BackColor = System.Drawing.SystemColors.Window;
            this.prestacionesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance53;
            appearance54.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance54.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance54.ForeColor = System.Drawing.SystemColors.WindowText;
            this.prestacionesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance54;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.prestacionesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance55.BackColor = System.Drawing.Color.Transparent;
            this.prestacionesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance55;
            appearance56.BackColor = System.Drawing.SystemColors.Control;
            appearance56.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.prestacionesUltraGrid.DisplayLayout.Override.CellAppearance = appearance56;
            this.prestacionesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance57.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance57.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance57.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance57.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.prestacionesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance57;
            this.prestacionesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance58.ForeColor = System.Drawing.Color.Red;
            this.prestacionesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance58;
            this.prestacionesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.prestacionesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance59;
            appearance60.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance60.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.prestacionesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance60;
            appearance61.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance61.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.prestacionesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance61;
            this.prestacionesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prestacionesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.prestacionesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.prestacionesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.prestacionesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prestacionesUltraGrid.Location = new System.Drawing.Point(2, 3);
            this.prestacionesUltraGrid.Name = "prestacionesUltraGrid";
            this.prestacionesUltraGrid.Size = new System.Drawing.Size(970, 40);
            this.prestacionesUltraGrid.TabIndex = 6;
            this.prestacionesUltraGrid.AfterCellActivate += new System.EventHandler(this.PrestacionesUltraGridAfterCellActivate);
            this.prestacionesUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.PrestacionesUltraGridInitializeRow);
            this.prestacionesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.prestacionesUltraGrid_AfterEnterEditMode);
            this.prestacionesUltraGrid.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.PrestacionesUltraGridClickCellButton);
            this.prestacionesUltraGrid.AfterCellListCloseUp += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.PrestacionesUltraGridAfterCellListCloseUp);
            // 
            // prestacionesBindingSource1
            // 
            this.prestacionesBindingSource1.DataMember = "Prestaciones";
            this.prestacionesBindingSource1.DataSource = this.dsPrestacion;
            // 
            // dsPrestacion
            // 
            this.dsPrestacion.DataSetName = "DsPrestacion";
            this.dsPrestacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMedicamentos
            // 
            this.ultraDropDownMedicamentos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMedicamentos.DataSource = this.medicamentosBindingSource;
            appearance104.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance104.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMedicamentos.DisplayLayout.Appearance = appearance104;
            ultraGridBand26.ColHeadersVisible = false;
            ultraGridColumn472.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn472.Header.VisiblePosition = 0;
            ultraGridColumn472.Hidden = true;
            ultraGridColumn472.Width = 37;
            ultraGridColumn473.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn473.Header.VisiblePosition = 1;
            ultraGridColumn473.Width = 219;
            ultraGridColumn474.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn474.Header.VisiblePosition = 2;
            ultraGridColumn474.Hidden = true;
            ultraGridColumn474.Width = 44;
            ultraGridColumn475.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn475.Header.VisiblePosition = 3;
            ultraGridColumn475.Hidden = true;
            ultraGridColumn475.Width = 62;
            ultraGridColumn476.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn476.Header.VisiblePosition = 4;
            ultraGridColumn476.Hidden = true;
            ultraGridColumn476.Width = 44;
            ultraGridBand26.Columns.AddRange(new object[] {
            ultraGridColumn472,
            ultraGridColumn473,
            ultraGridColumn474,
            ultraGridColumn475,
            ultraGridColumn476});
            this.ultraDropDownMedicamentos.DisplayLayout.BandsSerializer.Add(ultraGridBand26);
            this.ultraDropDownMedicamentos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMedicamentos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMedicamentos.DisplayLayout.MaxBandDepth = 5;
            appearance105.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.ActiveCellAppearance = appearance105;
            appearance106.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance106.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance106.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.ActiveRowAppearance = appearance106;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance107.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.CardAreaAppearance = appearance107;
            appearance108.BackColor = System.Drawing.SystemColors.Control;
            appearance108.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance108.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.CellAppearance = appearance108;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance109.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance109.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance109.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance109.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.HeaderAppearance = appearance109;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance110.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.RowSelectorAppearance = appearance110;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.SelectedCellAppearance = appearance111;
            appearance112.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance112.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.SelectedRowAppearance = appearance112;
            appearance113.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance113.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMedicamentos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance113;
            this.ultraDropDownMedicamentos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMedicamentos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMedicamentos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMedicamentos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMedicamentos.DisplayMember = "Nombre";
            this.ultraDropDownMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMedicamentos.Location = new System.Drawing.Point(244, 419);
            this.ultraDropDownMedicamentos.Name = "ultraDropDownMedicamentos";
            this.ultraDropDownMedicamentos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownMedicamentos.TabIndex = 43;
            this.ultraDropDownMedicamentos.ValueMember = "idMedicamento";
            this.ultraDropDownMedicamentos.Visible = false;
            this.ultraDropDownMedicamentos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMedicamentosBeforeDropDown);
            this.ultraDropDownMedicamentos.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownMedicamentosFilterRow);
            // 
            // medicamentosBindingSource
            // 
            this.medicamentosBindingSource.DataMember = "Medicamentos";
            this.medicamentosBindingSource.DataSource = this.dsMedicamentos;
            // 
            // dsMedicamentos
            // 
            this.dsMedicamentos.DataSetName = "DsMedicamentos";
            this.dsMedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownDiagnosticos
            // 
            this.ultraDropDownDiagnosticos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownDiagnosticos.DataSource = this.diagnosticosBindingSource;
            appearance124.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance124.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance124.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownDiagnosticos.DisplayLayout.Appearance = appearance124;
            ultraGridBand27.ColHeadersVisible = false;
            ultraGridColumn477.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn477.Header.VisiblePosition = 0;
            ultraGridColumn477.Hidden = true;
            ultraGridColumn477.Width = 60;
            ultraGridColumn478.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn478.Header.VisiblePosition = 1;
            ultraGridColumn478.Hidden = true;
            ultraGridColumn478.Width = 98;
            ultraGridColumn479.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn479.Header.VisiblePosition = 2;
            ultraGridColumn479.Width = 219;
            ultraGridBand27.Columns.AddRange(new object[] {
            ultraGridColumn477,
            ultraGridColumn478,
            ultraGridColumn479});
            this.ultraDropDownDiagnosticos.DisplayLayout.BandsSerializer.Add(ultraGridBand27);
            this.ultraDropDownDiagnosticos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownDiagnosticos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownDiagnosticos.DisplayLayout.MaxBandDepth = 5;
            appearance125.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.ActiveCellAppearance = appearance125;
            appearance126.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance126.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance126.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance126.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.ActiveRowAppearance = appearance126;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance127.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.CardAreaAppearance = appearance127;
            appearance128.BackColor = System.Drawing.SystemColors.Control;
            appearance128.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance128.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.CellAppearance = appearance128;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance129.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance129.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance129.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance129.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.HeaderAppearance = appearance129;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance130.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.RowSelectorAppearance = appearance130;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance131.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.SelectedCellAppearance = appearance131;
            appearance132.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance132.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance132.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.SelectedRowAppearance = appearance132;
            appearance133.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance133.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownDiagnosticos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance133;
            this.ultraDropDownDiagnosticos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownDiagnosticos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownDiagnosticos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownDiagnosticos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownDiagnosticos.DisplayMember = "Nombre";
            this.ultraDropDownDiagnosticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownDiagnosticos.Location = new System.Drawing.Point(244, 381);
            this.ultraDropDownDiagnosticos.Name = "ultraDropDownDiagnosticos";
            this.ultraDropDownDiagnosticos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownDiagnosticos.TabIndex = 42;
            this.ultraDropDownDiagnosticos.ValueMember = "idDiagnostico";
            this.ultraDropDownDiagnosticos.Visible = false;
            this.ultraDropDownDiagnosticos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownDiagnosticosBeforeDropDown);
            // 
            // diagnosticosBindingSource
            // 
            this.diagnosticosBindingSource.DataMember = "Diagnosticos";
            this.diagnosticosBindingSource.DataSource = this.dsDiagnosticos;
            // 
            // dsDiagnosticos
            // 
            this.dsDiagnosticos.DataSetName = "DsDiagnosticos";
            this.dsDiagnosticos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMotivos
            // 
            this.ultraDropDownMotivos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMotivos.DataSource = this.motivosDeLlamadoBindingSource;
            appearance134.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance134.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotivos.DisplayLayout.Appearance = appearance134;
            ultraGridBand25.ColHeadersVisible = false;
            ultraGridColumn468.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn468.Header.VisiblePosition = 0;
            ultraGridColumn468.Hidden = true;
            ultraGridColumn468.Width = 49;
            ultraGridColumn469.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn469.Header.VisiblePosition = 1;
            ultraGridColumn469.Width = 219;
            ultraGridColumn470.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn470.Header.VisiblePosition = 2;
            ultraGridColumn470.Hidden = true;
            ultraGridColumn470.Width = 44;
            ultraGridColumn471.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn471.Header.VisiblePosition = 3;
            ultraGridColumn471.Hidden = true;
            ultraGridColumn471.Width = 44;
            ultraGridBand25.Columns.AddRange(new object[] {
            ultraGridColumn468,
            ultraGridColumn469,
            ultraGridColumn470,
            ultraGridColumn471});
            this.ultraDropDownMotivos.DisplayLayout.BandsSerializer.Add(ultraGridBand25);
            this.ultraDropDownMotivos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotivos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotivos.DisplayLayout.MaxBandDepth = 5;
            appearance135.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotivos.DisplayLayout.Override.ActiveCellAppearance = appearance135;
            appearance136.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance136.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance136.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotivos.DisplayLayout.Override.ActiveRowAppearance = appearance136;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotivos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance137.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotivos.DisplayLayout.Override.CardAreaAppearance = appearance137;
            appearance138.BackColor = System.Drawing.SystemColors.Control;
            appearance138.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance138.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivos.DisplayLayout.Override.CellAppearance = appearance138;
            this.ultraDropDownMotivos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance139.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance139.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance139.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance139.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance139.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotivos.DisplayLayout.Override.HeaderAppearance = appearance139;
            this.ultraDropDownMotivos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance140.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotivos.DisplayLayout.Override.RowSelectorAppearance = appearance140;
            this.ultraDropDownMotivos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance141.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotivos.DisplayLayout.Override.SelectedCellAppearance = appearance141;
            appearance142.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance142.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance142.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivos.DisplayLayout.Override.SelectedRowAppearance = appearance142;
            appearance143.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance143.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotivos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance143;
            this.ultraDropDownMotivos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotivos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotivos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotivos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotivos.DisplayMember = "Nombre";
            this.ultraDropDownMotivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotivos.Location = new System.Drawing.Point(244, 343);
            this.ultraDropDownMotivos.Name = "ultraDropDownMotivos";
            this.ultraDropDownMotivos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownMotivos.TabIndex = 41;
            this.ultraDropDownMotivos.ValueMember = "idMotivoDeLlamado";
            this.ultraDropDownMotivos.Visible = false;
            this.ultraDropDownMotivos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotivosBeforeDropDown);
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
            // ultraDropDownPrepagos
            // 
            this.ultraDropDownPrepagos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPrepagos.DataSource = this.prepagosBindingSource;
            appearance3.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrepagos.DisplayLayout.Appearance = appearance3;
            ultraGridBand24.ColHeadersVisible = false;
            ultraGridColumn465.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn465.Header.VisiblePosition = 0;
            ultraGridColumn465.Hidden = true;
            ultraGridColumn465.Width = 57;
            ultraGridColumn466.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn466.Header.VisiblePosition = 1;
            ultraGridColumn466.Width = 219;
            ultraGridColumn467.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn467.Header.VisiblePosition = 2;
            ultraGridColumn467.Hidden = true;
            ultraGridColumn467.Width = 87;
            ultraGridBand24.Columns.AddRange(new object[] {
            ultraGridColumn465,
            ultraGridColumn466,
            ultraGridColumn467});
            this.ultraDropDownPrepagos.DisplayLayout.BandsSerializer.Add(ultraGridBand24);
            this.ultraDropDownPrepagos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrepagos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrepagos.DisplayLayout.MaxBandDepth = 5;
            appearance4.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveCellAppearance = appearance4;
            appearance5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance5.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveRowAppearance = appearance5;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance6.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CardAreaAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.Control;
            appearance7.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CellAppearance = appearance7;
            this.ultraDropDownPrepagos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance8.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderAppearance = appearance8;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance9.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSelectorAppearance = appearance9;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedCellAppearance = appearance10;
            appearance11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance11.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedRowAppearance = appearance11;
            appearance12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrepagos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance12;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrepagos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrepagos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrepagos.DisplayMember = "Nombre";
            this.ultraDropDownPrepagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPrepagos.Location = new System.Drawing.Point(244, 304);
            this.ultraDropDownPrepagos.Name = "ultraDropDownPrepagos";
            this.ultraDropDownPrepagos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownPrepagos.TabIndex = 40;
            this.ultraDropDownPrepagos.ValueMember = "idPrepago";
            this.ultraDropDownPrepagos.Visible = false;
            this.ultraDropDownPrepagos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownPrepagosBeforeDropDown);
            // 
            // prepagosBindingSource
            // 
            this.prepagosBindingSource.DataMember = "Prepagos";
            this.prepagosBindingSource.DataSource = this.dsPrepagos;
            // 
            // dsPrepagos
            // 
            this.dsPrepagos.DataSetName = "DsPrepagos";
            this.dsPrepagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPracticas
            // 
            this.ultraDropDownPracticas.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPracticas.DataSource = this.practicasBindingSource;
            appearance154.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance154.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance154.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPracticas.DisplayLayout.Appearance = appearance154;
            ultraGridBand23.ColHeadersVisible = false;
            ultraGridColumn463.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn463.Header.VisiblePosition = 0;
            ultraGridColumn463.Hidden = true;
            ultraGridColumn463.Width = 40;
            ultraGridColumn464.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn464.Header.VisiblePosition = 1;
            ultraGridColumn464.Width = 219;
            ultraGridBand23.Columns.AddRange(new object[] {
            ultraGridColumn463,
            ultraGridColumn464});
            this.ultraDropDownPracticas.DisplayLayout.BandsSerializer.Add(ultraGridBand23);
            this.ultraDropDownPracticas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPracticas.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPracticas.DisplayLayout.MaxBandDepth = 5;
            appearance155.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPracticas.DisplayLayout.Override.ActiveCellAppearance = appearance155;
            appearance156.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance156.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance156.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance156.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPracticas.DisplayLayout.Override.ActiveRowAppearance = appearance156;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPracticas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance157.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPracticas.DisplayLayout.Override.CardAreaAppearance = appearance157;
            appearance158.BackColor = System.Drawing.SystemColors.Control;
            appearance158.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance158.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPracticas.DisplayLayout.Override.CellAppearance = appearance158;
            this.ultraDropDownPracticas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance159.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance159.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance159.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance159.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance159.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPracticas.DisplayLayout.Override.HeaderAppearance = appearance159;
            this.ultraDropDownPracticas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance160.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPracticas.DisplayLayout.Override.RowSelectorAppearance = appearance160;
            this.ultraDropDownPracticas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance161.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPracticas.DisplayLayout.Override.SelectedCellAppearance = appearance161;
            appearance162.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance162.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance162.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPracticas.DisplayLayout.Override.SelectedRowAppearance = appearance162;
            appearance163.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance163.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPracticas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance163;
            this.ultraDropDownPracticas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPracticas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPracticas.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPracticas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPracticas.DisplayMember = "Nombre";
            this.ultraDropDownPracticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPracticas.Location = new System.Drawing.Point(244, 264);
            this.ultraDropDownPracticas.Name = "ultraDropDownPracticas";
            this.ultraDropDownPracticas.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownPracticas.TabIndex = 39;
            this.ultraDropDownPracticas.ValueMember = "idPractica";
            this.ultraDropDownPracticas.Visible = false;
            this.ultraDropDownPracticas.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownPracticasBeforeDropDown);
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
            // ultraDropDownCoberturas
            // 
            this.ultraDropDownCoberturas.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCoberturas.DataSource = this.coberturasBindingSource;
            appearance68.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance68.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCoberturas.DisplayLayout.Appearance = appearance68;
            ultraGridBand21.ColHeadersVisible = false;
            ultraGridColumn444.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn444.Header.VisiblePosition = 0;
            ultraGridColumn444.Hidden = true;
            ultraGridColumn444.Width = 43;
            ultraGridColumn445.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn445.Header.VisiblePosition = 1;
            ultraGridColumn445.Width = 219;
            ultraGridBand21.Columns.AddRange(new object[] {
            ultraGridColumn444,
            ultraGridColumn445});
            this.ultraDropDownCoberturas.DisplayLayout.BandsSerializer.Add(ultraGridBand21);
            this.ultraDropDownCoberturas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCoberturas.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCoberturas.DisplayLayout.MaxBandDepth = 5;
            appearance69.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCoberturas.DisplayLayout.Override.ActiveCellAppearance = appearance69;
            appearance70.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance70.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance70.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCoberturas.DisplayLayout.Override.ActiveRowAppearance = appearance70;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCoberturas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance71.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCoberturas.DisplayLayout.Override.CardAreaAppearance = appearance71;
            appearance72.BackColor = System.Drawing.SystemColors.Control;
            appearance72.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance72.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCoberturas.DisplayLayout.Override.CellAppearance = appearance72;
            this.ultraDropDownCoberturas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance73.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance73.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance73.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance73.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCoberturas.DisplayLayout.Override.HeaderAppearance = appearance73;
            this.ultraDropDownCoberturas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance74.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCoberturas.DisplayLayout.Override.RowSelectorAppearance = appearance74;
            this.ultraDropDownCoberturas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCoberturas.DisplayLayout.Override.SelectedCellAppearance = appearance75;
            appearance78.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance78.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCoberturas.DisplayLayout.Override.SelectedRowAppearance = appearance78;
            appearance81.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance81.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCoberturas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance81;
            this.ultraDropDownCoberturas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCoberturas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCoberturas.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCoberturas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCoberturas.DisplayMember = "Nombre";
            this.ultraDropDownCoberturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCoberturas.Location = new System.Drawing.Point(244, 226);
            this.ultraDropDownCoberturas.Name = "ultraDropDownCoberturas";
            this.ultraDropDownCoberturas.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownCoberturas.TabIndex = 38;
            this.ultraDropDownCoberturas.ValueMember = "idCobertura";
            this.ultraDropDownCoberturas.Visible = false;
            this.ultraDropDownCoberturas.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCoberturasBeforeDropDown);
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
            // ultraDropDownRecursosActivos
            // 
            this.ultraDropDownRecursosActivos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownRecursosActivos.DataSource = this.recursosListaBindingSource;
            appearance272.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance272.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance272.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownRecursosActivos.DisplayLayout.Appearance = appearance272;
            ultraGridColumn446.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn446.Header.VisiblePosition = 0;
            ultraGridColumn446.Hidden = true;
            ultraGridColumn447.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn447.Header.VisiblePosition = 1;
            ultraGridColumn447.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn447.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn447.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn447.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn448.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn448.Header.VisiblePosition = 2;
            ultraGridColumn448.Hidden = true;
            ultraGridColumn449.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn449.Header.VisiblePosition = 3;
            ultraGridColumn449.Hidden = true;
            ultraGridColumn450.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn450.Header.VisiblePosition = 4;
            ultraGridColumn450.Hidden = true;
            ultraGridColumn451.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn451.Header.VisiblePosition = 5;
            ultraGridColumn451.Hidden = true;
            ultraGridColumn452.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn452.Header.VisiblePosition = 6;
            ultraGridColumn452.Hidden = true;
            ultraGridColumn453.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn453.Header.VisiblePosition = 7;
            ultraGridColumn453.Hidden = true;
            ultraGridColumn454.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn454.Header.VisiblePosition = 8;
            ultraGridColumn454.Hidden = true;
            ultraGridColumn455.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn455.Header.VisiblePosition = 9;
            ultraGridColumn455.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn455.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn455.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn455.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn456.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn456.Header.VisiblePosition = 10;
            ultraGridColumn456.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn456.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn456.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn456.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn457.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn457.Header.VisiblePosition = 11;
            ultraGridColumn457.Hidden = true;
            ultraGridColumn457.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn457.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn457.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn457.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn458.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn458.Header.Caption = "Dirección";
            ultraGridColumn458.Header.VisiblePosition = 12;
            ultraGridColumn458.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn458.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn458.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn458.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn459.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn459.Header.Caption = "Tripulación";
            ultraGridColumn459.Header.VisiblePosition = 13;
            ultraGridColumn459.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn459.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn459.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(150, 0);
            ultraGridColumn459.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn459.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn460.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn460.Header.VisiblePosition = 14;
            ultraGridColumn460.Hidden = true;
            appearance340.TextHAlignAsString = "Right";
            ultraGridColumn461.CellAppearance = appearance340;
            ultraGridColumn461.Header.VisiblePosition = 15;
            ultraGridColumn461.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn461.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn461.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn461.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn462.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance341.ImageHAlign = Infragistics.Win.HAlign.Center;
            appearance341.ImageVAlign = Infragistics.Win.VAlign.Middle;
            ultraGridColumn462.CellAppearance = appearance341;
            ultraGridColumn462.Header.Caption = "";
            ultraGridColumn462.Header.VisiblePosition = 16;
            ultraGridColumn462.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn462.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn462.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn462.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn462.Width = 23;
            ultraGridBand22.Columns.AddRange(new object[] {
            ultraGridColumn446,
            ultraGridColumn447,
            ultraGridColumn448,
            ultraGridColumn449,
            ultraGridColumn450,
            ultraGridColumn451,
            ultraGridColumn452,
            ultraGridColumn453,
            ultraGridColumn454,
            ultraGridColumn455,
            ultraGridColumn456,
            ultraGridColumn457,
            ultraGridColumn458,
            ultraGridColumn459,
            ultraGridColumn460,
            ultraGridColumn461,
            ultraGridColumn462});
            ultraGridBand22.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownRecursosActivos.DisplayLayout.BandsSerializer.Add(ultraGridBand22);
            this.ultraDropDownRecursosActivos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownRecursosActivos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownRecursosActivos.DisplayLayout.MaxBandDepth = 5;
            appearance274.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.ActiveCellAppearance = appearance274;
            appearance275.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance275.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance275.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance275.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.ActiveRowAppearance = appearance275;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance276.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.CardAreaAppearance = appearance276;
            appearance277.BackColor = System.Drawing.SystemColors.Control;
            appearance277.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance277.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.CellAppearance = appearance277;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance278.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance278.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance278.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance278.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance278.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.HeaderAppearance = appearance278;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance279.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.RowSelectorAppearance = appearance279;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance280.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.SelectedCellAppearance = appearance280;
            appearance281.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance281.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance281.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.SelectedRowAppearance = appearance281;
            appearance282.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance282.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownRecursosActivos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance282;
            this.ultraDropDownRecursosActivos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownRecursosActivos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownRecursosActivos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownRecursosActivos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownRecursosActivos.DisplayMember = "Nombre";
            this.ultraDropDownRecursosActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownRecursosActivos.ImageList = this.imageList1;
            this.ultraDropDownRecursosActivos.Location = new System.Drawing.Point(244, 187);
            this.ultraDropDownRecursosActivos.Name = "ultraDropDownRecursosActivos";
            this.ultraDropDownRecursosActivos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownRecursosActivos.TabIndex = 37;
            this.ultraDropDownRecursosActivos.ValueMember = "idRecurso";
            this.ultraDropDownRecursosActivos.Visible = false;
            this.ultraDropDownRecursosActivos.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.UltraDropDownRecursosActivosInitializeRow);
            this.ultraDropDownRecursosActivos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownRecursosActivosBeforeDropDown);
            this.ultraDropDownRecursosActivos.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownRecursosActivosRowSelected);
            // 
            // recursosListaBindingSource
            // 
            this.recursosListaBindingSource.DataMember = "RecursosLista";
            this.recursosListaBindingSource.DataSource = this.dsRecursosLista;
            // 
            // dsRecursosLista
            // 
            this.dsRecursosLista.DataSetName = "DsRecursosLista";
            this.dsRecursosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownBarrio
            // 
            this.ultraDropDownBarrio.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownBarrio.DataSource = this.barriosListaBindingSource;
            appearance174.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance174.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance174.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrio.DisplayLayout.Appearance = appearance174;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn340.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn340.Header.VisiblePosition = 0;
            ultraGridColumn340.Hidden = true;
            ultraGridColumn340.Width = 45;
            ultraGridColumn341.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn341.Header.VisiblePosition = 1;
            ultraGridColumn341.Width = 219;
            ultraGridColumn342.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn342.Header.VisiblePosition = 2;
            ultraGridColumn342.Hidden = true;
            ultraGridColumn342.Width = 58;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn340,
            ultraGridColumn341,
            ultraGridColumn342});
            this.ultraDropDownBarrio.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownBarrio.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBarrio.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBarrio.DisplayLayout.MaxBandDepth = 5;
            appearance175.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBarrio.DisplayLayout.Override.ActiveCellAppearance = appearance175;
            appearance176.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance176.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance176.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance176.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBarrio.DisplayLayout.Override.ActiveRowAppearance = appearance176;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBarrio.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance177.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBarrio.DisplayLayout.Override.CardAreaAppearance = appearance177;
            appearance178.BackColor = System.Drawing.SystemColors.Control;
            appearance178.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance178.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrio.DisplayLayout.Override.CellAppearance = appearance178;
            this.ultraDropDownBarrio.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance179.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance179.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance179.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance179.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBarrio.DisplayLayout.Override.HeaderAppearance = appearance179;
            this.ultraDropDownBarrio.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance180.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBarrio.DisplayLayout.Override.RowSelectorAppearance = appearance180;
            this.ultraDropDownBarrio.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance181.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBarrio.DisplayLayout.Override.SelectedCellAppearance = appearance181;
            appearance182.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance182.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance182.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrio.DisplayLayout.Override.SelectedRowAppearance = appearance182;
            appearance183.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance183.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBarrio.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance183;
            this.ultraDropDownBarrio.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBarrio.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBarrio.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBarrio.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBarrio.DisplayMember = "Nombre";
            this.ultraDropDownBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownBarrio.Location = new System.Drawing.Point(249, 210);
            this.ultraDropDownBarrio.Name = "ultraDropDownBarrio";
            this.ultraDropDownBarrio.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownBarrio.TabIndex = 36;
            this.ultraDropDownBarrio.ValueMember = "idBarrio";
            this.ultraDropDownBarrio.Visible = false;
            this.ultraDropDownBarrio.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownBarrioBeforeDropDown);
            this.ultraDropDownBarrio.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownBarrioFilterRow);
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
            this.ultraDropDownCalles.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCalles.DataSource = this.callesBindingSource;
            appearance184.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance184.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance184.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalles.DisplayLayout.Appearance = appearance184;
            ultraGridBand31.ColHeadersVisible = false;
            ultraGridColumn490.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn490.Header.VisiblePosition = 0;
            ultraGridColumn490.Hidden = true;
            ultraGridColumn490.Width = 30;
            ultraGridColumn491.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn491.Header.VisiblePosition = 1;
            ultraGridColumn491.Hidden = true;
            ultraGridColumn491.Width = 57;
            ultraGridColumn492.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn492.Header.VisiblePosition = 2;
            ultraGridColumn492.Hidden = true;
            ultraGridColumn492.Width = 40;
            ultraGridColumn493.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn493.Header.VisiblePosition = 3;
            ultraGridColumn493.Width = 219;
            ultraGridBand31.Columns.AddRange(new object[] {
            ultraGridColumn490,
            ultraGridColumn491,
            ultraGridColumn492,
            ultraGridColumn493});
            this.ultraDropDownCalles.DisplayLayout.BandsSerializer.Add(ultraGridBand31);
            this.ultraDropDownCalles.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCalles.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCalles.DisplayLayout.MaxBandDepth = 5;
            appearance185.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCalles.DisplayLayout.Override.ActiveCellAppearance = appearance185;
            appearance186.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance186.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance186.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance186.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCalles.DisplayLayout.Override.ActiveRowAppearance = appearance186;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCalles.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance187.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCalles.DisplayLayout.Override.CardAreaAppearance = appearance187;
            appearance188.BackColor = System.Drawing.SystemColors.Control;
            appearance188.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance188.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalles.DisplayLayout.Override.CellAppearance = appearance188;
            this.ultraDropDownCalles.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance189.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance189.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance189.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance189.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance189.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCalles.DisplayLayout.Override.HeaderAppearance = appearance189;
            this.ultraDropDownCalles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance190.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCalles.DisplayLayout.Override.RowSelectorAppearance = appearance190;
            this.ultraDropDownCalles.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance191.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCalles.DisplayLayout.Override.SelectedCellAppearance = appearance191;
            appearance192.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance192.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance192.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalles.DisplayLayout.Override.SelectedRowAppearance = appearance192;
            appearance193.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance193.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCalles.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance193;
            this.ultraDropDownCalles.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCalles.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCalles.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCalles.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCalles.DisplayMember = "Nombre";
            this.ultraDropDownCalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCalles.Location = new System.Drawing.Point(0, 381);
            this.ultraDropDownCalles.Name = "ultraDropDownCalles";
            this.ultraDropDownCalles.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownCalles.TabIndex = 35;
            this.ultraDropDownCalles.ValueMember = "idCalle";
            this.ultraDropDownCalles.Visible = false;
            this.ultraDropDownCalles.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownCallesBeforeDropDown);
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
            this.ultraDropDownLocalidad.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownLocalidad.DataSource = this.localidadesBindingSource;
            appearance194.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance194.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance194.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidad.DisplayLayout.Appearance = appearance194;
            ultraGridBand30.ColHeadersVisible = false;
            ultraGridColumn488.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn488.Header.VisiblePosition = 0;
            ultraGridColumn488.Hidden = true;
            ultraGridColumn488.Width = 75;
            ultraGridColumn489.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn489.Header.VisiblePosition = 1;
            ultraGridColumn489.Width = 219;
            ultraGridBand30.Columns.AddRange(new object[] {
            ultraGridColumn488,
            ultraGridColumn489});
            this.ultraDropDownLocalidad.DisplayLayout.BandsSerializer.Add(ultraGridBand30);
            this.ultraDropDownLocalidad.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidad.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidad.DisplayLayout.MaxBandDepth = 5;
            appearance195.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveCellAppearance = appearance195;
            appearance196.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance196.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance196.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance196.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveRowAppearance = appearance196;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance197.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CardAreaAppearance = appearance197;
            appearance198.BackColor = System.Drawing.SystemColors.Control;
            appearance198.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance198.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CellAppearance = appearance198;
            this.ultraDropDownLocalidad.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance199.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance199.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance199.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance199.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance199.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderAppearance = appearance199;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance200.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSelectorAppearance = appearance200;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance201.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedCellAppearance = appearance201;
            appearance202.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance202.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance202.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedRowAppearance = appearance202;
            appearance203.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance203.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidad.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance203;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidad.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidad.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidad.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownLocalidad.Location = new System.Drawing.Point(0, 342);
            this.ultraDropDownLocalidad.Name = "ultraDropDownLocalidad";
            this.ultraDropDownLocalidad.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownLocalidad.TabIndex = 34;
            this.ultraDropDownLocalidad.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidad.Visible = false;
            this.ultraDropDownLocalidad.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownLocalidadBeforeDropDown);
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
            // ultraDropDownLugares
            // 
            this.ultraDropDownLugares.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownLugares.DataSource = this.lugaresBindingSource;
            appearance204.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance204.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance204.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLugares.DisplayLayout.Appearance = appearance204;
            ultraGridBand32.ColHeadersVisible = false;
            ultraGridColumn494.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn494.Header.VisiblePosition = 0;
            ultraGridColumn494.Hidden = true;
            ultraGridColumn494.Width = 41;
            ultraGridColumn495.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn495.Header.VisiblePosition = 1;
            ultraGridColumn495.Width = 219;
            ultraGridColumn496.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn496.Header.VisiblePosition = 2;
            ultraGridColumn496.Hidden = true;
            ultraGridColumn496.Width = 70;
            ultraGridColumn497.Header.VisiblePosition = 3;
            ultraGridColumn498.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn498.Header.VisiblePosition = 4;
            ultraGridColumn499.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn499.Header.VisiblePosition = 5;
            ultraGridBand32.Columns.AddRange(new object[] {
            ultraGridColumn494,
            ultraGridColumn495,
            ultraGridColumn496,
            ultraGridColumn497,
            ultraGridColumn498,
            ultraGridColumn499});
            ultraGridColumn500.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn500.Header.VisiblePosition = 0;
            ultraGridColumn500.Width = 44;
            ultraGridColumn501.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn501.Header.VisiblePosition = 1;
            ultraGridColumn501.Width = 33;
            ultraGridColumn502.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn502.Header.VisiblePosition = 2;
            ultraGridColumn502.Width = 70;
            ultraGridColumn503.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn503.Header.VisiblePosition = 3;
            ultraGridColumn503.Width = 70;
            ultraGridColumn504.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn504.Header.VisiblePosition = 4;
            ultraGridColumn504.Width = 70;
            ultraGridColumn505.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn505.Header.VisiblePosition = 5;
            ultraGridColumn505.Width = 59;
            ultraGridColumn506.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn506.Header.VisiblePosition = 6;
            ultraGridColumn506.Width = 59;
            ultraGridColumn507.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn507.Header.VisiblePosition = 7;
            ultraGridColumn507.Width = 41;
            ultraGridColumn508.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn508.Header.VisiblePosition = 8;
            ultraGridColumn508.Width = 70;
            ultraGridColumn509.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn509.Header.VisiblePosition = 10;
            ultraGridColumn509.Width = 41;
            ultraGridColumn510.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn510.Header.VisiblePosition = 11;
            ultraGridColumn510.Width = 41;
            ultraGridColumn511.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn511.Header.VisiblePosition = 9;
            ultraGridColumn511.Width = 51;
            ultraGridColumn512.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn512.Header.VisiblePosition = 12;
            ultraGridBand33.Columns.AddRange(new object[] {
            ultraGridColumn500,
            ultraGridColumn501,
            ultraGridColumn502,
            ultraGridColumn503,
            ultraGridColumn504,
            ultraGridColumn505,
            ultraGridColumn506,
            ultraGridColumn507,
            ultraGridColumn508,
            ultraGridColumn509,
            ultraGridColumn510,
            ultraGridColumn511,
            ultraGridColumn512});
            ultraGridColumn513.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn513.Header.VisiblePosition = 0;
            ultraGridColumn513.Width = 120;
            ultraGridColumn514.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn514.Header.VisiblePosition = 1;
            ultraGridColumn514.Width = 166;
            ultraGridColumn515.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn515.Header.VisiblePosition = 2;
            ultraGridColumn515.Width = 118;
            ultraGridColumn516.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn516.Header.VisiblePosition = 3;
            ultraGridColumn516.Width = 121;
            ultraGridColumn517.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn517.Header.VisiblePosition = 4;
            ultraGridColumn517.Width = 105;
            ultraGridBand34.Columns.AddRange(new object[] {
            ultraGridColumn513,
            ultraGridColumn514,
            ultraGridColumn515,
            ultraGridColumn516,
            ultraGridColumn517});
            ultraGridColumn518.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn518.Header.VisiblePosition = 0;
            ultraGridColumn518.Width = 104;
            ultraGridColumn519.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn519.Header.VisiblePosition = 1;
            ultraGridColumn519.Width = 141;
            ultraGridColumn520.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn520.Header.VisiblePosition = 2;
            ultraGridColumn520.Width = 145;
            ultraGridColumn521.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn521.Header.VisiblePosition = 3;
            ultraGridColumn521.Width = 87;
            ultraGridColumn522.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn522.Header.VisiblePosition = 4;
            ultraGridColumn522.Width = 86;
            ultraGridColumn523.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn523.Header.VisiblePosition = 5;
            ultraGridColumn523.Width = 86;
            ultraGridColumn524.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn524.Header.VisiblePosition = 6;
            ultraGridBand35.Columns.AddRange(new object[] {
            ultraGridColumn518,
            ultraGridColumn519,
            ultraGridColumn520,
            ultraGridColumn521,
            ultraGridColumn522,
            ultraGridColumn523,
            ultraGridColumn524});
            ultraGridColumn525.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn525.Header.VisiblePosition = 0;
            ultraGridColumn525.Width = 120;
            ultraGridColumn526.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn526.Header.VisiblePosition = 1;
            ultraGridColumn526.Width = 166;
            ultraGridColumn527.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn527.Header.VisiblePosition = 2;
            ultraGridColumn527.Width = 118;
            ultraGridColumn528.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn528.Header.VisiblePosition = 3;
            ultraGridColumn528.Width = 121;
            ultraGridColumn529.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn529.Header.VisiblePosition = 4;
            ultraGridColumn529.Width = 105;
            ultraGridBand36.Columns.AddRange(new object[] {
            ultraGridColumn525,
            ultraGridColumn526,
            ultraGridColumn527,
            ultraGridColumn528,
            ultraGridColumn529});
            this.ultraDropDownLugares.DisplayLayout.BandsSerializer.Add(ultraGridBand32);
            this.ultraDropDownLugares.DisplayLayout.BandsSerializer.Add(ultraGridBand33);
            this.ultraDropDownLugares.DisplayLayout.BandsSerializer.Add(ultraGridBand34);
            this.ultraDropDownLugares.DisplayLayout.BandsSerializer.Add(ultraGridBand35);
            this.ultraDropDownLugares.DisplayLayout.BandsSerializer.Add(ultraGridBand36);
            this.ultraDropDownLugares.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLugares.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLugares.DisplayLayout.MaxBandDepth = 5;
            appearance205.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLugares.DisplayLayout.Override.ActiveCellAppearance = appearance205;
            appearance206.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance206.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance206.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance206.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLugares.DisplayLayout.Override.ActiveRowAppearance = appearance206;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLugares.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance207.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLugares.DisplayLayout.Override.CardAreaAppearance = appearance207;
            appearance208.BackColor = System.Drawing.SystemColors.Control;
            appearance208.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance208.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLugares.DisplayLayout.Override.CellAppearance = appearance208;
            this.ultraDropDownLugares.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance209.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance209.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance209.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance209.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance209.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLugares.DisplayLayout.Override.HeaderAppearance = appearance209;
            this.ultraDropDownLugares.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance210.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLugares.DisplayLayout.Override.RowSelectorAppearance = appearance210;
            this.ultraDropDownLugares.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance211.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLugares.DisplayLayout.Override.SelectedCellAppearance = appearance211;
            appearance212.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance212.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance212.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLugares.DisplayLayout.Override.SelectedRowAppearance = appearance212;
            appearance213.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance213.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLugares.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance213;
            this.ultraDropDownLugares.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLugares.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLugares.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLugares.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLugares.DisplayMember = "Nombre";
            this.ultraDropDownLugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownLugares.Location = new System.Drawing.Point(0, 303);
            this.ultraDropDownLugares.Name = "ultraDropDownLugares";
            this.ultraDropDownLugares.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownLugares.TabIndex = 33;
            this.ultraDropDownLugares.ValueMember = "idLugar";
            this.ultraDropDownLugares.Visible = false;
            this.ultraDropDownLugares.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownLugaresBeforeDropDown);
            // 
            // lugaresBindingSource
            // 
            this.lugaresBindingSource.DataMember = "Lugares";
            this.lugaresBindingSource.DataSource = this.dsLugares;
            // 
            // dsLugares
            // 
            this.dsLugares.DataSetName = "DsLugares";
            this.dsLugares.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMotivosCancelacion
            // 
            this.ultraDropDownMotivosCancelacion.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMotivosCancelacion.DataSource = this.motivosDeCancelacionPrestacionBindingSource;
            appearance214.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance214.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance214.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Appearance = appearance214;
            ultraGridBand29.ColHeadersVisible = false;
            ultraGridColumn486.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn486.Header.VisiblePosition = 0;
            ultraGridColumn486.Hidden = true;
            ultraGridColumn486.Width = 66;
            ultraGridColumn487.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn487.Header.VisiblePosition = 1;
            ultraGridColumn487.Width = 219;
            ultraGridBand29.Columns.AddRange(new object[] {
            ultraGridColumn486,
            ultraGridColumn487});
            this.ultraDropDownMotivosCancelacion.DisplayLayout.BandsSerializer.Add(ultraGridBand29);
            this.ultraDropDownMotivosCancelacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.MaxBandDepth = 5;
            appearance215.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.ActiveCellAppearance = appearance215;
            appearance216.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance216.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance216.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance216.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.ActiveRowAppearance = appearance216;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance217.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.CardAreaAppearance = appearance217;
            appearance218.BackColor = System.Drawing.SystemColors.Control;
            appearance218.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance218.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.CellAppearance = appearance218;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance219.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance219.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance219.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance219.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance219.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.HeaderAppearance = appearance219;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance220.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.RowSelectorAppearance = appearance220;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance221.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.SelectedCellAppearance = appearance221;
            appearance222.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance222.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance222.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.SelectedRowAppearance = appearance222;
            appearance223.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance223.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance223;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotivosCancelacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotivosCancelacion.DisplayMember = "Nombre";
            this.ultraDropDownMotivosCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMotivosCancelacion.Location = new System.Drawing.Point(0, 264);
            this.ultraDropDownMotivosCancelacion.Name = "ultraDropDownMotivosCancelacion";
            this.ultraDropDownMotivosCancelacion.Size = new System.Drawing.Size(238, 33);
            this.ultraDropDownMotivosCancelacion.TabIndex = 32;
            this.ultraDropDownMotivosCancelacion.ValueMember = "idMotivoDeCancelacionPrestacion";
            this.ultraDropDownMotivosCancelacion.Visible = false;
            this.ultraDropDownMotivosCancelacion.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMotivosCancelacionBeforeDropDown);
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
            // ultraDropDownTiposDeDestino
            // 
            this.ultraDropDownTiposDeDestino.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeDestino.DataSource = this.tiposDeDestinoBindingSource;
            appearance114.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance114.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance114.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Appearance = appearance114;
            ultraGridBand20.ColHeadersVisible = false;
            ultraGridColumn441.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn441.Header.VisiblePosition = 0;
            ultraGridColumn441.Hidden = true;
            ultraGridColumn441.Width = 22;
            ultraGridColumn442.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn442.Header.VisiblePosition = 1;
            ultraGridColumn442.Width = 219;
            ultraGridColumn443.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn443.Header.VisiblePosition = 2;
            ultraGridColumn443.Hidden = true;
            ultraGridColumn443.Width = 55;
            ultraGridBand20.Columns.AddRange(new object[] {
            ultraGridColumn441,
            ultraGridColumn442,
            ultraGridColumn443});
            this.ultraDropDownTiposDeDestino.DisplayLayout.BandsSerializer.Add(ultraGridBand20);
            this.ultraDropDownTiposDeDestino.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTiposDeDestino.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTiposDeDestino.DisplayLayout.MaxBandDepth = 5;
            appearance115.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.ActiveCellAppearance = appearance115;
            appearance116.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance116.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance116.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance116.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.ActiveRowAppearance = appearance116;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance117.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.CardAreaAppearance = appearance117;
            appearance118.BackColor = System.Drawing.SystemColors.Control;
            appearance118.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance118.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.CellAppearance = appearance118;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance119.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance119.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance119.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance119.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance119.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.HeaderAppearance = appearance119;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance120.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.RowSelectorAppearance = appearance120;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance121.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.SelectedCellAppearance = appearance121;
            appearance122.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance122.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance122.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.SelectedRowAppearance = appearance122;
            appearance123.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance123.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTiposDeDestino.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance123;
            this.ultraDropDownTiposDeDestino.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTiposDeDestino.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTiposDeDestino.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTiposDeDestino.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTiposDeDestino.DisplayMember = "Nombre";
            this.ultraDropDownTiposDeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTiposDeDestino.Location = new System.Drawing.Point(488, 187);
            this.ultraDropDownTiposDeDestino.Name = "ultraDropDownTiposDeDestino";
            this.ultraDropDownTiposDeDestino.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownTiposDeDestino.TabIndex = 44;
            this.ultraDropDownTiposDeDestino.ValueMember = "idTipoDeDestino";
            this.ultraDropDownTiposDeDestino.Visible = false;
            this.ultraDropDownTiposDeDestino.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTiposDeDestinoBeforeDropDown);
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
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.prestacionesResumenUltraGrid);
            this.splitContainer1.Panel1.Controls.Add(this.panelEstadoGeneral);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.ultraDropDownContratos);
            this.splitContainer1.Size = new System.Drawing.Size(992, 625);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 47;
            // 
            // panelEstadoGeneral
            // 
            this.panelEstadoGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.panelEstadoGeneral.Location = new System.Drawing.Point(2, -2);
            this.panelEstadoGeneral.Name = "panelEstadoGeneral";
            this.panelEstadoGeneral.Size = new System.Drawing.Size(992, 10);
            this.panelEstadoGeneral.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.prestacionesUltraGrid);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 46);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.destinosUltraGrid);
            this.panel3.Controls.Add(this.ultraDropDownBarrio);
            this.panel3.Controls.Add(this.ultraDropDownDespachador);
            this.panel3.Controls.Add(this.ultraDropDownPacientes);
            this.panel3.Controls.Add(this.ultraDropDownMedicos);
            this.panel3.Controls.Add(this.ultraDropDownTiposDeDocumento);
            this.panel3.Controls.Add(this.ultraDropDownCodigos);
            this.panel3.Location = new System.Drawing.Point(3, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 381);
            this.panel3.TabIndex = 8;
            // 
            // destinosUltraGrid
            // 
            this.destinosUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinosUltraGrid.CalcManager = this.ultraCalcManager1;
            this.destinosUltraGrid.DataSource = this.destinosBindingSource;
            appearance303.BackColor = System.Drawing.SystemColors.Control;
            appearance303.ForeColor = System.Drawing.SystemColors.ControlText;
            this.destinosUltraGrid.DisplayLayout.AddNewBox.Appearance = appearance303;
            this.destinosUltraGrid.DisplayLayout.AddNewBox.ButtonConnectorStyle = Infragistics.Win.UIElementBorderStyle.None;
            this.destinosUltraGrid.DisplayLayout.AddNewBox.Hidden = false;
            this.destinosUltraGrid.DisplayLayout.AddNewBox.Prompt = "Agregar ...";
            this.destinosUltraGrid.DisplayLayout.AddNewBox.Style = Infragistics.Win.UltraWinGrid.AddNewBoxStyle.Compact;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.destinosUltraGrid.DisplayLayout.Appearance = appearance1;
            this.destinosUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand3.AddButtonCaption = " Destino";
            ultraGridColumn299.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn299.Header.VisiblePosition = 0;
            ultraGridColumn299.Hidden = true;
            ultraGridColumn299.Width = 56;
            ultraGridColumn300.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn300.Header.VisiblePosition = 1;
            ultraGridColumn300.Hidden = true;
            ultraGridColumn300.Width = 66;
            ultraGridColumn301.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn301.Header.Caption = "Hora Solicitada";
            ultraGridColumn301.Header.VisiblePosition = 4;
            ultraGridColumn301.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars;
            ultraGridColumn301.MaskInput = "dd/mm/yyyy hh:mm";
            ultraGridColumn301.Width = 91;
            ultraGridColumn302.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn302.Header.Caption = "Lugar";
            ultraGridColumn302.Header.VisiblePosition = 3;
            ultraGridColumn302.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn302.Width = 214;
            ultraGridColumn303.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn303.Header.Caption = "Tipo de Destino";
            ultraGridColumn303.Header.VisiblePosition = 2;
            ultraGridColumn303.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn303.Width = 75;
            ultraGridColumn304.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance315.FontData.BoldAsString = "True";
            appearance315.ForeColor = System.Drawing.Color.Red;
            appearance315.TextHAlignAsString = "Right";
            ultraGridColumn304.CellAppearance = appearance315;
            ultraGridColumn304.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn304.Header.VisiblePosition = 5;
            ultraGridColumn304.Width = 52;
            ultraGridColumn305.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn305.Header.VisiblePosition = 6;
            ultraGridColumn306.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn306.Header.VisiblePosition = 7;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn299,
            ultraGridColumn300,
            ultraGridColumn301,
            ultraGridColumn302,
            ultraGridColumn303,
            ultraGridColumn304,
            ultraGridColumn305,
            ultraGridColumn306});
            appearance316.FontData.BoldAsString = "True";
            appearance316.FontData.SizeInPoints = 11F;
            appearance316.TextHAlignAsString = "Left";
            ultraGridBand3.Header.Appearance = appearance316;
            ultraGridBand3.Header.Caption = "Destino";
            ultraGridBand3.HeaderVisible = true;
            ultraGridBand3.MinRows = 1;
            ultraGridBand3.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes;
            ultraGridBand4.AddButtonCaption = "Dirección";
            ultraGridColumn307.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn307.Header.VisiblePosition = 0;
            ultraGridColumn307.Hidden = true;
            ultraGridColumn307.Width = 32;
            ultraGridColumn308.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn308.Header.Caption = "Calle";
            ultraGridColumn308.Header.VisiblePosition = 1;
            ultraGridColumn308.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn308.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn308.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(260, 0);
            ultraGridColumn308.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(260, 0);
            ultraGridColumn308.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn308.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn308.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn308.Width = 29;
            ultraGridColumn309.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn309.Header.Caption = "Nº";
            ultraGridColumn309.Header.VisiblePosition = 2;
            ultraGridColumn309.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn309.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn309.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(53, 0);
            ultraGridColumn309.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(61, 0);
            ultraGridColumn309.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn309.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn309.Width = 45;
            ultraGridColumn310.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn310.Header.VisiblePosition = 3;
            ultraGridColumn310.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn310.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn310.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn310.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn310.Width = 60;
            ultraGridColumn311.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn311.Header.Caption = "Depto.";
            ultraGridColumn311.Header.VisiblePosition = 4;
            ultraGridColumn311.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn311.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn311.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(58, 0);
            ultraGridColumn311.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(58, 0);
            ultraGridColumn311.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn311.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn311.Width = 55;
            ultraGridColumn312.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn312.Header.Caption = "Entre";
            ultraGridColumn312.Header.VisiblePosition = 5;
            ultraGridColumn312.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn312.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn312.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(175, 0);
            ultraGridColumn312.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(169, 0);
            ultraGridColumn312.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn312.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn312.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn312.Width = 46;
            ultraGridColumn313.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn313.Header.Caption = "y";
            ultraGridColumn313.Header.VisiblePosition = 6;
            ultraGridColumn313.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn313.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn313.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(126, 0);
            ultraGridColumn313.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(81, 0);
            ultraGridColumn313.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn313.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn313.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn313.Width = 38;
            ultraGridColumn314.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn314.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn314.Header.VisiblePosition = 7;
            ultraGridColumn314.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn314.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn314.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(183, 92);
            ultraGridColumn314.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(183, 20);
            ultraGridColumn314.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn314.RowLayoutColumnInfo.SpanY = 6;
            ultraGridColumn314.Width = 48;
            ultraGridColumn315.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn315.Header.VisiblePosition = 8;
            ultraGridColumn315.Hidden = true;
            ultraGridColumn315.Width = 30;
            ultraGridColumn316.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn316.Header.VisiblePosition = 9;
            ultraGridColumn316.Hidden = true;
            ultraGridColumn316.Width = 24;
            ultraGridColumn317.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn317.Header.Caption = "Barrio";
            ultraGridColumn317.Header.VisiblePosition = 10;
            ultraGridColumn317.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn317.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn317.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(128, 0);
            ultraGridColumn317.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(118, 0);
            ultraGridColumn317.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn317.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn317.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn317.Width = 23;
            ultraGridColumn318.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn318.Header.Caption = "Localidad";
            ultraGridColumn318.Header.VisiblePosition = 11;
            ultraGridColumn318.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn318.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn318.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(175, 0);
            ultraGridColumn318.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn318.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn318.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn307,
            ultraGridColumn308,
            ultraGridColumn309,
            ultraGridColumn310,
            ultraGridColumn311,
            ultraGridColumn312,
            ultraGridColumn313,
            ultraGridColumn314,
            ultraGridColumn315,
            ultraGridColumn316,
            ultraGridColumn317,
            ultraGridColumn318});
            appearance317.FontData.BoldAsString = "True";
            appearance317.FontData.SizeInPoints = 10F;
            appearance317.TextHAlignAsString = "Left";
            ultraGridBand4.Header.Appearance = appearance317;
            ultraGridBand4.Header.Caption = "Dirección";
            ultraGridBand4.HeaderVisible = true;
            ultraGridBand4.MaxRows = 1;
            ultraGridBand4.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes;
            ultraGridBand4.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand5.AddButtonCaption = "Recurso";
            ultraGridColumn319.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn319.Header.VisiblePosition = 0;
            ultraGridColumn319.Hidden = true;
            ultraGridColumn319.Width = 9;
            ultraGridColumn320.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn320.Header.VisiblePosition = 1;
            ultraGridColumn320.Hidden = true;
            ultraGridColumn320.Width = 18;
            ultraGridColumn321.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance318.TextHAlignAsString = "Center";
            ultraGridColumn321.CellAppearance = appearance318;
            ultraGridColumn321.Header.Caption = "Recurso";
            ultraGridColumn321.Header.VisiblePosition = 2;
            ultraGridColumn321.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn321.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn321.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn321.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn321.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn321.Width = 41;
            ultraGridColumn322.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance319.TextHAlignAsString = "Center";
            ultraGridColumn322.CellAppearance = appearance319;
            ultraGridColumn322.Header.Caption = "Código";
            ultraGridColumn322.Header.VisiblePosition = 3;
            ultraGridColumn322.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn322.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn322.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn322.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn322.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn322.Width = 48;
            ultraGridColumn323.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn323.Header.VisiblePosition = 4;
            ultraGridColumn323.Hidden = true;
            ultraGridColumn323.Width = 28;
            ultraGridColumn324.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn324.Header.Caption = "Paciente a Bordo";
            ultraGridColumn324.Header.VisiblePosition = 5;
            ultraGridColumn324.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn324.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn324.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(215, 0);
            ultraGridColumn324.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn324.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn324.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn324.Width = 27;
            ultraGridColumn325.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn325.Header.VisiblePosition = 6;
            ultraGridColumn325.Hidden = true;
            ultraGridColumn325.Width = 20;
            ultraGridColumn326.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn326.Header.VisiblePosition = 7;
            ultraGridColumn326.Hidden = true;
            ultraGridColumn326.Width = 18;
            ultraGridColumn327.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn327.Header.VisiblePosition = 8;
            ultraGridColumn327.Hidden = true;
            ultraGridColumn327.Width = 24;
            ultraGridColumn328.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn328.Header.VisiblePosition = 9;
            ultraGridColumn328.Hidden = true;
            ultraGridColumn328.Width = 14;
            ultraGridColumn329.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn329.Header.VisiblePosition = 10;
            ultraGridColumn329.Hidden = true;
            ultraGridColumn329.Width = 8;
            ultraGridColumn330.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn330.Header.VisiblePosition = 11;
            ultraGridColumn330.Hidden = true;
            ultraGridColumn330.Width = 14;
            ultraGridColumn331.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn331.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance320.TextHAlignAsString = "Center";
            ultraGridColumn331.CellAppearance = appearance320;
            ultraGridColumn331.Header.VisiblePosition = 12;
            ultraGridColumn331.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn331.MaskInput = "hh:mm:ss";
            ultraGridColumn331.RowLayoutColumnInfo.MinimumCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn331.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn331.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn331.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(85, 0);
            ultraGridColumn331.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn331.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn331.Width = 56;
            ultraGridColumn332.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn332.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance321.TextHAlignAsString = "Center";
            ultraGridColumn332.CellAppearance = appearance321;
            ultraGridColumn332.Header.VisiblePosition = 13;
            ultraGridColumn332.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn332.MaskInput = "hh:mm:ss";
            ultraGridColumn332.RowLayoutColumnInfo.MinimumCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn332.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn332.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn332.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn332.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn332.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn332.Width = 37;
            ultraGridColumn333.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn333.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance322.TextHAlignAsString = "Center";
            ultraGridColumn333.CellAppearance = appearance322;
            ultraGridColumn333.Header.VisiblePosition = 14;
            ultraGridColumn333.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn333.MaskInput = "hh:mm:ss";
            ultraGridColumn333.RowLayoutColumnInfo.MinimumCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn333.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn333.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn333.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(96, 0);
            ultraGridColumn333.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(96, 0);
            ultraGridColumn333.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn333.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn333.Width = 29;
            ultraGridColumn334.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn334.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance323.TextHAlignAsString = "Center";
            ultraGridColumn334.CellAppearance = appearance323;
            ultraGridColumn334.Header.VisiblePosition = 15;
            ultraGridColumn334.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn334.MaskInput = "hh:mm:ss";
            ultraGridColumn334.RowLayoutColumnInfo.MinimumCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn334.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn334.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn334.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(96, 0);
            ultraGridColumn334.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(66, 0);
            ultraGridColumn334.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn334.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn334.Width = 37;
            ultraGridColumn335.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn335.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance324.TextHAlignAsString = "Center";
            ultraGridColumn335.CellAppearance = appearance324;
            ultraGridColumn335.Header.VisiblePosition = 16;
            ultraGridColumn335.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn335.MaskInput = "hh:mm:ss";
            ultraGridColumn335.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn335.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn335.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(86, 0);
            ultraGridColumn335.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(66, 0);
            ultraGridColumn335.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn335.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn335.Width = 56;
            ultraGridColumn336.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn336.Header.VisiblePosition = 17;
            ultraGridColumn336.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn336.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn336.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(424, 0);
            ultraGridColumn336.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(88, 0);
            ultraGridColumn336.RowLayoutColumnInfo.SpanX = 12;
            ultraGridColumn336.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn336.Width = 48;
            ultraGridColumn337.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn337.Header.Caption = "Lugar de Salida";
            ultraGridColumn337.Header.VisiblePosition = 18;
            ultraGridColumn337.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn337.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn337.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(149, 0);
            ultraGridColumn337.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn337.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn337.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn337.Width = 44;
            ultraGridColumn338.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn338.Header.Caption = "Otro Lugar de Salida";
            ultraGridColumn338.Header.VisiblePosition = 19;
            ultraGridColumn338.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn338.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn338.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(154, 0);
            ultraGridColumn338.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(116, 0);
            ultraGridColumn338.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn338.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn338.Width = 34;
            ultraGridColumn339.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn339.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance325.TextHAlignAsString = "Center";
            ultraGridColumn339.CellAppearance = appearance325;
            ultraGridColumn339.Header.Caption = "Despachador";
            ultraGridColumn339.Header.VisiblePosition = 20;
            ultraGridColumn339.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn339.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn339.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(252, 0);
            ultraGridColumn339.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn339.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn339.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn319,
            ultraGridColumn320,
            ultraGridColumn321,
            ultraGridColumn322,
            ultraGridColumn323,
            ultraGridColumn324,
            ultraGridColumn325,
            ultraGridColumn326,
            ultraGridColumn327,
            ultraGridColumn328,
            ultraGridColumn329,
            ultraGridColumn330,
            ultraGridColumn331,
            ultraGridColumn332,
            ultraGridColumn333,
            ultraGridColumn334,
            ultraGridColumn335,
            ultraGridColumn336,
            ultraGridColumn337,
            ultraGridColumn338,
            ultraGridColumn339});
            appearance326.FontData.BoldAsString = "True";
            appearance326.FontData.SizeInPoints = 10F;
            appearance326.TextHAlignAsString = "Left";
            ultraGridBand5.Header.Appearance = appearance326;
            ultraGridBand5.Header.Caption = "Recurso";
            ultraGridBand5.HeaderVisible = true;
            ultraGridBand5.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes;
            ultraGridBand5.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand5.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand5.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.destinosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.destinosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.destinosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.destinosUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.destinosUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.destinosUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance13.BackColor = System.Drawing.SystemColors.Window;
            this.destinosUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance13;
            appearance14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance14.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.destinosUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance14;
            this.destinosUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.destinosUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.destinosUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.destinosUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.destinosUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.destinosUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.destinosUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance15.BackColor = System.Drawing.Color.Transparent;
            this.destinosUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.Control;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.destinosUltraGrid.DisplayLayout.Override.CellAppearance = appearance16;
            this.destinosUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance17.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance17.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.destinosUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance17;
            this.destinosUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance18.ForeColor = System.Drawing.Color.Red;
            this.destinosUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance18;
            this.destinosUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.destinosUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance20.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.destinosUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance20;
            appearance21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.destinosUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance21;
            this.destinosUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.destinosUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.destinosUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.destinosUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.destinosUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinosUltraGrid.Location = new System.Drawing.Point(-2, -2);
            this.destinosUltraGrid.Name = "destinosUltraGrid";
            this.destinosUltraGrid.Size = new System.Drawing.Size(472, 378);
            this.destinosUltraGrid.TabIndex = 0;
            this.destinosUltraGrid.AfterCellActivate += new System.EventHandler(this.DestinosUltraGridAfterCellActivate);
            this.destinosUltraGrid.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.DestinosUltraGridAfterCellUpdate);
            this.destinosUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.DestinosUltraGridInitializeRow);
            this.destinosUltraGrid.InitializeTemplateAddRow += new Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventHandler(this.DestinosUltraGridInitializeTemplateAddRow);
            this.destinosUltraGrid.AfterEnterEditMode += new System.EventHandler(this.destinosUltraGrid_AfterEnterEditMode);
            this.destinosUltraGrid.AfterRowActivate += new System.EventHandler(this.DestinosUltraGridAfterRowActivate);
            this.destinosUltraGrid.AfterRowInsert += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.DestinosUltraGridAfterRowInsert);
            this.destinosUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.DestinosUltraGridCellChange);
            this.destinosUltraGrid.AfterCellListCloseUp += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.DestinosUltraGridAfterCellListCloseUp);
            this.destinosUltraGrid.BeforeCellListDropDown += new Infragistics.Win.UltraWinGrid.CancelableCellEventHandler(this.DestinosUltraGridBeforeCellListDropDown);
            this.destinosUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.DestinosUltraGridBeforeRowDeactivate);
            this.destinosUltraGrid.BeforeRowInsert += new Infragistics.Win.UltraWinGrid.BeforeRowInsertEventHandler(this.DestinosUltraGridBeforeRowInsert);
            this.destinosUltraGrid.BeforeCellUpdate += new Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventHandler(this.DestinosUltraGridBeforeCellUpdate);
            this.destinosUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.destinosUltraGrid_KeyDown);
            // 
            // destinosBindingSource
            // 
            this.destinosBindingSource.DataMember = "Destinos";
            this.destinosBindingSource.DataSource = this.dsDestinos;
            // 
            // dsDestinos
            // 
            this.dsDestinos.DataSetName = "DsDestinos";
            this.dsDestinos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownDespachador
            // 
            this.ultraDropDownDespachador.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownDespachador.DataSource = this.usuariosListaBindingSource;
            appearance94.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance94.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance94.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownDespachador.DisplayLayout.Appearance = appearance94;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn343.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn343.Header.VisiblePosition = 0;
            ultraGridColumn343.Hidden = true;
            ultraGridColumn344.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn344.Header.VisiblePosition = 1;
            ultraGridColumn344.Hidden = true;
            ultraGridColumn345.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn345.Header.VisiblePosition = 2;
            ultraGridColumn346.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn346.Header.VisiblePosition = 3;
            ultraGridColumn346.Hidden = true;
            ultraGridColumn347.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn347.Header.VisiblePosition = 4;
            ultraGridColumn347.Hidden = true;
            ultraGridColumn348.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn348.Header.VisiblePosition = 5;
            ultraGridColumn348.Hidden = true;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn343,
            ultraGridColumn344,
            ultraGridColumn345,
            ultraGridColumn346,
            ultraGridColumn347,
            ultraGridColumn348});
            this.ultraDropDownDespachador.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraDropDownDespachador.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownDespachador.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownDespachador.DisplayLayout.MaxBandDepth = 5;
            appearance95.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownDespachador.DisplayLayout.Override.ActiveCellAppearance = appearance95;
            appearance96.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance96.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance96.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownDespachador.DisplayLayout.Override.ActiveRowAppearance = appearance96;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownDespachador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance97.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownDespachador.DisplayLayout.Override.CardAreaAppearance = appearance97;
            appearance98.BackColor = System.Drawing.SystemColors.Control;
            appearance98.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance98.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDespachador.DisplayLayout.Override.CellAppearance = appearance98;
            this.ultraDropDownDespachador.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance99.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance99.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance99.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance99.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownDespachador.DisplayLayout.Override.HeaderAppearance = appearance99;
            this.ultraDropDownDespachador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance100.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownDespachador.DisplayLayout.Override.RowSelectorAppearance = appearance100;
            this.ultraDropDownDespachador.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownDespachador.DisplayLayout.Override.SelectedCellAppearance = appearance101;
            appearance102.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance102.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownDespachador.DisplayLayout.Override.SelectedRowAppearance = appearance102;
            appearance103.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance103.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownDespachador.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance103;
            this.ultraDropDownDespachador.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownDespachador.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownDespachador.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownDespachador.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownDespachador.DisplayMember = "NombApel";
            this.ultraDropDownDespachador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownDespachador.Location = new System.Drawing.Point(5, 250);
            this.ultraDropDownDespachador.Name = "ultraDropDownDespachador";
            this.ultraDropDownDespachador.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownDespachador.TabIndex = 51;
            this.ultraDropDownDespachador.ValueMember = "idUsuario";
            this.ultraDropDownDespachador.Visible = false;
            this.ultraDropDownDespachador.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownDespachadorBeforeDropDown);
            // 
            // usuariosListaBindingSource
            // 
            this.usuariosListaBindingSource.DataMember = "UsuariosLista";
            this.usuariosListaBindingSource.DataSource = this.dsUsuariosLista;
            // 
            // dsUsuariosLista
            // 
            this.dsUsuariosLista.DataSetName = "DsUsuariosLista";
            this.dsUsuariosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownPacientes
            // 
            this.ultraDropDownPacientes.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPacientes.DataSource = this.pacientesBindingSource;
            appearance84.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance84.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPacientes.DisplayLayout.Appearance = appearance84;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn349.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn349.Header.VisiblePosition = 0;
            ultraGridColumn349.Hidden = true;
            ultraGridColumn349.Width = 8;
            ultraGridColumn350.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn350.Header.VisiblePosition = 1;
            ultraGridColumn350.Hidden = true;
            ultraGridColumn350.Width = 9;
            ultraGridColumn351.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn351.Header.VisiblePosition = 2;
            ultraGridColumn351.Hidden = true;
            ultraGridColumn351.Width = 10;
            ultraGridColumn352.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn352.Header.VisiblePosition = 3;
            ultraGridColumn352.Width = 219;
            ultraGridColumn353.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn353.Header.VisiblePosition = 4;
            ultraGridColumn353.Hidden = true;
            ultraGridColumn353.Width = 10;
            ultraGridColumn354.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn354.Header.VisiblePosition = 5;
            ultraGridColumn354.Hidden = true;
            ultraGridColumn354.Width = 16;
            ultraGridColumn355.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn355.Header.VisiblePosition = 6;
            ultraGridColumn355.Hidden = true;
            ultraGridColumn355.Width = 16;
            ultraGridColumn356.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn356.Header.VisiblePosition = 7;
            ultraGridColumn356.Hidden = true;
            ultraGridColumn356.Width = 11;
            ultraGridColumn357.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn357.Header.VisiblePosition = 8;
            ultraGridColumn357.Hidden = true;
            ultraGridColumn357.Width = 18;
            ultraGridColumn358.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn358.Header.VisiblePosition = 9;
            ultraGridColumn358.Hidden = true;
            ultraGridColumn358.Width = 16;
            ultraGridColumn359.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn359.Header.VisiblePosition = 10;
            ultraGridColumn359.Hidden = true;
            ultraGridColumn359.Width = 12;
            ultraGridColumn360.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn360.Header.VisiblePosition = 11;
            ultraGridColumn360.Hidden = true;
            ultraGridColumn360.Width = 11;
            ultraGridColumn361.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn361.Header.VisiblePosition = 12;
            ultraGridColumn361.Hidden = true;
            ultraGridColumn361.Width = 13;
            ultraGridColumn362.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn362.Header.VisiblePosition = 13;
            ultraGridColumn362.Hidden = true;
            ultraGridColumn362.Width = 16;
            ultraGridColumn363.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn363.Header.VisiblePosition = 14;
            ultraGridColumn363.Hidden = true;
            ultraGridColumn363.Width = 11;
            ultraGridColumn364.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn364.Header.VisiblePosition = 15;
            ultraGridColumn364.Hidden = true;
            ultraGridColumn364.Width = 10;
            ultraGridColumn365.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn365.Header.VisiblePosition = 16;
            ultraGridColumn365.Hidden = true;
            ultraGridColumn366.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn366.Header.VisiblePosition = 17;
            ultraGridColumn366.Hidden = true;
            ultraGridColumn367.Header.VisiblePosition = 18;
            ultraGridColumn367.Hidden = true;
            ultraGridColumn368.Header.VisiblePosition = 19;
            ultraGridColumn368.Hidden = true;
            ultraGridColumn369.Header.VisiblePosition = 20;
            ultraGridColumn369.Hidden = true;
            ultraGridColumn370.Header.VisiblePosition = 21;
            ultraGridColumn371.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn371.Header.VisiblePosition = 22;
            ultraGridColumn372.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn372.Header.VisiblePosition = 23;
            ultraGridColumn373.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn373.Header.VisiblePosition = 24;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn349,
            ultraGridColumn350,
            ultraGridColumn351,
            ultraGridColumn352,
            ultraGridColumn353,
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
            ultraGridColumn373});
            ultraGridColumn374.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn374.Header.VisiblePosition = 0;
            ultraGridColumn374.Width = 174;
            ultraGridColumn375.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn375.Header.VisiblePosition = 1;
            ultraGridColumn375.Width = 193;
            ultraGridColumn376.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn376.Header.VisiblePosition = 2;
            ultraGridColumn376.Width = 115;
            ultraGridColumn377.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn377.Header.VisiblePosition = 3;
            ultraGridColumn377.Width = 167;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn374,
            ultraGridColumn375,
            ultraGridColumn376,
            ultraGridColumn377});
            ultraGridColumn378.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn378.Header.VisiblePosition = 0;
            ultraGridColumn378.Width = 298;
            ultraGridColumn379.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn379.Header.VisiblePosition = 1;
            ultraGridColumn379.Width = 192;
            ultraGridColumn380.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn380.Header.VisiblePosition = 2;
            ultraGridColumn380.Width = 159;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn378,
            ultraGridColumn379,
            ultraGridColumn380});
            ultraGridColumn381.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn381.Header.VisiblePosition = 0;
            ultraGridColumn381.Width = 262;
            ultraGridColumn382.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn382.Header.VisiblePosition = 1;
            ultraGridColumn382.Width = 159;
            ultraGridColumn383.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn383.Header.VisiblePosition = 2;
            ultraGridColumn383.Width = 120;
            ultraGridColumn384.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn384.Header.VisiblePosition = 3;
            ultraGridColumn384.Width = 108;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn381,
            ultraGridColumn382,
            ultraGridColumn383,
            ultraGridColumn384});
            this.ultraDropDownPacientes.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraDropDownPacientes.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.ultraDropDownPacientes.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.ultraDropDownPacientes.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.ultraDropDownPacientes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPacientes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPacientes.DisplayLayout.MaxBandDepth = 5;
            appearance85.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPacientes.DisplayLayout.Override.ActiveCellAppearance = appearance85;
            appearance86.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance86.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance86.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPacientes.DisplayLayout.Override.ActiveRowAppearance = appearance86;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPacientes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance87.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPacientes.DisplayLayout.Override.CardAreaAppearance = appearance87;
            appearance88.BackColor = System.Drawing.SystemColors.Control;
            appearance88.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPacientes.DisplayLayout.Override.CellAppearance = appearance88;
            this.ultraDropDownPacientes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance89.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance89.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance89.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance89.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPacientes.DisplayLayout.Override.HeaderAppearance = appearance89;
            this.ultraDropDownPacientes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance90.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPacientes.DisplayLayout.Override.RowSelectorAppearance = appearance90;
            this.ultraDropDownPacientes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPacientes.DisplayLayout.Override.SelectedCellAppearance = appearance91;
            appearance92.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance92.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance92.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPacientes.DisplayLayout.Override.SelectedRowAppearance = appearance92;
            appearance93.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance93.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPacientes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance93;
            this.ultraDropDownPacientes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPacientes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPacientes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPacientes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPacientes.DisplayMember = "Nombre";
            this.ultraDropDownPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownPacientes.Location = new System.Drawing.Point(5, 169);
            this.ultraDropDownPacientes.Name = "ultraDropDownPacientes";
            this.ultraDropDownPacientes.Size = new System.Drawing.Size(238, 35);
            this.ultraDropDownPacientes.TabIndex = 50;
            this.ultraDropDownPacientes.ValueMember = "idPaciente";
            this.ultraDropDownPacientes.Visible = false;
            this.ultraDropDownPacientes.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownPacientesBeforeDropDown);
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.dsPacientesPrestacion;
            // 
            // dsPacientesPrestacion
            // 
            this.dsPacientesPrestacion.DataSetName = "DsPacientesPrestacion";
            this.dsPacientesPrestacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMedicos
            // 
            this.ultraDropDownMedicos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMedicos.DataSource = this.ultraDataSourceMedicos;
            appearance22.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMedicos.DisplayLayout.Appearance = appearance22;
            ultraGridBand12.ColHeadersVisible = false;
            ultraGridColumn385.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn385.Header.VisiblePosition = 0;
            ultraGridColumn385.Hidden = true;
            ultraGridColumn385.Width = 43;
            ultraGridColumn386.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn386.Header.VisiblePosition = 1;
            ultraGridColumn386.Width = 219;
            ultraGridColumn387.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn387.Header.VisiblePosition = 2;
            ultraGridColumn387.Hidden = true;
            ultraGridColumn387.Width = 51;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn385,
            ultraGridColumn386,
            ultraGridColumn387});
            this.ultraDropDownMedicos.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.ultraDropDownMedicos.DisplayLayout.ColScrollRegions.Add(colScrollRegion1);
            this.ultraDropDownMedicos.DisplayLayout.ColScrollRegions.Add(colScrollRegion2);
            this.ultraDropDownMedicos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMedicos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMedicos.DisplayLayout.MaxBandDepth = 5;
            appearance23.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMedicos.DisplayLayout.Override.ActiveCellAppearance = appearance23;
            appearance24.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance24.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance24.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMedicos.DisplayLayout.Override.ActiveRowAppearance = appearance24;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMedicos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance25.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMedicos.DisplayLayout.Override.CardAreaAppearance = appearance25;
            appearance26.BackColor = System.Drawing.SystemColors.Control;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicos.DisplayLayout.Override.CellAppearance = appearance26;
            this.ultraDropDownMedicos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance27.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance27.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMedicos.DisplayLayout.Override.HeaderAppearance = appearance27;
            this.ultraDropDownMedicos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance28.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMedicos.DisplayLayout.Override.RowSelectorAppearance = appearance28;
            this.ultraDropDownMedicos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMedicos.DisplayLayout.Override.SelectedCellAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance30.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicos.DisplayLayout.Override.SelectedRowAppearance = appearance30;
            appearance31.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMedicos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance31;
            this.ultraDropDownMedicos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMedicos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMedicos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMedicos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMedicos.DisplayMember = "ApelNomb";
            this.ultraDropDownMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownMedicos.Location = new System.Drawing.Point(5, 212);
            this.ultraDropDownMedicos.Name = "ultraDropDownMedicos";
            this.ultraDropDownMedicos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownMedicos.TabIndex = 39;
            this.ultraDropDownMedicos.ValueMember = "idEmpleado";
            this.ultraDropDownMedicos.Visible = false;
            this.ultraDropDownMedicos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownMedicosBeforeDropDown);
            // 
            // ultraDataSourceMedicos
            // 
            ultraDataColumn1.DataType = typeof(int);
            this.ultraDataSourceMedicos.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2,
            ultraDataColumn3});
            // 
            // ultraDropDownTiposDeDocumento
            // 
            this.ultraDropDownTiposDeDocumento.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeDocumento.DataSource = this.tiposDeDocumentoBindingSource;
            appearance144.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance144.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance144.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Appearance = appearance144;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand13.ColHeadersVisible = false;
            ultraGridColumn388.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn388.Header.VisiblePosition = 0;
            ultraGridColumn388.Hidden = true;
            ultraGridColumn388.Width = 85;
            ultraGridColumn389.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn389.Header.VisiblePosition = 1;
            ultraGridColumn389.Hidden = true;
            ultraGridColumn389.Width = 231;
            ultraGridColumn390.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn390.Header.VisiblePosition = 2;
            ultraGridColumn390.Width = 231;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn388,
            ultraGridColumn389,
            ultraGridColumn390});
            this.ultraDropDownTiposDeDocumento.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
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
            this.ultraDropDownTiposDeDocumento.Location = new System.Drawing.Point(249, 250);
            this.ultraDropDownTiposDeDocumento.Name = "ultraDropDownTiposDeDocumento";
            this.ultraDropDownTiposDeDocumento.Size = new System.Drawing.Size(238, 34);
            this.ultraDropDownTiposDeDocumento.TabIndex = 52;
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
            // ultraDropDownCodigos
            // 
            this.ultraDropDownCodigos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCodigos.DataSource = this.codigosBindingSource;
            appearance32.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCodigos.DisplayLayout.Appearance = appearance32;
            ultraGridBand14.ColHeadersVisible = false;
            ultraGridColumn391.Header.VisiblePosition = 0;
            ultraGridColumn391.Hidden = true;
            ultraGridColumn392.Header.VisiblePosition = 1;
            ultraGridColumn393.Header.VisiblePosition = 2;
            ultraGridColumn393.Hidden = true;
            ultraGridColumn394.Header.VisiblePosition = 3;
            ultraGridColumn394.Hidden = true;
            ultraGridColumn395.Header.VisiblePosition = 4;
            ultraGridColumn395.Hidden = true;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn391,
            ultraGridColumn392,
            ultraGridColumn393,
            ultraGridColumn394,
            ultraGridColumn395});
            this.ultraDropDownCodigos.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.ultraDropDownCodigos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCodigos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCodigos.DisplayLayout.MaxBandDepth = 5;
            appearance33.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCodigos.DisplayLayout.Override.ActiveCellAppearance = appearance33;
            appearance34.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance34.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance34.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCodigos.DisplayLayout.Override.ActiveRowAppearance = appearance34;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCodigos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance35.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCodigos.DisplayLayout.Override.CardAreaAppearance = appearance35;
            appearance36.BackColor = System.Drawing.SystemColors.Control;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCodigos.DisplayLayout.Override.CellAppearance = appearance36;
            this.ultraDropDownCodigos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance37.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance37.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance37.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCodigos.DisplayLayout.Override.HeaderAppearance = appearance37;
            this.ultraDropDownCodigos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance38.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCodigos.DisplayLayout.Override.RowSelectorAppearance = appearance38;
            this.ultraDropDownCodigos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCodigos.DisplayLayout.Override.SelectedCellAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance40.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCodigos.DisplayLayout.Override.SelectedRowAppearance = appearance40;
            appearance41.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCodigos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance41;
            this.ultraDropDownCodigos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCodigos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCodigos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCodigos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCodigos.DisplayMember = "Nombre";
            this.ultraDropDownCodigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownCodigos.Location = new System.Drawing.Point(247, 172);
            this.ultraDropDownCodigos.Name = "ultraDropDownCodigos";
            this.ultraDropDownCodigos.Size = new System.Drawing.Size(223, 32);
            this.ultraDropDownCodigos.TabIndex = 53;
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
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pacientesUltraGrid);
            this.panel4.Location = new System.Drawing.Point(486, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 378);
            this.panel4.TabIndex = 0;
            // 
            // pacientesUltraGrid
            // 
            this.pacientesUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pacientesUltraGrid.CalcManager = this.ultraCalcManager1;
            this.pacientesUltraGrid.DataSource = this.pacientesBindingSource;
            appearance2.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.pacientesUltraGrid.DisplayLayout.Appearance = appearance2;
            this.pacientesUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn396.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn396.Header.VisiblePosition = 0;
            ultraGridColumn396.Hidden = true;
            ultraGridColumn396.Width = 17;
            ultraGridColumn397.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn397.Header.VisiblePosition = 1;
            ultraGridColumn397.Hidden = true;
            ultraGridColumn397.Width = 29;
            ultraGridColumn398.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn398.Header.VisiblePosition = 2;
            ultraGridColumn398.Hidden = true;
            ultraGridColumn398.Width = 23;
            ultraGridColumn399.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn399.Header.VisiblePosition = 3;
            ultraGridColumn399.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn399.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn399.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(404, 0);
            ultraGridColumn399.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(404, 0);
            ultraGridColumn399.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn399.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn399.Width = 48;
            ultraGridColumn400.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance327.TextHAlignAsString = "Right";
            ultraGridColumn400.CellAppearance = appearance327;
            ultraGridColumn400.Header.VisiblePosition = 4;
            ultraGridColumn400.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn400.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn400.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(115, 0);
            ultraGridColumn400.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(115, 0);
            ultraGridColumn400.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn400.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn400.Width = 25;
            ultraGridColumn401.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn401.Header.Caption = "en";
            ultraGridColumn401.Header.VisiblePosition = 5;
            ultraGridColumn401.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn401.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn401.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(118, 0);
            ultraGridColumn401.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(118, 0);
            ultraGridColumn401.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn401.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn401.Width = 42;
            ultraGridColumn402.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn402.Header.VisiblePosition = 6;
            ultraGridColumn402.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn402.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn402.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(123, 0);
            ultraGridColumn402.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(123, 0);
            ultraGridColumn402.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn402.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn402.Width = 42;
            ultraGridColumn403.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn403.Header.Caption = "Prepago";
            ultraGridColumn403.Header.VisiblePosition = 7;
            ultraGridColumn403.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn403.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn403.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(410, 0);
            ultraGridColumn403.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(410, 0);
            ultraGridColumn403.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn403.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn403.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn403.Width = 29;
            ultraGridColumn404.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn404.Header.Caption = "Nº Af. Prepago";
            ultraGridColumn404.Header.VisiblePosition = 8;
            ultraGridColumn404.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn404.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn404.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(455, 0);
            ultraGridColumn404.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(455, 0);
            ultraGridColumn404.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn404.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn404.Width = 49;
            ultraGridColumn405.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance328.TextHAlignAsString = "Center";
            ultraGridColumn405.CellAppearance = appearance328;
            ultraGridColumn405.Header.Caption = "Incidente";
            ultraGridColumn405.Header.VisiblePosition = 9;
            ultraGridColumn405.MaxLength = 30;
            ultraGridColumn405.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn405.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn405.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(195, 0);
            ultraGridColumn405.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(195, 0);
            ultraGridColumn405.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn405.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn405.Width = 43;
            ultraGridColumn406.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn406.Header.Caption = "Cobertura";
            ultraGridColumn406.Header.VisiblePosition = 10;
            ultraGridColumn406.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn406.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn406.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(404, 0);
            ultraGridColumn406.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(404, 0);
            ultraGridColumn406.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn406.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn406.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn406.Width = 31;
            ultraGridColumn407.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn407.Header.Caption = "Práctica";
            ultraGridColumn407.Header.VisiblePosition = 11;
            ultraGridColumn407.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn407.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn407.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(461, 0);
            ultraGridColumn407.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(461, 0);
            ultraGridColumn407.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn407.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn407.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn407.Width = 28;
            ultraGridColumn408.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance329.TextHAlignAsString = "Right";
            ultraGridColumn408.CellAppearance = appearance329;
            ultraGridColumn408.Header.VisiblePosition = 12;
            ultraGridColumn408.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn408.MaskInput = "{LOC}$ n,nnn,nnn.nn";
            ultraGridColumn408.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn408.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn408.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(174, 0);
            ultraGridColumn408.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(174, 0);
            ultraGridColumn408.RowLayoutColumnInfo.SpanX = 19;
            ultraGridColumn408.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn408.Width = 34;
            ultraGridColumn409.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn409.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn409.Header.VisiblePosition = 13;
            ultraGridColumn409.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn409.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn409.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(399, 56);
            ultraGridColumn409.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(399, 0);
            ultraGridColumn409.RowLayoutColumnInfo.SpanX = 21;
            ultraGridColumn409.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn409.VertScrollBar = true;
            ultraGridColumn409.Width = 42;
            ultraGridColumn410.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn410.Header.Caption = "Contrato";
            ultraGridColumn410.Header.VisiblePosition = 14;
            ultraGridColumn410.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn410.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn410.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(865, 0);
            ultraGridColumn410.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(865, 0);
            ultraGridColumn410.RowLayoutColumnInfo.SpanX = 9;
            ultraGridColumn410.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn410.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn411.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn411.Header.Caption = "Médico";
            ultraGridColumn411.Header.VisiblePosition = 15;
            ultraGridColumn411.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn411.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn411.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(356, 0);
            ultraGridColumn411.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(356, 0);
            ultraGridColumn411.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn411.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn411.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn412.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn412.Header.VisiblePosition = 16;
            ultraGridColumn412.Hidden = true;
            ultraGridColumn413.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn413.DefaultCellValue = "False";
            ultraGridColumn413.Header.Caption = "Extra";
            ultraGridColumn413.Header.VisiblePosition = 17;
            ultraGridColumn413.RowLayoutColumnInfo.OriginX = 29;
            ultraGridColumn413.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn413.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(135, 0);
            ultraGridColumn413.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(135, 0);
            ultraGridColumn413.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn413.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn414.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn414.Header.Caption = "Doc.";
            ultraGridColumn414.Header.VisiblePosition = 18;
            ultraGridColumn414.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn414.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn414.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(74, 0);
            ultraGridColumn414.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(74, 0);
            ultraGridColumn414.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn414.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn414.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn415.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance330.TextHAlignAsString = "Right";
            ultraGridColumn415.CellAppearance = appearance330;
            ultraGridColumn415.Header.Caption = "N° Docum.";
            ultraGridColumn415.Header.VisiblePosition = 19;
            ultraGridColumn415.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn415.MaskInput = "{LOC}nnn,nnn,nnn,nnn";
            ultraGridColumn415.MaxLength = 9;
            ultraGridColumn415.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn415.RowLayoutColumnInfo.OriginY = 8;
            ultraGridColumn415.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(330, 0);
            ultraGridColumn415.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(330, 0);
            ultraGridColumn415.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn415.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn416.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn416.Header.VisiblePosition = 21;
            ultraGridColumn416.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn416.RowLayoutColumnInfo.OriginY = 12;
            ultraGridColumn416.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(1264, 38);
            ultraGridColumn416.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(1264, 0);
            ultraGridColumn416.RowLayoutColumnInfo.SpanX = 30;
            ultraGridColumn416.RowLayoutColumnInfo.SpanY = 3;
            ultraGridColumn416.VertScrollBar = true;
            ultraGridColumn417.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn417.Header.VisiblePosition = 22;
            ultraGridColumn417.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn417.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn417.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(139, 56);
            ultraGridColumn417.RowLayoutColumnInfo.SpanX = 21;
            ultraGridColumn417.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn417.VertScrollBar = true;
            ultraGridColumn418.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn418.Header.VisiblePosition = 27;
            ultraGridColumn419.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn419.Header.VisiblePosition = 28;
            ultraGridColumn420.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn420.Header.VisiblePosition = 29;
            ultraGridColumn421.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance331.TextHAlignAsString = "Center";
            ultraGridColumn421.CellAppearance = appearance331;
            ultraGridColumn421.Header.Caption = "";
            ultraGridColumn421.Header.VisiblePosition = 20;
            ultraGridColumn421.RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridColumn421.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn421.RowLayoutColumnInfo.OriginY = 10;
            ultraGridColumn421.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(404, 0);
            ultraGridColumn421.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(116, 0);
            ultraGridColumn421.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn421.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn421.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn422.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn422.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn422.DataType = typeof(bool);
            ultraGridColumn422.Header.Caption = "Lista";
            ultraGridColumn422.Header.VisiblePosition = 23;
            ultraGridColumn422.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn422.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn422.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(105, 0);
            ultraGridColumn422.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(105, 0);
            ultraGridColumn422.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn422.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn423.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance332.TextHAlignAsString = "Center";
            ultraGridColumn423.CellAppearance = appearance332;
            ultraGridColumn423.Header.VisiblePosition = 24;
            ultraGridColumn423.RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridColumn423.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn423.RowLayoutColumnInfo.OriginY = 10;
            ultraGridColumn423.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(318, 0);
            ultraGridColumn423.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn423.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn423.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn424.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance333.TextHAlignAsString = "Center";
            ultraGridColumn424.CellAppearance = appearance333;
            ultraGridColumn424.Header.VisiblePosition = 25;
            ultraGridColumn424.RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridColumn424.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn424.RowLayoutColumnInfo.OriginY = 10;
            ultraGridColumn424.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(309, 0);
            ultraGridColumn424.RowLayoutColumnInfo.SpanX = 17;
            ultraGridColumn424.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn424.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridColumn425.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            appearance334.TextHAlignAsString = "Center";
            ultraGridColumn425.CellAppearance = appearance334;
            ultraGridColumn425.Header.VisiblePosition = 26;
            ultraGridColumn425.RowLayoutColumnInfo.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridColumn425.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn425.RowLayoutColumnInfo.OriginY = 10;
            ultraGridColumn425.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(233, 0);
            ultraGridColumn425.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn425.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn425.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn396,
            ultraGridColumn397,
            ultraGridColumn398,
            ultraGridColumn399,
            ultraGridColumn400,
            ultraGridColumn401,
            ultraGridColumn402,
            ultraGridColumn403,
            ultraGridColumn404,
            ultraGridColumn405,
            ultraGridColumn406,
            ultraGridColumn407,
            ultraGridColumn408,
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
            ultraGridColumn425});
            appearance335.FontData.BoldAsString = "True";
            appearance335.FontData.SizeInPoints = 11F;
            appearance335.TextHAlignAsString = "Left";
            ultraGridBand15.Header.Appearance = appearance335;
            ultraGridBand15.Header.Caption = "Paciente";
            ultraGridBand15.HeaderVisible = true;
            ultraGridBand15.MinRows = 1;
            ultraGridBand15.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.Yes;
            ultraGridBand15.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            rowLayoutColumnInfo4.OriginX = 0;
            rowLayoutColumnInfo4.OriginY = 0;
            rowLayoutColumnInfo4.PreferredCellSize = new System.Drawing.Size(394, 0);
            rowLayoutColumnInfo4.PreferredLabelSize = new System.Drawing.Size(394, 0);
            rowLayoutColumnInfo4.SpanX = 4;
            rowLayoutColumnInfo4.SpanY = 2;
            rowLayoutColumnInfo5.OriginX = 4;
            rowLayoutColumnInfo5.OriginY = 0;
            rowLayoutColumnInfo5.PreferredCellSize = new System.Drawing.Size(115, 0);
            rowLayoutColumnInfo5.PreferredLabelSize = new System.Drawing.Size(115, 0);
            rowLayoutColumnInfo5.SpanX = 2;
            rowLayoutColumnInfo5.SpanY = 2;
            rowLayoutColumnInfo6.OriginX = 6;
            rowLayoutColumnInfo6.OriginY = 0;
            rowLayoutColumnInfo6.PreferredCellSize = new System.Drawing.Size(118, 0);
            rowLayoutColumnInfo6.PreferredLabelSize = new System.Drawing.Size(118, 0);
            rowLayoutColumnInfo6.SpanX = 1;
            rowLayoutColumnInfo6.SpanY = 2;
            rowLayoutColumnInfo7.OriginX = 7;
            rowLayoutColumnInfo7.OriginY = 0;
            rowLayoutColumnInfo7.PreferredCellSize = new System.Drawing.Size(123, 0);
            rowLayoutColumnInfo7.PreferredLabelSize = new System.Drawing.Size(123, 0);
            rowLayoutColumnInfo7.SpanX = 1;
            rowLayoutColumnInfo7.SpanY = 2;
            rowLayoutColumnInfo8.OriginX = 0;
            rowLayoutColumnInfo8.OriginY = 2;
            rowLayoutColumnInfo8.PreferredCellSize = new System.Drawing.Size(410, 0);
            rowLayoutColumnInfo8.PreferredLabelSize = new System.Drawing.Size(410, 0);
            rowLayoutColumnInfo8.SpanX = 5;
            rowLayoutColumnInfo8.SpanY = 2;
            rowLayoutColumnInfo9.OriginX = 5;
            rowLayoutColumnInfo9.OriginY = 2;
            rowLayoutColumnInfo9.PreferredCellSize = new System.Drawing.Size(435, 0);
            rowLayoutColumnInfo9.PreferredLabelSize = new System.Drawing.Size(435, 0);
            rowLayoutColumnInfo9.SpanX = 4;
            rowLayoutColumnInfo9.SpanY = 2;
            rowLayoutColumnInfo10.OriginX = 8;
            rowLayoutColumnInfo10.OriginY = 8;
            rowLayoutColumnInfo10.PreferredCellSize = new System.Drawing.Size(195, 0);
            rowLayoutColumnInfo10.PreferredLabelSize = new System.Drawing.Size(195, 0);
            rowLayoutColumnInfo10.SpanX = 2;
            rowLayoutColumnInfo10.SpanY = 2;
            rowLayoutColumnInfo11.OriginX = 0;
            rowLayoutColumnInfo11.OriginY = 6;
            rowLayoutColumnInfo11.PreferredCellSize = new System.Drawing.Size(394, 0);
            rowLayoutColumnInfo11.PreferredLabelSize = new System.Drawing.Size(394, 0);
            rowLayoutColumnInfo11.SpanX = 4;
            rowLayoutColumnInfo11.SpanY = 2;
            rowLayoutColumnInfo12.OriginX = 4;
            rowLayoutColumnInfo12.OriginY = 6;
            rowLayoutColumnInfo12.PreferredCellSize = new System.Drawing.Size(451, 0);
            rowLayoutColumnInfo12.PreferredLabelSize = new System.Drawing.Size(451, 0);
            rowLayoutColumnInfo12.SpanX = 5;
            rowLayoutColumnInfo12.SpanY = 2;
            rowLayoutColumnInfo13.OriginX = 10;
            rowLayoutColumnInfo13.OriginY = 8;
            rowLayoutColumnInfo13.PreferredCellSize = new System.Drawing.Size(134, 0);
            rowLayoutColumnInfo13.PreferredLabelSize = new System.Drawing.Size(134, 0);
            rowLayoutColumnInfo13.SpanX = 19;
            rowLayoutColumnInfo13.SpanY = 2;
            rowLayoutColumnInfo14.OriginX = 9;
            rowLayoutColumnInfo14.OriginY = 0;
            rowLayoutColumnInfo14.PreferredCellSize = new System.Drawing.Size(359, 56);
            rowLayoutColumnInfo14.PreferredLabelSize = new System.Drawing.Size(359, 0);
            rowLayoutColumnInfo14.SpanX = 21;
            rowLayoutColumnInfo14.SpanY = 4;
            rowLayoutColumnInfo15.OriginX = 0;
            rowLayoutColumnInfo15.OriginY = 4;
            rowLayoutColumnInfo15.PreferredCellSize = new System.Drawing.Size(845, 0);
            rowLayoutColumnInfo15.PreferredLabelSize = new System.Drawing.Size(845, 0);
            rowLayoutColumnInfo15.SpanX = 9;
            rowLayoutColumnInfo15.SpanY = 2;
            rowLayoutColumnInfo16.OriginX = 4;
            rowLayoutColumnInfo16.OriginY = 8;
            rowLayoutColumnInfo16.PreferredCellSize = new System.Drawing.Size(356, 0);
            rowLayoutColumnInfo16.PreferredLabelSize = new System.Drawing.Size(356, 0);
            rowLayoutColumnInfo16.SpanX = 4;
            rowLayoutColumnInfo16.SpanY = 2;
            rowLayoutColumnInfo18.OriginX = 29;
            rowLayoutColumnInfo18.OriginY = 8;
            rowLayoutColumnInfo18.PreferredCellSize = new System.Drawing.Size(125, 0);
            rowLayoutColumnInfo18.PreferredLabelSize = new System.Drawing.Size(125, 0);
            rowLayoutColumnInfo18.SpanX = 1;
            rowLayoutColumnInfo18.SpanY = 2;
            rowLayoutColumnInfo19.OriginX = 0;
            rowLayoutColumnInfo19.OriginY = 8;
            rowLayoutColumnInfo19.PreferredCellSize = new System.Drawing.Size(74, 0);
            rowLayoutColumnInfo19.PreferredLabelSize = new System.Drawing.Size(74, 0);
            rowLayoutColumnInfo19.SpanX = 1;
            rowLayoutColumnInfo19.SpanY = 2;
            rowLayoutColumnInfo20.OriginX = 2;
            rowLayoutColumnInfo20.OriginY = 8;
            rowLayoutColumnInfo20.PreferredCellSize = new System.Drawing.Size(320, 0);
            rowLayoutColumnInfo20.PreferredLabelSize = new System.Drawing.Size(320, 0);
            rowLayoutColumnInfo20.SpanX = 2;
            rowLayoutColumnInfo20.SpanY = 2;
            rowLayoutColumnInfo21.OriginX = 0;
            rowLayoutColumnInfo21.OriginY = 12;
            rowLayoutColumnInfo21.PreferredCellSize = new System.Drawing.Size(1204, 38);
            rowLayoutColumnInfo21.PreferredLabelSize = new System.Drawing.Size(1204, 0);
            rowLayoutColumnInfo21.SpanX = 30;
            rowLayoutColumnInfo21.SpanY = 3;
            rowLayoutColumnInfo26.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            rowLayoutColumnInfo26.OriginX = 0;
            rowLayoutColumnInfo26.OriginY = 10;
            rowLayoutColumnInfo26.PreferredCellSize = new System.Drawing.Size(394, 0);
            rowLayoutColumnInfo26.PreferredLabelSize = new System.Drawing.Size(116, 0);
            rowLayoutColumnInfo26.SpanX = 4;
            rowLayoutColumnInfo26.SpanY = 2;
            rowLayoutColumnInfo27.OriginX = 8;
            rowLayoutColumnInfo27.OriginY = 0;
            rowLayoutColumnInfo27.PreferredCellSize = new System.Drawing.Size(95, 0);
            rowLayoutColumnInfo27.PreferredLabelSize = new System.Drawing.Size(95, 0);
            rowLayoutColumnInfo27.SpanX = 1;
            rowLayoutColumnInfo27.SpanY = 2;
            rowLayoutColumnInfo28.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            rowLayoutColumnInfo28.OriginX = 7;
            rowLayoutColumnInfo28.OriginY = 10;
            rowLayoutColumnInfo28.PreferredCellSize = new System.Drawing.Size(318, 0);
            rowLayoutColumnInfo28.SpanX = 6;
            rowLayoutColumnInfo28.SpanY = 2;
            rowLayoutColumnInfo29.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            rowLayoutColumnInfo29.OriginX = 13;
            rowLayoutColumnInfo29.OriginY = 10;
            rowLayoutColumnInfo29.PreferredCellSize = new System.Drawing.Size(259, 0);
            rowLayoutColumnInfo29.SpanX = 17;
            rowLayoutColumnInfo29.SpanY = 2;
            rowLayoutColumnInfo30.LabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            rowLayoutColumnInfo30.OriginX = 4;
            rowLayoutColumnInfo30.OriginY = 10;
            rowLayoutColumnInfo30.PreferredCellSize = new System.Drawing.Size(233, 0);
            rowLayoutColumnInfo30.SpanX = 3;
            rowLayoutColumnInfo30.SpanY = 2;
            rowLayout1.ColumnInfos.AddRange(new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo[] {
            rowLayoutColumnInfo1,
            rowLayoutColumnInfo2,
            rowLayoutColumnInfo3,
            rowLayoutColumnInfo4,
            rowLayoutColumnInfo5,
            rowLayoutColumnInfo6,
            rowLayoutColumnInfo7,
            rowLayoutColumnInfo8,
            rowLayoutColumnInfo9,
            rowLayoutColumnInfo10,
            rowLayoutColumnInfo11,
            rowLayoutColumnInfo12,
            rowLayoutColumnInfo13,
            rowLayoutColumnInfo14,
            rowLayoutColumnInfo15,
            rowLayoutColumnInfo16,
            rowLayoutColumnInfo17,
            rowLayoutColumnInfo18,
            rowLayoutColumnInfo19,
            rowLayoutColumnInfo20,
            rowLayoutColumnInfo21,
            rowLayoutColumnInfo22,
            rowLayoutColumnInfo23,
            rowLayoutColumnInfo24,
            rowLayoutColumnInfo25,
            rowLayoutColumnInfo26,
            rowLayoutColumnInfo27,
            rowLayoutColumnInfo28,
            rowLayoutColumnInfo29,
            rowLayoutColumnInfo30});
            rowLayout1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            rowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand15.RowLayouts.AddRange(new Infragistics.Win.UltraWinGrid.RowLayout[] {
            rowLayout1});
            ultraGridBand15.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridBand16.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand16.CardSettings.LabelWidth = 123;
            ultraGridBand16.CardSettings.ShowCaption = false;
            ultraGridBand16.CardSettings.Style = Infragistics.Win.UltraWinGrid.CardStyle.StandardLabels;
            ultraGridBand16.CardView = true;
            ultraGridBand16.ColHeadersVisible = false;
            ultraGridColumn426.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn426.Header.VisiblePosition = 0;
            ultraGridColumn426.Hidden = true;
            ultraGridColumn427.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn427.Header.Caption = "";
            ultraGridColumn427.Header.VisiblePosition = 1;
            ultraGridColumn427.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn427.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn427.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn427.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn427.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn427.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn427.Width = 101;
            ultraGridColumn428.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn428.Header.VisiblePosition = 2;
            ultraGridColumn428.Hidden = true;
            ultraGridColumn429.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn429.Header.VisiblePosition = 3;
            ultraGridColumn429.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn429.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn429.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn429.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn429.RowLayoutColumnInfo.SpanY = 2;
            ultraGridBand16.Columns.AddRange(new object[] {
            ultraGridColumn426,
            ultraGridColumn427,
            ultraGridColumn428,
            ultraGridColumn429});
            appearance336.FontData.BoldAsString = "True";
            appearance336.FontData.SizeInPoints = 10F;
            appearance336.TextHAlignAsString = "Left";
            ultraGridBand16.Header.Appearance = appearance336;
            ultraGridBand16.Header.Caption = "Motivos de Llamado";
            ultraGridBand16.HeaderVisible = true;
            rowLayout2.CardView = true;
            rowLayout2.CardViewStyle = Infragistics.Win.UltraWinGrid.CardStyle.StandardLabels;
            rowLayoutColumnInfo32.OriginX = 0;
            rowLayoutColumnInfo32.OriginY = 0;
            rowLayoutColumnInfo32.PreferredCellSize = new System.Drawing.Size(102, 0);
            rowLayoutColumnInfo32.SpanX = 2;
            rowLayoutColumnInfo32.SpanY = 2;
            rowLayoutColumnInfo34.OriginX = 0;
            rowLayoutColumnInfo34.OriginY = 2;
            rowLayoutColumnInfo34.PreferredCellSize = new System.Drawing.Size(102, 0);
            rowLayoutColumnInfo34.SpanX = 2;
            rowLayoutColumnInfo34.SpanY = 2;
            rowLayout2.ColumnInfos.AddRange(new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo[] {
            rowLayoutColumnInfo31,
            rowLayoutColumnInfo32,
            rowLayoutColumnInfo33,
            rowLayoutColumnInfo34});
            rowLayout2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand16.RowLayouts.AddRange(new Infragistics.Win.UltraWinGrid.RowLayout[] {
            rowLayout2});
            ultraGridBand16.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridBand17.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand17.CardSettings.LabelWidth = 95;
            ultraGridBand17.CardSettings.ShowCaption = false;
            ultraGridBand17.CardSettings.Style = Infragistics.Win.UltraWinGrid.CardStyle.StandardLabels;
            ultraGridBand17.CardView = true;
            ultraGridBand17.ColHeadersVisible = false;
            ultraGridColumn430.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn430.Header.VisiblePosition = 0;
            ultraGridColumn430.Hidden = true;
            ultraGridColumn430.Width = 100;
            ultraGridColumn431.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn431.Header.VisiblePosition = 1;
            ultraGridColumn431.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(102, 0);
            ultraGridColumn431.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn432.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn432.Header.VisiblePosition = 2;
            ultraGridColumn432.Hidden = true;
            ultraGridBand17.Columns.AddRange(new object[] {
            ultraGridColumn430,
            ultraGridColumn431,
            ultraGridColumn432});
            appearance337.FontData.BoldAsString = "True";
            appearance337.FontData.SizeInPoints = 10F;
            appearance337.TextHAlignAsString = "Left";
            ultraGridBand17.Header.Appearance = appearance337;
            ultraGridBand17.Header.Caption = "Diagnósticos";
            ultraGridBand17.HeaderVisible = true;
            rowLayout3.CardView = true;
            rowLayout3.CardViewStyle = Infragistics.Win.UltraWinGrid.CardStyle.StandardLabels;
            rowLayoutColumnInfo36.PreferredCellSize = new System.Drawing.Size(102, 0);
            rowLayout3.ColumnInfos.AddRange(new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo[] {
            rowLayoutColumnInfo35,
            rowLayoutColumnInfo36,
            rowLayoutColumnInfo37});
            rowLayout3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand17.RowLayouts.AddRange(new Infragistics.Win.UltraWinGrid.RowLayout[] {
            rowLayout3});
            ultraGridBand17.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ultraGridColumn433.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn433.Header.VisiblePosition = 0;
            ultraGridColumn433.Hidden = true;
            ultraGridColumn434.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn434.Header.Caption = "Medicamento o Descartable";
            ultraGridColumn434.Header.VisiblePosition = 1;
            ultraGridColumn434.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn434.Width = 166;
            ultraGridColumn435.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn435.Header.VisiblePosition = 2;
            ultraGridColumn435.Hidden = true;
            ultraGridColumn436.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance338.TextHAlignAsString = "Right";
            ultraGridColumn436.CellAppearance = appearance338;
            ultraGridColumn436.Header.VisiblePosition = 3;
            ultraGridColumn436.Width = 83;
            ultraGridColumn437.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn437.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn437.Header.VisiblePosition = 4;
            ultraGridColumn437.Width = 164;
            ultraGridBand18.Columns.AddRange(new object[] {
            ultraGridColumn433,
            ultraGridColumn434,
            ultraGridColumn435,
            ultraGridColumn436,
            ultraGridColumn437});
            appearance339.FontData.BoldAsString = "True";
            appearance339.FontData.SizeInPoints = 10F;
            appearance339.TextHAlignAsString = "Left";
            ultraGridBand18.Header.Appearance = appearance339;
            ultraGridBand18.Header.Caption = "Medicamentos y Material Descartable";
            ultraGridBand18.HeaderVisible = true;
            ultraGridBand18.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.pacientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.pacientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand16);
            this.pacientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand17);
            this.pacientesUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand18);
            this.pacientesUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.pacientesUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.pacientesUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance76.BackColor = System.Drawing.SystemColors.Window;
            this.pacientesUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance76;
            appearance77.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance77.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance77.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pacientesUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance77;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.pacientesUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance79.BackColor = System.Drawing.Color.Transparent;
            this.pacientesUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance79;
            appearance80.BackColor = System.Drawing.SystemColors.Control;
            appearance80.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.pacientesUltraGrid.DisplayLayout.Override.CellAppearance = appearance80;
            this.pacientesUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance83.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance83.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance83.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance83.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.pacientesUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance83;
            this.pacientesUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance235.ForeColor = System.Drawing.Color.Red;
            this.pacientesUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance235;
            this.pacientesUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance255.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.pacientesUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance255;
            appearance256.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance256.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance256.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.pacientesUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance256;
            appearance257.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance257.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.pacientesUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance257;
            this.pacientesUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pacientesUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.pacientesUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.pacientesUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.pacientesUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientesUltraGrid.Location = new System.Drawing.Point(3, -2);
            this.pacientesUltraGrid.Name = "pacientesUltraGrid";
            this.pacientesUltraGrid.Size = new System.Drawing.Size(489, 378);
            this.pacientesUltraGrid.TabIndex = 0;
            this.pacientesUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.PacientesUltraGridInitializeRow);
            this.pacientesUltraGrid.InitializeTemplateAddRow += new Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventHandler(this.PacientesUltraGridInitializeTemplateAddRow);
            this.pacientesUltraGrid.AfterEnterEditMode += new System.EventHandler(this.PacientesUltraGridAfterEnterEditMode);
            this.pacientesUltraGrid.AfterRowUpdate += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.PacientesUltraGridAfterRowUpdate);
            this.pacientesUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.PacientesUltraGridCellChange);
            this.pacientesUltraGrid.CellListSelect += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.PacientesUltraGridCellListSelect);
            this.pacientesUltraGrid.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.PacientesUltraGridClickCellButton);
            this.pacientesUltraGrid.BeforeRowInsert += new Infragistics.Win.UltraWinGrid.BeforeRowInsertEventHandler(this.PacientesUltraGridBeforeRowInsert);
            this.pacientesUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pacientesUltraGrid_KeyDown);
            this.pacientesUltraGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PacientesUltraGridKeyPress);
            // 
            // ultraDropDownContratos
            // 
            this.ultraDropDownContratos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownContratos.DataSource = this.contratosBindingSource;
            appearance164.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance164.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance164.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownContratos.DisplayLayout.Appearance = appearance164;
            ultraGridBand19.ColHeadersVisible = false;
            ultraGridColumn438.Header.VisiblePosition = 0;
            ultraGridColumn438.Hidden = true;
            ultraGridColumn439.Header.VisiblePosition = 1;
            ultraGridColumn439.Hidden = true;
            ultraGridColumn440.Header.VisiblePosition = 2;
            ultraGridBand19.Columns.AddRange(new object[] {
            ultraGridColumn438,
            ultraGridColumn439,
            ultraGridColumn440});
            this.ultraDropDownContratos.DisplayLayout.BandsSerializer.Add(ultraGridBand19);
            this.ultraDropDownContratos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownContratos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownContratos.DisplayLayout.MaxBandDepth = 5;
            appearance165.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownContratos.DisplayLayout.Override.ActiveCellAppearance = appearance165;
            appearance166.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance166.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance166.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance166.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownContratos.DisplayLayout.Override.ActiveRowAppearance = appearance166;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownContratos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance167.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownContratos.DisplayLayout.Override.CardAreaAppearance = appearance167;
            appearance168.BackColor = System.Drawing.SystemColors.Control;
            appearance168.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance168.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownContratos.DisplayLayout.Override.CellAppearance = appearance168;
            this.ultraDropDownContratos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance169.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance169.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance169.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance169.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance169.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownContratos.DisplayLayout.Override.HeaderAppearance = appearance169;
            this.ultraDropDownContratos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance170.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownContratos.DisplayLayout.Override.RowSelectorAppearance = appearance170;
            this.ultraDropDownContratos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance171.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownContratos.DisplayLayout.Override.SelectedCellAppearance = appearance171;
            appearance172.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance172.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance172.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownContratos.DisplayLayout.Override.SelectedRowAppearance = appearance172;
            appearance173.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance173.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownContratos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance173;
            this.ultraDropDownContratos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownContratos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownContratos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownContratos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownContratos.DisplayMember = "Contrato";
            this.ultraDropDownContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownContratos.Location = new System.Drawing.Point(375, 199);
            this.ultraDropDownContratos.Name = "ultraDropDownContratos";
            this.ultraDropDownContratos.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownContratos.TabIndex = 39;
            this.ultraDropDownContratos.ValueMember = "idContrato";
            this.ultraDropDownContratos.Visible = false;
            this.ultraDropDownContratos.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownContratosBeforeDropDown);
            this.ultraDropDownContratos.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownContratosRowSelected);
            // 
            // contratosBindingSource
            // 
            this.contratosBindingSource.DataMember = "Contratos";
            this.contratosBindingSource.DataSource = this.dsContratosLista;
            // 
            // dsContratosLista
            // 
            this.dsContratosLista.DataSetName = "DsContratosLista";
            this.dsContratosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTomadores
            // 
            this.ultraDropDownTomadores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTomadores.DataSource = this.usuariosListaBindingSource;
            appearance245.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance245.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance245.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTomadores.DisplayLayout.Appearance = appearance245;
            ultraGridBand28.ColHeadersVisible = false;
            ultraGridColumn480.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn480.Header.VisiblePosition = 0;
            ultraGridColumn480.Hidden = true;
            ultraGridColumn481.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn481.Header.VisiblePosition = 1;
            ultraGridColumn481.Hidden = true;
            ultraGridColumn482.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn482.Header.VisiblePosition = 2;
            ultraGridColumn482.Hidden = true;
            ultraGridColumn483.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn483.Header.VisiblePosition = 3;
            ultraGridColumn484.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn484.Header.VisiblePosition = 4;
            ultraGridColumn484.Hidden = true;
            ultraGridColumn485.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn485.Header.VisiblePosition = 5;
            ultraGridBand28.Columns.AddRange(new object[] {
            ultraGridColumn480,
            ultraGridColumn481,
            ultraGridColumn482,
            ultraGridColumn483,
            ultraGridColumn484,
            ultraGridColumn485});
            this.ultraDropDownTomadores.DisplayLayout.BandsSerializer.Add(ultraGridBand28);
            this.ultraDropDownTomadores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTomadores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTomadores.DisplayLayout.MaxBandDepth = 5;
            appearance246.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTomadores.DisplayLayout.Override.ActiveCellAppearance = appearance246;
            appearance247.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance247.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance247.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance247.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTomadores.DisplayLayout.Override.ActiveRowAppearance = appearance247;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTomadores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance248.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTomadores.DisplayLayout.Override.CardAreaAppearance = appearance248;
            appearance249.BackColor = System.Drawing.SystemColors.Control;
            appearance249.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance249.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadores.DisplayLayout.Override.CellAppearance = appearance249;
            this.ultraDropDownTomadores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance250.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance250.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance250.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance250.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance250.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTomadores.DisplayLayout.Override.HeaderAppearance = appearance250;
            this.ultraDropDownTomadores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance251.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTomadores.DisplayLayout.Override.RowSelectorAppearance = appearance251;
            this.ultraDropDownTomadores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance252.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTomadores.DisplayLayout.Override.SelectedCellAppearance = appearance252;
            appearance253.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance253.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance253.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadores.DisplayLayout.Override.SelectedRowAppearance = appearance253;
            appearance254.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance254.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTomadores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance254;
            this.ultraDropDownTomadores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTomadores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTomadores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTomadores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTomadores.DisplayMember = "NombApel";
            this.ultraDropDownTomadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownTomadores.Location = new System.Drawing.Point(488, 263);
            this.ultraDropDownTomadores.Name = "ultraDropDownTomadores";
            this.ultraDropDownTomadores.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownTomadores.TabIndex = 49;
            this.ultraDropDownTomadores.ValueMember = "idUsuario";
            this.ultraDropDownTomadores.Visible = false;
            this.ultraDropDownTomadores.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.UltraDropDownTomadoresBeforeDropDown);
            // 
            // buttonAgregarPaciente
            // 
            this.buttonAgregarPaciente.Location = new System.Drawing.Point(500, 12);
            this.buttonAgregarPaciente.Name = "buttonAgregarPaciente";
            this.buttonAgregarPaciente.Size = new System.Drawing.Size(125, 23);
            this.buttonAgregarPaciente.TabIndex = 3;
            this.buttonAgregarPaciente.Text = "Agregar un Paciente";
            this.buttonAgregarPaciente.UseVisualStyleBackColor = true;
            this.buttonAgregarPaciente.Click += new System.EventHandler(this.ButtonAgregarPacienteClick);
            // 
            // buttonReferenciaColores
            // 
            this.buttonReferenciaColores.Location = new System.Drawing.Point(12, 12);
            this.buttonReferenciaColores.Name = "buttonReferenciaColores";
            this.buttonReferenciaColores.Size = new System.Drawing.Size(131, 23);
            this.buttonReferenciaColores.TabIndex = 5;
            this.buttonReferenciaColores.Text = "Referencia de Colores";
            this.buttonReferenciaColores.UseVisualStyleBackColor = true;
            this.buttonReferenciaColores.Click += new System.EventHandler(this.ButtonReferenciaColoresClick);
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
            // dsDireccionLugar1
            // 
            this.dsDireccionLugar1.DataSetName = "DsDireccionLugar";
            this.dsDireccionLugar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCabBuscarTelefono
            // 
            this.dsCabBuscarTelefono.DataSetName = "Dscab_BuscarTelefono";
            this.dsCabBuscarTelefono.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBuscarTelefono
            // 
            this.dsBuscarTelefono.DataSetName = "DsBuscarTelefono";
            this.dsBuscarTelefono.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSistemas1
            // 
            this.dsSistemas1.DataSetName = "DsSistemas";
            this.dsSistemas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMedicos
            // 
            this.dsMedicos.DataSetName = "DsEmpleadosLista";
            this.dsMedicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDestinosOtro
            // 
            this.dsDestinosOtro.DataSetName = "DsDestinos";
            this.dsDestinosOtro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonCerrarPrestacion
            // 
            this.buttonCerrarPrestacion.Location = new System.Drawing.Point(672, 12);
            this.buttonCerrarPrestacion.Name = "buttonCerrarPrestacion";
            this.buttonCerrarPrestacion.Size = new System.Drawing.Size(100, 23);
            this.buttonCerrarPrestacion.TabIndex = 6;
            this.buttonCerrarPrestacion.Text = "Cerrar Prestación";
            this.buttonCerrarPrestacion.UseVisualStyleBackColor = true;
            this.buttonCerrarPrestacion.Click += new System.EventHandler(this.ButtonCerrarPrestacionClick);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(167, 17);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(81, 14);
            this.ultraLabel1.TabIndex = 7;
            this.ultraLabel1.Text = "Ver agendadas";
            // 
            // ultraDataSourceVerAgendadas
            // 
            this.ultraDataSourceVerAgendadas.Band.Columns.AddRange(new object[] {
            ultraDataColumn4,
            ultraDataColumn5});
            this.ultraDataSourceVerAgendadas.Rows.AddRange(new object[] {
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("1")),
                        ((object)("Nombre")),
                        ((object)("Próxima hora"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("3")),
                        ((object)("Nombre")),
                        ((object)("Próximas 3 hhoras"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("6")),
                        ((object)("Nombre")),
                        ((object)("Próximas 6 horas"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("12")),
                        ((object)("Nombre")),
                        ((object)("Próximas 12 horas"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("24")),
                        ((object)("Nombre")),
                        ((object)("Próximas 24 horas"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("hoy")),
                        ((object)("Nombre")),
                        ((object)("Hoy"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("semana")),
                        ((object)("Nombre")),
                        ((object)("7 días"))}),
            new Infragistics.Win.UltraWinDataSource.UltraDataRow(new object[] {
                        ((object)("Id")),
                        ((object)("todas")),
                        ((object)("Nombre")),
                        ((object)("Todas"))})});
            // 
            // ultraComboVerAgendadas
            // 
            this.ultraComboVerAgendadas.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.ultraComboVerAgendadas.CalcManager = this.ultraCalcManager1;
            this.ultraComboVerAgendadas.DataSource = this.ultraDataSourceVerAgendadas;
            appearance294.BackColor = System.Drawing.SystemColors.Window;
            appearance294.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraComboVerAgendadas.DisplayLayout.Appearance = appearance294;
            ultraGridColumn530.Header.VisiblePosition = 0;
            ultraGridColumn530.Hidden = true;
            ultraGridColumn531.Header.VisiblePosition = 1;
            ultraGridBand37.Columns.AddRange(new object[] {
            ultraGridColumn530,
            ultraGridColumn531});
            this.ultraComboVerAgendadas.DisplayLayout.BandsSerializer.Add(ultraGridBand37);
            this.ultraComboVerAgendadas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraComboVerAgendadas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance295.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance295.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance295.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance295.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboVerAgendadas.DisplayLayout.GroupByBox.Appearance = appearance295;
            appearance297.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboVerAgendadas.DisplayLayout.GroupByBox.BandLabelAppearance = appearance297;
            this.ultraComboVerAgendadas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance296.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance296.BackColor2 = System.Drawing.SystemColors.Control;
            appearance296.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance296.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraComboVerAgendadas.DisplayLayout.GroupByBox.PromptAppearance = appearance296;
            this.ultraComboVerAgendadas.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraComboVerAgendadas.DisplayLayout.MaxRowScrollRegions = 1;
            appearance302.BackColor = System.Drawing.SystemColors.Window;
            appearance302.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraComboVerAgendadas.DisplayLayout.Override.ActiveCellAppearance = appearance302;
            appearance298.BackColor = System.Drawing.SystemColors.Highlight;
            appearance298.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraComboVerAgendadas.DisplayLayout.Override.ActiveRowAppearance = appearance298;
            this.ultraComboVerAgendadas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraComboVerAgendadas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance306.BackColor = System.Drawing.SystemColors.Window;
            this.ultraComboVerAgendadas.DisplayLayout.Override.CardAreaAppearance = appearance306;
            appearance301.BorderColor = System.Drawing.Color.Silver;
            appearance301.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraComboVerAgendadas.DisplayLayout.Override.CellAppearance = appearance301;
            this.ultraComboVerAgendadas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraComboVerAgendadas.DisplayLayout.Override.CellPadding = 0;
            appearance299.BackColor = System.Drawing.SystemColors.Control;
            appearance299.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance299.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance299.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance299.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraComboVerAgendadas.DisplayLayout.Override.GroupByRowAppearance = appearance299;
            appearance300.TextHAlignAsString = "Left";
            this.ultraComboVerAgendadas.DisplayLayout.Override.HeaderAppearance = appearance300;
            this.ultraComboVerAgendadas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraComboVerAgendadas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance304.BackColor = System.Drawing.SystemColors.Window;
            appearance304.BorderColor = System.Drawing.Color.Silver;
            this.ultraComboVerAgendadas.DisplayLayout.Override.RowAppearance = appearance304;
            this.ultraComboVerAgendadas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance305.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraComboVerAgendadas.DisplayLayout.Override.TemplateAddRowAppearance = appearance305;
            this.ultraComboVerAgendadas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraComboVerAgendadas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraComboVerAgendadas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraComboVerAgendadas.DisplayMember = "Nombre";
            this.ultraComboVerAgendadas.LimitToList = true;
            this.ultraComboVerAgendadas.Location = new System.Drawing.Point(254, 13);
            this.ultraComboVerAgendadas.Name = "ultraComboVerAgendadas";
            this.ultraComboVerAgendadas.Size = new System.Drawing.Size(151, 22);
            this.ultraComboVerAgendadas.TabIndex = 8;
            this.ultraComboVerAgendadas.ValueMember = "Id";
            // 
            // dsParametros
            // 
            this.dsParametros.DataSetName = "DsParametros";
            this.dsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametrosBindingSource
            // 
            this.parametrosBindingSource.DataMember = "Parametros";
            this.parametrosBindingSource.DataSource = this.dsParametros;
            // 
            // FormDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(996, 665);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ultraDropDownTiposDeDestino);
            this.Controls.Add(this.ultraDropDownCoberturas);
            this.Controls.Add(this.ultraDropDownRecursosActivos);
            this.Controls.Add(this.ultraDropDownPracticas);
            this.Controls.Add(this.ultraDropDownPrepagos);
            this.Controls.Add(this.ultraDropDownMotivos);
            this.Controls.Add(this.ultraDropDownMedicamentos);
            this.Controls.Add(this.ultraDropDownDiagnosticos);
            this.Controls.Add(this.ultraDropDownTomadores);
            this.Controls.Add(this.ultraDropDownMotivosCancelacion);
            this.Controls.Add(this.ultraDropDownLocalidad);
            this.Controls.Add(this.ultraDropDownCalles);
            this.Controls.Add(this.ultraDropDownLugares);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FormDespacho";
            this.Tag = "O";
            this.Text = "Prestaciones";
            this.Activated += new System.EventHandler(this.FormDespachoActivated);
            this.Load += new System.EventHandler(this.FormDespachoLoad);
            this.Controls.SetChildIndex(this.ultraDropDownLugares, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCalles, 0);
            this.Controls.SetChildIndex(this.ultraDropDownLocalidad, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotivosCancelacion, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTomadores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownDiagnosticos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMedicamentos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotivos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPrepagos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPracticas, 0);
            this.Controls.SetChildIndex(this.ultraDropDownRecursosActivos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCoberturas, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeDestino, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesResumenUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesResumenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestacionesResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestacionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDiagnosticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiagnosticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeLlamadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeLlamado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCoberturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoberturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownRecursosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecursosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidades1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLugares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosCancelacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeCancelacionPrestacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeCancelacionPrestacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDestinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destinosUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDestinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownDespachador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPacientesPrestacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContratosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarAfiliados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAfiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDireccionLugar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCabBuscarTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscarTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDestinosOtro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSourceVerAgendadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraComboVerAgendadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsPrestacionesResumen dsPrestacionesResumen;
        private System.Windows.Forms.BindingSource prestacionesResumenBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid prestacionesResumenUltraGrid;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private System.Windows.Forms.ImageList imageList1;
        private Infragistics.Win.UltraWinGrid.UltraGrid prestacionesUltraGrid;
        private WS.DsMotivosDeCancelacionPrestacion dsMotivosDeCancelacionPrestacion;
        private System.Windows.Forms.BindingSource motivosDeCancelacionPrestacionBindingSource;
        private WS.DsLugares dsLugares;
        private System.Windows.Forms.BindingSource lugaresBindingSource;
        private WS.DsDireccionLugar dsDireccionLugar1;
        private WS.DsCallesLista dsCallesLista;
        private System.Windows.Forms.BindingSource callesBindingSource;
        private WS.DsBarrios dsBarrios;
        private System.Windows.Forms.BindingSource barriosListaBindingSource;
        private WS.DsCoberturas dsCoberturas;
        private System.Windows.Forms.BindingSource coberturasBindingSource;
        private WS.DsPracticas dsPracticas;
        private System.Windows.Forms.BindingSource practicasBindingSource;
        private WS.DsPrepagos dsPrepagos;
        private System.Windows.Forms.BindingSource prepagosBindingSource;
        private WS.DsMotivosDeLlamado dsMotivosDeLlamado;
        private System.Windows.Forms.BindingSource motivosDeLlamadoBindingSource;
        private WS.DsDiagnosticos dsDiagnosticos;
        private System.Windows.Forms.BindingSource diagnosticosBindingSource;
        private WS.DsMedicamentos dsMedicamentos;
        private System.Windows.Forms.BindingSource medicamentosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMedicamentos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownDiagnosticos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotivos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPrepagos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPracticas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCoberturas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownRecursosActivos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBarrio;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCalles;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLocalidad;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLugares;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotivosCancelacion;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeDestino;
        private System.Windows.Forms.BindingSource tiposDeDestinoBindingSource;
        private WS.DsTiposDeDestino dsTiposDeDestino;
        private WS.DsBuscarAfiliados dsBuscarAfiliados;
        private System.Windows.Forms.BindingSource buscarAfiliadosBindingSource;
        private WS.DsCabBuscarTelefono dsCabBuscarTelefono;
        private WS.DsBuscarTelefono dsBuscarTelefono;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource contratosBindingSource;
        private WS.DsContratosLista dsContratosLista;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTomadores;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPacientes;
        private System.Windows.Forms.Button buttonAgregarPaciente;
        private System.Windows.Forms.Button buttonReferenciaColores;
        private System.Windows.Forms.BindingSource prestacionesBindingSource1;
        private WS.DsPrestacion dsPrestacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Infragistics.Win.UltraWinGrid.UltraGrid pacientesUltraGrid;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private WS.DsPacientesPrestacion dsPacientesPrestacion;
        private Infragistics.Win.UltraWinGrid.UltraGrid destinosUltraGrid;
        private System.Windows.Forms.BindingSource destinosBindingSource;
        private WS.DsDestinos dsDestinos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMedicos;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceMedicos;
        private WS.DsSistemas dsSistemas1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownDespachador;
        private System.Windows.Forms.BindingSource localidadesBindingSource;
        private WS.DsLocalidades dsLocalidades1;
        private WS.DsEmpleadosLista dsMedicos;
        private System.Windows.Forms.BindingSource recursosListaBindingSource;
        private WS.DsRecursosLista dsRecursosLista;
        private System.Windows.Forms.BindingSource usuariosListaBindingSource;
        private WS.DsUsuariosLista dsUsuariosLista;
        private System.Windows.Forms.Panel panelEstadoGeneral;
        private WS.DsDestinos dsDestinosOtro;
        private System.Windows.Forms.Button buttonCerrarPrestacion;
        private WS.DsTiposDeDocumento dsTiposDeDocumento;
        private System.Windows.Forms.BindingSource tiposDeDocumentoBindingSource;
        private UltraDropDown ultraDropDownTiposDeDocumento;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSourceVerAgendadas;
        private UltraCombo ultraComboVerAgendadas;
        private WS.DsParametros dsParametros;
        private System.Windows.Forms.BindingSource parametrosBindingSource;
        private UltraDropDown ultraDropDownContratos;
        private UltraDropDown ultraDropDownCodigos;
        private System.Windows.Forms.BindingSource codigosBindingSource;
        private WS.DsCodigos dsCodigos;
    }
}
