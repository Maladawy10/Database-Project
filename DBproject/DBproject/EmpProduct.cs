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
    public partial class EmpProduct : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        int maxID = 0;
        int newID = 0;
        int empID;
        public EmpProduct(int empID)
        {
            this.empID = empID;
            InitializeComponent();
        }

        private void EmpProduct_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETMAXPRODUCTID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ID", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                maxID = Convert.ToInt32(cmd.Parameters["ID"].Value.ToString());
                newID = maxID + 1;
            }
            catch
            {
                newID = 1;
                maxID = 1;
            }

            CategoryCmb.Items.Clear();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select category from product";
            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                if (CategoryCmb.Items.Contains(dr["category"].ToString()))
                    continue;
                CategoryCmb.Items.Add(dr["category"].ToString());
            }
            dr.Close();
        }

        private void EmpProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text != "" && QuantityTxt.Text != "" && ActualPriceTxt.Text != "" && SellingPriceTxt.Text != "" && CategoryCmb.Text != "")
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "insert into product values (:ID, :name, :quantity, :actualCost, :Category, :price, :empID)";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("ID", newID);
                cmd2.Parameters.Add("name", NameTxt.Text.ToString());
                cmd2.Parameters.Add("quantity", int.Parse(QuantityTxt.Text.ToString()));
                cmd2.Parameters.Add("actualCost", int.Parse(ActualPriceTxt.Text.ToString()));
                cmd2.Parameters.Add("Category", CategoryCmb.Text.ToString());
                cmd2.Parameters.Add("price", SellingPriceTxt.Text.ToString());
                cmd2.Parameters.Add("empID", empID);
                int r = cmd2.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Product Added Successfully");
                    NameTxt.Text = "";
                    QuantityTxt.Text = "";
                    ActualPriceTxt.Text = "";
                    SellingPriceTxt.Text = "";
                    CategoryCmb.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please fill All the information");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Choiceform cf = new Choiceform(empID);
            cf.Show();
            this.Hide();
        }
    }
}
