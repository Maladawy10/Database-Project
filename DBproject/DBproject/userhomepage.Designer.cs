namespace DBproject
{
    partial class userhomepage
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
            this.category_cmb = new System.Windows.Forms.ComboBox();
            this.product_cmb = new System.Windows.Forms.ComboBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buy_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // category_cmb
            // 
            this.category_cmb.FormattingEnabled = true;
            this.category_cmb.Location = new System.Drawing.Point(188, 42);
            this.category_cmb.Name = "category_cmb";
            this.category_cmb.Size = new System.Drawing.Size(121, 24);
            this.category_cmb.TabIndex = 0;
            this.category_cmb.SelectedIndexChanged += new System.EventHandler(this.category_cmb_SelectedIndexChanged);
            // 
            // product_cmb
            // 
            this.product_cmb.FormattingEnabled = true;
            this.product_cmb.Location = new System.Drawing.Point(188, 102);
            this.product_cmb.Name = "product_cmb";
            this.product_cmb.Size = new System.Drawing.Size(121, 24);
            this.product_cmb.TabIndex = 1;
            this.product_cmb.SelectedIndexChanged += new System.EventHandler(this.product_cmb_SelectedIndexChanged);
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(188, 228);
            this.price_txt.Name = "price_txt";
            this.price_txt.ReadOnly = true;
            this.price_txt.Size = new System.Drawing.Size(121, 22);
            this.price_txt.TabIndex = 2;
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(188, 169);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(121, 22);
            this.quantity_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Price";
            // 
            // buy_btn
            // 
            this.buy_btn.Location = new System.Drawing.Point(356, 294);
            this.buy_btn.Name = "buy_btn";
            this.buy_btn.Size = new System.Drawing.Size(136, 29);
            this.buy_btn.TabIndex = 8;
            this.buy_btn.Text = "Add to Cart";
            this.buy_btn.UseVisualStyleBackColor = true;
            this.buy_btn.Click += new System.EventHandler(this.buy_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(459, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 31);
            this.logout_btn.TabIndex = 10;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // userhomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 436);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buy_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.product_cmb);
            this.Controls.Add(this.category_cmb);
            this.Name = "userhomepage";
            this.Text = "userhomepage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userhomepage_FormClosing);
            this.Load += new System.EventHandler(this.userhomepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox category_cmb;
        private System.Windows.Forms.ComboBox product_cmb;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buy_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logout_btn;
    }
}