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
using System.Xml;

namespace TaxiServiceDempAppWithSQLServer
{
    public partial class TripSearch : Form
    {
        string xmlCustomersFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Customers.xml";
        string xmlDriversFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Drivers.xml";
        string xmlReservationPersonFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\ReservationPerson.xml";
        string xmlTripFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Trip.xml";
        string xmlTripsFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Trips.xml";
        string xmlAutomobilesFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Automobiles.xml";
        string FilePath = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\";
        public TripSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text ==  string.Empty && this.textBox2.Text == string.Empty && this.textBox3.Text == string.Empty)
            {
                MessageBox.Show("لطفا حداقل یکی از فیلدهای جستجو را پر کنید.");
            }
            else
            {
                DataSet mainds = new DataSet();

                DataSet dsCustomers = new DataSet();
                DataSet dsDrivers = new DataSet();
                DataSet dsReservationPerson = new DataSet();
                DataSet dsTrip = new DataSet();
                DataSet dsTrips = new DataSet();
                DataSet dsAutomobiles = new DataSet();

                dsCustomers.ReadXml(xmlCustomersFile);
                dsDrivers.ReadXml(xmlDriversFile);
                dsReservationPerson.ReadXml(xmlReservationPersonFile);
                dsTrip.ReadXml(xmlTripFile);
                dsTrips.ReadXml(xmlTripsFile);
                dsAutomobiles.ReadXml(xmlAutomobilesFile);

                mainds.Merge(dsCustomers);
                mainds.Merge(dsDrivers);
                mainds.Merge(dsReservationPerson);
                mainds.Merge(dsTrip);
                mainds.Merge(dsTrips);
                mainds.Merge(dsAutomobiles);

                DataSet GridDS = new DataSet();
                DataTable GridDT = new DataTable();
                GridDT.Columns.Add("FirstName");
                GridDT.Columns.Add("LastName");
                GridDT.Columns.Add("Origin");
                GridDT.Columns.Add("Destination");
                GridDT.Columns.Add("Cost");
                GridDT.Columns.Add("DriverLastName");
                GridDT.Columns.Add("CarName");

                string TripID = "";
                string FirstName = "";
                string LastName = "";
                string DriverID = "";
                string Origin = "";
                string Destination = "";
                string Cost = "";
                string DriverLastName = "";
                string CarName = "";
                string CustomerID = this.textBox1.Text.ToString();

                if (this.textBox1.Text != string.Empty)
                {
                    var query = from p in mainds.Tables[4].AsEnumerable()
                                join i in mainds.Tables[0].AsEnumerable() on p.Field<string>("CustomerID") equals i.Field<string>("ID")
                                where p.Field<string>("CustomerID") == CustomerID
                                select new
                                {
                                    CustomerID = i.Field<string>("ID"),
                                    TripID = p.Field<string>("TripID"),
                                    FirstName = i.Field<string>("FirstName"),
                                    LastName = i.Field<string>("LastName"),
                                    DriverID = p.Field<string>("DriverID"),
                                };
                    foreach (var q in query)
                    {
                        TripID = q.TripID;
                        FirstName = q.FirstName;
                        LastName = q.LastName;
                        DriverID = q.DriverID;
                    }

                    var query2 = from p in mainds.Tables[4].AsEnumerable()
                                 join i in mainds.Tables[3].AsEnumerable() on p.Field<string>("TripID") equals i.Field<string>("ID")
                                 where p.Field<string>("TripID") == TripID
                                 select new
                                 {
                                     Origin = i.Field<string>("Origin"),
                                     Destination = i.Field<string>("Destination"),
                                     Cost = i.Field<string>("Cost")
                                 };
                    foreach (var q in query2)
                    {
                        Origin = q.Origin;
                        Destination = q.Destination;
                        Cost = q.Cost;
                    }

                    var query3 = from p in mainds.Tables[1].AsEnumerable()
                                 join i in mainds.Tables[5].AsEnumerable() on p.Field<string>("ID") equals i.Field<string>("DriverID")
                                 where p.Field<string>("ID") == DriverID
                                 select new
                                 {
                                     DriverLastName = p.Field<string>("LastName"),
                                     CarName = i.Field<string>("Name")
                                 };
                    foreach (var q in query3)
                    {
                        DriverLastName = q.DriverLastName;
                        CarName = q.CarName;
                    }
                }
                else
                {
                    if (this.textBox2.Text != string.Empty && this.textBox3.Text != string.Empty)
                    {
                        // به دلیل کمبود زمان کافی فرصت نشد :(
                        // فرآیند دقیقا مشابه شرط بالاست !
                    }
                    else
                    {
                        MessageBox.Show("اطلاعات ناقص وارد شده است.");
                    }
                }
                GridDT.Rows.Add(FirstName, LastName, Origin, Destination, Cost, DriverLastName, CarName);
                GridDS.Tables.Add(GridDT);
                this.dataGridView1.DataSource = GridDS.Tables[0];

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = this.radioButton1.Checked;
            this.textBox2.Enabled = this.textBox3.Enabled = !(this.radioButton1.Checked);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Enabled = this.textBox3.Enabled = this.radioButton2.Checked;
            this.textBox1.Enabled = !(this.radioButton2.Checked);
        }

        private void TripSearch_Load(object sender, EventArgs e)
        {
            this.radioButton1.Checked = true;
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = this.textBox3.Enabled = !(this.radioButton1.Checked);
            this.textBox1.Focus();

            //DataSet ds = new DataSet();
            //ds.ReadXml(xmlCustomersFile);

            //this.dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
