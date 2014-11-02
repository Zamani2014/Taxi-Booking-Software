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
using System.Xml.Linq;
using TaxiServiceDempAppWithXML;

namespace TaxiServiceDempAppWithSQLServer
{
    public partial class TripOrderForm : Form
    {
        string xmlCustomersFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Customers.xml";
        string xmlDriversFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Drivers.xml";
        string xmlReservationPersonFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\ReservationPerson.xml";
        string xmlTripFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Trip.xml";
        string xmlTripsFile = "C:\\Users\\Alireza\\Desktop\\TaxiServiceDempApp\\TaxiServiceDempApp\\TaxiServiceDempAppWithXML\\DataFiles\\Trips.xml";

        public TripOrderForm()
        {
            InitializeComponent();
        }

        private void TripOrderForm_Load(object sender, EventArgs e)
        {
            #region ComboBox1
            XmlDocument xmlCustomersDoc = new XmlDocument();
            xmlCustomersDoc.Load(xmlCustomersFile);
            var itemNodes = xmlCustomersDoc.SelectNodes("Customers");

            int i = 0;
            int arrayLength = 0;
            foreach (XmlNode node in itemNodes)
            {
                var Customer = node.SelectNodes("Customer");
                foreach (XmlNode Cus in Customer)
                {
                    arrayLength++;
                }
            }

            string[] ID = new string[arrayLength];
            string[] FirstName = new string[arrayLength];
            string[] LastName = new string[arrayLength];

            foreach (XmlNode node in itemNodes)
            {
                var Customer = node.SelectNodes("Customer");
                foreach (XmlNode Cus in Customer)
                {
                    ID[i] = Cus.SelectSingleNode("ID").InnerText;
                    FirstName[i] = Cus.SelectSingleNode("FirstName").InnerText;
                    LastName[i] = Cus.SelectSingleNode("LastName").InnerText;
                    i++;
                }
            }

            for (int j = 0; j < arrayLength; j++)
            {
                UserComboBoxData item = new UserComboBoxData(FirstName[j] + " " + LastName[j], int.Parse(ID[j]));
                this.comboBox1.Items.Add(item);
            }
            this.comboBox1.SelectedIndex = 0;
            #endregion
            #region ComboBox2
            XmlDocument xmlDriversDoc = new XmlDocument();
            xmlDriversDoc.Load(xmlDriversFile);
            var itemNodes2 = xmlDriversDoc.SelectNodes("Drivers");

            int i2 = 0;
            int arrayLength2 = 0;
            foreach (XmlNode node in itemNodes2)
            {
                var Customer = node.SelectNodes("Driver");
                foreach (XmlNode Cus in Customer)
                {
                    arrayLength2++;
                }
            }

            string[] ID2 = new string[arrayLength2];
            string[] FirstName2 = new string[arrayLength2];
            string[] LastName2 = new string[arrayLength2];

            foreach (XmlNode node in itemNodes2)
            {
                var Driver = node.SelectNodes("Driver");
                foreach (XmlNode Cus in Driver)
                {
                    ID2[i2] = Cus.SelectSingleNode("ID").InnerText;
                    FirstName2[i2] = Cus.SelectSingleNode("FirstName").InnerText;
                    LastName2[i2] = Cus.SelectSingleNode("LastName").InnerText;
                    i2++;
                }
            }

            for (int j = 0; j < arrayLength2; j++)
            {
                UserComboBoxData item = new UserComboBoxData(FirstName2[j] + " " + LastName2[j], int.Parse(ID2[j]));
                this.comboBox2.Items.Add(item);
            }
            this.comboBox2.SelectedIndex = 0;
            #endregion
            #region ComboBox3
            XmlDocument xmlReservationPersonDoc = new XmlDocument();
            xmlReservationPersonDoc.Load(xmlReservationPersonFile);
            var itemNodes3 = xmlReservationPersonDoc.SelectNodes("ReservationPersons");

            int i3 = 0;
            int arrayLength3 = 0;
            foreach (XmlNode node in itemNodes3)
            {
                var ReservationPerson = node.SelectNodes("ReservationPerson");
                foreach (XmlNode Cus in ReservationPerson)
                {
                    arrayLength3++;
                }
            }

            string[] ID3 = new string[arrayLength3];
            string[] FirstName3 = new string[arrayLength3];
            string[] LastName3 = new string[arrayLength3];

            foreach (XmlNode node in itemNodes3)
            {
                var ReservationPerson = node.SelectNodes("ReservationPerson");
                foreach (XmlNode Cus in ReservationPerson)
                {
                    ID3[i3] = Cus.SelectSingleNode("ID").InnerText;
                    FirstName3[i3] = Cus.SelectSingleNode("FirstName").InnerText;
                    LastName3[i3] = Cus.SelectSingleNode("LastName").InnerText;
                    i3++;
                }
            }

            for (int j = 0; j < arrayLength3; j++)
            {
                UserComboBoxData item = new UserComboBoxData(FirstName3[j] + " " + LastName3[j], int.Parse(ID3[j]));
                this.comboBox3.Items.Add(item);
            }
            this.comboBox3.SelectedIndex = 0;
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = Guid.NewGuid().ToString();
                string Origin = this.textBox1.Text.ToString();
                string Destination = this.textBox2.Text.ToString();
                string RegisterDateTime = GetDateTime.GenerateDateTime();
                string Cost = this.textBox3.Text.ToString();
                string Description = this.richTextBox1.Text.ToString();

                var TripXDoc = XDocument.Load(xmlTripFile);
                var newElement = new XElement("Trip", 
                    new XElement("ID", ID),
                    new XElement("Origin", Origin),
                    new XElement("Destination", Destination),
                    new XElement("RegisterDateTime", RegisterDateTime),
                    new XElement("Cost", Cost),
                    new XElement("Description", Description)
                );

                TripXDoc.Element("Trips").Add(newElement);
                TripXDoc.Save(xmlTripFile);

                if (InsertTripsToDB(ID))
                {
                    MessageBox.Show("اطلاعات با موفقیت در سیستم ثبت شد!");
                    this.textBox1.Clear();
                    this.textBox2.Clear();
                    this.textBox3.Clear();
                    this.richTextBox1.Clear();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("متاسفانه خطایی در روند ثبت اطلاعات رخ داده است !");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private bool InsertTripsToDB(string InputTripID)
        {
            try
            {
                string ID = Guid.NewGuid().ToString();
                string TripID = InputTripID;
                string ReservationPersonID = (this.comboBox3.SelectedItem as UserComboBoxData).Value.ToString();
                string CustomerID = (this.comboBox1.SelectedItem as UserComboBoxData).Value.ToString();
                string DriverID = (this.comboBox2.SelectedItem as UserComboBoxData).Value.ToString();
                string RegisterDateTime = GetDateTime.GenerateDateTime();
                string Description = this.richTextBox1.Text.ToString();

                var TripsXDoc = XDocument.Load(xmlTripsFile);
                var newElement = new XElement("Trips",
                    new XElement("ID", ID),
                    new XElement("TripID", TripID),
                    new XElement("ReservationPersonID", ReservationPersonID),
                    new XElement("CustomerID", CustomerID),
                    new XElement("DriverID", DriverID),
                    new XElement("RegisterDateTime", RegisterDateTime),
                    new XElement("Description", Description)
                );

                TripsXDoc.Element("Tripss").Add(newElement);
                TripsXDoc.Save(xmlTripsFile);

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("متاسفانه خطایی در روند ثبت اطلاعات رخ داده است !");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                return false;
            }
        }
    }
}
