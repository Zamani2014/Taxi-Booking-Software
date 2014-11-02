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
    public partial class Trips : Form
    {
        public Trips()
        {
            InitializeComponent();
        }

        private void Trips_Load(object sender, EventArgs e)
        {
            string xmlFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Trip.xml";

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(xmlFile, XmlReadMode.InferSchema);

            this.dataGridView1.DataSource = dataSet.Tables[0];

        }
    }
}
