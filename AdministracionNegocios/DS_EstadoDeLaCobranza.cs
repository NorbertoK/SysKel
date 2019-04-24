namespace Administración.DsEstadoDeLaCobranzaTableAdapters
{
    public partial class EstadoDeLaCobranzaTableAdapter
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
    
    public partial class DsEstadoDeLaCobranza {
    }
}
