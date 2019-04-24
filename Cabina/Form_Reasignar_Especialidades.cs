using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cabina.Properties;
using Cabina.WS;

namespace Cabina
{
    public partial class FormReasignarEspecialidades : Cabina.Form1
    {
        public FormReasignarEspecialidades()
        {
            InitializeComponent();
        }

        private void FormReasignarEspecialidadesLoad(object sender, EventArgs e)
        {
            dsDiagnosticos.Merge(new Service().GetDiagnosticos(Program.Pin));
        }
        private bool Grabar()
        {
            Validate();
            diagnosticosBindingSource.EndEdit();
            var aux = new Service().UpdateDiagnosticos(dsDiagnosticos, Program.Pin);
            if (aux == null)
            {
                MessageBox.Show(
                    "La operación fue rechazada por la Base de Datos." + Environment.NewLine + Environment.NewLine +
                    "Probablemente esté intentando eliminar un dato" + Environment.NewLine +
                    "necesario para la integridad de la información", "Operación Rechazada", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsDiagnosticos.Clear();
                dsDiagnosticos.Merge(new Service().GetDiagnosticos(Program.Pin));
                buttonAceptar.Enabled = false;
                buttonAplicar.Enabled = false;
                return false;
            }
            dsDiagnosticos.Merge(aux);
            ManejoDatos.AplicarUpdate(dsDiagnosticos);
            return true;
        }

        private void ButtonAplicarClick(object sender, EventArgs e)
        {
            Grabar();
            buttonAplicar.Enabled = false;
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            if (buttonAplicar.Enabled)
            {
                if (Grabar())
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void DiagnosticosCategoriaUltraGridAfterEnterEditMode(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
            ManejoDatos.SeleccionInicio(sender);
        }

        private void DiagnosticosCategoriaUltraGridAfterRowsDeleted(object sender, EventArgs e)
        {
            buttonAplicar.Enabled = true;
            buttonAceptar.Enabled = true;
        }
    }
}
