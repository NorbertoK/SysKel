using System;
using Administración.WS;

namespace Administración
{
    public partial class FormRepAfiliadosNoUnTitular : FormCR
    {
        public FormRepAfiliadosNoUnTitular()
        {
            InitializeComponent();
        }

        private void FormRepAfiliadosNoUnTitularLoad(object sender, EventArgs e)
        {
            var aux = new Service {Timeout = (60*60*1000)};
            dsRepNoUnTitular1.Merge(aux.GetAfiliadosNoUnTitular(Program.Pin));
            crAfiliadosNoUnTitular1.SetDataSource(dsRepNoUnTitular1);
        }
    }
}