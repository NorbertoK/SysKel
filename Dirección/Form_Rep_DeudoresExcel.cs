namespace Dirección
{
    using System;
    using WS;
    public partial class FormRepDeudoresExcel : FormCR
    {
        public FormRepDeudoresExcel()
        {
            InitializeComponent();
        }
        public DsDeudores DsDeudoresTraidos { get; set; }

        private void FormRepDeudoresExcelLoad(object sender, EventArgs e)
        {
            crDeudoresExcel1.SetDataSource(DsDeudoresTraidos);
        }
    }
}
