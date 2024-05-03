using Microsoft.Data.SqlClient;
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
    public partial class BrandFrm : Form
    {
        private readonly DochDochContext _context;
        string status, message;
        //CRUDService crud = new CRUDService();
        public BrandFrm(DochDochContext context)
        {
            InitializeComponent();
            _context = context;
        }

        public MainFrm MidParent { get; internal set; }

        //public MainFrm MidParent { get; internal set; }

        private void BrandFrm_Load(object sender, EventArgs e)
        {
            GetBrand();
        }

        private void GetBrand()
        {

            string[,] sp_par =
                {
                    {"brand_id","" }
                };
            data_brand.DataSource = CRUDService.ExecCRUD(_context, "production.sp_brand_list", sp_par);
        }
        protected void CUDBrand(string cud)
        {
            string[,] sp_par =
                {
                    {"brand_id",txtbrandid.Text },
                    {"brand_name",txtbrandname.Text },
                    {"cud",cud }
                };
            var rv = CRUDService.ExecCRUD(_context, "production.brands_cud", sp_par);
            if (rv != null)
            {
                status = rv.Rows[0][0].ToString();
                message = rv.Rows[0]["cud_message"].ToString();
                if (status == "Succeed")
                {
                    GetBrand();
                }
            }
            else
            {
                status = "Error";
                message = "Something went wrong !";
            }
            MessageService.doMessage(status, message);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageService.doMessageQuestion("Do you want to save ?") == DialogResult.Yes)
            {
                CUDBrand("C");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageService.doMessageQuestion("Do you want to update ?") == DialogResult.Yes)
            {
                CUDBrand("U");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageService.doMessageQuestion("Do you want to delete ?") == DialogResult.Yes)
            {
                CUDBrand("D");
            }
        }

        private void data_brand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbrandid.Text = data_brand.SelectedRows[0].Cells[0].Value.ToString();
            txtbrandname.Text = data_brand.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
