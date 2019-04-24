namespace Administración.DsRepPadronTableAdapters
{
    public partial class PadronTableAdapter
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
    partial class DsRepPadron
    {
    }
}