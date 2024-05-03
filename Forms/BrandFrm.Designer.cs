namespace ProjectBikeStore.Forms
{
    partial class BrandFrm
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
            data_brand = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtbrandid = new TextBox();
            txtbrandname = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)data_brand).BeginInit();
            SuspendLayout();
            // 
            // data_brand
            // 
            data_brand.BackgroundColor = SystemColors.ControlLight;
            data_brand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_brand.Location = new Point(107, 225);
            data_brand.Name = "data_brand";
            data_brand.RowTemplate.Height = 25;
            data_brand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_brand.Size = new Size(655, 157);
            data_brand.TabIndex = 0;
            data_brand.CellDoubleClick += data_brand_CellDoubleClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 0, 192);
            textBox1.Location = new Point(198, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 51);
            textBox1.TabIndex = 1;
            textBox1.Text = "Bike Brand Information";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 95);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Brand Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 133);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Brand Name\r\n";
            // 
            // txtbrandid
            // 
            txtbrandid.Location = new Point(281, 87);
            txtbrandid.Name = "txtbrandid";
            txtbrandid.Size = new Size(226, 23);
            txtbrandid.TabIndex = 3;
            // 
            // txtbrandname
            // 
            txtbrandname.Location = new Point(281, 125);
            txtbrandname.Name = "txtbrandname";
            txtbrandname.Size = new Size(226, 23);
            txtbrandname.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(564, 129);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(657, 129);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(750, 129);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // BrandFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(865, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtbrandname);
            Controls.Add(txtbrandid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(data_brand);
            Name = "BrandFrm";
            Text = "Brand Name";
            Load += BrandFrm_Load;
            ((System.ComponentModel.ISupportInitialize)data_brand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data_brand;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox txtbrandid;
        private TextBox txtbrandname;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
    }
}