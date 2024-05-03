using Microsoft.Reporting.WinForms;
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
    
    public partial class InvoiceFrm : Form
    {
        private readonly DochDochContext _context;
        public InvoiceFrm(DochDochContext context)
        {
            InitializeComponent();
            _context = context; 
        }

        private void InvoiceFrm_Load(object sender, EventArgs e)
        {
            //var rv = ReadMTResultService.ExecReadData(_context, "exec order_invoice_by_id '1616'");
            string OrderId = OrderListFrm.OrderId;
            GetInvoice(OrderId);
        }
        protected void GetInvoice(string order_id)
        {
            var dataSet = ReadMTResultService.ExecReadData(_context, "exec order_invoice_by_id '" + order_id + "'");
            reportViewer1.Reset();
            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource orderRDS = new ReportDataSource();
            orderRDS.Value = dataSet.Tables[0];
            orderRDS.Name = "OrderDs";
            this.reportViewer1.LocalReport.DataSources.Add(orderRDS);

            ReportDataSource roderItemRDS = new ReportDataSource();
            roderItemRDS.Value = dataSet.Tables[1];
            roderItemRDS.Name = "OrderItemsDs";
            this.reportViewer1.LocalReport.DataSources.Add(roderItemRDS);

            this.reportViewer1.LocalReport.ReportPath = "E:\\Lesson at BBU\\Year II\\Semester II\\Personal Application Development\\Project\\ProjectBikeStore\\Reports\\OrderInvoice.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
