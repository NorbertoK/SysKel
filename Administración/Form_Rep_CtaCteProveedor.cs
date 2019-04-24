using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepCtaCteProveedor : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepCtaCteProveedor()
        {
            InitializeComponent();
        }
        public int IdProveedor { get; set; }

        public string Nombre { get; set; }

        private void FormRepCtaCteProveedorLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_CuentaCorrienteProveedor1.DataDefinition.ParameterFields;
            dsCuentaCorrienteProveedor1.Merge(new Service().GetCuentaCorrienteProveedor(IdProveedor, Program.Pin));
            CR_CuentaCorrienteProveedor1.SetDataSource(dsCuentaCorrienteProveedor1);
            AgregarParametro("Nombre", Nombre);
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
