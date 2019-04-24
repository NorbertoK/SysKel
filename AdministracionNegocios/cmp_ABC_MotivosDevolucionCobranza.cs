using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCMotivosDevolucionCobranza : Component
    {
        public CmpABCMotivosDevolucionCobranza()
        {
            InitializeComponent();
        }

        public DsMotivosDevolucionCobranza GetMotivosDevolucionCobranza()
        {
            var ret = new DsMotivosDevolucionCobranza();
            motivosDevolucionCobranzaTableAdapter1.Fill(ret.MotivosDevolucionCobranza);
            return ret;
        }

        public DsMotivosDevolucionCobranza UpdateMotivosDevolucionCobranza(DsMotivosDevolucionCobranza moti)
        {
            try
            {
                motivosDevolucionCobranzaTableAdapter1.Update(moti.MotivosDevolucionCobranza);
            }
            catch
            {
                return null;
            }
            return moti;
        }
    }
}