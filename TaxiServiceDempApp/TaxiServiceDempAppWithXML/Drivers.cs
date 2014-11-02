using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiServiceDempAppWithSQLServer
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            string xmlFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Drivers.xml";

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(xmlFile, XmlReadMode.InferSchema);

            this.dataGridView1.DataSource = dataSet.Tables[0];

        }
    }
}
