using System;
using Cabina.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Cabina
{
    public partial class FormRepTurnosPorFrase : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepTurnosPorFrase()
        {
            InitializeComponent();
        }

        public string Frase { get; set; }
        public string Busqueda { get; set; }
        private void FormReportTurnosPorFraseLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_TurnoPorFrase1.DataDefinition.ParameterFields;
            dsTurnosImprimir1.Merge(new Service().GetTurnosPorFrase(Frase, Program.Pin));
            CR_TurnoPorFrase1.SetDataSource(dsTurnosImprimir1);
            AgregarParametro("Busqueda", Busqueda);
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
