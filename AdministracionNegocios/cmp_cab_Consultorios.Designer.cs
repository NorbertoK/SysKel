namespace Administración
{
    partial class CmpCabConsultorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.feriadosTableAdapter1 = new Administración.DsFeriadosTableAdapters.FeriadosTableAdapter();
            this.moldesDeTurnosTableAdapter1 = new Administración.DsMoldesDeTurnosTableAdapters.MoldesDeTurnosTableAdapter();
            this.turnosTableAdapter1 = new Administración.DsTurnosTableAdapters.TurnosTableAdapter();
            this.diagnosticosTurnosTableAdapter1 = new Administración.DsTurnosTableAdapters.DiagnosticosTurnosTableAdapter();
            this.motivosTurnosTableAdapter1 = new Administración.DsTurnosTableAdapters.MotivosTurnosTableAdapter();
            this.datosFiliatoriosTableAdapter1 = new Administración.DsAntecedentesConsultorioTableAdapters.DatosFiliatoriosTableAdapter();
            this.atencionesAnterioresConsultorioTableAdapter1 = new Administración.DsAntecedentesConsultorioTableAdapters.AtencionesAnterioresConsultorioTableAdapter();
            this.turnosImprimirTableAdapter1 = new Administración.DsTurnosImprimirTableAdapters.TurnosImprimirTableAdapter();
            // 
            // feriadosTableAdapter1
            // 
            this.feriadosTableAdapter1.ClearBeforeFill = true;
            // 
            // moldesDeTurnosTableAdapter1
            // 
            this.moldesDeTurnosTableAdapter1.ClearBeforeFill = true;
            // 
            // turnosTableAdapter1
            // 
            this.turnosTableAdapter1.ClearBeforeFill = true;
            // 
            // diagnosticosTurnosTableAdapter1
            // 
            this.diagnosticosTurnosTableAdapter1.ClearBeforeFill = true;
            // 
            // motivosTurnosTableAdapter1
            // 
            this.motivosTurnosTableAdapter1.ClearBeforeFill = true;
            // 
            // datosFiliatoriosTableAdapter1
            // 
            this.datosFiliatoriosTableAdapter1.ClearBeforeFill = true;
            // 
            // atencionesAnterioresConsultorioTableAdapter1
            // 
            this.atencionesAnterioresConsultorioTableAdapter1.ClearBeforeFill = true;
            // 
            // turnosImprimirTableAdapter1
            // 
            this.turnosImprimirTableAdapter1.ClearBeforeFill = true;

        }

        #endregion

        private DsFeriadosTableAdapters.FeriadosTableAdapter feriadosTableAdapter1;
        private DsMoldesDeTurnosTableAdapters.MoldesDeTurnosTableAdapter moldesDeTurnosTableAdapter1;
        private DsTurnosTableAdapters.TurnosTableAdapter turnosTableAdapter1;
        private DsTurnosTableAdapters.DiagnosticosTurnosTableAdapter diagnosticosTurnosTableAdapter1;
        private DsTurnosTableAdapters.MotivosTurnosTableAdapter motivosTurnosTableAdapter1;
        private DsAntecedentesConsultorioTableAdapters.DatosFiliatoriosTableAdapter datosFiliatoriosTableAdapter1;
        private DsAntecedentesConsultorioTableAdapters.AtencionesAnterioresConsultorioTableAdapter atencionesAnterioresConsultorioTableAdapter1;
        private DsTurnosImprimirTableAdapters.TurnosImprimirTableAdapter turnosImprimirTableAdapter1;
    }
}
