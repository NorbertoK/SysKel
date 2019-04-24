using System.ComponentModel;

namespace Administración
{
    public partial class CmpCabImprimirPrestacion : Component
    {
        public CmpCabImprimirPrestacion()
        {
            InitializeComponent();
        }

        public DsImprimirPrestacion GetImprimirPrestacion(int idPrestacion)
        {
            var ret = new DsImprimirPrestacion();
            imprimirPrestacionTableAdapter1.SetTimeOut();
            imprimirPrestacionCtaCteTableAdapter1.SetTimeOut();
            imprimirPrestacionTableAdapter1.Fill(ret.ImprimirPrestacion, idPrestacion);
            imprimirPrestacionCtaCteTableAdapter1.Fill(ret.ImprimirPrestacionCtaCte, idPrestacion);
            return ret;
        }

        public DsImprimirPrestacion GetImprimirPrestaciones(string proceso)
        {
            var ret = new DsImprimirPrestacion();
            imprimirPrestacionTableAdapter1.SetTimeOut();
            imprimirPrestacionCtaCteTableAdapter1.SetTimeOut();
            imprimirPrestacionTableAdapter1.FillByProceso(ret.ImprimirPrestacion, proceso);
            imprimirPrestacionCtaCteTableAdapter1.FillByProceso(ret.ImprimirPrestacionCtaCte, proceso);
            return ret;
        }
    }
}