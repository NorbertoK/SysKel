using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Administración.Properties;

namespace Administración
{
    public partial class CmpDeudores : Component
    {
        public CmpDeudores()
        {
            InitializeComponent();
        }

        public CmpDeudores(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void ProcesarDeudores()
        {
            using (var connection = new SqlConnection(Settings.Default.DatosConnectionString))
            {
                var command = new SqlCommand("dbo.Deudores", connection)
                                  {
                                      CommandType = CommandType.StoredProcedure,
                                      CommandTimeout = 3600000
                                  };
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public DsDeudores GetDeudores(string hasta)
        {
            var ret = new DsDeudores();
            deudoresTableAdapter1.SetTimeOut();
            deudoresTableAdapter1.Fill(ret.Deudores,hasta);
            return ret;
        }
    }
}
