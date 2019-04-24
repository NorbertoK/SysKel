using System.ComponentModel;

namespace Administración
{
    public partial class CmpEstadoDeLaCobranza : Component
    {
        public CmpEstadoDeLaCobranza()
        {
            InitializeComponent();
        }

        public DsEstadoDeLaCobranza GetEstadoDeLaCobranza(int idCobrador, string fecha, int meses, string mostrarFuturo)
        {
            var ret = new DsEstadoDeLaCobranza();
            estadoDeLaCobranzaTableAdapter1.SetTimeOut();
            estadoDeLaCobranzaTableAdapter1.Fill(ret.EstadoDeLaCobranza, idCobrador,fecha,meses,mostrarFuturo);
            return ret;
        }
        public DsEntidadesSinLiquidar GetEntidadesSinLiquidar()
        {
            var ret = new DsEntidadesSinLiquidar();
            view_EntidadesSinLiquidarTableAdapter1.Fill(ret.View_EntidadesSinLiquidar);
            return ret;
        }
    }
}