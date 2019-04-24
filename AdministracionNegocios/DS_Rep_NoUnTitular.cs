namespace Administración.DsRepNoUnTitularTableAdapters
{
    public partial class AfiliadosNoUnTitularTableAdapter
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
    partial class DsRepNoUnTitular
    {
    }
}