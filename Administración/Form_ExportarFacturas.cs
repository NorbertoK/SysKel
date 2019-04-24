using System;
using System.Data;
using System.IO;
using Administración.WS;
using System.Windows.Forms;

namespace Administración
{
    public partial class FormExportarFacturas : Form1
    {
        public FormExportarFacturas()
        {
            InitializeComponent();
        }
        private void Ejecutar()
        {
            ultraLabelAviso.Text = "Un momentito...";
            ultraLabelAviso.Refresh();
            dsExportarImpresionFacturas.Merge(new Service().GetExportarImpresionFacturas(Program.Pin));
            if (dsExportarImpresionFacturas.ExportarImpresionFacturas.Rows.Count == 1)
            {
                ultraLabelAviso.Text = "Se creó el archivo ";
                ultraLabelAviso.Refresh();
                buttonCancelar.Visible = true;
                return;
            }
            var fecha = new Service().GetFacturasExportadas(Program.Pin);
            var dir = new DirectoryInfo("C:/Facturas");
            if (!dir.Exists)
            {
                dir.Create();
            }
            var nombreArchivo = "C:\\Facturas\\" + fecha + ".csv";
            using (var sw = File.CreateText(nombreArchivo))
            {
                foreach (DataRow row in dsExportarImpresionFacturas.ExportarImpresionFacturas)
                {
                    sw.WriteLine(row[0]);
                }
                sw.WriteLine(Convert.ToChar(13));
            }
            ultraLabelAviso.Text = "Se creó el archivo " +
                                   Environment.NewLine +
                                   nombreArchivo +
                                   ".";
            buttonCancelar.Visible = true;
        }

        private void FormExportarFacturas_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Ejecutar();
            Cursor.Current = Cursors.Default;
        }
    }
}