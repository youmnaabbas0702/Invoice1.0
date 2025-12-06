namespace Invoice_v1._0.Forms
{
    partial class frmAddInvoiceLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbUnitType = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.nudSalesTotal = new System.Windows.Forms.NumericUpDown();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.nudNetTotal = new System.Windows.Forms.NumericUpDown();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbItemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.nudDiscountAmount = new System.Windows.Forms.NumericUpDown();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.nudDiscountRate = new System.Windows.Forms.NumericUpDown();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.nudItemsDiscount = new System.Windows.Forms.NumericUpDown();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.nudDiscountperUnit = new System.Windows.Forms.NumericUpDown();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.nudTotalTaxableFees = new System.Windows.Forms.NumericUpDown();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddTax = new System.Windows.Forms.Button();
            this.dgvTaxes = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalesTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemsDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountperUnit)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTaxableFees)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(35, 48);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(58, 26);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Code:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(35, 118);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 26);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDescription.Location = new System.Drawing.Point(166, 120);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(390, 101);
            this.txtDescription.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 261);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 26);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Quantity:";
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.Location = new System.Drawing.Point(361, 264);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(195, 34);
            this.cmbUnitType.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(588, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(324, 51);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "New Invoice Line";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 26);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Unit price:";
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.DecimalPlaces = 5;
            this.nudUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudUnitPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudUnitPrice.Location = new System.Drawing.Point(226, 54);
            this.nudUnitPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(322, 32);
            this.nudUnitPrice.TabIndex = 20;
            this.nudUnitPrice.ThousandsSeparator = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(158, 54);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 26);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "EGP";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(158, 127);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 26);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "EGP";
            // 
            // nudSalesTotal
            // 
            this.nudSalesTotal.DecimalPlaces = 5;
            this.nudSalesTotal.Enabled = false;
            this.nudSalesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudSalesTotal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudSalesTotal.Location = new System.Drawing.Point(226, 127);
            this.nudSalesTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudSalesTotal.Name = "nudSalesTotal";
            this.nudSalesTotal.Size = new System.Drawing.Size(322, 32);
            this.nudSalesTotal.TabIndex = 23;
            this.nudSalesTotal.ThousandsSeparator = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(27, 127);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(108, 26);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Sales total:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(227, 125);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 26);
            this.labelControl9.TabIndex = 27;
            this.labelControl9.Text = "EGP";
            // 
            // nudNetTotal
            // 
            this.nudNetTotal.DecimalPlaces = 5;
            this.nudNetTotal.Enabled = false;
            this.nudNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudNetTotal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudNetTotal.Location = new System.Drawing.Point(295, 125);
            this.nudNetTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudNetTotal.Name = "nudNetTotal";
            this.nudNetTotal.Size = new System.Drawing.Size(322, 32);
            this.nudNetTotal.TabIndex = 26;
            this.nudNetTotal.ThousandsSeparator = true;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(35, 125);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(87, 26);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Net total:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(227, 196);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 26);
            this.labelControl11.TabIndex = 30;
            this.labelControl11.Text = "EGP";
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 5;
            this.nudTotal.Enabled = false;
            this.nudTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudTotal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudTotal.Location = new System.Drawing.Point(295, 196);
            this.nudTotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(322, 32);
            this.nudTotal.TabIndex = 29;
            this.nudTotal.ThousandsSeparator = true;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(35, 196);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(53, 26);
            this.labelControl12.TabIndex = 28;
            this.labelControl12.Text = "Total:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.DecimalPlaces = 5;
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudQuantity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudQuantity.Location = new System.Drawing.Point(166, 266);
            this.nudQuantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(189, 32);
            this.nudQuantity.TabIndex = 31;
            this.nudQuantity.ThousandsSeparator = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.cmbItemType);
            this.groupBox1.Controls.Add(this.txtItemCode);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.cmbUnitType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 315);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product info";
            // 
            // cmbItemType
            // 
            this.cmbItemType.Location = new System.Drawing.Point(166, 48);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbItemType.Properties.Appearance.Options.UseFont = true;
            this.cmbItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbItemType.Properties.Items.AddRange(new object[] {
            "EGS",
            "GS1"});
            this.cmbItemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbItemType.Size = new System.Drawing.Size(83, 32);
            this.cmbItemType.TabIndex = 0;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(255, 48);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Properties.Appearance.Options.UseFont = true;
            this.txtItemCode.Size = new System.Drawing.Size(301, 32);
            this.txtItemCode.TabIndex = 10;
            this.txtItemCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtItemCode_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.nudUnitPrice);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.nudSalesTotal);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(12, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 192);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pricing";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelControl21);
            this.groupBox3.Controls.Add(this.labelControl17);
            this.groupBox3.Controls.Add(this.nudDiscountAmount);
            this.groupBox3.Controls.Add(this.labelControl18);
            this.groupBox3.Controls.Add(this.labelControl19);
            this.groupBox3.Controls.Add(this.nudDiscountRate);
            this.groupBox3.Controls.Add(this.labelControl20);
            this.groupBox3.Controls.Add(this.labelControl15);
            this.groupBox3.Controls.Add(this.nudItemsDiscount);
            this.groupBox3.Controls.Add(this.labelControl16);
            this.groupBox3.Controls.Add(this.labelControl13);
            this.groupBox3.Controls.Add(this.nudDiscountperUnit);
            this.groupBox3.Controls.Add(this.labelControl14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(12, 643);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 323);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discounts";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(524, 175);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(20, 26);
            this.labelControl21.TabIndex = 37;
            this.labelControl21.Text = "%";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(17, 226);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(166, 26);
            this.labelControl17.TabIndex = 34;
            this.labelControl17.Text = "discount amount:";
            // 
            // nudDiscountAmount
            // 
            this.nudDiscountAmount.DecimalPlaces = 5;
            this.nudDiscountAmount.Enabled = false;
            this.nudDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudDiscountAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudDiscountAmount.Location = new System.Drawing.Point(256, 226);
            this.nudDiscountAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudDiscountAmount.Name = "nudDiscountAmount";
            this.nudDiscountAmount.Size = new System.Drawing.Size(322, 32);
            this.nudDiscountAmount.TabIndex = 35;
            this.nudDiscountAmount.ThousandsSeparator = true;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(189, 226);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(47, 26);
            this.labelControl18.TabIndex = 36;
            this.labelControl18.Text = "EGP";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(17, 175);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(130, 26);
            this.labelControl19.TabIndex = 31;
            this.labelControl19.Text = "discount rate:";
            // 
            // nudDiscountRate
            // 
            this.nudDiscountRate.DecimalPlaces = 5;
            this.nudDiscountRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudDiscountRate.Location = new System.Drawing.Point(256, 175);
            this.nudDiscountRate.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudDiscountRate.Name = "nudDiscountRate";
            this.nudDiscountRate.Size = new System.Drawing.Size(251, 32);
            this.nudDiscountRate.TabIndex = 32;
            this.nudDiscountRate.ThousandsSeparator = true;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(189, 175);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(47, 26);
            this.labelControl20.TabIndex = 33;
            this.labelControl20.Text = "EGP";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(17, 110);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(147, 26);
            this.labelControl15.TabIndex = 28;
            this.labelControl15.Text = "Items discount:";
            // 
            // nudItemsDiscount
            // 
            this.nudItemsDiscount.DecimalPlaces = 5;
            this.nudItemsDiscount.Enabled = false;
            this.nudItemsDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudItemsDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudItemsDiscount.Location = new System.Drawing.Point(256, 110);
            this.nudItemsDiscount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudItemsDiscount.Name = "nudItemsDiscount";
            this.nudItemsDiscount.Size = new System.Drawing.Size(322, 32);
            this.nudItemsDiscount.TabIndex = 29;
            this.nudItemsDiscount.ThousandsSeparator = true;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(189, 110);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(47, 26);
            this.labelControl16.TabIndex = 30;
            this.labelControl16.Text = "EGP";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(17, 59);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(128, 26);
            this.labelControl13.TabIndex = 25;
            this.labelControl13.Text = "discount/unit:";
            // 
            // nudDiscountperUnit
            // 
            this.nudDiscountperUnit.DecimalPlaces = 5;
            this.nudDiscountperUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudDiscountperUnit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudDiscountperUnit.Location = new System.Drawing.Point(256, 59);
            this.nudDiscountperUnit.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudDiscountperUnit.Name = "nudDiscountperUnit";
            this.nudDiscountperUnit.Size = new System.Drawing.Size(322, 32);
            this.nudDiscountperUnit.TabIndex = 26;
            this.nudDiscountperUnit.ThousandsSeparator = true;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(189, 61);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(47, 26);
            this.labelControl14.TabIndex = 27;
            this.labelControl14.Text = "EGP";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelControl22);
            this.groupBox4.Controls.Add(this.nudTotalTaxableFees);
            this.groupBox4.Controls.Add(this.labelControl23);
            this.groupBox4.Controls.Add(this.labelControl10);
            this.groupBox4.Controls.Add(this.nudNetTotal);
            this.groupBox4.Controls.Add(this.labelControl9);
            this.groupBox4.Controls.Add(this.labelControl12);
            this.groupBox4.Controls.Add(this.labelControl11);
            this.groupBox4.Controls.Add(this.nudTotal);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(656, 648);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(666, 253);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Totals";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Location = new System.Drawing.Point(35, 60);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(176, 26);
            this.labelControl22.TabIndex = 31;
            this.labelControl22.Text = "Total taxable fees:";
            // 
            // nudTotalTaxableFees
            // 
            this.nudTotalTaxableFees.DecimalPlaces = 5;
            this.nudTotalTaxableFees.Enabled = false;
            this.nudTotalTaxableFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudTotalTaxableFees.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudTotalTaxableFees.Location = new System.Drawing.Point(295, 60);
            this.nudTotalTaxableFees.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudTotalTaxableFees.Name = "nudTotalTaxableFees";
            this.nudTotalTaxableFees.Size = new System.Drawing.Size(322, 32);
            this.nudTotalTaxableFees.TabIndex = 32;
            this.nudTotalTaxableFees.ThousandsSeparator = true;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Location = new System.Drawing.Point(227, 60);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(47, 26);
            this.labelControl23.TabIndex = 33;
            this.labelControl23.Text = "EGP";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddTax);
            this.groupBox5.Controls.Add(this.dgvTaxes);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox5.Location = new System.Drawing.Point(656, 85);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(861, 541);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Taxes";
            // 
            // btnAddTax
            // 
            this.btnAddTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAddTax.Image = global::Invoice_v1._0.Properties.Resources.invoice_add;
            this.btnAddTax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTax.Location = new System.Drawing.Point(664, 48);
            this.btnAddTax.Name = "btnAddTax";
            this.btnAddTax.Size = new System.Drawing.Size(191, 77);
            this.btnAddTax.TabIndex = 46;
            this.btnAddTax.Text = "Add Tax";
            this.btnAddTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTax.UseVisualStyleBackColor = true;
            this.btnAddTax.Click += new System.EventHandler(this.btnAddTax_Click);
            // 
            // dgvTaxes
            // 
            this.dgvTaxes.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaxes.Location = new System.Drawing.Point(23, 141);
            this.dgvTaxes.Name = "dgvTaxes";
            this.dgvTaxes.RowHeadersWidth = 62;
            this.dgvTaxes.RowTemplate.Height = 28;
            this.dgvTaxes.Size = new System.Drawing.Size(832, 361);
            this.dgvTaxes.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSave.Image = global::Invoice_v1._0.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(1373, 901);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 65);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmAddInvoiceLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 1001);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl3);
            this.Name = "frmAddInvoiceLine";
            this.Text = "frmAddInvoiceLine";
            this.Load += new System.EventHandler(this.frmAddInvoiceLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalesTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemsDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountperUnit)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalTaxableFees)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.ComboBoxEdit cmbItemType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbUnitType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.NumericUpDown nudSalesTotal;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.NumericUpDown nudNetTotal;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvTaxes;
        private System.Windows.Forms.Button btnAddTax;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.NumericUpDown nudDiscountperUnit;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.NumericUpDown nudItemsDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.NumericUpDown nudDiscountAmount;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private System.Windows.Forms.NumericUpDown nudDiscountRate;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private System.Windows.Forms.NumericUpDown nudTotalTaxableFees;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}