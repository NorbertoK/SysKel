using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepEstPrestLocalidadCodigo : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();

        public FormRepEstPrestLocalidadCodigo()
        {
            InitializeComponent();
        }

        public DateTime Desde { private get; set; }

        public DateTime Hasta { private get; set; }

        private void FormRepEstPrestLocalidadCodigoLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crEstPrestLocalidadCodigo1.DataDefinition.ParameterFields;
            dsRepPrestCodigoLocalidad1.Merge(new Service().GetPrestacionesCodigoLocalidad(
                                                 Desde.ToString("yyyyMMdd"), Hasta.ToString("yyyyMMdd"), Program.Pin));
            crEstPrestLocalidadCodigo1.SetDataSource(dsRepPrestCodigoLocalidad1);
            AgregarParametro("Desde", Desde);
            AgregarParametro("Hasta", Hasta);
        }

        private void AgregarParametro(string nombreParametro, DateTime valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue {Value = valorParametro};
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}