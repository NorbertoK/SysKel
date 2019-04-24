namespace Dirección
{
    using WS;
    using CrystalDecisions.CrystalReports.Engine;
    using CrystalDecisions.Shared;

    public partial class FormRepEstadisticaCantidadDeAfiliados : FormCR
    {
        public string PeriodoDesde { get; set; }
        public string PeriodoHasta { get; set; }
        public string Modo { get; set; }
        public int IdPlan { get; set; }
        public string Subtitulo { get; set; }
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepEstadisticaCantidadDeAfiliados()
        {
            InitializeComponent();
        }

        private void FormRepEstadisticaCantidadDeAfiliadosLoad(object sender, System.EventArgs e)
        {
            _crParameterFieldDefinitions = crEstadisticaCantidadDeAfiliados1.DataDefinition.ParameterFields;
            dsEstadisticaCantidadDeAfiliados1.Merge(new Service().GetEstadisticaCantidadDeAfiliados(PeriodoDesde,PeriodoHasta,Modo,IdPlan,Program.Pin));
            crEstadisticaCantidadDeAfiliados1.SetDataSource(dsEstadisticaCantidadDeAfiliados1);
            _crParameterFieldLocation = _crParameterFieldDefinitions["Subtitulo"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue { Value = Subtitulo };
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}