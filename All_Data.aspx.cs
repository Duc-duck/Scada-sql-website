using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class All_Data : System.Web.UI.Page
{
    SQL _sql;
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
        _sql = new SQL(connectionString);
        Hienthigiatricambien();
    }
    void Hienthigiatricambien()
    {
        string html1 =
          "<table class=content-table style=margin-left:130px id=mytable>" +
               "<thead> <tr>" +
                  "<th>Sensor</th>" +
                  "<th>Value</th>" +
                  "<th> Time </th>" +
               "</tr> </thead>";

        string html2 = "";
        DataTable cb = _sql.GetSensor_Asc();
        for (int i = 0; i < cb.Rows.Count; i++)
        {
            string tencambien = cb.Rows[i]["Name"].ToString();
            double giatri = Convert.ToDouble(cb.Rows[i]["Value"]);
            DateTime thoigian = Convert.ToDateTime(cb.Rows[i]["Time"]);
            html2 +=
                "<tbody> <tr>" +
                    "<td>" + tencambien.ToString() + "</td>" +
                    "<td>" + giatri.ToString() + "</td>" +
                    "<td>" + thoigian.ToString() + "</td>" +
                "</tr> </tbody>";
        }
        string html3 = "</table><br />";
        Literal1.Text = html1 + html2 + html3;
    }

    protected void All_Asc_Click(object sender, EventArgs e)
    {
        Hienthigiatricambien();
    }

    protected void All_Desc_Click(object sender, EventArgs e)
    {
        string html1 =
"<table class=content-table style=margin-left:130px>" +
"<thead> <tr>" +
  "<th>Sensor</th>" +
  "<th>Value</th>" +
  "<th> Time </th>" +
"</tr> </thead>";

        string html2 = "";
        DataTable cb = _sql.GetSensor_Desc();
        for (int i = 0; i < cb.Rows.Count; i++)
        {
            string tencambien = cb.Rows[i]["Name"].ToString();
            double giatri = Convert.ToDouble(cb.Rows[i]["Value"]);
            DateTime thoigian = Convert.ToDateTime(cb.Rows[i]["Time"]);
            html2 +=
                "<tbody> <tr>" +
                    "<td>" + tencambien.ToString() + "</td>" +
                    "<td>" + giatri.ToString() + "</td>" +
                    "<td>" + thoigian.ToString() + "</td>" +
                "</tr> </tbody>";
        }
        string html3 = "</table><br />";
        Literal1.Text = html1 + html2 + html3;
    }
}