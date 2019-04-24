namespace Administración.DsDeudoresTableAdapters
{
    public partial class DeudoresTableAdapter
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
namespace Administración {
    
    
    public partial class DsDeudores {
        partial class DeudoresDataTable
        {
        }
    }
}
