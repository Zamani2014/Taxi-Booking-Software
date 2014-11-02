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
            // TODO: This line of code loads data into the 'taxiServicesDBDataSet.ReservationPersonTbl' table. You can move, or remove it, as needed.
            this.reservationPersonTblTableAdapter.Fill(this.taxiServicesDBDataSet.ReservationPersonTbl);

        }
    }
}
