using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCTandasDeFacturacion : Component
    {
        public CmpABCTandasDeFacturacion()
        {
            InitializeComponent();
        }

        public DsTandasDeFacturacion GetTandasDeFacturacion()
        {
            var ret = new DsTandasDeFacturacion();
            tandasDeFacturacionTableAdapter1.Fill(ret.TandasDeFacturacion);
            return ret;
        }

        public DsTandasDeFacturacion UpdateTandasDeFacturacion(DsTandasDeFacturacion tandas)
        {
            try
            {
                tandasDeFacturacionTableAdapter1.Update(tandas.TandasDeFacturacion);
            }
            catch
            {
                return null;
            }
            return tandas;
        }
    }
}