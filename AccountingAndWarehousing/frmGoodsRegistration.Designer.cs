namespace AccountingAndWarehousing
{
    partial class frmGoodsRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsRegistration));
            this.grpGoodsRegistration = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtUnit = new DevExpress.XtraEditors.TextEdit();
            this.txtUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.lblUnit = new DevExpress.XtraEditors.LabelControl();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.cmbGrouping = new System.Windows.Forms.ComboBox();
            this.btnShowProductGroupForm = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.lblProductImage = new DevExpress.XtraEditors.LabelControl();
            this.txtProductCode = new DevExpress.XtraEditors.TextEdit();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.lblProductCode = new DevExpress.XtraEditors.LabelControl();
            this.lblUnitPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblProductGroup = new DevExpress.XtraEditors.LabelControl();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.imgOpenFile = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.ProductErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.btnShowWarehouseForm = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpGoodsRegistration)).BeginInit();
            this.grpGoodsRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGoodsRegistration
            // 
            this.grpGoodsRegistration.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpGoodsRegistration.CaptionImageOptions.SvgImage")));
            this.grpGoodsRegistration.Controls.Add(this.cmbWarehouse);
            this.grpGoodsRegistration.Controls.Add(this.btnShowWarehouseForm);
            this.grpGoodsRegistration.Controls.Add(this.labelControl2);
            this.grpGoodsRegistration.Controls.Add(this.labelControl1);
            this.grpGoodsRegistration.Controls.Add(this.btnCancel);
            this.grpGoodsRegistration.Controls.Add(this.btnInsertOrUpdate);
            this.grpGoodsRegistration.Controls.Add(this.txtUnit);
            this.grpGoodsRegistration.Controls.Add(this.txtUnitPrice);
            this.grpGoodsRegistration.Controls.Add(this.lblUnit);
            this.grpGoodsRegistration.Controls.Add(this.picBox);
            this.grpGoodsRegistration.Controls.Add(this.cmbGrouping);
            this.grpGoodsRegistration.Controls.Add(this.btnShowProductGroupForm);
            this.grpGoodsRegistration.Controls.Add(this.btnBrowse);
            this.grpGoodsRegistration.Controls.Add(this.lblProductImage);
            this.grpGoodsRegistration.Controls.Add(this.txtProductCode);
            this.grpGoodsRegistration.Controls.Add(this.txtProductName);
            this.grpGoodsRegistration.Controls.Add(this.lblProductCode);
            this.grpGoodsRegistration.Controls.Add(this.lblUnitPrice);
            this.grpGoodsRegistration.Controls.Add(this.lblProductGroup);
            this.grpGoodsRegistration.Controls.Add(this.lblProductName);
            this.grpGoodsRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGoodsRegistration.Location = new System.Drawing.Point(0, 0);
            this.grpGoodsRegistration.Name = "grpGoodsRegistration";
            this.grpGoodsRegistration.Size = new System.Drawing.Size(703, 321);
            this.grpGoodsRegistration.TabIndex = 0;
            this.grpGoodsRegistration.Text = "ثبت اطلاعات کالا";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(382, 196);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 17);
            this.labelControl1.TabIndex = 69;
            this.labelControl1.Text = "ریال";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(221, 275);
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
            this.btnInsertOrUpdate.Location = new System.Drawing.Point(363, 275);
            this.btnInsertOrUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertOrUpdate.Name = "btnInsertOrUpdate";
            this.btnInsertOrUpdate.Size = new System.Drawing.Size(118, 38);
            this.btnInsertOrUpdate.TabIndex = 63;
            this.btnInsertOrUpdate.Text = "ثبت";
            this.btnInsertOrUpdate.Click += new System.EventHandler(this.btnInsertOrUpdate_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnit.Location = new System.Drawing.Point(382, 154);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtUnit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUnit.Properties.MaxLength = 50;
            this.txtUnit.Size = new System.Drawing.Size(195, 22);
            this.txtUnit.TabIndex = 58;
            this.txtUnit.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnit_Validating);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitPrice.Location = new System.Drawing.Point(412, 194);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(165, 23);
            this.txtUnitPrice.TabIndex = 47;
            this.txtUnitPrice.ThousandsSeparator = true;
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit.Location = new System.Drawing.Point(598, 157);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(39, 17);
            this.lblUnit.TabIndex = 57;
            this.lblUnit.Text = "واحد : ";
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Location = new System.Drawing.Point(117, 181);
            this.picBox.Margin = new System.Windows.Forms.Padding(4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(117, 86);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 56;
            this.picBox.TabStop = false;
            // 
            // cmbGrouping
            // 
            this.cmbGrouping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGrouping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrouping.FormattingEnabled = true;
            this.cmbGrouping.Location = new System.Drawing.Point(74, 69);
            this.cmbGrouping.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrouping.Name = "cmbGrouping";
            this.cmbGrouping.Size = new System.Drawing.Size(160, 24);
            this.cmbGrouping.TabIndex = 48;
            // 
            // btnShowProductGroupForm
            // 
            this.btnShowProductGroupForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowProductGroupForm.Location = new System.Drawing.Point(17, 69);
            this.btnShowProductGroupForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowProductGroupForm.Name = "btnShowProductGroupForm";
            this.btnShowProductGroupForm.Size = new System.Drawing.Size(41, 23);
            this.btnShowProductGroupForm.TabIndex = 55;
            this.btnShowProductGroupForm.Text = "...";
            this.btnShowProductGroupForm.Click += new System.EventHandler(this.btnShowProductGroupForm_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(137, 145);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(97, 28);
            this.btnBrowse.TabIndex = 49;
            this.btnBrowse.Text = "انتخاب ...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblProductImage
            // 
            this.lblProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductImage.Location = new System.Drawing.Point(262, 151);
            this.lblProductImage.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(40, 17);
            this.lblProductImage.TabIndex = 54;
            this.lblProductImage.Text = "تصویر :";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCode.Location = new System.Drawing.Point(382, 107);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtProductCode.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtProductCode.Properties.MaxLength = 50;
            this.txtProductCode.Size = new System.Drawing.Size(195, 22);
            this.txtProductCode.TabIndex = 46;
            this.txtProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
            this.txtProductCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtProductCode_Validating);
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductName.Location = new System.Drawing.Point(382, 67);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtProductName.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtProductName.Properties.MaxLength = 100;
            this.txtProductName.Size = new System.Drawing.Size(195, 22);
            this.txtProductName.TabIndex = 45;
            this.txtProductName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblProductCode
            // 
            this.lblProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductCode.Location = new System.Drawing.Point(598, 110);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(71, 17);
            this.lblProductCode.TabIndex = 53;
            this.lblProductCode.Text = "کد محصول :";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitPrice.Location = new System.Drawing.Point(598, 196);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(72, 17);
            this.lblUnitPrice.TabIndex = 52;
            this.lblUnitPrice.Text = "قیمت واحد :";
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductGroup.Location = new System.Drawing.Point(263, 72);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(76, 17);
            this.lblProductGroup.TabIndex = 51;
            this.lblProductGroup.Text = "دسته بندی :";
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductName.Location = new System.Drawing.Point(598, 71);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(72, 17);
            this.lblProductName.TabIndex = 50;
            this.lblProductName.Text = "نام محصول :";
            // 
            // imgOpenFile
            // 
            this.imgOpenFile.DefaultExt = "*.jpg";
            this.imgOpenFile.Filter = "JPG Files|*.JPG|PNG Files|*.PNG";
            this.imgOpenFile.InitialDirectory = "C:\\";
            this.imgOpenFile.Title = "انتخاب تصویر";
            // 
            // ProductErrorProvider
            // 
            this.ProductErrorProvider.ContainerControl = this;
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(74, 107);
            this.cmbWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(160, 24);
            this.cmbWarehouse.TabIndex = 70;
            // 
            // btnShowWarehouseForm
            // 
            this.btnShowWarehouseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowWarehouseForm.Location = new System.Drawing.Point(17, 107);
            this.btnShowWarehouseForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowWarehouseForm.Name = "btnShowWarehouseForm";
            this.btnShowWarehouseForm.Size = new System.Drawing.Size(41, 23);
            this.btnShowWarehouseForm.TabIndex = 72;
            this.btnShowWarehouseForm.Text = "...";
            this.btnShowWarehouseForm.Click += new System.EventHandler(this.btnShowWarehouseForm_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(263, 110);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 17);
            this.labelControl2.TabIndex = 71;
            this.labelControl2.Text = "انبار: ";
            // 
            // frmGoodsRegistration
            // 
            this.AcceptButton = this.btnInsertOrUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 321);
            this.Controls.Add(this.grpGoodsRegistration);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmGoodsRegistration.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGoodsRegistration";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت کالا";
            this.Load += new System.EventHandler(this.frmGoodsRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpGoodsRegistration)).EndInit();
            this.grpGoodsRegistration.ResumeLayout(false);
            this.grpGoodsRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpGoodsRegistration;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnInsertOrUpdate;
        private DevExpress.XtraEditors.LabelControl lblUnit;
        private DevExpress.XtraEditors.SimpleButton btnShowProductGroupForm;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.LabelControl lblProductImage;
        private DevExpress.XtraEditors.LabelControl lblProductCode;
        private DevExpress.XtraEditors.LabelControl lblUnitPrice;
        private DevExpress.XtraEditors.LabelControl lblProductGroup;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.XtraOpenFileDialog imgOpenFile;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ProductErrorProvider;
        public System.Windows.Forms.PictureBox picBox;
        private DevExpress.XtraEditors.TextEdit txtUnit;
        private System.Windows.Forms.NumericUpDown txtUnitPrice;
        private System.Windows.Forms.ComboBox cmbGrouping;
        private DevExpress.XtraEditors.TextEdit txtProductCode;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private DevExpress.XtraEditors.SimpleButton btnShowWarehouseForm;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}