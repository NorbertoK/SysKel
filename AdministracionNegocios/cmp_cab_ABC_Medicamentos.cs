using System.ComponentModel;
using System.Data;
using System.Transactions;

namespace Administración
{
    public partial class CmpCabABCMedicamentos : Component
    {
        public CmpCabABCMedicamentos()
        {
            InitializeComponent();
        }

        public DsMedicamentos GetMedicamentos()
        {
            var ret = new DsMedicamentos();
            medicamentosCategoriasTableAdapter1.Fill(ret.MedicamentosCategorias);
            medicamentosTableAdapter1.Fill(ret.Medicamentos);
            return ret;
        }

        public DsMedicamentos UpdateMedicamentos(DsMedicamentos medi)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    medicamentosCategoriasTableAdapter1.Update(medi.MedicamentosCategorias.Select("", "",
                                                                                                  DataViewRowState.Added |
                                                                                                  DataViewRowState.
                                                                                                      ModifiedCurrent));
                    medicamentosTableAdapter1.Update(medi.Medicamentos);
                    medicamentosCategoriasTableAdapter1.Update(medi.MedicamentosCategorias);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return medi;
            }
        }
    }
}