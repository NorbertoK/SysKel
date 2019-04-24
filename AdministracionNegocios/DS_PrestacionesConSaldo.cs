namespace Administración.DsPrestacionesConSaldoTableAdapters
{
    public partial class PrestacionesConSaldoTableAdapter
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
    public partial class DsPrestacionesConSaldo
    {
    }
}