
namespace DBproject
{
    partial class EmpProduct
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActualPriceTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SellingPriceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CategoryCmb = new System.Windows.Forms.ComboBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(230, 79);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(346, 74);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 22);
            this.NameTxt.TabIndex = 1;
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(346, 135);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(100, 22);
            this.QuantityTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // ActualPriceTxt
            // 
            this.ActualPriceTxt.Location = new System.Drawing.Point(346, 192);
            this.ActualPriceTxt.Name = "ActualPriceTxt";
            this.ActualPriceTxt.Size = new System.Drawing.Size(100, 22);
            this.ActualPriceTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actual Price";
            // 
            // SellingPriceTxt
            // 
            this.SellingPriceTxt.Location = new System.Drawing.Point(346, 252);
            this.SellingPriceTxt.Name = "SellingPriceTxt";
            this.SellingPriceTxt.Size = new System.Drawing.Size(100, 22);
            this.SellingPriceTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selling Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category";
            // 
            // CategoryCmb
            // 
            this.CategoryCmb.FormattingEnabled = true;
            this.CategoryCmb.Location = new System.Drawing.Point(346, 317);
            this.CategoryCmb.Name = "CategoryCmb";
            this.CategoryCmb.Size = new System.Drawing.Size(121, 24);
            this.CategoryCmb.TabIndex = 9;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(517, 378);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(125, 33);
            this.AddProductBtn.TabIndex = 10;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(664, 28);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(86, 33);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // EmpProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.CategoryCmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SellingPriceTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ActualPriceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuantityTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLabel);
            this.Name = "EmpProduct";
            this.Text = "EmpProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpProduct_FormClosing);
            this.Load += new System.EventHandler(this.EmpProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ActualPriceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SellingPriceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CategoryCmb;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button backBtn;
    }
}