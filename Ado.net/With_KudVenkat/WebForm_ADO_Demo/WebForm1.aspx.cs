using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Configuration;


//Execute each and every line SO that you can use alternatives also.

namespace WebForm_ADO_Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //string connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog = youtube; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //string CS = @"data source=(local)\SQLEXPRESS; database=youtube1; integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(CS)) 
            {
                SqlCommand cmd = new SqlCommand("Select * from tblProductis1", con);
                con.Open();
                //SqlDataReader rdr = cmd.ExecuteReader();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
          


            //string CS = @"data source=(local)\SQLEXPRESS; database=youtube1; integrated security=SSPI";
            //SqlConnection con = new SqlConnection(CS);
            //SqlCommand cmd = new SqlCommand("Select * from tblProductis1", con);
            //con.Open();
            //SqlDataReader rdr = cmd.ExecuteReader();
            //GridView1.DataSource = rdr;
            //GridView1.DataBind();
            //con.Close();

            ////////////////////////////////////////////////////////////////
            //using (SqlConnection sqlCon = new SqlConnection(connectionString))
            //{
            //    sqlCon.Open();
            //    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tblProductis",sqlCon);
            //    //DataTable dt

            //}
        }
    }
}