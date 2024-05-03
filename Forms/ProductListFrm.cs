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
    public partial class ProductListFrm : Form
    {
        private readonly DochDochContext _context;
        public static string eventType = "";
        public static string productId = "";

        //public MainFrm MidParent { get; internal set; }

        public ProductListFrm(DochDochContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void ProductListFrm_Load(object sender, EventArgs e)
        {
            GetProductList();
        }

        protected void GetProductList()
        {
            string[,] par =
                {
                    {"product_id","" }
                };
            grd_Product.DataSource = CRUDService.ExecCRUD(_context, "product_list", par);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ProductFrm(_context);
            eventType = "View";
            frm.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frm = new ProductFrm(_context);
            eventType = "Save";
            frm.ShowDialog();
        }
    }
}
