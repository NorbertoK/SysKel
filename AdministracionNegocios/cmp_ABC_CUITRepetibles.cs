using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCCUITRepetibles : Component
    {
        public CmpABCCUITRepetibles()
        {
            InitializeComponent();
        }

        public DsCUITRepetibles GetCUITRepetibles()
        {
            var ret = new DsCUITRepetibles();
            cuitRepetiblesTableAdapter1.Fill(ret.CUITRepetibles);
            return ret;
        }

        public DsCUITRepetibles UpdateCUITRepetibles(DsCUITRepetibles repe)
        {
            try
            {
                cuitRepetiblesTableAdapter1.Update(repe.CUITRepetibles);
            }
            catch
            {
                return null;
            }
            return repe;
        }
    }
}