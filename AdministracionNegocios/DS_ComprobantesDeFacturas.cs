namespace Administración.DsComprobantesDeFacturasTableAdapters
{
    public partial class FuncReporteComprobantesDeFacturasTableAdapter
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
    partial class DsComprobantesDeFacturas
    {
        #region Nested type: FuncReporteComprobantesDeFacturasDataTable

        partial class FuncReporteComprobantesDeFacturasDataTable
        {
        }

        #endregion
    }
}