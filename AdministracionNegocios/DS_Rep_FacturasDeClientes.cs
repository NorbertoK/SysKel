namespace Administración.DsRepFacturasDeClientesTableAdapters
{
    public partial class FacturasDeClientesTableAdapter
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
    partial class DsRepFacturasDeClientes
    {
        #region Nested type: FacturasDeClientesDataTable

        partial class FacturasDeClientesDataTable
        {
        }

        #endregion
    }
}