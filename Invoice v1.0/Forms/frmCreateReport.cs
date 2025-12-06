using Invoice_v1._0.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_v1._0.Forms
{
    public partial class frmCreateReport : Form
    {
        public frmCreateReport()
        {
            InitializeComponent();
            this.Size = new Size(600, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string internalId = txtInternalId.Text.Trim();
            if (!InvoiceServices.IsInternalIdExist(internalId))
            {
                MessageBox.Show("Internal Id not exist, choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int invoiceId = InvoiceServices.GetInvoiceID(internalId);
            frmInvoiceReport frm = new frmInvoiceReport(invoiceId);
            frm.ShowDialog();
        }
    }
}
