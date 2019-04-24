using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepHistRenglonesFacturaModelo : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepHistRenglonesFacturaModelo()
        {
            InitializeComponent();
        }
        public string Titulo { get; set; }
        public string Filtro { get; set; }
        public string Cliente { get; set; }
        public DateTime Desde { get; set; }

        private void CrystalReportViewer1Load(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = CR_Hist_RenglonesFacturaProforma1.DataDefinition.ParameterFields;
            if (Filtro == "Cliente")
                dsHist_RenglonesFacturaProforma1.Merge(new Service().GetHistorialRenglonesPorCliente(Cliente, Program.Pin));
            if(Filtro=="Fecha")
                dsHist_RenglonesFacturaProforma1.Merge(new Service().GetHistorialRenglonesPorFecha(Desde, Program.Pin));
            if (Filtro == "SinActualizar")
                dsHist_RenglonesFacturaProforma1.Merge(new Service().GetHistorialRenglonesSinActualizar(Desde, Program.Pin));
            CR_Hist_RenglonesFacturaProforma1.SetDataSource(dsHist_RenglonesFacturaProforma1);
            AgregarParametro("Titulo", Titulo);
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
