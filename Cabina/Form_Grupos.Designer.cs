using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    partial class FormGrupos
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
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Grupos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCobranza", -1, "ultraDropDownTipoDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza", -1, "ultraDropDownEntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VencimientoTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTitularTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocumentoTitularTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TelefonoTitularTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCategoriaIVA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CUIT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sucursal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jubilado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpresasSueldoBcoMacro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Grupos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Afiliados_Grupos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Grupos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Grupos_EmailGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobrador", 0);
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Grupos", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona", -1, "ultraDropDownZonas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidades");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_DireccionesGrupos");
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_DireccionesGrupos", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Afiliados_Grupos", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apellido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeDocumento");
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaDeNacimiento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sexo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Titular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Asma");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Diabetes");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tabaco");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Hipertension");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Corazon");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Alergia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn97 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Otros");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn98 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugarDeInternacion", -1, "ultraDropDownLugarDeInternacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn99 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago", -1, "ultraDropDownPrepagos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn100 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn101 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento", -1, "ultraDropDownTiposDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn102 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicoDeCabecera", -1, "ultraDropDownMedicosDeCabecera");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn103 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idOcupacion", -1, "ultraDropDownOcupaciones");
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroAfiliadoPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Solicitudes_Afiliados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Afiliados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Afiliados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Afiliados");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Edad", 0);
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Solicitudes_Afiliados", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AltaBajaSusp");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaRegistro", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idVendedor", -1, "ultraDropDownVendedores");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeBaja", -1, "ultraDropDownMotivosDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn131 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTomadorDeBaja", -1, "ultraDropDownTomadoresDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Renovacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EsCambioDePlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrabador", -1, "ultraDropDownGrabador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idSolicitud");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_AfiliadosPlanes_Solicitudes");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_AfiliadosPlanes_Solicitudes", 4);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliadoPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idsolicitud");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan", -1, "ultraDropDownPlanesAfiliado");
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Afiliados", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn143 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn144 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn145 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Afiliados", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn146 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn147 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Real");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn148 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn149 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn150 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn151 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn152 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn153 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn154 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2", -1, "ultraDropDownCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn155 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona", -1, "ultraDropDownZonas");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn156 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn157 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn158 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn159 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn160 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn161 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio", -1, "ultraDropDownBarrios");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn162 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDestino");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn163 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad", -1, "ultraDropDownLocalidades");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn164 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Direcciones1");
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Direcciones1", 7);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn165 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn166 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn167 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn168 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn169 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Afiliados", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn170 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn171 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn172 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand11 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Grupos", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn173 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn174 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn175 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn176 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn177 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn178 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn179 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_TelefonosContactos");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn180 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Emails_Contactos_Afiliados");
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand12 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_TelefonosContactos", 10);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn181 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn182 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn183 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn184 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn185 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.Appearance appearance194 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand13 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Emails_Contactos_Afiliados", 10);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn186 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn187 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn188 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand14 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Grupos_EmailGrupo", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn189 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn190 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn191 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance184 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand35 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Planes", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn301 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn302 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn303 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn304 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContrato");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn507 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PadronExterno");
            Infragistics.Win.Appearance appearance185 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance186 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance187 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance188 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance189 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance190 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance191 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance192 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance193 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance174 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand34 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Calles", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn297 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn298 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn299 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn300 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance175 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance176 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance177 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance178 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance179 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance180 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance181 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance182 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance183 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance164 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand33 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn292 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn293 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn294 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereEntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn295 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereZonaDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn296 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereDireccionReal");
            Infragistics.Win.Appearance appearance165 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance166 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance167 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance168 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance169 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance170 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance171 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance172 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance173 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance154 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand32 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EntidadesDeCobranza", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn277 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntidadDeCobranza");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn278 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn279 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn280 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MascaraTarjeta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn281 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereNumero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn282 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereVencimiento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn283 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereNombreTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn284 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereDocTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn285 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereTelTitular");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn286 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDeCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn287 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereConvenio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn288 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereSucursal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn289 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereEmpresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn290 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RequiereJubilado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn291 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance155 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance156 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance157 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance158 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance159 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance160 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance161 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance162 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance163 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand31 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TiposDeDocumento", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn274 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTipoDeDocumento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn275 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn276 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance145 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance146 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance147 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance148 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance149 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance150 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance151 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance152 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance153 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand26 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Lugares", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn238 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn239 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn240 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn241 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocaldad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn242 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Direcciones_Lugares");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn243 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Contactos_Lugares");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand27 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Direcciones_Lugares", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn244 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn245 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCalle");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn246 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn247 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Piso");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn248 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Departamento");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn249 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle1");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn250 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEntreCalle2");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn251 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn252 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn253 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn254 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn255 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn256 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Direcciones1");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand28 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Direcciones1", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn257 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn258 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn259 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn260 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn261 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand29 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Contactos_Lugares", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn262 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn263 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn264 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn265 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn266 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idGrupo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn267 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLugar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn268 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Telefonos_Cotactos");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand30 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Telefonos_Cotactos", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn269 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idTelefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn270 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn271 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idContacto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn272 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idDireccion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn273 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idAfiliado");
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance124 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand25 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Prepagos", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn235 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPrepago");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn236 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn237 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.Appearance appearance125 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance126 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance127 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance128 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance129 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance130 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance131 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance132 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance114 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand24 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn228 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn229 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn230 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn231 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn232 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn233 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn234 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
            Infragistics.Win.Appearance appearance115 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance116 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance117 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance118 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance119 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance120 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance121 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance122 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance123 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand23 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Zonas", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn222 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idZona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn223 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn224 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn225 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn226 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idCobrador");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn227 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPuntoDeVenta");
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance113 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand22 = new Infragistics.Win.UltraWinGrid.UltraGridBand("EmpleadosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn215 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn216 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn217 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn218 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn219 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn220 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn221 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBanco");
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand21 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MotivosDeBaja", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn213 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMotivoDeBaja");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn214 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance74 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand20 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PlanesAfiliado", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn208 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idPlan");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn209 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn210 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn211 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn212 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PadronExterno");
            Infragistics.Win.Appearance appearance75 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance76 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance77 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance78 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance79 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance80 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance81 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance82 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance83 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance64 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand19 = new Infragistics.Win.UltraWinGrid.UltraGridBand("BarriosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn205 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idBarrio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn206 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn207 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.Appearance appearance65 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance66 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance67 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance68 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance69 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance70 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance71 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance72 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance73 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand18 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Ocupaciones", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn203 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idOcupacion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn204 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance63 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand17 = new Infragistics.Win.UltraWinGrid.UltraGridBand("MedicosDeCabeceraLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn198 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idMedicoDeCabecera");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn199 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apellido");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn200 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn201 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn202 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion1 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.UltraWinGrid.ColScrollRegion colScrollRegion2 = new Infragistics.Win.UltraWinGrid.ColScrollRegion(236);
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand16 = new Infragistics.Win.UltraWinGrid.UltraGridBand("LocalidadesLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idLocalidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand15 = new Infragistics.Win.UltraWinGrid.UltraGridBand("UsuariosLista", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn192 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn193 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn194 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombApel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn195 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ApelNomb");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn196 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Iniciales");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn197 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("idEmpleado");
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.gruposUltraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAfiliados = new Cabina.WS.DsAfiliados();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.ultraDropDownPlanes = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanes = new Cabina.WS.DsPlanes();
            this.ultraDropDownCalle = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.bindingSourceCalle = new System.Windows.Forms.BindingSource(this.components);
            this.dsCallesLista = new Cabina.WS.DsCallesLista();
            this.ultraDropDownTipoDeCobranza = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeCobranza = new Cabina.WS.DsTiposDeCobranza();
            this.ultraDropDownEntidadDeCobranza = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.entidadesDeCobranzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEntidadesDeCobranza = new Cabina.WS.DsEntidadesDeCobranza();
            this.ultraDropDownTiposDeDocumento = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tiposDeDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTiposDeDocumento = new Cabina.WS.DsTiposDeDocumento();
            this.ultraDropDownLugarDeInternacion = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.lugaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLugares = new Cabina.WS.DsLugares();
            this.ultraDropDownPrepagos = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.prepagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrepagos = new Cabina.WS.DsPrepagos();
            this.ultraDropDownVendedores = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.vendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVendedores = new Cabina.WS.DsEmpleadosLista();
            this.ultraDropDownZonas = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.zonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsZonas = new Cabina.WS.DsZonas();
            this.ultraDropDownTomadoresDeBaja = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.tomadoresDeBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTomadoresDeBaja = new Cabina.WS.DsEmpleadosLista();
            this.ultraDropDownMotivosDeBaja = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.motivosDeBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMotivosDeBaja = new Cabina.WS.DsMotivosDeBaja();
            this.ultraDropDownPlanesAfiliado = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.planesAfiliadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanesAfiliado = new Cabina.WS.DsPlanesAfiliado();
            this.ultraDropDownBarrios = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.barriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBarrios = new Cabina.WS.DsBarrios();
            this.buttonEstadoActualDelGrupo = new System.Windows.Forms.Button();
            this.buttonCancelarNoHeredado = new System.Windows.Forms.Button();
            this.ultraDropDownOcupaciones = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.ocupacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOcupaciones = new Cabina.WS.DsOcupaciones();
            this.ultraDropDownMedicosDeCabecera = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.medicosDeCabeceraListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMedicosDeCabecera = new Cabina.WS.DsMedicosDeCabecera();
            this.ultraDropDownLocalidades = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.localidadesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLocalidadesLista = new Cabina.WS.DsLocalidadesLista();
            this.ultraDropDownGrabador = new Infragistics.Win.UltraWinGrid.UltraDropDown();
            this.usuariosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUsuariosLista1 = new Cabina.WS.DsUsuariosLista();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposUltraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAfiliados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTipoDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEntidadDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesDeCobranzaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLugarDeInternacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadoresDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomadoresDeBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTomadoresDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanesAfiliado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesAfiliadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanesAfiliado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownOcupaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOcupaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicosDeCabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDeCabeceraListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicosDeCabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(1057, 20);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toolTip1.SetToolTip(this.buttonAceptar, "Grabar y Salir");
            this.buttonAceptar.Click += new System.EventHandler(this.ButtonAceptarClick);
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(947, 20);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toolTip1.SetToolTip(this.buttonAplicar, "Grabar sin salir");
            this.buttonAplicar.Click += new System.EventHandler(this.ButtonAplicarClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEstadoActualDelGrupo);
            this.panel1.Controls.Add(this.buttonSalir);
            this.panel1.Controls.Add(this.buttonCancelarNoHeredado);
            this.panel1.Location = new System.Drawing.Point(1, 670);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1175, 62);
            this.panel1.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonCancelarNoHeredado, 0);
            this.panel1.Controls.SetChildIndex(this.buttonSalir, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.panel1.Controls.SetChildIndex(this.buttonEstadoActualDelGrupo, 0);
            this.panel1.Controls.SetChildIndex(this.buttonAplicar, 0);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(839, 20);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCancelar.Text = "No va";
            this.toolTip1.SetToolTip(this.buttonCancelar, "Salir");
            this.buttonCancelar.Visible = false;
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // gruposUltraGrid
            // 
            this.gruposUltraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gruposUltraGrid.CalcManager = this.ultraCalcManager1;
            this.gruposUltraGrid.DataSource = this.gruposBindingSource;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.gruposUltraGrid.DisplayLayout.Appearance = appearance11;
            ultraGridColumn33.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn33.Header.VisiblePosition = 0;
            ultraGridColumn33.Hidden = true;
            ultraGridColumn33.Width = 114;
            ultraGridColumn34.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn34.Header.Caption = "Tipo de Cobranza";
            ultraGridColumn34.Header.VisiblePosition = 1;
            ultraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(120, 0);
            ultraGridColumn34.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(120, 0);
            ultraGridColumn34.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn34.Width = 103;
            ultraGridColumn35.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn35.Header.Caption = "Entidad de Cobranza";
            ultraGridColumn35.Header.VisiblePosition = 2;
            ultraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(110, 0);
            ultraGridColumn35.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(110, 0);
            ultraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn35.Width = 148;
            ultraGridColumn36.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn36.Header.Caption = "Número Tarjeta";
            ultraGridColumn36.Header.VisiblePosition = 3;
            ultraGridColumn36.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(94, 0);
            ultraGridColumn36.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(91, 0);
            ultraGridColumn36.Width = 116;
            ultraGridColumn37.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn37.Header.Caption = "Vencimiento";
            ultraGridColumn37.Header.VisiblePosition = 4;
            ultraGridColumn37.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(70, 0);
            ultraGridColumn37.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(70, 0);
            ultraGridColumn37.Width = 72;
            ultraGridColumn38.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn38.Header.Caption = "Nombre del Titular";
            ultraGridColumn38.Header.VisiblePosition = 5;
            ultraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(108, 0);
            ultraGridColumn38.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(105, 0);
            ultraGridColumn38.Width = 142;
            ultraGridColumn39.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn39.Header.Caption = "Doc. Titular";
            ultraGridColumn39.Header.VisiblePosition = 6;
            ultraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(76, 0);
            ultraGridColumn39.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(70, 0);
            ultraGridColumn39.Width = 82;
            ultraGridColumn40.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn40.Header.Caption = "Tel. Titular";
            ultraGridColumn40.Header.VisiblePosition = 7;
            ultraGridColumn40.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(73, 0);
            ultraGridColumn40.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(66, 0);
            ultraGridColumn40.Width = 80;
            ultraGridColumn41.Header.VisiblePosition = 8;
            ultraGridColumn42.Header.VisiblePosition = 9;
            ultraGridColumn43.Header.VisiblePosition = 11;
            ultraGridColumn44.Header.VisiblePosition = 12;
            ultraGridColumn48.Header.VisiblePosition = 13;
            ultraGridColumn49.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn49.Header.VisiblePosition = 16;
            ultraGridColumn50.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn50.Header.VisiblePosition = 14;
            ultraGridColumn51.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn51.Header.VisiblePosition = 15;
            ultraGridColumn52.Header.VisiblePosition = 17;
            ultraGridColumn53.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn53.Header.VisiblePosition = 10;
            ultraGridColumn53.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(87, 0);
            ultraGridColumn53.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(59, 0);
            ultraGridColumn53.Width = 98;
            ultraGridBand1.Columns.AddRange(new object[] {
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
            ultraGridColumn44,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53});
            appearance12.FontData.BoldAsString = "True";
            appearance12.FontData.SizeInPoints = 11F;
            appearance12.TextHAlignAsString = "Left";
            ultraGridBand1.Header.Appearance = appearance12;
            ultraGridBand1.Header.Caption = "Cobranza";
            ultraGridBand1.HeaderVisible = true;
            ultraGridBand1.MaxRows = 1;
            ultraGridBand1.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn54.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn54.Header.VisiblePosition = 0;
            ultraGridColumn54.Hidden = true;
            ultraGridColumn54.Width = 31;
            ultraGridColumn55.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn55.DefaultCellValue = "True";
            ultraGridColumn55.Header.VisiblePosition = 1;
            ultraGridColumn55.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn55.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn55.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(78, 52);
            ultraGridColumn55.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(78, 0);
            ultraGridColumn55.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn55.RowLayoutColumnInfo.SpanY = 6;
            ultraGridColumn55.Width = 56;
            ultraGridColumn56.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn56.DefaultCellValue = "True";
            ultraGridColumn56.Header.VisiblePosition = 2;
            ultraGridColumn56.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn56.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn56.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(58, 52);
            ultraGridColumn56.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(58, 0);
            ultraGridColumn56.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn56.RowLayoutColumnInfo.SpanY = 6;
            ultraGridColumn56.Width = 63;
            ultraGridColumn57.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn57.Header.Caption = "Calle";
            ultraGridColumn57.Header.VisiblePosition = 3;
            ultraGridColumn57.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn57.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn57.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(197, 0);
            ultraGridColumn57.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(38, 0);
            ultraGridColumn57.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn57.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn57.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn57.Width = 51;
            ultraGridColumn58.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn58.Header.Caption = "Número";
            ultraGridColumn58.Header.VisiblePosition = 4;
            ultraGridColumn58.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn58.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn58.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(66, 0);
            ultraGridColumn58.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn58.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn58.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn58.Width = 90;
            ultraGridColumn59.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn59.Header.VisiblePosition = 5;
            ultraGridColumn59.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn59.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn59.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(41, 0);
            ultraGridColumn59.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(34, 0);
            ultraGridColumn59.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn59.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn59.Width = 90;
            ultraGridColumn60.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn60.Header.VisiblePosition = 6;
            ultraGridColumn60.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn60.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn60.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(81, 0);
            ultraGridColumn60.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(81, 0);
            ultraGridColumn60.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn60.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn60.Width = 90;
            ultraGridColumn61.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn61.Header.Caption = "entre";
            ultraGridColumn61.Header.VisiblePosition = 7;
            ultraGridColumn61.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn61.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn61.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(197, 0);
            ultraGridColumn61.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(38, 0);
            ultraGridColumn61.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn61.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn61.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn61.Width = 76;
            ultraGridColumn62.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn62.Header.Caption = "y";
            ultraGridColumn62.Header.VisiblePosition = 8;
            ultraGridColumn62.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn62.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn62.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(197, 0);
            ultraGridColumn62.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(18, 0);
            ultraGridColumn62.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn62.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn62.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn62.Width = 76;
            ultraGridColumn63.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn63.Header.Caption = "Zona";
            ultraGridColumn63.Header.VisiblePosition = 9;
            ultraGridColumn63.RowLayoutColumnInfo.OriginX = 12;
            ultraGridColumn63.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn63.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(66, 0);
            ultraGridColumn63.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn63.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn63.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn63.Width = 51;
            ultraGridColumn64.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn64.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn64.Header.VisiblePosition = 10;
            ultraGridColumn64.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn64.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn64.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(385, 36);
            ultraGridColumn64.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(88, 0);
            ultraGridColumn64.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn64.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn64.VertScrollBar = true;
            ultraGridColumn64.Width = 90;
            ultraGridColumn65.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn65.Header.VisiblePosition = 11;
            ultraGridColumn65.Hidden = true;
            ultraGridColumn65.Width = 34;
            ultraGridColumn66.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn66.Header.VisiblePosition = 12;
            ultraGridColumn66.Hidden = true;
            ultraGridColumn66.Width = 33;
            ultraGridColumn67.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn67.Header.VisiblePosition = 13;
            ultraGridColumn67.Hidden = true;
            ultraGridColumn67.Width = 35;
            ultraGridColumn68.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn68.Header.VisiblePosition = 14;
            ultraGridColumn68.Hidden = true;
            ultraGridColumn68.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn68.Width = 33;
            ultraGridColumn69.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn69.Header.Caption = "Barrio";
            ultraGridColumn69.Header.VisiblePosition = 15;
            ultraGridColumn69.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn69.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn69.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(131, 0);
            ultraGridColumn69.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(131, 0);
            ultraGridColumn69.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn69.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn69.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn70.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn70.Header.VisiblePosition = 16;
            ultraGridColumn70.Hidden = true;
            ultraGridColumn71.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn71.Header.Caption = "Localidad";
            ultraGridColumn71.Header.VisiblePosition = 17;
            ultraGridColumn71.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn71.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn71.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(154, 0);
            ultraGridColumn71.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(154, 0);
            ultraGridColumn71.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn71.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn71.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn72.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn72.Header.VisiblePosition = 18;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68,
            ultraGridColumn69,
            ultraGridColumn70,
            ultraGridColumn71,
            ultraGridColumn72});
            appearance13.FontData.BoldAsString = "True";
            appearance13.FontData.SizeInPoints = 11F;
            appearance13.TextHAlignAsString = "Left";
            ultraGridBand2.Header.Appearance = appearance13;
            ultraGridBand2.Header.Caption = "Direcciones del Grupo de Afiliados";
            ultraGridBand2.HeaderVisible = true;
            ultraGridBand2.MaxRows = 2;
            ultraGridBand2.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand3.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand3.CardSettings.ShowCaption = false;
            ultraGridBand3.CardView = true;
            ultraGridColumn73.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn73.Header.VisiblePosition = 0;
            ultraGridColumn73.Hidden = true;
            ultraGridColumn73.Width = 103;
            ultraGridColumn74.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn74.Header.VisiblePosition = 1;
            ultraGridColumn74.Width = 100;
            ultraGridColumn75.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn75.Header.VisiblePosition = 2;
            ultraGridColumn75.Hidden = true;
            ultraGridColumn75.Width = 121;
            ultraGridColumn76.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn76.Header.VisiblePosition = 3;
            ultraGridColumn76.Hidden = true;
            ultraGridColumn76.Width = 124;
            ultraGridColumn77.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn77.Header.VisiblePosition = 4;
            ultraGridColumn77.Hidden = true;
            ultraGridColumn77.Width = 107;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn73,
            ultraGridColumn74,
            ultraGridColumn75,
            ultraGridColumn76,
            ultraGridColumn77});
            ultraGridBand3.Header.Caption = "Tel. Direccìón";
            ultraGridBand3.HeaderVisible = true;
            ultraGridBand3.MaxRows = 5;
            ultraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn78.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn78.Header.VisiblePosition = 0;
            ultraGridColumn78.Hidden = true;
            ultraGridColumn78.Width = 20;
            ultraGridColumn79.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn79.Header.VisiblePosition = 1;
            ultraGridColumn79.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn79.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn79.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(144, 0);
            ultraGridColumn79.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(144, 0);
            ultraGridColumn79.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn79.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn79.Width = 54;
            ultraGridColumn80.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn80.Header.VisiblePosition = 2;
            ultraGridColumn80.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn80.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn80.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(137, 0);
            ultraGridColumn80.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn80.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn80.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn80.Width = 59;
            ultraGridColumn81.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            appearance14.TextHAlignAsString = "Right";
            ultraGridColumn81.CellAppearance = appearance14;
            ultraGridColumn81.Header.Caption = "Nº Documento";
            ultraGridColumn81.Header.VisiblePosition = 3;
            ultraGridColumn81.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn81.MaskInput = "{LOC}nnn,nnn,nnn,nnn";
            ultraGridColumn81.RowLayoutColumnInfo.OriginX = 7;
            ultraGridColumn81.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn81.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(91, 0);
            ultraGridColumn81.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(91, 0);
            ultraGridColumn81.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn81.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn82.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn82.Format = "dd/MM/yyyy";
            ultraGridColumn82.Header.Caption = "Nacimiento";
            ultraGridColumn82.Header.VisiblePosition = 4;
            ultraGridColumn82.RowLayoutColumnInfo.OriginX = 9;
            ultraGridColumn82.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn82.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(78, 0);
            ultraGridColumn82.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(78, 0);
            ultraGridColumn82.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn82.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn82.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateWithoutDropDown;
            ultraGridColumn82.Width = 60;
            ultraGridColumn83.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn83.Header.VisiblePosition = 5;
            ultraGridColumn83.RowLayoutColumnInfo.OriginX = 13;
            ultraGridColumn83.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn83.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(81, 0);
            ultraGridColumn83.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(81, 0);
            ultraGridColumn83.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn83.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn83.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn83.Width = 51;
            ultraGridColumn90.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn90.DefaultCellValue = "False";
            ultraGridColumn90.Header.VisiblePosition = 6;
            ultraGridColumn90.RowLayoutColumnInfo.OriginX = 17;
            ultraGridColumn90.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn90.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(52, 0);
            ultraGridColumn90.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(44, 0);
            ultraGridColumn90.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn90.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn90.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            ultraGridColumn90.Width = 24;
            ultraGridColumn91.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn91.DefaultCellValue = "False";
            ultraGridColumn91.Header.VisiblePosition = 7;
            ultraGridColumn91.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn91.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn91.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(83, 0);
            ultraGridColumn91.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn91.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn92.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn92.DefaultCellValue = "False";
            ultraGridColumn92.Header.VisiblePosition = 8;
            ultraGridColumn92.RowLayoutColumnInfo.OriginX = 1;
            ultraGridColumn92.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn92.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(61, 18);
            ultraGridColumn92.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(61, 0);
            ultraGridColumn92.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn92.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn92.Width = 31;
            ultraGridColumn93.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn93.DefaultCellValue = "False";
            ultraGridColumn93.Header.VisiblePosition = 9;
            ultraGridColumn93.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn93.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn93.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(87, 18);
            ultraGridColumn93.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn93.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn93.Width = 28;
            ultraGridColumn94.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn94.DefaultCellValue = "False";
            ultraGridColumn94.Header.Caption = "Hipertensión";
            ultraGridColumn94.Header.VisiblePosition = 10;
            ultraGridColumn94.RowLayoutColumnInfo.OriginX = 5;
            ultraGridColumn94.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn94.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(40, 18);
            ultraGridColumn94.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(40, 0);
            ultraGridColumn94.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn94.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn94.Width = 41;
            ultraGridColumn95.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn95.DefaultCellValue = "False";
            ultraGridColumn95.Header.Caption = "Corazón";
            ultraGridColumn95.Header.VisiblePosition = 11;
            ultraGridColumn95.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn95.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn95.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(92, 18);
            ultraGridColumn95.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn95.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn95.Width = 57;
            ultraGridColumn96.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn96.Header.VisiblePosition = 12;
            ultraGridColumn96.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn96.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn96.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(51, 18);
            ultraGridColumn96.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn96.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn96.Width = 51;
            ultraGridColumn97.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn97.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn97.Header.Caption = "Observaciones";
            ultraGridColumn97.Header.VisiblePosition = 13;
            ultraGridColumn97.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn97.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn97.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(272, 93);
            ultraGridColumn97.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(117, 0);
            ultraGridColumn97.RowLayoutColumnInfo.SpanX = 11;
            ultraGridColumn97.RowLayoutColumnInfo.SpanY = 6;
            ultraGridColumn97.VertScrollBar = true;
            ultraGridColumn97.Width = 51;
            ultraGridColumn98.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn98.Header.Caption = "Lugar de Internación";
            ultraGridColumn98.Header.VisiblePosition = 14;
            ultraGridColumn98.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn98.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn98.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(164, 0);
            ultraGridColumn98.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn98.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn98.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn98.Width = 64;
            ultraGridColumn99.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn99.Header.Caption = "Obra Social o Prepago";
            ultraGridColumn99.Header.VisiblePosition = 15;
            ultraGridColumn99.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn99.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn99.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(117, 0);
            ultraGridColumn99.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(117, 0);
            ultraGridColumn99.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn99.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn99.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn99.Width = 34;
            ultraGridColumn100.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn100.Header.VisiblePosition = 16;
            ultraGridColumn100.Hidden = true;
            ultraGridColumn100.Width = 30;
            ultraGridColumn101.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn101.Header.Caption = "Tipo Doc.";
            ultraGridColumn101.Header.VisiblePosition = 17;
            ultraGridColumn101.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn101.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn101.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(43, 0);
            ultraGridColumn101.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn101.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn101.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn102.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance15.TextHAlignAsString = "Center";
            ultraGridColumn102.CellAppearance = appearance15;
            ultraGridColumn102.Header.Caption = "Médico de Cabecera";
            ultraGridColumn102.Header.VisiblePosition = 18;
            ultraGridColumn102.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn102.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn102.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(231, 0);
            ultraGridColumn102.RowLayoutColumnInfo.SpanX = 4;
            ultraGridColumn102.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn102.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn103.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            appearance16.TextHAlignAsString = "Center";
            ultraGridColumn103.CellAppearance = appearance16;
            ultraGridColumn103.Header.Caption = "Ocupación";
            ultraGridColumn103.Header.VisiblePosition = 19;
            ultraGridColumn103.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn103.RowLayoutColumnInfo.OriginY = 6;
            ultraGridColumn103.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(192, 0);
            ultraGridColumn103.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(66, 0);
            ultraGridColumn103.RowLayoutColumnInfo.SpanX = 5;
            ultraGridColumn103.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn103.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn117.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn117.Header.Caption = "Nº Af. Prepago";
            ultraGridColumn117.Header.VisiblePosition = 20;
            ultraGridColumn117.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn117.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn117.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(129, 0);
            ultraGridColumn117.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(87, 0);
            ultraGridColumn117.RowLayoutColumnInfo.SpanX = 3;
            ultraGridColumn117.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn118.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn118.Header.VisiblePosition = 22;
            ultraGridColumn119.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn119.Header.VisiblePosition = 23;
            ultraGridColumn120.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn120.Header.VisiblePosition = 24;
            ultraGridColumn121.Header.VisiblePosition = 25;
            ultraGridColumn122.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn122.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn122.Header.VisiblePosition = 21;
            ultraGridColumn122.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn122.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn122.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(94, 0);
            ultraGridColumn122.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(39, 0);
            ultraGridColumn122.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn122.RowLayoutColumnInfo.SpanY = 2;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn78,
            ultraGridColumn79,
            ultraGridColumn80,
            ultraGridColumn81,
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn90,
            ultraGridColumn91,
            ultraGridColumn92,
            ultraGridColumn93,
            ultraGridColumn94,
            ultraGridColumn95,
            ultraGridColumn96,
            ultraGridColumn97,
            ultraGridColumn98,
            ultraGridColumn99,
            ultraGridColumn100,
            ultraGridColumn101,
            ultraGridColumn102,
            ultraGridColumn103,
            ultraGridColumn117,
            ultraGridColumn118,
            ultraGridColumn119,
            ultraGridColumn120,
            ultraGridColumn121,
            ultraGridColumn122});
            appearance17.FontData.BoldAsString = "True";
            appearance17.FontData.SizeInPoints = 11F;
            appearance17.TextHAlignAsString = "Left";
            ultraGridBand4.Header.Appearance = appearance17;
            ultraGridBand4.Header.Caption = "Afiliados";
            ultraGridBand4.HeaderVisible = true;
            ultraGridBand4.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn123.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn123.Header.Caption = "Tipo";
            ultraGridColumn123.Header.VisiblePosition = 1;
            ultraGridColumn123.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn123.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn123.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(98, 0);
            ultraGridColumn123.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(98, 0);
            ultraGridColumn123.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn123.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn123.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn123.Width = 83;
            ultraGridColumn124.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn124.Header.VisiblePosition = 2;
            ultraGridColumn124.Hidden = true;
            ultraGridColumn124.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn124.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn124.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(64, 0);
            ultraGridColumn124.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn124.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn124.Width = 43;
            ultraGridColumn125.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn125.Header.VisiblePosition = 3;
            ultraGridColumn125.Hidden = true;
            ultraGridColumn125.RowLayoutColumnInfo.OriginX = 22;
            ultraGridColumn125.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn125.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn125.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn125.Width = 55;
            ultraGridColumn126.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn126.Header.VisiblePosition = 4;
            ultraGridColumn126.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn126.MaskInput = "dd/mm/yyyy";
            ultraGridColumn126.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn126.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn126.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(78, 0);
            ultraGridColumn126.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(78, 0);
            ultraGridColumn126.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn126.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn126.Width = 73;
            ultraGridColumn127.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn127.Header.Caption = "Fecha Final";
            ultraGridColumn127.Header.VisiblePosition = 5;
            ultraGridColumn127.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn127.MaskInput = "dd/mm/yyyy";
            ultraGridColumn127.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null;
            ultraGridColumn127.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn127.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn127.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(77, 0);
            ultraGridColumn127.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(77, 0);
            ultraGridColumn127.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn127.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn127.Width = 71;
            ultraGridColumn128.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn128.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn128.Header.Caption = "Registrada";
            ultraGridColumn128.Header.VisiblePosition = 6;
            ultraGridColumn128.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            ultraGridColumn128.MaskInput = "dd/mm/yyyy hh:mm";
            ultraGridColumn128.RowLayoutColumnInfo.OriginX = 32;
            ultraGridColumn128.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn128.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(123, 0);
            ultraGridColumn128.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(123, 0);
            ultraGridColumn128.RowLayoutColumnInfo.SpanX = 7;
            ultraGridColumn128.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn128.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn128.Width = 84;
            ultraGridColumn129.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn129.Header.Caption = "Vendedor";
            ultraGridColumn129.Header.VisiblePosition = 7;
            ultraGridColumn129.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn129.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn129.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(115, 0);
            ultraGridColumn129.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(115, 0);
            ultraGridColumn129.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn129.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn129.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn129.Width = 61;
            ultraGridColumn130.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn130.Header.Caption = "Motivo de Baja";
            ultraGridColumn130.Header.VisiblePosition = 8;
            ultraGridColumn130.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null;
            ultraGridColumn130.RowLayoutColumnInfo.OriginX = 14;
            ultraGridColumn130.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn130.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(115, 0);
            ultraGridColumn130.RowLayoutColumnInfo.SpanX = 6;
            ultraGridColumn130.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn130.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn130.Width = 78;
            ultraGridColumn131.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn131.Header.Caption = "Tomador de Baja";
            ultraGridColumn131.Header.VisiblePosition = 9;
            ultraGridColumn131.RowLayoutColumnInfo.OriginX = 20;
            ultraGridColumn131.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn131.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(117, 0);
            ultraGridColumn131.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(117, 0);
            ultraGridColumn131.RowLayoutColumnInfo.SpanX = 12;
            ultraGridColumn131.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn131.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn132.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn132.Header.VisiblePosition = 10;
            ultraGridColumn132.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn132.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn132.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(502, 0);
            ultraGridColumn132.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(502, 0);
            ultraGridColumn132.RowLayoutColumnInfo.SpanX = 30;
            ultraGridColumn132.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn132.Width = 59;
            ultraGridColumn133.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn133.Header.Caption = "Renovación";
            ultraGridColumn133.Header.VisiblePosition = 11;
            ultraGridColumn133.Hidden = true;
            ultraGridColumn133.RowLayoutColumnInfo.OriginX = 3;
            ultraGridColumn133.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn133.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(83, 0);
            ultraGridColumn133.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(83, 0);
            ultraGridColumn133.RowLayoutColumnInfo.SpanX = 7;
            ultraGridColumn133.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn134.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn134.DefaultCellValue = "False";
            ultraGridColumn134.Header.Caption = "Cambio de Plan";
            ultraGridColumn134.Header.VisiblePosition = 12;
            ultraGridColumn134.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn134.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn134.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(98, 0);
            ultraGridColumn134.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(98, 0);
            ultraGridColumn134.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn134.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn135.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn135.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn135.Header.Caption = "Grabador";
            ultraGridColumn135.Header.VisiblePosition = 13;
            ultraGridColumn135.RowLayoutColumnInfo.OriginX = 32;
            ultraGridColumn135.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn135.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(123, 0);
            ultraGridColumn135.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(123, 0);
            ultraGridColumn135.RowLayoutColumnInfo.SpanX = 7;
            ultraGridColumn135.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn135.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit;
            ultraGridColumn136.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn136.Header.VisiblePosition = 0;
            ultraGridColumn136.Hidden = true;
            ultraGridColumn136.RowLayoutColumnInfo.OriginX = 24;
            ultraGridColumn136.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn136.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn136.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn136.Width = 37;
            ultraGridColumn137.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn137.Header.VisiblePosition = 14;
            ultraGridColumn137.Hidden = true;
            ultraGridBand5.Columns.AddRange(new object[] {
            ultraGridColumn123,
            ultraGridColumn124,
            ultraGridColumn125,
            ultraGridColumn126,
            ultraGridColumn127,
            ultraGridColumn128,
            ultraGridColumn129,
            ultraGridColumn130,
            ultraGridColumn131,
            ultraGridColumn132,
            ultraGridColumn133,
            ultraGridColumn134,
            ultraGridColumn135,
            ultraGridColumn136,
            ultraGridColumn137});
            appearance18.FontData.BoldAsString = "True";
            appearance18.FontData.SizeInPoints = 11F;
            appearance18.TextHAlignAsString = "Left";
            ultraGridBand5.Header.Appearance = appearance18;
            ultraGridBand5.Header.Caption = "Solicitudes";
            ultraGridBand5.HeaderVisible = true;
            ultraGridBand5.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand5.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand5.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand6.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand6.CardSettings.ShowCaption = false;
            ultraGridBand6.CardView = true;
            ultraGridColumn138.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn138.Header.VisiblePosition = 0;
            ultraGridColumn138.Hidden = true;
            ultraGridColumn138.Width = 111;
            ultraGridColumn139.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn139.Header.VisiblePosition = 1;
            ultraGridColumn139.Hidden = true;
            ultraGridColumn139.Width = 135;
            ultraGridColumn140.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn140.Header.Caption = "Plan";
            ultraGridColumn140.Header.VisiblePosition = 2;
            ultraGridColumn140.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(172, 0);
            ultraGridColumn140.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn140.Width = 266;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn138,
            ultraGridColumn139,
            ultraGridColumn140});
            appearance19.FontData.BoldAsString = "True";
            appearance19.FontData.SizeInPoints = 11F;
            appearance19.TextHAlignAsString = "Left";
            ultraGridBand6.Header.Appearance = appearance19;
            ultraGridBand6.Header.Caption = "Planes";
            ultraGridBand6.HeaderVisible = true;
            ultraGridBand6.MaxRows = 4;
            ultraGridBand6.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand6.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand6.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand7.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand7.CardSettings.ShowCaption = false;
            ultraGridBand7.CardView = true;
            ultraGridColumn141.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn141.Header.VisiblePosition = 0;
            ultraGridColumn141.Hidden = true;
            ultraGridColumn141.Width = 103;
            ultraGridColumn142.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn142.Header.VisiblePosition = 1;
            ultraGridColumn142.Width = 100;
            ultraGridColumn143.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn143.Header.VisiblePosition = 2;
            ultraGridColumn143.Hidden = true;
            ultraGridColumn143.Width = 121;
            ultraGridColumn144.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn144.Header.VisiblePosition = 3;
            ultraGridColumn144.Hidden = true;
            ultraGridColumn144.Width = 124;
            ultraGridColumn145.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn145.Header.VisiblePosition = 4;
            ultraGridColumn145.Hidden = true;
            ultraGridColumn145.Width = 107;
            ultraGridBand7.Columns.AddRange(new object[] {
            ultraGridColumn141,
            ultraGridColumn142,
            ultraGridColumn143,
            ultraGridColumn144,
            ultraGridColumn145});
            appearance20.FontData.BoldAsString = "True";
            appearance20.FontData.SizeInPoints = 11F;
            appearance20.TextHAlignAsString = "Left";
            ultraGridBand7.Header.Appearance = appearance20;
            ultraGridBand7.Header.Caption = "Tel. Afiliado";
            ultraGridBand7.HeaderVisible = true;
            ultraGridBand7.MaxRows = 4;
            ultraGridBand7.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand7.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn146.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn146.Header.VisiblePosition = 0;
            ultraGridColumn146.Hidden = true;
            ultraGridColumn146.Width = 31;
            ultraGridColumn147.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn147.Header.VisiblePosition = 1;
            ultraGridColumn147.Hidden = true;
            ultraGridColumn147.Width = 46;
            ultraGridColumn148.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn148.Header.VisiblePosition = 2;
            ultraGridColumn148.Hidden = true;
            ultraGridColumn148.Width = 56;
            ultraGridColumn149.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn149.Header.Caption = "Calle";
            ultraGridColumn149.Header.VisiblePosition = 3;
            ultraGridColumn149.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn149.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn149.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(132, 0);
            ultraGridColumn149.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(38, 0);
            ultraGridColumn149.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn149.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn149.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn149.Width = 46;
            ultraGridColumn150.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn150.Header.Caption = "Número";
            ultraGridColumn150.Header.VisiblePosition = 4;
            ultraGridColumn150.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn150.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn150.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(64, 0);
            ultraGridColumn150.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(52, 0);
            ultraGridColumn150.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn150.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn150.Width = 79;
            ultraGridColumn151.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn151.Header.VisiblePosition = 5;
            ultraGridColumn151.RowLayoutColumnInfo.OriginX = 6;
            ultraGridColumn151.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn151.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(45, 0);
            ultraGridColumn151.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(34, 0);
            ultraGridColumn151.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn151.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn151.Width = 79;
            ultraGridColumn152.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn152.Header.Caption = "Depto.";
            ultraGridColumn152.Header.VisiblePosition = 6;
            ultraGridColumn152.RowLayoutColumnInfo.OriginX = 8;
            ultraGridColumn152.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn152.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(59, 0);
            ultraGridColumn152.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(46, 0);
            ultraGridColumn152.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn152.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn152.Width = 79;
            ultraGridColumn153.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn153.Header.Caption = "entre";
            ultraGridColumn153.Header.VisiblePosition = 7;
            ultraGridColumn153.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn153.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn153.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(132, 0);
            ultraGridColumn153.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(38, 0);
            ultraGridColumn153.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn153.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn153.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn153.Width = 67;
            ultraGridColumn154.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn154.Header.Caption = "y";
            ultraGridColumn154.Header.VisiblePosition = 8;
            ultraGridColumn154.RowLayoutColumnInfo.OriginX = 2;
            ultraGridColumn154.RowLayoutColumnInfo.OriginY = 4;
            ultraGridColumn154.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(132, 0);
            ultraGridColumn154.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(18, 0);
            ultraGridColumn154.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn154.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn154.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn154.Width = 67;
            ultraGridColumn155.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn155.Header.Caption = "Zona";
            ultraGridColumn155.Header.VisiblePosition = 9;
            ultraGridColumn155.RowLayoutColumnInfo.OriginX = 10;
            ultraGridColumn155.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn155.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(60, 0);
            ultraGridColumn155.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(60, 0);
            ultraGridColumn155.RowLayoutColumnInfo.SpanX = 1;
            ultraGridColumn155.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn155.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn155.Width = 46;
            ultraGridColumn156.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn156.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn156.Header.VisiblePosition = 10;
            ultraGridColumn156.RowLayoutColumnInfo.OriginX = 4;
            ultraGridColumn156.RowLayoutColumnInfo.OriginY = 2;
            ultraGridColumn156.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(353, 36);
            ultraGridColumn156.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(88, 0);
            ultraGridColumn156.RowLayoutColumnInfo.SpanX = 8;
            ultraGridColumn156.RowLayoutColumnInfo.SpanY = 4;
            ultraGridColumn156.VertScrollBar = true;
            ultraGridColumn156.Width = 79;
            ultraGridColumn157.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn157.Header.VisiblePosition = 11;
            ultraGridColumn157.Hidden = true;
            ultraGridColumn157.Width = 33;
            ultraGridColumn158.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn158.Header.VisiblePosition = 12;
            ultraGridColumn158.Hidden = true;
            ultraGridColumn158.Width = 32;
            ultraGridColumn159.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn159.Header.VisiblePosition = 13;
            ultraGridColumn159.Hidden = true;
            ultraGridColumn159.Width = 34;
            ultraGridColumn160.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn160.Header.VisiblePosition = 14;
            ultraGridColumn160.Hidden = true;
            ultraGridColumn160.Width = 32;
            ultraGridColumn161.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn161.Header.Caption = "Barrio";
            ultraGridColumn161.Header.VisiblePosition = 15;
            ultraGridColumn161.RowLayoutColumnInfo.OriginX = 11;
            ultraGridColumn161.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn161.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(79, 0);
            ultraGridColumn161.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(42, 0);
            ultraGridColumn161.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn161.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn161.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn162.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn162.Header.VisiblePosition = 16;
            ultraGridColumn162.Hidden = true;
            ultraGridColumn163.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn163.Header.Caption = "Localidad";
            ultraGridColumn163.Header.VisiblePosition = 17;
            ultraGridColumn163.RowLayoutColumnInfo.OriginX = 0;
            ultraGridColumn163.RowLayoutColumnInfo.OriginY = 0;
            ultraGridColumn163.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(151, 0);
            ultraGridColumn163.RowLayoutColumnInfo.PreferredLabelSize = new System.Drawing.Size(151, 0);
            ultraGridColumn163.RowLayoutColumnInfo.SpanX = 2;
            ultraGridColumn163.RowLayoutColumnInfo.SpanY = 2;
            ultraGridColumn163.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
            ultraGridColumn164.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn164.Header.VisiblePosition = 18;
            ultraGridBand8.Columns.AddRange(new object[] {
            ultraGridColumn146,
            ultraGridColumn147,
            ultraGridColumn148,
            ultraGridColumn149,
            ultraGridColumn150,
            ultraGridColumn151,
            ultraGridColumn152,
            ultraGridColumn153,
            ultraGridColumn154,
            ultraGridColumn155,
            ultraGridColumn156,
            ultraGridColumn157,
            ultraGridColumn158,
            ultraGridColumn159,
            ultraGridColumn160,
            ultraGridColumn161,
            ultraGridColumn162,
            ultraGridColumn163,
            ultraGridColumn164});
            appearance21.FontData.BoldAsString = "True";
            appearance21.FontData.SizeInPoints = 11F;
            appearance21.TextHAlignAsString = "Left";
            ultraGridBand8.Header.Appearance = appearance21;
            ultraGridBand8.Header.Caption = "Dirección del Afiliado (Sólo si no es la del Grupo)";
            ultraGridBand8.HeaderVisible = true;
            ultraGridBand8.MaxRows = 1;
            ultraGridBand8.RowLayoutLabelStyle = Infragistics.Win.UltraWinGrid.RowLayoutLabelStyle.WithCellData;
            ultraGridBand8.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridBand9.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand9.CardSettings.ShowCaption = false;
            ultraGridBand9.CardView = true;
            ultraGridColumn165.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn165.Header.VisiblePosition = 0;
            ultraGridColumn165.Hidden = true;
            ultraGridColumn165.Width = 126;
            ultraGridColumn166.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn166.Header.VisiblePosition = 1;
            ultraGridColumn166.RowLayoutColumnInfo.PreferredCellSize = new System.Drawing.Size(110, 0);
            ultraGridColumn166.Width = 100;
            ultraGridColumn167.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn167.Header.VisiblePosition = 2;
            ultraGridColumn167.Hidden = true;
            ultraGridColumn167.Width = 135;
            ultraGridColumn168.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn168.Header.VisiblePosition = 3;
            ultraGridColumn168.Hidden = true;
            ultraGridColumn168.Width = 134;
            ultraGridColumn169.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn169.Header.VisiblePosition = 4;
            ultraGridColumn169.Hidden = true;
            ultraGridColumn169.Width = 110;
            ultraGridBand9.Columns.AddRange(new object[] {
            ultraGridColumn165,
            ultraGridColumn166,
            ultraGridColumn167,
            ultraGridColumn168,
            ultraGridColumn169});
            appearance22.FontData.BoldAsString = "True";
            appearance22.FontData.SizeInPoints = 11F;
            ultraGridBand9.Header.Appearance = appearance22;
            ultraGridBand9.Header.Caption = "Tel.Dir.Afil.";
            ultraGridBand9.HeaderVisible = true;
            ultraGridBand9.MaxRows = 5;
            ultraGridBand9.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand9.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn170.Header.VisiblePosition = 0;
            ultraGridColumn170.Hidden = true;
            ultraGridColumn170.Width = 211;
            ultraGridColumn171.Header.VisiblePosition = 1;
            ultraGridColumn171.Width = 275;
            ultraGridColumn172.Header.VisiblePosition = 2;
            ultraGridColumn172.Hidden = true;
            ultraGridColumn172.Width = 218;
            ultraGridBand10.Columns.AddRange(new object[] {
            ultraGridColumn170,
            ultraGridColumn171,
            ultraGridColumn172});
            appearance23.FontData.BoldAsString = "True";
            appearance23.FontData.SizeInPoints = 11F;
            appearance23.TextHAlignAsString = "Left";
            ultraGridBand10.Header.Appearance = appearance23;
            ultraGridBand10.Header.Caption = "e_mail del Afiliado";
            ultraGridBand10.HeaderVisible = true;
            ultraGridColumn173.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn173.Header.VisiblePosition = 0;
            ultraGridColumn173.Hidden = true;
            ultraGridColumn173.Width = 107;
            ultraGridColumn174.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn174.Header.VisiblePosition = 1;
            ultraGridColumn174.Width = 294;
            ultraGridColumn175.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn175.Header.VisiblePosition = 2;
            ultraGridColumn175.Width = 409;
            ultraGridColumn176.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn176.Header.VisiblePosition = 3;
            ultraGridColumn176.Hidden = true;
            ultraGridColumn176.Width = 104;
            ultraGridColumn177.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn177.Header.VisiblePosition = 4;
            ultraGridColumn177.Hidden = true;
            ultraGridColumn177.Width = 103;
            ultraGridColumn178.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn178.Header.VisiblePosition = 5;
            ultraGridColumn178.Hidden = true;
            ultraGridColumn178.Width = 103;
            ultraGridColumn179.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn179.Header.VisiblePosition = 6;
            ultraGridColumn180.Header.VisiblePosition = 7;
            ultraGridBand11.Columns.AddRange(new object[] {
            ultraGridColumn173,
            ultraGridColumn174,
            ultraGridColumn175,
            ultraGridColumn176,
            ultraGridColumn177,
            ultraGridColumn178,
            ultraGridColumn179,
            ultraGridColumn180});
            appearance24.FontData.BoldAsString = "True";
            appearance24.FontData.SizeInPoints = 11F;
            appearance24.TextHAlignAsString = "Left";
            ultraGridBand11.Header.Appearance = appearance24;
            ultraGridBand11.Header.Caption = "En Caso de Emergencia Avisar a:";
            ultraGridBand11.HeaderVisible = true;
            ultraGridBand12.CardSettings.CardScrollbars = Infragistics.Win.UltraWinGrid.CardScrollbars.None;
            ultraGridBand12.CardSettings.ShowCaption = false;
            ultraGridBand12.CardView = true;
            ultraGridColumn181.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn181.Header.VisiblePosition = 0;
            ultraGridColumn181.Hidden = true;
            ultraGridColumn181.Width = 136;
            ultraGridColumn182.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn182.Header.VisiblePosition = 1;
            ultraGridColumn182.Width = 100;
            ultraGridColumn183.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn183.Header.VisiblePosition = 2;
            ultraGridColumn183.Hidden = true;
            ultraGridColumn183.Width = 134;
            ultraGridColumn184.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn184.Header.VisiblePosition = 3;
            ultraGridColumn184.Hidden = true;
            ultraGridColumn184.Width = 136;
            ultraGridColumn185.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn185.Header.VisiblePosition = 4;
            ultraGridColumn185.Hidden = true;
            ultraGridColumn185.Width = 118;
            ultraGridBand12.Columns.AddRange(new object[] {
            ultraGridColumn181,
            ultraGridColumn182,
            ultraGridColumn183,
            ultraGridColumn184,
            ultraGridColumn185});
            appearance194.FontData.BoldAsString = "True";
            appearance194.FontData.SizeInPoints = 11F;
            ultraGridBand12.Header.Appearance = appearance194;
            ultraGridBand12.Header.Caption = "Tel. Emergencia";
            ultraGridBand12.HeaderVisible = true;
            ultraGridBand12.MaxRows = 5;
            ultraGridBand12.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None;
            ultraGridBand12.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            ultraGridColumn186.Header.VisiblePosition = 0;
            ultraGridColumn187.Header.VisiblePosition = 1;
            ultraGridColumn188.Header.VisiblePosition = 2;
            ultraGridBand13.Columns.AddRange(new object[] {
            ultraGridColumn186,
            ultraGridColumn187,
            ultraGridColumn188});
            ultraGridColumn189.Header.VisiblePosition = 0;
            ultraGridColumn190.Header.VisiblePosition = 1;
            ultraGridColumn191.Header.VisiblePosition = 2;
            ultraGridBand14.Columns.AddRange(new object[] {
            ultraGridColumn189,
            ultraGridColumn190,
            ultraGridColumn191});
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand5);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand7);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand8);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand9);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand10);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand11);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand12);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand13);
            this.gruposUltraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand14);
            this.gruposUltraGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.gruposUltraGrid.DisplayLayout.InterBandSpacing = 10;
            this.gruposUltraGrid.DisplayLayout.MaxBandDepth = 5;
            appearance25.BackColor = System.Drawing.SystemColors.Window;
            this.gruposUltraGrid.DisplayLayout.Override.ActiveCellAppearance = appearance25;
            appearance26.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance26.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance26.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gruposUltraGrid.DisplayLayout.Override.ActiveRowAppearance = appearance26;
            this.gruposUltraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.gruposUltraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.gruposUltraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.gruposUltraGrid.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.gruposUltraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.gruposUltraGrid.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.gruposUltraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance27.BackColor = System.Drawing.Color.Transparent;
            this.gruposUltraGrid.DisplayLayout.Override.CardAreaAppearance = appearance27;
            appearance28.BackColor = System.Drawing.SystemColors.Control;
            appearance28.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.gruposUltraGrid.DisplayLayout.Override.CellAppearance = appearance28;
            this.gruposUltraGrid.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance29.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance29.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance29.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.gruposUltraGrid.DisplayLayout.Override.HeaderAppearance = appearance29;
            this.gruposUltraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance30.ForeColor = System.Drawing.Color.Red;
            this.gruposUltraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance30;
            this.gruposUltraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.gruposUltraGrid.DisplayLayout.Override.SelectedCellAppearance = appearance31;
            appearance32.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance32.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.gruposUltraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance32;
            appearance33.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.gruposUltraGrid.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance33;
            this.gruposUltraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gruposUltraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.gruposUltraGrid.DisplayLayout.UseFixedHeaders = true;
            this.gruposUltraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.gruposUltraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gruposUltraGrid.Location = new System.Drawing.Point(-3, 2);
            this.gruposUltraGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gruposUltraGrid.Name = "gruposUltraGrid";
            this.gruposUltraGrid.Size = new System.Drawing.Size(1175, 678);
            this.gruposUltraGrid.TabIndex = 2;
            this.gruposUltraGrid.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.GruposUltraGridAfterCellUpdate);
            this.gruposUltraGrid.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.GruposUltraGridInitializeRow);
            this.gruposUltraGrid.AfterEnterEditMode += new System.EventHandler(this.GruposUltraGridAfterEnterEditMode);
            this.gruposUltraGrid.AfterRowActivate += new System.EventHandler(this.GruposUltraGridAfterRowActivate);
            this.gruposUltraGrid.AfterRowsDeleted += new System.EventHandler(this.GruposUltraGridAfterRowsDeleted);
            this.gruposUltraGrid.AfterRowUpdate += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.GruposUltraGridAfterRowUpdate);
            this.gruposUltraGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.GruposUltraGridCellChange);
            this.gruposUltraGrid.BeforeCellDeactivate += new System.ComponentModel.CancelEventHandler(this.GruposUltraGridBeforeCellDeactivate);
            this.gruposUltraGrid.BeforeExitEditMode += new Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventHandler(this.GruposUltraGridBeforeExitEditMode);
            this.gruposUltraGrid.BeforeRowDeactivate += new System.ComponentModel.CancelEventHandler(this.GruposUltraGridBeforeRowDeactivate);
            this.gruposUltraGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gruposUltraGrid_KeyDown);
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            this.gruposBindingSource.DataSource = this.dsAfiliados;
            // 
            // dsAfiliados
            // 
            this.dsAfiliados.DataSetName = "DsAfiliados";
            this.dsAfiliados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(936, 20);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(100, 28);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Visible = false;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalirClick);
            // 
            // ultraDropDownPlanes
            // 
            this.ultraDropDownPlanes.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPlanes.DataSource = this.planesBindingSource;
            appearance184.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance184.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance184.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPlanes.DisplayLayout.Appearance = appearance184;
            this.ultraDropDownPlanes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand35.ColHeadersVisible = false;
            ultraGridColumn301.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn301.Header.VisiblePosition = 0;
            ultraGridColumn301.Hidden = true;
            ultraGridColumn301.Width = 64;
            ultraGridColumn302.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn302.Header.VisiblePosition = 1;
            ultraGridColumn302.Width = 294;
            ultraGridColumn303.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn303.Header.VisiblePosition = 2;
            ultraGridColumn303.Hidden = true;
            ultraGridColumn303.Width = 49;
            ultraGridColumn304.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn304.Header.VisiblePosition = 3;
            ultraGridColumn304.Hidden = true;
            ultraGridColumn304.Width = 37;
            ultraGridColumn507.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn507.Header.VisiblePosition = 4;
            ultraGridColumn507.Hidden = true;
            ultraGridColumn507.Width = 65;
            ultraGridBand35.Columns.AddRange(new object[] {
            ultraGridColumn301,
            ultraGridColumn302,
            ultraGridColumn303,
            ultraGridColumn304,
            ultraGridColumn507});
            this.ultraDropDownPlanes.DisplayLayout.BandsSerializer.Add(ultraGridBand35);
            this.ultraDropDownPlanes.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPlanes.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPlanes.DisplayLayout.MaxBandDepth = 5;
            appearance185.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveCellAppearance = appearance185;
            appearance186.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance186.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance186.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance186.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPlanes.DisplayLayout.Override.ActiveRowAppearance = appearance186;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPlanes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance187.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.CardAreaAppearance = appearance187;
            appearance188.BackColor = System.Drawing.SystemColors.Control;
            appearance188.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance188.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.CellAppearance = appearance188;
            this.ultraDropDownPlanes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance189.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance189.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance189.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance189.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance189.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderAppearance = appearance189;
            this.ultraDropDownPlanes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance190.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSelectorAppearance = appearance190;
            this.ultraDropDownPlanes.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance191.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedCellAppearance = appearance191;
            appearance192.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance192.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance192.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanes.DisplayLayout.Override.SelectedRowAppearance = appearance192;
            appearance193.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance193.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPlanes.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance193;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPlanes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPlanes.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPlanes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPlanes.DisplayMember = "Nombre";
            this.ultraDropDownPlanes.Location = new System.Drawing.Point(72, 436);
            this.ultraDropDownPlanes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownPlanes.Name = "ultraDropDownPlanes";
            this.ultraDropDownPlanes.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownPlanes.TabIndex = 4;
            this.ultraDropDownPlanes.ValueMember = "idPlan";
            this.ultraDropDownPlanes.Visible = false;
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
            // ultraDropDownCalle
            // 
            this.ultraDropDownCalle.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownCalle.DataSource = this.bindingSourceCalle;
            appearance174.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance174.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance174.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownCalle.DisplayLayout.Appearance = appearance174;
            this.ultraDropDownCalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand34.ColHeadersVisible = false;
            ultraGridColumn297.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn297.Header.VisiblePosition = 0;
            ultraGridColumn297.Hidden = true;
            ultraGridColumn297.Width = 39;
            ultraGridColumn298.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn298.Header.VisiblePosition = 1;
            ultraGridColumn298.Hidden = true;
            ultraGridColumn298.Width = 231;
            ultraGridColumn299.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn299.Header.VisiblePosition = 2;
            ultraGridColumn299.Hidden = true;
            ultraGridColumn299.Width = 51;
            ultraGridColumn300.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn300.Header.VisiblePosition = 3;
            ultraGridColumn300.Width = 227;
            ultraGridBand34.Columns.AddRange(new object[] {
            ultraGridColumn297,
            ultraGridColumn298,
            ultraGridColumn299,
            ultraGridColumn300});
            this.ultraDropDownCalle.DisplayLayout.BandsSerializer.Add(ultraGridBand34);
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
            this.ultraDropDownCalle.Location = new System.Drawing.Point(397, 235);
            this.ultraDropDownCalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownCalle.Name = "ultraDropDownCalle";
            this.ultraDropDownCalle.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownCalle.TabIndex = 8;
            this.ultraDropDownCalle.ValueMember = "idCalle";
            this.ultraDropDownCalle.Visible = false;
            this.ultraDropDownCalle.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownCalleFilterRow);
            // 
            // bindingSourceCalle
            // 
            this.bindingSourceCalle.DataMember = "Calles";
            this.bindingSourceCalle.DataSource = this.dsCallesLista;
            // 
            // dsCallesLista
            // 
            this.dsCallesLista.DataSetName = "DsCallesLista";
            this.dsCallesLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownTipoDeCobranza
            // 
            this.ultraDropDownTipoDeCobranza.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTipoDeCobranza.DataSource = this.tiposDeCobranzaBindingSource;
            appearance164.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance164.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance164.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Appearance = appearance164;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand33.ColHeadersVisible = false;
            ultraGridColumn292.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn292.Header.VisiblePosition = 0;
            ultraGridColumn292.Hidden = true;
            ultraGridColumn292.Width = 27;
            ultraGridColumn293.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn293.Header.VisiblePosition = 1;
            ultraGridColumn293.Width = 127;
            ultraGridColumn294.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn294.Header.VisiblePosition = 2;
            ultraGridColumn294.Hidden = true;
            ultraGridColumn294.Width = 41;
            ultraGridColumn295.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn295.Header.VisiblePosition = 3;
            ultraGridColumn295.Hidden = true;
            ultraGridColumn295.Width = 38;
            ultraGridColumn296.Header.VisiblePosition = 4;
            ultraGridColumn296.Hidden = true;
            ultraGridColumn296.Width = 66;
            ultraGridBand33.Columns.AddRange(new object[] {
            ultraGridColumn292,
            ultraGridColumn293,
            ultraGridColumn294,
            ultraGridColumn295,
            ultraGridColumn296});
            this.ultraDropDownTipoDeCobranza.DisplayLayout.BandsSerializer.Add(ultraGridBand33);
            this.ultraDropDownTipoDeCobranza.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.MaxBandDepth = 5;
            appearance165.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.ActiveCellAppearance = appearance165;
            appearance166.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance166.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance166.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance166.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.ActiveRowAppearance = appearance166;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance167.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.CardAreaAppearance = appearance167;
            appearance168.BackColor = System.Drawing.SystemColors.Control;
            appearance168.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance168.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.CellAppearance = appearance168;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance169.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance169.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance169.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance169.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance169.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.HeaderAppearance = appearance169;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance170.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.RowSelectorAppearance = appearance170;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance171.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.SelectedCellAppearance = appearance171;
            appearance172.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance172.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance172.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.SelectedRowAppearance = appearance172;
            appearance173.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance173.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance173;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTipoDeCobranza.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTipoDeCobranza.DisplayMember = "Nombre";
            this.ultraDropDownTipoDeCobranza.DropDownWidth = 150;
            this.ultraDropDownTipoDeCobranza.Location = new System.Drawing.Point(395, 286);
            this.ultraDropDownTipoDeCobranza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownTipoDeCobranza.Name = "ultraDropDownTipoDeCobranza";
            this.ultraDropDownTipoDeCobranza.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownTipoDeCobranza.TabIndex = 10;
            this.ultraDropDownTipoDeCobranza.ValueMember = "idTipoDeCobranza";
            this.ultraDropDownTipoDeCobranza.Visible = false;
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
            // ultraDropDownEntidadDeCobranza
            // 
            this.ultraDropDownEntidadDeCobranza.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownEntidadDeCobranza.DataSource = this.entidadesDeCobranzaBindingSource;
            appearance154.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance154.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance154.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Appearance = appearance154;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand32.ColHeadersVisible = false;
            ultraGridColumn277.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn277.Header.VisiblePosition = 0;
            ultraGridColumn277.Hidden = true;
            ultraGridColumn277.Width = 25;
            ultraGridColumn278.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn278.Header.VisiblePosition = 1;
            ultraGridColumn278.Width = 227;
            ultraGridColumn279.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn279.Header.VisiblePosition = 2;
            ultraGridColumn279.Hidden = true;
            ultraGridColumn279.Width = 23;
            ultraGridColumn280.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn280.Header.VisiblePosition = 3;
            ultraGridColumn280.Hidden = true;
            ultraGridColumn280.Width = 23;
            ultraGridColumn281.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn281.Header.VisiblePosition = 4;
            ultraGridColumn281.Hidden = true;
            ultraGridColumn281.Width = 24;
            ultraGridColumn282.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn282.Header.VisiblePosition = 5;
            ultraGridColumn282.Hidden = true;
            ultraGridColumn282.Width = 29;
            ultraGridColumn283.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn283.Header.VisiblePosition = 6;
            ultraGridColumn283.Hidden = true;
            ultraGridColumn283.Width = 31;
            ultraGridColumn284.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn284.Header.VisiblePosition = 7;
            ultraGridColumn284.Hidden = true;
            ultraGridColumn284.Width = 27;
            ultraGridColumn285.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn285.Header.VisiblePosition = 8;
            ultraGridColumn285.Hidden = true;
            ultraGridColumn285.Width = 26;
            ultraGridColumn286.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn286.Header.VisiblePosition = 9;
            ultraGridColumn286.Hidden = true;
            ultraGridColumn286.Width = 73;
            ultraGridColumn287.Header.VisiblePosition = 10;
            ultraGridColumn287.Hidden = true;
            ultraGridColumn287.Width = 36;
            ultraGridColumn288.Header.VisiblePosition = 11;
            ultraGridColumn288.Hidden = true;
            ultraGridColumn288.Width = 35;
            ultraGridColumn289.Header.VisiblePosition = 12;
            ultraGridColumn289.Hidden = true;
            ultraGridColumn289.Width = 35;
            ultraGridColumn290.Header.VisiblePosition = 13;
            ultraGridColumn290.Hidden = true;
            ultraGridColumn290.Width = 34;
            ultraGridColumn291.Header.VisiblePosition = 14;
            ultraGridColumn291.Hidden = true;
            ultraGridColumn291.Width = 19;
            ultraGridBand32.Columns.AddRange(new object[] {
            ultraGridColumn277,
            ultraGridColumn278,
            ultraGridColumn279,
            ultraGridColumn280,
            ultraGridColumn281,
            ultraGridColumn282,
            ultraGridColumn283,
            ultraGridColumn284,
            ultraGridColumn285,
            ultraGridColumn286,
            ultraGridColumn287,
            ultraGridColumn288,
            ultraGridColumn289,
            ultraGridColumn290,
            ultraGridColumn291});
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.BandsSerializer.Add(ultraGridBand32);
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.MaxBandDepth = 5;
            appearance155.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.ActiveCellAppearance = appearance155;
            appearance156.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance156.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance156.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance156.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.ActiveRowAppearance = appearance156;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance157.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.CardAreaAppearance = appearance157;
            appearance158.BackColor = System.Drawing.SystemColors.Control;
            appearance158.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance158.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.CellAppearance = appearance158;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance159.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance159.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance159.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance159.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance159.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.HeaderAppearance = appearance159;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance160.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.RowSelectorAppearance = appearance160;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance161.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.SelectedCellAppearance = appearance161;
            appearance162.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance162.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance162.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.SelectedRowAppearance = appearance162;
            appearance163.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance163.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance163;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownEntidadDeCobranza.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownEntidadDeCobranza.DisplayMember = "Nombre";
            this.ultraDropDownEntidadDeCobranza.DropDownWidth = 250;
            this.ultraDropDownEntidadDeCobranza.Location = new System.Drawing.Point(397, 336);
            this.ultraDropDownEntidadDeCobranza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownEntidadDeCobranza.Name = "ultraDropDownEntidadDeCobranza";
            this.ultraDropDownEntidadDeCobranza.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownEntidadDeCobranza.TabIndex = 11;
            this.ultraDropDownEntidadDeCobranza.ValueMember = "idEntidadDeCobranza";
            this.ultraDropDownEntidadDeCobranza.Visible = false;
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
            // ultraDropDownTiposDeDocumento
            // 
            this.ultraDropDownTiposDeDocumento.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTiposDeDocumento.DataSource = this.tiposDeDocumentoBindingSource;
            appearance144.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance144.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance144.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.Appearance = appearance144;
            this.ultraDropDownTiposDeDocumento.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand31.ColHeadersVisible = false;
            ultraGridColumn274.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn274.Header.VisiblePosition = 0;
            ultraGridColumn274.Hidden = true;
            ultraGridColumn274.Width = 85;
            ultraGridColumn275.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn275.Header.VisiblePosition = 1;
            ultraGridColumn275.Hidden = true;
            ultraGridColumn275.Width = 231;
            ultraGridColumn276.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn276.Header.VisiblePosition = 2;
            ultraGridColumn276.Width = 227;
            ultraGridBand31.Columns.AddRange(new object[] {
            ultraGridColumn274,
            ultraGridColumn275,
            ultraGridColumn276});
            this.ultraDropDownTiposDeDocumento.DisplayLayout.BandsSerializer.Add(ultraGridBand31);
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
            this.ultraDropDownTiposDeDocumento.Location = new System.Drawing.Point(397, 386);
            this.ultraDropDownTiposDeDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownTiposDeDocumento.Name = "ultraDropDownTiposDeDocumento";
            this.ultraDropDownTiposDeDocumento.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownTiposDeDocumento.TabIndex = 12;
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
            // ultraDropDownLugarDeInternacion
            // 
            this.ultraDropDownLugarDeInternacion.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownLugarDeInternacion.DataSource = this.lugaresBindingSource;
            appearance134.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance134.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Appearance = appearance134;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand26.ColHeadersVisible = false;
            ultraGridColumn238.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn238.Header.VisiblePosition = 0;
            ultraGridColumn238.Hidden = true;
            ultraGridColumn238.Width = 51;
            ultraGridColumn239.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn239.Header.VisiblePosition = 1;
            ultraGridColumn239.Width = 227;
            ultraGridColumn240.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn240.Header.VisiblePosition = 2;
            ultraGridColumn240.Hidden = true;
            ultraGridColumn240.Width = 90;
            ultraGridColumn241.Header.VisiblePosition = 3;
            ultraGridColumn241.Hidden = true;
            ultraGridColumn241.Width = 55;
            ultraGridColumn242.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn242.Header.VisiblePosition = 4;
            ultraGridColumn243.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn243.Header.VisiblePosition = 5;
            ultraGridBand26.Columns.AddRange(new object[] {
            ultraGridColumn238,
            ultraGridColumn239,
            ultraGridColumn240,
            ultraGridColumn241,
            ultraGridColumn242,
            ultraGridColumn243});
            ultraGridColumn244.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn244.Header.VisiblePosition = 0;
            ultraGridColumn245.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn245.Header.VisiblePosition = 1;
            ultraGridColumn246.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn246.Header.VisiblePosition = 2;
            ultraGridColumn247.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn247.Header.VisiblePosition = 3;
            ultraGridColumn248.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn248.Header.VisiblePosition = 4;
            ultraGridColumn249.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn249.Header.VisiblePosition = 5;
            ultraGridColumn250.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn250.Header.VisiblePosition = 6;
            ultraGridColumn251.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn251.Header.VisiblePosition = 7;
            ultraGridColumn252.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn252.Header.VisiblePosition = 8;
            ultraGridColumn253.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn253.Header.VisiblePosition = 10;
            ultraGridColumn254.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn254.Header.VisiblePosition = 11;
            ultraGridColumn255.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn255.Header.VisiblePosition = 9;
            ultraGridColumn256.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn256.Header.VisiblePosition = 12;
            ultraGridBand27.Columns.AddRange(new object[] {
            ultraGridColumn244,
            ultraGridColumn245,
            ultraGridColumn246,
            ultraGridColumn247,
            ultraGridColumn248,
            ultraGridColumn249,
            ultraGridColumn250,
            ultraGridColumn251,
            ultraGridColumn252,
            ultraGridColumn253,
            ultraGridColumn254,
            ultraGridColumn255,
            ultraGridColumn256});
            ultraGridColumn257.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn257.Header.VisiblePosition = 0;
            ultraGridColumn258.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn258.Header.VisiblePosition = 1;
            ultraGridColumn259.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn259.Header.VisiblePosition = 2;
            ultraGridColumn260.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn260.Header.VisiblePosition = 3;
            ultraGridColumn261.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn261.Header.VisiblePosition = 4;
            ultraGridBand28.Columns.AddRange(new object[] {
            ultraGridColumn257,
            ultraGridColumn258,
            ultraGridColumn259,
            ultraGridColumn260,
            ultraGridColumn261});
            ultraGridColumn262.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn262.Header.VisiblePosition = 0;
            ultraGridColumn263.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn263.Header.VisiblePosition = 1;
            ultraGridColumn264.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn264.Header.VisiblePosition = 2;
            ultraGridColumn265.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn265.Header.VisiblePosition = 3;
            ultraGridColumn266.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn266.Header.VisiblePosition = 4;
            ultraGridColumn267.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn267.Header.VisiblePosition = 5;
            ultraGridColumn268.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn268.Header.VisiblePosition = 6;
            ultraGridBand29.Columns.AddRange(new object[] {
            ultraGridColumn262,
            ultraGridColumn263,
            ultraGridColumn264,
            ultraGridColumn265,
            ultraGridColumn266,
            ultraGridColumn267,
            ultraGridColumn268});
            ultraGridColumn269.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn269.Header.VisiblePosition = 0;
            ultraGridColumn270.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn270.Header.VisiblePosition = 1;
            ultraGridColumn271.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn271.Header.VisiblePosition = 2;
            ultraGridColumn272.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn272.Header.VisiblePosition = 3;
            ultraGridColumn273.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn273.Header.VisiblePosition = 4;
            ultraGridBand30.Columns.AddRange(new object[] {
            ultraGridColumn269,
            ultraGridColumn270,
            ultraGridColumn271,
            ultraGridColumn272,
            ultraGridColumn273});
            this.ultraDropDownLugarDeInternacion.DisplayLayout.BandsSerializer.Add(ultraGridBand26);
            this.ultraDropDownLugarDeInternacion.DisplayLayout.BandsSerializer.Add(ultraGridBand27);
            this.ultraDropDownLugarDeInternacion.DisplayLayout.BandsSerializer.Add(ultraGridBand28);
            this.ultraDropDownLugarDeInternacion.DisplayLayout.BandsSerializer.Add(ultraGridBand29);
            this.ultraDropDownLugarDeInternacion.DisplayLayout.BandsSerializer.Add(ultraGridBand30);
            this.ultraDropDownLugarDeInternacion.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.MaxBandDepth = 5;
            appearance135.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.ActiveCellAppearance = appearance135;
            appearance136.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance136.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance136.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.ActiveRowAppearance = appearance136;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance137.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.CardAreaAppearance = appearance137;
            appearance138.BackColor = System.Drawing.SystemColors.Control;
            appearance138.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance138.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.CellAppearance = appearance138;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance139.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance139.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance139.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance139.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance139.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.HeaderAppearance = appearance139;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance140.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.RowSelectorAppearance = appearance140;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance141.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.SelectedCellAppearance = appearance141;
            appearance142.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance142.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance142.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.SelectedRowAppearance = appearance142;
            appearance143.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance143.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance143;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownLugarDeInternacion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownLugarDeInternacion.DisplayMember = "Nombre";
            this.ultraDropDownLugarDeInternacion.DropDownWidth = 250;
            this.ultraDropDownLugarDeInternacion.Location = new System.Drawing.Point(397, 436);
            this.ultraDropDownLugarDeInternacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownLugarDeInternacion.Name = "ultraDropDownLugarDeInternacion";
            this.ultraDropDownLugarDeInternacion.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownLugarDeInternacion.TabIndex = 13;
            this.ultraDropDownLugarDeInternacion.ValueMember = "idLugar";
            this.ultraDropDownLugarDeInternacion.Visible = false;
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
            // ultraDropDownPrepagos
            // 
            this.ultraDropDownPrepagos.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPrepagos.DataSource = this.prepagosBindingSource;
            appearance124.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance124.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance124.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPrepagos.DisplayLayout.Appearance = appearance124;
            this.ultraDropDownPrepagos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand25.ColHeadersVisible = false;
            ultraGridColumn235.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn235.Header.VisiblePosition = 0;
            ultraGridColumn235.Hidden = true;
            ultraGridColumn235.Width = 57;
            ultraGridColumn236.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn236.Header.VisiblePosition = 1;
            ultraGridColumn236.Width = 227;
            ultraGridColumn237.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn237.Header.VisiblePosition = 2;
            ultraGridColumn237.Hidden = true;
            ultraGridColumn237.Width = 87;
            ultraGridBand25.Columns.AddRange(new object[] {
            ultraGridColumn235,
            ultraGridColumn236,
            ultraGridColumn237});
            this.ultraDropDownPrepagos.DisplayLayout.BandsSerializer.Add(ultraGridBand25);
            this.ultraDropDownPrepagos.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPrepagos.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPrepagos.DisplayLayout.MaxBandDepth = 5;
            appearance125.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveCellAppearance = appearance125;
            appearance126.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance126.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance126.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance126.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPrepagos.DisplayLayout.Override.ActiveRowAppearance = appearance126;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPrepagos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance127.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CardAreaAppearance = appearance127;
            appearance128.BackColor = System.Drawing.SystemColors.Control;
            appearance128.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance128.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.CellAppearance = appearance128;
            this.ultraDropDownPrepagos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance129.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance129.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance129.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance129.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderAppearance = appearance129;
            this.ultraDropDownPrepagos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance130.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSelectorAppearance = appearance130;
            this.ultraDropDownPrepagos.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance131.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedCellAppearance = appearance131;
            appearance132.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance132.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance132.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPrepagos.DisplayLayout.Override.SelectedRowAppearance = appearance132;
            appearance133.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance133.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPrepagos.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance133;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPrepagos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPrepagos.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPrepagos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPrepagos.DisplayMember = "Nombre";
            this.ultraDropDownPrepagos.DropDownWidth = 250;
            this.ultraDropDownPrepagos.Location = new System.Drawing.Point(720, 286);
            this.ultraDropDownPrepagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownPrepagos.Name = "ultraDropDownPrepagos";
            this.ultraDropDownPrepagos.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownPrepagos.TabIndex = 14;
            this.ultraDropDownPrepagos.ValueMember = "idPrepago";
            this.ultraDropDownPrepagos.Visible = false;
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
            // ultraDropDownVendedores
            // 
            this.ultraDropDownVendedores.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownVendedores.DataSource = this.vendedoresBindingSource;
            appearance114.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance114.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance114.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownVendedores.DisplayLayout.Appearance = appearance114;
            this.ultraDropDownVendedores.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand24.ColHeadersVisible = false;
            ultraGridColumn228.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn228.Header.VisiblePosition = 0;
            ultraGridColumn228.Hidden = true;
            ultraGridColumn228.Width = 30;
            ultraGridColumn229.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn229.Header.VisiblePosition = 1;
            ultraGridColumn229.Hidden = true;
            ultraGridColumn229.Width = 21;
            ultraGridColumn230.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn230.Header.VisiblePosition = 2;
            ultraGridColumn230.Hidden = true;
            ultraGridColumn230.Width = 45;
            ultraGridColumn231.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn231.Header.VisiblePosition = 3;
            ultraGridColumn231.Hidden = true;
            ultraGridColumn231.Width = 45;
            ultraGridColumn232.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn232.Header.VisiblePosition = 4;
            ultraGridColumn232.Width = 227;
            ultraGridColumn233.Header.VisiblePosition = 5;
            ultraGridColumn233.Hidden = true;
            ultraGridColumn233.Width = 40;
            ultraGridColumn234.Header.VisiblePosition = 6;
            ultraGridColumn234.Hidden = true;
            ultraGridColumn234.Width = 40;
            ultraGridBand24.Columns.AddRange(new object[] {
            ultraGridColumn228,
            ultraGridColumn229,
            ultraGridColumn230,
            ultraGridColumn231,
            ultraGridColumn232,
            ultraGridColumn233,
            ultraGridColumn234});
            this.ultraDropDownVendedores.DisplayLayout.BandsSerializer.Add(ultraGridBand24);
            this.ultraDropDownVendedores.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownVendedores.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownVendedores.DisplayLayout.MaxBandDepth = 5;
            appearance115.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownVendedores.DisplayLayout.Override.ActiveCellAppearance = appearance115;
            appearance116.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance116.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance116.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance116.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownVendedores.DisplayLayout.Override.ActiveRowAppearance = appearance116;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownVendedores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance117.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownVendedores.DisplayLayout.Override.CardAreaAppearance = appearance117;
            appearance118.BackColor = System.Drawing.SystemColors.Control;
            appearance118.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance118.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownVendedores.DisplayLayout.Override.CellAppearance = appearance118;
            this.ultraDropDownVendedores.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance119.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance119.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance119.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance119.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance119.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownVendedores.DisplayLayout.Override.HeaderAppearance = appearance119;
            this.ultraDropDownVendedores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance120.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownVendedores.DisplayLayout.Override.RowSelectorAppearance = appearance120;
            this.ultraDropDownVendedores.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance121.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownVendedores.DisplayLayout.Override.SelectedCellAppearance = appearance121;
            appearance122.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance122.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance122.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownVendedores.DisplayLayout.Override.SelectedRowAppearance = appearance122;
            appearance123.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance123.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownVendedores.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance123;
            this.ultraDropDownVendedores.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownVendedores.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownVendedores.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownVendedores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownVendedores.DisplayMember = "ApelNomb";
            this.ultraDropDownVendedores.DropDownWidth = 250;
            this.ultraDropDownVendedores.Location = new System.Drawing.Point(723, 236);
            this.ultraDropDownVendedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownVendedores.Name = "ultraDropDownVendedores";
            this.ultraDropDownVendedores.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownVendedores.TabIndex = 15;
            this.ultraDropDownVendedores.ValueMember = "idEmpleado";
            this.ultraDropDownVendedores.Visible = false;
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
            // ultraDropDownZonas
            // 
            this.ultraDropDownZonas.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownZonas.DataSource = this.zonasBindingSource;
            appearance104.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance104.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownZonas.DisplayLayout.Appearance = appearance104;
            this.ultraDropDownZonas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand23.ColHeadersVisible = false;
            ultraGridColumn222.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn222.Header.VisiblePosition = 0;
            ultraGridColumn222.Hidden = true;
            ultraGridColumn222.Width = 26;
            ultraGridColumn223.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn223.Header.VisiblePosition = 1;
            ultraGridColumn223.Width = 227;
            ultraGridColumn224.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn224.Header.VisiblePosition = 2;
            ultraGridColumn224.Hidden = true;
            ultraGridColumn224.Width = 46;
            ultraGridColumn225.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn225.Header.VisiblePosition = 3;
            ultraGridColumn225.Hidden = true;
            ultraGridColumn225.Width = 34;
            ultraGridColumn226.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn226.Header.VisiblePosition = 4;
            ultraGridColumn226.Hidden = true;
            ultraGridColumn226.Width = 33;
            ultraGridColumn227.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn227.Header.VisiblePosition = 5;
            ultraGridColumn227.Hidden = true;
            ultraGridColumn227.Width = 46;
            ultraGridBand23.Columns.AddRange(new object[] {
            ultraGridColumn222,
            ultraGridColumn223,
            ultraGridColumn224,
            ultraGridColumn225,
            ultraGridColumn226,
            ultraGridColumn227});
            this.ultraDropDownZonas.DisplayLayout.BandsSerializer.Add(ultraGridBand23);
            this.ultraDropDownZonas.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownZonas.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownZonas.DisplayLayout.MaxBandDepth = 5;
            appearance105.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownZonas.DisplayLayout.Override.ActiveCellAppearance = appearance105;
            appearance106.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance106.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance106.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownZonas.DisplayLayout.Override.ActiveRowAppearance = appearance106;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownZonas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance107.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownZonas.DisplayLayout.Override.CardAreaAppearance = appearance107;
            appearance108.BackColor = System.Drawing.SystemColors.Control;
            appearance108.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance108.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownZonas.DisplayLayout.Override.CellAppearance = appearance108;
            this.ultraDropDownZonas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance109.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance109.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance109.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance109.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownZonas.DisplayLayout.Override.HeaderAppearance = appearance109;
            this.ultraDropDownZonas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance110.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownZonas.DisplayLayout.Override.RowSelectorAppearance = appearance110;
            this.ultraDropDownZonas.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownZonas.DisplayLayout.Override.SelectedCellAppearance = appearance111;
            appearance112.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance112.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownZonas.DisplayLayout.Override.SelectedRowAppearance = appearance112;
            appearance113.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance113.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownZonas.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance113;
            this.ultraDropDownZonas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownZonas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownZonas.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownZonas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownZonas.DisplayMember = "Nombre";
            this.ultraDropDownZonas.DropDownWidth = 250;
            this.ultraDropDownZonas.Location = new System.Drawing.Point(723, 135);
            this.ultraDropDownZonas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownZonas.Name = "ultraDropDownZonas";
            this.ultraDropDownZonas.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownZonas.TabIndex = 16;
            this.ultraDropDownZonas.ValueMember = "idZona";
            this.ultraDropDownZonas.Visible = false;
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
            // ultraDropDownTomadoresDeBaja
            // 
            this.ultraDropDownTomadoresDeBaja.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownTomadoresDeBaja.DataSource = this.tomadoresDeBajaBindingSource;
            appearance94.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance94.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance94.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Appearance = appearance94;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand22.ColHeadersVisible = false;
            ultraGridColumn215.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn215.Header.VisiblePosition = 0;
            ultraGridColumn215.Hidden = true;
            ultraGridColumn215.Width = 30;
            ultraGridColumn216.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn216.Header.VisiblePosition = 1;
            ultraGridColumn216.Hidden = true;
            ultraGridColumn216.Width = 21;
            ultraGridColumn217.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn217.Header.VisiblePosition = 2;
            ultraGridColumn217.Hidden = true;
            ultraGridColumn217.Width = 45;
            ultraGridColumn218.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn218.Header.VisiblePosition = 3;
            ultraGridColumn218.Hidden = true;
            ultraGridColumn218.Width = 45;
            ultraGridColumn219.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn219.Header.VisiblePosition = 4;
            ultraGridColumn219.Width = 227;
            ultraGridColumn220.Header.VisiblePosition = 5;
            ultraGridColumn220.Hidden = true;
            ultraGridColumn220.Width = 40;
            ultraGridColumn221.Header.VisiblePosition = 6;
            ultraGridColumn221.Hidden = true;
            ultraGridColumn221.Width = 40;
            ultraGridBand22.Columns.AddRange(new object[] {
            ultraGridColumn215,
            ultraGridColumn216,
            ultraGridColumn217,
            ultraGridColumn218,
            ultraGridColumn219,
            ultraGridColumn220,
            ultraGridColumn221});
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.BandsSerializer.Add(ultraGridBand22);
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.MaxBandDepth = 5;
            appearance95.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.ActiveCellAppearance = appearance95;
            appearance96.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance96.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance96.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.ActiveRowAppearance = appearance96;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance97.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.CardAreaAppearance = appearance97;
            appearance98.BackColor = System.Drawing.SystemColors.Control;
            appearance98.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance98.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.CellAppearance = appearance98;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance99.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance99.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance99.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance99.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.HeaderAppearance = appearance99;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance100.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.RowSelectorAppearance = appearance100;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.SelectedCellAppearance = appearance101;
            appearance102.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance102.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.SelectedRowAppearance = appearance102;
            appearance103.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance103.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance103;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownTomadoresDeBaja.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownTomadoresDeBaja.DisplayMember = "ApelNomb";
            this.ultraDropDownTomadoresDeBaja.DropDownWidth = 250;
            this.ultraDropDownTomadoresDeBaja.Location = new System.Drawing.Point(723, 186);
            this.ultraDropDownTomadoresDeBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownTomadoresDeBaja.Name = "ultraDropDownTomadoresDeBaja";
            this.ultraDropDownTomadoresDeBaja.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownTomadoresDeBaja.TabIndex = 17;
            this.ultraDropDownTomadoresDeBaja.ValueMember = "idEmpleado";
            this.ultraDropDownTomadoresDeBaja.Visible = false;
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
            appearance84.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance84.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Appearance = appearance84;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand21.ColHeadersVisible = false;
            ultraGridColumn213.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn213.Header.VisiblePosition = 0;
            ultraGridColumn213.Hidden = true;
            ultraGridColumn213.Width = 114;
            ultraGridColumn214.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn214.Header.VisiblePosition = 1;
            ultraGridColumn214.Width = 227;
            ultraGridBand21.Columns.AddRange(new object[] {
            ultraGridColumn213,
            ultraGridColumn214});
            this.ultraDropDownMotivosDeBaja.DisplayLayout.BandsSerializer.Add(ultraGridBand21);
            this.ultraDropDownMotivosDeBaja.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.MaxBandDepth = 5;
            appearance85.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.ActiveCellAppearance = appearance85;
            appearance86.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance86.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance86.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.ActiveRowAppearance = appearance86;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance87.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.CardAreaAppearance = appearance87;
            appearance88.BackColor = System.Drawing.SystemColors.Control;
            appearance88.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.CellAppearance = appearance88;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance89.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance89.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance89.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance89.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.HeaderAppearance = appearance89;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance90.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.RowSelectorAppearance = appearance90;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.SelectedCellAppearance = appearance91;
            appearance92.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance92.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance92.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.SelectedRowAppearance = appearance92;
            appearance93.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance93.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance93;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMotivosDeBaja.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMotivosDeBaja.DisplayMember = "Nombre";
            this.ultraDropDownMotivosDeBaja.DropDownWidth = 250;
            this.ultraDropDownMotivosDeBaja.Location = new System.Drawing.Point(720, 336);
            this.ultraDropDownMotivosDeBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownMotivosDeBaja.Name = "ultraDropDownMotivosDeBaja";
            this.ultraDropDownMotivosDeBaja.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownMotivosDeBaja.TabIndex = 18;
            this.ultraDropDownMotivosDeBaja.ValueMember = "idMotivoDeBaja";
            this.ultraDropDownMotivosDeBaja.Visible = false;
            this.ultraDropDownMotivosDeBaja.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownMotivosDeBajaFilterRow);
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
            // ultraDropDownPlanesAfiliado
            // 
            this.ultraDropDownPlanesAfiliado.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownPlanesAfiliado.DataSource = this.planesAfiliadoBindingSource;
            appearance74.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance74.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Appearance = appearance74;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand20.ColHeadersVisible = false;
            ultraGridColumn208.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn208.Header.VisiblePosition = 0;
            ultraGridColumn208.Hidden = true;
            ultraGridColumn208.Width = 43;
            ultraGridColumn209.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn209.Header.VisiblePosition = 1;
            ultraGridColumn209.Width = 227;
            ultraGridColumn210.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn210.Header.VisiblePosition = 2;
            ultraGridColumn210.Hidden = true;
            ultraGridColumn210.Width = 76;
            ultraGridColumn211.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn211.Header.VisiblePosition = 3;
            ultraGridColumn211.Hidden = true;
            ultraGridColumn211.Width = 36;
            ultraGridColumn212.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn212.Header.VisiblePosition = 4;
            ultraGridColumn212.Hidden = true;
            ultraGridColumn212.Width = 66;
            ultraGridBand20.Columns.AddRange(new object[] {
            ultraGridColumn208,
            ultraGridColumn209,
            ultraGridColumn210,
            ultraGridColumn211,
            ultraGridColumn212});
            this.ultraDropDownPlanesAfiliado.DisplayLayout.BandsSerializer.Add(ultraGridBand20);
            this.ultraDropDownPlanesAfiliado.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.MaxBandDepth = 5;
            appearance75.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.ActiveCellAppearance = appearance75;
            appearance76.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance76.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance76.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.ActiveRowAppearance = appearance76;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance77.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.CardAreaAppearance = appearance77;
            appearance78.BackColor = System.Drawing.SystemColors.Control;
            appearance78.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.CellAppearance = appearance78;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance79.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance79.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance79.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance79.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.HeaderAppearance = appearance79;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance80.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.RowSelectorAppearance = appearance80;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.SelectedCellAppearance = appearance81;
            appearance82.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance82.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.SelectedRowAppearance = appearance82;
            appearance83.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance83.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance83;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownPlanesAfiliado.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownPlanesAfiliado.DisplayMember = "Nombre";
            this.ultraDropDownPlanesAfiliado.DropDownWidth = 250;
            this.ultraDropDownPlanesAfiliado.Location = new System.Drawing.Point(720, 386);
            this.ultraDropDownPlanesAfiliado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownPlanesAfiliado.Name = "ultraDropDownPlanesAfiliado";
            this.ultraDropDownPlanesAfiliado.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownPlanesAfiliado.TabIndex = 19;
            this.ultraDropDownPlanesAfiliado.ValueMember = "idPlan";
            this.ultraDropDownPlanesAfiliado.Visible = false;
            this.ultraDropDownPlanesAfiliado.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownPlanesAfiliadoFilterRow);
            // 
            // planesAfiliadoBindingSource
            // 
            this.planesAfiliadoBindingSource.DataMember = "PlanesAfiliado";
            this.planesAfiliadoBindingSource.DataSource = this.dsPlanesAfiliado;
            // 
            // dsPlanesAfiliado
            // 
            this.dsPlanesAfiliado.DataSetName = "DsPlanesAfiliado";
            this.dsPlanesAfiliado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownBarrios
            // 
            this.ultraDropDownBarrios.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownBarrios.DataSource = this.barriosBindingSource;
            appearance64.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance64.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownBarrios.DisplayLayout.Appearance = appearance64;
            this.ultraDropDownBarrios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand19.ColHeadersVisible = false;
            ultraGridColumn205.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn205.Header.VisiblePosition = 0;
            ultraGridColumn205.Hidden = true;
            ultraGridColumn205.Width = 57;
            ultraGridColumn206.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn206.Header.VisiblePosition = 1;
            ultraGridColumn206.Width = 227;
            ultraGridColumn207.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn207.Header.VisiblePosition = 2;
            ultraGridColumn207.Hidden = true;
            ultraGridBand19.Columns.AddRange(new object[] {
            ultraGridColumn205,
            ultraGridColumn206,
            ultraGridColumn207});
            this.ultraDropDownBarrios.DisplayLayout.BandsSerializer.Add(ultraGridBand19);
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
            this.ultraDropDownBarrios.Location = new System.Drawing.Point(723, 436);
            this.ultraDropDownBarrios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownBarrios.Name = "ultraDropDownBarrios";
            this.ultraDropDownBarrios.Size = new System.Drawing.Size(317, 43);
            this.ultraDropDownBarrios.TabIndex = 28;
            this.ultraDropDownBarrios.ValueMember = "idBarrio";
            this.ultraDropDownBarrios.Visible = false;
            this.ultraDropDownBarrios.FilterRow += new Infragistics.Win.UltraWinGrid.FilterRowEventHandler(this.UltraDropDownBarriosFilterRow);
            // 
            // barriosBindingSource
            // 
            this.barriosBindingSource.DataSource = this.dsBarrios;
            this.barriosBindingSource.Position = 0;
            // 
            // dsBarrios
            // 
            this.dsBarrios.DataSetName = "DsBarrios";
            this.dsBarrios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonEstadoActualDelGrupo
            // 
            this.buttonEstadoActualDelGrupo.Enabled = false;
            this.buttonEstadoActualDelGrupo.Location = new System.Drawing.Point(16, 18);
            this.buttonEstadoActualDelGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEstadoActualDelGrupo.Name = "buttonEstadoActualDelGrupo";
            this.buttonEstadoActualDelGrupo.Size = new System.Drawing.Size(184, 28);
            this.buttonEstadoActualDelGrupo.TabIndex = 4;
            this.buttonEstadoActualDelGrupo.Text = "Estado Actual del Grupo";
            this.buttonEstadoActualDelGrupo.UseVisualStyleBackColor = true;
            this.buttonEstadoActualDelGrupo.Click += new System.EventHandler(this.ButtonEstadoActualDelGrupoClick);
            // 
            // buttonCancelarNoHeredado
            // 
            this.buttonCancelarNoHeredado.Location = new System.Drawing.Point(719, 20);
            this.buttonCancelarNoHeredado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelarNoHeredado.Name = "buttonCancelarNoHeredado";
            this.buttonCancelarNoHeredado.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelarNoHeredado.TabIndex = 5;
            this.buttonCancelarNoHeredado.Text = "Cancelar";
            this.buttonCancelarNoHeredado.UseVisualStyleBackColor = true;
            this.buttonCancelarNoHeredado.Click += new System.EventHandler(this.ButtonCancelarNoHeredadoClick);
            // 
            // ultraDropDownOcupaciones
            // 
            this.ultraDropDownOcupaciones.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownOcupaciones.DataSource = this.ocupacionesBindingSource;
            appearance54.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance54.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownOcupaciones.DisplayLayout.Appearance = appearance54;
            this.ultraDropDownOcupaciones.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand18.ColHeadersVisible = false;
            ultraGridColumn203.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn203.Header.VisiblePosition = 0;
            ultraGridColumn203.Hidden = true;
            ultraGridColumn203.Width = 97;
            ultraGridColumn204.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn204.Header.VisiblePosition = 1;
            ultraGridColumn204.Width = 294;
            ultraGridBand18.Columns.AddRange(new object[] {
            ultraGridColumn203,
            ultraGridColumn204});
            this.ultraDropDownOcupaciones.DisplayLayout.BandsSerializer.Add(ultraGridBand18);
            this.ultraDropDownOcupaciones.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownOcupaciones.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownOcupaciones.DisplayLayout.MaxBandDepth = 5;
            appearance55.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.ActiveCellAppearance = appearance55;
            appearance56.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance56.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance56.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.ActiveRowAppearance = appearance56;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance57.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.CardAreaAppearance = appearance57;
            appearance58.BackColor = System.Drawing.SystemColors.Control;
            appearance58.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.CellAppearance = appearance58;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance59.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance59.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance59.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance59.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.HeaderAppearance = appearance59;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance60.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.RowSelectorAppearance = appearance60;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.SelectedCellAppearance = appearance61;
            appearance62.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance62.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.SelectedRowAppearance = appearance62;
            appearance63.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance63.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownOcupaciones.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance63;
            this.ultraDropDownOcupaciones.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownOcupaciones.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownOcupaciones.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownOcupaciones.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownOcupaciones.DisplayMember = "Nombre";
            this.ultraDropDownOcupaciones.Location = new System.Drawing.Point(72, 386);
            this.ultraDropDownOcupaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownOcupaciones.Name = "ultraDropDownOcupaciones";
            this.ultraDropDownOcupaciones.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownOcupaciones.TabIndex = 29;
            this.ultraDropDownOcupaciones.ValueMember = "idOcupacion";
            this.ultraDropDownOcupaciones.Visible = false;
            // 
            // ocupacionesBindingSource
            // 
            this.ocupacionesBindingSource.DataMember = "Ocupaciones";
            this.ocupacionesBindingSource.DataSource = this.dsOcupaciones;
            // 
            // dsOcupaciones
            // 
            this.dsOcupaciones.DataSetName = "DsOcupaciones";
            this.dsOcupaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownMedicosDeCabecera
            // 
            this.ultraDropDownMedicosDeCabecera.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownMedicosDeCabecera.DataSource = this.medicosDeCabeceraListaBindingSource;
            appearance44.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance44.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Appearance = appearance44;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand17.ColHeadersVisible = false;
            ultraGridColumn198.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn198.Header.VisiblePosition = 0;
            ultraGridColumn198.Hidden = true;
            ultraGridColumn198.Width = 51;
            ultraGridColumn199.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn199.Header.VisiblePosition = 1;
            ultraGridColumn199.Hidden = true;
            ultraGridColumn199.Width = 42;
            ultraGridColumn200.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn200.Header.VisiblePosition = 2;
            ultraGridColumn200.Hidden = true;
            ultraGridColumn200.Width = 42;
            ultraGridColumn201.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn201.Header.VisiblePosition = 3;
            ultraGridColumn201.Width = 294;
            ultraGridColumn202.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn202.Header.VisiblePosition = 4;
            ultraGridColumn202.Hidden = true;
            ultraGridColumn202.Width = 42;
            ultraGridBand17.Columns.AddRange(new object[] {
            ultraGridColumn198,
            ultraGridColumn199,
            ultraGridColumn200,
            ultraGridColumn201,
            ultraGridColumn202});
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.BandsSerializer.Add(ultraGridBand17);
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.ColScrollRegions.Add(colScrollRegion1);
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.ColScrollRegions.Add(colScrollRegion2);
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.MaxBandDepth = 5;
            appearance45.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.ActiveCellAppearance = appearance45;
            appearance46.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance46.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance46.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.ActiveRowAppearance = appearance46;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance47.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.CardAreaAppearance = appearance47;
            appearance48.BackColor = System.Drawing.SystemColors.Control;
            appearance48.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.CellAppearance = appearance48;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance49.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance49.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance49.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance49.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.HeaderAppearance = appearance49;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance50.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.RowSelectorAppearance = appearance50;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.SelectedCellAppearance = appearance51;
            appearance52.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance52.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.SelectedRowAppearance = appearance52;
            appearance53.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance53.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance53;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownMedicosDeCabecera.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownMedicosDeCabecera.DisplayMember = "ApelNomb";
            this.ultraDropDownMedicosDeCabecera.Location = new System.Drawing.Point(72, 336);
            this.ultraDropDownMedicosDeCabecera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownMedicosDeCabecera.Name = "ultraDropDownMedicosDeCabecera";
            this.ultraDropDownMedicosDeCabecera.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownMedicosDeCabecera.TabIndex = 30;
            this.ultraDropDownMedicosDeCabecera.ValueMember = "idMedicoDeCabecera";
            this.ultraDropDownMedicosDeCabecera.Visible = false;
            // 
            // medicosDeCabeceraListaBindingSource
            // 
            this.medicosDeCabeceraListaBindingSource.DataMember = "MedicosDeCabeceraLista";
            this.medicosDeCabeceraListaBindingSource.DataSource = this.dsMedicosDeCabecera;
            // 
            // dsMedicosDeCabecera
            // 
            this.dsMedicosDeCabecera.DataSetName = "DsMedicosDeCabecera";
            this.dsMedicosDeCabecera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ultraDropDownLocalidades
            // 
            this.ultraDropDownLocalidades.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownLocalidades.DataSource = this.localidadesListaBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownLocalidades.DisplayLayout.Appearance = appearance1;
            this.ultraDropDownLocalidades.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridBand16.ColHeadersVisible = false;
            ultraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn30.Header.VisiblePosition = 0;
            ultraGridColumn30.Hidden = true;
            ultraGridColumn30.Width = 91;
            ultraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            ultraGridColumn31.Header.VisiblePosition = 1;
            ultraGridColumn31.Width = 294;
            ultraGridColumn32.Header.VisiblePosition = 2;
            ultraGridColumn32.Hidden = true;
            ultraGridColumn32.Width = 58;
            ultraGridBand16.Columns.AddRange(new object[] {
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32});
            this.ultraDropDownLocalidades.DisplayLayout.BandsSerializer.Add(ultraGridBand16);
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
            this.ultraDropDownLocalidades.Location = new System.Drawing.Point(72, 287);
            this.ultraDropDownLocalidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownLocalidades.Name = "ultraDropDownLocalidades";
            this.ultraDropDownLocalidades.Size = new System.Drawing.Size(317, 42);
            this.ultraDropDownLocalidades.TabIndex = 31;
            this.ultraDropDownLocalidades.ValueMember = "idLocalidad";
            this.ultraDropDownLocalidades.Visible = false;
            this.ultraDropDownLocalidades.RowSelected += new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(this.UltraDropDownLocalidadesRowSelected);
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
            // ultraDropDownGrabador
            // 
            this.ultraDropDownGrabador.CalcManager = this.ultraCalcManager1;
            this.ultraDropDownGrabador.DataSource = this.usuariosListaBindingSource;
            appearance34.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance34.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraDropDownGrabador.DisplayLayout.Appearance = appearance34;
            ultraGridBand15.ColHeadersVisible = false;
            ultraGridColumn192.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn192.Header.VisiblePosition = 0;
            ultraGridColumn192.Hidden = true;
            ultraGridColumn193.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn193.Header.VisiblePosition = 1;
            ultraGridColumn193.Hidden = true;
            ultraGridColumn194.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn194.Header.VisiblePosition = 2;
            ultraGridColumn195.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn195.Header.VisiblePosition = 3;
            ultraGridColumn195.Hidden = true;
            ultraGridColumn196.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            ultraGridColumn196.Header.VisiblePosition = 4;
            ultraGridColumn196.Hidden = true;
            ultraGridColumn197.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn197.Header.VisiblePosition = 5;
            ultraGridColumn197.Hidden = true;
            ultraGridBand15.Columns.AddRange(new object[] {
            ultraGridColumn192,
            ultraGridColumn193,
            ultraGridColumn194,
            ultraGridColumn195,
            ultraGridColumn196,
            ultraGridColumn197});
            this.ultraDropDownGrabador.DisplayLayout.BandsSerializer.Add(ultraGridBand15);
            this.ultraDropDownGrabador.DisplayLayout.GroupByBox.Hidden = true;
            this.ultraDropDownGrabador.DisplayLayout.InterBandSpacing = 10;
            this.ultraDropDownGrabador.DisplayLayout.MaxBandDepth = 5;
            appearance35.BackColor = System.Drawing.SystemColors.Window;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveCellAppearance = appearance35;
            appearance36.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            appearance36.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance36.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ultraDropDownGrabador.DisplayLayout.Override.ActiveRowAppearance = appearance36;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.False;
            this.ultraDropDownGrabador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            appearance37.BackColor = System.Drawing.Color.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.CardAreaAppearance = appearance37;
            appearance38.BackColor = System.Drawing.SystemColors.Control;
            appearance38.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.CellAppearance = appearance38;
            this.ultraDropDownGrabador.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            appearance39.BackColor = System.Drawing.SystemColors.ActiveCaption;
            appearance39.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            appearance39.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderAppearance = appearance39;
            this.ultraDropDownGrabador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance40.ForeColor = System.Drawing.Color.Red;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSelectorAppearance = appearance40;
            this.ultraDropDownGrabador.DisplayLayout.Override.RowSpacingAfter = 1;
            appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedCellAppearance = appearance41;
            appearance42.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance42.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraDropDownGrabador.DisplayLayout.Override.SelectedRowAppearance = appearance42;
            appearance43.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            appearance43.BackColor2 = System.Drawing.SystemColors.ControlDark;
            this.ultraDropDownGrabador.DisplayLayout.Override.TemplateAddRowCellAppearance = appearance43;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraDropDownGrabador.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraDropDownGrabador.DisplayLayout.UseFixedHeaders = true;
            this.ultraDropDownGrabador.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraDropDownGrabador.DisplayMember = "NombApel";
            this.ultraDropDownGrabador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraDropDownGrabador.Location = new System.Drawing.Point(395, 190);
            this.ultraDropDownGrabador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ultraDropDownGrabador.Name = "ultraDropDownGrabador";
            this.ultraDropDownGrabador.Size = new System.Drawing.Size(317, 39);
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
            // FormGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1175, 726);
            this.Controls.Add(this.gruposUltraGrid);
            this.Controls.Add(this.ultraDropDownGrabador);
            this.Controls.Add(this.ultraDropDownLocalidades);
            this.Controls.Add(this.ultraDropDownMedicosDeCabecera);
            this.Controls.Add(this.ultraDropDownOcupaciones);
            this.Controls.Add(this.ultraDropDownBarrios);
            this.Controls.Add(this.ultraDropDownPlanesAfiliado);
            this.Controls.Add(this.ultraDropDownMotivosDeBaja);
            this.Controls.Add(this.ultraDropDownTomadoresDeBaja);
            this.Controls.Add(this.ultraDropDownZonas);
            this.Controls.Add(this.ultraDropDownVendedores);
            this.Controls.Add(this.ultraDropDownPrepagos);
            this.Controls.Add(this.ultraDropDownLugarDeInternacion);
            this.Controls.Add(this.ultraDropDownTiposDeDocumento);
            this.Controls.Add(this.ultraDropDownEntidadDeCobranza);
            this.Controls.Add(this.ultraDropDownTipoDeCobranza);
            this.Controls.Add(this.ultraDropDownCalle);
            this.Controls.Add(this.ultraDropDownPlanes);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(471, 230);
            this.Name = "FormGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo de Afiliados";
            this.Load += new System.EventHandler(this.FormGruposLoad);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPlanes, 0);
            this.Controls.SetChildIndex(this.ultraDropDownCalle, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTipoDeCobranza, 0);
            this.Controls.SetChildIndex(this.ultraDropDownEntidadDeCobranza, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTiposDeDocumento, 0);
            this.Controls.SetChildIndex(this.ultraDropDownLugarDeInternacion, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPrepagos, 0);
            this.Controls.SetChildIndex(this.ultraDropDownVendedores, 0);
            this.Controls.SetChildIndex(this.ultraDropDownZonas, 0);
            this.Controls.SetChildIndex(this.ultraDropDownTomadoresDeBaja, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMotivosDeBaja, 0);
            this.Controls.SetChildIndex(this.ultraDropDownPlanesAfiliado, 0);
            this.Controls.SetChildIndex(this.ultraDropDownBarrios, 0);
            this.Controls.SetChildIndex(this.ultraDropDownOcupaciones, 0);
            this.Controls.SetChildIndex(this.ultraDropDownMedicosDeCabecera, 0);
            this.Controls.SetChildIndex(this.ultraDropDownLocalidades, 0);
            this.Controls.SetChildIndex(this.ultraDropDownGrabador, 0);
            this.Controls.SetChildIndex(this.gruposUltraGrid, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposUltraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAfiliados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCallesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTipoDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownEntidadDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entidadesDeCobranzaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntidadesDeCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTiposDeDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTiposDeDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLugarDeInternacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLugares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrepagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownTomadoresDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomadoresDeBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTomadoresDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivosDeBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMotivosDeBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownPlanesAfiliado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesAfiliadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanesAfiliado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownOcupaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOcupaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownMedicosDeCabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDeCabeceraListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedicosDeCabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownLocalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocalidadesLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDropDownGrabador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUsuariosLista1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource gruposBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid gruposUltraGrid;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private System.Windows.Forms.Button buttonSalir;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPlanes;
        private WS.DsAfiliados dsAfiliados;
        private WS.DsCallesLista dsCallesLista;
        private System.Windows.Forms.BindingSource bindingSourceCalle;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownCalle;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTipoDeCobranza;
        private System.Windows.Forms.BindingSource tiposDeCobranzaBindingSource;
        private WS.DsTiposDeCobranza dsTiposDeCobranza;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownEntidadDeCobranza;
        private System.Windows.Forms.BindingSource entidadesDeCobranzaBindingSource;
        private WS.DsEntidadesDeCobranza dsEntidadesDeCobranza;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTiposDeDocumento;
        private System.Windows.Forms.BindingSource tiposDeDocumentoBindingSource;
        private WS.DsTiposDeDocumento dsTiposDeDocumento;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLugarDeInternacion;
        private System.Windows.Forms.BindingSource lugaresBindingSource;
        private WS.DsLugares dsLugares;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPrepagos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownVendedores;
        private System.Windows.Forms.BindingSource prepagosBindingSource;
        private WS.DsPrepagos dsPrepagos;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownZonas;
        private System.Windows.Forms.BindingSource zonasBindingSource;
        private WS.DsZonas dsZonas;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownTomadoresDeBaja;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMotivosDeBaja;
        private System.Windows.Forms.BindingSource motivosDeBajaBindingSource;
        private WS.DsMotivosDeBaja dsMotivosDeBaja;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private WS.DsPlanes dsPlanes;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownPlanesAfiliado;
        private System.Windows.Forms.BindingSource planesAfiliadoBindingSource;
        private WS.DsPlanesAfiliado dsPlanesAfiliado;
        private System.Windows.Forms.BindingSource barriosBindingSource;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownBarrios;
        private WS.DsBarrios dsBarrios;
        private System.Windows.Forms.Button buttonEstadoActualDelGrupo;
        private System.Windows.Forms.Button buttonCancelarNoHeredado;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownMedicosDeCabecera;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownOcupaciones;
        private System.Windows.Forms.BindingSource ocupacionesBindingSource;
        private WS.DsOcupaciones dsOcupaciones;
        private System.Windows.Forms.BindingSource medicosDeCabeceraListaBindingSource;
        private WS.DsMedicosDeCabecera dsMedicosDeCabecera;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownLocalidades;
        private System.Windows.Forms.BindingSource localidadesListaBindingSource;
        private WS.DsLocalidadesLista dsLocalidadesLista;
        private System.Windows.Forms.BindingSource tomadoresDeBajaBindingSource;
        private WS.DsEmpleadosLista dsTomadoresDeBaja;
        private System.Windows.Forms.BindingSource vendedoresBindingSource;
        private WS.DsEmpleadosLista dsVendedores;
        private Infragistics.Win.UltraWinGrid.UltraDropDown ultraDropDownGrabador;
        private System.Windows.Forms.BindingSource usuariosListaBindingSource;
        private Cabina.WS.DsUsuariosLista dsUsuariosLista1;
    }
}
