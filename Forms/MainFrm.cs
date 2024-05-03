using ProjectBikeStore.Models.Data;
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
    public partial class MainFrm : Form
    {
        private readonly DochDochContext _context;
        public MainFrm(DochDochContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void showForm(Form frm)
        {
            //frm.MidParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new BrandFrm(_context);
            showForm(frm);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ProductListFrm(_context);
            showForm(frm);
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new OrderListFrm(_context);
            showForm(frm);
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new InvoiceFrm(_context);
            showForm(frm);
        }
    }
}
