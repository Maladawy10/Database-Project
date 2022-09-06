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
    public partial class userhomepage : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        Dictionary<int, Product> ShoppingCart = new Dictionary<int, Product>();
        int userID;
        int quantity = 0;
        int ID = 0;
        int index = 0;

        public struct Pquantity
        {
           public int ID;
           public int Quantity;
        };
        Pquantity[] productsQuantity = new Pquantity[100];

        public userhomepage(int userID)
        {
            this.userID = userID;
            InitializeComponent();
        }

        private void userhomepage_Load(object sender, EventArgs e)
        {
            category_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            product_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            ShoppingCart.Clear();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getcategories";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("categories", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (category_cmb.Items.Contains(dr[0]))
                    continue;
                category_cmb.Items.Add(dr[0]);
            }
            dr.Close();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select ID, quantity from product";
            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                productsQuantity[index].ID = int.Parse(dr2[0].ToString());
                productsQuantity[index].Quantity = int.Parse(dr2[1].ToString());
                index++;
            }
            dr2.Close();
        }

        private void userhomepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void category_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            product_cmb.Items.Clear();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name from product where category=:category";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("category", category_cmb.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                product_cmb.Items.Add(dr["name"]);
            }
            dr.Close();
        }
        private void product_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select price, ID from product where name=:name and category=:category";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", product_cmb.SelectedItem.ToString());
            cmd.Parameters.Add("category", category_cmb.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                price_txt.Text = dr[0].ToString();
                ID = int.Parse(dr[1].ToString());
            }
            dr.Close();
           
        }

        private void buy_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < index; i++)
            {
                if(ID == productsQuantity[i].ID)
                {
                    quantity = productsQuantity[i].Quantity;
                }
            }
            if(quantity >= int.Parse(quantity_txt.Text.ToString()))
            {
                Product tempProduct = new Product(product_cmb.SelectedItem.ToString(), category_cmb.SelectedItem.ToString(), int.Parse(quantity_txt.Text.ToString()), quantity, int.Parse(price_txt.Text.ToString()));
                for (int i = 0; i < index; i++)
                {
                    if (ID == productsQuantity[i].ID)
                    {
                        productsQuantity[i].Quantity -= int.Parse(quantity_txt.Text.ToString());
                    }
                }

                ShoppingCart.Add(ID, tempProduct);

                MessageBox.Show("Item added to cart successfully");
                quantity_txt.Text = "";
                price_txt.Text = "";
                category_cmb.Text = "";
                product_cmb.Text = "";
            }
            else
            {
                MessageBox.Show("Not enough Quantity in stock! (Available Quantity = " + quantity +")");
                quantity_txt.Text = "";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckOutForm COF = new CheckOutForm(ShoppingCart, userID);
            COF.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
