using System.ComponentModel;

namespace Administración
{
    public partial class CmpABCMedicosDeCabecera : Component
    {
        public CmpABCMedicosDeCabecera()
        {
            InitializeComponent();
        }

        public DsMedicosDeCabecera GetMedicosDeCabecera()
        {
            var ret = new DsMedicosDeCabecera();
            medicosDeCabeceraTableAdapter1.Fill(ret.MedicosDeCabecera);
            return ret;
        }

        public DsMedicosDeCabecera UpdateMedicosDeCabecera(DsMedicosDeCabecera med)
        {
            try
            {
                medicosDeCabeceraTableAdapter1.Update(med.MedicosDeCabecera);
            }
            catch
            {
                return null;
            }
            return med;
        }

        public DsMedicosDeCabecera GetMedicosDeCabederaLista()
        {
            var ret = new DsMedicosDeCabecera();
            medicosDeCabeceraListaTableAdapter1.Fill(ret.MedicosDeCabeceraLista);
            return ret;
        }
    }
}