using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepInformeFacturasClientes : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepInformeFacturasClientes()
        {
            InitializeComponent();
        }

        public string Periodo { private get; set; }

        public int IdPuntoDeVenta { private get; set; }

        public string PuntoDeVenta { private get; set; }

        private void FormRepInformeFacturasClientesLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crInformeFacturasDeClientes1.DataDefinition.ParameterFields;
            var aux = new Service {Timeout = (60*60*1000)};
            dsRepFacturasDeClientes1.Merge(aux.GetFacturasDeClientes(Periodo, IdPuntoDeVenta, Program.Pin));
            crInformeFacturasDeClientes1.SetDataSource(dsRepFacturasDeClientes1);
            AgregarParametro("PuntoDeVenta", PuntoDeVenta);
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