using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepTasaDeUsoClientes : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepTasaDeUsoClientes()
        {
            InitializeComponent();
        }

        public string PeriodoDesde { get; set; }
        public string PeriodoHasta { get; set; }
        private void Form_Rep_TasaDeUsoClientes_Load(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crTasaDeUsoClientes.DataDefinition.ParameterFields;
            var aux = new Service { Timeout = (60 * 60 * 1000) };
            dsTasaDeUsoClientes1.Merge(aux.GetTasaDeUsoClientes(PeriodoDesde, PeriodoHasta, Program.Pin));
            crTasaDeUsoClientes.SetDataSource(dsTasaDeUsoClientes1);
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
