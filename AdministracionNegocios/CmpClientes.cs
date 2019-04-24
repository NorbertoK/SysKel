using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Administración.Properties;

namespace Administración
{
    public partial class CmpClientes : Component
    {
        public CmpClientes()
        {
            InitializeComponent();
        }

        public DsClientes GetClientes()
        {
            var ret = new DsClientes();
            clientesTableAdapter1.Fill(ret.Clientes);
            return ret;
        }

        public DsClientesLista GetClientesLista()
        {
            var ret = new DsClientesLista();
            clientesListaTableAdapter1.Fill(ret.ClientesLista);
            return ret;
        }

        public DsClientesLista GetClientesListaPorTipo(int idTipoDeCliente)
        {
            var ret = new DsClientesLista();
            clientesListaTableAdapter1.FillByIdTipoDeCliente(ret.ClientesLista, idTipoDeCliente);
            return ret;
        }

        public DsClientes GetCliente(int cliente)
        {
            var ret = new DsClientes();
            clientesTableAdapter1.FillByIdCliente(ret.Clientes, cliente);
            contactosClientesTableAdapter1.FillByIdCliente(ret.Contactos, cliente);
            telefonosContactosClientesTableAdapter1.FillByIdCliente(ret.TelefonosContactos, cliente);
            direccionesClientesTableAdapter1.FillByIdCliente(ret.Direcciones, cliente);
            telefonosDireccionesClientesTableAdapter1.FillByIdCliente(ret.TelefonosDirecciones, cliente);
            contratosTableAdapter1.FillByIdCliente(ret.Contratos, cliente);
            planesContratosTableAdapter1.FillByIdCliente(ret.Planes, cliente);
            solicitudesContratosTableAdapter1.FillByIdCliente(ret.Solicitudes, cliente);
            direccionContratoTableAdapter1.FillByIdCliente(ret.DireccionContrato, cliente);
            telefonosDireccionContratoTableAdapter1.FillByIdCliente(ret.TelefonosDireccionContrato, cliente);
            facturasProformaTableAdapter1.FillByIdcliente(ret.FacturasProforma, cliente);
            renglonesFacturaProformaTableAdapter1.FillByIdcliente(ret.RenglonesFacturaProforma, cliente);
            emailsClientesTableAdapter1.FillByIdCliente(ret.EmailsClientes, cliente);
            emailsContactosClientesTableAdapter1.FillByIdCliente(ret.EmailsContactosClientes, cliente);
            return ret;
        }

        public DsClientes UpdateCliente(DsClientes cli)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    /* Primero agrego o modifico los padres y después los hijos */
                    clientesTableAdapter1.Update(cli.Clientes.Select("", "",
                                                                     DataViewRowState.Added |
                                                                     DataViewRowState.ModifiedCurrent));
                    emailsClientesTableAdapter1.Update(cli.EmailsClientes.Select("", "", DataViewRowState.Added |
                                                                         DataViewRowState.
                                                                             ModifiedCurrent));
                    contactosClientesTableAdapter1.Update(cli.Contactos.Select("", "",
                                                                               DataViewRowState.Added |
                                                                               DataViewRowState.ModifiedCurrent));
                    telefonosContactosClientesTableAdapter1.Update(cli.TelefonosContactos.Select("", "",
                                                                                                 DataViewRowState.Added |
                                                                                                 DataViewRowState.
                                                                                                     ModifiedCurrent));
                    emailsContactosClientesTableAdapter1.Update(cli.EmailsContactosClientes.Select("", "", DataViewRowState.Added |
                                                                         DataViewRowState.
                                                                             ModifiedCurrent));
                    direccionesClientesTableAdapter1.Update(cli.Direcciones.Select("", "",
                                                                                   DataViewRowState.Added |
                                                                                   DataViewRowState.ModifiedCurrent));
                    telefonosDireccionesClientesTableAdapter1.Update(cli.TelefonosDirecciones.Select("", "",
                                                                                                     DataViewRowState.
                                                                                                         Added |
                                                                                                     DataViewRowState.
                                                                                                         ModifiedCurrent));
                    contratosTableAdapter1.Update(cli.Contratos.Select("", "",
                                                                       DataViewRowState.Added |
                                                                       DataViewRowState.ModifiedCurrent));
                    solicitudesContratosTableAdapter1.Update(cli.Solicitudes.Select("", "",
                                                                                    DataViewRowState.Added |
                                                                                    DataViewRowState.ModifiedCurrent));
                    planesContratosTableAdapter1.Update(cli.Planes.Select("", "",
                                                                          DataViewRowState.Added |
                                                                          DataViewRowState.ModifiedCurrent));
                    direccionContratoTableAdapter1.Update(cli.DireccionContrato.Select("", "",
                                                                                       DataViewRowState.Added |
                                                                                       DataViewRowState.ModifiedCurrent));
                    telefonosDireccionContratoTableAdapter1.Update(cli.TelefonosDireccionContrato.Select("", "",
                                                                                                         DataViewRowState
                                                                                                             .Added |
                                                                                                         DataViewRowState
                                                                                                             .
                                                                                                             ModifiedCurrent));
                    facturasProformaTableAdapter1.Update(cli.FacturasProforma.Select("", "",
                                                                                     DataViewRowState.Added |
                                                                                     DataViewRowState.ModifiedCurrent));
                    renglonesFacturaProformaTableAdapter1.Update(cli.RenglonesFacturaProforma.Select("", "",
                                                                                                     DataViewRowState.
                                                                                                         Added |
                                                                                                     DataViewRowState.
                                                                                                         ModifiedCurrent));


                    /* Primero elimino a los hijos y después a los padres */
                    renglonesFacturaProformaTableAdapter1.Update(cli.RenglonesFacturaProforma);
                    facturasProformaTableAdapter1.Update(cli.FacturasProforma);
                    telefonosDireccionContratoTableAdapter1.Update(cli.TelefonosDireccionContrato);
                    direccionContratoTableAdapter1.Update(cli.DireccionContrato);
                    planesContratosTableAdapter1.Update(cli.Planes);
                    solicitudesContratosTableAdapter1.Update(cli.Solicitudes);
                    contratosTableAdapter1.Update(cli.Contratos);
                    telefonosDireccionesClientesTableAdapter1.Update(cli.TelefonosDirecciones);
                    direccionesClientesTableAdapter1.Update(cli.Direcciones);
                    emailsContactosClientesTableAdapter1.Update(cli.EmailsContactosClientes);
                    telefonosContactosClientesTableAdapter1.Update(cli.TelefonosContactos);
                    contactosClientesTableAdapter1.Update(cli.Contactos);
                    emailsClientesTableAdapter1.Update(cli.EmailsClientes);
                    clientesTableAdapter1.Update(cli.Clientes);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return cli;
            }
        }

        public string NombreCuitIngresado(string cuit, int idCliente)
        {
            string nombClienteAnterior;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT NombreCompleto FROM Clientes WHERE CUIT=" + cuit +
                        " AND NOT idCliente=" + idCliente + ";", connection);
                connection.Open();
                try
                {
                    nombClienteAnterior = command.ExecuteScalar().ToString();
                }
                catch
                {
                    nombClienteAnterior = "";
                }
            }
            return nombClienteAnterior;
        }

        public string NombreCuitIngresadoProveedor(string cuit, int idProveedor)
        {
            string nombProveedorAnterior;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT RazonSocial FROM Proveedores WHERE CUIT=" + cuit +
                        " AND NOT idProveedor" + idProveedor + ";", connection);
                connection.Open();
                try
                {
                    nombProveedorAnterior = command.ExecuteScalar().ToString();
                }
                catch
                {
                    nombProveedorAnterior = "";
                }
            }
            return nombProveedorAnterior;
        }

        public string NombreProveedorCuitIngresado(string cuit, int idProveedor)
        {
            string nombProveedorAnterior;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT NombreCompleto FROM Proveedores WHERE CUIT=" + cuit +
                        " AND NOT idProveedore=" + idProveedor + ";", connection);
                connection.Open();
                try
                {
                    nombProveedorAnterior = command.ExecuteScalar().ToString();
                }
                catch
                {
                    nombProveedorAnterior = "";
                }
            }
            return nombProveedorAnterior;
        }

        public DsContratosLista GetContratosRenglonFactura(int idCliente)
        {
            var ret = new DsContratosLista();
            contratosRenglonFacturaTableAdapter1.Fill(ret.ContratosRenglonFactura, idCliente);
            return ret;
        }

        public DsContratosLista GetContratosRenglonFacturaTodos()
        {
            var ret = new DsContratosLista();
            contratosRenglonFacturaTableAdapter1.FillTodos(ret.ContratosRenglonFactura);
            return ret;
        }

        public DsContratosLista GetPlanesRenglonFactura(int idCliente)
        {
            var ret = new DsContratosLista();
            planesDelClienteTableAdapter1.FillByIdCliente(ret.PlanesDelCliente, idCliente);
            return ret;
        }

        public DsCopagos GetCopagos()
        {
            var ret = new DsCopagos();
            copagosTableAdapter1.Fill(ret.Copagos);
            return ret;
        }

        public DsCopagos UpdateCopagos(DsCopagos copagos)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    copagosTableAdapter1.Update(copagos.Copagos);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return copagos;
            }
        }
    }
}