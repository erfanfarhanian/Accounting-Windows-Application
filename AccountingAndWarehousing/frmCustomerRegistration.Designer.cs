namespace AccountingAndWarehousing
{
    partial class frmCustomerRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRegistration));
            this.grpGoodsRegistration = new DevExpress.XtraEditors.GroupControl();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lblDept = new DevExpress.XtraEditors.LabelControl();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.lblTel = new DevExpress.XtraEditors.LabelControl();
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.btnShowCustomerTypeForm = new DevExpress.XtraEditors.SimpleButton();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.lblLastName = new DevExpress.XtraEditors.LabelControl();
            this.lblMobile = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomerType = new DevExpress.XtraEditors.LabelControl();
            this.lblFirstName = new DevExpress.XtraEditors.LabelControl();
            this.CustomerErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.txtAddrress = new System.Windows.Forms.TextBox();
            this.CustomerErrorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grpGoodsRegistration)).BeginInit();
            this.grpGoodsRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerErrorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGoodsRegistration
            // 
            this.grpGoodsRegistration.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpGoodsRegistration.CaptionImageOptions.SvgImage")));
            this.grpGoodsRegistration.Controls.Add(this.txtAddrress);
            this.grpGoodsRegistration.Controls.Add(this.txtMobile);
            this.grpGoodsRegistration.Controls.Add(this.btnCancel);
            this.grpGoodsRegistration.Controls.Add(this.btnInsertOrUpdate);
            this.grpGoodsRegistration.Controls.Add(this.lblDept);
            this.grpGoodsRegistration.Controls.Add(this.txtTel);
            this.grpGoodsRegistration.Controls.Add(this.lblTel);
            this.grpGoodsRegistration.Controls.Add(this.cmbCustomerType);
            this.grpGoodsRegistration.Controls.Add(this.btnShowCustomerTypeForm);
            this.grpGoodsRegistration.Controls.Add(this.txtLastName);
            this.grpGoodsRegistration.Controls.Add(this.txtFirstName);
            this.grpGoodsRegistration.Controls.Add(this.lblLastName);
            this.grpGoodsRegistration.Controls.Add(this.lblMobile);
            this.grpGoodsRegistration.Controls.Add(this.lblCustomerType);
            this.grpGoodsRegistration.Controls.Add(this.lblFirstName);
            this.grpGoodsRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGoodsRegistration.Location = new System.Drawing.Point(0, 0);
            this.grpGoodsRegistration.Name = "grpGoodsRegistration";
            this.grpGoodsRegistration.Size = new System.Drawing.Size(641, 314);
            this.grpGoodsRegistration.TabIndex = 1;
            this.grpGoodsRegistration.Text = "ثبت اطلاعات مشتری";
            this.grpGoodsRegistration.Paint += new System.Windows.Forms.PaintEventHandler(this.grpGoodsRegistration_Paint);
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.Location = new System.Drawing.Point(17, 129);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtMobile.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMobile.Properties.MaxLength = 11;
            this.txtMobile.Size = new System.Drawing.Size(195, 22);
            this.txtMobile.TabIndex = 66;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            this.txtMobile.Validating += new System.ComponentModel.CancelEventHandler(this.txtMobile_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(185, 263);
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
            this.btnInsertOrUpdate.Location = new System.Drawing.Point(311, 263);
            this.btnInsertOrUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertOrUpdate.Name = "btnInsertOrUpdate";
            this.btnInsertOrUpdate.Size = new System.Drawing.Size(118, 38);
            this.btnInsertOrUpdate.TabIndex = 63;
            this.btnInsertOrUpdate.Text = "ثبت";
            this.btnInsertOrUpdate.Click += new System.EventHandler(this.btnInsertOrUpdate_Click);
            // 
            // lblDept
            // 
            this.lblDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDept.Location = new System.Drawing.Point(543, 159);
            this.lblDept.Margin = new System.Windows.Forms.Padding(4);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(41, 17);
            this.lblDept.TabIndex = 59;
            this.lblDept.Text = "آدرس: ";
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Location = new System.Drawing.Point(340, 127);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtTel.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTel.Properties.MaxLength = 11;
            this.txtTel.Size = new System.Drawing.Size(195, 22);
            this.txtTel.TabIndex = 58;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            this.txtTel.Validating += new System.ComponentModel.CancelEventHandler(this.txtTel_Validating);
            // 
            // lblTel
            // 
            this.lblTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTel.Location = new System.Drawing.Point(543, 128);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(65, 17);
            this.lblTel.TabIndex = 57;
            this.lblTel.Text = "تلفن ثابت: ";
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Location = new System.Drawing.Point(342, 67);
            this.cmbCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(193, 24);
            this.cmbCustomerType.TabIndex = 48;
            // 
            // btnShowCustomerTypeForm
            // 
            this.btnShowCustomerTypeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowCustomerTypeForm.Location = new System.Drawing.Point(293, 66);
            this.btnShowCustomerTypeForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCustomerTypeForm.Name = "btnShowCustomerTypeForm";
            this.btnShowCustomerTypeForm.Size = new System.Drawing.Size(41, 23);
            this.btnShowCustomerTypeForm.TabIndex = 55;
            this.btnShowCustomerTypeForm.Text = "...";
            this.btnShowCustomerTypeForm.Click += new System.EventHandler(this.btnShowCustomerTypeForm_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(17, 99);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtLastName.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtLastName.Properties.MaxLength = 50;
            this.txtLastName.Size = new System.Drawing.Size(195, 22);
            this.txtLastName.TabIndex = 46;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(340, 99);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtFirstName.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtFirstName.Properties.MaxLength = 100;
            this.txtFirstName.Size = new System.Drawing.Size(195, 22);
            this.txtFirstName.TabIndex = 45;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.Location = new System.Drawing.Point(220, 102);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 17);
            this.lblLastName.TabIndex = 53;
            this.lblLastName.Text = "نام خانوادگی: ";
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMobile.Location = new System.Drawing.Point(220, 132);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(4);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(74, 17);
            this.lblMobile.TabIndex = 52;
            this.lblMobile.Text = "تلفن همراه: ";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerType.Location = new System.Drawing.Point(543, 70);
            this.lblCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(76, 17);
            this.lblCustomerType.TabIndex = 51;
            this.lblCustomerType.Text = "نوع مشتری: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.Location = new System.Drawing.Point(543, 101);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(25, 17);
            this.lblFirstName.TabIndex = 50;
            this.lblFirstName.Text = "نام: ";
            // 
            // CustomerErrorProvider
            // 
            this.CustomerErrorProvider.ContainerControl = this;
            // 
            // txtAddrress
            // 
            this.txtAddrress.Location = new System.Drawing.Point(17, 156);
            this.txtAddrress.Multiline = true;
            this.txtAddrress.Name = "txtAddrress";
            this.txtAddrress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddrress.Size = new System.Drawing.Size(519, 100);
            this.txtAddrress.TabIndex = 67;
            this.txtAddrress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddrress_Validating);
            // 
            // CustomerErrorProvider2
            // 
            this.CustomerErrorProvider2.ContainerControl = this;
            // 
            // frmCustomerRegistration
            // 
            this.AcceptButton = this.btnInsertOrUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 314);
            this.Controls.Add(this.grpGoodsRegistration);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmCustomerRegistration.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerRegistration";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت مشتری";
            this.Load += new System.EventHandler(this.frmCustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpGoodsRegistration)).EndInit();
            this.grpGoodsRegistration.ResumeLayout(false);
            this.grpGoodsRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerErrorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpGoodsRegistration;
        private DevExpress.XtraEditors.TextEdit txtMobile;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnInsertOrUpdate;
        private DevExpress.XtraEditors.LabelControl lblDept;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.LabelControl lblTel;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private DevExpress.XtraEditors.SimpleButton btnShowCustomerTypeForm;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.LabelControl lblLastName;
        private DevExpress.XtraEditors.LabelControl lblMobile;
        private DevExpress.XtraEditors.LabelControl lblCustomerType;
        private DevExpress.XtraEditors.LabelControl lblFirstName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider CustomerErrorProvider;
        private System.Windows.Forms.TextBox txtAddrress;
        private System.Windows.Forms.ErrorProvider CustomerErrorProvider2;
    }
}