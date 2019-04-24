using System;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Cabina
{
    public partial class FormRepInformeAsistencia : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepInformeAsistencia()
        {
            InitializeComponent();
        }
        public DateTime Fecha { get; set; }
        public int Prestacion { get; set; }
        public string Movil { get; set; }
        public string Medico { get; set; }
        public int Matricula { get; set; }
        public string Paciente { get; set; }
        public string Socio { get; set; }
        public string Edad { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Antecedentes { get; set; }
        public string Motivos { get; set; }
        private void FormRepInformeAsistenciaLoad(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_InformeAsistencia1.DataDefinition.ParameterFields;
            AgregarParametroFecha("Fecha", Fecha);
            AgregarParametroInt("Prestacion", Prestacion);
            AgregarParametroString("Movil", Movil);
            AgregarParametroString("Medico", Medico);
            AgregarParametroInt("Matricula", Matricula);
            AgregarParametroString("Paciente", Paciente);
            AgregarParametroString("Socio", Socio);
            AgregarParametroString("Edad", Edad);
            AgregarParametroString("Domicilio", Domicilio);
            AgregarParametroString("Telefono", Telefono);
            AgregarParametroString("Antecedentes", Antecedentes);
            AgregarParametroString("Motivos", Motivos);
        }
        private void AgregarParametroFecha(string nombreParametro, DateTime valorParametro)
        {
            _crParameterFieldLocation = _crParameterFieldDefinitions[nombreParametro];
            _crParameterValues = _crParameterFieldLocation.CurrentValues;
            _crParameterDiscreteValue = new ParameterDiscreteValue { Value = valorParametro };
            _crParameterValues.Add(_crParameterDiscreteValue);
            _crParameterFieldLocation.ApplyCurrentValues(_crParameterValues);
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
