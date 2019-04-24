using System;

namespace Administración
{
    public partial class FormRepSolicitudesCAE : FormCR
    {
        public FormRepSolicitudesCAE()
        {
            InitializeComponent();
        }
        public WS.DsSolicitudesCAE DsSolicitudesTraidas { get; set; }
        private void FormRepSolicitudesCAE_Load(object sender, EventArgs e)
        {
            CR_SolicitudesCAE1.SetDataSource(DsSolicitudesTraidas);
        }
    }
}
