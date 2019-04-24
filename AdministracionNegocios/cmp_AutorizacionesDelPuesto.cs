using System.ComponentModel;

namespace Administración
{
    public partial class CmpAutorizacionesDelPuesto : Component
    {
        public CmpAutorizacionesDelPuesto()
        {
            InitializeComponent();
        }

        public DsAutorizacionesDelPuesto GetAutorizacionesDelPuesto()
        {
            var ret = new DsAutorizacionesDelPuesto();
            autorizacionesDelPuestoTableAdapter1.Fill(ret.AutorizacionesDelPuesto);
            return ret;
        }

        public DsAutorizacionesDelPuesto UpdateAutorizacionesDelPuesto(DsAutorizacionesDelPuesto auto)
        {
            try
            {
                autorizacionesDelPuestoTableAdapter1.Update(auto.AutorizacionesDelPuesto);
            }
            catch
            {
                return null;
            }
            return auto;
        }

        public DsRepPuestosAutorizados GetPuestosAutorizados()
        {
            var ret = new DsRepPuestosAutorizados();
            puestosAutorizadosTableAdapter1.Fill(ret.PuestosAutorizados);
            return ret;
        }
    }
}