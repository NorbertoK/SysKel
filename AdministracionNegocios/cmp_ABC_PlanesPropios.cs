using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCPlanesPropios : Component
    {
        public CmpABCPlanesPropios()
        {
            InitializeComponent();
        }

        public CmpABCPlanesPropios(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public DsPlanesPropios GetPlanesPropios()
        {
            var ret = new DsPlanesPropios();
            planesTableAdapter1.Fill(ret.Planes);
            return ret;
        }

        public DsPlanesPropios UpdatePlanesPropios(DsPlanesPropios planes)
        {
            try
            {
                planesTableAdapter1.Update(planes.Planes);
            }
            catch
            {
                return null;
            }
            return planes;
        }

        public DsPlanes GetPlanesContratos()
        {
            var ret = new DsPlanes();
            planesContratoTableAdapter1.Fill(ret.PlanesContrato);
            return ret;
        }

        public DsPlanes UpdatePlanesContratos(DsPlanes planes)
        {
            try
            {
                planesContratoTableAdapter1.Update(planes.PlanesContrato);
            }
            catch
            {
                return null;
            }
            return planes;
        }

        public DsProtecciones GetProtecciones()
        {
            var ret = new DsProtecciones();
            proteccionesTableAdapter1.Fill(ret.Protecciones);
            return ret;
        }

        public DsProtecciones UpdateProtecciones(DsProtecciones prot)
        {
            try
            {
                proteccionesTableAdapter1.Update(prot.Protecciones);
            }
            catch
            {
                return null;
            }
            return prot;
        }

        public DsPlanesParaReporte GetPlanesParaReporte()
        {
            var ret = new DsPlanesParaReporte();
            planesParaReporteTableAdapter1.Fill(ret.PlanesParaReporte);
            return ret;
        }
        public DsEstadisticaPlanes GetEstadisticaPlanes(string fecha)
        {
            var ret = new DsEstadisticaPlanes();
            estadisticaPlanesTableAdapter1.Fill(ret.EstadisticaPlanes, fecha);
            return ret;
        }
    }
}