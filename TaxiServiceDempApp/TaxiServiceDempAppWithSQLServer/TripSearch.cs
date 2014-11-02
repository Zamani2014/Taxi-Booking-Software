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
    public partial class TripSearch : Form
    {
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
                string query = "SELECT A.FirstName, A.LastName, B.Origin, B.Destination, B.Cost, C.LastName, D.Name FROM " +
                    "CustomerTbl A, TripTbl B, DriverTbl C, AutomobileTbl D, TripsTbl E WHERE 1=1 ";

                if (this.textBox1.Text != string.Empty)
                {
                    query += " AND A.ID='" + int.Parse(this.textBox1.Text.ToString()) + "'";
                }
                else
                {
                    if (this.textBox2.Text != string.Empty && this.textBox3.Text != string.Empty)
                    {
                        query += " AND A.FirstName LIKE '%" + this.textBox2.Text.ToString() + "%'";
                        query += " AND A.LastName LIKE '%" + this.textBox3.Text.ToString() + "%'";
                    }
                    else
                    {
                        MessageBox.Show("اطلاعات ناقص وارد شده است.");
                    }
                }

                query += " AND A.ID = E.CustomerID AND B.ID = E.TripID AND C.ID = E.DriverID AND C.ID = D.DriverID";

                string connString = System.Configuration.ConfigurationManager.ConnectionStrings["TaxiServiceDempAppWithSQLServer.Properties.Settings.TaxiServicesDBConnectionString"].ToString();
                SqlConnection cn = new SqlConnection(connString);
                cn.Open();

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
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
        }
    }
}
