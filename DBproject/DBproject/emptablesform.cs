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
    public partial class emptablesform : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public emptablesform()
        {
            InitializeComponent();
        }

        private void emptablesform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = "";
            if (textBox1.Text != "")
            {
                cmdstr = "select * from emp where age<=:age";
                adapter = new OracleDataAdapter(cmdstr, constr);
                adapter.SelectCommand.Parameters.Add("age", int.Parse(textBox1.Text.ToString()));
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
                MessageBox.Show("Please Provide an Age");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            
            MessageBox.Show("Data Updated successfully");
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Choiceform cf = new Choiceform(2);
            cf.Show();
            this.Hide();
        }
    }
}
