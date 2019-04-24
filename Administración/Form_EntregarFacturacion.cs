using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using WS;

    public partial class FormEntregarFacturacion : Form1
    {
        public FormEntregarFacturacion()
        {
            InitializeComponent();
        }

        private void FormEntregarFacturacionLoad(object sender, EventArgs e)
        {
            dsFacturaciones.Merge(new Service().GetFacturacionesNoEntregadas(Program.Pin));
        }

        private void FacturacionesUltraGridCellChange(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            foreach (var renglon in facturacionesUltraGrid.Rows)
            {
                if (renglon.Cells["Entregar"].Text == "True")
                {
                    buttonAceptar.Enabled = true;
                    return;
                }
                buttonAceptar.Enabled = false;
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            var proceso = new Service().GetProceso(Program.Pin);
            var entregar = from ent in dsFacturaciones.Facturaciones.AsEnumerable()
                           where ent.Field<bool?>("Entregar") == true
                           select ent;
            foreach (var renglon in entregar)
            {
                new Service().EntregarFacturacion(renglon.Field<int>("idFacturacion"), Program.Pin);
                new Service().InsertarId(proceso, renglon.Field<int>("idFacturacion"), 0, Program.Pin);
            }
            var f = new FormRepEntregarFacturaciones
                        {
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0),
                            Proceso = proceso
                        };
            f.Show();
            dsFacturaciones.Clear();
            dsFacturaciones.Merge(new Service().GetFacturacionesNoEntregadas(Program.Pin));
        }

        private void facturacionesUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                facturacionesUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}