using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormBajasOCambios
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BajasOCambios", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBajaOCambio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Alta");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Baja", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRegistro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idVendedor", -1, "ultraDropDownVendedor");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTomadorDeBaja", -1, "ultraDropDownTomadoresDeBaja");
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeBaja", -1, "ultraDropDownMotivosDeBaja");
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsCambioDePlan");
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlanNuevo", -1, "ultraDropDownPlanes");
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador", -1, "ultraDropDownGrabador");
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_BajasOCambiosDetalles_BajasOCambios");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_BajasOCambiosDetalles_BajasOCambios", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBajaOCambioDetalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBajaOCambio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Elegido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado", -1, "ultraDropDownAfiliado", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlanDeBaja", -1, "ultraDropDownPlanes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeBaja", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Planes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PadronExterno");
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("AfiliadosDelGrupo", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCobranza");
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance245 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance246 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance247 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance248 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance249 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance250 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance251 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance252 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance253 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance254 = new Infragistics.Win.Appearance();
            this.dsBajasOCambios = new Administración.WS.DsBajasOCambios();
            this.bajasOCambiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bajasOCambiosUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDropDownVendedor = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.vendedoresListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVendedores = new Administración.WS.DsEmpleadosLista();
            this.ultraDropDownTomadoresDeBaja = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tomadoresDeBajabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTomadoresDeBaja = new Administración.WS.DsEmpleadosLista();
            this.ultraDropDownMotivosDeBaja = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDeBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeBaja = new Administración.WS.DsMotivosDeBaja();
            this.ultraDropDownPlanes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanes = new Administración.WS.DsPlanes();
            this.ultraDropDownAfiliado = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.afiliadosDelGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuariosLista1 = new Administración.WS.DsUsuariosLista();
            this.ultraDropDownGrabador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBajasOCambios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bajasOCambiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bajasOCambiosUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadoresDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomadoresDeBajabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTomadoresDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownAfiliado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosDelGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = true;
            this.buttonAceptar.Location = new System.Drawing.Point(476, 16);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(395, 16);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Size = new System.Drawing.Size(566, 50);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(395, 16);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // dsBajasOCambios
            // 
            this.dsBajasOCambios.DataSetName = "DsBajasOCambios";
            this.dsBajasOCambios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bajasOCambiosBindingSource
            // 
            this.bajasOCambiosBindingSource.DataMember = "BajasOCambios";
            this.bajasOCambiosBindingSource.DataSource = this.dsBajasOCambios;
            // 
            // bajasOCambiosUltraGrid
            // 
            this.bajasOCambiosUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bajasOCambiosUltraGrid.DataSource = this.bajasOCambiosBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.bajasOCambiosUltraGrid.DisplayLayout.Appearance = appearance1;
            this.bajasOCambiosUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 11;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance2.TextHAlignAsString = "Center";
            ultraGridColumn2.CellAppearance = appearance2;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn2.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(49, 0);
            ultraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(49, 0);
            ultraGridColumn2.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn2.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn2.Width = 56;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance3.TextHAlignAsString = "Center";
            ultraGridColumn3.CellAppearance = appearance3;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn3.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(49, 0);
            ultraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(49, 0);
            ultraGridColumn3.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn3.Width = 41;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance4.TextHAlignAsString = "Center";
            ultraGridColumn4.CellAppearance = appearance4;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(49, 0);
            ultraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(49, 0);
            ultraGridColumn4.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn4.Width = 71;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 34;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance5.TextHAlignAsString = "Center";
            ultraGridColumn6.CellAppearance = appearance5;
            ultraGridColumn6.Header.Caption = "Vendedor";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn6.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn6.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn6.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn6.Width = 88;
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance6.TextHAlignAsString = "Center";
            ultraGridColumn7.CellAppearance = appearance6;
            ultraGridColumn7.Header.Caption = "Tomador de la Baja";
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn7.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn7.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn7.Width = 112;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance7.TextHAlignAsString = "Center";
            ultraGridColumn8.CellAppearance = appearance7;
            ultraGridColumn8.Header.Caption = "Motivo de Baja";
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn8.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn8.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn8.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn8.Width = 99;
            ultraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn9.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn9.RowLayoutColumnInfo.OriginY = 3;
            ultraGridColumn9.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn9.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn9.Width = 106;
            ultraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance8.TextHAlignAsString = "Center";
            ultraGridColumn10.CellAppearance = appearance8;
            ultraGridColumn10.Header.Caption = "Es Cambio de Plan";
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn10.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn10.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn10.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn10.Width = 100;
            ultraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance9.TextHAlignAsString = "Center";
            ultraGridColumn11.CellAppearance = appearance9;
            ultraGridColumn11.Header.Caption = "Nuevo Plan";
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn11.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn11.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn11.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn11.Width = 81;
            ultraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance69.TextHAlignAsString = "Center";
            ultraGridColumn12.CellAppearance = appearance69;
            ultraGridColumn12.Header.Caption = "Grabador";
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn13.Header.VisiblePosition = 12;
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
            ultraGridColumn13});
            ultraGridBand1.MaxRows = 1;
            ultraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn14.Header.VisiblePosition = 0;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn14.Width = 58;
            ultraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn15.Header.VisiblePosition = 1;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn15.Width = 60;
            ultraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn16.Header.Caption = "Seleccionado";
            ultraGridColumn16.Header.VisiblePosition = 5;
            ultraGridColumn16.Width = 92;
            ultraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn17.Header.Caption = "Afiliado";
            ultraGridColumn17.Header.VisiblePosition = 2;
            ultraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn17.Width = 180;
            ultraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn18.Header.Caption = "Plan";
            ultraGridColumn18.Header.VisiblePosition = 3;
            ultraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn18.Width = 115;
            ultraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn19.Header.VisiblePosition = 4;
            ultraGridColumn19.Width = 120;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19});
            ultraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ultraGridBand2.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.bajasOCambiosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.bajasOCambiosUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.bajasOCambiosUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.bajasOCambiosUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.bajasOCambiosUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance10;
            appearance11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance11.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance11;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance12.BackColor = System.Drawing.Color.Transparent;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.Control;
            appearance13.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.CellAppearance = appearance13;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance14.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance14.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance14;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance15.ForeColor = System.Drawing.Color.Red;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance15;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance16;
            appearance17.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance17.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance17;
            appearance18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.bajasOCambiosUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance18;
            this.bajasOCambiosUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bajasOCambiosUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.bajasOCambiosUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.bajasOCambiosUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.bajasOCambiosUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bajasOCambiosUltraGrid.Location = new System.Drawing.Point(0, 1);
            this.bajasOCambiosUltraGrid.Name = "bajasOCambiosUltraGrid";
            this.bajasOCambiosUltraGrid.Size = new System.Drawing.Size(566, 325);
            this.bajasOCambiosUltraGrid.TabIndex = 2;
            this.bajasOCambiosUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.BajasOCambiosUltraGridInitializeRow);
            this.bajasOCambiosUltraGrid.AfterEnterEditMode += new System.EventHandler(this.bajasOCambiosUltraGrid_AfterEnterEditMode);
            this.bajasOCambiosUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.BajasOCambiosUltraGridCellChange);
            this.bajasOCambiosUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bajasOCambiosUltraGrid_KeyDown);
            // 
            // ultraDropDownVendedor
            // 
            this.ultraDropDownVendedor.DataSource = this.vendedoresListaBindingSource;
            appearance19.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance19.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownVendedor.DisplayLayout.Appearance = appearance19;
            this.ultraDropDownVendedor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn20.Header.VisiblePosition = 0;
            ultraGridColumn20.Hidden = true;
            ultraGridColumn20.Width = 31;
            ultraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn21.Header.VisiblePosition = 1;
            ultraGridColumn21.Hidden = true;
            ultraGridColumn21.Width = 20;
            ultraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn22.Header.VisiblePosition = 2;
            ultraGridColumn22.Hidden = true;
            ultraGridColumn22.Width = 42;
            ultraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn23.Header.VisiblePosition = 3;
            ultraGridColumn23.Hidden = true;
            ultraGridColumn23.Width = 42;
            ultraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn24.Header.VisiblePosition = 4;
            ultraGridColumn24.Width = 219;
            ultraGridColumn25.Header.VisiblePosition = 5;
            ultraGridColumn25.Hidden = true;
            ultraGridColumn25.Width = 39;
            ultraGridColumn26.Header.VisiblePosition = 6;
            ultraGridColumn26.Hidden = true;
            ultraGridColumn26.Width = 39;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26});
            this.ultraDropDownVendedor.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownVendedor.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownVendedor.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownVendedor.DisplayLayout.MaxBandDepth = 5;
            appearance20.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownVendedor.DisplayLayout.Override.ActiveCellAppearance = appearance20;
            appearance21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance21.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance21.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownVendedor.DisplayLayout.Override.ActiveRowAppearance = appearance21;
            this.ultraDropDownVendedor.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownVendedor.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownVendedor.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownVendedor.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownVendedor.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownVendedor.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownVendedor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance22.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownVendedor.DisplayLayout.Override.CardAreaAppearance = appearance22;
            appearance23.BackColor = System.Drawing.SystemColors.Control;
            appearance23.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownVendedor.DisplayLayout.Override.CellAppearance = appearance23;
            this.ultraDropDownVendedor.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance24.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance24.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance24.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownVendedor.DisplayLayout.Override.HeaderAppearance = appearance24;
            this.ultraDropDownVendedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance25.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownVendedor.DisplayLayout.Override.RowSelectorAppearance = appearance25;
            this.ultraDropDownVendedor.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownVendedor.DisplayLayout.Override.SelectedCellAppearance = appearance26;
            appearance27.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance27.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownVendedor.DisplayLayout.Override.SelectedRowAppearance = appearance27;
            appearance28.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance28.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownVendedor.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance28;
            this.ultraDropDownVendedor.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownVendedor.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownVendedor.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownVendedor.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownVendedor.DisplayMember = "ApelNomb";
            this.ultraDropDownVendedor.Location = new System.Drawing.Point(12, 109);
            this.ultraDropDownVendedor.Name = "ultraDropDownVendedor";
            this.ultraDropDownVendedor.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownVendedor.TabIndex = 15;
            this.ultraDropDownVendedor.ValueMember = "idEmpleado";
            this.ultraDropDownVendedor.Visible = false;
            this.ultraDropDownVendedor.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownVendedorFilterRow);
            // 
            // vendedoresListaBindingSource
            // 
            this.vendedoresListaBindingSource.DataMember = "EmpleadosLista";
            this.vendedoresListaBindingSource.DataSource = this.dsVendedores;
            // 
            // dsVendedores
            // 
            this.dsVendedores.DataSetName = "DsEmpleadosLista";
            this.dsVendedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTomadoresDeBaja
            // 
            this.ultraDropDownTomadoresDeBaja.DataSource = this.tomadoresDeBajabindingSource;
            appearance29.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance29.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Appearance = appearance29;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn27.Header.VisiblePosition = 0;
            ultraGridColumn27.Hidden = true;
            ultraGridColumn27.Width = 31;
            ultraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn28.Header.VisiblePosition = 1;
            ultraGridColumn28.Hidden = true;
            ultraGridColumn28.Width = 20;
            ultraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn29.Header.VisiblePosition = 2;
            ultraGridColumn29.Hidden = true;
            ultraGridColumn29.Width = 42;
            ultraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn30.Header.VisiblePosition = 3;
            ultraGridColumn30.Hidden = true;
            ultraGridColumn30.Width = 42;
            ultraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn31.Header.VisiblePosition = 4;
            ultraGridColumn31.Width = 219;
            ultraGridColumn32.Header.VisiblePosition = 5;
            ultraGridColumn32.Hidden = true;
            ultraGridColumn32.Width = 39;
            ultraGridColumn33.Header.VisiblePosition = 6;
            ultraGridColumn33.Hidden = true;
            ultraGridColumn33.Width = 39;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33});
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.MaxBandDepth = 5;
            appearance30.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.ActiveCellAppearance = appearance30;
            appearance31.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance31.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance31.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.ActiveRowAppearance = appearance31;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance32.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.CardAreaAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.Control;
            appearance33.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.CellAppearance = appearance33;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance34.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance34.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance34.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.HeaderAppearance = appearance34;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance35.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.RowSelectorAppearance = appearance35;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.SelectedCellAppearance = appearance36;
            appearance37.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance37.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.SelectedRowAppearance = appearance37;
            appearance38.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance38;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTomadoresDeBaja.DisplayMember = "ApelNomb";
            this.ultraDropDownTomadoresDeBaja.Location = new System.Drawing.Point(12, 147);
            this.ultraDropDownTomadoresDeBaja.Name = "ultraDropDownTomadoresDeBaja";
            this.ultraDropDownTomadoresDeBaja.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownTomadoresDeBaja.TabIndex = 16;
            this.ultraDropDownTomadoresDeBaja.ValueMember = "idEmpleado";
            this.ultraDropDownTomadoresDeBaja.Visible = false;
            this.ultraDropDownTomadoresDeBaja.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownTomadoresDeBajaFilterRow);
            // 
            // tomadoresDeBajabindingSource
            // 
            this.tomadoresDeBajabindingSource.DataMember = "EmpleadosLista";
            this.tomadoresDeBajabindingSource.DataSource = this.dsTomadoresDeBaja;
            // 
            // dsTomadoresDeBaja
            // 
            this.dsTomadoresDeBaja.DataSetName = "DsEmpleadosLista";
            this.dsTomadoresDeBaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMotivosDeBaja
            // 
            this.ultraDropDownMotivosDeBaja.DataSource = this.motivosDeBajaBindingSource;
            appearance39.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Appearance = appearance39;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand5.ColHeadersVisible = false;
            ultraGridColumn34.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn34.Header.VisiblePosition = 0;
            ultraGridColumn34.Hidden = true;
            ultraGridColumn34.Width = 108;
            ultraGridColumn35.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn35.Header.VisiblePosition = 1;
            ultraGridColumn35.Width = 219;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn34,
            ultraGridColumn35});
            this.ultraDropDownMotivosDeBaja.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.ultraDropDownMotivosDeBaja.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.MaxBandDepth = 5;
            appearance40.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.ActiveCellAppearance = appearance40;
            appearance41.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance41.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance41.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.ActiveRowAppearance = appearance41;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance42.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.CardAreaAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.Control;
            appearance43.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.CellAppearance = appearance43;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance44.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance44.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance44.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance44.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.HeaderAppearance = appearance44;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance45.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.RowSelectorAppearance = appearance45;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.SelectedCellAppearance = appearance46;
            appearance47.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance47.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.SelectedRowAppearance = appearance47;
            appearance48.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance48.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance48;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotivosDeBaja.DisplayMember = "Nombre";
            this.ultraDropDownMotivosDeBaja.Location = new System.Drawing.Point(12, 185);
            this.ultraDropDownMotivosDeBaja.Name = "ultraDropDownMotivosDeBaja";
            this.ultraDropDownMotivosDeBaja.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownMotivosDeBaja.TabIndex = 17;
            this.ultraDropDownMotivosDeBaja.ValueMember = "idMotivoDeBaja";
            this.ultraDropDownMotivosDeBaja.Visible = false;
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
            // ultraDropDownPlanes
            // 
            this.ultraDropDownPlanes.DataSource = this.planesBindingSource;
            appearance49.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPlanes.DisplayLayout.Appearance = appearance49;
            this.ultraDropDownPlanes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand6.ColHeadersVisible = false;
            ultraGridColumn36.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn36.Header.VisiblePosition = 0;
            ultraGridColumn36.Hidden = true;
            ultraGridColumn36.Width = 46;
            ultraGridColumn37.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn37.Header.VisiblePosition = 1;
            ultraGridColumn37.Width = 219;
            ultraGridColumn38.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn38.Header.VisiblePosition = 2;
            ultraGridColumn38.Hidden = true;
            ultraGridColumn38.Width = 38;
            ultraGridColumn39.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn39.Header.VisiblePosition = 3;
            ultraGridColumn39.Hidden = true;
            ultraGridColumn39.Width = 55;
            ultraGridColumn40.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn40.Header.VisiblePosition = 4;
            ultraGridColumn40.Hidden = true;
            ultraGridColumn40.Width = 65;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40});
            this.ultraDropDownPlanes.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.ultraDropDownPlanes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPlanes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPlanes.DisplayLayout.MaxBandDepth = 5;
            appearance50.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveCellAppearance = appearance50;
            appearance51.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance51.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance51.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveRowAppearance = appearance51;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance52.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.CardAreaAppearance = appearance52;
            appearance53.BackColor = System.Drawing.SystemColors.Control;
            appearance53.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.CellAppearance = appearance53;
            this.ultraDropDownPlanes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance54.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance54.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance54.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance54.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderAppearance = appearance54;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance55.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSelectorAppearance = appearance55;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedCellAppearance = appearance56;
            appearance57.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance57.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedRowAppearance = appearance57;
            appearance58.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance58.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPlanes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance58;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPlanes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPlanes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPlanes.DisplayMember = "Nombre";
            this.ultraDropDownPlanes.Location = new System.Drawing.Point(12, 223);
            this.ultraDropDownPlanes.Name = "ultraDropDownPlanes";
            this.ultraDropDownPlanes.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownPlanes.TabIndex = 18;
            this.ultraDropDownPlanes.ValueMember = "idPlan";
            this.ultraDropDownPlanes.Visible = false;
            this.ultraDropDownPlanes.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownPlanesFilterRow);
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "Planes";
            this.planesBindingSource.DataSource = this.dsPlanes;
            // 
            // dsPlanes
            // 
            this.dsPlanes.DataSetName = "DsPlanes";
            this.dsPlanes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownAfiliado
            // 
            this.ultraDropDownAfiliado.DataSource = this.afiliadosDelGrupoBindingSource;
            appearance59.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance59.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownAfiliado.DisplayLayout.Appearance = appearance59;
            this.ultraDropDownAfiliado.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand7.ColHeadersVisible = false;
            ultraGridColumn41.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn41.Header.VisiblePosition = 0;
            ultraGridColumn41.Hidden = true;
            ultraGridColumn41.Width = 84;
            ultraGridColumn42.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn42.Header.VisiblePosition = 1;
            ultraGridColumn42.Width = 219;
            ultraGridColumn43.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn43.Header.VisiblePosition = 2;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn43.Width = 74;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43});
            this.ultraDropDownAfiliado.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.ultraDropDownAfiliado.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownAfiliado.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownAfiliado.DisplayLayout.MaxBandDepth = 5;
            appearance60.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownAfiliado.DisplayLayout.Override.ActiveCellAppearance = appearance60;
            appearance61.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance61.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance61.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownAfiliado.DisplayLayout.Override.ActiveRowAppearance = appearance61;
            this.ultraDropDownAfiliado.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownAfiliado.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownAfiliado.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownAfiliado.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownAfiliado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownAfiliado.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownAfiliado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance62.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownAfiliado.DisplayLayout.Override.CardAreaAppearance = appearance62;
            appearance63.BackColor = System.Drawing.SystemColors.Control;
            appearance63.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownAfiliado.DisplayLayout.Override.CellAppearance = appearance63;
            this.ultraDropDownAfiliado.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance64.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance64.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance64.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance64.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownAfiliado.DisplayLayout.Override.HeaderAppearance = appearance64;
            this.ultraDropDownAfiliado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance65.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownAfiliado.DisplayLayout.Override.RowSelectorAppearance = appearance65;
            this.ultraDropDownAfiliado.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownAfiliado.DisplayLayout.Override.SelectedCellAppearance = appearance66;
            appearance67.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance67.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownAfiliado.DisplayLayout.Override.SelectedRowAppearance = appearance67;
            appearance68.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance68.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownAfiliado.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance68;
            this.ultraDropDownAfiliado.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownAfiliado.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownAfiliado.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownAfiliado.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownAfiliado.DisplayMember = "ApelNomb";
            this.ultraDropDownAfiliado.Location = new System.Drawing.Point(256, 109);
            this.ultraDropDownAfiliado.Name = "ultraDropDownAfiliado";
            this.ultraDropDownAfiliado.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownAfiliado.TabIndex = 19;
            this.ultraDropDownAfiliado.ValueMember = "idAfiliado";
            this.ultraDropDownAfiliado.Visible = false;
            // 
            // afiliadosDelGrupoBindingSource
            // 
            this.afiliadosDelGrupoBindingSource.DataMember = "AfiliadosDelGrupo";
            this.afiliadosDelGrupoBindingSource.DataSource = this.dsBajasOCambios;
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
            // ultraDropDownGrabador
            // 
            this.ultraDropDownGrabador.DataSource = this.usuariosListaBindingSource;
            appearance245.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance245.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance245.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownGrabador.DisplayLayout.Appearance = appearance245;
            ultraGridBand8.ColHeadersVisible = false;
            ultraGridColumn44.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn44.Header.VisiblePosition = 0;
            ultraGridColumn44.Hidden = true;
            ultraGridColumn45.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn45.Header.VisiblePosition = 1;
            ultraGridColumn45.Hidden = true;
            ultraGridColumn46.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn46.Header.VisiblePosition = 2;
            ultraGridColumn46.Hidden = true;
            ultraGridColumn47.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn47.Header.VisiblePosition = 3;
            ultraGridColumn48.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn48.Header.VisiblePosition = 4;
            ultraGridColumn48.Hidden = true;
            ultraGridColumn49.Header.VisiblePosition = 5;
            ultraGridColumn49.Hidden = true;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49});
            this.ultraDropDownGrabador.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.ultraDropDownGrabador.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownGrabador.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownGrabador.DisplayLayout.MaxBandDepth = 5;
            appearance246.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveCellAppearance = appearance246;
            appearance247.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance247.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance247.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance247.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveRowAppearance = appearance247;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance248.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.CardAreaAppearance = appearance248;
            appearance249.BackColor = System.Drawing.SystemColors.Control;
            appearance249.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance249.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.CellAppearance = appearance249;
            this.ultraDropDownGrabador.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance250.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance250.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance250.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance250.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance250.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderAppearance = appearance250;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance251.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSelectorAppearance = appearance251;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance252.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedCellAppearance = appearance252;
            appearance253.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance253.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance253.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedRowAppearance = appearance253;
            appearance254.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance254.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownGrabador.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance254;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownGrabador.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownGrabador.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownGrabador.DisplayMember = "NombApel";
            this.ultraDropDownGrabador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownGrabador.Location = new System.Drawing.Point(256, 147);
            this.ultraDropDownGrabador.Name = "ultraDropDownGrabador";
            this.ultraDropDownGrabador.Size = new System.Drawing.Size(238, 32);
            this.ultraDropDownGrabador.TabIndex = 55;
            this.ultraDropDownGrabador.ValueMember = "idUsuario";
            this.ultraDropDownGrabador.Visible = false;
            // 
            // FormBajasOCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(565, 364);
            this.Controls.Add(this.bajasOCambiosUltraGrid);
            this.Controls.Add(this.ultraDropDownGrabador);
            this.Controls.Add(this.ultraDropDownAfiliado);
            this.Controls.Add(this.ultraDropDownPlanes);
            this.Controls.Add(this.ultraDropDownMotivosDeBaja);
            this.Controls.Add(this.ultraDropDownTomadoresDeBaja);
            this.Controls.Add(this.ultraDropDownVendedor);
            this.Name = "FormBajasOCambios";
            this.Text = "Bajas o Cambios de Plan";
            this.Activated += new System.EventHandler(this.FormBajasOCambiosActivated);
            this.Load += new System.EventHandler(this.FormBajasOCambiosLoad);
            this.Controls.SetChildIndex(this.ultraDropDownVendedor, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTomadoresDeBaja, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotivosDeBaja, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPlanes, 0);
            this.Controls.SetChildIndex(this.ultraDropDownAfiliado, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownGrabador, 0);
            this.Controls.SetChildIndex(this.bajasOCambiosUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsBajasOCambios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bajasOCambiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bajasOCambiosUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadoresDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomadoresDeBajabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTomadoresDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownAfiliado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosDelGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WS.DsBajasOCambios dsBajasOCambios;
        private System.Windows.Forms.BindingSource bajasOCambiosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid bajasOCambiosUltraGrid;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownVendedor;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTomadoresDeBaja;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotivosDeBaja;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPlanes;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownAfiliado;
        private System.Windows.Forms.BindingSource vendedoresListaBindingSource;
        private WS.DsEmpleadosLista dsVendedores;
        private System.Windows.Forms.BindingSource tomadoresDeBajabindingSource;
        private WS.DsEmpleadosLista dsTomadoresDeBaja;
        private System.Windows.Forms.BindingSource motivosDeBajaBindingSource;
        private WS.DsMotivosDeBaja dsMotivosDeBaja;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private WS.DsPlanes dsPlanes;
        private System.Windows.Forms.BindingSource afiliadosDelGrupoBindingSource;
        private System.Windows.Forms.BindingSource usuariosListaBindingSource;
        private Administración.WS.DsUsuariosLista dsUsuariosLista1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownGrabador;
    }
}
