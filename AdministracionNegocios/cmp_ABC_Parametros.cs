using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCParametros : Component
    {
        public CmpABCParametros()
        {
            InitializeComponent();
        }

        public DsParametros GetParametros()
        {
            var ret = new DsParametros();
            parametrosTableAdapter1.Fill(ret.Parametros);
            return ret;
        }

        public DsParametros UpdateParametros(DsParametros param)
        {
            parametrosTableAdapter1.Update(param.Parametros);
            return param;
        }
    }
}