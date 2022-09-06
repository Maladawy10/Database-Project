using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
namespace DBproject
{
    public partial class Loginemp : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr";
       OracleConnection conn;
        int empID;
        public Loginemp()
        {
            InitializeComponent();
        }

        private void logasemp_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select password, id from emp where username=:usrname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("usrname", emaillog_txt.Text.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["password"].ToString().Equals(passlog_txt.Text.ToString()))
                {
                    empID = int.Parse(dr[1].ToString());
                    MessageBox.Show("login successfully");
                    Choiceform cf = new Choiceform(empID);
                    cf.Show();
                    this.Hide();
                    //empcategorydata ecd = new empcategorydata();
                    //ecd.Show();
                    //this.Hide();
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
        private void Loginemp_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Loginemp_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            Opening_Menu om = new Opening_Menu();
            om.Show();
            this.Hide();
        }

    }
}
