using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoUnderstand_dataset
{
    public partial class UnderstandDataSet : UserControl
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataSet ds;

        public UnderstandDataSet()
        {
            InitializeComponent();
        }

        DataTable GetEmployeeTable()
        {
            dt = new DataTable("Employee");
            #region Employee DataTable
            dc = new DataColumn("EmpId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("EmpName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("DepId", typeof(int));
            dt.Columns.Add(dc);

            // Adding rows
            dr = dt.NewRow();
            dr[0] = 101;
            dr["EmpName"] = "Anadi";
            dr[2] = 10;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 102;
            dr[1] = "Manadi";
            dr[2] = 20;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 103;
            dr[1] = "Sanaadi";
            dr[2] = 40;
            dt.Rows.Add(dr);
            #endregion

            return dt;
        }

        //DataTable GetDepartmentTable()
        //{
        //    dt = new DataTable("Department");
        //    #region Employee DataTable
        //    dc = new DataColumn("DepId", typeof(int));
        //    dt.Columns.Add(dc);
        //    dt.PrimaryKey = new DataColumn[] { dc };

        //    //dc = new DataColumn("DepName", typeof(string));
        //    //dt.Columns.Add(dc);

        //    dc = new DataColumn("DepId", typeof(int));
        //    dt.Columns.Add(dc);

        //    // Adding rows
        //    dr = dt.NewRow();
        //    dr[0] = 10;
        //    dr[1] = "Administration";
        //    dt.Rows.Add(dr);

        //    dr = dt.NewRow();
        //    dr[0] = 102;
        //    dr[1] = "HR";
        //    dt.Rows.Add(dr);
        //    #endregion

        //    return dt;
        //}

        //DataSet GenerateDataSet()
        //{
        //    DataTable emp = GetEmployeeTable();
        //    DataTable dept = GetDepartmentTable();

        //    ds = new DataSet("MyDs");
        //    ds.Tables.Add(emp);
        //    ds.Tables.Add(dept);

        //    DataColumn col_pk = ds.Tables["Department"].Columns["DeptId"];
        //    DataColumn col_fk = ds.Tables["Employee"].Columns["DeptId"];
        //    DataRelation drel = new DataRelation("Emp_Dept_Rel", col_pk, col_fk);
        //    ds.Relations.Add(drel);

        //    return ds;

        //}
        private void UnderstandDataSet_Load(object sender, EventArgs e)
        {
            //DataSet MyDs = GenerateDataSet();
            //dataGridView1.DataSource = MyDs.Tables["Employee"];
            //dataGridView2.DataSource = MyDs.Tables[1];
            DataTable EmpTable = GetEmployeeTable();
            dataGridView1.DataSource = EmpTable;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
