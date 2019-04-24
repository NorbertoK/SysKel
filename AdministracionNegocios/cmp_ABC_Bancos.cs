using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCBancos : Component
    {
        public CmpABCBancos()
        {
            InitializeComponent();
        }

        public DsBancos GetBancos()
        {
            var ret = new DsBancos();
            bancosTableAdapter1.Fill(ret.Bancos);
            return ret;
        }

        public DsBancos UpdateBancos(DsBancos ban)
        {
            try
            {
                bancosTableAdapter1.Update(ban.Bancos);
            }
            catch
            {
                return null;
            }
            return ban;
        }

        public DsEmpresasSueldoBancoMacro GetEmpresasSueldoBancoMacro()
        {
            var ret = new DsEmpresasSueldoBancoMacro();
            empresasSueldoBcoMacroTableAdapter1.Fill(ret.EmpresasSueldoBcoMacro);
            return ret;
        }

        public DsEmpresasSueldoBancoMacro UpdateEmpresasSueldoBancoMacro(DsEmpresasSueldoBancoMacro emp)
        {
            try
            {
                empresasSueldoBcoMacroTableAdapter1.Update(emp.EmpresasSueldoBcoMacro);
            }
            catch
            {
                return null;
            }
            return emp;
        }
    }
}