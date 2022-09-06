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
    public partial class empcategorydata : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public empcategorydata()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = @"select * from product where category=:category";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("category", comboBox1.SelectedItem.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void empcategorydata_Load(object sender, EventArgs e)
        {
            string constr = "User Id=hr;Password=hr;Data Source=orcl";
            string cmdstr = @"select category from product";
            OracleDataAdapter adapter1 = new OracleDataAdapter(cmdstr, constr);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1);
            for(int i=0;i< ds1.Tables[0].Rows.Count;i++)
            {
                if(!comboBox1.Items.Contains(ds1.Tables[0].Rows[i].Field<string>("category")))
                comboBox1.Items.Add(ds1.Tables[0].Rows[i].Field<string>("category"));
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Data Updated successfully");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Choiceform cf = new Choiceform(2);
            cf.Show();
            this.Hide();
        }
    }
}
