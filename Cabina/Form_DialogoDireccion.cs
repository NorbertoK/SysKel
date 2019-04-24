using System;

namespace Cabina
{
    public partial class FormDialogoDireccion : Form1
    {
        public delegate void DelegadoVariable(string mensaje);
        public event DelegadoVariable MiEvento;
        public FormDialogoDireccion()
        {
            InitializeComponent();
        }

        private void UltraOptionSet1ValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            MiEvento(ultraOptionSetDirecciones.Value.ToString());
            Close();
        }
    }
}
