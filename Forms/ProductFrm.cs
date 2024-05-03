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
    public partial class ProductFrm : Form
    {
        private readonly DochDochContext _context;

        public ProductFrm(DochDochContext context)
        {
            InitializeComponent();
            _context = context;
        }

        public MainFrm MidParent { get; internal set; }

        protected void GetBrand()
        {
            string[,] sp_par =
            {
                {"brand_id","" }
                };
            cbo_Brand.DataSource = CRUDService.ExecCRUD(_context, "production.sp_brand_list", sp_par);
            cbo_Brand.ValueMember = "brand_id";
            cbo_Brand.DisplayMember = "brand_name";
        }
        private void ProductFrm_Load(object sender, EventArgs e)
        {
            string eventType = ProductListFrm.eventType;
            if(eventType == "View")
            {
                btnCUD.Visible = false;
            }
            else
            {
                btnCUD.Visible = true;
            }
            btnCUD.Text = eventType;
            GetBrand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string brand_id = cbo_Brand.SelectedValue.ToString();
            MessageBox.Show(brand_id);
        }
    }
}
