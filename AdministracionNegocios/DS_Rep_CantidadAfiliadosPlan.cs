namespace Administración.DsRepCantidadAfiliadosPlanTableAdapters
{
    public partial class CantidadAfiliadosPlanTableAdapter
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
    partial class DsRepCantidadAfiliadosPlan
    {
    }
}