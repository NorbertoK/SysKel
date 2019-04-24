using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormImportarRespuestaWilly : Form1
    {
        public FormImportarRespuestaWilly()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv";
            openFileDialog1.FileName = "";
            var rta = openFileDialog1.ShowDialog();
            if (rta == DialogResult.Cancel) return;
            textBox1.Text = openFileDialog1.FileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = textBox1.Text != "";
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var proceso = new Service().GetProceso(Program.Pin);
            var lector = new StreamReader(textBox1.Text);
            var registro = lector.ReadLine();
            while (registro != null)
            {
                var partes = registro.Split(';', '-');
                var destino = dsImportarCAE.ImportarCAE.NewRow();
                destino["Proceso"] = proceso;
                destino["idComprobante"] = Convert.ToInt32(partes[0]);
                if (partes[1] == "FA") destino["idTipoDeComprobante"] = 7;
                if (partes[1] == "FB") destino["idTipoDeComprobante"] = 8;
                if (partes[1] == "NCA") destino["idTipoDeComprobante"] = 12;
                if (partes[1] == "NCB") destino["idTipoDeComprobante"] = 13;
                destino["Prefijo"] = partes[2];
                destino["NumeroDeComprobante"] = partes[3];
                destino["CAE"] = partes[4];
                destino["Fecha"] =
                    DateTime.ParseExact(partes[5] + partes[6] + partes[7],
                        "yyyyMMdd", CultureInfo.InvariantCulture);
                dsImportarCAE.ImportarCAE.Rows.Add(destino);
                registro = lector.ReadLine();
            }
            lector.Close();
            new Service().UpdateImportarCAE(dsImportarCAE, Program.Pin);
            new Service().ImportarDatosCAE(proceso,Program.Pin);
            Close();
        }
    }
}