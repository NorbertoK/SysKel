using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepBancoMacro : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepBancoMacro()
        {
            InitializeComponent();
        }
        public bool Jubilado { private get; set; }
        public string Periodo { private get; set; }
        public string Titulo { private get; set; }
        private void FormRepBancoMacroLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_BancoMacro1.DataDefinition.ParameterFields;
            if (Titulo == "Banco Macro")
            {
                dsReporteMacro1.Merge(new Service().GetReporteMacro(Jubilado, Periodo, Program.Pin));
                CR_BancoMacro1.SetDataSource(dsReporteMacro1.Tables["BancoMacro"]);
            }
            if (Titulo == "Argencard")
            {
                dsReporteMacro1.Merge(new Service().GetReporteArgencard(Periodo, Program.Pin));
                CR_BancoMacro1.SetDataSource(dsReporteMacro1.Tables["Argencard"]);
            }
            if (Titulo == "Tarjeta Naranja")
            {
                dsReporteNaranja1.Merge(new Service().GetReporteNaranjaInforme(Periodo, Program.Pin));
                CR_BancoMacro1.SetDataSource(dsReporteNaranja1.Tables["ReporteNaranjaInforme"]);
            }
            AgregarParametro("Periodo", Periodo);
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
