using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCCodigos : Component
    {
        public CmpABCCodigos()
        {
            InitializeComponent();
        }

        public DsCodigos GetCodigos()
        {
            var ret = new DsCodigos();
            codigosTableAdapter1.Fill(ret.Codigos);
            return ret;
        }

        public DsCodigos UpdateCodigos(DsCodigos codigos)
        {
            try
            {
                codigosTableAdapter1.Update(codigos.Codigos);
            }
            catch
            {
                return null;
            }
            return codigos;
        }
    }
}