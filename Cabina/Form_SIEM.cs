using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Cabina
{
    public partial class FormSiem : Form
    {
        private string _tresCifras = "";

        public FormSiem()
        {
            InitializeComponent();
        }

        public string TresCifras
        {
            get { return _tresCifras; }
            set { _tresCifras = value; }
        }

        private void FormSiemLoad(object sender, EventArgs e)
        {
            var nombreArchivo = "Cabina.Fichas.SIEM_" + TresCifras + ".gif";
            var myBitmap = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(nombreArchivo));
            pictureBox1.Image = myBitmap;
        }
    }
}