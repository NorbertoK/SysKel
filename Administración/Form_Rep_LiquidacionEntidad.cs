using System;

namespace Administración
{
    using WS;

    public partial class FormRepLiquidacionEntidad : FormCR
    {
        public FormRepLiquidacionEntidad()
        {
            InitializeComponent();
        }
        public int IdLiquidacionEntidad { get; set; }
        private void FormRepLiquidacionEntidadLoad(object sender, EventArgs e)
        {
            dsReportLiquidacionEntidad1.Merge(new Service().GetReportLiquidacionEntidad(IdLiquidacionEntidad,
                                                                                         Program.Pin));
            crLiquidacionEntidad1.SetDataSource(dsReportLiquidacionEntidad1);
        }
    }
}
