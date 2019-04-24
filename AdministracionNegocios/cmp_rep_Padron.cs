using System;
using System.ComponentModel;

namespace Administración
{
    public partial class CmpRepPadron : Component
    {
        public CmpRepPadron()
        {
            InitializeComponent();
        }

        public DsRepPadron GetPadron(DateTime @fecha, int idZona)
        {
            var ret = new DsRepPadron();
            padronTableAdapter1.SetTimeOut();
            padronTableAdapter1.Fill(ret.Padron, fecha, idZona);
            return ret;
        }
    }
}