using System.ComponentModel;

namespace Administración
{
    public partial class CmpEstadoActualDelGrupo : Component
    {
        public CmpEstadoActualDelGrupo()
        {
            InitializeComponent();
        }

        public DsEstadoActualDelGrupo GetEstadoActualDelGrupo(int idGrupo)
        {
            var ret = new DsEstadoActualDelGrupo();
            estadoAfiliadosDelGrupoTableAdapter1.Fill(ret.EstadoAfiliadosDelGrupo, idGrupo);
            return ret;
        }
    }
}