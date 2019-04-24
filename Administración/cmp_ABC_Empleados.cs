using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCEmpleados : Component
    {
        public CmpABCEmpleados()
        {
            InitializeComponent();
        }

        public DsEmpleados GetEmpleados()
        {
            var ret = new DsEmpleados();
            empleadosTableAdapter1.Fill(ret.Empleados);
            return ret;
        }

        public DsEmpleados UpdateEmpleados(DsEmpleados emp)
        {
            try
            {
                empleadosTableAdapter1.Update(emp.Empleados);
            }
            catch
            {
                return null;
            }
            return emp;
        }

        public DsCargos GetCargos()
        {
            var ret = new DsCargos();
            cargosTableAdapter1.Fill(ret.Cargos);
            return ret;
        }

        public DsEmpleadosLista GetEmpleadosLista()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.Fill(ret.EmpleadosLista);
            return ret;
        }

        public DsEmpleadosLista GetAdministrativos()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.FillAdministrativos(ret.EmpleadosLista);
            return ret;
        }

        public DsEmpleadosLista GetMedicos()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.FillMedicos(ret.EmpleadosLista);
            return ret;
        }

        public DsEmpleadosLista GetParamedicos()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.FillParamedicos(ret.EmpleadosLista);
            return ret;
        }

        public DsEmpleadosLista GetChoferes()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.FillChoferes(ret.EmpleadosLista);
            return ret;
        }

        public DsEmpleadosLista GetVendedores()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.FillVendedores(ret.EmpleadosLista);
            return ret;
        }

        public DsEmpleadosLista GetCobradores()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.FillCobradores(ret.EmpleadosLista);
            return ret;
        }
    }
}