using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCMotivosDeBaja : Component
    {
        public CmpABCMotivosDeBaja()
        {
            InitializeComponent();
        }

        public DsMotivosDeBaja GetMotivosDeBaja()
        {
            var ret = new DsMotivosDeBaja();
            motivosDeBajaTableAdapter1.Fill(ret.MotivosDeBaja);
            return ret;
        }

        public DsMotivosDeBaja UpdateMotivosDeBaja(DsMotivosDeBaja motivos)
        {
            try
            {
                motivosDeBajaTableAdapter1.Update(motivos.MotivosDeBaja);
            }
            catch
            {
                return null;
            }
            return motivos;
        }
    }
}