using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adodemo1_kudvenkat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void form1_load(object sender, EventArgs e)
        {
            update();
        }
        public void update()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Hai";
            dataGridView1.Columns[0].Name = "Bai";
            dataGridView1.Columns[0].Name = "See you";

            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("1");
            row.Add("1");
            dataGridView1.Rows.Add(row.ToArray());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
