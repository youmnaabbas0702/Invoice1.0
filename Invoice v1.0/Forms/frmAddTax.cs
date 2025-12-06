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
    public partial class frmAddTax : Form
    {
        List<TaxTypeItem> TaxTypes = new List<TaxTypeItem>();
        List<TaxSubTypeItem> TaxSubTypes = new List<TaxSubTypeItem>();

        // Delegate to return the created tax object
        public delegate void TaxObjectDataBackHandler(InvoiceLineTax tax);
        public event TaxObjectDataBackHandler TaxObjectDataBack;

        public frmAddTax()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 270);
            // Attach Validating events for controls
            cmbTaxType.Validating += Control_Validating;
            nudTaxRate.Validating += Control_Validating;
            nudTaxAmount.Validating += Control_Validating;
        }

        private void LoadTaxTypes()
        {
            string path = Path.Combine(Application.StartupPath, "TaxTypes.json");
            string json = File.ReadAllText(path);

            TaxTypes = JsonConvert.DeserializeObject<List<TaxTypeItem>>(json);

            cmbTaxType.DataSource = TaxTypes;
            cmbTaxType.DisplayMember = "DisplayText";
            cmbTaxType.ValueMember = "Code";    

            cmbTaxType.SelectedIndex = 0;
        }

        private void LoadTaxSubTypes()
        {
            string path = Path.Combine(Application.StartupPath, "TaxSubTypes.json");
            string json = File.ReadAllText(path);

            TaxSubTypes = JsonConvert.DeserializeObject<List<TaxSubTypeItem>>(json);

            cmbTaxSubType.DataSource = TaxSubTypes;
            cmbTaxSubType.DisplayMember = "DisplayText"; 
            cmbTaxSubType.ValueMember = "Code";          
        }

        private void frmAddTax_Load(object sender, EventArgs e)
        {
            LoadTaxSubTypes();
            LoadTaxTypes();

        }

        private void CmbTaxType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTaxType.SelectedValue == null)
                return;

            string selectedTaxTypeCode = cmbTaxType.SelectedValue.ToString();

            var filteredSubTypes = TaxSubTypes
                .Where(st => st.TaxTypeReference == selectedTaxTypeCode)
                .ToList();

            cmbTaxSubType.DataSource = filteredSubTypes;
            cmbTaxSubType.DisplayMember = "DisplayText";
            cmbTaxSubType.ValueMember = "Code";

            if (filteredSubTypes.Any())
                cmbTaxSubType.SelectedValue = filteredSubTypes[0].Code;
            else
                cmbTaxSubType.SelectedIndex = -1;
        }

        private void Control_Validating(object sender, CancelEventArgs e)
        {
            if (sender is ComboBox cb)
            {
                if (string.IsNullOrWhiteSpace(cb.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cb, "Required field");

                }
                else
                {
                    errorProvider1.SetError(cb, "");
                }
            }
            else if (sender is NumericUpDown nud)
            {
                if (nud.Value <= 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(nud, "Value must be > 0");

                }
                else
                {
                    errorProvider1.SetError(nud, "");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Trigger validation for all child controls
            if (!ValidateChildren())
            {
                MessageBox.Show("Please fix validation errors.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create tax object
            InvoiceLineTax tax = new InvoiceLineTax
            {
                TaxType = cmbTaxType.Text.Trim(),
                SubType = string.IsNullOrWhiteSpace(cmbTaxSubType.Text) ? null : cmbTaxSubType.Text.Trim(),
                TaxRate = nudTaxRate.Value,
                TaxAmount = nudTaxAmount.Value
            };

            // Call the delegate to send tax object back
            TaxObjectDataBack?.Invoke(tax);

            // Close the form
            this.Close();
        }
    
    }
}
