using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Administración.Properties;
using Administración.WS;

// ReSharper disable InconsistentNaming

namespace Administración
{
    public partial class FormFacturaElectronica : Form1
    {
        private string _respuesta;

        public FormFacturaElectronica()
        {
            InitializeComponent();
        }

        private void FormPruebaFacturaElectronica_Load(object sender, EventArgs e)
        {
            dsFacturasSinCAE.Merge(new Service().GetFacturasSinCAE(Program.Pin));
            if (dsFacturasSinCAE.FacturasSinCAE.Rows.Count > 0)
                buttonAceptar.Enabled = true;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            SolicitarCAE();
            MostrarResultado();
            buttonCancelar.Enabled = true;
        }

        [Localizable(false)]
        private void MostrarResultado()
        {
            var aux = new Service().UpdatesolSolicitudesCae(dsSolicitudesCAE, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "No se grabó el archivo de Solicitudes de CAE.",
                    "¡Atención!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            // Muestro el reporte con el resultado.
            var f = new FormRepSolicitudesCAE
            {
                DsSolicitudesTraidas = dsSolicitudesCAE,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.ShowDialog(this);
        }

        private void SolicitarCAE()
        {
            for (var i = 0; i < dsFacturasSinCAE.FacturasSinCAE.Count; i++)
            {
                var renglon = dsFacturasSinCAE.FacturasSinCAE.Rows[i];
                _respuesta = new Service().GetWsfEv1(
                    (int) renglon["tipoCbte"],
                    renglon["Token"].ToString(),
                    renglon["Sign"].ToString(),
                    (int) renglon["tipoDoc"],
                    renglon["CUIT"].ToString(),
                    (int) renglon["puntoVta"],
                    renglon["nroDoc"].ToString(),
                    (long) renglon["cbtDesde"],
                    (long) renglon["cbtDesde"],
                    renglon["impTotal"].ToString(),
                    renglon["impTotConc"].ToString(),
                    renglon["impNeto"].ToString(),
                    renglon["impIVA"].ToString(),
                    renglon["impTrib"].ToString(),
                    renglon["impOpEx"].ToString(),
                    renglon["fechaCbte"].ToString(),
                    renglon["fechaVencPago"].ToString(),
                    renglon["fechaServDesde"].ToString(),
                    renglon["fechaServHasta"].ToString(),
                    renglon["baseImp3"].ToString(),
                    renglon["importeIVA3"].ToString(),
                    renglon["baseImp4"].ToString(),
                    renglon["importeIVA4"].ToString(),
                    renglon["baseImp5"].ToString(),
                    renglon["importeIVA5"].ToString(),
                    renglon["baseImp6"].ToString(),
                    renglon["importeIVA6"].ToString(),
                    renglon["baseImp8"].ToString(),
                    renglon["importeIVA8"].ToString(),
                    renglon["baseImp9"].ToString(),
                    renglon["importeIVA9"].ToString(),
                    Program.Pin);
                var solicitudCAE = dsSolicitudesCAE.SolicitudesCAE.NewSolicitudesCAERow();
                solicitudCAE.Fecha = new Service().HoraActual(Program.Pin);
                solicitudCAE.idComprobante = (int) renglon["idComprobante"];
                solicitudCAE.TipoDeComprobante = renglon["TipoComprobante"].ToString();
                solicitudCAE.Prefijo = renglon["puntoVta"].ToString().PadLeft(4, '0');
                solicitudCAE.NumeroDeComprobante = renglon["cbtDesde"].ToString();
                solicitudCAE.NombreCliente = renglon["NombreCliente"].ToString();
                if (!_respuesta.Contains("|"))
                {
                    solicitudCAE.Error = _respuesta;
                    MessageBox.Show(_respuesta, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                var partes = _respuesta.Split('|');
                solicitudCAE.Resultado = partes[0];
                solicitudCAE.CAE = partes[1];
                solicitudCAE.Reproceso = partes[2];
                solicitudCAE.Observaciones = ManejoDatos.CodePage(partes[3]);
                solicitudCAE.Vencimiento = partes[4];
                solicitudCAE.XmlRequest = partes[5];
                solicitudCAE.XmlResponse = partes[6];
                solicitudCAE.Error = ManejoDatos.CodePage(partes[7]);
                if (solicitudCAE.Resultado != @"A")
                {
                    if (solicitudCAE.Resultado == @"R")
                    {
                        dsSolicitudesCAE.SolicitudesCAE.Rows.Add(solicitudCAE);
                        MessageBox.Show(
                            "Factura Rechazada." +
                            Environment.NewLine +
                            solicitudCAE.Observaciones + Environment.NewLine + solicitudCAE.Error,
                            "Factura " + renglon["cbtDesde"]);
                        break;
                    }
                    dsSolicitudesCAE.SolicitudesCAE.Rows.Add(solicitudCAE);
                    MessageBox.Show(
                        "Error de comunicación." + Environment.NewLine +
                        "Reintente.",
                        "Factura " + renglon["cbtDesde"]);
                    break;
                }
                // Desde aquí, la solicitud ha sido aceptada.
                if (solicitudCAE.Observaciones != "")
                {
                    MessageBox.Show(
                        "Factura aceptada con observacones o errores." +
                        Environment.NewLine + solicitudCAE.Observaciones,
                        "Factura " + renglon["cbtDesde"]);
                }
                dsSolicitudesCAE.SolicitudesCAE.Rows.Add(solicitudCAE);
                solicitudesCAEUltraGrid.Update();
                new Service().GuardarCAE((int) renglon["idComprobante"], solicitudCAE.CAE, solicitudCAE.Vencimiento,
                    Program.Pin);
                var nombreArchivo = ProcesarPDF(solicitudCAE, renglon);
                if (nombreArchivo == "PDF no generado.")
                {
                    solicitudCAE.Enviada = "PDF no generado.";
                }
                else
                {
                    ProcesarEmail(renglon, solicitudCAE, nombreArchivo);
                }
                ManejoDatos.AplicarUpdate(dsFacturasSinCAE);
                facturasSinCAEUltraGrid.Refresh();
            }
        }

        private void ProcesarEmail(DataRow renglon, WS.DsSolicitudesCAE.SolicitudesCAERow solicitudCAE,
            string nombreArchivo)
        {
            if (ultraCheckEditorEnviar.Checked && !File.Exists("c:\\MiCasa\\Estoy.txt"))
            {
                try
                {
                    if (renglon["Email"] == DBNull.Value || renglon["Email"].ToString() == "")
                    {
                        solicitudCAE.Enviada = "Sin dirección.";
                    }
                    else
                    {
                        var enviada = new Service().EnviarFactura(Settings.Default.Empresa, renglon["Email"].ToString(),
                            nombreArchivo, Program.Pin);
                        if (enviada)
                        {
                            solicitudCAE.Enviada = String.Format("{0:dd/MM/yyyy HH:mm}",
                                new Service().HoraActual(Program.Pin));
                            new Service().GuardarFacturaEnviada((int) renglon["idComprobante"], Program.Pin);
                        }
                        else
                        {
                            solicitudCAE.Enviada = "Error al enviar.";
                        }
                    }
                }
                catch (Exception)
                {
                    solicitudCAE.Enviada = "Error crítico.";
                }
            }
        }

        private static string ProcesarPDF(WS.DsSolicitudesCAE.SolicitudesCAERow solicitudCAE, DataRow renglon)
        {
            var nombreArchivo = "";
            if (solicitudCAE.Resultado == @"A")
            {
                nombreArchivo = new Service().GetPDF(
                    Settings.Default.Empresa
                    , (int) renglon["tipoDoc"]
                    , renglon["nroDoc"].ToString()
                    , (int) renglon["tipoCbte"]
                    , (int) renglon["puntoVta"]
                    , (long) renglon["cbtDesde"]
                    , renglon["impTotal"].ToString()
                    , renglon["impTotConc"].ToString()
                    , renglon["impNeto"].ToString()
                    , renglon["impIVA"].ToString()
                    , renglon["impTrib"].ToString()
                    , renglon["impOpEx"].ToString()
                    , ManejoDatos.FechaConBarras(renglon["fechaCbte"].ToString())
                    , ManejoDatos.FechaConBarras(renglon["fechaVencPago"].ToString())
                    , ManejoDatos.FechaConBarras(renglon["fechaServDesde"].ToString())
                    , ManejoDatos.FechaConBarras(renglon["fechaServHasta"].ToString())
                    , solicitudCAE.CAE
                    , solicitudCAE.Vencimiento
                    , renglon["CategoriaIVA"].ToString()
                    , renglon["NombreCliente"].ToString()
                    , renglon["DireccionCliente"].ToString()
                    , solicitudCAE.Observaciones
                    , renglon["LocalidadCliente"].ToString()
                    , renglon["ProvinciaCliente"].ToString()
                    , renglon["TipoReferencia"].ToString()
                    , renglon["PrefijoReferencia"].ToString()
                    , renglon["NumeroReferencia"].ToString()
                    , renglon["baseImp4"].ToString()
                    , renglon["importeIVA4"].ToString()
                    , renglon["baseImp5"].ToString()
                    , renglon["importeIVA5"].ToString()
                    , (int) renglon["idComprobante"]
                    , solicitudCAE.TipoDeComprobante
                    , solicitudCAE.Prefijo
                    , solicitudCAE.NumeroDeComprobante
                    , Program.Pin
                    );
            }
            return nombreArchivo;
        }
    }
}