using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;

namespace Administración
{
    public partial class FormAsignarCobradorAPrestaciones : Form1
    {
        public FormAsignarCobradorAPrestaciones()
        {
            InitializeComponent();
        }

        private void FormAsignarCobradorAPrestacionesLoad(object sender, EventArgs e)
        {
            dsPrestacionesSinCobrador.Merge(new Service().GetPrestacionesSinCobrador(Program.Pin));
            dsCobradores.Merge(new Service().GetCobradores(Program.Pin));
        }

        private void UltraDropDownCobradoresFilterRow(object sender, FilterRowEventArgs e)
        {
            var fc = new FilterCondition(e.Row.Band.Columns["Activo"], FilterComparisionOperator.Equals, true);
            e.RowFilteredOut = !e.Row.MeetsCriteria(fc);
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var proceso = new Service().GetProceso(Program.Pin);
            backgroundWorker1.RunWorkerAsync(proceso);
        }

        private void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            var consulta =
                dsPrestacionesSinCobrador.PrestacionesSinCobrador.AsEnumerable().Where(
                    p => p.Field<int?>("idCobrador") > 0).Select(p => new
                                                                          {
                                                                              idComprobante =
                                                                          p.Field<int>("idComprobante"),
                                                                              idCobrador = p.Field<int>("idCobrador")
                                                                          });
            if (!consulta.Any())
            {
                MessageBox.Show("No asignó ningún cobrador.", "¡Atención!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                e.Result = "No";
            }
            else
            {
                foreach (var comprobante in consulta)
                {
                    new Service().InsertarId(e.Argument.ToString(), comprobante.idComprobante, comprobante.idCobrador,
                                             Program.Pin);
                }
                new Service().AsignarCobradorAPrestaciones(e.Argument.ToString(), Program.Pin);
                e.Result = e.Argument.ToString();
            }
        }

        private void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result.ToString() != "No")
            {
                var f = new FormRepComprobantesDeFactura
                            {
                                Proceso = e.Result.ToString(),
                                MdiParent = MdiParent,
                                StartPosition = FormStartPosition.Manual,
                                Location = new Point(0, 0)
                            };
                f.Show();
                new Service().EliminarProceso(e.Result.ToString(), Program.Pin);
                Close();
            }
            else
            {
                buttonAceptar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
        }

        private void prestacionesSinCobradorUltraGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                prestacionesSinCobradorUltraGrid.PerformAction(UltraGridAction.NextCellByTab);
        }

        private void prestacionesSinCobradorUltraGrid_AfterEnterEditMode(object sender, EventArgs e)
        {
            ManejoDatos.SeleccionInicio(sender);
        }
    }
}