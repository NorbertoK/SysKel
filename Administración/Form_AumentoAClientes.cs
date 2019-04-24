using System;
using System.Drawing;
using System.Windows.Forms;
using Administración.WS;
using Infragistics.Win.UltraWinGrid;
using Resources = Administración.Properties.Resources;

namespace Administración
{
    public partial class FormAumentoAClientes : Form1
    {
        private bool _aumentarTodos;
        private DateTime _fecha = new Service().HoraActual(Program.Pin);
        private FormPrincipal _fp;
        private string _frase = "";

        public FormAumentoAClientes()
        {
            InitializeComponent();
        }

        private void FormAumentoAClientes_Load(object sender, EventArgs e)
        {
            _fp = (FormPrincipal) MdiParent;
            tiposDeClienteBindingSource.DataSource = _fp.dsTiposDeCliente;
            tiposDeContratoBindingSource.DataSource = _fp.dsTiposDeContrato;
            dsNegocios.Merge(new Service().GetNegocios(Program.Pin));
            tandasDeFacturacionBindingSource.DataSource = _fp.dsTandasDeFacturacion;
            dsLocalidades.Merge(new Service().GetLocalidadesConMarca(Program.Pin));
            dsParametros.Merge(new Service().GetParametros(Program.Pin));
            if ((bool) dsParametros.Parametros.Rows[0]["UsaNegocios"])
                dsNegocios.Merge(new Service().GetNegocios(Program.Pin));
            else
                ultraTabControl1.Tabs[2].Visible = false;
        }

        private bool Verificar()
        {
            _aumentarTodos = false;
            if (ultraCurrencyEditor1.Value == 0)
            {
                MessageBox.Show("Falta el porcentaje de aumento.",
                    "¡Atención!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            if ((bool) dsParametros.Parametros.Rows[0]["UsaNegocios"])
                if ((decimal) ultraGridRubro.Rows.SummaryValues["Marcas"].Value == 0 ||
                    (decimal) ultraGridTiposDeContrato.Rows.SummaryValues["Marcas"].Value == 0 ||
                    (decimal) ultraGridNegocios.Rows.SummaryValues["Marcas"].Value == 0 ||
                    (decimal) ultraGridTanda.Rows.SummaryValues["Marcas"].Value == 0 ||
                    (decimal) ultraGridLocalidad.Rows.SummaryValues["Marcas"].Value == 0)
                {
                    MessageBox.Show("Hay una sección sin ninguna marca.",
                        "Selección inválida", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return false;
                }

            if ((decimal) ultraGridRubro.Rows.SummaryValues["Marcas"].Value == ultraGridRubro.Rows.Count &&
                (decimal) ultraGridTiposDeContrato.Rows.SummaryValues["Marcas"].Value ==
                ultraGridTiposDeContrato.Rows.Count &&
                (decimal) ultraGridNegocios.Rows.SummaryValues["Marcas"].Value == ultraGridNegocios.Rows.Count &&
                (decimal) ultraGridTanda.Rows.SummaryValues["Marcas"].Value == ultraGridTanda.Rows.Count &&
                (decimal) ultraGridLocalidad.Rows.SummaryValues["Marcas"].Value == ultraGridLocalidad.Rows.Count)
            {
                if (MessageBox.Show(
                        "Ha seleccionado absolutamente todos los contratos." +
                        Environment.NewLine + Environment.NewLine +
                        "¿Seguro que quiere aumenta el valor a TODOS?", "¡Atención!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _aumentarTodos = true;
                    return true;
                }

                _aumentarTodos = false;
                return false;
            }

            if ((decimal) ultraGridRubro.Rows.SummaryValues["Marcas"].Value == 0 ||
                (decimal) ultraGridTiposDeContrato.Rows.SummaryValues["Marcas"].Value == 0 ||
                (decimal) ultraGridTanda.Rows.SummaryValues["Marcas"].Value == 0 ||
                (decimal) ultraGridLocalidad.Rows.SummaryValues["Marcas"].Value == 0)
            {
                MessageBox.Show("Hay una sección sin ninguna marca.",
                    "Selección inválida", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

            if ((decimal) ultraGridRubro.Rows.SummaryValues["Marcas"].Value == ultraGridRubro.Rows.Count &&
                (decimal) ultraGridTiposDeContrato.Rows.SummaryValues["Marcas"].Value ==
                ultraGridTiposDeContrato.Rows.Count &&
                (decimal) ultraGridTanda.Rows.SummaryValues["Marcas"].Value == ultraGridTanda.Rows.Count &&
                (decimal) ultraGridLocalidad.Rows.SummaryValues["Marcas"].Value == ultraGridLocalidad.Rows.Count)
            {
                if (MessageBox.Show(
                        "Ha seleccionado absolutamente todos los contratos." +
                        Environment.NewLine + Environment.NewLine +
                        "¿Seguro que quiere aumenta el valor a TODOS?", "¡Atención!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _aumentarTodos = true;
                    return true;
                }

                _aumentarTodos = false;
                return false;
            }

            return true;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            buttonAceptar.Enabled = false;
            if (!Verificar())
            {
                buttonAceptar.Enabled = true;
                return;
            }

            if (!_aumentarTodos)
            {
                if ((decimal) ultraGridRubro.Rows.SummaryValues["Marcas"].Value != ultraGridRubro.Rows.Count)
                {
                    _frase += " AND idTipoDeCliente in (";
                    foreach (var renglon in ultraGridRubro.Rows)
                        if ((bool) renglon.Cells["Marca"].Value)
                            _frase += renglon.Cells["idTipoDeCliente"].Value + ",";
                    _frase = _frase.Remove(_frase.Length - 1) + ")";
                }

                if ((decimal) ultraGridTiposDeContrato.Rows.SummaryValues["Marcas"].Value !=
                    ultraGridTiposDeContrato.Rows.Count)
                {
                    _frase += " AND idTipoDeContrato in (";
                    foreach (var renglon in ultraGridTiposDeContrato.Rows)
                        if ((bool) renglon.Cells["Marca"].Value)
                            _frase += renglon.Cells["idTipoDeContrato"].Value + ",";
                    _frase = _frase.Remove(_frase.Length - 1) + ")";
                }

                if ((decimal) ultraGridNegocios.Rows.SummaryValues["Marcas"].Value != ultraGridNegocios.Rows.Count &&
                    (bool) dsParametros.Parametros.Rows[0]["UsaNegocios"])
                {
                    _frase += " AND idNegocio in (";
                    foreach (var renglon in ultraGridNegocios.Rows)
                        if ((bool) renglon.Cells["Marca"].Value)
                            _frase += renglon.Cells["idNegocio"].Value + ",";
                    _frase = _frase.Remove(_frase.Length - 1) + ")";
                }

                if ((decimal) ultraGridTanda.Rows.SummaryValues["Marcas"].Value != ultraGridTanda.Rows.Count)
                {
                    _frase += " AND idTandaDeFacturacion in (";
                    foreach (var renglon in ultraGridTanda.Rows)
                        if ((bool) renglon.Cells["Marca"].Value)
                            _frase += renglon.Cells["idTandaDeFacturacion"].Value + ",";
                    _frase = _frase.Remove(_frase.Length - 1) + ")";
                }

                if ((decimal) ultraGridLocalidad.Rows.SummaryValues["Marcas"].Value != ultraGridLocalidad.Rows.Count)
                {
                    _frase += " AND idLocalidad in (";
                    foreach (var renglon in ultraGridLocalidad.Rows)
                        if ((bool) renglon.Cells["Marca"].Value)
                            _frase += renglon.Cells["idLocalidad"].Value + ",";
                    _frase = _frase.Remove(_frase.Length - 1) + ")";
                }
            }

            new Service().UpdateTiposDeCliente(dsTiposDeCliente, Program.Pin);
            new Service().UpdateTiposDeContrato(dsTiposDeContrato, Program.Pin);
            new Service().UpdateNegocios(dsNegocios, Program.Pin);
            new Service().UpdateTandasDeFacturacion(dsTandasDeFacturacion, Program.Pin);
            new Service().UpdateLocalidadesConMarca(dsLocalidades, Program.Pin);
            var idAumento = new Service().AumentosAutomaticos(ultraCurrencyEditor1.Value, _frase, Program.Pin);
            var f = new FormRepAumentoAutomatico
            {
                IdAumento = idAumento,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0)
            };
            f.Show();
            var rep = new FormRepHistRenglonesFacturaModelo
            {
                Filtro = "SinActualizar",
                Titulo = "Modificaciones de los Renglones de Factura sin actualizar desde el "
                         + _fecha.ToString("dd/MM/yyyy") + ". No se incluyen los planes",
                Cliente = "",
                Desde = _fecha,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(10, 10)
            };
            rep.Show();
            var repo = new FormRepHistPlanes
            {
                Titulo = "Modificaciones de los Planes desde el " + _fecha.ToString("dd/MM/yyyy"),
                Desde = _fecha,
                MdiParent = MdiParent,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(20, 20)
            };
            repo.Show();
            Close();
        }

        private void ultraCurrencyEditor1_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(SelectAllTextInNumericEditor));
        }

        private void SelectAllTextInNumericEditor()
        {
            ultraCurrencyEditor1.SelectAll();
        }

        #region Marcas

        private void ultraGridRubro_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (!e.ReInitialize)
                e.Row.Cells["Marca"].Value = true;
        }

        private void ultraGridTiposDeContrato_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (!e.ReInitialize)
                e.Row.Cells["Marca"].Value = true;
        }

        private void ultraGridNegocios_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (!e.ReInitialize)
                e.Row.Cells["Marca"].Value = true;
        }

        private void ultraGridTada_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (!e.ReInitialize)
                e.Row.Cells["Marca"].Value = true;
        }

        private void ultraGridLocalidad_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (!e.ReInitialize)
                e.Row.Cells["Marca"].Value = true;
        }

        #endregion
    }
}