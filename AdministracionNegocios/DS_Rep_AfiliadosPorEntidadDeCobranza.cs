namespace Administración.DsRepAfiliadosPorEntidadDeCobranzaTableAdapters
{
    public partial class AfiliadosPorEntidadDeCobranzaTableAdapter
    {
        public void SetTimeOut()
        {
            foreach (var command in CommandCollection)
            {
                command.CommandTimeout = 0;
            }
        }
    }
}

namespace Administración
{
    partial class DsRepAfiliadosPorEntidadDeCobranza
    {
    }
}