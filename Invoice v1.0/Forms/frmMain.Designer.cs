namespace Invoice_v1._0
{
    partial class frmMain
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
            this.btnFindINvoice = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNewInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindINvoice
            // 
            this.btnFindINvoice.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFindINvoice.Appearance.BorderColor = System.Drawing.Color.Navy;
            this.btnFindINvoice.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnFindINvoice.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFindINvoice.Appearance.Options.UseBackColor = true;
            this.btnFindINvoice.Appearance.Options.UseBorderColor = true;
            this.btnFindINvoice.Appearance.Options.UseFont = true;
            this.btnFindINvoice.Appearance.Options.UseForeColor = true;
            this.btnFindINvoice.Location = new System.Drawing.Point(377, 328);
            this.btnFindINvoice.Name = "btnFindINvoice";
            this.btnFindINvoice.Size = new System.Drawing.Size(237, 130);
            this.btnFindINvoice.TabIndex = 1;
            this.btnFindINvoice.Text = "Print Invoice";
            this.btnFindINvoice.Click += new System.EventHandler(this.btnFindINvoice_Click);
            // 
            // btnAddNewInvoice
            // 
            this.btnAddNewInvoice.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddNewInvoice.Appearance.BorderColor = System.Drawing.Color.Navy;
            this.btnAddNewInvoice.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewInvoice.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNewInvoice.Appearance.Options.UseBackColor = true;
            this.btnAddNewInvoice.Appearance.Options.UseBorderColor = true;
            this.btnAddNewInvoice.Appearance.Options.UseFont = true;
            this.btnAddNewInvoice.Appearance.Options.UseForeColor = true;
            this.btnAddNewInvoice.Location = new System.Drawing.Point(376, 146);
            this.btnAddNewInvoice.Name = "btnAddNewInvoice";
            this.btnAddNewInvoice.Size = new System.Drawing.Size(238, 130);
            this.btnAddNewInvoice.TabIndex = 2;
            this.btnAddNewInvoice.Text = "New Invoice";
            this.btnAddNewInvoice.Click += new System.EventHandler(this.btnAddNewInvoice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Invoice_v1._0.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 603);
            this.Controls.Add(this.btnAddNewInvoice);
            this.Controls.Add(this.btnFindINvoice);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Invoice v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnFindINvoice;
        private DevExpress.XtraEditors.SimpleButton btnAddNewInvoice;
    }
}

