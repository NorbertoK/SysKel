using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Administración.Properties;

namespace Administración
{
    public partial class CmpGrupos : Component
    {
        public CmpGrupos()
        {
            InitializeComponent();
        }

        public DsAfiliados GetGrupo(int grupo)
        {
            var ret = new DsAfiliados();
            gruposTableAdapter1.FillByIdGrupo(ret.Grupos, grupo);
            emailGrupoTableAdapter1.FillByIdGrupo(ret.EmailGrupo, grupo);
            afiliadosTableAdapter1.FillByIdGrupo(ret.Afiliados, grupo);
            direccionesAfiliadosTableAdapter1.FillByIdGrupo(ret.DireccionesAfiliados, grupo);
            telefonosDireccionesAfiliadosTableAdapter1.FillByIdGrupo(ret.TelefonosDireccionesAfiliados, grupo);
            solicitudesTableAdapter1.FillByIdGrupo(ret.Solicitudes, grupo);
            afiliadosPlanesTableAdapter1.FillByIdGrupo(ret.AfiliadosPlanes, grupo);
            telefonosAfiliadosTableAdapter1.FillByIdGrupo(ret.TelefonosAfiliados, grupo);
            emailsAfiliadosTableAdapter1.FillByIdGrupo(ret.EmailsAfiliados, grupo);
            contactosTableAdapter1.FillByIdGrupo(ret.Contactos, grupo);
            telefonosContactosTableAdapter1.FillByIdGrupo(ret.TelefonosContactos, grupo);
            emailsContactosAfiliadosTableAdapter1.FillByIdGrupo(ret.EmailsContactosAfiliados, grupo);
            direccionesGruposTableAdapter1.FillByIdGrupo(ret.DireccionesGrupos, grupo);
            telefonosDireccionesGruposTableAdapter1.FillByIdGrupo(ret.TelefonosDireccionesGrupos, grupo);
            return ret;
        }

        public string NombreAfiliado(int idTipoDeDocumento, string numeroDeDocumento, int intIdAfiliado)
        {
            string nombApel;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT Nombre+' '+Apellido FROM Afiliados WHERE idTipoDeDocumento=@idTipoDeDocumento AND NumeroDeDocumento=@numeroDeDocumento AND NOT idAfiliado=@int_idAfiliado",
                        connection);
                var xIdTipoDeDocumento = command.Parameters.Add("@idTipoDeDocumento", SqlDbType.Int);
                xIdTipoDeDocumento.Value = idTipoDeDocumento;
                var xNumeroDeDocumento = command.Parameters.Add("@numeroDeDocumento", SqlDbType.VarChar);
                xNumeroDeDocumento.Value = numeroDeDocumento;
                var xIntIdAfiliado = command.Parameters.Add("@int_idAfiliado", SqlDbType.Int);
                xIntIdAfiliado.Value = intIdAfiliado;
                connection.Open();
                try
                {
                    nombApel = command.ExecuteScalar().ToString();
                }
                catch
                {
                    nombApel = "";
                }
            }
            return nombApel;
        }

        public DsAfiliados UpdateGrupo(DsAfiliados datos)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    /* Primero agrego o modifico los padres y después los hijos */
                    gruposTableAdapter1.Update(datos.Grupos.Select("", "",
                                                                   DataViewRowState.Added |
                                                                   DataViewRowState.ModifiedCurrent));
                    emailGrupoTableAdapter1.Update(datos.EmailGrupo.Select("", "",
                                                                   DataViewRowState.Added |
                                                                   DataViewRowState.ModifiedCurrent));
                    afiliadosTableAdapter1.Update(datos.Afiliados.Select("", "",
                                                                         DataViewRowState.Added |
                                                                         DataViewRowState.ModifiedCurrent));
                    direccionesAfiliadosTableAdapter1.Update(datos.DireccionesAfiliados.Select("", "",
                                                                                               DataViewRowState.Added |
                                                                                               DataViewRowState.
                                                                                                   ModifiedCurrent));
                    telefonosDireccionesAfiliadosTableAdapter1.Update(datos.TelefonosDireccionesAfiliados.Select("", "",
                                                                                                                 DataViewRowState
                                                                                                                     .
                                                                                                                     Added |
                                                                                                                 DataViewRowState
                                                                                                                     .
                                                                                                                     ModifiedCurrent));
                    solicitudesTableAdapter1.Update(datos.Solicitudes.Select("", "",
                                                                             DataViewRowState.Added |
                                                                             DataViewRowState.ModifiedCurrent));
                    afiliadosPlanesTableAdapter1.Update(datos.AfiliadosPlanes.Select("", "",
                                                                                     DataViewRowState.Added |
                                                                                     DataViewRowState.ModifiedCurrent));
                    telefonosAfiliadosTableAdapter1.Update(datos.TelefonosAfiliados.Select("", "",
                                                                                           DataViewRowState.Added |
                                                                                           DataViewRowState.
                                                                                               ModifiedCurrent));
                    emailsAfiliadosTableAdapter1.Update(datos.EmailsAfiliados.Select("", "",
                                                                                     DataViewRowState.Added |
                                                                                     DataViewRowState.
                                                                                         ModifiedCurrent));
                    contactosTableAdapter1.Update(datos.Contactos.Select("", "",
                                                                         DataViewRowState.Added |
                                                                         DataViewRowState.ModifiedCurrent));
                    emailsContactosAfiliadosTableAdapter1.Update(datos.EmailsContactosAfiliados.Select("", "",
                                                                                     DataViewRowState.Added |
                                                                                     DataViewRowState.
                                                                                         ModifiedCurrent));
                    telefonosContactosTableAdapter1.Update(datos.TelefonosContactos.Select("", "",
                                                                                           DataViewRowState.Added |
                                                                                           DataViewRowState.
                                                                                               ModifiedCurrent));
                    direccionesGruposTableAdapter1.Update(datos.DireccionesGrupos.Select("", "",
                                                                                         DataViewRowState.Added |
                                                                                         DataViewRowState.
                                                                                             ModifiedCurrent));

                    /* Primero elimino a los hijos y después a los padres */
                    telefonosDireccionesGruposTableAdapter1.Update(datos.TelefonosDireccionesGrupos);
                    direccionesGruposTableAdapter1.Update(datos.DireccionesGrupos);
                    emailsContactosAfiliadosTableAdapter1.Update(datos.EmailsContactosAfiliados);
                    telefonosContactosTableAdapter1.Update(datos.TelefonosContactos);
                    contactosTableAdapter1.Update(datos.Contactos);
                    emailsAfiliadosTableAdapter1.Update(datos.EmailsAfiliados);
                    telefonosAfiliadosTableAdapter1.Update(datos.TelefonosAfiliados);
                    afiliadosPlanesTableAdapter1.Update(datos.AfiliadosPlanes);
                    solicitudesTableAdapter1.Update(datos.Solicitudes);
                    telefonosDireccionesAfiliadosTableAdapter1.Update(datos.TelefonosDireccionesAfiliados);
                    direccionesAfiliadosTableAdapter1.Update(datos.DireccionesAfiliados);
                    afiliadosTableAdapter1.Update(datos.Afiliados);
                    emailGrupoTableAdapter1.Update(datos.EmailGrupo);
                    gruposTableAdapter1.Update(datos.Grupos);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return datos;
            }
        }

        public DsPlanes GetPlanes()
        {
            var ret = new DsPlanes();
            planesTableAdapter1.Fill(ret.Planes);
            return ret;
        }

        public DsPlanesAfiliado GetPlanesAfiliado(int idAfiliado, DateTime fecha)
        {
            var ret = new DsPlanesAfiliado();
            planesAfiliadoTableAdapter1.Fill(ret.PlanesAfiliado, idAfiliado, fecha);
            return ret;
        }

        public int DefaultDNI()
        {
            int idDNI;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT TOP 1 DNI FROM Sistemas;", connection);
                idDNI = (int) command.ExecuteScalar();
            }
            return idDNI;
        }

        public string MensajeCantidadDeTitulares(int idGrupo)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT dbo.CantidadDeTitulares(@idGrupo)", connection);
                var xIdGrupo = command.Parameters.Add("idGrupo", SqlDbType.Int);
                xIdGrupo.Value = idGrupo;
                connection.Open();
                var frase = command.ExecuteScalar().ToString();
                return frase;
            }
        }

        public int HayAfiliadosPropiosActivos(int idGrupo, DateTime fecha)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT dbo.HayAlgunAfiliadoActivo(@idGrupo,@fecha)", connection);
                var xIdGrupo = command.Parameters.Add("idGrupo", SqlDbType.Int);
                xIdGrupo.Value = idGrupo;
                var xFecha = command.Parameters.Add("fecha", SqlDbType.DateTime);
                xFecha.Value = fecha;
                connection.Open();
                var hay = (int) command.ExecuteScalar();
                return hay;
            }
        }

        public DsRepBajasAutomaticas GetListadoBajasAutomaticas(string proceso)
        {
            var ret = new DsRepBajasAutomaticas();
            listadoBajasAutomaticasTableAdapter1.Fill(ret.ListadoBajasAutomaticas, proceso);
            return ret;
        }

        public void ActualizarClienteActivo(int idCliente)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "UPDATE dbo.Clientes SET Activo = dbo.HayAlgunContratoActivo(@idCliente, getdate()) WHERE idCliente = @idCliente",
                        connection);
                var xIdCliente = command.Parameters.Add("idCliente", SqlDbType.Int);
                xIdCliente.Value = idCliente;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void ActualizarGrupoActivo(int idGrupo)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "UPDATE  dbo.Grupos SET Activo = dbo.HayAlgunAfiliadoActivo(@idGrupo, getdate()) WHERE idGrupo = @idGrupo",
                        connection);
                var xIdGrupo = command.Parameters.Add("idGrupo", SqlDbType.Int);
                xIdGrupo.Value = idGrupo;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public string NombApelTitular(int idGrupo)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT dbo.NombApelTitular(@idGrupo)", connection);
                var xIdGrupo = command.Parameters.Add("idGrupo", SqlDbType.Int);
                xIdGrupo.Value = idGrupo;
                connection.Open();
                var frase = command.ExecuteScalar().ToString();
                return frase;
            }
        }

        public DsImportarPadron UpdateImportarPadron(DsImportarPadron tabla)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    tablaImportarPadronTableAdapter1.SetTimeOut();
                    tablaImportarPadronTableAdapter1.Update(tabla.Row);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return tabla;
            }
        }
    }
}