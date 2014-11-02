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
            // TODO: This line of code loads data into the 'taxiServicesDBDataSet.DriverTbl' table. You can move, or remove it, as needed.
            this.driverTblTableAdapter.Fill(this.taxiServicesDBDataSet.DriverTbl);

        }
    }
}
