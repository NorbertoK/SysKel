﻿using System;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Administración
{
    public partial class FormRepFacturadoYCobrado : FormCR
    {
        private ParameterDiscreteValue _crParameterDiscreteValue = new ParameterDiscreteValue();
        private ParameterFieldDefinitions _crParameterFieldDefinitions;
        private ParameterFieldDefinition _crParameterFieldLocation;
        private ParameterValues _crParameterValues = new ParameterValues();
        public FormRepFacturadoYCobrado()
        {
            InitializeComponent();
        }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        private void FormFacturadoYCobrado_Load(object sender, EventArgs e)
        {
            _crParameterFieldDefinitions = crFacturadoYCobrado1.DataDefinition.ParameterFields;
            var aux = new Service { Timeout = (60 * 60 * 1000) };
            dsFacturadoYCobrado1.Merge(aux.GetFacturadoYCobrado(Desde.ToString("yyyyMMdd"), Hasta.ToString("yyyyMMdd"), Program.Pin));
            crFacturadoYCobrado1.SetDataSource(dsFacturadoYCobrado1);
            AgregarParametro("Periodo", Desde.ToString("dd/MM/yyyy") + " al " + Hasta.ToString("dd/MM/yyyy"));
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
