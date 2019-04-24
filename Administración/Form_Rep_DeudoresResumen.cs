using System;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace Administración
{
    public partial class FormRepDeudoresResumen : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepDeudoresResumen()
        {
            InitializeComponent();
        }
        public DsDeudores DsDeudoresTraidos { private get; set; }
        public DateTime Fecha { private get; set; }
        private void FormRepDeudoresResumenLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crDeudoresResumen1.DataDefinition.ParameterFields;
            crDeudoresResumen1.SetDataSource(DsDeudoresTraidos);
            _crParameterFieldLocation = _crParameterFieldDefinitions["Fecha"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = Fecha};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}
