using System;
using Dirección.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Dirección
{
    public partial class FormRepTasaDeUsoCliNum : FormCR
    {
        public FormRepTasaDeUsoCliNum()
        {
            InitializeComponent();
        }

        public DsRepTasaDeUso DsRepTasaDeUso1;
        public string Subtitulo;
        public string Periodo;
        public int Filtro;
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        private void FormRepTasaDeUsoLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_TasaDeUsoCliNum1.DataDefinition.ParameterFields;
            CR_TasaDeUsoCliNum1.SetDataSource(DsRepTasaDeUso1);
            AgregarParametroString("Subtitulo", Subtitulo);
            AgregarParametroString("Periodo", Periodo);
            AgregarParametroInt("Filtro", Filtro);
        }
        private void AgregarParametroString(string nombreParametro, string valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue { Value = valorParametro };
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
        private void AgregarParametroInt(string nombreParametro, int valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue { Value = valorParametro };
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
        }
    }
}
