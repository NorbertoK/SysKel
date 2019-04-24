using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormReporteListadoCuponesClientes : Form1
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormReporteListadoCuponesClientes()
        {
            InitializeComponent();
        }

        public string Periodo { get; set; }
        public int IdCobrador { get; set; }
        public string Prefijo { get; set; }
        public int IdZona { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public string TodosOPendientes { get; set; }
        public string Comprobantes { get; set; }
        private void FormReporteListadoCuponesLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crListadoComprobantesClientes1.DataDefinition.ParameterFields;
            dsComprobantesDeFacturas1.Merge(new Service().GetComprobantesDeFacturas(Desde, Hasta, Comprobantes, Prefijo, Program.Pin));
            dsZonas1.Merge(new Service().GetZonas(Program.Pin));
            dsCobradores.Merge(new Service().GetCobradores(Program.Pin));
            crListadoComprobantesClientes1.SetDataSource(dsComprobantesDeFacturas1);

            AgregarParametro("Periodo", Periodo);

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