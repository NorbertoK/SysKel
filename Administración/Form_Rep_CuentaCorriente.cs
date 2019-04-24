using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepCuentaCorriente : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepCuentaCorriente()
        {
            InitializeComponent();
        }

        public string GrupoOCliente { get; set; }

        public int Id { get; set; }

        public string Nombre { get; set; }

        private void FormRepCuentaCorrienteLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_CuentaCorriente1.DataDefinition.ParameterFields;
            ds_CuentaCorriente1.Merge(new Service().GetCuentaCorriente(GrupoOCliente, Id, Program.Pin));
            CR_CuentaCorriente1.SetDataSource(ds_CuentaCorriente1);
            AgregarParametro("Nombre", Nombre);
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