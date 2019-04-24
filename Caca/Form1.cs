using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caca.AFIP;

namespace Caca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ws = new AFIP.ServiceSoapClient();
            //ws.FECAEASolicitar(new FEAuthRequest() {ExtensionData = new ExtensionDataObject() } , )
        }
    }
}
