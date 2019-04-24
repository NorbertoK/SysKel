using System;
using Cabina.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Cabina
{
    public partial class FormRepTurnos : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepTurnos()
        {
            InitializeComponent();
        }
        public DateTime Fecha { get; set; }
        private void FormRepTurnosLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_Turnos1.DataDefinition.ParameterFields;
            dsTurnosImprimir1.Merge(new Service().GetTurnosImprimir(Fecha, Program.Pin));
            CR_Turnos1.SetDataSource(dsTurnosImprimir1);
            AgregarParametroFecha("Fecha", Fecha);
        }
        private void AgregarParametroFecha(string nombreParametro, DateTime valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue { Value = valorParametro };
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}
