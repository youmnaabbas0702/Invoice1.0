using DevExpress.XtraEditors.DXErrorProvider;
using Invoice_v1._0.Data;
using Invoice_v1._0.Models;
using Invoice_v1._0.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Invoice_v1._0.Forms
{
    public partial class frmAddInvoice : Form
    {
        List<CountryItem> countries;
        List<ActivityCodeItem> ActivityCodes;
        private List<InvoiceLine> invoiceLines = new List<InvoiceLine>();
        private Invoice _invoice = new Invoice();

        public frmAddInvoice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1200, 600);
        }

        private void LoadCountries()
        {
            string path = Path.Combine(Application.StartupPath, "Countries.json");
            string json = File.ReadAllText(path);

            countries = JsonConvert.DeserializeObject<List<CountryItem>>(json);

            // Binding to both ComboBoxes
            cmbIssuerCountry.DataSource = new List<CountryItem>(countries);
            cmbIssuerCountry.DisplayMember = "NameEn";
            cmbIssuerCountry.ValueMember = "Code";

            cmbReceiverCountry.DataSource = new List<CountryItem>(countries);
            cmbReceiverCountry.DisplayMember = "NameEn";
            cmbReceiverCountry.ValueMember = "Code";

            // Select Egypt by default
            cmbIssuerCountry.SelectedValue = "EG";
            cmbReceiverCountry.SelectedValue = "EG";
        }

        private void LoadActivityCodes()
        {
            string path = Path.Combine(Application.StartupPath, "ActivityCodes.json");
            string json = File.ReadAllText(path);

            ActivityCodes = JsonConvert.DeserializeObject<List<ActivityCodeItem>>(json);

            cmbActivityCode.DataSource = ActivityCodes;
            cmbActivityCode.DisplayMember = "DisplayText";
            cmbActivityCode.ValueMember = "Code";

            cmbActivityCode.SelectedIndex = 0;
        }

        private void frmAddInvoice_Load(object sender, EventArgs e)
        {
            txtInternalId.Text = InvoiceServices.GenerateInternalID();
            dtpDateIssued.Value = DateTime.Now;
            dtpDateIssued.MaxDate = DateTime.Now;
            cmbReceiverType.EditValue = "B";
            cmbIssuerType.EditValue = "B";
            LoadCountries();
            LoadActivityCodes();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex += 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex -= 1;
        }

        private void txtReceiverId_Validating(object sender, CancelEventArgs e)
        {
            var textBox = sender as DevExpress.XtraEditors.TextEdit;
            if (textBox == null)
                return;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                dxErrorProvider1.SetError(
                    textBox,
                    "This field cannot be empty",
                    ErrorType.Critical
                );

                e.Cancel = true; 
            }
            else
            {
                dxErrorProvider1.SetError(textBox, "");
            }

            if(txtIssuerId.Text.Trim().ToLower() == txtReceiverId.Text.Trim().ToLower())
            {
                dxErrorProvider1.SetError(
                   textBox,
                   "Issuer Id and Receiver Id can't be equal.",
                   ErrorType.Critical
               );

                e.Cancel = true;
            }
            else
            {
                dxErrorProvider1.SetError(textBox, "");
            }
        }

        private void txtIssuerBranchId_Validating(object sender, CancelEventArgs e)
        {
            if (cmbIssuerType.EditValue?.ToString() == "B" && string.IsNullOrWhiteSpace(txtIssuerBranchId.Text))
            {
                dxErrorProvider1.SetError(
                    txtIssuerBranchId,
                    "Branch Id cannot be empty when issuer type = 'B'",
                    ErrorType.Critical
                );

                e.Cancel = true;
            }
            else
            {
                dxErrorProvider1.SetError(txtIssuerBranchId, "");
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            frmAddInvoiceLine lineForm = new frmAddInvoiceLine();

            // Subscribe BEFORE showing the dialog
            lineForm.OnInvoiceLineAdded += HandleInvoiceLineAdded;

            lineForm.ShowDialog();
        }

        private void HandleInvoiceLineAdded(InvoiceLine newLine)
        {
            invoiceLines.Add(newLine);
            UpdateInvoiceLinesGrid();

        }
        
        private void UpdateInvoiceLinesGrid()
        {
            dgvInvoiceLines.DataSource = null;
            dgvInvoiceLines.DataSource = invoiceLines
            .Select(l => new
            {
                l.Description,
                l.ItemType,
                l.ItemCode,
                l.UnitType,
                l.Quantity,
                l.CurrencySold,
                l.AmountEGP,
                l.SalesTotal,
                l.ItemsDiscount,
                l.DiscountAmount,
                l.NetTotal,
                l.TotalTaxableFees,
                l.Total
            })
            .ToList();
        }

        private Party BuildIssuerFromControls()
        {
            Party issuer = new Party();

            issuer.Role = "Issuer";
            issuer.Type = cmbIssuerType.SelectedItem.ToString()[0];     

            issuer.RegID = txtIssuerId.Text.Trim();
            issuer.Name = txtIssuerName.Text.Trim();

            issuer.Country = cmbIssuerCountry.SelectedValue.ToString();
            issuer.Governate = txtIssuerGovernate.Text.Trim();
            issuer.RegionCity = txtIssuerRegionCity.Text.Trim();
            issuer.Street = txtIssuerStreet.Text.Trim();
            issuer.BuildingNumber = txtIssuerBuildingNumber.Text.Trim();

            issuer.BranchId = txtIssuerBranchId.Text.Trim();

            return issuer;
        }

        private Party BuildReceiverFromControls()
        {
            Party receiver = new Party();

            receiver.Role = "Receiver"; 
            receiver.Type = cmbReceiverType.SelectedItem.ToString()[0];

            receiver.RegID = txtReceiverId.Text.Trim();
            receiver.Name = txtReceiverName.Text.Trim();

            receiver.Country = cmbReceiverCountry.SelectedValue.ToString();
            receiver.Governate = txtReceiverGovernate.Text.Trim();
            receiver.RegionCity = txtReceiverRegionCity.Text.Trim();
            receiver.Street = txtReceiverStreet.Text.Trim();
            receiver.BuildingNumber = txtReceiverBuildingNumber.Text.Trim();

            return receiver;
        }

        private bool CollectDataFromForm()
        {
            try
            {
                Party Issuer = BuildIssuerFromControls();
                Party Receiver = BuildReceiverFromControls();

                _invoice = new Invoice();
                _invoice.InternalId = txtInternalId.Text.Trim();
                _invoice.DateTimeIssued = dtpDateIssued.Value;

                _invoice.Issuer = Issuer;
                _invoice.Receiver = Receiver;

                _invoice.TaxpayerActivityCode = cmbActivityCode.SelectedValue.ToString();
                CalculateInvoiceTotals();

                // Lines & Totals are calculated
                _invoice.InvoiceLines = invoiceLines; // invoiceLines is your global list


                // Final Validation
                if (_invoice.InvoiceLines == null || _invoice.InvoiceLines.Count == 0)
                {
                    MessageBox.Show("Invoice must have at least ONE line!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Error while collecting invoice data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CalculateInvoiceTotals()
        {
            _invoice.TotalSalesAmount = invoiceLines.Sum(l => l.SalesTotal);
            _invoice.TotalItemsDiscountAmount = invoiceLines.Sum(l => l.ItemsDiscount);
            _invoice.TotalDiscountAmount = invoiceLines.Sum(l => l.DiscountAmount);
            _invoice.NetAmount = invoiceLines.Sum(l => l.NetTotal);
            _invoice.TotalAmount = invoiceLines.Sum(l => l.Total);
            _invoice.ExtraDiscountAmount = 0; // Not implemented yet, keep 0

            // CREATION of TaxTotals (grouping by TaxType)
            _invoice.TaxTotals = invoiceLines
                .SelectMany(l => l.Taxes)
                .GroupBy(t => t.TaxType)
                .Select(g => new InvoiceTaxTotal
                {
                    TaxType = g.Key,
                    Amount = g.Sum(x => x.TaxAmount)
                })
                .ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("There are invalid inputs!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }

            if (!CollectDataFromForm())
                return;

            bool isSaved = InvoiceServices.AddNewInvoice(_invoice);

            if (isSaved)
            {
                MessageBox.Show("Invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Would you like to generate report? ", "Invoice report creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmInvoiceReport frm = new frmInvoiceReport(_invoice.InvoiceID);
                    frm.ShowDialog();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            if (sender is System.Windows.Forms.ComboBox cb)
            {
                if (string.IsNullOrWhiteSpace(cb.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cb, "Required field");
                }
                else
                    errorProvider1.SetError(cb, "");
                return;
            }

            if (sender is DevExpress.XtraEditors.ComboBoxEdit cbxEdit)
            {
                if (string.IsNullOrWhiteSpace(cbxEdit.Text))
                {
                    e.Cancel = true;
                    dxErrorProvider1.SetError(cbxEdit, "Required field");
                }
                else
                    dxErrorProvider1.SetError(cbxEdit, "");
                return;
            }

            if (sender is System.Windows.Forms.TextBox tb)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tb, "Required field");
                }
                else
                    errorProvider1.SetError(tb, "");
                return;
            }

            if (sender is DevExpress.XtraEditors.TextEdit txtEdit)
            {
                if (string.IsNullOrWhiteSpace(txtEdit.Text))
                {
                    e.Cancel = true;
                    dxErrorProvider1.SetError(txtEdit, "Required field");
                }
                else
                    dxErrorProvider1.SetError(txtEdit, "");
                return;
            }

            if (sender is NumericUpDown nud)
            {
                if (nud.Value <= 0)
                {
                    e.Cancel = true;
                    dxErrorProvider1.SetError(nud, "Value must be > 0");
                }
                else
                    dxErrorProvider1.SetError(nud, "");
                return;
            }
        }

        private void txtInternalId_Validating(object sender, CancelEventArgs e)
        {
            string input = txtInternalId.Text.Trim();

            // 1) Check Empty
            if (string.IsNullOrEmpty(input))
            {
                e.Cancel = true;
                dxErrorProvider1.SetError(txtInternalId, "Internal ID is required.");
                return;
            }

            // 2) Check Duplicate from DB
            if (InvoiceDataAccess.IsINternalIdExist(input))
            {
                e.Cancel = true;
                dxErrorProvider1.SetError(txtInternalId, "Internal ID already exists!");
                return;
            }

            // Passed both checks
            dxErrorProvider1.SetError(txtInternalId, "");
        }

        private void dgvInvoiceLines_Validating(object sender, CancelEventArgs e)
        {
            if (dgvInvoiceLines.Rows.Count == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(dgvInvoiceLines, "There must be at least one onvoice line.");
            }
            else
                errorProvider1.SetError(dgvInvoiceLines, "");
        }
    }
}
