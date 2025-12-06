using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Invoice_v1._0.Models;
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

namespace Invoice_v1._0.Forms
{
    public partial class frmAddInvoiceLine : Form
    {
        public delegate void InvoiceLineDataBack(InvoiceLine line);
        public InvoiceLineDataBack OnInvoiceLineAdded;

        List<UnitTypeItem> unitTypes = new List<UnitTypeItem>();
        List<InvoiceLineTax> Taxes = new List<InvoiceLineTax>();

        public frmAddInvoiceLine()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1050, 650);

            // Wire up validating events
            cmbItemType.Validating += Control_Validating;
            txtItemCode.Validating += Control_Validating;
            txtDescription.Validating += Control_Validating;
            nudQuantity.Validating += Control_Validating;
            cmbUnitType.Validating += Control_Validating;
            nudUnitPrice.Validating += Control_Validating;
            nudDiscountperUnit.Validating += Control_Validating;
            nudDiscountRate.Validating += Control_Validating;
            nudQuantity.Validating += Control_Validating;
            // Calculation events
            nudQuantity.ValueChanged += (s, e) => { CalculateSalesTotal(); CalculateItemsDiscount(); CalculateNetTotal(); CalculateTotal(); };
            nudUnitPrice.ValueChanged += (s, e) => { CalculateSalesTotal(); CalculateDiscountAmount(); CalculateNetTotal(); CalculateTotal(); };
            nudDiscountperUnit.ValueChanged += (s, e) => { CalculateItemsDiscount(); CalculateNetTotal(); CalculateTotal(); };
            nudDiscountRate.ValueChanged += (s, e) => { CalculateDiscountAmount(); CalculateNetTotal(); CalculateTotal(); };
            nudTotalTaxableFees.ValueChanged += (s, e) => { CalculateTotal(); };
        }

        // Generic validation for controls
        private void Control_Validating(object sender, CancelEventArgs e)
        {
            if (sender is ComboBoxEdit cbxEdit)
            {
                if (string.IsNullOrWhiteSpace(cbxEdit.Text))
                {
                    e.Cancel = true;
                    dxErrorProvider1.SetError(cbxEdit, "Required field");
                }
                else
                    dxErrorProvider1.SetError(cbxEdit, "");
            }
            // DevExpress TextEdit
            else if (sender is TextEdit txt)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    e.Cancel = true;
                    dxErrorProvider1.SetError(txt, "Required field");
                }
                else
                    dxErrorProvider1.SetError(txt, "");
            }
            else if (sender is NumericUpDown nud)
            {
                if (nud.Value <= 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(nud, "Value must be > 0");
                }
                else
                    errorProvider1.SetError(nud, "");
            }
        }

        private void LoadUnitTypes()
        {
            string path = Path.Combine(Application.StartupPath, "UnitTypes.json");
            string json = File.ReadAllText(path);

            unitTypes = JsonConvert.DeserializeObject<List<UnitTypeItem>>(json);

            cmbUnitType.DataSource = unitTypes;
            cmbUnitType.DisplayMember = "DescEn";
            cmbUnitType.ValueMember = "Code";

            cmbUnitType.SelectedValue = "KGM";
        }

        private void frmAddInvoiceLine_Load(object sender, EventArgs e)
        {
            cmbItemType.SelectedIndex = 0;
            LoadUnitTypes();
        }

        private void btnAddTax_Click(object sender, EventArgs e)
        {
            frmAddTax frmAddTax = new frmAddTax();

            frmAddTax.TaxObjectDataBack += OnNewTaxReceived;

            frmAddTax.ShowDialog();
        }

        private void OnNewTaxReceived(InvoiceLineTax tax)
        {
            // 1. Validate that the TaxType is unique
            if (Taxes.Any(t => t.TaxType.Equals(tax.TaxType, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Tax type '{tax.TaxType}' is already added for this line.",
                    "Duplicate Tax", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Add the new tax to the list
            Taxes.Add(tax);

            //update taxable fees
            nudTotalTaxableFees.Value = Taxes.Sum(t => t.TaxAmount);

            // 3. Refresh the DataGridView
            UpdateTaxesGrid();
        }

        private void UpdateTaxesGrid()
        {
            dgvTaxes.DataSource = null;
            dgvTaxes.DataSource = Taxes
                .Select(t => new
                {
                    t.TaxType,
                    t.TaxRate,
                    t.TaxAmount,
                    t.SubType
                })
                .ToList();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            // Create InvoiceLine object
            InvoiceLine line = new InvoiceLine
            {
                Description = txtDescription.Text.Trim(),
                ItemType = cmbItemType.Text,
                ItemCode = txtItemCode.Text.Trim(),
                UnitType = cmbUnitType.Text,
                Quantity = nudQuantity.Value,
                AmountEGP = nudUnitPrice.Value,
                SalesTotal = nudSalesTotal.Value,
                ItemsDiscount = nudItemsDiscount.Value,
                DiscountAmount = nudDiscountAmount.Value,
                NetTotal = nudNetTotal.Value,
                TotalTaxableFees = nudTotalTaxableFees.Value,
                Total = nudTotal.Value,
                Taxes = Taxes
            };

            // Call delegate to send back
            OnInvoiceLineAdded?.Invoke(line);
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        //equations calculations
        private void CalculateSalesTotal()
        {
            nudSalesTotal.Value = nudQuantity.Value * nudUnitPrice.Value;
        }

        private void CalculateItemsDiscount()
        {
            nudItemsDiscount.Value = nudQuantity.Value * nudDiscountperUnit.Value;
        }

        private void CalculateDiscountAmount()
        {
            nudDiscountAmount.Value = (nudDiscountRate.Value / 100m) * nudSalesTotal.Value;
        }

        private void CalculateNetTotal()
        {
            nudNetTotal.Value = nudSalesTotal.Value - nudItemsDiscount.Value - nudDiscountAmount.Value;
        }

        private void CalculateTotal()
        {
            nudTotal.Value = nudNetTotal.Value + nudTotalTaxableFees.Value;
        }

        private void txtItemCode_Validating(object sender, CancelEventArgs e)
        {
            if(cmbItemType.SelectedIndex == 0 && !txtItemCode.Text.Trim().StartsWith("EG"))
            {
                e.Cancel = true;
                dxErrorProvider1.SetError(txtItemCode, "If item type is 'EGS' code must start with EG.");
            }
            else
                dxErrorProvider1.SetError(txtItemCode, "");
        }
    }
}
