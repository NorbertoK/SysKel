namespace Administración.DsListaCorreoTableAdapters
{
    public partial class ListaCorreoTableAdapter
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
    
    
    public partial class DsListaCorreo {
    }
}
