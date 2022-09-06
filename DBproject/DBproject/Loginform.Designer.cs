namespace DBproject
{
    partial class Form1
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
            this.logascustomer = new System.Windows.Forms.Button();
            this.emaillog_txt = new System.Windows.Forms.TextBox();
            this.passlog_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logascustomer
            // 
            this.logascustomer.Location = new System.Drawing.Point(264, 189);
            this.logascustomer.Name = "logascustomer";
            this.logascustomer.Size = new System.Drawing.Size(147, 31);
            this.logascustomer.TabIndex = 1;
            this.logascustomer.Text = "Login As Customer";
            this.logascustomer.UseVisualStyleBackColor = true;
            this.logascustomer.Click += new System.EventHandler(this.logascustomer_Click);
            // 
            // emaillog_txt
            // 
            this.emaillog_txt.Location = new System.Drawing.Point(248, 65);
            this.emaillog_txt.Name = "emaillog_txt";
            this.emaillog_txt.Size = new System.Drawing.Size(178, 22);
            this.emaillog_txt.TabIndex = 3;
            // 
            // passlog_txt
            // 
            this.passlog_txt.Location = new System.Drawing.Point(248, 108);
            this.passlog_txt.Name = "passlog_txt";
            this.passlog_txt.PasswordChar = '*';
            this.passlog_txt.Size = new System.Drawing.Size(178, 22);
            this.passlog_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "If you don\'t have an Account?!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(294, 291);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(577, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 31);
            this.back_btn.TabIndex = 13;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 371);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passlog_txt);
            this.Controls.Add(this.emaillog_txt);
            this.Controls.Add(this.logascustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logascustomer;
        private System.Windows.Forms.TextBox emaillog_txt;
        private System.Windows.Forms.TextBox passlog_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button back_btn;
    }
}

