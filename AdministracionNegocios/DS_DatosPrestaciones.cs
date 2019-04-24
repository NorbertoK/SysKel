namespace Administración.DsDatosPrestacionesTableAdapters
{
    public partial class DatosPrestacionesTableAdapter
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

    
    public partial class DsDatosPrestaciones {
    }
}
