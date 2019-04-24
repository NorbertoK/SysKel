﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormNdeCPrestacion : Form1
    {
        public FormNdeCPrestacion()
        {
            InitializeComponent();
        }

        private void FormNdeCPrestacionLoad(object sender, EventArgs e)
        {
            dsPorcentajeIVA.Merge(new Service().GetPorcentajeIVA(Program.Pin));
            backgroundWorker1.RunWorkerAsync();
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var f = new FormFacturaManual
            {
                Tipo = "NdeC",
                IdReferencia = (int) prestacionesConSaldoUltraGrid.ActiveRow.Cells["idComprobante"].Value,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(1, 1)
            };
            f.Show();
            Close();
        }

        private void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            dsPrestacionesConSaldo.Merge(new Service().GetPrestacionesConSaldo(Program.Pin));
        }

        private void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ultraLabelEspere.Visible = false;
        }

        private void prestacionesConSaldoUltraGrid_AfterRowActivate(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }
    }
}