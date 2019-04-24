using System;
using System.ComponentModel;
using System.Data;
using System.Transactions;

namespace Administración
{
    public partial class CmpRenglonesFP : Component
    {
        public CmpRenglonesFP()
        {
            InitializeComponent();
        }

        public DsRenglonesDeFactura GetRenglonesFP()
        {
            var ret = new DsRenglonesDeFactura();
            clientesRFPTableAdapter1.Fill(ret.Clientes);
            facturasProformaRFPTableAdapter1.Fill(ret.FacturasProforma);
            renglonesFPTableAdapter1.Fill(ret.RenglonesFacturaProforma);
            return ret;
        }

        public DsRenglonesDeFactura UpdateRenglonesFP(DsRenglonesDeFactura rfp)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    /* Primero agrego o modifico los padres y después los hijos */
                    clientesRFPTableAdapter1.Update(rfp.Clientes.Select("", "",
                                                                        DataViewRowState.Added |
                                                                        DataViewRowState.ModifiedCurrent));
                    facturasProformaRFPTableAdapter1.Update(rfp.FacturasProforma.Select("", "",
                                                                                        DataViewRowState.Added |
                                                                                        DataViewRowState.ModifiedCurrent));
                    renglonesFPTableAdapter1.Update(rfp.RenglonesFacturaProforma.Select("", "",
                                                                                        DataViewRowState.Added |
                                                                                        DataViewRowState.ModifiedCurrent));
                    /* Primero elimino a los hijos y después a los padres */
                    renglonesFPTableAdapter1.Update(rfp.RenglonesFacturaProforma);
                    facturasProformaRFPTableAdapter1.Update(rfp.FacturasProforma);
                    clientesRFPTableAdapter1.Update(rfp.Clientes);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return rfp;
            }
        }

        public DsContratosLista GetContratosListaFP()
        {
            var ret = new DsContratosLista();
            contratosRenglonFPTableAdapter1.Fill(ret.ContratosRenglonFP);
            return ret;
        }

        public DsHist_RenglonesFacturaProforma GetHistorialRenglonesPorFecha(DateTime fecha)
        {
            var ret = new DsHist_RenglonesFacturaProforma();
            view_Hist_RenglonesFacturaProformaTableAdapter1.FillByFecha(ret.View_Hist_RenglonesFacturaProforma,fecha);
            return ret;
        }

        public DsHist_RenglonesFacturaProforma GetHistorialRenglonesPorCliente(string cliente)
        {
            var ret = new DsHist_RenglonesFacturaProforma();
            view_Hist_RenglonesFacturaProformaTableAdapter1.FillByCliente(ret.View_Hist_RenglonesFacturaProforma, cliente);
            return ret;
        }

        public DsHist_RenglonesFacturaProforma GetHistorialRenglonesSinActualizar(DateTime fecha)
        {
            var ret = new DsHist_RenglonesFacturaProforma();
            view_Hist_RenglonesFacturaProformaTableAdapter1.FillBySinActualizar(ret.View_Hist_RenglonesFacturaProforma, fecha);
            return ret;
        }
        
        public DsHist_Planes GetHistorialPlanesPorFecha(DateTime fecha)
        {
            var ret = new DsHist_Planes();
            view_Hist_PlanesTableAdapter1.Fill(ret.View_Hist_Planes, fecha);
            return ret;
        }

        public DsHist_Recursos GetHistorialRecursosPorFecha(DateTime desde, DateTime hasta)
        {
            var ret = new DsHist_Recursos();
            view_Hist_RecursosTableAdapter1.Fill(ret.View_Hist_Recursos, desde, hasta);
            return ret;
        }

        public DsHist_Recursos GetHistorialRecursosPorFechaYChofer(DateTime desde, DateTime hasta, string chofer)
        {
            var ret = new DsHist_Recursos();
            view_Hist_RecursosTableAdapter1.FillByChofer(ret.View_Hist_Recursos, desde, hasta, chofer);
            return ret;
        }
        public DsHist_Recursos GetHistorialRecursosPorFechaYMedico(DateTime desde, DateTime hasta, string medico)
        {
            var ret = new DsHist_Recursos();
            view_Hist_RecursosTableAdapter1.FillByMedico(ret.View_Hist_Recursos, desde, hasta, medico);
            return ret;
        }
        public DsHist_Recursos GetHistorialRecursosPorFechaYMovil(DateTime desde, DateTime hasta, string movil)
        {
            var ret = new DsHist_Recursos();
            view_Hist_RecursosTableAdapter1.FillByMovil(ret.View_Hist_Recursos, desde, hasta, movil);
            return ret;
        }
        public DsHist_Recursos GetHistorialRecursosPorFechaYParamedico(DateTime desde, DateTime hasta, string paramedico)
        {
            var ret = new DsHist_Recursos();
            view_Hist_RecursosTableAdapter1.FillByParamedico(ret.View_Hist_Recursos, desde, hasta, paramedico);
            return ret;
        }
        public DsHist_Recursos GetHistorialRecursosPorFechaYRecurso(DateTime desde, DateTime hasta, string recurso)
        {
            var ret = new DsHist_Recursos();
            view_Hist_RecursosTableAdapter1.FillByRecurso(ret.View_Hist_Recursos, desde, hasta, recurso);
            return ret;
        }
    }
}