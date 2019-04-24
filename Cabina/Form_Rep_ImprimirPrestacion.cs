using System;

namespace Cabina
{
    public partial class FormRepImprimirPrestacion : FormCR
    {
        private string _proceso = "Nada";

        public FormRepImprimirPrestacion()
        {
            InitializeComponent();
        }

        public int IdPrestacion { get; set; }

        public string Proceso
        {
            get { return _proceso; }
            set { _proceso = value; }
        }

        private void FormRepImprimirPrestacionLoad(object sender, EventArgs e)
        {
            var aux = new WS.Service {Timeout = (60 * 60 * 1000)};
            dsImprimirPrestacion1.Merge(Proceso == "Nada"
                ? aux.GetImprimirPrestacion(IdPrestacion, Program.Pin)
                : aux.GetImprimirPrestaciones(Proceso, Program.Pin));
            crImprimirPrestacion1.SetDataSource(dsImprimirPrestacion1);
        }
    }
}