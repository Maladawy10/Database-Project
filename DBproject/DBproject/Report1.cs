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
    
    public partial class Report1 : Form
    {
        productreport productreport;
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            productreport = new productreport();
            foreach (ParameterDiscreteValue v in productreport.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productreport.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = productreport;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Choiceform cf = new Choiceform(2);
            cf.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
