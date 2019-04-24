using System.ComponentModel;
using System.Transactions;

namespace Administración
{
    public partial class CmpCabABCRecursos : Component
    {
        public CmpCabABCRecursos()
        {
            InitializeComponent();
        }

        public DsRecursos GetRecutsos()
        {
            var ret = new DsRecursos();
            recursosTableAdapter1.Fill(ret.Recursos);
            return ret;
        }

        public DsRecursos UpdateRecursos(DsRecursos recu)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    recursosTableAdapter1.Update(recu.Recursos);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return recu;
            }
        }

        public DsRecursos GetMovilesLista()
        {
            var ret = new DsRecursos();
            movilesTableAdapter1.Fill(ret.Moviles);
            return ret;
        }

        public DsRecursos GetMedicosLista()
        {
            var ret = new DsRecursos();
            medicosTableAdapter1.Fill(ret.Medicos);
            return ret;
        }

        public DsRecursos GetParamedicosLista()
        {
            var ret = new DsRecursos();
            paramedicosTableAdapter1.Fill(ret.Paramedicos);
            return ret;
        }

        public DsRecursos GetChoferesLista()
        {
            var ret = new DsRecursos();
            choferesTableAdapter1.Fill(ret.Choferes);
            return ret;
        }

        public DsRecursosLista GetRecursosLista()
        {
            var ret = new DsRecursosLista();
            recursosListaTableAdapter1.Fill(ret.RecursosLista);
            return ret;
        }
    }
}