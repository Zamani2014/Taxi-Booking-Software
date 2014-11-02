using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;

/// <summary>
/// Summary description for DateTime
/// </summary>
public class GetDateTime
{
    public GetDateTime()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string GenerateDateTime()
    {
        PersianCalendar jc = new PersianCalendar();
        DateTime thisDate = System.DateTime.Now;

        string p_year = jc.GetYear(thisDate).ToString();
        string p_month = jc.GetMonth(thisDate).ToString();
        string p_day = jc.GetDayOfMonth(thisDate).ToString();

        string mytime = jc.GetHour(thisDate).ToString() + ":" + jc.GetMinute(thisDate).ToString() + ":" + jc.GetSecond(thisDate).ToString();
        string mydate = p_year + "/" + p_month + "/" + p_day;
        string mytot = mytime + " - " + mydate;
        
        return mytot;
    }
}