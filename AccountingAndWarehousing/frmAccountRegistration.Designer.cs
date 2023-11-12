namespace AccountingAndWarehousing
{
    partial class frmAccountRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountRegistration));
            this.grpEnterFinancialAcc = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.lblBalance = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtBalance = new System.Windows.Forms.NumericUpDown();
            this.lblAccountNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountType = new DevExpress.XtraEditors.TextEdit();
            this.txtAccountOwner = new DevExpress.XtraEditors.TextEdit();
            this.lblAccountType = new DevExpress.XtraEditors.LabelControl();
            this.lblBankName = new DevExpress.XtraEditors.LabelControl();
            this.lblAccountOwner = new DevExpress.XtraEditors.LabelControl();
            this.FinancialAccountErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grpEnterFinancialAcc)).BeginInit();
            this.grpEnterFinancialAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialAccountErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEnterFinancialAcc
            // 
            this.grpEnterFinancialAcc.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpEnterFinancialAcc.CaptionImageOptions.SvgImage")));
            this.grpEnterFinancialAcc.Controls.Add(this.labelControl1);
            this.grpEnterFinancialAcc.Controls.Add(this.txtDescription);
            this.grpEnterFinancialAcc.Controls.Add(this.txtBankName);
            this.grpEnterFinancialAcc.Controls.Add(this.btnCancel);
            this.grpEnterFinancialAcc.Controls.Add(this.btnInsertOrUpdate);
            this.grpEnterFinancialAcc.Controls.Add(this.lblDescription);
            this.grpEnterFinancialAcc.Controls.Add(this.lblBalance);
            this.grpEnterFinancialAcc.Controls.Add(this.txtAccountNumber);
            this.grpEnterFinancialAcc.Controls.Add(this.txtBalance);
            this.grpEnterFinancialAcc.Controls.Add(this.lblAccountNumber);
            this.grpEnterFinancialAcc.Controls.Add(this.txtAccountType);
            this.grpEnterFinancialAcc.Controls.Add(this.txtAccountOwner);
            this.grpEnterFinancialAcc.Controls.Add(this.lblAccountType);
            this.grpEnterFinancialAcc.Controls.Add(this.lblBankName);
            this.grpEnterFinancialAcc.Controls.Add(this.lblAccountOwner);
            this.grpEnterFinancialAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEnterFinancialAcc.Location = new System.Drawing.Point(0, 0);
            this.grpEnterFinancialAcc.Name = "grpEnterFinancialAcc";
            this.grpEnterFinancialAcc.Size = new System.Drawing.Size(659, 325);
            this.grpEnterFinancialAcc.TabIndex = 1;
            this.grpEnterFinancialAcc.Text = "ورود اطلاعات حساب های مالی";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(20, 131);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 17);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "ریال";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(20, 159);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(519, 92);
            this.txtDescription.TabIndex = 67;
            // 
            // txtBankName
            // 
            this.txtBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankName.Location = new System.Drawing.Point(20, 98);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtBankName.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtBankName.Properties.MaxLength = 50;
            this.txtBankName.Size = new System.Drawing.Size(200, 22);
            this.txtBankName.TabIndex = 66;
            this.txtBankName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBankName_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(204, 270);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 38);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertOrUpdate
            // 
            this.btnInsertOrUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertOrUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInsertOrUpdate.ImageOptions.SvgImage")));
            this.btnInsertOrUpdate.Location = new System.Drawing.Point(330, 270);
            this.btnInsertOrUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertOrUpdate.Name = "btnInsertOrUpdate";
            this.btnInsertOrUpdate.Size = new System.Drawing.Size(118, 38);
            this.btnInsertOrUpdate.TabIndex = 63;
            this.btnInsertOrUpdate.Text = "ثبت";
            this.btnInsertOrUpdate.Click += new System.EventHandler(this.btnInsertOrUpdate_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Location = new System.Drawing.Point(547, 162);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 17);
            this.lblDescription.TabIndex = 61;
            this.lblDescription.Text = "توضیحات: ";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.Location = new System.Drawing.Point(223, 131);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(99, 17);
            this.lblBalance.TabIndex = 59;
            this.lblBalance.Text = "موجودی حساب: ";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountNumber.Location = new System.Drawing.Point(344, 128);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtAccountNumber.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtAccountNumber.Properties.MaxLength = 20;
            this.txtAccountNumber.Size = new System.Drawing.Size(195, 22);
            this.txtAccountNumber.TabIndex = 58;
            this.txtAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNumber_KeyPress);
            this.txtAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountNumber_Validating);
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBalance.Location = new System.Drawing.Point(50, 129);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalance.Maximum = new decimal(new int[] {
            1215752182,
            23,
            0,
            0});
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(165, 23);
            this.txtBalance.TabIndex = 47;
            this.txtBalance.ThousandsSeparator = true;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountNumber.Location = new System.Drawing.Point(547, 131);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(91, 17);
            this.lblAccountNumber.TabIndex = 57;
            this.lblAccountNumber.Text = "شماره حساب: ";
            // 
            // txtAccountType
            // 
            this.txtAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountType.Location = new System.Drawing.Point(344, 98);
            this.txtAccountType.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtAccountType.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtAccountType.Properties.MaxLength = 50;
            this.txtAccountType.Size = new System.Drawing.Size(195, 22);
            this.txtAccountType.TabIndex = 46;
            this.txtAccountType.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountType_Validating);
            // 
            // txtAccountOwner
            // 
            this.txtAccountOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountOwner.Location = new System.Drawing.Point(269, 68);
            this.txtAccountOwner.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountOwner.Name = "txtAccountOwner";
            this.txtAccountOwner.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtAccountOwner.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtAccountOwner.Properties.MaxLength = 100;
            this.txtAccountOwner.Size = new System.Drawing.Size(270, 22);
            this.txtAccountOwner.TabIndex = 45;
            this.txtAccountOwner.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountOwner_Validating);
            // 
            // lblAccountType
            // 
            this.lblAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountType.Location = new System.Drawing.Point(547, 100);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(4);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(70, 17);
            this.lblAccountType.TabIndex = 53;
            this.lblAccountType.Text = "نوع حساب: ";
            // 
            // lblBankName
            // 
            this.lblBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankName.Location = new System.Drawing.Point(228, 100);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(4);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(55, 17);
            this.lblBankName.TabIndex = 52;
            this.lblBankName.Text = "نام بانک: ";
            // 
            // lblAccountOwner
            // 
            this.lblAccountOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountOwner.Location = new System.Drawing.Point(547, 71);
            this.lblAccountOwner.Margin = new System.Windows.Forms.Padding(4);
            this.lblAccountOwner.Name = "lblAccountOwner";
            this.lblAccountOwner.Size = new System.Drawing.Size(89, 17);
            this.lblAccountOwner.TabIndex = 50;
            this.lblAccountOwner.Text = "صاحب حساب: ";
            // 
            // FinancialAccountErrorProvider
            // 
            this.FinancialAccountErrorProvider.ContainerControl = this;
            // 
            // frmAccountRegistration
            // 
            this.AcceptButton = this.btnInsertOrUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 325);
            this.Controls.Add(this.grpEnterFinancialAcc);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmAccountRegistration.IconOptions.SvgImage")));
            this.Name = "frmAccountRegistration";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت حساب های مالی";
            this.Load += new System.EventHandler(this.frmAccountRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpEnterFinancialAcc)).EndInit();
            this.grpEnterFinancialAcc.ResumeLayout(false);
            this.grpEnterFinancialAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinancialAccountErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpEnterFinancialAcc;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnInsertOrUpdate;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.LabelControl lblBalance;
        private DevExpress.XtraEditors.TextEdit txtAccountNumber;
        private System.Windows.Forms.NumericUpDown txtBalance;
        private DevExpress.XtraEditors.LabelControl lblAccountNumber;
        private DevExpress.XtraEditors.TextEdit txtAccountType;
        private DevExpress.XtraEditors.TextEdit txtAccountOwner;
        private DevExpress.XtraEditors.LabelControl lblAccountType;
        private DevExpress.XtraEditors.LabelControl lblBankName;
        private DevExpress.XtraEditors.LabelControl lblAccountOwner;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider FinancialAccountErrorProvider;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}