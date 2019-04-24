using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace Administración
{
    public partial class FormRepTasaDeUsoAfYCli : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepTasaDeUsoAfYCli()
        {
            InitializeComponent();
        }
        public string PeriodoDesde { get; set; }
        public string PeriodoHasta { get; set; }
        private void FormRepTasaDeUsoAfYCli_Load(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crTasaDeUsoAfYCli1.DataDefinition.ParameterFields;
            var aux = new Service { Timeout = (60 * 60 * 1000) };
            dsTasaDeUsoAfYCli1.Merge(aux.GetTasaDeUsoAfYCli(PeriodoDesde, PeriodoHasta, Program.Pin));
            crTasaDeUsoAfYCli1.SetDataSource(dsTasaDeUsoAfYCli1);
            AgregarParametro("Subtitulo", "Período " + PeriodoDesde + " al " + PeriodoHasta);
        }
        private void AgregarParametro(string nombreParametro, string valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue { Value = valorParametro };
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}
