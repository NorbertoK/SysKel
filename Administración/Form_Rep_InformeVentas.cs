using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepInformeVentas : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        private DateTime _desde = DateTime.Today;
        private DateTime _hasta = DateTime.Today;

        public FormRepInformeVentas()
        {
            InitializeComponent();
        }

        public DateTime Desde
        {
            private get { return _desde; }
            set { _desde = value; }
        }

        public DateTime Hasta
        {
            private get { return _hasta; }
            set { _hasta = value; }
        }

        private void FormRepInformeVentasLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crInformeVentas.DataDefinition.ParameterFields;
            dsInformeVentas.Merge(new Service().GetInformeVentas(Desde.ToString("yyyyMMdd"),
                                                                  Hasta.ToString("yyyyMMdd"), Program.Pin));
            crInformeVentas.SetDataSource(dsInformeVentas);
            AgregarParametro("Desde", Desde.ToString("dd/MM/yyyy"));
            AgregarParametro("Hasta", Hasta.ToString("dd/MM/yyyy"));
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