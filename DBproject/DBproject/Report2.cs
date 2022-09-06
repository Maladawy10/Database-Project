using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace DBproject
{
    public partial class Report2 : Form
    {
        customerreport customerreport;
        public Report2()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Choiceform cf = new Choiceform(2);
            cf.Show();
            this.Hide();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            customerreport = new customerreport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = customerreport;
        }
    }
}
