using System.ComponentModel;

namespace Administración
{
    public partial class CmpCabABCCoberturas : Component
    {
        public CmpCabABCCoberturas()
        {
            InitializeComponent();
        }

        public DsCoberturas GetCoberturas()
        {
            var ret = new DsCoberturas();
            coberturasTableAdapter1.Fill(ret.Coberturas);
            return ret;
        }

        public DsCoberturas UpdateCoberturas(DsCoberturas cob)
        {
            try
            {
                coberturasTableAdapter1.Update(cob.Coberturas);
            }
            catch
            {
                return null;
            }
            return cob;
        }
    }
}