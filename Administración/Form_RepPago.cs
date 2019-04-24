using System;
using Administración.Properties;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepPago : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepPago()
        {
            InitializeComponent();
        }
        public int IdOrdenDePago { get; set; }

        private void FormRepPagoLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_ReportPago1.DataDefinition.ParameterFields;
            dsReportPago1.Merge(new Service().GetReportPago(IdOrdenDePago,Program.Pin));
            CR_ReportPago1.SetDataSource(dsReportPago1);
            AgregarParametro("Empresa", Settings.Default.Empresa);
            AgregarParametro("Numero", string.Format("{0:##,#}",IdOrdenDePago));
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
