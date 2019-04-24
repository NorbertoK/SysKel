using System.ComponentModel;
using System.Data;
using System.Transactions;

namespace Administración
{
    public partial class CmpCabABCDiagnosticos : Component
    {
        public CmpCabABCDiagnosticos()
        {
            InitializeComponent();
        }

        public DsDiagnosticos GetDiagnosticos()
        {
            var ret = new DsDiagnosticos();
            diagnosticosCategoriaTableAdapter1.Fill(ret.DiagnosticosCategoria);
            diagnosticosTableAdapter1.Fill(ret.Diagnosticos);
            return ret;
        }

        public DsDiagnosticos UpdateDiagnosticos(DsDiagnosticos diag)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    diagnosticosCategoriaTableAdapter1.Update(diag.DiagnosticosCategoria.Select("", "",
                                                                                                DataViewRowState.Added |
                                                                                                DataViewRowState.
                                                                                                    ModifiedCurrent));
                    diagnosticosTableAdapter1.Update(diag.Diagnosticos);
                    diagnosticosCategoriaTableAdapter1.Update(diag.DiagnosticosCategoria);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return diag;
            }
        }
    }
}