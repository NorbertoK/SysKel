using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormReporteListadoCupones : Form1
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
       
        public FormReporteListadoCupones()
        {
            InitializeComponent();
        }

        public string Periodo { get; set; }
        public int IdTipoDeCobranza { get; set; }
        public int IdEntidadDeCobranza { get; set; }
        public int IdCobrador { get; set; }
        public string Prefijo { get; set; }
        public int IdZona { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public DateTime DesdeFecha { get; set; }
        public DateTime HastaFecha { get; set; }
        public string TodosOPendientes { get; set; }
        public string Comprobantes { get; set; }
        private void FormReporteListadoCuponesLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crListadoComprobantes1.DataDefinition.ParameterFields;
            dsReportComprobantes1.Merge(new Service().GetReportComprobantes(Periodo, IdTipoDeCobranza,
                                                                            IdEntidadDeCobranza, IdCobrador, Prefijo,
                                                                            IdZona, Desde, Hasta,
                                                                            DesdeFecha.ToString("yyyyMMdd HH:mm:ss"),
                                                                            HastaFecha.ToString("yyyyMMdd HH:mm:ss"),
                                                                            TodosOPendientes, Comprobantes, Program.Pin));
            dsTiposDeCobranza1.Merge(new Service().GetTiposDeCobranza(Program.Pin));
            dsEntidadesDeCobranza1.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
            dsZonas1.Merge(new Service().GetZonas(Program.Pin));
            dsCobradores.Merge(new Service().GetCobradores(Program.Pin));
            crListadoComprobantes1.SetDataSource(dsReportComprobantes1);

            AgregarParametro("Periodo", Periodo);

            string tipoDeCobranza;
            try
            {
                tipoDeCobranza = dsTiposDeCobranza1.TiposDeCobranza.FindByidTipoDeCobranza(IdTipoDeCobranza).Nombre;
            }
            catch
            {
                tipoDeCobranza = "Todas";
            }
            AgregarParametro("TipoDeCobranza", tipoDeCobranza);

            string entidadDeCobranza;
            try
            {
                entidadDeCobranza =
                    dsEntidadesDeCobranza1.EntidadesDeCobranza.FindByidEntidadDeCobranza(IdEntidadDeCobranza).Nombre;
            }
            catch
            {
                entidadDeCobranza = "Todas";
            }
            AgregarParametro("EntidadDeCobranza", entidadDeCobranza);

            string cobrador;
            try
            {
                cobrador = dsCobradores.EmpleadosLista.FindByidEmpleado(IdCobrador).NombApel;
            }
            catch
            {
                cobrador = "Todos";
            }
            AgregarParametro("Cobrador", cobrador);

            var prefijo1 = Prefijo == "" ? "Todos" : Prefijo;
            AgregarParametro("Prefijo", prefijo1);

            string zona;
            try
            {
                zona = dsZonas1.Zonas.FindByidZona(IdZona).Nombre;
            }
            catch
            {
                zona = "Todas";
            }
            AgregarParametro("Zona", zona);

            var desde1 = Desde == "" ? "Todos" : Desde;
            AgregarParametro("Desde", desde1);

            var hasta1 = Hasta == "" ? "Todos" : Hasta;
            AgregarParametro("Hasta", hasta1);

            var todosOPendientes1 = TodosOPendientes == "T" ? "Pendientes y Pagos" : "Sólo los Pendientes";
            AgregarParametro("TodosOPendientes", todosOPendientes1);
        }

        private void AgregarParametro(string nombreParametro, string valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = valorParametro};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}