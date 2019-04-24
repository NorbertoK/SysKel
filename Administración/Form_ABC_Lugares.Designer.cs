using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    partial class FormABCLugares
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Lugares", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocaldad", -1, "ultraDropDownLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Lugares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Lugares");
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Lugares", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Direcciones1");
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Direcciones1", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Lugares", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn87 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn88 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn89 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Cotactos");
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Cotactos", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("LocalidadesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("LocalidadesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            this.lugaresUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.lugaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLugares = new Administración.WS.DsLugares();
            this.bindingSourceCalle = new System.Windows.Forms.BindingSource(this.components);
            this.dsCallesLista1 = new Administración.WS.DsCallesLista();
            this.ultraDropDownCalle = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ultraDropDownBarrios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.barriosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarrios = new Administración.WS.DsBarrios();
            this.ultraDropDownLocalidad = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.localidadesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalidadesLista = new Administración.WS.DsLocalidadesLista();
            this.ultraDropDownLocalidades = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(676, 20);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(568, 20);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-107, 487);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(796, 62);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(460, 20);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            // 
            // lugaresUltraGrid
            // 
            this.lugaresUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lugaresUltraGrid.CalcManager = this.ultraCalcManager1;
            this.lugaresUltraGrid.DataSource = this.lugaresBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.lugaresUltraGrid.DisplayLayout.Appearance = appearance1;
            this.lugaresUltraGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn61.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn61.Header.VisiblePosition = 0;
            ultraGridColumn61.Hidden = true;
            ultraGridColumn61.Width = 60;
            ultraGridColumn62.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn62.Header.VisiblePosition = 1;
            ultraGridColumn62.Width = 272;
            ultraGridColumn63.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn63.Header.VisiblePosition = 2;
            ultraGridColumn63.Width = 255;
            ultraGridColumn64.Header.Caption = "Localdad";
            ultraGridColumn64.Header.VisiblePosition = 3;
            ultraGridColumn64.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn64.Width = 121;
            ultraGridColumn65.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn65.Header.VisiblePosition = 5;
            ultraGridColumn66.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn66.Header.VisiblePosition = 4;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66});
            appearance56.FontData.BoldAsString = "True";
            appearance56.FontData.SizeInPoints = 11F;
            appearance56.TextHAlignAsString = "Left";
            ultraGridBand5.Header.Appearance = appearance56;
            ultraGridBand5.HeaderVisible = true;
            ultraGridColumn67.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn67.Header.VisiblePosition = 0;
            ultraGridColumn67.Hidden = true;
            ultraGridColumn67.Width = 8;
            ultraGridColumn68.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn68.Header.Caption = "Calle";
            ultraGridColumn68.Header.VisiblePosition = 1;
            ultraGridColumn68.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn68.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn68.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(323, 0);
            ultraGridColumn68.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(38, 0);
            ultraGridColumn68.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn68.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn68.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn68.Width = 12;
            ultraGridColumn69.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn69.Header.Caption = "Número";
            ultraGridColumn69.Header.VisiblePosition = 2;
            ultraGridColumn69.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn69.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn69.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(121, 0);
            ultraGridColumn69.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn69.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn69.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn69.Width = 13;
            ultraGridColumn70.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn70.Header.VisiblePosition = 3;
            ultraGridColumn70.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn70.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn70.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(98, 0);
            ultraGridColumn70.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(34, 0);
            ultraGridColumn70.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn70.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn70.Width = 47;
            ultraGridColumn71.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn71.Header.Caption = "Depto.";
            ultraGridColumn71.Header.VisiblePosition = 4;
            ultraGridColumn71.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn71.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn71.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(80, 0);
            ultraGridColumn71.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(80, 0);
            ultraGridColumn71.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn71.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn71.Width = 48;
            ultraGridColumn72.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn72.Header.Caption = "entre";
            ultraGridColumn72.Header.VisiblePosition = 5;
            ultraGridColumn72.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn72.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn72.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(323, 0);
            ultraGridColumn72.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(38, 0);
            ultraGridColumn72.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn72.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn72.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn72.Width = 40;
            ultraGridColumn73.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn73.Header.Caption = "y";
            ultraGridColumn73.Header.VisiblePosition = 6;
            ultraGridColumn73.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn73.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn73.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(323, 0);
            ultraGridColumn73.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(18, 0);
            ultraGridColumn73.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn73.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn73.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn73.Width = 38;
            ultraGridColumn74.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn74.Header.Caption = "Zona";
            ultraGridColumn74.Header.VisiblePosition = 7;
            ultraGridColumn74.Hidden = true;
            ultraGridColumn74.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
            ultraGridColumn74.Width = 12;
            ultraGridColumn75.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn75.Header.VisiblePosition = 8;
            ultraGridColumn75.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn75.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn75.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(443, 36);
            ultraGridColumn75.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(443, 0);
            ultraGridColumn75.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn75.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn75.Width = 43;
            ultraGridColumn76.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn76.Header.VisiblePosition = 10;
            ultraGridColumn76.Hidden = true;
            ultraGridColumn76.Width = 17;
            ultraGridColumn77.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn77.Header.Caption = "Barrio";
            ultraGridColumn77.Header.VisiblePosition = 11;
            ultraGridColumn77.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn77.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn77.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn77.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn77.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn78.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn78.Header.Caption = "Localidad";
            ultraGridColumn78.Header.VisiblePosition = 9;
            ultraGridColumn78.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn78.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn78.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(281, 18);
            ultraGridColumn78.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(281, 0);
            ultraGridColumn78.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn78.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn79.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn79.Header.VisiblePosition = 12;
            ultraGridBand6.Columns.AddRange(new object[] {
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
            ultraGridColumn79});
            appearance57.FontData.BoldAsString = "True";
            appearance57.FontData.SizeInPoints = 11F;
            appearance57.TextHAlignAsString = "Left";
            ultraGridBand6.Header.Appearance = appearance57;
            ultraGridBand6.Header.Caption = "Dirección";
            ultraGridBand6.HeaderVisible = true;
            ultraGridBand6.MaxRows = 1;
            ultraGridBand6.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand7.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand7.CardSettings.ShowCaption = false;
            ultraGridBand7.CardView = true;
            ultraGridColumn80.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn80.Header.VisiblePosition = 0;
            ultraGridColumn80.Hidden = true;
            ultraGridColumn80.Width = 100;
            ultraGridColumn81.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn81.Header.VisiblePosition = 1;
            ultraGridColumn81.Width = 100;
            ultraGridColumn82.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn82.Header.VisiblePosition = 2;
            ultraGridColumn82.Hidden = true;
            ultraGridColumn82.Width = 36;
            ultraGridColumn83.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn83.Header.VisiblePosition = 3;
            ultraGridColumn83.Hidden = true;
            ultraGridColumn83.Width = 37;
            ultraGridColumn84.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn84.Header.VisiblePosition = 4;
            ultraGridColumn84.Hidden = true;
            ultraGridColumn84.Width = 32;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn80,
            ultraGridColumn81,
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn84});
            appearance58.FontData.BoldAsString = "True";
            appearance58.FontData.SizeInPoints = 11F;
            ultraGridBand7.Header.Appearance = appearance58;
            ultraGridBand7.Header.Caption = "Tel. Lugar";
            ultraGridBand7.HeaderVisible = true;
            ultraGridBand7.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand7.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn85.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn85.Header.VisiblePosition = 0;
            ultraGridColumn85.Hidden = true;
            ultraGridColumn85.Width = 36;
            ultraGridColumn86.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn86.Header.VisiblePosition = 1;
            ultraGridColumn86.Width = 319;
            ultraGridColumn87.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn87.Header.VisiblePosition = 2;
            ultraGridColumn87.Width = 310;
            ultraGridColumn88.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn88.Header.VisiblePosition = 3;
            ultraGridColumn88.Hidden = true;
            ultraGridColumn88.Width = 38;
            ultraGridColumn89.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn89.Header.VisiblePosition = 4;
            ultraGridColumn89.Hidden = true;
            ultraGridColumn89.Width = 43;
            ultraGridColumn90.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn90.Header.VisiblePosition = 5;
            ultraGridColumn90.Hidden = true;
            ultraGridColumn90.Width = 54;
            ultraGridColumn91.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn91.Header.VisiblePosition = 6;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn85,
            ultraGridColumn86,
            ultraGridColumn87,
            ultraGridColumn88,
            ultraGridColumn89,
            ultraGridColumn90,
            ultraGridColumn91});
            appearance59.FontData.SizeInPoints = 11F;
            appearance59.TextHAlignAsString = "Left";
            ultraGridBand8.Header.Appearance = appearance59;
            ultraGridBand8.Header.Caption = "Referentes";
            ultraGridBand8.HeaderVisible = true;
            ultraGridBand8.MaxRows = 7;
            ultraGridBand9.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand9.CardSettings.ShowCaption = false;
            ultraGridBand9.CardView = true;
            ultraGridColumn92.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn92.Header.VisiblePosition = 0;
            ultraGridColumn92.Hidden = true;
            ultraGridColumn92.Width = 100;
            ultraGridColumn93.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn93.Header.VisiblePosition = 1;
            ultraGridColumn93.Width = 100;
            ultraGridColumn94.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn94.Header.VisiblePosition = 2;
            ultraGridColumn94.Hidden = true;
            ultraGridColumn94.Width = 36;
            ultraGridColumn95.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn95.Header.VisiblePosition = 3;
            ultraGridColumn95.Hidden = true;
            ultraGridColumn95.Width = 37;
            ultraGridColumn96.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn96.Header.VisiblePosition = 4;
            ultraGridColumn96.Hidden = true;
            ultraGridColumn96.Width = 32;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn92,
            ultraGridColumn93,
            ultraGridColumn94,
            ultraGridColumn95,
            ultraGridColumn96});
            appearance60.FontData.BoldAsString = "True";
            appearance60.FontData.SizeInPoints = 11F;
            ultraGridBand9.Header.Appearance = appearance60;
            ultraGridBand9.Header.Caption = "Tel. Contacto";
            ultraGridBand9.HeaderVisible = true;
            ultraGridBand9.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand9.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.lugaresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.lugaresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.lugaresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.lugaresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.lugaresUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.lugaresUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.lugaresUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.lugaresUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.lugaresUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance7;
            appearance8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance8.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lugaresUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance8;
            this.lugaresUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.lugaresUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.lugaresUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.lugaresUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.lugaresUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.lugaresUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.lugaresUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance9.BackColor = System.Drawing.Color.Transparent;
            this.lugaresUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.lugaresUltraGrid.DisplayLayout.Override.CellAppearance = appearance10;
            this.lugaresUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance11.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.lugaresUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.lugaresUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance12.ForeColor = System.Drawing.Color.Red;
            this.lugaresUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance12;
            this.lugaresUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.lugaresUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance13;
            appearance14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance14.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.lugaresUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.lugaresUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance15;
            this.lugaresUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lugaresUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.lugaresUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.lugaresUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.lugaresUltraGrid.Location = new System.Drawing.Point(1, 1);
            this.lugaresUltraGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lugaresUltraGrid.Name = "lugaresUltraGrid";
            this.lugaresUltraGrid.Size = new System.Drawing.Size(688, 498);
            this.lugaresUltraGrid.TabIndex = 2;
            this.lugaresUltraGrid.AfterEnterEditMode += new System.EventHandler(this.LugaresUltraGridAfterEnterEditMode);
            this.lugaresUltraGrid.AfterRowActivate += new System.EventHandler(this.LugaresUltraGridAfterRowActivate);
            this.lugaresUltraGrid.AfterRowsDeleted += new System.EventHandler(this.LugaresUltraGridAfterRowsDeleted);
            this.lugaresUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.LugaresUltraGridCellChange);
            this.lugaresUltraGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.LugaresUltraGridBeforeRowsDeleted);
            this.lugaresUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lugaresUltraGrid_KeyDown);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
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
            // bindingSourceCalle
            // 
            this.bindingSourceCalle.DataMember = "Calles";
            this.bindingSourceCalle.DataSource = this.dsCallesLista1;
            // 
            // dsCallesLista1
            // 
            this.dsCallesLista1.DataSetName = "DsCallesLista";
            this.dsCallesLista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownCalle
            // 
            this.ultraDropDownCalle.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCalle.DataSource = this.bindingSourceCalle;
            appearance46.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalle.DisplayLayout.Appearance = appearance46;
            this.ultraDropDownCalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand4.ColHeadersVisible = false;
            ultraGridColumn57.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn57.Header.VisiblePosition = 0;
            ultraGridColumn57.Hidden = true;
            ultraGridColumn57.Width = 37;
            ultraGridColumn58.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn58.Header.VisiblePosition = 1;
            ultraGridColumn58.Hidden = true;
            ultraGridColumn58.Width = 115;
            ultraGridColumn59.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn59.Header.VisiblePosition = 2;
            ultraGridColumn59.Hidden = true;
            ultraGridColumn59.Width = 56;
            ultraGridColumn60.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn60.Header.VisiblePosition = 3;
            ultraGridColumn60.Width = 219;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60});
            ultraGridBand4.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownCalle.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ultraDropDownCalle.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownCalle.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownCalle.DisplayLayout.MaxBandDepth = 5;
            appearance47.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownCalle.DisplayLayout.Override.ActiveCellAppearance = appearance47;
            appearance48.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance48.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance48.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownCalle.DisplayLayout.Override.ActiveRowAppearance = appearance48;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownCalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance49.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownCalle.DisplayLayout.Override.CardAreaAppearance = appearance49;
            appearance50.BackColor = System.Drawing.SystemColors.Control;
            appearance50.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalle.DisplayLayout.Override.CellAppearance = appearance50;
            this.ultraDropDownCalle.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance51.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance51.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance51.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance51.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownCalle.DisplayLayout.Override.HeaderAppearance = appearance51;
            this.ultraDropDownCalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance52.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownCalle.DisplayLayout.Override.RowSelectorAppearance = appearance52;
            this.ultraDropDownCalle.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownCalle.DisplayLayout.Override.SelectedCellAppearance = appearance53;
            appearance54.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance54.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownCalle.DisplayLayout.Override.SelectedRowAppearance = appearance54;
            appearance55.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance55.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownCalle.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance55;
            this.ultraDropDownCalle.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownCalle.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownCalle.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownCalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownCalle.DisplayMember = "Nombre";
            this.ultraDropDownCalle.Location = new System.Drawing.Point(352, 362);
            this.ultraDropDownCalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownCalle.Name = "ultraDropDownCalle";
            this.ultraDropDownCalle.Size = new System.Drawing.Size(317, 41);
            this.ultraDropDownCalle.TabIndex = 11;
            this.ultraDropDownCalle.ValueMember = "idCalle";
            this.ultraDropDownCalle.Visible = false;
            this.ultraDropDownCalle.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCalleFilterRow);
            // 
            // ultraDropDownBarrios
            // 
            this.ultraDropDownBarrios.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownBarrios.DataSource = this.barriosListaBindingSource;
            appearance36.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrios.DisplayLayout.Appearance = appearance36;
            this.ultraDropDownBarrios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand3.ColHeadersVisible = false;
            ultraGridColumn54.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn54.Header.VisiblePosition = 0;
            ultraGridColumn54.Hidden = true;
            ultraGridColumn55.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn55.Header.VisiblePosition = 1;
            ultraGridColumn56.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn56.Header.VisiblePosition = 2;
            ultraGridColumn56.Hidden = true;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56});
            ultraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraDropDownBarrios.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraDropDownBarrios.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownBarrios.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownBarrios.DisplayLayout.MaxBandDepth = 5;
            appearance37.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveCellAppearance = appearance37;
            appearance38.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance38.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance38.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownBarrios.DisplayLayout.Override.ActiveRowAppearance = appearance38;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownBarrios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance39.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.CardAreaAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.Control;
            appearance40.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.CellAppearance = appearance40;
            this.ultraDropDownBarrios.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance41.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance41.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance41.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance41.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderAppearance = appearance41;
            this.ultraDropDownBarrios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance42.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSelectorAppearance = appearance42;
            this.ultraDropDownBarrios.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedCellAppearance = appearance43;
            appearance44.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance44.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownBarrios.DisplayLayout.Override.SelectedRowAppearance = appearance44;
            appearance45.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownBarrios.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance45;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownBarrios.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownBarrios.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownBarrios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownBarrios.DisplayMember = "Nombre";
            this.ultraDropDownBarrios.Location = new System.Drawing.Point(353, 410);
            this.ultraDropDownBarrios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownBarrios.Name = "ultraDropDownBarrios";
            this.ultraDropDownBarrios.Size = new System.Drawing.Size(317, 38);
            this.ultraDropDownBarrios.TabIndex = 13;
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
            // ultraDropDownLocalidad
            // 
            this.ultraDropDownLocalidad.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownLocalidad.DataSource = this.localidadesListaBindingSource;
            appearance26.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidad.DisplayLayout.Appearance = appearance26;
            this.ultraDropDownLocalidad.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand2.ColHeadersVisible = false;
            ultraGridColumn48.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn48.Header.VisiblePosition = 0;
            ultraGridColumn48.Hidden = true;
            ultraGridColumn48.Width = 91;
            ultraGridColumn49.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn49.Header.VisiblePosition = 1;
            ultraGridColumn49.Width = 294;
            ultraGridColumn50.Header.VisiblePosition = 2;
            ultraGridColumn50.Hidden = true;
            ultraGridColumn50.Width = 58;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50});
            this.ultraDropDownLocalidad.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraDropDownLocalidad.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidad.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidad.DisplayLayout.MaxBandDepth = 5;
            appearance27.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveCellAppearance = appearance27;
            appearance28.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance28.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance28.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidad.DisplayLayout.Override.ActiveRowAppearance = appearance28;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidad.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance29.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CardAreaAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.Control;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.CellAppearance = appearance30;
            this.ultraDropDownLocalidad.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance31.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance31.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance31.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderAppearance = appearance31;
            this.ultraDropDownLocalidad.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance32.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSelectorAppearance = appearance32;
            this.ultraDropDownLocalidad.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedCellAppearance = appearance33;
            appearance34.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance34.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidad.DisplayLayout.Override.SelectedRowAppearance = appearance34;
            appearance35.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidad.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance35;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidad.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidad.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidad.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidad.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidad.Location = new System.Drawing.Point(353, 315);
            this.ultraDropDownLocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownLocalidad.Name = "ultraDropDownLocalidad";
            this.ultraDropDownLocalidad.Size = new System.Drawing.Size(317, 39);
            this.ultraDropDownLocalidad.TabIndex = 14;
            this.ultraDropDownLocalidad.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidad.Visible = false;
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
            // ultraDropDownLocalidades
            // 
            this.ultraDropDownLocalidades.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownLocalidades.DataSource = this.localidadesListaBindingSource;
            appearance16.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidades.DisplayLayout.Appearance = appearance16;
            this.ultraDropDownLocalidades.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand1.ColHeadersVisible = false;
            ultraGridColumn51.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn51.Header.VisiblePosition = 0;
            ultraGridColumn51.Hidden = true;
            ultraGridColumn51.Width = 91;
            ultraGridColumn52.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn52.Header.VisiblePosition = 1;
            ultraGridColumn52.Width = 294;
            ultraGridColumn53.Header.VisiblePosition = 2;
            ultraGridColumn53.Hidden = true;
            ultraGridColumn53.Width = 58;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53});
            this.ultraDropDownLocalidades.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraDropDownLocalidades.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLocalidades.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLocalidades.DisplayLayout.MaxBandDepth = 5;
            appearance17.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLocalidades.DisplayLayout.Override.ActiveCellAppearance = appearance17;
            appearance18.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance18.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance18.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLocalidades.DisplayLayout.Override.ActiveRowAppearance = appearance18;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLocalidades.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance19.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLocalidades.DisplayLayout.Override.CardAreaAppearance = appearance19;
            appearance20.BackColor = System.Drawing.SystemColors.Control;
            appearance20.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidades.DisplayLayout.Override.CellAppearance = appearance20;
            this.ultraDropDownLocalidades.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance21.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance21.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLocalidades.DisplayLayout.Override.HeaderAppearance = appearance21;
            this.ultraDropDownLocalidades.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance22.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLocalidades.DisplayLayout.Override.RowSelectorAppearance = appearance22;
            this.ultraDropDownLocalidades.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLocalidades.DisplayLayout.Override.SelectedCellAppearance = appearance23;
            appearance24.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance24.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLocalidades.DisplayLayout.Override.SelectedRowAppearance = appearance24;
            appearance25.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLocalidades.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance25;
            this.ultraDropDownLocalidades.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLocalidades.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLocalidades.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLocalidades.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLocalidades.DisplayMember = "NombreCompleto";
            this.ultraDropDownLocalidades.Location = new System.Drawing.Point(352, 266);
            this.ultraDropDownLocalidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownLocalidades.Name = "ultraDropDownLocalidades";
            this.ultraDropDownLocalidades.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownLocalidades.TabIndex = 32;
            this.ultraDropDownLocalidades.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidades.Visible = false;
            // 
            // FormABCLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(687, 549);
            this.Controls.Add(this.lugaresUltraGrid);
            this.Controls.Add(this.ultraDropDownLocalidades);
            this.Controls.Add(this.ultraDropDownLocalidad);
            this.Controls.Add(this.ultraDropDownBarrios);
            this.Controls.Add(this.ultraDropDownCalle);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(471, 230);
            this.Name = "FormABCLugares";
            this.Text = "Lugares";
            this.Activated += new System.EventHandler(this.FormABCLugaresActivated);
            this.Load += new System.EventHandler(this.FormABCLugaresLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCalle, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBarrios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownLocalidad, 0);
            this.Controls.SetChildIndex(this.ultraDropDownLocalidades, 0);
            this.Controls.SetChildIndex(this.lugaresUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lugaresUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid lugaresUltraGrid;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private System.Windows.Forms.BindingSource lugaresBindingSource;
        private WS.DsLugares dsLugares;
        private System.Windows.Forms.BindingSource bindingSourceCalle;
        private WS.DsCallesLista dsCallesLista1;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCalle;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBarrios;
        private System.Windows.Forms.BindingSource barriosListaBindingSource;
        private WS.DsBarrios dsBarrios;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLocalidad;
        private System.Windows.Forms.BindingSource localidadesListaBindingSource;
        private WS.DsLocalidadesLista dsLocalidadesLista;
        private UltraDropDown ultraDropDownLocalidades;
    }
}
