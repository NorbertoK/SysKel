using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCSistemas : Component
    {
        public CmpABCSistemas()
        {
            InitializeComponent();
        }

        public DsSistemas GetSistemas()
        {
            var ret = new DsSistemas();
            sistemasTableAdapter1.Fill(ret.Sistemas);
            return ret;
        }

        public DsSistemas UpdateSistemas(DsSistemas sis)
        {
            try
            {
                sistemasTableAdapter1.Update(sis.Sistemas);
            }
            catch
            {
                return null;
            }
            return sis;
        }
        public DsLicencia GetLicencia(string empresa)
        {
            var ret = new DsLicencia();
            licenciasTableAdapter1.Fill(ret.Licencias, empresa);
            return ret;
        }
        public DsLicencia UpdateLicencia(DsLicencia lic)
        {
            try
            {
                licenciasTableAdapter1.Update(lic.Licencias);
            }
            catch
            {
                return null;
            }
            return lic;
        }
    }
}