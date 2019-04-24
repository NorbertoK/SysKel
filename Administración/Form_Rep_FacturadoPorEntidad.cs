using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepFacturadoPorEntidad : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepFacturadoPorEntidad()
        {
            InitializeComponent();
        }

        public int IdEntidadDeCobranza { private get; set; }

        public string EntidadDeCobranza { private get; set; }

        public string Periodo { private get; set; }

        private void FormRepFacturadoPorEntidadLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crFacturadoPorEntidad1.DataDefinition.ParameterFields;
            var aux = new Service {Timeout = (60*60*1000)};
            dsRepListadoFacturadoPorEntidad1.Merge(aux.GetListadoFacturadoPorEntidad(IdEntidadDeCobranza, Periodo,
                                                                                     Program.Pin));
            crFacturadoPorEntidad1.SetDataSource(dsRepListadoFacturadoPorEntidad1);
            AgregarParametro("EntidadDeCobranza", EntidadDeCobranza);
            AgregarParametro("Periodo", Periodo);
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