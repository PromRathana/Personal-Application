namespace ProjectBikeStore.Forms
{
    partial class OrderListFrm
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
            components = new System.ComponentModel.Container();
            grd_OrderList = new DataGridView();
            txtFDate = new DateTimePicker();
            label1 = new Label();
            btnRefresh = new Button();
            btnAddNew = new Button();
            txtTDate = new DateTimePicker();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            orderInvoiceToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)grd_OrderList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grd_OrderList
            // 
            grd_OrderList.AllowUserToAddRows = false;
            grd_OrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_OrderList.ContextMenuStrip = contextMenuStrip1;
            grd_OrderList.Location = new Point(56, 235);
            grd_OrderList.Name = "grd_OrderList";
            grd_OrderList.RowHeadersWidth = 62;
            grd_OrderList.RowTemplate.Height = 33;
            grd_OrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_OrderList.Size = new Size(1680, 471);
            grd_OrderList.TabIndex = 0;
            // 
            // txtFDate
            // 
            txtFDate.CustomFormat = "yyyy-MM-dd";
            txtFDate.Format = DateTimePickerFormat.Custom;
            txtFDate.Location = new Point(668, 139);
            txtFDate.Name = "txtFDate";
            txtFDate.Size = new Size(300, 27);
            txtFDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 139);
            label1.Name = "label1";
            label1.Size = new Size(124, 18);
            label1.TabIndex = 2;
            label1.Text = "Between Date";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1477, 139);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(1595, 139);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(141, 34);
            btnAddNew.TabIndex = 3;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // txtTDate
            // 
            txtTDate.CustomFormat = "yyyy-MM-dd";
            txtTDate.Format = DateTimePickerFormat.Custom;
            txtTDate.Location = new Point(992, 139);
            txtTDate.Name = "txtTDate";
            txtTDate.Size = new Size(300, 27);
            txtTDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 64);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 2;
            label2.Text = "Order List";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { orderInvoiceToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // orderInvoiceToolStripMenuItem
            // 
            orderInvoiceToolStripMenuItem.Name = "orderInvoiceToolStripMenuItem";
            orderInvoiceToolStripMenuItem.Size = new Size(180, 22);
            orderInvoiceToolStripMenuItem.Text = "Order Invoice";
            orderInvoiceToolStripMenuItem.Click += orderInvoiceToolStripMenuItem_Click;
            // 
            // OrderListFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 760);
            Controls.Add(btnAddNew);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTDate);
            Controls.Add(txtFDate);
            Controls.Add(grd_OrderList);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OrderListFrm";
            Text = "OrderListFrm";
            Load += OrderListFrm_Load;
            ((System.ComponentModel.ISupportInitialize)grd_OrderList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grd_OrderList;
        private DateTimePicker txtFDate;
        private Label label1;
        private Button btnRefresh;
        private Button btnAddNew;
        private DateTimePicker txtTDate;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem orderInvoiceToolStripMenuItem;
    }
}