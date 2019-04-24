using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepCuentaCorrienteDetallada : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepCuentaCorrienteDetallada()
        {
            InitializeComponent();
        }
        public string GrupoOCliente { get; set; }

        public int Id { get; set; }

        public string Nombre { get; set; }
        private void FormRepCuentaCorrienteDetallada_Load(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_CuentaCorrienteDetallada1.DataDefinition.ParameterFields;
            ds_CuentaCorriente1.Merge(new Service().GetCuentaCorriente(GrupoOCliente, Id, Program.Pin));
            dsDetalleFacturasCliente1.Merge(new Service().GetDetalleFacturasCliente(Id,Program.Pin));
            CR_CuentaCorrienteDetallada1.SetDataSource(ds_CuentaCorriente1);
            CR_CuentaCorrienteDetallada1.Subreports[0].SetDataSource(dsDetalleFacturasCliente1);
            CR_CuentaCorrienteDetallada1.Subreports[1].SetDataSource(dsDetalleFacturasCliente1);
            CR_CuentaCorrienteDetallada1.Subreports[2].SetDataSource(dsDetalleFacturasCliente1);
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
