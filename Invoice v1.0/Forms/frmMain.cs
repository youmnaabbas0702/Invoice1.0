using Invoice_v1._0.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_v1._0
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddNewInvoice_Click(object sender, EventArgs e)
        {
            frmAddInvoice frmAddInvoice = new frmAddInvoice();
            frmAddInvoice.ShowDialog();
        }

        private void btnFindINvoice_Click(object sender, EventArgs e)
        {
            frmCreateReport frm = new frmCreateReport();
            frm.ShowDialog();
        }
    }
}
