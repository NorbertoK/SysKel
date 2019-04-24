using System;
using System.Drawing;
using System.Windows.Forms;
using Cabina.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Cabina.Properties.Resources;

namespace Cabina
{
    public partial class FormBuscarPrestaciones : Form
    {
        private FormPrincipalCabina _fp;

        public FormBuscarPrestaciones()
        {
            InitializeComponent();
        }

        private void FormBuscarPrestacionesLoad(object sender, EventArgs e)
        {
            if (Tag.ToString() == "M")
                Text = "Buscar Prestaciones para Modificarlas";
            if (Tag.ToString() == "L")
                Text = "Listar Prestaciones";
            if (Tag.ToString() == "C")
                Text = "Contar Pacientes";
            ultraCalendarCombo1.Value = new Service().HoraActual(Program.Pin);
            ultraCalendarCombo2.Value = new Service().HoraActual(Program.Pin);
            ultraComboCanceladas.Value = 0;
            ultraComboTiempoDeLlegada.Value = 0;
            ultraComboInternacion.Value = 0;
            /*Tomo datos del padre*/
            _fp = (FormPrincipalCabina) MdiParent;
            tiposDeClienteBindingSource.DataSource = _fp.dsTiposDeCliente;
            localidadesBindingSource.DataSource = _fp.dsLocalidades1;
            codigosBindingSource.DataSource = _fp.dsCodigos;
            clientesListaBindingSource.DataSource = _fp.dsClientesLista;
            contratosBindingSource.DataSource = _fp.dsContratosLista;
            callesBindingSource.DataSource = _fp.dsCallesLista;
            coberturasBindingSource.DataSource = _fp.dsCoberturas;
            tiposDeDestinoBindingSource.DataSource = _fp.dsTiposDeDestino;

            dsRecursos.Merge(new Service().GetMovilesLista(Program.Pin));
            dsRecursos.Merge(new Service().GetMedicosLista(Program.Pin));
            dsRecursos.Merge(new Service().GetParamedicosLista(Program.Pin));
            dsRecursos.Merge(new Service().GetChoferesLista(Program.Pin));
            dsMotivosDeLlamado.Merge(new Service().GetMotivosDeLlamado(Program.Pin));
            dsDiagnosticos.Merge(new Service().GetDiagnosticos(Program.Pin));
            dsMedicamentos.Merge(new Service().GetMedicamentos(Program.Pin));
            dsLugares.Merge(new Service().GetLugares(Program.Pin));
            dsEntidadesDeCobranza.Merge(new Service().GetEntidadesDeCobranza(Program.Pin));
            dsUsuarios.Merge(new Service().GetUsuarios(Program.Pin));
        }

        private void UltraComboRubroRowSelected(object sender, RowSelectedEventArgs e)
        {
            ultraComboClientes.Value = DBNull.Value;
            if (e.Row == null)
            {
                dsClientesLista.Clear();
                dsClientesLista.Merge(new Service().GetClientesLista(Program.Pin));
            }
            else
            {
                dsClientesLista.Clear();
                dsClientesLista.Merge(new Service().GetClientesListaPorTipo(
                    (int) e.Row.Cells["idTipoDeCliente"].Value, Program.Pin));
            }
        }

        private void UltraComboLocalidadesRowSelected(object sender, RowSelectedEventArgs e)
        {
            ultraComboCalles.Value = DBNull.Value;
            if (e.Row == null)
            {
                dsCallesLista.Clear();
                dsCallesLista.Merge(new Service().GetCallesLista(Program.Pin));
            }
            else
            {
                dsCallesLista.Clear();
                dsCallesLista.Merge(new Service().GetCallesListaPorLocalidad((int) e.Row.Cells["idLocalidad"].Value,
                    Program.Pin));
            }
        }

        private void ButtonBuscarPacienteClick(object sender, EventArgs e)
        {
            buttonBuscarPaciente.Enabled = false;
            var frase = "(";
            var seps = new[] {' '};
            foreach (var parte in textBoxBuscarPaciente.Text.Split(seps))
                frase += "Nombre LIKE '%" + parte.Replace("'", "''") + "%') AND (";
            frase = frase.Remove(frase.Length - 7) + ");";
            dsBuscarPacientes.Clear();
            dsBuscarPacientes.Merge(new Service().GetPacientesPorNombre(frase, Program.Pin));
            ultraComboPacientes.Enabled = true;
        }

        private void TextBoxBuscarPacienteKeyUp(object sender, KeyEventArgs e)
        {
            ultraComboPacientes.Enabled = false;
            if (textBoxBuscarPaciente.Text.Length > 2)
            {
                buttonBuscarPaciente.Enabled = true;
            }
            else
            {
                buttonBuscarPaciente.Enabled = false;
                dsBuscarPacientes.Clear();
            }
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void UltraComboInternacionRowSelected(object sender, RowSelectedEventArgs e)
        {
            if ((int) e.Row.Cells["Valor"].Value == 2)
            {
                ultraComboLugares.Value = DBNull.Value;
                ultraComboLugares.Enabled = false;
            }
            else
            {
                ultraComboLugares.Enabled = true;
            }
        }

        private void ButtonAceptarClick(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            var desde = (DateTime) ultraCalendarCombo1.Value;
            var hasta = (DateTime) ultraCalendarCombo2.Value;
            var desdeHora = ultraDateTimeEditorDesdeHora.Text;
            var hastaHora = ultraDateTimeEditorHastaHora.Text;
            var nroPrestacion = textBoxPrestacionNro.Text ?? "";
            var idCobertura = (int?) ultraComboCoberturas.Value ?? 0;
            var idTipoDeDestino = (int?) ultraComboTiposDeDestino.Value ?? 0;
            var idCliente = (int?) ultraComboClientes.Value ?? 0;
            var idContrato = (int?) ultraComboContratos.Value ?? 0;
            var idRubro = (int?) ultraComboRubro.Value ?? 0;
            var idCodigo = (int?) ultraComboCodigos.Value ?? 0;
            var idEntidadDeCobranza = (int?) ultraComboEntidadDeCobranza.Value ?? 0;
            var paciente = ultraComboPacientes.Value == null ? "" : ultraComboPacientes.Text;
            var hC = textBoxHC.Text ?? "";
            var idLocalidad = (int?) ultraComboLocalidades.Value ?? 0;
            var idCalle = (int?) ultraComboCalles.Value ?? 0;
            var telefono = textBoxTelefono.Text ?? "";
            var idMovil = (int?) ultraComboMoviles.Value ?? 0;
            var tiempoDeLlegada = (int) ultraComboTiempoDeLlegada.Value;
            var idMedico = (int?) ultraComboMedicos.Value ?? 0;
            var idParamedico = (int?) ultraComboParamedicos.Value ?? 0;
            var idChofer = (int?) ultraComboChoferes.Value ?? 0;
            var idMotivo = (int?) ultraComboMotivo.Value ?? 0;
            var idDiagnostico = (int?) ultraComboDiagnostico.Value ?? 0;
            var idMedicamento = (int?) ultraComboMedicamentos.Value ?? 0;
            var internacion = (int) ultraComboInternacion.Value;
            var idLugar = (int?) ultraComboLugares.Value ?? 0;
            var idTomador = (int?) ultraComboTomadores.Value ?? 0;
            var idDespachador = (int?) ultraComboDespachador.Value ?? 0;
            var verCanceladas = (int?) ultraComboCanceladas.Value ?? 0;
            var cuentaPacientes = Tag.ToString() == "C" ? 1 : 0;
            var proceso = new Service().GetProcesoPrestaciones(desde.ToString("yyyyMMdd"),
                hasta.ToString("yyyyMMdd"),
                desdeHora, hastaHora,
                nroPrestacion, idCobertura, idTipoDeDestino,
                idCliente, idContrato, idRubro, idCodigo,
                idEntidadDeCobranza, paciente, hC,
                idLocalidad, idCalle, telefono,
                idMovil, tiempoDeLlegada, idMedico,
                idParamedico, idChofer, idMotivo,
                idDiagnostico, idMedicamento,
                internacion, idLugar, idTomador,
                idDespachador, verCanceladas, cuentaPacientes, Program.Pin);
            if ("VM".Contains(Tag.ToString()))
            {
                var f = new FormDespacho {Proceso = proceso};
                if (Tag.ToString() == "V") // Ver
                    f.Tag = "V";
                if (Tag.ToString() == "M") // Modificar
                    f.Tag = "C";
                f.MdiParent = MdiParent;
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(0, 0);
                f.Show();
            }

            if (Tag.ToString() == "L") //Listar
            {
                var form = new FormRepImprimirPrestacion
                {
                    Proceso = proceso,
                    MdiParent = MdiParent,
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0)
                };
                form.Show();
            }

            if (Tag.ToString() != "C") return; // Contar
            var tDesde = ultraCalendarCombo1.Text;
            var tHasta = ultraCalendarCombo2.Text;
            var tDesdeHora = ultraDateTimeEditorDesdeHora.Text;
            var tHastaHora = ultraDateTimeEditorHastaHora.Text;
            var tNroPrestacion = textBoxPrestacionNro.Text ?? "";
            var tCobertura = ultraComboCoberturas.Text;
            var tTipoDeDestino = ultraComboCoberturas.Text;
            var tCliente = ultraComboClientes.Text;
            var tContrato = ultraComboContratos.Text;
            var tRubro = ultraComboRubro.Text;
            var tCodigo = ultraComboCodigos.Text;
            var tEntidadDeCobranza = ultraComboEntidadDeCobranza.Text;
            var tPaciente = ultraComboPacientes.Text;
            var tHC = textBoxHC.Text;
            var tLocalidad = ultraComboLocalidades.Text;
            var tCalle = ultraComboCalles.Text;
            var tTelefono = textBoxTelefono.Text;
            var tMovil = ultraComboMoviles.Text;
            var tTiempoDeLlegada = ultraComboTiempoDeLlegada.Text;
            var tMedico = ultraComboMedicos.Text;
            var tParamedico = ultraComboParamedicos.Text;
            var tChofer = ultraComboChoferes.Text;
            var tMotivo = ultraComboMotivo.Text;
            var tDiagnostico = ultraComboDiagnostico.Text;
            var tMedicamento = ultraComboMedicamentos.Text;
            var tInternacion = ultraComboInternacion.Text;
            var tLugar = ultraComboLugares.Text;
            var tTomador = ultraComboTomadores.Text;
            var tDespachador = ultraComboDespachador.Text;
            var tCanceladas = ultraComboCanceladas.Text;
            var formc = new FormRepContarPrestaciones
            {
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
                Desde = tDesde,
                Hasta = tHasta,
                DesdeHora = tDesdeHora,
                HastaHora = tHastaHora,
                NroPrestacion = tNroPrestacion,
                Cobertura = tCobertura,
                TipoDeDestino = tTipoDeDestino,
                Cliente = tCliente,
                Contrato = tContrato,
                Rubro = tRubro,
                Codigo = tCodigo,
                EntidadDeCobranza = tEntidadDeCobranza,
                Paciente = tPaciente,
                HC = tHC,
                Localidad = tLocalidad,
                Calle = tCalle,
                Telefono = tTelefono,
                Movil = tMovil,
                TiempoDeLlegada = tTiempoDeLlegada,
                Medico = tMedico,
                Paramedico = tParamedico,
                Chofer = tChofer,
                Motivo = tMotivo,
                Diagnostico = tDiagnostico,
                Medicamento = tMedicamento,
                Internacion = tInternacion,
                Lugar = tLugar,
                Tomador = tTomador,
                Despachador = tDespachador,
                Cantidad =
                    new Service().ContarPrestaciones(proceso, Program.Pin),
                Canceladas = tCanceladas
            };
            new Service().EliminarProceso(proceso, Program.Pin);
            formc.Show();
        }

        private void FormBuscarPrestacionesActivated(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = true;
        }

        private void ButtonBuscarContratoClick(object sender, EventArgs e)
        {
            var frmBuscarContrato = new FormBuscarContratoDesdeDespacho();
            frmBuscarContrato.ShowDialog(this);
            if (frmBuscarContrato.Boton == "Contrato") ultraComboContratos.Value = frmBuscarContrato.IdContrato;
            frmBuscarContrato.Close();
        }
    }
}