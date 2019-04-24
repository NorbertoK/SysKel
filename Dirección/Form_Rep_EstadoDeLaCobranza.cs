namespace Dirección
{
    using System;
    using WS;
    using CrystalDecisions.CrystalReports.Engine;
    using CrystalDecisions.Shared;

    public partial class FormRepEstadoDeLaCobranza : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepEstadoDeLaCobranza()
        {
            InitializeComponent();
        }

        public string Cobrador { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCobrador { get; set; }
        public int Meses { get; set; }
        public string MostrarFuturo { get; set; }

        private void FormRepEstadoDeLaCobranzaLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crEstadoDeLaCobranza1.DataDefinition.ParameterFields;
            var aux = new Service { Timeout = (60 * 60 * 1000) };
            dsEstadoDeLaCobranza1.Merge(aux.GetEstadoDeLaCobranza(IdCobrador, Fecha.ToString("yyyyMMdd"),
                                                                             Meses, MostrarFuturo, Program.Pin));
            crEstadoDeLaCobranza1.SetDataSource(dsEstadoDeLaCobranza1);
            AgregarParametroString("Cobrador", Cobrador);
            AgregarParametroDate("Fecha", Fecha);
            AgregarParametroInt("idCobrador", IdCobrador);
            AgregarParametroInt("Meses", Meses);
        }

        private void AgregarParametroString(string nombreParametro, string valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = valorParametro};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }

        private void AgregarParametroInt(string nombreParametro, int valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = valorParametro};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }

        private void AgregarParametroDate(string nombreParametro, DateTime valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = valorParametro};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}