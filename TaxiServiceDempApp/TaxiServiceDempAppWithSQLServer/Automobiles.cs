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
            // TODO: This line of code loads data into the 'taxiServicesDBDataSet.AutomobileTbl' table. You can move, or remove it, as needed.
            this.automobileTblTableAdapter.Fill(this.taxiServicesDBDataSet.AutomobileTbl);

            string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TaxiServiceDempAppWithSQLServer.Properties.Settings.TaxiServicesDBConnectionString"].ToString();

            string query = "SELECT A.DriverID, A.ID, A.Name, A.Color, A.Model, A.ChasisNo, A.No, A.Description, B.FirstName, B.LastName" +
                           " FROM AutomobileTbl A, DriverTbl B Where A.DriverID = B.ID";

            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();

            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
