using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Sensors_Details : System.Web.UI.Page
{
    SQL _sql;
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
        _sql = new SQL(connectionString);
    }

    void Hienthigiatricambien(string Name)
    {
        string html1 =
  "<table class=content-table style=margin-left:130px>" +
       "<thead> <tr>" +
          "<th>Sensor</th>" +
          "<th>Value</th>" +
          "<th> Time </th>" +
       "</tr> </thead>";

        string html2 = "";
        DataTable cb = _sql.GetSensor_Named(Name);
        for (int i = 0; i < cb.Rows.Count; i++)
        {
            string tencambien = cb.Rows[i]["Name"].ToString();
            double giatri = Convert.ToDouble(cb.Rows[i]["Value"]);
            DateTime thoigian = Convert.ToDateTime(cb.Rows[i]["Time"]);
            html2 +=
                "<tbody><tr>" +
                    "<td>" + tencambien.ToString() + "</td>" +
                    "<td>" + giatri.ToString() + "</td>" +
                    "<td>" + thoigian.ToString() + "</td>" +
                "</tr><tbody/>";
        }
        string html3 = "</table><br />";
        Literal3.Text = html1 + html2 + html3;
    }

    protected void Name_Click(object sender, EventArgs e)
    {
        string Name = tbxNamed.Text;
        Hienthigiatricambien(Name);
    }
}