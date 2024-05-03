namespace ProjectBikeStore.Forms
{
    partial class ProductFrm
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
            label1 = new Label();
            cbo_Brand = new ComboBox();
            btnCUD = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbo_Category = new ComboBox();
            txtProductId = new TextBox();
            txtProductModelYear = new TextBox();
            txtProductName = new TextBox();
            label6 = new Label();
            txtProductListPrice = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 296);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Model Year";
            // 
            // cbo_Brand
            // 
            cbo_Brand.FormattingEnabled = true;
            cbo_Brand.Location = new Point(205, 209);
            cbo_Brand.Name = "cbo_Brand";
            cbo_Brand.Size = new Size(266, 23);
            cbo_Brand.TabIndex = 1;
            // 
            // btnCUD
            // 
            btnCUD.Location = new Point(425, 372);
            btnCUD.Name = "btnCUD";
            btnCUD.Size = new Size(75, 23);
            btnCUD.TabIndex = 2;
            btnCUD.Text = "CUD";
            btnCUD.UseVisualStyleBackColor = true;
            btnCUD.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 259);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 217);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 181);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 0;
            label4.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 146);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 0;
            label5.Text = "Product Id";
            // 
            // cbo_Category
            // 
            cbo_Category.FormattingEnabled = true;
            cbo_Category.Location = new Point(205, 251);
            cbo_Category.Name = "cbo_Category";
            cbo_Category.Size = new Size(266, 23);
            cbo_Category.TabIndex = 1;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(205, 138);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(266, 23);
            txtProductId.TabIndex = 3;
            // 
            // txtProductModelYear
            // 
            txtProductModelYear.Location = new Point(205, 288);
            txtProductModelYear.Name = "txtProductModelYear";
            txtProductModelYear.Size = new Size(266, 23);
            txtProductModelYear.TabIndex = 3;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(205, 173);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(266, 23);
            txtProductName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 330);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 0;
            label6.Text = "List Price";
            // 
            // txtProductListPrice
            // 
            txtProductListPrice.Location = new Point(205, 322);
            txtProductListPrice.Name = "txtProductListPrice";
            txtProductListPrice.Size = new Size(266, 23);
            txtProductListPrice.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 61);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 0;
            label7.Text = "Product CUD";
            // 
            // ProductFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 450);
            Controls.Add(txtProductName);
            Controls.Add(txtProductListPrice);
            Controls.Add(txtProductModelYear);
            Controls.Add(txtProductId);
            Controls.Add(btnCUD);
            Controls.Add(cbo_Category);
            Controls.Add(cbo_Brand);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductFrm";
            Text = "ProductFrm";
            Load += ProductFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbo_Brand;
        private Button btnCUD;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbo_Category;
        private TextBox txtProductId;
        private TextBox txtProductModelYear;
        private TextBox txtProductName;
        private Label label6;
        private TextBox txtProductListPrice;
        private Label label7;
    }
}