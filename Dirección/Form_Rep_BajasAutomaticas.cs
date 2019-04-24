using System;

namespace Dirección
{
    using WS;

    public partial class FormRepBajasAutomaticas : FormCR
    {
        public FormRepBajasAutomaticas()
        {
            InitializeComponent();
        }
        public string Proceso { get; set; }

        private void FormRepBajasRecientesLoad(object sender, EventArgs e)
        {
            dsRepBajasAutomaticas1.Merge(new Service().GetListadoBajasAutomaticas(Proceso,Program.Pin));
            crBajasAutomaticas1.SetDataSource(dsRepBajasAutomaticas1);
            new Service().EliminarProceso(Proceso,Program.Pin);
        }

    }
}
