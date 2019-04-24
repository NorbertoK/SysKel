using System;
using Administración.WS;

namespace Administración
{
    public partial class FormRepAumentoAutomatico : FormCR
    {
        public FormRepAumentoAutomatico()
        {
            InitializeComponent();
        }

        public int IdAumento { private get; set; }

        private void Form_Rep_AumentoAutomatico_Load(object sender, EventArgs e)
        {
            dsRepAumentosAuto1.Merge(new Service().GetRepAumentosAuto(IdAumento, Program.Pin));
            CR_AumentosAutomaticos1.SetDataSource(dsRepAumentosAuto1);
        }
    }
}