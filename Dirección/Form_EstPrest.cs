using System;
using System.Windows.Forms;
using Dirección.WS;

namespace Dirección
{
    public partial class FormEstPrest : Form
    {
        public FormEstPrest()
        {
            InitializeComponent();
        }

        private void FormEstPrestLoad(object sender, EventArgs e)
        {
            ultraCalendarComboDesde.Value = new Service().HoraActual(Program.Pin);
            ultraCalendarComboHasta.Value = new Service().HoraActual(Program.Pin);
        }

        private void UltraComboReportesValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            var reporte = ultraComboReportes.Value.ToString();
            switch (reporte)
            {
                case "LocCod":
                    {
                        buttonAceptar.Enabled = false;
                        buttonCancelar.Enabled = false;
                        var f = new FormRepEstPrestLocalidadCodigo
                                    {
                                        Desde = ((DateTime) ultraCalendarComboDesde.Value),
                                        Hasta = ((DateTime) ultraCalendarComboHasta.Value),
                                        MdiParent = MdiParent
                                    };
                        f.Show();
                        Close();
                    }
                    break;
                case "CodLoc":
                    {
                        buttonAceptar.Enabled = false;
                        buttonCancelar.Enabled = false;
                        var f = new FormRepEstPrestCodigoLocalidad
                                    {
                                        Desde = ((DateTime) ultraCalendarComboDesde.Value),
                                        Hasta = ((DateTime) ultraCalendarComboHasta.Value),
                                        MdiParent = MdiParent
                                    };
                        f.Show();
                        Close();
                    }
                    break;
                case "LocMotCod":
                    {
                        buttonAceptar.Enabled = false;
                        buttonCancelar.Enabled = false;
                        var f = new FormRepEstPrestLocalidadMotivoCodigo
                                    {
                                        Desde = ((DateTime)ultraCalendarComboDesde.Value),
                                        Hasta = ((DateTime)ultraCalendarComboHasta.Value),
                                        MdiParent = MdiParent
                                    };
                        f.Show();
                        Close();
                    }
                    break;
                case "MedicUtil":
                    {
                        buttonAceptar.Enabled = false;
                        buttonCancelar.Enabled = false;
                        var f = new FormRepEstPrestMedicamentosUtilizados
                                    {
                                        Desde = ((DateTime)ultraCalendarComboDesde.Value),
                                        Hasta = ((DateTime)ultraCalendarComboHasta.Value),
                                        MdiParent = MdiParent
                                    };
                        f.Show();
                        Close();
                    }
                    break;
            }
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void UltraComboReportesItemNotInList(object sender, Infragistics.Win.UltraWinEditors.ValidationErrorEventArgs e)
        {
            if (e.InvalidText == "" || e.InvalidText == "Elija el reporte...")
            {
                e.RetainFocus = false; // Permite que haya valores nulos.
            }
        }
    }
}