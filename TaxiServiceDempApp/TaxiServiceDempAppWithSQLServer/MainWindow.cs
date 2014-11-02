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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReservationPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservations ReservationsFrm = new Reservations();
            ReservationsFrm.MdiParent = this;
            ReservationsFrm.Show();
        }

        private void TripsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trips TripsFrm = new Trips();
            TripsFrm.MdiParent = this;
            TripsFrm.Show();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers CustomersFrm = new Customers();
            CustomersFrm.MdiParent = this;
            CustomersFrm.Show();
        }

        private void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automobiles AutomobilesFrm = new Automobiles();
            AutomobilesFrm.MdiParent = this;
            AutomobilesFrm.Show();
        }

        private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drivers DriversFrm = new Drivers();
            DriversFrm.MdiParent = this;
            DriversFrm.Show();
        }

        private void RegisterOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripOrderForm TripOrderFormObj = new TripOrderForm();
            TripOrderFormObj.MdiParent = this;
            TripOrderFormObj.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TripSearch TripSearchFrm = new TripSearch();
            TripSearchFrm.MdiParent = this;
            TripSearchFrm.Show();
        }
    }
}
