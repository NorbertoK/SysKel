using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepFacturadoClientes : FormCR
    {
        //private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        //private ParameterFieldDefinitions _crParameterFieldDefinitions;
        //private ParameterFieldDefinition _crParameterFieldLocation;
        //private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepFacturadoClientes()
        {
            InitializeComponent();
        }

        public string DesdePeriodo { get; set; }
        public string HastaPeriodo { get; set; }

        private void FormRepFacturadoClientesLoad(object sender, EventArgs e)
        {
            //_crParameterFieldDefinitions = crFacturadoClientes.DataDefinition.ParameterFields;
            var aux = new Service {Timeout = (60*60*1000)};
            dsFacturadoClientes.Merge(aux.GetFacturadoClientes(DesdePeriodo, HastaPeriodo,
                                                               Program.Pin));
            crFacturadoClientes.SetDataSource(dsFacturadoClientes);
            //AgregarParametro("DesdePeriodo", DesdePeriodo);
            //AgregarParametro("HastaPeriodo", HastaPeriodo);
        }

        //private void AgregarParametro(string nombreParametro, string valorParametro)
        //{
        //    _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
        //    _crParameterValues = _crParameterFieldLocation.CurrentValues;
        //    _crParameterDiscreteValue = new ParameterDiscreteValue {Value = valorParametro};
        //    _crParameterValues.Add(_crParameterDiscreteValue);
        //    _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        //}
    }
}