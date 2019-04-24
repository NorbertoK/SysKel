using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepAfiliadosPorEntidadDeCobranza : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepAfiliadosPorEntidadDeCobranza()
        {
            InitializeComponent();
        }

        public int IdEntidadDeCobranza { private get; set; }

        public string EntidadDeCobranza { private get; set; }

        private void FormRepAfiliadosPorEntidadDeCobranzaLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crAfiliadosPorEntidadDeCobranza1.DataDefinition.ParameterFields;
            var aux = new Service {Timeout = (60*60*1000)};
            dsRepAfiliadosPorEntidadDeCobranza1.Merge(aux.GetAfiliadosPorEntidadDeCobranza(IdEntidadDeCobranza,
                                                                                             Program.Pin));
            crAfiliadosPorEntidadDeCobranza1.SetDataSource(dsRepAfiliadosPorEntidadDeCobranza1);
            AgregarParametro("Entidad", EntidadDeCobranza);
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