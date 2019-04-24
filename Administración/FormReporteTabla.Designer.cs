namespace Administración
{
    partial class FormReporteTabla
    {
        private WS.DsBancos dsBancos;
        private CR_Tablas_Bancos crTablasBancos;
        private CRTablasCoberturas crTablasCoberturas;
        private CR_Tablas_Codigos crTablasCodigos;
        private CR_Tablas_CUITsRepetibles crTablasCuiTsRepetibles;
        private CRTablasDiagnosticos crTablasDiagnosticos;
        private CR_Tablas_Empleados crTablasEmpleados;
        private CR_Tablas_EntidadesDeCobranza crTablasEntidadesDeCobranza;
        private CR_Tablas_Lugares crTablasLugares;
        private CRTablasMedicamentos crTablasMedicamentos;
        private CR_Tablas_MedicosDeCabecera crTablasMedicosDeCabecera;
        private CRTablasMotivosCancelacionPrestacion crTablasMotivosCancelacionPrestacion;
        private CR_Tablas_MotivosDeBaja crTablasMotivosDeBaja;
        private CRTablasMotivosDeLlamado crTablasMotivosDeLlamado;
        private CRTablasMoviles crTablasMoviles;
        private CR_Tablas_Ocupaciones crTablasOcupaciones;
        private CR_Tablas_Planes crTablasPlanes;
        private CRTablasPracticas crTablasPracticas;
        private CR_Tablas_Prepagos crTablasPrepagos;
        private CR_Tablas_Prestadores crTablasPrestadores;
        private CR_Tablas_Proveedores crTablasProveedores;
        private CR_Tablas_Puestos crTablasPuestos;
        private CR_Tablas_Rubros crTablasRubros;
        private CR_Tablas_Territorios crTablasTerritorios;
        private CRTablasTiposDeDestino crTablasTiposDeDestino;
        private CRTablasTiposDeMovil crTablasTiposDeMovil;
        private CR_Tablas_TiposDeValores crTablasTiposDeValores;
        private CR_Tablas_Usuarios crTablasUsuarios;
        private CRTablasZonas crTablasZonas;
        private WS.DsDiagnosticos dsDiagnosticos;

        #region Windows Form Designer generated code


        #endregion

        private WS.DsCodigos dsCodigos;
        private WS.DsCUITRepetibles dscuitRepetibles;

        private void InitializeComponent()
        {
            this.dsBancos = new Administración.WS.DsBancos();
            this.crTablasBancos = new Administración.CR_Tablas_Bancos();
            this.crTablasCoberturas = new Administración.CRTablasCoberturas();
            this.crTablasCodigos = new Administración.CR_Tablas_Codigos();
            this.crTablasCuiTsRepetibles = new Administración.CR_Tablas_CUITsRepetibles();
            this.crTablasDiagnosticos = new Administración.CRTablasDiagnosticos();
            this.crTablasEmpleados = new Administración.CR_Tablas_Empleados();
            this.crTablasEntidadesDeCobranza = new Administración.CR_Tablas_EntidadesDeCobranza();
            this.crTablasLugares = new Administración.CR_Tablas_Lugares();
            this.crTablasMedicamentos = new Administración.CRTablasMedicamentos();
            this.crTablasMedicosDeCabecera = new Administración.CR_Tablas_MedicosDeCabecera();
            this.crTablasMotivosCancelacionPrestacion = new Administración.CRTablasMotivosCancelacionPrestacion();
            this.crTablasMotivosDeBaja = new Administración.CR_Tablas_MotivosDeBaja();
            this.crTablasMotivosDeLlamado = new Administración.CRTablasMotivosDeLlamado();
            this.crTablasMoviles = new Administración.CRTablasMoviles();
            this.crTablasOcupaciones = new Administración.CR_Tablas_Ocupaciones();
            this.crTablasPlanes = new Administración.CR_Tablas_Planes();
            this.crTablasPracticas = new Administración.CRTablasPracticas();
            this.crTablasPrepagos = new Administración.CR_Tablas_Prepagos();
            this.crTablasPrestadores = new Administración.CR_Tablas_Prestadores();
            this.crTablasProveedores = new Administración.CR_Tablas_Proveedores();
            this.crTablasPuestos = new Administración.CR_Tablas_Puestos();
            this.crTablasRubros = new Administración.CR_Tablas_Rubros();
            this.crTablasTerritorios = new Administración.CR_Tablas_Territorios();
            this.crTablasTiposDeDestino = new Administración.CRTablasTiposDeDestino();
            this.crTablasTiposDeMovil = new Administración.CRTablasTiposDeMovil();
            this.crTablasTiposDeValores = new Administración.CR_Tablas_TiposDeValores();
            this.crTablasUsuarios = new Administración.CR_Tablas_Usuarios();
            this.crTablasZonas = new Administración.CRTablasZonas();
            this.dsCodigos = new Administración.WS.DsCodigos();
            this.dscuitRepetibles = new Administración.WS.DsCUITRepetibles();
            this.dsDiagnosticos = new Administración.WS.DsDiagnosticos();
            this.dsEntidadesDeCobranza = new Administración.WS.DsEntidadesDeCobranza();
            this.dsLugaresLista = new Administración.WS.DsLugaresLista();
            this.dsMedicamentos = new Administración.WS.DsMedicamentos();
            this.dsMedicosDeCabecera = new Administración.WS.DsMedicosDeCabecera();
            this.dsMotivosDeCancelacionPrestacion = new Administración.WS.DsMotivosDeCancelacionPrestacion();
            this.dsMotivosDeBaja = new Administración.WS.DsMotivosDeBaja();
            this.dsMotivosDeLlamado = new Administración.WS.DsMotivosDeLlamado();
            this.dsOcupaciones = new Administración.WS.DsOcupaciones();
            this.dsPlanesParaReporte = new Administración.WS.DsPlanesParaReporte();
            this.dsPracticas = new Administración.WS.DsPracticas();
            this.dsPrepagos = new Administración.WS.DsPrepagos();
            this.dsProveedores = new Administración.WS.DsProveedores();
            this.dsPuestos = new Administración.WS.DsPuestos();
            this.dsTiposDeCliente = new Administración.WS.DsTiposDeCliente();
            this.dsTerritorios = new Administración.WS.DsTerritorios();
            this.dsTiposDeDestino = new Administración.WS.DsTiposDeDestino();
            this.dsTiposDeValores = new Administración.WS.DsTiposDeValores();
            this.dsUsuarios = new Administración.WS.DsUsuarios();
            this.dsZonasLista = new Administración.WS.DsZonasLista();
            this.dsTiposDeMovil = new Administración.WS.DsTiposDeMovil();
            this.dsReporteTransferencia = new Administración.WS.DsReporteTransferencia();
            this.dsMovilesLista = new Administración.WS.DsMovilesLista();
            this.dsCoberturas = new Administración.WS.DsCoberturas();
            this.dsEmpleadosLista = new Administración.DsEmpleadosLista();
            this.dsPrestadores = new Administración.WS.DsPrestadores();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dscuitRepetibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiagnosticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugaresLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicosDeCabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeCancelacionPrestacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeLlamado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOcupaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanesParaReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTerritorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonasLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeMovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMovilesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoberturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestadores)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ReportSource = this.crTablasZonas;
            this.crystalReportViewer1.Size = new System.Drawing.Size(930, 586);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(841, 592);
            // 
            // dsBancos
            // 
            this.dsBancos.DataSetName = "DsBancos";
            this.dsBancos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCodigos
            // 
            this.dsCodigos.DataSetName = "DsCodigos";
            this.dsCodigos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dscuitRepetibles
            // 
            this.dscuitRepetibles.DataSetName = "DsCUITRepetibles";
            this.dscuitRepetibles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDiagnosticos
            // 
            this.dsDiagnosticos.DataSetName = "DsDiagnosticos";
            this.dsDiagnosticos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsEntidadesDeCobranza
            // 
            this.dsEntidadesDeCobranza.DataSetName = "DsEntidadesDeCobranza";
            this.dsEntidadesDeCobranza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsLugaresLista
            // 
            this.dsLugaresLista.DataSetName = "DsLugaresLista";
            this.dsLugaresLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMedicamentos
            // 
            this.dsMedicamentos.DataSetName = "DsMedicamentos";
            this.dsMedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMedicosDeCabecera
            // 
            this.dsMedicosDeCabecera.DataSetName = "DsMedicosDeCabecera";
            this.dsMedicosDeCabecera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMotivosDeCancelacionPrestacion
            // 
            this.dsMotivosDeCancelacionPrestacion.DataSetName = "DsMotivosDeCancelacionPrestacion";
            this.dsMotivosDeCancelacionPrestacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMotivosDeBaja
            // 
            this.dsMotivosDeBaja.DataSetName = "DsMotivosDeBaja";
            this.dsMotivosDeBaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMotivosDeLlamado
            // 
            this.dsMotivosDeLlamado.DataSetName = "DsMotivosDeLlamado";
            this.dsMotivosDeLlamado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsOcupaciones
            // 
            this.dsOcupaciones.DataSetName = "DsOcupaciones";
            this.dsOcupaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPlanesParaReporte
            // 
            this.dsPlanesParaReporte.DataSetName = "DsPlanesParaReporte";
            this.dsPlanesParaReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPracticas
            // 
            this.dsPracticas.DataSetName = "DsPracticas";
            this.dsPracticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPrepagos
            // 
            this.dsPrepagos.DataSetName = "DsPrepagos";
            this.dsPrepagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsProveedores
            // 
            this.dsProveedores.DataSetName = "DsProveedores";
            this.dsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPuestos
            // 
            this.dsPuestos.DataSetName = "DsPuestos";
            this.dsPuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsTiposDeCliente
            // 
            this.dsTiposDeCliente.DataSetName = "DsTiposDeCliente";
            this.dsTiposDeCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsTerritorios
            // 
            this.dsTerritorios.DataSetName = "DsTerritorios";
            this.dsTerritorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsTiposDeDestino
            // 
            this.dsTiposDeDestino.DataSetName = "DsTiposDeDestino";
            this.dsTiposDeDestino.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsTiposDeValores
            // 
            this.dsTiposDeValores.DataSetName = "DsTiposDeValores";
            this.dsTiposDeValores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsUsuarios
            // 
            this.dsUsuarios.DataSetName = "DsUsuarios";
            this.dsUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsZonasLista
            // 
            this.dsZonasLista.DataSetName = "DsZonasLista";
            this.dsZonasLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsTiposDeMovil
            // 
            this.dsTiposDeMovil.DataSetName = "DsTiposDeMovil";
            this.dsTiposDeMovil.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsReporteTransferencia
            // 
            this.dsReporteTransferencia.DataSetName = "DsReporteTransferencia";
            this.dsReporteTransferencia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsMovilesLista
            // 
            this.dsMovilesLista.DataSetName = "DsMovilesLista";
            this.dsMovilesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCoberturas
            // 
            this.dsCoberturas.DataSetName = "DsCoberturas";
            this.dsCoberturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsEmpleadosLista
            // 
            this.dsEmpleadosLista.DataSetName = "DsEmpleadosLista";
            this.dsEmpleadosLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPrestadores
            // 
            this.dsPrestadores.DataSetName = "DsPrestadores";
            this.dsPrestadores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormReporteTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 627);
            this.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.Name = "FormReporteTabla";
            this.Text = "Tabla";
            this.Load += new System.EventHandler(this.FormReporteTablaLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dsBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dscuitRepetibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiagnosticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugaresLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicosDeCabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeCancelacionPrestacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeLlamado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOcupaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanesParaReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTerritorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonasLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeMovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporteTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMovilesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoberturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpleadosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrestadores)).EndInit();
            this.ResumeLayout(false);

        }

        private WS.DsEntidadesDeCobranza dsEntidadesDeCobranza;
        private WS.DsLugaresLista dsLugaresLista;
        private WS.DsMedicamentos dsMedicamentos;
        private WS.DsMedicosDeCabecera dsMedicosDeCabecera;
        private WS.DsMotivosDeCancelacionPrestacion dsMotivosDeCancelacionPrestacion;
        private WS.DsMotivosDeBaja dsMotivosDeBaja;
        private WS.DsMotivosDeLlamado dsMotivosDeLlamado;
        private WS.DsOcupaciones dsOcupaciones;
        private WS.DsPlanesParaReporte dsPlanesParaReporte;
        private WS.DsPracticas dsPracticas;
        private WS.DsPrepagos dsPrepagos;
        private WS.DsProveedores dsProveedores;
        private WS.DsPuestos dsPuestos;
        private WS.DsTiposDeCliente dsTiposDeCliente;
        private WS.DsTerritorios dsTerritorios;
        private WS.DsTiposDeDestino dsTiposDeDestino;
        private WS.DsTiposDeValores dsTiposDeValores;
        private WS.DsUsuarios dsUsuarios;
        private WS.DsZonasLista dsZonasLista;
        private WS.DsTiposDeMovil dsTiposDeMovil;
        private WS.DsReporteTransferencia dsReporteTransferencia;
        private WS.DsMovilesLista dsMovilesLista;
        private WS.DsCoberturas dsCoberturas;
        private DsEmpleadosLista dsEmpleadosLista;
        private WS.DsPrestadores dsPrestadores;
    }
}
