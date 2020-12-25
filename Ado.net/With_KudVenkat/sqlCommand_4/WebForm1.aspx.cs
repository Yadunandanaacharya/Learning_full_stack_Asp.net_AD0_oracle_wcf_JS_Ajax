using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace sqlCommand_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection con = new SqlConnection(CS))
            {
                //SqlCommand cmd = new SqlCommand("Select ProductId, Name, UnitPrice, QtyAvailable from tblProduct4", con);
                //con.Open();
                //GridView1.DataSource =  cmd.ExecuteReader();
                //GridView1.DataBind();

                //Other way of doing

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "delete from tblProduct4 where ProductId = 3";
                int TotalRowsAffected = (int)cmd.ExecuteNonQuery();
                Response.Write("Total Rows deleted = " + TotalRowsAffected.ToString() + "<br/>");


                cmd.CommandText = "Insert into tblProduct4 values (5, 'Server', 23333, 5)";
                TotalRowsAffected = (int)cmd.ExecuteNonQuery();
                Response.Write("Total Rows Inserted = " + TotalRowsAffected.ToString() + "<br/>");



                cmd.CommandText = "update tblProduct4 set UnitPrice=0 where ProductId=3";
                TotalRowsAffected = (int)cmd.ExecuteNonQuery();
                Response.Write("Total Rows Updated = " + TotalRowsAffected.ToString() + "<br/>");
            }
        }
    }
}