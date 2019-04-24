using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepHistRecursos : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepHistRecursos()
        {
            InitializeComponent();
        }
        public string Titulo { get; set; }
        public string Filtro { get; set; }
        public string Chofer { get; set; }
        public string Medico { get; set; }
        public string Movil { get; set; }
        public string Paramedico { get; set; }
        public string Recurso { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        private void FormRepHistRecursosLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_Hist_Recursos1.DataDefinition.ParameterFields;
            switch (Filtro)
            {
                case "Fecha":
                    dsHist_Recursos1.Merge(new Service().GetHistorialRecursosPorFecha(Desde,Hasta,Program.Pin));
                    break;
                case "Chofer":
                    dsHist_Recursos1.Merge(new Service().GetHistorialRecursosPorFechaYChofer(Desde, Hasta,Chofer, Program.Pin));
                    break;
                case "Medico":
                    dsHist_Recursos1.Merge(new Service().GetHistorialRecursosPorFechaYMedico(Desde, Hasta,Medico, Program.Pin));
                    break;
                case "Movil":
                    dsHist_Recursos1.Merge(new Service().GetHistorialRecursosPorFechaYMovil(Desde, Hasta, Movil, Program.Pin));
                    break;
                case "Paramedico":
                    dsHist_Recursos1.Merge(new Service().GetHistorialRecursosPorFechaYParamedico(Desde, Hasta,Paramedico,Program.Pin));
                    break;
                case "Recurso":
                    dsHist_Recursos1.Merge(new Service().GetHistorialRecursosPorFechaYRecurso(Desde, Hasta, Recurso, Program.Pin));
                    break;
            }
            CR_Hist_Recursos1.SetDataSource(dsHist_Recursos1);
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
