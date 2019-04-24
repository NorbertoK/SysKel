using System.ComponentModel;
using System.Data;
using System.Transactions;

namespace Administración
{
    public partial class CmpABCLugares : Component
    {
        public CmpABCLugares()
        {
            InitializeComponent();
        }

        public DsLugares GetLugares()
        {
            var ret = new DsLugares();
            lugaresTableAdapter1.Fill(ret.Lugares);
            contactosTableAdapter1.FillByIdLugar(ret.Contactos);
            telefonosContactosTableAdapter1.FillByIdLugar(ret.TelefonosContactos);
            direccionesTableAdapter1.FillByIdLugar(ret.Direcciones);
            telefonosDireccionesTableAdapter1.FillByIdLugar(ret.TelefonosDirecciones);
            return ret;
        }

        public DsLugares UpdateLugares(DsLugares lugares)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    /* Primero agrego o modifico los padres y después los hijos */
                    lugaresTableAdapter1.Update(lugares.Lugares.Select("", "",
                                                                       DataViewRowState.Added |
                                                                       DataViewRowState.ModifiedCurrent));
                    contactosTableAdapter1.Update(lugares.Contactos.Select("", "",
                                                                           DataViewRowState.Added |
                                                                           DataViewRowState.ModifiedCurrent));
                    telefonosContactosTableAdapter1.Update(lugares.TelefonosContactos.Select("", "",
                                                                                             DataViewRowState.Added |
                                                                                             DataViewRowState.
                                                                                                 ModifiedCurrent));
                    direccionesTableAdapter1.Update(lugares.Direcciones.Select("", "",
                                                                               DataViewRowState.Added |
                                                                               DataViewRowState.ModifiedCurrent));

                    /* Primero elimino a los hijos y después a los padres */
                    telefonosDireccionesTableAdapter1.Update(lugares.TelefonosDirecciones);
                    direccionesTableAdapter1.Update(lugares.Direcciones);
                    telefonosContactosTableAdapter1.Update(lugares.TelefonosContactos);
                    contactosTableAdapter1.Update(lugares.Contactos);
                    lugaresTableAdapter1.Update(lugares.Lugares);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return lugares;
            }
        }

        public DsLugaresLista GetLugaresLista()
        {
            var ret = new DsLugaresLista();
            lugaresListaTableAdapter1.Fill(ret.LugaresLista);
            return ret;
        }
    }
}