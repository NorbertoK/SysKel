using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    public partial class FormAtencionesAnteriores : Form1
    {
        public FormAtencionesAnteriores()
        {
            InitializeComponent();
        }

        public int IdAfiliado { get; set; }

        public string Telefono { get; set; }

        public int IdPrestacion { get; set; }

        private void AtencionesAnterioresUltraGridInitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Bands[0].SortedColumns.Add("TipoDeBusqueda", false, true);
        }

        private void FormAtencionesAnterioresLoad(object sender, EventArgs e)
        {
            dsAtencionesAnteriores.Merge(new WS.Service().GetAtencionesAnteriores(IdAfiliado, Telefono,
                                                                                                  IdPrestacion,
                                                                                                  Program.Pin));
        }

        private void atencionesAnterioresUltraGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                atencionesAnterioresUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}