using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Threading.Tasks;
/// <summary>
/// Summary description for Class1
/// </summary>
public class SQL
{
    public string connectionString;
    public SQL(string cs)
    {
        this.connectionString = cs;
    }
    public DataTable SearchSensor(string Name, string starttime, string endtime)
    {
        string strSQL = "select * from Scada.dbo.Table1 where Name=N'" + Name +"' " + 
            "and Time > convert(datetime, N'" + starttime + "',103) " +
            "and Time < convert(datetime, N'" + endtime +"',103);";
        return GetData(strSQL, connectionString);
    }
    public DataTable SearchSensor_Asc(string Name, string starttime, string endtime)
    {
        string strSQL = "select * from Scada.dbo.Table1 where Name=N'" + Name + "' " +
            "and Time > convert(datetime, N'" + starttime + "',103) " +
            "and Time < convert(datetime, N'" + endtime + "',103) " + "order by Time";
        return GetData(strSQL, connectionString);
    }

    public DataTable SearchSensor_Desc(string Name, string starttime, string endtime)
    {
        string strSQL = "select * from Scada.dbo.Table1 where Name=N'" + Name + "' " +
            "and Time > convert(datetime, N'" + starttime + "',103) " +
            "and Time < convert(datetime, N'" + endtime + "',103) " + "order by Time " + "desc";
        return GetData(strSQL, connectionString);
    }
    public DataTable GetSensor_Asc()
    {
        string strSQL = "select * from Scada.dbo.Table1 " + "order by Time";
        return GetData(strSQL, connectionString);
    }

    public DataTable GetSensor_Desc()
    {
        string strSQL = "select * from Scada.dbo.Table1 " + "order by Time " + "desc";
        return GetData(strSQL, connectionString);
    }

    public DataTable GetSensor_Named(string Name)
    {
        string strSQL = "select * from Scada.dbo.Table1 where Name=N'" + Name + "' " + "order by Time";
        return GetData(strSQL, connectionString);
    }
    // public DataTable GetSensor()
    //  {
    //     string strSQL = "select * from Scada.dbo.Table1";
    //      return GetData(strSQL, connectionString);
    //  }
    public System.Data.DataTable GetData(string selectCommand, string connectionString)
    {
        try
        {
            //Create a new data adapter based on the specified query 
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            // Create a command builder to generate SQL update, insert, and 
            // delete commands based on selectCommand. These are used to 
            // update the database.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Populate a new data table and bind it to the BindingSource. 
            System.Data.DataTable table = new System.Data.DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);

            return table;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}