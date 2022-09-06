using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject
{
    public partial class Choiceform : Form
    {
        int empID;
        public Choiceform(int empID)
        {
            this.empID = empID;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Choiceform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                empcategorydata etf = new empcategorydata();
                etf.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                Report1 R1 = new Report1();
                R1.Show();
                this.Hide();
            }
            if (radioButton3.Checked)
            {
                Report2 R2 = new Report2();
                R2.Show();
                this.Hide();
            }
            if (newProductRadio.Checked)
            {
                EmpProduct R2 = new EmpProduct(empID);
                R2.Show();
                this.Hide();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Loginemp le = new Loginemp();
            le.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
