using Microsoft.EntityFrameworkCore;
using ProjectBikeStore.Models.Data;
using ProjectBikeStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBikeStore.Forms
{
    public partial class OrderListFrm : Form
    {
        private readonly DochDochContext _context;
        public static string OrderId;
        public OrderListFrm(DochDochContext context)
        {
            InitializeComponent();
            _context = context;
        }
        private void OrderListFrm_Load(object sender, EventArgs e)
        {
            GetOrderList();
        }

        protected void GetOrderList()
        {
            string[,] par =
            {
                { "fDate", txtFDate.Text},
                { "tDate", txtFDate.Text}
            };
            grd_OrderList.DataSource = CRUDService.ExecCRUD(_context, "order_list", par);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetOrderList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frm = new OrderFrm(_context);
            frm.ShowDialog();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void orderInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderId = grd_OrderList.SelectedRows[0].Cells[0].Value.ToString();
            var frm = new InvoiceFrm(_context);
            frm.ShowDialog();
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
