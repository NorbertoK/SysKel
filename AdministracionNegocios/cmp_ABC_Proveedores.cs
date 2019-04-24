using System.ComponentModel;
using System.Data;
using System.Transactions;

namespace Administración
{
    public partial class CmpABCProveedores : Component
    {
        public CmpABCProveedores()
        {
            InitializeComponent();
        }

        public DsProveedores GetProveedores()
        {
            var ret = new DsProveedores();
            proveedoresTableAdapter1.Fill(ret.Proveedores);
            return ret;
        }

        public DsProveedores GetProveedoresActivos()
        {
            var ret = new DsProveedores();
            proveedoresTableAdapter1.FillByActivos(ret.Proveedores);
            return ret;
        }

        public DsProveedores GetProveedor(int idProveedor)
        {
            var ret = new DsProveedores();
            proveedoresTableAdapter1.FillByIdProveedor(ret.Proveedores, idProveedor);
            negociosDelProveedorTableAdapter1.FillByIdProveedor(ret.NegociosDelProveedor, idProveedor);
            emailsProveedoresTableAdapter1.FillByIdProveedor(ret.EmailsProveedores, idProveedor);
            direccionesTableAdapter1.FillByIdProveedor(ret.Direcciones, idProveedor);
            telefonosDireccionesTableAdapter1.FillByIdProveedor(ret.TelefonosDirecciones, idProveedor);
            contactosTableAdapter1.FillByIdProveedor(ret.Contactos, idProveedor);
            telefonosContactosTableAdapter1.FillByIdProveedor(ret.TelefonosContactos, idProveedor);
            emailsContactosTableAdapter1.FillByIdProveedor(ret.EmailsContactos, idProveedor);
            return ret;
        }

        public DsBuscarProveedores GetBuscarProveedores(string frase)
        {
            var ret = new DsBuscarProveedores();
            buscarProveedoresTableAdapter1.Fill(ret.BuscarProveedores, frase);
            if (ret.BuscarProveedores.Count == 0)
            {
                ret.BuscarProveedores.Rows.Add(0);
                ret.BuscarProveedores[0].RazonSocial = "Ningún Resultado";
            }
            return ret;
        }

        public DsProveedores UpdateProveedores(DsProveedores prov)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    proveedoresTableAdapter1.Update(prov.Proveedores.Select("", "",
                        DataViewRowState.Added |
                        DataViewRowState.ModifiedCurrent));
                    negociosDelProveedorTableAdapter1.Update(prov.NegociosDelProveedor.Select("", "",
                        DataViewRowState.Added |
                        DataViewRowState.ModifiedCurrent));
                    emailsProveedoresTableAdapter1.Update(prov.EmailsProveedores.Select("", "",
                        DataViewRowState.Added |
                        DataViewRowState.ModifiedCurrent));
                    direccionesTableAdapter1.Update(prov.Direcciones.Select("", "",
                        DataViewRowState.Added |
                        DataViewRowState.ModifiedCurrent));
                    telefonosDireccionesTableAdapter1.Update(prov.TelefonosDirecciones.Select("", "",
                        DataViewRowState.Added |
                        DataViewRowState.ModifiedCurrent));
                    contactosTableAdapter1.Update(prov.Contactos.Select("", "",
                        DataViewRowState.Added |
                        DataViewRowState.ModifiedCurrent));
                    telefonosContactosTableAdapter1.Update(prov.TelefonosContactos.Select("", "",
                        DataViewRowState.Added |
                        DataViewRowState.ModifiedCurrent));
                    emailsContactosTableAdapter1.Update(prov.EmailsContactos);
                    telefonosContactosTableAdapter1.Update(prov.TelefonosContactos);
                    contactosTableAdapter1.Update(prov.Contactos);
                    telefonosDireccionesTableAdapter1.Update(prov.TelefonosDirecciones);
                    direccionesTableAdapter1.Update(prov.Direcciones);
                    emailsProveedoresTableAdapter1.Update(prov.EmailsProveedores);
                    negociosDelProveedorTableAdapter1.Update(prov.NegociosDelProveedor);
                    proveedoresTableAdapter1.Update(prov.Proveedores);
                }
                catch
                {
                    return null;
                }
                ts.Complete();
                return prov;
            }
        }
    }
}