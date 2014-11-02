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
            // TODO: This line of code loads data into the 'taxiServicesDBDataSet.TripTbl' table. You can move, or remove it, as needed.
            this.tripTblTableAdapter.Fill(this.taxiServicesDBDataSet.TripTbl);

        }
    }
}
