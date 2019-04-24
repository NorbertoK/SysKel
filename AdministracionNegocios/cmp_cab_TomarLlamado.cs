using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    public partial class CmpCabTomarLlamado : Component
    {
        public CmpCabTomarLlamado()
        {
            InitializeComponent();
        }

        public CmpCabTomarLlamado(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public DsCabBuscarTelefono GetRefTelefono(string telefono)
        {
            var ret = new DsCabBuscarTelefono();
            buscarTelefonoTableAdapter1.Fill(ret.BuscarTelefono, telefono);
            return ret.BuscarTelefono.Count == 0 ? null : ret;
        }

        public DsCabBuscarTelefono GetRefDireccion(int idCalle, string numero)
        {
            var ret = new DsCabBuscarTelefono();
            buscarTelefonoTableAdapter1.FillByDireccion(ret.BuscarTelefono, idCalle, numero);
            return ret.BuscarTelefono.Count == 0 ? null : ret;
        }

        public DsCabBuscarTelefono GetRefDireccionCalle(int idCalle)
        {
            var ret = new DsCabBuscarTelefono();
            buscarTelefonoTableAdapter1.FillByCalle(ret.BuscarTelefono, idCalle);
            return ret.BuscarTelefono.Count == 0 ? null : ret;
        }

        public DsCabBuscarTelefono GetRefDireccionLocalidad(int idLocalidad)
        {
            var ret = new DsCabBuscarTelefono();
            buscarTelefonoTableAdapter1.FillByLocalidad(ret.BuscarTelefono, idLocalidad);
            return ret.BuscarTelefono.Count == 0 ? null : ret;
        }

        public DsCabBuscarTelefono GetRefAfiliado(int idAfiliado)
        {
            var ret = new DsCabBuscarTelefono();
            buscarTelefonoTableAdapter1.FillByIdAfiliado(ret.BuscarTelefono, idAfiliado);
            return ret.BuscarTelefono.Count == 0 ? null : ret;
        }

        public int CrearPrestacion(string fechaYHora, string telefono, int idLocalidad, int idCalle, string numero, string piso,
                                   string departamento, int idEntreCalle1, int idEntreCalle2, string observacionesDireccion, int idBarrio,
                                   int idTipoDeDestino, int idMotivoDeLlamado1, string observacionesMotivo1, int idMotivoDeLlamado2,
                                   string observacionesMotivo2, int idMotivoDeLlamado3, string observacionesMotivo3, int idMotivoDeLlamado4,
                                   string observacionesMotivo4, int idAfiliado, string apelNomb, int idTipoDeDocumento,
                                   string numeroDeDocumento, int edad, string edadEn, string sexo, int idPrepago, string numeroPrepago,
                                   decimal importe, string antecedentes, int idCodigo, int idCobertura, int idPractica,
                                   string observacionesPrestacion, int idContrato, int idTomador, bool terminada, int idMotivoDeCancelacion,
                                   string incidenteExterno, bool extraCobertura, decimal copagoSugerido)
        {
            int retorno;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.AgregarPrestacion", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xFechaYHora = command.Parameters.Add("@fechaYHora", SqlDbType.VarChar, 17);
                xFechaYHora.Value = fechaYHora;
                var xTelefono = command.Parameters.Add("@telefono", SqlDbType.VarChar);
                xTelefono.Value = telefono;
                var xIdLocalidad = command.Parameters.Add("@idLocalidad", SqlDbType.Int);
                xIdLocalidad.Value = idLocalidad;
                var xIdCalle = command.Parameters.Add("@idCalle", SqlDbType.Int);
                xIdCalle.Value = idCalle;
                var xNumero = command.Parameters.Add("@numero", SqlDbType.VarChar);
                xNumero.Value = numero;
                var xPiso = command.Parameters.Add("@piso", SqlDbType.VarChar);
                xPiso.Value = piso;
                var xDepartamento = command.Parameters.Add("@Departamento", SqlDbType.VarChar);
                xDepartamento.Value = departamento;
                var xIdEntreCalle1 = command.Parameters.Add("@idEntreCalle1", SqlDbType.Int);
                xIdEntreCalle1.Value = idEntreCalle1;
                var xIdEntreCalle2 = command.Parameters.Add("@idEntreCalle2", SqlDbType.Int);
                xIdEntreCalle2.Value = idEntreCalle2;
                var xObservacionesDireccion = command.Parameters.Add("@ObservacionesDireccion",
                                                                     SqlDbType.VarChar);
                xObservacionesDireccion.Value = observacionesDireccion;
                var xIdBarrio = command.Parameters.Add("@idBarrio", SqlDbType.Int);
                xIdBarrio.Value = idBarrio;
                var xIdTipoDeDestino = command.Parameters.Add("@idTipoDeDestino", SqlDbType.Int);
                xIdTipoDeDestino.Value = idTipoDeDestino;
                var xIdMotivoDeLlamado1 = command.Parameters.Add("@idMotivoDeLlamado1", SqlDbType.Int);
                xIdMotivoDeLlamado1.Value = idMotivoDeLlamado1;
                var xObservacionesMotivo1 = command.Parameters.Add("@ObservacionesMotivo1", SqlDbType.VarChar);
                xObservacionesMotivo1.Value = observacionesMotivo1;
                var xIdMotivoDeLlamado2 = command.Parameters.Add("@idMotivoDeLlamado2", SqlDbType.Int);
                xIdMotivoDeLlamado2.Value = idMotivoDeLlamado2;
                var xObservacionesMotivo2 = command.Parameters.Add("@ObservacionesMotivo2", SqlDbType.VarChar);
                xObservacionesMotivo2.Value = observacionesMotivo2;
                var xIdMotivoDeLlamado3 = command.Parameters.Add("@idMotivoDeLlamado3", SqlDbType.Int);
                xIdMotivoDeLlamado3.Value = idMotivoDeLlamado3;
                var xObservacionesMotivo3 = command.Parameters.Add("@ObservacionesMotivo3", SqlDbType.VarChar);
                xObservacionesMotivo3.Value = observacionesMotivo3;
                var xIdMotivoDeLlamado4 = command.Parameters.Add("@idMotivoDeLlamado4", SqlDbType.Int);
                xIdMotivoDeLlamado4.Value = idMotivoDeLlamado4;
                var xObservacionesMotivo4 = command.Parameters.Add("@ObservacionesMotivo4", SqlDbType.VarChar);
                xObservacionesMotivo4.Value = observacionesMotivo4;
                var xIdAfiliado = command.Parameters.Add("@idAfiliado", SqlDbType.Int);
                xIdAfiliado.Value = idAfiliado;
                var xApelNomb = command.Parameters.Add("@ApelNomb", SqlDbType.VarChar);
                xApelNomb.Value = apelNomb;
                var xIdTipoDeDocumento = command.Parameters.Add("@idTipoDeDocumento", SqlDbType.Int);
                xIdTipoDeDocumento.Value = idTipoDeDocumento;
                var xNumeroDeDocumento = command.Parameters.Add("@NumeroDeDocumento", SqlDbType.VarChar, 20);
                xNumeroDeDocumento.Value = numeroDeDocumento;
                var xEdad = command.Parameters.Add("@Edad", SqlDbType.Int);
                xEdad.Value = edad;
                var xEdadEn = command.Parameters.Add("@EdadEn", SqlDbType.VarChar);
                xEdadEn.Value = edadEn;
                var xSexo = command.Parameters.Add("@Sexo", SqlDbType.VarChar);
                xSexo.Value = sexo;
                var xIdPrepago = command.Parameters.Add("@idPrepago", SqlDbType.Int);
                xIdPrepago.Value = idPrepago;
                var xNumeroPrepago = command.Parameters.Add("NumeroPrepago", SqlDbType.VarChar);
                xNumeroPrepago.Value = numeroPrepago;
                var xImporte = command.Parameters.Add("@importe", SqlDbType.Decimal);
                xImporte.Precision = 10;
                xImporte.Scale = 2;
                xImporte.Value = importe;
                var xAntecedentes = command.Parameters.Add("@Antecedentes", SqlDbType.VarChar);
                xAntecedentes.Value = antecedentes;
                var xIdCodigo = command.Parameters.Add("@idCodigo", SqlDbType.Int);
                xIdCodigo.Value = idCodigo;
                var xIdCobertura = command.Parameters.Add("@idCobertura", SqlDbType.Int);
                xIdCobertura.Value = idCobertura;
                var xIdPractica = command.Parameters.Add("@idPractica", SqlDbType.Int);
                xIdPractica.Value = idPractica;
                var xObservacionesPrestacion = command.Parameters.Add("@ObservacionesPrestacion",
                                                                      SqlDbType.VarChar);
                xObservacionesPrestacion.Value = observacionesPrestacion;
                var xIdContrato = command.Parameters.Add("@idContrato", SqlDbType.Int);
                xIdContrato.Value = idContrato;
                var xIdTomador = command.Parameters.Add("@idTomador", SqlDbType.Int);
                xIdTomador.Value = idTomador;
                var xTerminada = command.Parameters.Add("@terminada", SqlDbType.Bit);
                xTerminada.Value = terminada;
                var xIdMotivoDeCancelacion = command.Parameters.Add("@idMotivoDeCancelacion", SqlDbType.Int);
                xIdMotivoDeCancelacion.Value = idMotivoDeCancelacion;
                var xIncidenteExterno = command.Parameters.Add("@incidenteExterno", SqlDbType.VarChar, 50);
                xIncidenteExterno.Value = incidenteExterno;
                var xExtraCobertura = command.Parameters.Add("@extraCobertura", SqlDbType.Bit);
                xExtraCobertura.Value = extraCobertura;
                var xCopagoSugerido = command.Parameters.Add("@copagoSugerido", SqlDbType.Bit);
                xCopagoSugerido.Value = copagoSugerido;
                var ret = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                ret.Direction = ParameterDirection.ReturnValue;
                connection.Open();
                command.ExecuteNonQuery();
                retorno = (int) ret.Value;
            }
            return retorno;
        }

        public int CrearPrestacionProgramada(string prestacionesString
                                             , string fechaYHora
                                             , string telefono1
                                             , int idLocalidad1
                                             , int idCalle1
                                             , string numero1
                                             , string piso1
                                             , string departamento1
                                             , int idEntreCalle11
                                             , int idEntreCalle21
                                             , string observacionesDireccion1
                                             , int idBarrio1
                                             , int idLocalidad2
                                             , int idCalle2
                                             , string numero2
                                             , string piso2
                                             , string departamento2
                                             , int idEntreCalle12
                                             , int idEntreCalle22
                                             , string observacionesDireccion2
                                             , int @idBarrio2
                                             , bool haySegundaDirección
                                             , bool esperaYRetorno
                                             , int idAfiliado1
                                             , string apelNomb
                                             , int idTipoDeDocumento
                                             , string numeroDeDocumento
                                             , int edad
                                             , string edadEn
                                             , string sexo
                                             , int idPrepago
                                             , string numeroPrepago
                                             , decimal importe
                                             , string antecedentes
                                             , int idCobertura
                                             , int idPractica
                                             , int idContrato
                                             , int idTomador
                                             , bool extraCobertura
                                             , decimal copagoSugerido
            )
        {
            int retorno;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.AgregarProgramado", connection)
                                  {CommandType = CommandType.StoredProcedure};
                var xPrestacionesString = command.Parameters.Add("@prestacionesString", SqlDbType.VarChar);
                xPrestacionesString.Value = prestacionesString;
                var xFechaYHora = command.Parameters.Add("@fechaYHora", SqlDbType.VarChar, 17);
                xFechaYHora.Value = fechaYHora;
                var xTelefono = command.Parameters.Add("@telefono", SqlDbType.VarChar);
                xTelefono.Value = telefono1;
                var xIdLocalidad1 = command.Parameters.Add("@idLocalidad_1", SqlDbType.Int);
                xIdLocalidad1.Value = idLocalidad1;
                var xIdCalle1 = command.Parameters.Add("@idCalle_1", SqlDbType.Int);
                xIdCalle1.Value = idCalle1;
                var xNumero1 = command.Parameters.Add("@Numero_1", SqlDbType.VarChar);
                xNumero1.Value = numero1;
                var xPiso1 = command.Parameters.Add("@Piso_1", SqlDbType.VarChar);
                xPiso1.Value = piso1;
                var xDepartamento1 = command.Parameters.Add("@Departamento_1", SqlDbType.VarChar);
                xDepartamento1.Value = departamento1;
                var xIdEntreCalle11 = command.Parameters.Add("@idEntreCalle1_1", SqlDbType.Int);
                xIdEntreCalle11.Value = idEntreCalle11;
                var xIdEntreCalle21 = command.Parameters.Add("@idEntreCalle2_1", SqlDbType.Int);
                xIdEntreCalle21.Value = idEntreCalle21;
                var xObservacionesDireccion1 = command.Parameters.Add("@ObservacionesDireccion_1",
                                                                      SqlDbType.VarChar);
                xObservacionesDireccion1.Value = observacionesDireccion1;
                var xIdBarrio1 = command.Parameters.Add("@idBarrio_1", SqlDbType.Int);
                xIdBarrio1.Value = idBarrio1;
                var xIdLocalidad2 = command.Parameters.Add("@idLocalidad_2", SqlDbType.Int);
                xIdLocalidad2.Value = idLocalidad2;
                var xIdCalle2 = command.Parameters.Add("@idCalle_2", SqlDbType.Int);
                xIdCalle2.Value = idCalle2;
                var xNumero2 = command.Parameters.Add("@Numero_2", SqlDbType.VarChar);
                xNumero2.Value = numero2;
                var xPiso2 = command.Parameters.Add("@Piso_2", SqlDbType.VarChar);
                xPiso2.Value = piso2;
                var xDepartamento2 = command.Parameters.Add("@Departamento_2", SqlDbType.VarChar);
                xDepartamento2.Value = departamento2;
                var xIdEntreCalle12 = command.Parameters.Add("@idEntreCalle1_2", SqlDbType.Int);
                xIdEntreCalle12.Value = idEntreCalle12;
                var xIdEntreCalle22 = command.Parameters.Add("@idEntreCalle2_2", SqlDbType.Int);
                xIdEntreCalle22.Value = idEntreCalle22;
                var xObservacionesDireccion2 = command.Parameters.Add("@ObservacionesDireccion_2",
                                                                      SqlDbType.VarChar);
                xObservacionesDireccion2.Value = observacionesDireccion2;
                var xIdBarrio2 = command.Parameters.Add("@idBarrio_2", SqlDbType.Int);
                xIdBarrio2.Value = idBarrio2;
                var xHaySegundaDirección = command.Parameters.Add("@HaySegundaDirección", SqlDbType.Bit);
                xHaySegundaDirección.Value = haySegundaDirección;
                var xEsperaYRetorno = command.Parameters.Add("@EsperaYRetorno", SqlDbType.Bit);
                xEsperaYRetorno.Value = esperaYRetorno;
                var xIdAfiliado = command.Parameters.Add("@idAfiliado", SqlDbType.Int);
                xIdAfiliado.Value = idAfiliado1;
                var xApelNomb = command.Parameters.Add("@ApelNomb", SqlDbType.VarChar);
                xApelNomb.Value = apelNomb;
                var xIdTipoDeDocumento = command.Parameters.Add("@idTipoDeDocumento", SqlDbType.Int);
                xIdTipoDeDocumento.Value = idTipoDeDocumento;
                var xNumeroDeDocumento = command.Parameters.Add("@NumeroDeDocumento", SqlDbType.VarChar, 20);
                xNumeroDeDocumento.Value = numeroDeDocumento;
                var xEdad = command.Parameters.Add("@Edad", SqlDbType.Int);
                xEdad.Value = edad;
                var xEdadEn = command.Parameters.Add("@EdadEn", SqlDbType.VarChar);
                xEdadEn.Value = edadEn;
                var xSexo = command.Parameters.Add("@Sexo", SqlDbType.VarChar);
                xSexo.Value = sexo;
                var xIdPrepago = command.Parameters.Add("@idPrepago", SqlDbType.Int);
                xIdPrepago.Value = idPrepago;
                var xNumeroPrepago = command.Parameters.Add("NumeroPrepago", SqlDbType.VarChar);
                xNumeroPrepago.Value = numeroPrepago;
                var xImporte = command.Parameters.Add("@importe", SqlDbType.Decimal);
                xImporte.Precision = 10;
                xImporte.Scale = 2;
                xImporte.Value = importe;
                var xAntecedentes = command.Parameters.Add("@Antecedentes", SqlDbType.VarChar);
                xAntecedentes.Value = antecedentes;
                var xIdCobertura = command.Parameters.Add("@idCobertura", SqlDbType.Int);
                xIdCobertura.Value = idCobertura;
                var xIdPractica = command.Parameters.Add("@idPractica", SqlDbType.Int);
                xIdPractica.Value = idPractica;
                var xIdContrato = command.Parameters.Add("@idContrato", SqlDbType.Int);
                xIdContrato.Value = idContrato;
                var xIdTomador = command.Parameters.Add("@idTomador", SqlDbType.Int);
                xIdTomador.Value = idTomador;
                var xExtraCobertura = command.Parameters.Add("@extraCobertura", SqlDbType.Bit);
                xExtraCobertura.Value = extraCobertura;
                var xCopagoSugerido = command.Parameters.Add("@copagoSugerido", SqlDbType.Bit);
                xCopagoSugerido.Value = copagoSugerido;
                var ret = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
                ret.Direction = ParameterDirection.ReturnValue;
                connection.Open();
                command.ExecuteNonQuery();
                retorno = (int) ret.Value;
            }
            return retorno;
        }

        public DsBuscarTelefono GetAfiliadoDelTelefono(int idAfiliado1)
        {
            var ret = new DsBuscarTelefono();
            afiliadosTableAdapter1.Fill(ret.Afiliados, idAfiliado1);
            return ret;
        }

        public DsBuscarTelefono GetDireccionDelTelefono(int idDireccion)
        {
            var ret = new DsBuscarTelefono();
            direccionesTableAdapter1.Fill(ret.Direcciones, idDireccion);
            return ret;
        }

        public DsContratosLista GetContratosLista()
        {
            var ret = new DsContratosLista();
            contratosTableAdapter1.Fill(ret.Contratos);
            return ret;
        }

        public DsContratosLista GetContratosListaNoBaja()
        {
            var ret = new DsContratosLista();
            contratosTableAdapter1.FillByNoBaja(ret.Contratos);
            return ret;
        }

        public DsBuscarContrato BuscarContrato(string frase)
        {
            var ret = new DsBuscarContrato();
            buscarClientesYDireccionTableAdapter1.Fill(ret.BuscarClientesYDireccion, frase);
            if (ret.BuscarClientesYDireccion.Count == 0)
            {
                ret.BuscarClientesYDireccion.Rows.Add(0);
                ret.BuscarClientesYDireccion[0].Contrato = "Ningún Resultado";
            }
            return ret;
        }

        public DsAtencionesAnteriores GetAtencionesAnteriores(int idAfiliado, string telefono, int idPrestacion)
        {
            var ret = new DsAtencionesAnteriores();
            atencionesAnterioresTableAdapter1.Fill(ret.AtencionesAnteriores, idAfiliado, telefono, idPrestacion);
            return ret;
        }

        public decimal SugerirCopago(int idContrato, int idPlan, int idTipoDeDestino, int idCodigo, int idPractica, int idTipoDeContrato)
        {
            decimal resultado;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.SugerirCopago", connection) {CommandType = CommandType.StoredProcedure};
                command.Parameters.AddWithValue("@idContrato", idContrato);
                command.Parameters.AddWithValue("@idPlan", idPlan);
                command.Parameters.AddWithValue("@idTipoDeDestino", idTipoDeDestino);
                command.Parameters.AddWithValue("@idCodigo", idCodigo);
                command.Parameters.AddWithValue("@idPractica", idPractica);
                command.Parameters.AddWithValue("@idTipoDeContrato", idTipoDeContrato);
                var ret = command.Parameters.Add("@Result", SqlDbType.Decimal);
                ret.Direction = ParameterDirection.Output;
                connection.Open();
                command.ExecuteNonQuery();
                resultado = (decimal) command.Parameters["@Result"].Value;
            }
            return resultado;
        }

        public int ContratoDelPlan(int idPlan)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT dbo.ContratoDelPlan(@idPlan)", connection);
                command.Parameters.AddWithValue("@idPlan", idPlan);
                connection.Open();
                var idContrato = (int) command.ExecuteScalar();
                return idContrato;
            }
        }

        public string TelefonosDelAfiliado(int idAfiliado)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT dbo.TelefonosDelAfiliado(@idAfiliado)", connection);
                command.Parameters.AddWithValue("@idAfiliado", idAfiliado);
                connection.Open();
                var telefonos = command.ExecuteScalar().ToString();
                return telefonos;
            }
        }
    }
}