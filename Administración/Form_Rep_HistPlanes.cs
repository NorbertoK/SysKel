using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepHistPlanes : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepHistPlanes()
        {
            InitializeComponent();
        }
        public string Titulo { get; set; }
        public DateTime Desde { get; set; }
        private void FormRepHistPlanesLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_Hist_Planes1.DataDefinition.ParameterFields;
                dsHist_Planes1.Merge(new Service().GetHistorialPlanesPorFecha(Desde, Program.Pin));
                CR_Hist_Planes1.SetDataSource(dsHist_Planes1);
            AgregarParametro("Titulo", Titulo);
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
