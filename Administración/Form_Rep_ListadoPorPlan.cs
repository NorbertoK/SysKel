using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepListadoPorPlan : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        private DateTime _fecha = new Service().HoraActual(Program.Pin);
        private string _nombrePlan = "";

        public FormRepListadoPorPlan()
        {
            InitializeComponent();
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public int IdPlan { get; set; }

        public string NombrePlan
        {
            get { return _nombrePlan; }
            set { _nombrePlan = value; }
        }

        private void FormRepListadoPorPlanLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crListadoPorPlan.DataDefinition.ParameterFields;
            var aux = new Service {Timeout = (60*60*1000)};
            dsRepListadoPorPlan.Merge(aux.GetListadoPorPlan(IdPlan, Fecha.ToString("yyyyMMdd"), Program.Pin));
            crListadoPorPlan.SetDataSource(dsRepListadoPorPlan);

            _crParameterFieldLocation = _crParameterFieldDefinitions["Fecha"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = Fecha};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);

            _crParameterFieldLocation = _crParameterFieldDefinitions["nPlan"];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = NombrePlan};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}