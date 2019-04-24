using System.ComponentModel;
using System.Data;
using System.Transactions;

namespace Administración
{
    public partial class CmpCambiosDeCobrador : Component
    {
        public CmpCambiosDeCobrador()
        {
            InitializeComponent();
        }

        public DsCambiosDeCobrador GetCambiosDeCobrador()
        {
            var ret = new DsCambiosDeCobrador();
            cambiosDeCobradorTableAdapter1.Fill(ret.CambiosDeCobrador);
            return ret;
        }

        public DsCambiosDeCobrador UpdateCambioDeCobrador(DsCambiosDeCobrador cambios)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    cambiosDeCobradorTableAdapter1.Update(cambios.CambiosDeCobrador.Select("", "",
                                                                                           DataViewRowState.Added |
                                                                                           DataViewRowState.
                                                                                               ModifiedCurrent));
                    comprobantesCambioDeCobradorTableAdapter1.Update(cambios.ComprobantesCambioDeCobrador);
                    cambiosDeCobradorTableAdapter1.Update(cambios.CambiosDeCobrador);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return cambios;
            }
        }

        public DsRepCambioDeCobrador GetRepCambioDeCobrador(int idCambioDeCobrador)
        {
            var ret = new DsRepCambioDeCobrador();
            cabeceraRepCambioCobradorTableAdapter1.Fill(ret.CabeceraRepCambioCobrador, idCambioDeCobrador);
            comprobantesRepCambioCobradorTableAdapter1.Fill(ret.ComprobantesRepCambioCobrador, idCambioDeCobrador);
            return ret;
        }
        public DsListaCambiosDeCobrador GetListaCambiosDeCobrador()
        {
            var ret = new DsListaCambiosDeCobrador();
            listaCambioDeCobradorTableAdapter1.Fill(ret.ListaCambioDeCobrador);
            return ret;
        }
    }
}