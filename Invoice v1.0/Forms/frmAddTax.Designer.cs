namespace Invoice_v1._0.Forms
{
    partial class frmAddTax
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
            this.nudTaxRate = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTaxType = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTaxSubType = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.nudTaxAmount = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTaxRate
            // 
            this.nudTaxRate.DecimalPlaces = 5;
            this.nudTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudTaxRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudTaxRate.Location = new System.Drawing.Point(846, 179);
            this.nudTaxRate.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudTaxRate.Name = "nudTaxRate";
            this.nudTaxRate.Size = new System.Drawing.Size(189, 32);
            this.nudTaxRate.TabIndex = 34;
            this.nudTaxRate.ThousandsSeparator = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(181, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 26);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Type";
            // 
            // cmbTaxType
            // 
            this.cmbTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbTaxType.FormattingEnabled = true;
            this.cmbTaxType.Location = new System.Drawing.Point(26, 179);
            this.cmbTaxType.Name = "cmbTaxType";
            this.cmbTaxType.Size = new System.Drawing.Size(356, 34);
            this.cmbTaxType.TabIndex = 33;
            this.cmbTaxType.SelectionChangeCommitted += new System.EventHandler(this.CmbTaxType_SelectionChangeCommitted);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(673, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(149, 51);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "Add tax";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(571, 136);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 26);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "SubType";
            // 
            // cmbTaxSubType
            // 
            this.cmbTaxSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaxSubType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbTaxSubType.FormattingEnabled = true;
            this.cmbTaxSubType.Location = new System.Drawing.Point(436, 179);
            this.cmbTaxSubType.Name = "cmbTaxSubType";
            this.cmbTaxSubType.Size = new System.Drawing.Size(356, 34);
            this.cmbTaxSubType.TabIndex = 37;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(917, 136);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 26);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Rate";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(1145, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 26);
            this.labelControl5.TabIndex = 40;
            this.labelControl5.Text = "Amount";
            // 
            // nudTaxAmount
            // 
            this.nudTaxAmount.DecimalPlaces = 5;
            this.nudTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudTaxAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudTaxAmount.Location = new System.Drawing.Point(1089, 179);
            this.nudTaxAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudTaxAmount.Name = "nudTaxAmount";
            this.nudTaxAmount.Size = new System.Drawing.Size(189, 32);
            this.nudTaxAmount.TabIndex = 39;
            this.nudTaxAmount.ThousandsSeparator = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSave.Image = global::Invoice_v1._0.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(1250, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 65);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 337);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.nudTaxAmount);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbTaxSubType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.nudTaxRate);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbTaxType);
            this.Name = "frmAddTax";
            this.Text = "Add Tax";
            this.Load += new System.EventHandler(this.frmAddTax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTaxRate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbTaxType;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbTaxSubType;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown nudTaxAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}