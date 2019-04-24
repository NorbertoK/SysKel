using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCPuestosDelUsuario : Component
    {
        public CmpABCPuestosDelUsuario()
        {
            InitializeComponent();
        }

        public DsPuestosDelUsuario GetPuestosDelUsuario()
        {
            var ret = new DsPuestosDelUsuario();
            puestosUsuariosTableAdapter1.Fill(ret.PuestosUsuarios);
            return ret;
        }

        public DsPuestosDelUsuario UpdatePuestosDelUsuario(DsPuestosDelUsuario usu)
        {
            try
            {
                puestosUsuariosTableAdapter1.Update(usu.PuestosUsuarios);
            }
            catch
            {
                return null;
            }
            return usu;
        }

        public DsUsuarios GetUsuarios()
        {
            var ret = new DsUsuarios();
            usuariosTableAdapter1.Fill(ret.Usuarios);
            return ret;
        }

        public DsUsuarios UpdateUsuarios(DsUsuarios usu)
        {
            try
            {
                usuariosTableAdapter1.Update(usu.Usuarios);
            }
            catch
            {
                return null;
            }
            return usu;
        }

        public DsUsuariosLista GetUsuariosLista()
        {
            var ret = new DsUsuariosLista();
            usuariosListaTableAdapter1.Fill(ret.UsuariosLista);
            return ret;
        }
    }
}