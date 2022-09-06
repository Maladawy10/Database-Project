using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;


namespace DBproject
{
    public partial class CheckOutForm : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr";
        OracleConnection conn;
        Dictionary<int, Product> shoppingCart = new Dictionary<int, Product>();
        int shippmentFees = 30;
        int userID;
        int totalPrice = 0;
        int newid, maxid = 0;
        int newOPid, OPmaxid;
        public CheckOutForm(Dictionary<int, Product> shoppingCart, int userID)
        {
            this.shoppingCart = shoppingCart;
            this.userID = userID;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            products_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETORDERID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ORID", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                maxid = Convert.ToInt32(cmd.Parameters["ORID"].Value.ToString());
                newid = maxid + 1;
            }
            catch
            {
                newid = 1;
                maxid = 1;
            }

            
            foreach(var x in shoppingCart.Values)
            {
                totalPrice += x.Price * x.Quantity;
            }

            foreach(var x in shoppingCart.Values)
            {
                products_cmb.Items.Add(x.Name);
            }

            totalPrice += shippmentFees;
            ShipmentFeesTxt.Text = shippmentFees.ToString();
            TotalPriceTxt.Text = totalPrice.ToString();
            orderDateTxt.Text = DateTime.Now.ToString();
            DeliveryDateTxt.Text = DateTime.Now.AddDays(3).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CreditNumberTxt.Visible = false;
            PinTxt.Visible = false;
            label4.Visible = false;
            label3.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CreditNumberTxt.Visible = true;
            PinTxt.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addressTxt.Text == "" && radioButton1.Checked)
            {
                MessageBox.Show("Please fill in the info");
            }
            else if((addressTxt.Text == "" || CreditNumberTxt.Text == "" || PinTxt.Text == "" ) && radioButton2.Checked)
            {
                MessageBox.Show("Please fill in the info");
            }
            else
            {

                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "insert into orderph values(:id, :shippingfees, :createdDate, :deliveryDate, :paymentMethod, :address, :customerid,:totalprice)";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("id", newid);
                cmd2.Parameters.Add("shippingfees", shippmentFees);
                cmd2.Parameters.Add("createdDate", Convert.ToDateTime(orderDateTxt.Text));
                cmd2.Parameters.Add("deliveryDate", Convert.ToDateTime(DeliveryDateTxt.Text));
                
                if(radioButton1.Checked)
                    cmd2.Parameters.Add("paymentMethod", radioButton1.Text.ToString());

                else if(radioButton2.Checked)
                    cmd2.Parameters.Add("paymentMethod", radioButton2.Text.ToString());

                cmd2.Parameters.Add("address", addressTxt.Text.ToString());
                cmd2.Parameters.Add("customerid", userID);
                cmd2.Parameters.Add("totalprice", totalPrice);
                int ret = cmd2.ExecuteNonQuery();
                if(ret != -1)
                {
                    foreach(var x in shoppingCart)
                    {
                        OracleCommand cmd4 = new OracleCommand();
                        cmd4.Connection = conn;
                        cmd4.CommandText = "GETORDERPRODUCTSID";
                        cmd4.CommandType = CommandType.StoredProcedure;
                        cmd4.Parameters.Add("ORPID", OracleDbType.Int32, ParameterDirection.Output);
                        cmd4.ExecuteNonQuery();
                        try
                        {
                            OPmaxid = Convert.ToInt32(cmd4.Parameters["ORPID"].Value.ToString());
                            newOPid = OPmaxid + 1;
                        }
                        catch
                        {
                            newOPid = 1;
                        }
                        OracleCommand cmd5 = new OracleCommand();
                        cmd5.Connection = conn;
                        cmd5.CommandText = "insert into orderproducts values(:id, :orderId, :productID)";
                        cmd5.CommandType = CommandType.Text;
                        cmd5.Parameters.Add("id", newOPid);
                        cmd5.Parameters.Add("orderId", newid);
                        cmd5.Parameters.Add("productID", x.Key);
                        cmd5.ExecuteNonQuery();

                        int newQuantity = 0;
                        newQuantity = x.Value.stockQuantity - x.Value.Quantity;
                        OracleCommand cmd7 = new OracleCommand();
                        cmd7.Connection = conn;
                        cmd7.CommandText = "Update product set quantity =:newquantity where id=:id";
                        cmd7.CommandType = CommandType.Text;
                        cmd7.Parameters.Add("newquantity", newQuantity);
                        cmd7.Parameters.Add("id", x.Key);
                        cmd7.ExecuteNonQuery();
                    }
                    MessageBox.Show("Order Confirmed Succefully");
                }
                else
                {
                    MessageBox.Show("failed");
                }
                userhomepage uhp = new userhomepage(userID);
                uhp.Show();
                this.Hide();
            }
        }

        private void CheckOutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
