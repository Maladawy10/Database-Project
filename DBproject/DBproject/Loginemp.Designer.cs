namespace DBproject
{
    partial class Loginemp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passlog_txt = new System.Windows.Forms.TextBox();
            this.emaillog_txt = new System.Windows.Forms.TextBox();
            this.logasemp = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // passlog_txt
            // 
            this.passlog_txt.Location = new System.Drawing.Point(308, 116);
            this.passlog_txt.Name = "passlog_txt";
            this.passlog_txt.PasswordChar = '*';
            this.passlog_txt.Size = new System.Drawing.Size(178, 22);
            this.passlog_txt.TabIndex = 9;
            // 
            // emaillog_txt
            // 
            this.emaillog_txt.Location = new System.Drawing.Point(308, 73);
            this.emaillog_txt.Name = "emaillog_txt";
            this.emaillog_txt.Size = new System.Drawing.Size(178, 22);
            this.emaillog_txt.TabIndex = 8;
            // 
            // logasemp
            // 
            this.logasemp.Location = new System.Drawing.Point(253, 190);
            this.logasemp.Name = "logasemp";
            this.logasemp.Size = new System.Drawing.Size(155, 31);
            this.logasemp.TabIndex = 7;
            this.logasemp.Text = "Login As Employee";
            this.logasemp.UseVisualStyleBackColor = true;
            this.logasemp.Click += new System.EventHandler(this.logasemp_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(576, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 31);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click_1);
            // 
            // Loginemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 331);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passlog_txt);
            this.Controls.Add(this.emaillog_txt);
            this.Controls.Add(this.logasemp);
            this.Name = "Loginemp";
            this.Text = "Loginemp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loginemp_FormClosing);
            this.Load += new System.EventHandler(this.Loginemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passlog_txt;
        private System.Windows.Forms.TextBox emaillog_txt;
        private System.Windows.Forms.Button logasemp;
        private System.Windows.Forms.Button back_btn;
    }
}