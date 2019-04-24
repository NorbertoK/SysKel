using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCAutorizaciones : Component
    {
        public CmpABCAutorizaciones()
        {
            InitializeComponent();
        }

        public DsAutorizaciones GetAutorizaciones()
        {
            var ret = new DsAutorizaciones();
            autorizacionesTableAdapter1.Fill(ret.Autorizaciones);
            return ret;
        }

        public DsAutorizaciones UpdateAutorizaciones(DsAutorizaciones auto)
        {
            try
            {
                autorizacionesTableAdapter1.Update(auto.Autorizaciones);
            }
            catch
            {
                return null;
            }
            return auto;
        }
    }
}