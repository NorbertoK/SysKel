using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCEntidadesDeCobranza : Component
    {
        public CmpABCEntidadesDeCobranza()
        {
            InitializeComponent();
        }

        public DsEntidadesDeCobranza GetEntidadesDeCobranza()
        {
            var ret = new DsEntidadesDeCobranza();
            entidadesDeCobranzaTableAdapter1.Fill(ret.EntidadesDeCobranza);
            return ret;
        }

        public DsEntidadesDeCobranza UpdateEntidadesDeCobranza(DsEntidadesDeCobranza entidades)
        {
            try
            {
                entidadesDeCobranzaTableAdapter1.Update(entidades.EntidadesDeCobranza);
            }
            catch
            {
                return null;
            }
            return entidades;
        }
    }
}