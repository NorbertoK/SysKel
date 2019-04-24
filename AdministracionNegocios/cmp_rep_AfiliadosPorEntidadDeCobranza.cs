using System.ComponentModel;

namespace Administración
{
    public partial class CmpRepAfiliadosPorEntidadDeCobranza : Component
    {
        public CmpRepAfiliadosPorEntidadDeCobranza()
        {
            InitializeComponent();
        }

        public DsRepAfiliadosPorEntidadDeCobranza GetAfiliadosPorEntidadDeCobranza(int id)
        {
            var ret = new DsRepAfiliadosPorEntidadDeCobranza();
            afiliadosPorEntidadDeCobranzaTableAdapter1.SetTimeOut();
            afiliadosPorEntidadDeCobranzaTableAdapter1.Fill(ret.AfiliadosPorEntidadDeCobranza, id);
            return ret;
        }

        public DsRepListadoFacturadoPorEntidad GetListadoFacturadoPorEntidad(int idEntidadDeCobranza, string periodo)
        {
            var ret = new DsRepListadoFacturadoPorEntidad();
            listadoFacturadoPorEntidadDeCobranzaTableAdapter1.Fill(ret.ListadoFacturadoPorEntidadDeCobranza,
                                                                   idEntidadDeCobranza, periodo);
            return ret;
        }
    }
}