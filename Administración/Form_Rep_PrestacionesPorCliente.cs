using System;
using Administración.Properties;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepPrestacionesPorCliente : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepPrestacionesPorCliente()
        {
            InitializeComponent();
        }
        public DateTime Desde { get; set; }

        public DateTime Hasta { get; set; }

        private void FormRepPrestacionesPorClienteLoad(object sender, EventArgs e)
        {
            if (Settings.Default.Empresa == "AYMED")
            {
                _crParameterFieldDefinitions = CR_ResumenPrestacionesPorCliente1.DataDefinition.ParameterFields;
                var aux = new Service { Timeout = (60 * 60 * 1000) };
                dsRepResumenPrestacionesPorCliente1.Merge(aux.GetResumenPrestacionesPorCliente(Desde.ToString("yyyyMMdd"), Hasta.ToString("yyyyMMdd"), Program.Pin));
                CR_ResumenPrestacionesPorCliente1.SetDataSource(dsRepResumenPrestacionesPorCliente1);
            }
            else
            {
                crystalReportViewer1.ReportSource =
                    cR_ResumenPrestacionesPorClienteSoloDomicilios1;
                _crParameterFieldDefinitions = cR_ResumenPrestacionesPorClienteSoloDomicilios1.DataDefinition.ParameterFields;
                var aux = new Service { Timeout = (60 * 60 * 1000) };
                dsRepResumenPrestacionesPorCliente1.Merge(aux.GetResumenPrestacionesPorClienteSoloDomicilios(Desde.ToString("yyyyMMdd"), Hasta.ToString("yyyyMMdd"), Program.Pin));
                cR_ResumenPrestacionesPorClienteSoloDomicilios1.SetDataSource(dsRepResumenPrestacionesPorCliente1);
            }
            AgregarParametro("Periodo", Desde.ToString("dd/MM/yyyy") + " al " + Hasta.ToString("dd/MM/yyyy"));
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
