using System;
using Cabina.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Cabina
{
    public partial class FormRepCaja : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepCaja()
        {
            InitializeComponent();
        }

        public int IdEmpleado { private get; set; }

        public DateTime Desde { private get; set; }

        public DateTime Hasta { private get; set; }

        public string Titulo { private get; set; }

        private void FormRepCajaLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_Caja1.DataDefinition.ParameterFields;
            var aux = new Service {Timeout = 60*60*1000};
            ds_Caja1.Merge(aux.GetCaja(IdEmpleado, Desde.ToString("yyyyMMdd"), Hasta.ToString("yyyyMMdd"), Program.Pin));
            CR_Caja1.SetDataSource(ds_Caja1);
            AgregarParametro("Titulo", Titulo);
            AgregarParametro("Periodo", Desde.ToString("dd/MM/yyyy") + " al " + Hasta.ToString("dd/MM/yyyy"));
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