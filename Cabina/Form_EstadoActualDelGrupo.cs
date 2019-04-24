using System;
using System.Drawing;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;

namespace Cabina
{
    public partial class FormEstadoActualDelGrupo : Form1
    {
        public FormEstadoActualDelGrupo()
        {
            InitializeComponent();
        }

        public int Grupo { get; set; }

        private void EstadoAfiliadosDelGrupoUltraGridInitializeRow(object sender, InitializeRowEventArgs e)
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

        private void FormEstadoActualDelGrupoLoad(object sender, EventArgs e)
        {
            ds_EstadoActualDelGrupo.Merge(new Service().GetEstadoActualDelGrupo(Grupo, Program.Pin));
            estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Bands[0].SortedColumns.Clear();
            estadoAfiliadosDelGrupoUltraGrid.DisplayLayout.Bands[0].SortedColumns.Add("Nombre", false, false);
            estadoAfiliadosDelGrupoUltraGrid.ActiveRow = null;
        }
    }
}