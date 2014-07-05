using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Data.OleDb;


public partial class DefaultGarden : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //DataSet ds1 = _wsGeneral.GetMoistureData();

DataSet MoistureStats = new DataSet();

                 String ConnectionString = "Data Source=p3nwdshsql-v06.shr.prod.phx3.secureserver.net;Initial Catalog=;User ID=;Password=;";

                SqlConnection con = new SqlConnection(ConnectionString);

                SqlCommand cmd = new SqlCommand("select * from test1 where site like 'unit_2%'", con);
                
                SqlDataAdapter DA = new SqlDataAdapter();
                DA.SelectCommand = cmd;
                con.Open();

                //DataSet DS = new DataSet();
                DA.Fill(MoistureStats, "UserTable");
                
                con.Close();


        dg1.DataSource = MoistureStats;
        dg1.DataBind();
    }
}
