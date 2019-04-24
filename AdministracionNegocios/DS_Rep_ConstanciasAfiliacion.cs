namespace Administración.DsRepConstanciasAfiliacionTableAdapters
{
    public partial class ConstanciasAfiliacionTableAdapter
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
    partial class DsRepConstanciasAfiliacion
    {
    }
}