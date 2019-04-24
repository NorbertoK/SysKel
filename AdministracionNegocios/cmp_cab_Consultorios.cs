using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Administración.Properties;
using System;

namespace Administración
{
    public partial class CmpCabConsultorios : Component
    {
        public CmpCabConsultorios()
        {
            InitializeComponent();
        }

        public DsFeriados GetFeriados()
        {
            var ret = new DsFeriados();
            feriadosTableAdapter1.Fill(ret.Feriados);
            return ret;
        }

        public DsFeriados UpdateFeriados(DsFeriados fer)
        {
            try
            {
                feriadosTableAdapter1.Update(fer.Feriados);
            }
            catch
            {
                return null;
            }
            return fer;
        }

        public DsMoldesDeTurnos GetMoldesDeTurnos()
        {
            var ret = new DsMoldesDeTurnos();
            moldesDeTurnosTableAdapter1.Fill(ret.MoldesDeTurnos);
            return ret;
        }

        public DsMoldesDeTurnos UpdateMoldesDeTurnos(DsMoldesDeTurnos mol)
        {
            try
            {
                moldesDeTurnosTableAdapter1.Update(mol.MoldesDeTurnos);
            }
            catch
            {
                return null;
            }
            return mol;
        }

        public void GenerarTurnos(int mes, int anyo)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.GeneradorDeTurnos", connection) {CommandType = CommandType.StoredProcedure};
                var xMes = command.Parameters.Add("@mes", SqlDbType.Int);
                xMes.Value = mes;
                var xAnyo = command.Parameters.Add("@anyo", SqlDbType.Int);
                xAnyo.Value = anyo;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DsTurnos GetTurnos()
        {
            var ret = new DsTurnos();
            turnosTableAdapter1.Fill(ret.Turnos);
            return ret;
        }

        public DsTurnos UpdateTurnos(DsTurnos tur)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    /* Primero agrego o modifico los padres y después los hijos */
                    turnosTableAdapter1.Update(tur.Turnos.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent));
                    motivosTurnosTableAdapter1.Update(tur.MotivosTurnos.Select("", "",
                                                                               DataViewRowState.Added | DataViewRowState.ModifiedCurrent));
                    diagnosticosTurnosTableAdapter1.Update(tur.DiagnosticosTurnos.Select("", "",
                                                                                         DataViewRowState.Added |
                                                                                         DataViewRowState.ModifiedCurrent));
                    /* Primero elimino a los hijos y después a los padres */
                    diagnosticosTurnosTableAdapter1.Update(tur.DiagnosticosTurnos);
                    motivosTurnosTableAdapter1.Update(tur.MotivosTurnos);
                    turnosTableAdapter1.Update(tur.Turnos);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return tur;
            }
        }

        public DsTurnos GetTurnosFuturos(int idMedico)
        {
            var ret = new DsTurnos();
            turnosTableAdapter1.FillFuturos(ret.Turnos, idMedico);
            return ret;
        }

        public DsTurnos GetTurnosHoy()
        {
            var ret = new DsTurnos();
            turnosTableAdapter1.FillHoy(ret.Turnos);
            return ret;
        }

        public DsTurnos GetTurnosHoyPorMedico(int idMedico)
        {
            var ret = new DsTurnos();
            turnosTableAdapter1.FillHoyPorMedico(ret.Turnos, idMedico);
            motivosTurnosTableAdapter1.FillHoyPorMedico(ret.MotivosTurnos, idMedico);
            diagnosticosTurnosTableAdapter1.FillHoyPorMedico(ret.DiagnosticosTurnos, idMedico);
            return ret;
        }

        public int IntTipoDeDocumentoDesdeIniciales(string iniciales)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT idTipoDeDocumento FROM dbo.TiposDeDocumento WHERE Iniciales = @iniciales", connection);
                var xIniciales = command.Parameters.Add("@iniciales", SqlDbType.VarChar);
                xIniciales.Value = iniciales;
                connection.Open();
                var id = (int) command.ExecuteScalar();
                return id;
            }
        }

        public string SerieDelComprobante(int idComprobante)
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("SELECT Serie FROM dbo.TiposDeComprobante tc JOIN dbo.Comprobantes comp ON tc.idTipoDeComprobante = comp.idTipoDeComprobante WHERE idComprobante = @idComprobante", connection);
                var xIdComprobante = command.Parameters.Add("@idComprobante", SqlDbType.Int);
                xIdComprobante.Value = idComprobante;
                connection.Open();
                var serie = command.ExecuteScalar().ToString();
                return serie;
            }
        }

        public DsAntecedentesConsultorio GetDatosFiliatorios(string numeroDeDocumento, int idAfiliado)
        {
            var ret = new DsAntecedentesConsultorio();
            datosFiliatoriosTableAdapter1.Fill(ret.DatosFiliatorios, numeroDeDocumento, idAfiliado);
            return ret;
        }

        public DsAntecedentesConsultorio GetAtencionesAnterioresConsultorio(int idTurno, string numeroDeDocumento)
        {
            var ret = new DsAntecedentesConsultorio();
            atencionesAnterioresConsultorioTableAdapter1.Fill(ret.AtencionesAnterioresConsultorio, idTurno, numeroDeDocumento);
            return ret;
        }

        public DsTurnosImprimir GetTurnosImprimir(DateTime dia)
        {
            var ret = new DsTurnosImprimir();
            turnosImprimirTableAdapter1.Fill(ret.TurnosImprimir, dia);
            return ret;
        }

        public DsTurnosImprimir GetTurnosPorFrase(string frase)
        {
            var ret = new DsTurnosImprimir();
            turnosImprimirTableAdapter1.FillByFrase(ret.TurnosImprimir, frase);
            return ret;
        }
    }
}