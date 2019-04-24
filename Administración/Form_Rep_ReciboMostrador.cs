using System;
using Administración.Properties;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepReciboMostrador : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepReciboMostrador()
        {
            InitializeComponent();
        }
        public int IdRemesa { get; set; }
        private void FormRepReciboMostrador_Load(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_ReciboMostrador1.DataDefinition.ParameterFields;
            dsReportRemesa1.Merge(new Service().GetReporteRemesa(IdRemesa, Program.Pin));
            CR_ReciboMostrador1.SetDataSource(dsReportRemesa1);
            AgregarParametro("Empresa", Settings.Default.Empresa);
            AgregarParametro("Empleado", new Service().NombreDelUsuario(Program.IdUsuario, Program.Pin));
            AgregarParametro("Numero", string.Format("{0:##,#}",dsReportRemesa1.Remesa.Rows[0]["Caja"])); 
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
