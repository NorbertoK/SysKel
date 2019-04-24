using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace Cabina
{
    public partial class FormRepContarPrestaciones : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepContarPrestaciones()
        {
            InitializeComponent();
        }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public string DesdeHora { get; set; }
        public string HastaHora { get; set; }
        public string NroPrestacion { get; set; }
        public string Cobertura { get; set; }
        public string TipoDeDestino { get; set; }
        public string Cliente { get; set; }
        public string Contrato { get; set; }
        public string Rubro { get; set; }
        public string Codigo { get; set; }
        public string EntidadDeCobranza { get; set; }
        public string Paciente { get; set; }
        public string HC { get; set; }
        public string Localidad { get; set; }
        public string Calle { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string TiempoDeLlegada { get; set; }
        public string Medico { get; set; }
        public string Paramedico { get; set; }
        public string Chofer { get; set; }
        public string Motivo { get; set; }
        public string Diagnostico { get; set; }
        public string Medicamento { get; set; }
        public string Internacion { get; set; }
        public string Lugar { get; set; }
        public string Tomador { get; set; }
        public string Despachador { get; set; }
        public string Canceladas { get; set; }
        public int Cantidad { get; set; }

        private void FormRepContarPrestacionesLoad(object sender, System.EventArgs e)
        {
            _crParameterFieldDefinitions = crContadorDePrestaciones1.DataDefinition.ParameterFields;
            AgregarParametro("Desde",Desde);
            AgregarParametro("Hasta",Hasta);
            AgregarParametro("DesdeHora", DesdeHora);
            AgregarParametro("HastaHora", HastaHora);
            AgregarParametro("Nro_Prestacion",NroPrestacion);
            AgregarParametro("Prestaciones",Cobertura);
            AgregarParametro("Cliente",Cliente);
            AgregarParametro("Contrato", Contrato);
            AgregarParametro("Rubro",Rubro);
            AgregarParametro("Código",Codigo);
            AgregarParametro("EntidadDeCobranza",EntidadDeCobranza);
            AgregarParametro("Paciente",Paciente);
            AgregarParametro("HC",HC);
            AgregarParametro("Localidad",Localidad);
            AgregarParametro("Calle",Calle);
            AgregarParametro("Teléfono", Telefono);
            AgregarParametro("Móvil", Movil);
            AgregarParametro("TiempoDeLlegada", TiempoDeLlegada);
            AgregarParametro("Médico",Medico);
            AgregarParametro("Paramédico", Paramedico);
            AgregarParametro("Chofer", Chofer);
            AgregarParametro("Motivo", Motivo);
            AgregarParametro("Diagnóstico", Diagnostico);
            AgregarParametro("Medicamento", Medicamento);
            AgregarParametro("Internación", Internacion);
            AgregarParametro("Lugar", Lugar);
            AgregarParametro("Tomador", Tomador);
            AgregarParametro("Despachador", Despachador);
            AgregarParametroInt("Cantidad", Cantidad);
            AgregarParametro("Canceladas", Canceladas);

        }
        private void AgregarParametro(string nombreParametro, string valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue { Value = valorParametro };
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
        private void AgregarParametroInt(string nombreParametro, int valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue { Value = valorParametro };
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}
