using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCPuntosDeVenta : Component
    {
        public CmpABCPuntosDeVenta()
        {
            InitializeComponent();
        }

        public DsPuntosDeVenta GetPuntosDeVenta()
        {
            var ret = new DsPuntosDeVenta();
            puntosDeVentaTableAdapter1.Fill(ret.PuntosDeVenta);
            return ret;
        }

        public DsPuntosDeVenta UpdatePuntosDeVenta(DsPuntosDeVenta puntos)
        {
            try
            {
                puntosDeVentaTableAdapter1.Update(puntos.PuntosDeVenta);
            }
            catch
            {
                return null;
            }
            return puntos;
        }
    }
}