using System.ComponentModel;
using System.Transactions;

namespace Administración
{
    public partial class CmpCabABCMoviles : Component
    {
        public CmpCabABCMoviles()
        {
            InitializeComponent();
        }

        public DsMoviles GetMoviles()
        {
            var ret = new DsMoviles();
            movilesTableAdapter1.Fill(ret.Moviles);
            return ret;
        }

        public DsMoviles UpdateMoviles(DsMoviles movi)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    movilesTableAdapter1.Update(movi.Moviles);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return movi;
            }
        }

        public DsMovilesLista GetMovilesLista()
        {
            var ret = new DsMovilesLista();
            movilesListaTableAdapter1.Fill(ret.MovilesLista);
            return ret;
        }
    }
}