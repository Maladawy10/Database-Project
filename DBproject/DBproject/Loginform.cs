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
    public partial class Form1 : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        int userID;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reg_btn_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_form f = new Register_form();
            f.Show();
            this.Hide();
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void logascustomer_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select password, id from userph where email=:email";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", emaillog_txt.Text.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["password"].ToString().Equals(passlog_txt.Text.ToString()))
                {
                    MessageBox.Show("login successfully");
                    userID = int.Parse(dr[1].ToString());
                    userhomepage uhp = new userhomepage(userID);
                    uhp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid password");
                }
            }
            else
            {
                MessageBox.Show("invalid username");
            }
            dr.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Opening_Menu om = new Opening_Menu();
            om.Show();
            this.Hide();
        }
    }
}
