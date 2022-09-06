
namespace DBproject
{
    partial class CheckOutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeliveryDateTxt = new System.Windows.Forms.TextBox();
            this.o = new System.Windows.Forms.Label();
            this.orderDateTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalPriceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShipmentFeesTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CreditNumberTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PinTxt = new System.Windows.Forms.TextBox();
            this.products_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Address";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(222, 67);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(177, 22);
            this.addressTxt.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Delivery Date";
            // 
            // DeliveryDateTxt
            // 
            this.DeliveryDateTxt.Location = new System.Drawing.Point(222, 316);
            this.DeliveryDateTxt.Name = "DeliveryDateTxt";
            this.DeliveryDateTxt.ReadOnly = true;
            this.DeliveryDateTxt.Size = new System.Drawing.Size(177, 22);
            this.DeliveryDateTxt.TabIndex = 18;
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Location = new System.Drawing.Point(89, 258);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(79, 17);
            this.o.TabIndex = 17;
            this.o.Text = "Order Date";
            // 
            // orderDateTxt
            // 
            this.orderDateTxt.Location = new System.Drawing.Point(222, 256);
            this.orderDateTxt.Name = "orderDateTxt";
            this.orderDateTxt.ReadOnly = true;
            this.orderDateTxt.Size = new System.Drawing.Size(177, 22);
            this.orderDateTxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Price";
            // 
            // TotalPriceTxt
            // 
            this.TotalPriceTxt.Location = new System.Drawing.Point(222, 190);
            this.TotalPriceTxt.Name = "TotalPriceTxt";
            this.TotalPriceTxt.ReadOnly = true;
            this.TotalPriceTxt.Size = new System.Drawing.Size(177, 22);
            this.TotalPriceTxt.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Shippment Fees";
            // 
            // ShipmentFeesTxt
            // 
            this.ShipmentFeesTxt.Location = new System.Drawing.Point(222, 127);
            this.ShipmentFeesTxt.Name = "ShipmentFeesTxt";
            this.ShipmentFeesTxt.ReadOnly = true;
            this.ShipmentFeesTxt.Size = new System.Drawing.Size(177, 22);
            this.ShipmentFeesTxt.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(496, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 87);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Credit Card";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cash";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Card Number";
            this.label3.Visible = false;
            // 
            // CreditNumberTxt
            // 
            this.CreditNumberTxt.Location = new System.Drawing.Point(625, 187);
            this.CreditNumberTxt.Name = "CreditNumberTxt";
            this.CreditNumberTxt.Size = new System.Drawing.Size(177, 22);
            this.CreditNumberTxt.TabIndex = 30;
            this.CreditNumberTxt.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Pin";
            this.label4.Visible = false;
            // 
            // PinTxt
            // 
            this.PinTxt.Location = new System.Drawing.Point(625, 258);
            this.PinTxt.Name = "PinTxt";
            this.PinTxt.Size = new System.Drawing.Size(177, 22);
            this.PinTxt.TabIndex = 28;
            this.PinTxt.Visible = false;
            // 
            // products_cmb
            // 
            this.products_cmb.FormattingEnabled = true;
            this.products_cmb.Location = new System.Drawing.Point(222, 367);
            this.products_cmb.Name = "products_cmb";
            this.products_cmb.Size = new System.Drawing.Size(177, 24);
            this.products_cmb.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Products";
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(768, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 31);
            this.logout_btn.TabIndex = 34;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.products_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreditNumberTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PinTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalPriceTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShipmentFeesTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeliveryDateTxt);
            this.Controls.Add(this.o);
            this.Controls.Add(this.orderDateTxt);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckOutForm_FormClosing);
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DeliveryDateTxt;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.TextBox orderDateTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalPriceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ShipmentFeesTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreditNumberTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PinTxt;
        private System.Windows.Forms.ComboBox products_cmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button logout_btn;
    }
}