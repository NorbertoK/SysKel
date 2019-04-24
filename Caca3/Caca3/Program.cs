// Ejemplo de Uso de Interface COM para generar Facturas Electrónica en formato PDF
// Según AFIP Resolición General 2485/2006 y normativa relacionada (RG1415/03 y RG1361), aplicable a:
//  * merado interno (WSFEv1 y WSMTXCA, incluyendo importación, con y sin detalle)
//  * exportación (WSFEX)
//  * bono fiscal electrónico (WSBFE)
// 2011 (C) Mariano Reingart <reingart@gmail.com>
// Licencia: GPLv3
using System;
namespace Caca3
{
    internal class Program
    {
        private static void Main()
        {
            int tipo_cbte;
            int punto_vta;
            int cbte_nro;
            int tipo_doc;
            string nro_doc;
            string nombre_cliente; 
            string domicilio_cliente; 
            string localidad_cliente; 
            string provincia_cliente; 
            string imp_total;
            string imp_tot_conc;
            string imp_neto;
            string imp_tot_iva;
            string imp_trib;
            string imp_op_ex;
            string fecha_cbte;
            string fecha_venc_pago;
            string fecha_serv_desde;
            string fecha_serv_hasta;
            string motivo_obs;
            string cae;
            string fecha_vto_cae;
            string baseImp4;
            string importeIVA4;
            string baseImp5;
            string importeIVA5;
            //int tributo_id;
            //string Desc;
            //string base_imp;
            //string alic;
            //string importe;
            // Detalle
            string ds;
            int qty;
            string precio;
            //string bonif;
            int iva_id;
            string imp_iva;
            string importe_item;
            // Generales
            int idComprobante;
            string salida;
            bool imprimir;


            //object PyFEPDF;

            //  Crear objeto interface para generaci�n de F.E. en PDF
            dynamic PyFEPDF = Activator.CreateInstance(Type.GetTypeFromProgID("PyFEPDF"));
            Console.WriteLine(PyFEPDF.Version);
            Console.WriteLine(PyFEPDF.InstallDir);
            //  CUIT del emisor
            PyFEPDF.CUIT = "33693450239";
            PyFEPDF.FmtCantidad = "0.0";
            PyFEPDF.FmtPrecio = "0.2";
            tipo_cbte = 1; //  Factura A
            punto_vta = 4000; //  prefijo
            cbte_nro = 12345678; //  número de factura
            const int concepto = 2; // Servicios
            //  datos del cliente:
            tipo_doc = 80;
            nro_doc = "30000000007";
            nombre_cliente = "Joao Da Silva";
            domicilio_cliente = "Rua 76 km 34.5 Alagoas";
            const int pais_dst_cmp = 200;

            const string id_impositivo = ""; //  Código para exportación
            imp_total = "122.00";
            imp_tot_conc = "0.00";

            imp_neto = "100.00";
            imp_tot_iva = "21.00";
            imp_trib = "1.00";
            imp_op_ex = "0.00";
            const string descuento = "0.00";
            fecha_cbte = "27/03/2011";
            fecha_venc_pago = "27/03/2011";
            //  Fechas del período del servicio facturado
            fecha_serv_desde = "27/03/2011";
            fecha_serv_hasta = "27/03/2011";
            const string moneda_id = "PES";
            const string moneda_ctz = "1.000";
            const string obs_generales = "";
            const string obs_comerciales = "";
            const string forma_pago = "10 dias";
            const string incoterms = "";
            const int idioma_cbte = 1;
            //  motivo de observación (F136 y otros - RG2485/08 Art. 30 inc. c):
            motivo_obs = ("10063: Factura individual, DocTipo: 80, " +
                          "DocNro 30000000007 no se encuentra inscripto en condicion ACTIVA en el impuesto.");
            cae = "61123022925855";
            fecha_vto_cae = "20110320";
            PyFEPDF.CrearFactura(concepto, tipo_doc, nro_doc, tipo_cbte, punto_vta, cbte_nro, imp_total, imp_tot_conc,
                imp_neto, imp_tot_iva, imp_trib, imp_op_ex, fecha_cbte, fecha_venc_pago, fecha_serv_desde,
                fecha_serv_hasta, moneda_id, moneda_ctz, cae, fecha_vto_cae, id_impositivo, nombre_cliente,
                domicilio_cliente, pais_dst_cmp, obs_comerciales, obs_generales, forma_pago, incoterms, idioma_cbte,
                motivo_obs, descuento);
            localidad_cliente = "Hurlingham";
            provincia_cliente = "Buenos Aires";
            PyFEPDF.EstablecerParametro("localidad_cliente", localidad_cliente);
            PyFEPDF.EstablecerParametro("provincia_cliente", provincia_cliente);
            //  Logotipo AFIP Comprobante Autorizado (cambiar resultado="A")
            PyFEPDF.EstablecerParametro("resultado", "N");



            //  Agregar comprobantes asociados (si es una NC/ND):
            // tipo = 19
            // pto_vta = 2
            // nro = 1234
            // pyfepdf.AgregarCmpAsoc(tipo, pto_vta, nro)
            // Agrego tasas de IVA
            baseImp4 = "0.00";
            importeIVA4 = "0.00";
            baseImp5 = "0.00";
            importeIVA5 = "0.00";
            if (baseImp4 != "0.00")
            {
                PyFEPDF.AgregarIva(4, baseImp4, importeIVA4);
            }
            if (baseImp5 != "0.00")
            {
                PyFEPDF.AgregarIva(5, baseImp5, importeIVA5);
            }
            //  Agregar cada impuesto (por ej. IIBB, retenciones, percepciones, etc.):
            //tributo_id = 99;
            ////  codigo para 99-otros tributos
            //Desc = "Impuesto Municipal Matanza";
            //base_imp = "100.00";
            //alic = "1.00";
            //importe = "1.00";
            //PyFEPDF.AgregarTributo(tributo_id, Desc, base_imp, alic, importe);
            //  Agrego detalles de cada item de la factura:
            const string u_mtx = ""; //  unidades
            const string cod_mtx = ""; // código de barras
            const string codigo = "";
            ds = "Descripcion del producto P0001";
            qty = 1;
            //  cantidad
            const int umed = 7; //  código de unidad de medida (ej. 7 para "unidades")
            precio = "100.00"; //  precio neto (A) o iva incluido (B)
            const string bonif = "0.00"; //  importe de descuentos
            iva_id = 5; //  código para alícuota del 21%
            imp_iva = "21.00"; //  importe liquidado de iva
            importe_item = "121.00"; //  importe total del item
            const string despacho = "";
            const string dato_a = "";
            const string dato_b = "";
            const string dato_c = "";
            const string dato_d = "";
            const string dato_e = "";
            PyFEPDF.AgregarDetalleItem(u_mtx, cod_mtx, codigo, ds, qty, umed, precio, bonif, iva_id, imp_iva,
                importe_item, despacho, dato_a, dato_b, dato_c, dato_d, dato_e);
            //  Agrego datos adicionales fijos:
            PyFEPDF.AgregarDato("logo", (PyFEPDF.InstallDir + "\\plantillas\\logoSAE.png"));
            // PyFEPDF.AgregarDato("afip", PyFEPDF.InstallDir + "\plantillas\afip.png")
            PyFEPDF.AgregarDato("EMPRESA", "Sistema Asistencial de Emergencia S.R.L.");
            PyFEPDF.AgregarDato("MEMBRETE1", "Independencia 482 - S.S. de Jujuy - Argentina - CP Y4600AFX");
            PyFEPDF.AgregarDato("MEMBRETE2", "Tele/Fax: 4236666 - sae@saejujuy.com.ar");
            PyFEPDF.AgregarDato("CUIT", "CUIT 33-64293464-9");
            PyFEPDF.AgregarDato("IIBB", "IIBB A-1-14632");
            PyFEPDF.AgregarDato("IVA", "IVA Responsable Inscripto");
            PyFEPDF.AgregarDato("INICIO", "Inicio de Actividad: 01/04/1992");
            //PyFEPDF.AgregarDato("ObservacionesGenerales1", "Nota al pie1");
            //PyFEPDF.AgregarDato("ObservacionesGenerales2", "");
            //PyFEPDF.AgregarDato("ObservacionesGenerales3", "");
            //  Cargo el formato desde el archivo CSV (opcional)
            //  (carga todos los campos a utilizar desde la planilla)
            PyFEPDF.CargarFormato((PyFEPDF.InstallDir + "\\plantillas\\facturaSAE.csv"));
            //  Agrego campos manualmente (opcional):
            const string nombre = "idComprobante";
            const string tipo = "T";
            const int X1 = 20;
            const int Y1 = 210;
            const int X2 = 50;
            const int Y2 = 255;
            //  coordenadas (en milimetros)
            const string Font = "Arial";
            const int Size = 6;
            const int Bold = 0;
            const int Italic = 0;
            const int Underline = 0;
            //  tipo de letra
            const string foreground = "000000";
            const string background = "FFFFFF";
            const string Align = "C";
            const int orden = 2;
            //  Orden Z, menor prioridad se dibuja primero (para superposiciones)
            idComprobante = 123456;
            var Texto = "idComprobante: " + idComprobante;
            PyFEPDF.AgregarCampo(nombre, tipo, X1, Y1, X2, Y2, Font, Size, Bold, Italic, Underline, foreground,
                background, Align, Texto, orden);
            //  Creo plantilla para esta factura (papel A4 vertical):
            const string papel = "A4";
            const string orientacion = "portrait";
            PyFEPDF.CrearPlantilla(papel, orientacion);
            const int num_copias = 3; //  original, duplicado y triplicado
            const int lineas_max = 24; //  cantidad de linas de items por p�gina
            const string qty_pos = "der";
            PyFEPDF.ProcesarPlantilla(num_copias, lineas_max, qty_pos);
            //  Genero el PDF de salida seg�n la plantilla procesada
            salida = "c:\\factura.pdf";
            PyFEPDF.GenerarPDF(salida);
            //  Abro el visor de PDF y muestro lo generado
            //  (es necesario tener instalado Acrobat Reader o similar)
            imprimir = false; // cambiar a True para que lo envie directo a la impresora
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            PyFEPDF.MostrarPDF(salida, imprimir);
        }
    }
}