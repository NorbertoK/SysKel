using System;
using Administración.WS;

namespace Administración
{
    public partial class FormRepConstanciasDeAfiliacion : FormCR
    {
        private string _periodo = "";

        public FormRepConstanciasDeAfiliacion()
        {
            InitializeComponent();
        }

        public string Periodo
        {
            get { return _periodo; }
            set { _periodo = value; }
        }

        public int IdCliente { get; set; }

        public int IdContrato { get; set; }

        public int IdPlan { get; set; }

        private void FormRepConstanciasDeAfiliacionLoad(object sender, EventArgs e)
        {
            var aux = new Service {Timeout = (60*60*1000)};
            dsRepConstanciasAfiliacion1.Merge(aux.GetConstanciasAfiliacion(Periodo, IdCliente, IdContrato, IdPlan,
                                                                             Program.Pin));
            crConstanciasAfiliacion1.SetDataSource(dsRepConstanciasAfiliacion1);
        }
    }
}