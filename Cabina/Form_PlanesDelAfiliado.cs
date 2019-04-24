using System;
using System.Drawing;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    public partial class FormPlanesDelAfiliado : Form1
    {
        public FormPlanesDelAfiliado()
        {
            InitializeComponent();
        }

        public int IdAfiliado { get; set; }

        private void FormPlanesDelAfiliadoLoad(object sender, EventArgs e)
        {
            dsBuscarAfiliados.Merge(new Service().GetBuscarAfiliados("idAfiliado = " + IdAfiliado, Program.Pin));
            ultraGrid.DisplayLayout.Bands[0].SortedColumns.Clear();
            ultraGrid.DisplayLayout.Bands[0].SortedColumns.Add("Nombre", false, false);
            ultraGrid.Rows[0].Activate();
            ultraGrid.ActiveRow = null;
        }

        private void UltraGridInitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["Estado"].Text == "Activo")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Green;
            }
            if (e.Row.Cells["Estado"].Text == "Alta Reciente")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.DarkMagenta;
            }
            if (e.Row.Cells["Estado"].Text == "Baja")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Red;
            }
            if (e.Row.Cells["Estado"].Text == "Suspendido")
            {
                e.Row.Cells["Estado"].Appearance.ForeColor = Color.Blue;
            }
            if (e.Row.Cells["Nombre"].Text == "Ningún Resultado")
            {
                e.Row.Cells["Nombre"].Appearance.ForeColor = Color.Red;
            }
        }
    }
}