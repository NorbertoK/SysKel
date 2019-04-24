namespace Dirección
{
    using System;
    using WS;

    public partial class FormRepDeudores : FormCR
    {
        public FormRepDeudores()
        {
            InitializeComponent();
        }

        public DsDeudores DsDeudoresTraidos { get; set; }

        private void FormRepDeudoresLoad(object sender, EventArgs e)
        {
            crDeudores.SetDataSource(DsDeudoresTraidos);
        }
    }
}