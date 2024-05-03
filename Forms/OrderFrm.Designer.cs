namespace ProjectBikeStore.Forms
{
    partial class OrderFrm
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
            btn_Order_AddNew = new Button();
            grd_order_items = new DataGridView();
            cboCustomerId = new ComboBox();
            label1 = new Label();
            txtOrderId = new TextBox();
            groupBox1 = new GroupBox();
            cboProduct = new ComboBox();
            cboBrand = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            txtTotal = new TextBox();
            txtDiscount = new TextBox();
            txtUnitPrice = new TextBox();
            txtQty = new TextBox();
            label9 = new Label();
            label7 = new Label();
            cboCategory = new ComboBox();
            txtGrandTotal = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cboStoreId = new ComboBox();
            label5 = new Label();
            cboStaffId = new ComboBox();
            label6 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)grd_order_items).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Order_AddNew
            // 
            btn_Order_AddNew.Location = new Point(1439, 34);
            btn_Order_AddNew.Margin = new Padding(2, 3, 2, 3);
            btn_Order_AddNew.Name = "btn_Order_AddNew";
            btn_Order_AddNew.Size = new Size(140, 30);
            btn_Order_AddNew.TabIndex = 0;
            btn_Order_AddNew.Text = "Add Item";
            btn_Order_AddNew.UseVisualStyleBackColor = true;
            btn_Order_AddNew.Click += btn_Order_AddNew_Click;
            // 
            // grd_order_items
            // 
            grd_order_items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_order_items.Location = new Point(18, 175);
            grd_order_items.Margin = new Padding(2, 3, 2, 3);
            grd_order_items.Name = "grd_order_items";
            grd_order_items.RowHeadersWidth = 62;
            grd_order_items.RowTemplate.Height = 33;
            grd_order_items.Size = new Size(1561, 222);
            grd_order_items.TabIndex = 1;
            // 
            // cboCustomerId
            // 
            cboCustomerId.FormattingEnabled = true;
            cboCustomerId.Location = new Point(234, 181);
            cboCustomerId.Margin = new Padding(2, 3, 2, 3);
            cboCustomerId.Name = "cboCustomerId";
            cboCustomerId.Size = new Size(377, 24);
            cboCustomerId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1136, 780);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 16);
            label1.TabIndex = 3;
            label1.Text = "Grand Total";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(234, 132);
            txtOrderId.Margin = new Padding(2, 3, 2, 3);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(377, 23);
            txtOrderId.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grd_order_items);
            groupBox1.Controls.Add(btn_Order_AddNew);
            groupBox1.Controls.Add(cboProduct);
            groupBox1.Controls.Add(cboBrand);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtDiscount);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtQty);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Location = new Point(42, 351);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(1602, 414);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Item";
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(573, 128);
            cboProduct.Margin = new Padding(2, 3, 2, 3);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(394, 24);
            cboProduct.TabIndex = 2;
            // 
            // cboBrand
            // 
            cboBrand.FormattingEnabled = true;
            cboBrand.Location = new Point(295, 128);
            cboBrand.Margin = new Padding(2, 3, 2, 3);
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new Size(274, 24);
            cboBrand.TabIndex = 2;
            cboBrand.SelectedIndexChanged += cboBrand_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1490, 92);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(40, 16);
            label13.TabIndex = 3;
            label13.Text = "Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1334, 92);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(64, 16);
            label12.TabIndex = 3;
            label12.Text = "Discount";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1154, 92);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(65, 16);
            label11.TabIndex = 3;
            label11.Text = "UnitPrice";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(974, 92);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(31, 16);
            label10.TabIndex = 3;
            label10.Text = "Qty";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(576, 92);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(58, 16);
            label8.TabIndex = 3;
            label8.Text = "Product";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(1441, 128);
            txtTotal.Margin = new Padding(2, 3, 2, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(138, 23);
            txtTotal.TabIndex = 4;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(1305, 128);
            txtDiscount.Margin = new Padding(2, 3, 2, 3);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(132, 23);
            txtDiscount.TabIndex = 4;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(1147, 128);
            txtUnitPrice.Margin = new Padding(2, 3, 2, 3);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(154, 23);
            txtUnitPrice.TabIndex = 4;
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(974, 128);
            txtQty.Margin = new Padding(2, 3, 2, 3);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(170, 23);
            txtQty.TabIndex = 4;
            txtQty.TextChanged += txtQty_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(298, 92);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(44, 16);
            label9.TabIndex = 3;
            label9.Text = "Brand";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 92);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 16);
            label7.TabIndex = 3;
            label7.Text = "Category";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(18, 128);
            cboCategory.Margin = new Padding(2, 3, 2, 3);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(274, 24);
            cboCategory.TabIndex = 2;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Location = new Point(1283, 772);
            txtGrandTotal.Margin = new Padding(2, 3, 2, 3);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.Size = new Size(338, 23);
            txtGrandTotal.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 16);
            label2.TabIndex = 3;
            label2.Text = "Order Id";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(-388, -479);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(800, 39);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(270, 38);
            label3.TabIndex = 3;
            label3.Text = "Product Order";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 188);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 16);
            label4.TabIndex = 3;
            label4.Text = "Customer";
            // 
            // cboStoreId
            // 
            cboStoreId.FormattingEnabled = true;
            cboStoreId.Location = new Point(234, 233);
            cboStoreId.Margin = new Padding(2, 3, 2, 3);
            cboStoreId.Name = "cboStoreId";
            cboStoreId.Size = new Size(377, 24);
            cboStoreId.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 240);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 16);
            label5.TabIndex = 3;
            label5.Text = "Store";
            // 
            // cboStaffId
            // 
            cboStaffId.FormattingEnabled = true;
            cboStaffId.Location = new Point(234, 282);
            cboStaffId.Margin = new Padding(2, 3, 2, 3);
            cboStaffId.Name = "cboStaffId";
            cboStaffId.Size = new Size(377, 24);
            cboStaffId.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 289);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(40, 16);
            label6.TabIndex = 3;
            label6.Text = "Staff";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(745, 289);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // OrderFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1688, 830);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Controls.Add(txtGrandTotal);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtOrderId);
            Controls.Add(label1);
            Controls.Add(cboStaffId);
            Controls.Add(cboStoreId);
            Controls.Add(cboCustomerId);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "OrderFrm";
            Text = "OrderFrm";
            Load += OrderFrm_Load;
            ((System.ComponentModel.ISupportInitialize)grd_order_items).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Order_AddNew;
        private DataGridView grd_order_items;
        private ComboBox cboCustomerId;
        private Label label1;
        private TextBox txtOrderId;
        private GroupBox groupBox1;
        private TextBox txtGrandTotal;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private ComboBox cboStoreId;
        private Label label5;
        private ComboBox cboStaffId;
        private Label label6;
        private ComboBox cboProduct;
        private ComboBox cboBrand;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label7;
        private ComboBox cboCategory;
        private Label label13;
        private Button btnSave;
        private TextBox txtTotal;
        private TextBox txtDiscount;
        private TextBox txtUnitPrice;
        private TextBox txtQty;
    }
}