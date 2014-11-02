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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            string xmlFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\ReservationPerson.xml";

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(xmlFile, XmlReadMode.InferSchema);

            this.dataGridView1.DataSource = dataSet.Tables[0];

        }
    }
}
