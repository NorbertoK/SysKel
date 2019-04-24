namespace
    Administración.DsRepResumenPrestacionesPorClienteTableAdapters
{
    public partial class ResumenPrestacionesPorClienteSoloDomiciliosTableAdapter
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
    
    
    public partial class DsRepResumenPrestacionesPorCliente {
    }
}
