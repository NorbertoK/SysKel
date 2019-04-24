using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepPadron : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        private DateTime _fecha = new Service().HoraActual(Program.Pin);
        private string _nombreZona = "";

        public FormRepPadron()
        {
            InitializeComponent();
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public int IdZona { get; set; }

        public string NombreZona
        {
            get { return _nombreZona; }
            set { _nombreZona = value; }
        }

        private void FormRepPadronLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crPadron1.DataDefinition.ParameterFields;
            var aux = new Service {Timeout = (60*60*1000)};
            dsRepPadron1.Merge(aux.GetPadron(Fecha, IdZona, Program.Pin));
            crPadron1.SetDataSource(dsRepPadron1);

            _crParameterFieldLocation = _crParameterFieldDefinitions["Fecha"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = Fecha};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);

            _crParameterFieldLocation = _crParameterFieldDefinitions["Zona"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = NombreZona};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}