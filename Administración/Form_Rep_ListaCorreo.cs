using System;
using Administraci�n.WS;

namespace Administraci�n
{
    public partial class FormRepListaCorreo : FormIds
    {
        public FormRepListaCorreo()
        {
            InitializeComponent();
        }

        private void FormRepListaCorreoLoad(object sender, EventArgs e)
        {
            var aux = new Service {Timeout = (60*60*1000)};
            dsListaCorreo.Merge(aux.GetListaCorreo(AfiliadosOClientes, TipoDeDireccion, Proceso, Program.Pin));
            crListaCorreo.SetDataSource(dsListaCorreo);
        }
    }
}