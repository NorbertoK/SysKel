using System;
using Administración.WS;

namespace Administración
{
    public partial class FormRepCambioDeCobrador : FormCR
    {
        public FormRepCambioDeCobrador()
        {
            InitializeComponent();
        }

        public int IdCambioDeCobrador { private get; set; }

        private void FormRepCambioDeCobradorLoad(object sender, EventArgs e)
        {
            dsRepCambioDeCobrador1.Merge(new Service().GetRepCambioDeCobrador(IdCambioDeCobrador, Program.Pin));
            crCambioCobrador1.SetDataSource(dsRepCambioDeCobrador1);
        }
    }
}