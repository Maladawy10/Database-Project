using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace DBproject
{
    public partial class Register_form : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        public Register_form()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (name_txt.Text == "")
                MessageBox.Show("Please fill all info");
            else if (id_txt.Text == "")
                MessageBox.Show("Please fill all info");
            else if (phone_txt.Text == "")
                MessageBox.Show("Please fill all info");
            else if (!male_rb.Checked && !female_rb.Checked)
                MessageBox.Show("Please fill all info");
            else if (passreg_txt.Text == "")
                MessageBox.Show("Please fill all info");
            else if (repass_txt.Text == "")
                MessageBox.Show("Please fill all info");
            else if (passreg_txt.Text != repass_txt.Text)
                MessageBox.Show("Password Mismatch");
            else if (!(email_txt.Text.Contains("@gmail.com")))
                MessageBox.Show("Incorrect E-mail format");
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into userph values (:nationalid,:name,:gender,:username,:pass,:phonenumber)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("nationalid", id_txt.Text.ToString());
                cmd.Parameters.Add("name", name_txt.Text.ToString());
                if (male_rb.Checked)
                    cmd.Parameters.Add("gender", 'M');
                else if (female_rb.Checked)
                    cmd.Parameters.Add("gender", 'F');
                cmd.Parameters.Add("username", email_txt.Text.ToString());
                cmd.Parameters.Add("pass", passreg_txt.Text.ToString());
                cmd.Parameters.Add("phonenumber", phone_txt.Text.ToString());
                int ret = cmd.ExecuteNonQuery();
                if (ret != -1)
                {
                    MessageBox.Show("Register Succesfully");
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void Register_form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Register_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
