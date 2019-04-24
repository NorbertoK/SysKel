using System.ComponentModel;
using System.Transactions;

namespace Administración
{
    public partial class CmpCabABCTiposDeMovil : Component
    {
        public CmpCabABCTiposDeMovil()
        {
            InitializeComponent();
        }

        public DsTiposDeMovil GetTiposDeMovil()
        {
            var ret = new DsTiposDeMovil();
            tiposDeMovilTableAdapter1.Fill(ret.TiposDeMovil);
            return ret;
        }

        public DsTiposDeMovil UpdateTiposDeMovil(DsTiposDeMovil tdem)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    tiposDeMovilTableAdapter1.Update(tdem.TiposDeMovil);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return tdem;
            }
        }
    }
}