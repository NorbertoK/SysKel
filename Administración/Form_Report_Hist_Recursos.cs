using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;

namespace Administración
{
    public partial class FormReportHistRecursos : Form1
    {
        public FormReportHistRecursos()
        {
            InitializeComponent();
        }

        private void FormReportHistRecursosLoad(object sender, EventArgs e)
        {
            ultraCalendarComboDesde.Value = new Service().Hoy(Program.Pin);
            ultraCalendarComboHasta.Value = new Service().Hoy(Program.Pin);
            dsRecursos.Merge(new Service().GetMovilesLista(Program.Pin));
            dsRecursos.Merge(new Service().GetMedicosLista(Program.Pin));
            dsRecursos.Merge(new Service().GetParamedicosLista(Program.Pin));
            dsRecursos.Merge(new Service().GetChoferesLista(Program.Pin));
            dsRecursos.Merge(new Service().GetRecursosLista(Program.Pin));
        }

        private void UltraCombo1ValueChanged(object sender, EventArgs e)
        {
            ultraLabelChofer.Visible = ultraComboFiltro.Value.ToString() == "Chofer";
            choferesUltraCombo.Visible = ultraComboFiltro.Value.ToString() == "Chofer";
            ultraLabelMedico.Visible = ultraComboFiltro.Value.ToString() == "Medico";
            medicosUltraCombo.Visible = ultraComboFiltro.Value.ToString() == "Medico";
            ultraLabelMovil.Visible = ultraComboFiltro.Value.ToString() == "Movil";
            movilesUltraCombo.Visible = ultraComboFiltro.Value.ToString() == "Movil";
            ultraLabelParamedico.Visible = ultraComboFiltro.Value.ToString() == "Paramedico";
            paramedicosUltraCombo.Visible = ultraComboFiltro.Value.ToString() == "Paramedico";
            ultraLabelRecurso.Visible = ultraComboFiltro.Value.ToString() == "Recurso";
            recursosUltraCombo.Visible = ultraComboFiltro.Value.ToString() == "Recurso";
            buttonAceptar.Enabled = ultraComboFiltro.Value.ToString() == "Fecha";
        }

        private void ChoferesUltraComboValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = choferesUltraCombo.Value != DBNull.Value;
        }

        private void MedicosUltraComboValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = medicosUltraCombo.Value != DBNull.Value;
        }

        private void MovilesUltraComboValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = movilesUltraCombo.Value != DBNull.Value;
        }

        private void ParamedicosUltraComboValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = paramedicosUltraCombo.Value != DBNull.Value;
        }

        private void RecursosUltraComboValueChanged(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = recursosUltraCombo.Value != DBNull.Value;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            var titulo = "Modificaciones de los Recursos del " + ultraCalendarComboDesde.Text + " al " + ultraCalendarComboHasta.Text;
            switch (ultraComboFiltro.Value.ToString())
            {
                case "Fecha":
                    break;
                case "Chofer":
                    titulo = titulo + " - Chofer: " + choferesUltraCombo.SelectedRow.Cells["NombApel"].Value;
                    break;
                case "Medico":
                    titulo = titulo + " - Médico: " + medicosUltraCombo.SelectedRow.Cells["NombApel"].Value;
                    break;
                case "Movil":
                    titulo = titulo + " - Móvil: " + movilesUltraCombo.Text;
                    break;
                case "Paramedico":
                    titulo = titulo + " - Enfermero: " + paramedicosUltraCombo.SelectedRow.Cells["NombApel"].Value;
                    break;
                case "Recurso":
                    titulo = titulo + " - Recurso: " + recursosUltraCombo.Text;
                    break;
            }
            buttonAceptar.Enabled = false;
            buttonCancelar.Enabled = false;
            var rep = new FormRepHistRecursos
                          {
                              Titulo = titulo,
                              Filtro = ultraComboFiltro.Value.ToString(),
                              Chofer =
                                  choferesUltraCombo.Value == null
                                      ? ""
                                      : choferesUltraCombo.SelectedRow.Cells["NombApel"].Value.ToString(),
                              Medico =
                                  medicosUltraCombo.Value == null
                                      ? ""
                                      : medicosUltraCombo.SelectedRow.Cells["NombApel"].Value.ToString(),
                              Movil = movilesUltraCombo.Text,
                              Paramedico =
                                  paramedicosUltraCombo.Value == null
                                      ? ""
                                      : paramedicosUltraCombo.SelectedRow.Cells["NombApel"].Value.ToString(),
                              Recurso = recursosUltraCombo.Text,
                              Desde = (DateTime) ultraCalendarComboDesde.Value,
                              Hasta = (DateTime) ultraCalendarComboHasta.Value,
                              MdiParent = MdiParent,
                              StartPosition = FormStartPosition.Manual,
                              Location = new Point(0, 0)
                          };
            rep.Show();
            Close();
        }
    }
}