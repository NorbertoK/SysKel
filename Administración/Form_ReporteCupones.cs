using System;
using Administración.Properties;
using Administración.WS;
using CrystalDecisions.CrystalReports.Engine;

namespace Administración
{
    public partial class FormReporteCupones : Form1
    {
        public FormReporteCupones()
        {
            InitializeComponent();
        }

        public string Proceso { get; set; }
        public string Periodo { get; set; }
        public int IdTipoDeCobranza { get; set; }
        public int IdEntidadDeCobranza { get; set; }
        public int IdCobrador { get; set; }
        public string Prefijo { get; set; }
        public int IdZona { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public DateTime DesdeFecha { get; set; }
        public DateTime HastaFecha { get; set; }
        public string TodosOPendientes { get; set; }
        public string Resumen { get; set; }
        public string Comprobantes { get; set; }

        private void FormReporteCuponesLoad(object sender, EventArgs e)
        {
            ReportClass cr = null;
            ReportClass crCResumen;
            if (Settings.Default.Empresa == "SAE")
            {
                if (Comprobantes == "C")
                    cr = crComprobantes31;
                //if (Comprobantes == "A")
                //    cr = crFacturaA_Afiliados;
                //if (Comprobantes == "B")
                //    cr = crFacturaB_Afiliados;
                crCResumen = crComprobantesConResumen31;
            }

            else
            {
                cr = crComprobantes1;
                crCResumen = crComprobantesConResumen1;
            }

            if (Resumen == "Si")
            {
                crystalReportViewer1.ReportSource = crCResumen;
                var aux = new Service {Timeout = (60*60*1000)};
                dsReportComprobantes1.Merge(aux.GetReportComprobantes(Periodo, IdTipoDeCobranza, IdEntidadDeCobranza,
                                                                      IdCobrador, Prefijo, IdZona, Desde, Hasta,
                                                                      DesdeFecha.ToString("yyyyMMdd HH:mm:ss"),
                                                                      HastaFecha.ToString("yyyyMMdd HH:mm:ss"),
                                                                      TodosOPendientes, Comprobantes, Program.Pin));
                crCResumen.SetDataSource(dsReportComprobantes1);
            }
            else
            {
                crystalReportViewer1.ReportSource = cr;
                var aux = new Service {Timeout = (60*60*1000)};
                if (Proceso == "Nulo")
                {
                    dsReportComprobantes1.Merge(aux.GetReportComprobantes(Periodo, IdTipoDeCobranza, IdEntidadDeCobranza,
                                                                          IdCobrador, Prefijo, IdZona, Desde, Hasta,
                                                                          DesdeFecha.ToString("yyyyMMdd HH:mm:ss"),
                                                                          HastaFecha.ToString("yyyyMMdd HH:mm:ss"),
                                                                          TodosOPendientes, Comprobantes, Program.Pin));
                }
                else
                {
                    dsReportComprobantes1.Merge(aux.GetReportComprobantesPorProceso(Proceso, Program.Pin));
                    new Service().EliminarProceso(Proceso, Program.Pin);
                }
                if (cr != null) cr.SetDataSource(dsReportComprobantes1);
            }
        }
    }
}