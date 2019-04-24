using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormCobrarEnMostradorPrest : Form1
    {
        public FormCobrarEnMostradorPrest()
        {
            InitializeComponent();
        }
        private FormPrincipal _fp;
        private void FormCobrarEnMostradorPrestLoad(object sender, EventArgs e)
        {
            _fp = (FormPrincipal)MdiParent;
            backgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            var aux = new Service {Timeout = (60*60*1000)};
            dsPrestacionesConSaldo.Merge(aux.GetPrestacionesConSaldo(Program.Pin));
        }

        private void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ultraLabelEspere.Visible = false;
        }

        private void PrestacionesConSaldoUltraGridAfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (_fp.dsUsuariosLista.UsuariosLista.FindByidUsuario(Program.IdUsuario).IsidEmpleadoNull())
            {
                MessageBox.Show("Su usuario no tiene asignado un empleado.", "No está autorizado");
                buttonAceptar.Enabled = false;
                return;
            }
            Hide();
            var proceso = new Service().GetProceso(Program.Pin);
            new Service().InsertarId(proceso, (int) prestacionesConSaldoUltraGrid.ActiveRow.Cells["idComprobante"].Value,
                                     0, Program.Pin);
            var f = new FormRemesaAfiliadoMostrador
                        {
                            Proceso = proceso,
                            IdPrestacion = ((int) prestacionesConSaldoUltraGrid.ActiveRow.Cells["idPrestacion"].Value),
                            Tag = "Clientes",
                            MdiParent = MdiParent,
                            StartPosition = FormStartPosition.Manual,
                            Location = new Point(0, 0)
                        };
            f.Show();
            Close();
        }

        private void prestacionesConSaldoUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                prestacionesConSaldoUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }
    }
}