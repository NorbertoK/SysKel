namespace Administración.DsRepTasaDeUsoTableAdapters
{
    public partial class TasaDeUsoTableAdapter
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
    
    
    public partial class DsRepTasaDeUso {
    }
}
