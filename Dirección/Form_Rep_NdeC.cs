using System;
using Dirección.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Dirección
{
    public partial class FormRepNdeC : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepNdeC()
        {
            InitializeComponent();
        }

        public DateTime Desde { get; set; }

        public DateTime Hasta { get; set; }

        private void CrystalReportViewer1Load(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crListaNdeC.DataDefinition.ParameterFields;
            dsRepNdeC.Merge(new Service().GetRepNdeC(Desde.ToString("yyyyMMdd"), Hasta.ToString("yyyyMMdd"),
                                                      Program.Pin));
            crListaNdeC.SetDataSource(dsRepNdeC);
            AgregarParametro("Desde", Desde);
            AgregarParametro("Hasta", Hasta);
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