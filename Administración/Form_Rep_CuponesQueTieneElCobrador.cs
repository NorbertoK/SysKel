using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepCuponesQueTieneElCobrador : Form1
    {
        private string _cobrador = "";

        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        private string _proceso = "";

        public FormRepCuponesQueTieneElCobrador()
        {
            InitializeComponent();
        }

        public string Proceso
        {
            private get { return _proceso; }
            set { _proceso = value; }
        }

        public string Cobrador
        {
            private get { return _cobrador; }
            set { _cobrador = value; }
        }

        private void FormReporteListadoCuponesLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crComprobantesQueTieneElCobrador1.DataDefinition.ParameterFields;
            dsReportComprobantes1.Merge(new Service().GetReportComprobantesPorProceso(Proceso, Program.Pin));
            new Service().EliminarProceso(Proceso, Program.Pin);
            crComprobantesQueTieneElCobrador1.SetDataSource(dsReportComprobantes1);
            AgregarParametro("Cobrador", Cobrador);
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