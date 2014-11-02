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

namespace TaxiServiceDempAppWithSQLServer
{
    public partial class TripOrderForm : Form
    {
        public TripOrderForm()
        {
            InitializeComponent();
        }

        private void TripOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiServicesDBDataSet.TripsTbl' table. You can move, or remove it, as needed.
            this.tripsTblTableAdapter.Fill(this.taxiServicesDBDataSet.TripsTbl);
            // TODO: This line of code loads data into the 'taxiServicesDBDataSet.ReservationPersonTbl' table. You can move, or remove it, as needed.
            this.reservationPersonTblTableAdapter.Fill(this.taxiServicesDBDataSet.ReservationPersonTbl);
            // TODO: This line of code loads data into the 'taxiServicesDBDataSet.DriverTbl' table. You can move, or remove it, as needed.
            this.driverTblTableAdapter.Fill(this.taxiServicesDBDataSet.DriverTbl);
            // TODO: This line of code loads data into the 'taxiServicesDBDataSet.CustomerTbl' table. You can move, or remove it, as needed.
            this.customerTblTableAdapter.Fill(this.taxiServicesDBDataSet.CustomerTbl);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = GenerateIDColumn.GetNewID("TripTbl");
                string Origin = this.textBox1.Text.ToString();
                string Destination = this.textBox2.Text.ToString();
                string RegisterDateTime = GetDateTime.GenerateDateTime();
                string Cost = this.textBox3.Text.ToString();
                string Description = this.richTextBox1.Text.ToString();

                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TaxiServiceDempAppWithSQLServer.Properties.Settings.TaxiServicesDBConnectionString"].ToString();
                SqlConnection cn = new SqlConnection(connectionString);
                cn.Open();

                string query = "INSERT INTO TripTbl (ID, Origin, Destination, RegisterDateTime, Cost, Description) values (@ID, @Origin, @Destination, @RegisterDateTime, @Cost, @Description)";
                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@Origin", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Destination", SqlDbType.NVarChar);
                cmd.Parameters.Add("@RegisterDateTime", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Cost", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar);

                cmd.Parameters["@ID"].Value = ID;
                cmd.Parameters["@Origin"].Value = Origin;
                cmd.Parameters["@Destination"].Value = Destination;
                cmd.Parameters["@RegisterDateTime"].Value = RegisterDateTime;
                cmd.Parameters["@Cost"].Value = Cost;
                cmd.Parameters["@Description"].Value = Description;

                cmd.ExecuteNonQuery();
                cn.Close();

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
            }
        }

        private bool InsertTripsToDB(int InputTripID)
        {
            try
            {
                int ID = GenerateIDColumn.GetNewID("TripsTbl");
                int TripID = InputTripID;
                int ReservationPersonID = int.Parse(this.comboBox3.SelectedValue.ToString());
                int CustomerID = int.Parse(this.comboBox1.SelectedValue.ToString());
                int DriverID = int.Parse(this.comboBox2.SelectedValue.ToString());
                string RegisterDateTime = GetDateTime.GenerateDateTime();
                string Description = "-";

                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TaxiServiceDempAppWithSQLServer.Properties.Settings.TaxiServicesDBConnectionString"].ToString();
                SqlConnection cn = new SqlConnection(connectionString);
                cn.Open();

                string query = "INSERT INTO TripsTbl (ID, TripID, ReservationPersonID, CustomerID, DriverID, RegisterDateTime, Description) values (@ID, @TripID, @ReservationPersonID, @CustomerID, @DriverID, @RegisterDateTime, @Description)";
                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@TripID", SqlDbType.Int);
                cmd.Parameters.Add("@ReservationPersonID", SqlDbType.Int);
                cmd.Parameters.Add("@CustomerID", SqlDbType.Int);
                cmd.Parameters.Add("@DriverID", SqlDbType.Int);
                cmd.Parameters.Add("@RegisterDateTime", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar);

                cmd.Parameters["@ID"].Value = ID;
                cmd.Parameters["@TripID"].Value = TripID;
                cmd.Parameters["@ReservationPersonID"].Value = ReservationPersonID;
                cmd.Parameters["@CustomerID"].Value = CustomerID;
                cmd.Parameters["@DriverID"].Value = DriverID;
                cmd.Parameters["@RegisterDateTime"].Value = RegisterDateTime;
                cmd.Parameters["@Description"].Value = Description;

                cmd.ExecuteNonQuery();
                cn.Close();

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("متاسفانه خطایی در روند ثبت اطلاعات رخ داده است !");
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
