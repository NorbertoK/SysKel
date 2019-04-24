using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using Administración.Properties;

namespace Administración
{
    public partial class CmpFacturaciones : Component
    {
        public CmpFacturaciones()
        {
            InitializeComponent();
        }

        public DsFacturaciones GetFacturaciones()
        {
            var ret = new DsFacturaciones();
            facturacionesTableAdapter1.Fill(ret.Facturaciones);
            return ret;
        }

        public DsFacturaciones GetFacturacionesNoEntregadas()
        {
            var ret = new DsFacturaciones();
            facturacionesTableAdapter1.FillNoEntregadas(ret.Facturaciones);
            return ret;
        }

        public DsFacturaciones GetFacturacionesPorProceso(string proceso)
        {
            var ret = new DsFacturaciones();
            facturacionesTableAdapter1.FillByProceso(ret.Facturaciones, proceso);
            return ret;
        }

        public DsRepAumentosAuto GetRepAumentosAuto(int idAumento)
        {
            var ret = new DsRepAumentosAuto();
            aumentosReporteTableAdapter1.Fill(ret.AumentosReporte, idAumento);
            return ret;
        }

        public DsSolicitudesCAE GetSolicitudesCae(DateTime desde, DateTime hasta)
        {
            var ret = new DsSolicitudesCAE();
            solicitudesCAETableAdapter1.FillByFecha(ret.SolicitudesCAE, desde, hasta);
            return ret;
        }

        public DsSolicitudesCAE UpdateSolicitudesCae(DsSolicitudesCAE sol)
        {
            try
            {
                solicitudesCAETableAdapter1.Update(sol.SolicitudesCAE);
            }
            catch
            {
                return null;
            }

            return sol;
        }

        public DsImportarCAE UpdateImportarCae(DsImportarCAE imp)
        {
            try
            {
                importarCAETableAdapter1.Update(imp.ImportarCAE);
            }
            catch
            {
                return null;
            }

            return imp;
        }

        public void ImportarDatosCAE(string proceso)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.ImportarDatosCAE", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                var xproceso = command.Parameters.Add("@proceso", SqlDbType.VarChar, 255);
                xproceso.Value = proceso;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EntregarFacturacion(int idFacturacion)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.EntregarFacturacion", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                var xIdFacturacion = command.Parameters.Add("@idFacturacion", SqlDbType.Int);
                xIdFacturacion.Value = idFacturacion;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DsFacturadoYCobrado GetFacturadoYCobrado(string desde, string hasta)
        {
            var ret = new DsFacturadoYCobrado();
            facturadoYCobradoTableAdapter1.Fill(ret.FacturadoYCobrado, desde, hasta);
            return ret;
        }

        public DsExportarImpresionFacturas GetExportarImpresionFacturas()
        {
            var ret = new DsExportarImpresionFacturas();
            exportarImpresionFacturasTableAdapter1.Fill(ret.ExportarImpresionFacturas);
            return ret;
        }

        public DsComprobantes GetComprobantes(int cantidad, string prefijo, string numeroInicial, string serie)
        {
            var ret = new DsComprobantes();
            comprobantesTableAdapter1.Fill(ret.Comprobantes, cantidad, prefijo, numeroInicial, serie);
            return ret;
        }

        public DsFacturaManual GetComprobantePorIdComprobante(int idComprobante)
        {
            var ret = new DsFacturaManual();
            comprobantesManualesTableAdapter1.FillByIdComprobante(ret.ComprobantesManuales, idComprobante);
            detallesComprobantesManualesTableAdapter1.FillByIdComprobante(ret.DetallesComprobantesManuales,
                idComprobante);
            return ret;
        }

        public DsFacturasSinCAE GetFacturasSinCAE()
        {
            var ret = new DsFacturasSinCAE();
            facturasSinCAETableAdapter1.Fill(ret.FacturasSinCAE);
            return ret;
        }

        public DsFacturasSinCAE GetFacturasSinCAEParaReporte()
        {
            var ret = new DsFacturasSinCAE();
            facturasSinCAETableAdapter1.Fill(ret.FacturasSinCAE);
            detalleFacturasSinCAETableAdapter1.FillTodos(ret.DetalleFacturasSinCAE);
            return ret;
        }

        public DsFacturasSinCAE GetDetalleFacturaSinCAE(int idComprobante)
        {
            var ret = new DsFacturasSinCAE();
            detalleFacturasSinCAETableAdapter1.Fill(ret.DetalleFacturasSinCAE, idComprobante);
            return ret;
        }

        public DsFacturasSinCAE GetGenerarPDF(int idComprobante)
        {
            var ret = new DsFacturasSinCAE();
            generarPDFTableAdapter1.Fill(ret.GenerarPDF, idComprobante);
            return ret;
        }

        public void GuardarCAE(int idComprobante, string cae, string vencimientoCAE)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.GuardarCAE", connection) {CommandType = CommandType.StoredProcedure};
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                var xcae = command.Parameters.Add("@CAE", SqlDbType.VarChar, 14);
                xcae.Value = cae;
                var xVenciientoCAE = command.Parameters.Add("@VencimientoCAE", SqlDbType.VarChar, 8);
                xVenciientoCAE.Value = vencimientoCAE;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void GuardarFacturaEnviada(int idComprobante)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand("dbo.GuardarFacturaEnviada", connection) {CommandType = CommandType.StoredProcedure};
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DsComprobantes UpdateComprobantes(DsComprobantes comp)
        {
            try
            {
                /* Primero agrego o modifico los padres y después los hijos */
                comprobantesTableAdapter1.Update(comp.Comprobantes.Select("", "",
                    DataViewRowState.Added |
                    DataViewRowState.ModifiedCurrent));
                detallesComprobantesTableAdapter1.Update(comp.DetallesComprobantes.Select("", "",
                    DataViewRowState.Added |
                    DataViewRowState.ModifiedCurrent));
                /* Primero elimino a los hijos y después a los padres */
                detallesComprobantesTableAdapter1.Update(comp.DetallesComprobantes);
                comprobantesTableAdapter1.Update(comp.Comprobantes);
            }
            catch
            {
                return null;
            }

            return comp;
        }

        public int? GetIdTipoDeComprobante(string tipo, int idReferencia)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT dbo.GetIdTipoDeComprobante(@tipo,@idReferencia)",
                        connection);
                var xTipo = command.Parameters.Add("@tipo", SqlDbType.VarChar, 10);
                xTipo.Value = tipo;
                var xIdReferencia = command.Parameters.Add("@idReferencia", SqlDbType.Int);
                xIdReferencia.Value = idReferencia;
                connection.Open();
                var resultado = (int) command.ExecuteScalar();
                return resultado;
            }
        }

        public string GetFacturasExportadas()
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT TOP 1 FacturasExportadas FROM dbo.Parametros",
                        connection);
                connection.Open();
                var resultado = command.ExecuteScalar().ToString();
                return resultado;
            }
        }

        public string GetWsfEv1(int tipoCbte, string token, string sign, int tipoDoc, string cuit, int puntoVta,
            string nroDoc, long cbtDesde, long cbtHasta,
            string impTotal, string impTotConc, string impNeto, string impIVA, string impTrib, string impOpEx,
            string fechaCbte, string fechaVencPago, string fechaServDesde, string fechaServHasta, string baseImp3,
            string importeIVA3, string baseImp4,
            string importeIVA4, string baseImp5, string importeIVA5, string baseImp6,
            string importeIVA6, string baseImp8, string importeIVA8, string baseImp9,
            string importeIVA9)
        {
            int vigencia;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "SELECT TOP 1 CASE WHEN VigenciaTokenSign > GETDATE() THEN 1 ELSE 0 END FROM dbo.Parametros",
                        connection);
                connection.Open();
                vigencia = (int) command.ExecuteScalar();
            }

            if (vigencia == 0)
            {
                const string cache = "";

                //' Crear objeto interface Web Service Autenticación y Autorización
                //WSAA = new object("WSAA");
                dynamic wsaa;
                try
                {
                    wsaa = Activator.CreateInstance(Type.GetTypeFromProgID("WSAA"));
                }
                catch (Exception)
                {
                    return @"No crea la instancia.";
                }

                try
                {
                    // Generar un Ticket de Requerimiento de Acceso (TRA) para WSFEv1

                    string tra = wsaa.CreateTRA("wsfe", 43200);

                    // Especificar la ubicacion de los archivos certificado y clave privada
                    const string certificado = "C:\\PyAfipWs\\SAE.crt";
                    const string claveprivada = "C:\\PyAfipWs\\SAE.key";

                    // Generar el mensaje firmado (CMS)
                    string cms = wsaa.SignTRA(tra, certificado, claveprivada);

                    // Llamar al web service para autenticar.
                    const string proxy = "";
                    var wsdl = File.Exists("c:\\MiCasa\\Estoy.txt")
                        ? "https://wsaahomo.afip.gov.ar/ws/services/LoginCms?wsdl"
                        : "https://wsaa.afip.gov.ar/ws/services/LoginCms?wsdl";
                    wsaa.Conectar(cache, wsdl, proxy); // Homologación
                    wsaa.LoginCMS(cms);
                }
                catch
                {
                    if (wsaa.Excepcion != "")
                        //return @"Excepcion";
                        return wsaa.Excepcion;
                }

                using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
                {
                    var command = new SqlCommand("dbo.GuardarTokenYSign", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    var xToken = command.Parameters.Add("@token", SqlDbType.VarChar);
                    xToken.Value = wsaa.Token;
                    var xSign = command.Parameters.Add("@sign", SqlDbType.VarChar);
                    xSign.Value = wsaa.Sign;
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                token = wsaa.Token;
                sign = wsaa.Sign;
            }


            ////////////////////////////////////////////////


            // Crear objeto interface Web Service de Factura Electrónica de Mercado Interno
            dynamic wsfEv1 = Activator.CreateInstance(Type.GetTypeFromProgID("WSFEv1"));

            try
            {
                // Setear tocken y sign de autorización (pasos previos)
                wsfEv1.Token = token;
                wsfEv1.Sign = sign;

                // CUIT del emisor (debe estar registrado en la AFIP)
                if (File.Exists("c:\\MiCasa\\Estoy.txt")) cuit = "20167784233"; // Mario Bianco
                wsfEv1.Cuit = cuit;

                // Conectar al Servicio Web de Facturación
                const string proxy = ""; // "usuario:clave@localhost:8000"
                var wsdl = File.Exists("c:\\MiCasa\\Estoy.txt")
                    ? "https://wswhomo.afip.gov.ar/wsfev1/service.asmx?WSDL"
                    : "https://servicios1.afip.gov.ar/wsfev1/service.asmx?WSDL";
                const string cache1 = ""; //Path

                wsfEv1.Conectar(cache1, wsdl, proxy, "pycurl");

                // Llamo a un servicio nulo, para obtener el estado del servidor (opcional)
                //wsfEv1.Dummy();
                //if (wsfEv1.AppServerStatus != @"OK") return @"Appserver status " + wsfEv1.AppServerStatus;
                //if (wsfEv1.DbServerStatus != @"OK") return @"Dbserver status " + wsfEv1.DbServerStatus;
                //if (wsfEv1.AuthServerStatus != @"OK") return @"Authserver status " + wsfEv1.AuthServerStatus;

                if (File.Exists("c:\\SysKel\\MostrarSiguienteFactura.txt") ||
                    File.Exists("c:\\MiCasa\\MostrarSiguienteFactura.txt"))
                {
                    // Establezco los valores de la factura a autorizar:
                    object cbteNro = wsfEv1.CompUltimoAutorizado(tipoCbte, puntoVta);
                    var lcbteNro = cbteNro.ToString() == "" ? 0 : Convert.ToInt64(cbteNro);
                    lcbteNro = lcbteNro + 1;
                    if (cbtDesde != lcbteNro)
                        return @"Intenta obtener el CAE del comprobante " + cbtDesde + @" y la AFIP espera el " +
                               lcbteNro +
                               ".";
                }
                //Borrar hasta aquí

                const int concepto = 2; // Servicios
                const string monedaId = "PES";
                const string monedaCtz = "1.000";

                var ok = wsfEv1.CrearFactura(concepto, tipoDoc, nroDoc, tipoCbte, puntoVta,
                    cbtDesde, cbtHasta, impTotal, impTotConc, impNeto,
                    impIVA, impTrib, impOpEx, fechaCbte, fechaVencPago,
                    fechaServDesde, fechaServHasta,
                    monedaId, monedaCtz);

                if ((bool) ok == false)
                    return @"No se pudo crear la factura.";

                //// Agrego comprobantes Asociados

                //// Agrego impuestos varios
                //var id = 99;
                //const string desc = "Impuesto Municipal Matanza";
                //var baseImp = "100.00";
                //const string alic = "1.00";
                //var importe = "1.00";
                //wsfEv1.AgregarTributo(id, desc, baseImp, alic, importe);

                // Agrego tasas de IVA
                if (baseImp3 != "0.00") wsfEv1.AgregarIva(3, baseImp3, importeIVA3);
                if (baseImp4 != "0.00") wsfEv1.AgregarIva(4, baseImp4, importeIVA4);
                if (baseImp5 != "0.00") wsfEv1.AgregarIva(5, baseImp5, importeIVA5);
                if (baseImp6 != "0.00") wsfEv1.AgregarIva(6, baseImp6, importeIVA6);
                if (baseImp8 != "0.00") wsfEv1.AgregarIva(8, baseImp8, importeIVA8);
                if (baseImp9 != "0.00") wsfEv1.AgregarIva(9, baseImp9, importeIVA9);

                // Habilito reprocesamiento automático (predeterminado):
                wsfEv1.Reprocesar = true;

                // Solicito CAE:
                wsfEv1.CAESolicitar();
                // Resultado|CAE|Reproceso|Observaciones|Vencimiento|XmlRequest|XmlResponse|Errores
                wsfEv1.AnalizarXml("XmlResponse");
                return wsfEv1.Resultado + "|" + wsfEv1.CAE + "|" + wsfEv1.Reproceso + "|" + wsfEv1.Obs + "|" +
                       wsfEv1.Vencimiento + "|" + wsfEv1.XmlRequest + "|" + wsfEv1.XmlResponse + "|" +
                       wsfEv1.ObtenerTagXml("Errors", "Err", "Msg");
            }
            catch
            {
                try
                {
                    return "" + "|" + wsfEv1.CAE + "|" + wsfEv1.Reproceso + "|" + wsfEv1.Obs + "|" +
                           wsfEv1.Vencimiento +
                           "|" + wsfEv1.XmlRequest + "|" + wsfEv1.XmlResponse + "|" +
                           wsfEv1.ObtenerTagXml("Errors", "Err", "Msg");
                }
                catch
                {
                    return "Error de SysKel.";
                }
            }
        }

        public string GetPDF(string empresa, int tipoDoc, string nroDoc, int tipoCbte, int puntoVta, long cbtDesde,
            string impTotal, string impTotConc, string impNeto, string impIVA, string impTrib, string impOpEx,
            string fechaCbte, string fechaVencPago, string fechaServDesde, string fechaServHasta, string cae,
            string fechaVtoCae, string categoriaIVA, string nombreCliente, string direccionCliente,
            string observaciones,
            string localidadCliente, string provinciaCliente, string tipoReferencia, string prefijoReferencia,
            string numeroReferencia, string baseImp4, string importeIVA4, string baseImp5, string importeIVA5,
            int idComprobante, string tipoDeComprobante, string prefijo, string numeroDeComprobante)
        {
            dynamic pyFEPDF = Activator.CreateInstance(Type.GetTypeFromProgID("PyFEPDF"));
            //Console.WriteLine(PyFEPDF.Version);
            //Console.WriteLine(PyFEPDF.InstallDir);
            pyFEPDF.FmtCantidad = @"0.0";
            pyFEPDF.FmtPrecio = @"0.3";
            //  Agrego datos adicionales fijos:
            pyFEPDF.AgregarDato(@"logo", pyFEPDF.InstallDir + @"\plantillas\logoSAE.png");
            // PyFEPDF.AgregarDato("afip", PyFEPDF.InstallDir + "\plantillas\afip.png")
            if (empresa == @"SAE")
            {
                pyFEPDF.CUIT = @"33642934649";
                pyFEPDF.AgregarDato(@"EMPRESA", @"Servicio Asistencial de Emergencia S.R.L.");
                pyFEPDF.AgregarDato(@"MEMBRETE1", @"Independencia 482 - S.S. de Jujuy - Argentina - CP Y4600AFX");
                pyFEPDF.AgregarDato(@"MEMBRETE2", @"Tele/Fax: 4236666 - sae@saejujuy.com.ar");
                pyFEPDF.AgregarDato(@"CUIT", @"CUIT 33-64293464-9");
                pyFEPDF.AgregarDato(@"IIBB", @"IIBB A-1-14632");
                pyFEPDF.AgregarDato(@"IVA", @"IVA Responsable Inscripto");
                pyFEPDF.AgregarDato(@"INICIO", @"Inicio de Actividad: 01/04/1992");
                //  Cargo el formato desde el archivo CSV (opcional)
                //  (carga todos los campos a utilizar desde la planilla)
                if(tipoCbte > 50 && tipoCbte < 54) // Serie M
                    pyFEPDF.CargarFormato(pyFEPDF.InstallDir + @"\\plantillas\\facturaSAE_M.csv");
                else
                    pyFEPDF.CargarFormato(pyFEPDF.InstallDir + @"\\plantillas\\facturaSAE.csv");
            }

            //PyFEPDF.AgregarDato("ObservacionesGenerales1", "Nota al pie1");
            //PyFEPDF.AgregarDato("ObservacionesGenerales2", "");
            //PyFEPDF.AgregarDato("ObservacionesGenerales3", "");
            pyFEPDF.CrearFactura(
                2 //Concepto
                , tipoDoc //tipo_doc
                , nroDoc //nro_doc
                , tipoCbte //tipo_cbte
                , puntoVta //punto_vta
                , cbtDesde //cbte_nro
                , impTotal //imp_total
                , impTotConc //imp_tot_conc
                , impNeto //imp_neto
                , impIVA //imp_tot_iva
                , impTrib //imp_trib
                , impOpEx //imp_op_ex
                , fechaCbte //fecha_cbte
                , "" //fechaVencPago //fecha_venc_pago
                , fechaServDesde //fecha_serv_desde
                , fechaServHasta //fecha_serv_hasta
                , @"PES" //moneda_id
                , @"1.000" //moneda_ctz
                , cae //cae
                , fechaVtoCae //fecha_vto_cae
                , categoriaIVA //id_impositivo
                , nombreCliente //nombre_cliente
                , direccionCliente //domicilio_cliente
                , 200 //pais_dst_cmp
                , "" //obs_comerciales
                , "" //obs_generales
                , @"" //forma_pago
                , "" //incoterms
                , 1 //idioma_cbte
                , observaciones //motivo_obs
                , @"0.00" //descuento
            );
            pyFEPDF.EstablecerParametro("localidad_cliente", localidadCliente);
            pyFEPDF.EstablecerParametro("provincia_cliente", provinciaCliente);
            //  Logotipo AFIP Comprobante No Autorizado (cambiar resultado="N")
            pyFEPDF.EstablecerParametro("resultado", @"A");
            //  Agregar comprobantes asociados (si es una NC/ND):
            if (!string.IsNullOrEmpty(tipoReferencia))
                pyFEPDF.AgregarCmpAsoc(tipoReferencia, prefijoReferencia, numeroReferencia);
            if (baseImp4 != @"0.00") pyFEPDF.AgregarIva(4, baseImp4, importeIVA4);
            if (baseImp5 != @"0.00") pyFEPDF.AgregarIva(5, baseImp5, importeIVA5);

            //  Agregar cada impuesto (por ej. IIBB, retenciones, percepciones, etc.):
            //tributo_id = 99;
            ////  codigo para 99-otros tributos
            //Desc = "Impuesto Municipal Matanza";
            //base_imp = "100.00";
            //alic = "1.00";
            //importe = "1.00";
            //PyFEPDF.AgregarTributo(tributo_id, Desc, base_imp, alic, importe);

            //  Agrego detalles de cada item de la factura:
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command =
                    new SqlCommand(
                        "dbo.DetalleFacturasSinCAE", connection) {CommandType = CommandType.StoredProcedure};
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                        pyFEPDF.AgregarDetalleItem(
                            "" // u_mtx
                            , "" //cod_mtx
                            , "" //codigo
                            , reader["ds"].ToString() //ds
                            , reader["qty"].ToString() //qty
                            , 7 //umed
                            , reader["PrecioUnitario"].ToString() //precio
                            , @"0.00" //bonif
                            , reader["iva_id"].ToString() //iva_id
                            , reader["imp_iva"].ToString() //imp_iva
                            , reader["ImporteDelDetalle"].ToString() //importe_item
                            , "" //despacho
                            , "" //dato_a
                            , "" //dato_b
                            , "" //dato_c
                            , "" //dato_d
                            , "" //dato_e
                        );
                    reader.Close();
                }
            }

            //  Agrego campos manualmente (opcional):
            pyFEPDF.AgregarCampo(
                @"idComprobante" //nombre
                , @"T" //tipo
                , 20 //X1
                , 210 //Y1
                , 50 //X2
                , 255 //Y2
                , @"Arial" //Font
                , 7 //Size
                , 0 //Bold
                , 0 //Italic
                , 0 //Underline
                , @"000000" //foreground
                , @"FFFFFF" //background
                , @"C" //Align
                , @"idComprobante: " + idComprobante //Texto
                , 2 //orden
            );
            pyFEPDF.CrearPlantilla(
                "A4" //papel
                , "portrait" //orientacion
            );
            pyFEPDF.ProcesarPlantilla(
                3 //num_copias
                , 24 //lineas_max
                , "der" //qty_pos
            );
            var ruta = "C:\\SysKel\\PDFs\\";
            var nombreArchivo = tipoDeComprobante.Replace(" ", "") + "-" + prefijo + "-" +
                                numeroDeComprobante.PadLeft(8, '0') + ".pdf";
            try
            {
                pyFEPDF.GenerarPDF(ruta + nombreArchivo);
                //pyFEPDF.MostrarPDF(salida //Salida
                //    , 0 // Imprimir
                //    );
                return nombreArchivo;
            }
            catch
            {
                return "PDF no generado.";
            }
        }

        public bool EnviarFactura(string empresa, string destinatario, string nombreArchivo)
        {
            var ruta = "C:\\SysKel\\PDFs\\";
            var rutaYNombreArchivo = ruta + nombreArchivo;
            var msg = new MailMessage();
            msg.To.Add(destinatario);
            msg.Subject = nombreArchivo;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = false;
            //Agrego el archivo que puse en la ruta anterior "PathFile", y su tipo.
            var data = new Attachment(rutaYNombreArchivo, MediaTypeNames.Application.Pdf);
            //Obtengo las propiedades del archivo.
            var disposition = data.ContentDisposition;
            disposition.CreationDate = File.GetCreationTime(rutaYNombreArchivo);
            disposition.ModificationDate = File.GetLastWriteTime(rutaYNombreArchivo);
            disposition.ReadDate = File.GetLastAccessTime(rutaYNombreArchivo);
            //Agrego el archivo al mensaje
            msg.Attachments.Add(data);
            var client = new SmtpClient {Port = 587, Host = "smtp.gmail.com", EnableSsl = true};
            if (empresa == "SAE")
            {
                msg.From = new MailAddress("su.factura.SAE@gmail.com", "Su factura de SAE", Encoding.UTF8);
                msg.ReplyToList.Add(new MailAddress("saejujuy@gmail.com"));
                client.Credentials =
                    new NetworkCredential("su.factura.SAE@gmail.com", Desencriptar("ubvLCZND2rtRAzpNHvrBmw=="));
                msg.Body = "Adjuntamos su factura de SAE.";
            }

            try
            {
                using (client)
                {
                    client.Send(msg);
                    return true;
                }
            }
            catch (SmtpException)
            {
                return false;
            }
        }

        public DsPorcentajeIVA GetPorcentajeIVA()
        {
            var ret = new DsPorcentajeIVA();
            porcentajeIVATableAdapter1.Fill(ret.PorcentajeIVA);
            return ret;
        }

        private string Desencriptar(string textoEncriptado)
        {
            const string key = "ABCDEFGHIJKLMÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz";
            try
            {
                var arrayADescifrar = Convert.FromBase64String(textoEncriptado);
                var hashmd5 = new MD5CryptoServiceProvider();
                var keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
                var tdes = new TripleDESCryptoServiceProvider
                {
                    Key = keyArray,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
                var cTransform = tdes.CreateDecryptor();
                var resultArray = cTransform.TransformFinalBlock(arrayADescifrar, 0, arrayADescifrar.Length);
                tdes.Clear();
                var res = Encoding.UTF8.GetString(resultArray);
                return res;
            }
            catch (Exception)
            {
                return "Cualquier verdura.";
            }
        }

        public int AumentosAutomaticos(decimal aumento, string frase)
        {
            int retorno;
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                SqlParameter xidAumento;
                using (var command = new SqlCommand("dbo.AumentosAutomaticos", connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    xidAumento = command.Parameters.Add("@idAumento", SqlDbType.Int);
                    xidAumento.Direction = ParameterDirection.Output;
                    var xaumento = command.Parameters.Add("@aumento", SqlDbType.Decimal);
                    xaumento.Value = aumento;
                    var xfrase = command.Parameters.Add("@frase", SqlDbType.VarChar, 1000);
                    xfrase.Value = frase;
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                retorno = (int) xidAumento.Value;
            }

            return retorno;
        }
    }
}