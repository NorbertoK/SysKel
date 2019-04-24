using System;
using Dirección.WS;

namespace Dirección
{
    public partial class FormRepEstPrestMedicamentosUtilizados : FormCR
    {
        public FormRepEstPrestMedicamentosUtilizados()
        {
            InitializeComponent();
        }
        public DateTime Desde { private get; set; }
        public DateTime Hasta { private get; set; }

        private void FormRepEstPrestLocalidadMotivoCodigoLoad(object sender, EventArgs e)
        {
            dsRepPrestMedicamentosUtilizados1.Merge(new Service().GetRepPrestMedicamentosUtilizados(
                                                 Desde.ToString("yyyyMMdd"), Hasta.ToString("yyyyMMdd"), Program.Pin));
            crEstPrestMedicamentosUtilizados1.SetDataSource(dsRepPrestMedicamentosUtilizados1);
        }
    }
}
