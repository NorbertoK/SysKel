using System;
using Administración.WS;

namespace Administración
{
    public partial class FormProviRepSinPlan : FormCR
    {
        public FormProviRepSinPlan()
        {
            InitializeComponent();
        }

        private void FormProviRepSinPlanLoad(object sender, EventArgs e)
        {
            var aux = new Service {Timeout = (60*60*1000)};
            dsProviSinPlan1.Merge(aux.GetProviSinPlan(Program.Pin));
            crProviSinPlan1.SetDataSource(dsProviSinPlan1);
        }
    }
}