using System;
using Administración.Properties;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepIVAVentasAfiliados : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        private DateTime _desde = new Service().HoraActual(Program.Pin);
        private DateTime _hasta = new Service().HoraActual(Program.Pin);

        public FormRepIVAVentasAfiliados()
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

        public int UltimaPaginaImpresa { private get; set; }

        private void FormRepIVAVentasAfiliadosLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crIVAVentas.DataDefinition.ParameterFields;
            dsRepIVAVentasAfiliados.Merge(new Service().GetIVAVentasAfiliados(Desde.ToString("yyyyMMdd"),
                                                                               Hasta.ToString("yyyyMMdd"),
                                                                               Program.Pin));
            crIVAVentas.SetDataSource(dsRepIVAVentasAfiliados);

            _crParameterFieldLocation = _crParameterFieldDefinitions["UltimaPaginaImpresa"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = UltimaPaginaImpresa};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);

            _crParameterFieldLocation = _crParameterFieldDefinitions["Desde"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = Desde};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);

            _crParameterFieldLocation = _crParameterFieldDefinitions["Hasta"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = Hasta};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);

            _crParameterFieldLocation = _crParameterFieldDefinitions["Empresa"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue { Value = Settings.Default.Empresa };
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}