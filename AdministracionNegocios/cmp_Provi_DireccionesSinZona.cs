using System.ComponentModel;

namespace Administración
{
    public partial class CmpProviDireccionesSinZona : Component
    {
        public CmpProviDireccionesSinZona()
        {
            InitializeComponent();
        }

        public DsProviDireccionesSinZona GetDireccionesSinZona()
        {
            var ret = new DsProviDireccionesSinZona();
            direccionesSinZonaTableAdapter1.Fill(ret.Afiliados);
            return ret;
        }

        public DsProviSinPlan GetProviSinPlan()
        {
            var ret = new DsProviSinPlan();
            proviSinPlanTableAdapter1.SetTimeOut();
            proviSinPlanTableAdapter1.Fill(ret.Provi_SinPlan);
            return ret;
        }

        public DsRepNoUnTitular GetAfiliadosNoUnTitular()
        {
            var ret = new DsRepNoUnTitular();
            afiliadosNoUnTitularTableAdapter1.SetTimeOut();
            afiliadosNoUnTitularTableAdapter1.Fill(ret.AfiliadosNoUnTitlar);
            return ret;
        }
    }
}