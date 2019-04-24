using System.ComponentModel;
using System.Data;
using System.Transactions;

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
            cargosEmpleadosTableAdapter1.Fill(ret.CargosEmpleados);
            return ret;
        }

        public DsEmpleados UpdateEmpleados(DsEmpleados emp)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    /* Primero agrego o modifico los padres y después los hijos */
                    empleadosTableAdapter1.Update(emp.Empleados.Select("", "",
                                                                       DataViewRowState.Added |
                                                                       DataViewRowState.ModifiedCurrent));
                    cargosEmpleadosTableAdapter1.Update(emp.CargosEmpleados.Select("", "",
                                                                                   DataViewRowState.Added |
                                                                                   DataViewRowState.ModifiedCurrent));

                    /* Primero elimino a los hijos y después a los padres */
                    cargosEmpleadosTableAdapter1.Update(emp.CargosEmpleados);
                    empleadosTableAdapter1.Update(emp.Empleados);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return emp;
            }
        }

        public DsCargos GetCargos()
        {
            var ret = new DsCargos();
            cargosTableAdapter1.Fill(ret.Cargos);
            return ret;
        }

        public DsEmpleadosLista GetEmpleadosReporte()
        {
            var ret = new DsEmpleadosLista();
            empleadosReporteTableAdapter1.Fill(ret.EmpleadosReporte);
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

        public DsEmpleadosLista GetCajasBancos()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.FillByBancos(ret.EmpleadosLista);
            return ret;
        }

        public DsEmpleadosLista GetNoAdministrativos()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.FillNoAdministrativos(ret.EmpleadosLista);
            return ret;
        }

        public DsEmpleadosLista GetAdministrativosYBancos()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.FillByAdministrativosYBancos(ret.EmpleadosLista);
            return ret;
        }

        public DsEmpleadosLista GetCajasConSaldoOBanco()
        {
            var ret = new DsEmpleadosLista();
            empleadosListaTableAdapter1.FillByCajasConSaldoOBanco(ret.EmpleadosLista);
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