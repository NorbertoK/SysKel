namespace Dirección
{
    using WS;
    public partial class FormRepDeudoresResumen : FormCR
    {
        public FormRepDeudoresResumen()
        {
            InitializeComponent();
        }
        public DsDeudores DsDeudoresTraidos { get; set; }
        private void FormRepDeudoresResumenLoad(object sender, System.EventArgs e)
        {
            crDeudoresResumen1.SetDataSource(DsDeudoresTraidos);
        }
    }
}
