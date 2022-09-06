namespace DBproject
{
    partial class Register_form
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.passreg_txt = new System.Windows.Forms.TextBox();
            this.repass_txt = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pass_txt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gender_gb = new System.Windows.Forms.GroupBox();
            this.male_rb = new System.Windows.Forms.RadioButton();
            this.female_rb = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gender_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(377, 27);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 22);
            this.name_txt.TabIndex = 0;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(377, 74);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 22);
            this.id_txt.TabIndex = 1;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(377, 124);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(100, 22);
            this.phone_txt.TabIndex = 3;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(377, 235);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(100, 22);
            this.email_txt.TabIndex = 4;
            // 
            // passreg_txt
            // 
            this.passreg_txt.Location = new System.Drawing.Point(377, 274);
            this.passreg_txt.Name = "passreg_txt";
            this.passreg_txt.PasswordChar = '*';
            this.passreg_txt.Size = new System.Drawing.Size(100, 22);
            this.passreg_txt.TabIndex = 5;
            // 
            // repass_txt
            // 
            this.repass_txt.Location = new System.Drawing.Point(377, 318);
            this.repass_txt.Name = "repass_txt";
            this.repass_txt.PasswordChar = '*';
            this.repass_txt.Size = new System.Drawing.Size(100, 22);
            this.repass_txt.TabIndex = 6;
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(325, 355);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(100, 27);
            this.register_btn.TabIndex = 7;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "National ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "E-mail";
            // 
            // Pass_txt
            // 
            this.Pass_txt.AutoSize = true;
            this.Pass_txt.Location = new System.Drawing.Point(165, 279);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.Size = new System.Drawing.Size(69, 17);
            this.Pass_txt.TabIndex = 12;
            this.Pass_txt.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Re-enter Password";
            // 
            // gender_gb
            // 
            this.gender_gb.Controls.Add(this.male_rb);
            this.gender_gb.Controls.Add(this.female_rb);
            this.gender_gb.Location = new System.Drawing.Point(168, 161);
            this.gender_gb.Name = "gender_gb";
            this.gender_gb.Size = new System.Drawing.Size(309, 49);
            this.gender_gb.TabIndex = 0;
            this.gender_gb.TabStop = false;
            this.gender_gb.Text = "Gender";
            this.gender_gb.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // male_rb
            // 
            this.male_rb.AutoSize = true;
            this.male_rb.Location = new System.Drawing.Point(225, 17);
            this.male_rb.Name = "male_rb";
            this.male_rb.Size = new System.Drawing.Size(59, 21);
            this.male_rb.TabIndex = 1;
            this.male_rb.Text = "Male";
            this.male_rb.UseVisualStyleBackColor = true;
            // 
            // female_rb
            // 
            this.female_rb.AutoSize = true;
            this.female_rb.Location = new System.Drawing.Point(85, 17);
            this.female_rb.Name = "female_rb";
            this.female_rb.Size = new System.Drawing.Size(75, 21);
            this.female_rb.TabIndex = 0;
            this.female_rb.Text = "Female";
            this.female_rb.UseVisualStyleBackColor = true;
            this.female_rb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(335, 402);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "If you have an Account?!";
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gender_gb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.repass_txt);
            this.Controls.Add(this.passreg_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.name_txt);
            this.Name = "Register_form";
            this.Text = "Register_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_form_FormClosing);
            this.Load += new System.EventHandler(this.Register_form_Load);
            this.gender_gb.ResumeLayout(false);
            this.gender_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox passreg_txt;
        private System.Windows.Forms.TextBox repass_txt;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Pass_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gender_gb;
        private System.Windows.Forms.RadioButton male_rb;
        private System.Windows.Forms.RadioButton female_rb;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}