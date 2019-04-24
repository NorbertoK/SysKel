using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepCantidadAfiliadosPlan : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepCantidadAfiliadosPlan()
        {
            InitializeComponent();
        }

        public DateTime Fecha { private get; set; }

        private void FormRepCantidadAfiliadosPlanLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crCantidadAfiliadosPlan1.DataDefinition.ParameterFields;
            var aux = new Service {Timeout = (60*60*1000)};
            dsRepCantidadAfiliadosPlan1.Merge(aux.GetCantidadAfiliadosPlan(Fecha.ToString("yyyyMMdd"), Program.Pin));
            crCantidadAfiliadosPlan1.SetDataSource(dsRepCantidadAfiliadosPlan1);
            AgregarParametro("fecha", Fecha);
        }

        private void AgregarParametro(string nombreParametro, DateTime valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = valorParametro};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}