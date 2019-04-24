using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Administración
{
    public partial class FormPadronAse : Form
    {
        private readonly DataSet _ds = new DataSet();

        public FormPadronAse()
        {
            InitializeComponent();
        }

        private void FormPadronAseLoad(object sender, EventArgs e)
        {
            const string sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                                             "Data Source=C:\\Padrones\\ASE.xls;" +
                                             "Extended Properties=Excel 8.0;";
            const string sqlExcel = "Select * From [Padrón para CEC$]";
            var oledbConn = new OleDbConnection(sConnectionString);
            oledbConn.Open();
            var oledbCmd = new OleDbCommand(sqlExcel, oledbConn);
            var da = new OleDbDataAdapter(oledbCmd);
            da.Fill(_ds);
            ultraGrid1.DataSource = _ds;
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonActualizarClick(object sender, EventArgs e)
        {
            //int titular = 0;
            foreach (DataRow renglon in _ds.Tables[0].Rows)
            {
                if (renglon["Categ#"].ToString() == "")
                {
                    break;
                }
                if (renglon["Categ#"].ToString() == "TITULAR")
                {
                }
            }
        }
    }
}