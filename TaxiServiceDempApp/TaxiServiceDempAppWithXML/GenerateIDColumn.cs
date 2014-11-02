using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for GenerateIDColumn
/// </summary>
public class GenerateIDColumn
{
	public GenerateIDColumn()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static int GetNewID(string tableName)
    {
        PersianCalendar jc = new PersianCalendar();
        DateTime thisDate = System.DateTime.Now;

        //string p_year = jc.GetYear(thisDate).ToString();
        string p_month = jc.GetMonth(thisDate).ToString();
        string p_day = jc.GetDayOfMonth(thisDate).ToString();

        //string mytime = jc.GetHour(thisDate).ToString() + ":" + jc.GetMinute(thisDate).ToString() + ":" + jc.GetSecond(thisDate).ToString();
        int mydate = int.Parse(p_month + p_day + 1);
        //string mytot = mytime + " - " + mydate;

        string ConnectionString = ConfigurationManager.ConnectionStrings["TaxiServiceDempAppWithSQLServer.Properties.Settings.TaxiServicesDBConnectionString"].ConnectionString.ToString();
        SqlConnection CN = new SqlConnection(ConnectionString);
        CN.Open();
        string query = "SELECT TOP 1 * FROM " + tableName + " ORDER BY ID DESC";
        SqlCommand CMD = new SqlCommand(query, CN);
        SqlDataReader DR = CMD.ExecuteReader();

        if (DR.Read())
        {
            int latestID = int.Parse(DR["ID"].ToString());
            return latestID + 1;
        }
        else
        {
            return mydate;
        }
    }
}