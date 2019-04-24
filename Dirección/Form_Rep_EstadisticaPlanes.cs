using System;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Dirección
{
    using WS;
    public partial class FormRepEstadisticaPlanes : FormCR
    {
        public FormRepEstadisticaPlanes()
        {
            InitializeComponent();
        }
        public DateTime Fecha;
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        private void FormRepEstadisticaPlanesLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = cr_EstadisticaPlanes1.DataDefinition.ParameterFields;
            dsEstadisticaPlanes1.Merge(new Service().GetEstadisticaPlanes(Fecha.ToString("yyyyMMdd"), Program.Pin));
            cr_EstadisticaPlanes1.SetDataSource(dsEstadisticaPlanes1);
            AgregarParametro("Fecha", Fecha);
        }
        private void AgregarParametro(string nombreParametro, DateTime valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue { Value = valorParametro };
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}
