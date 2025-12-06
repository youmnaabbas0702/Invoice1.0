using Invoice_v1._0.Reports;
using Invoice_v1._0.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_v1._0.Forms
{
    public partial class frmInvoiceReport : Form
    {
        private int _invoiceID;

        public frmInvoiceReport(int invoiceID)
        {
            InitializeComponent();
            _invoiceID = invoiceID;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmInvoiceReport_Load(object sender, EventArgs e)
        {
            var ds = InvoiceServices.GetInvoiceData(_invoiceID);
            Debug.WriteLine(ds.Tables["InvoiceLines"].Rows.Count); // must be > 0

              rptInvoice rpt = new rptInvoice();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
