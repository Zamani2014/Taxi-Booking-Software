using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace TaxiServiceDempAppWithSQLServer
{
    public partial class Automobiles : Form
    {
        public Automobiles()
        {
            InitializeComponent();
        }

        private void Automobiles_Load(object sender, EventArgs e)
        {
            string xmlFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Automobiles.xml";

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(xmlFile, XmlReadMode.InferSchema);

            this.dataGridView1.DataSource = dataSet.Tables[0];

        }
    }
}
