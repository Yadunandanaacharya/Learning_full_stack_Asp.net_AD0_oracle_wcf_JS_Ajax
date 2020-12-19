using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using samplewcfservice;
using System.ServiceModel;

namespace DemoWcfHost
{
    public partial class Form1 : Form
    {
        ServiceHost host;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceHost host = new ServiceHost(typeof(User));
            host.AddServiceEndpoint(typeof(IUser), new NetTcpBinding(), "net.tcp://localhost:1234/mysampleservice");
            host.Open();
            label1.Text = ("Server Started");
        }
    }
}
