using System.ComponentModel;

namespace Administración
{
    public partial class CmpCabABCMotivosDeLlamado : Component
    {
        public CmpCabABCMotivosDeLlamado()
        {
            InitializeComponent();
        }

        public DsMotivosDeLlamado GetMotivosDeLlamado()
        {
            var ret = new DsMotivosDeLlamado();
            motivosDeLlamadoTableAdapter1.Fill(ret.MotivosDeLlamado);
            return ret;
        }

        public DsMotivosDeLlamado UpdateMotivosDeLlamado(DsMotivosDeLlamado moti)
        {
            try
            {
                motivosDeLlamadoTableAdapter1.Update(moti.MotivosDeLlamado);
            }
            catch
            {
                return null;
            }
            return moti;
        }
    }
}