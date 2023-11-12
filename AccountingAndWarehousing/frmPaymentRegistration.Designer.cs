namespace AccountingAndWarehousing
{
    partial class frmPaymentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentRegistration));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.cmbSituation = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.txtDueDate = new Atf.UI.DateTimeSelector();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtDocumentNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtRegistrationDate = new Atf.UI.DateTimeSelector();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbAccountNumber = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPayer = new DevExpress.XtraEditors.TextEdit();
            this.txtAccountType = new DevExpress.XtraEditors.TextEdit();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PaymentDocumentErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.PaymentDocumentErrorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDocumentErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDocumentErrorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnInsertOrUpdate);
            this.groupControl1.Controls.Add(this.cmbSituation);
            this.groupControl1.Controls.Add(this.txtCustomerName);
            this.groupControl1.Controls.Add(this.txtDueDate);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtDocumentNumber);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtRegistrationDate);
            this.groupControl1.Controls.Add(this.txtAmount);
            this.groupControl1.Controls.Add(this.cmbAccountNumber);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.txtPayer);
            this.groupControl1.Controls.Add(this.txtAccountType);
            this.groupControl1.Controls.Add(this.txtBankName);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(752, 370);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "ورود اطلاعات ثبت";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(254, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 39);
            this.btnCancel.TabIndex = 75;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertOrUpdate
            // 
            this.btnInsertOrUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInsertOrUpdate.ImageOptions.SvgImage")));
            this.btnInsertOrUpdate.Location = new System.Drawing.Point(369, 321);
            this.btnInsertOrUpdate.Name = "btnInsertOrUpdate";
            this.btnInsertOrUpdate.Size = new System.Drawing.Size(109, 39);
            this.btnInsertOrUpdate.TabIndex = 74;
            this.btnInsertOrUpdate.Text = "ثبت";
            this.btnInsertOrUpdate.Click += new System.EventHandler(this.btnInsertOrUpdate_Click);
            // 
            // cmbSituation
            // 
            this.cmbSituation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSituation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituation.FormattingEnabled = true;
            this.cmbSituation.Items.AddRange(new object[] {
            "عدم وصول",
            "وصول شده",
            "برگشت خورده"});
            this.cmbSituation.Location = new System.Drawing.Point(27, 182);
            this.cmbSituation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSituation.Name = "cmbSituation";
            this.cmbSituation.Size = new System.Drawing.Size(237, 24);
            this.cmbSituation.TabIndex = 73;
            this.cmbSituation.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSituation_Validating);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(398, 182);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(238, 22);
            this.txtCustomerName.TabIndex = 72;
            this.txtCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerName_Validating);
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(27, 152);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDueDate.Size = new System.Drawing.Size(238, 24);
            this.txtDueDate.TabIndex = 71;
            this.txtDueDate.UsePersianFormat = true;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(271, 156);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(92, 17);
            this.labelControl12.TabIndex = 70;
            this.labelControl12.Text = "تاریخ سررسید: ";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(398, 124);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(238, 22);
            this.txtDocumentNumber.TabIndex = 69;
            this.txtDocumentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentNumber_KeyPress);
            this.txtDocumentNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtDocumentNumber_Validating);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(642, 182);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(67, 17);
            this.labelControl11.TabIndex = 68;
            this.labelControl11.Text = "پرداخت به: ";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(642, 130);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(79, 17);
            this.labelControl10.TabIndex = 67;
            this.labelControl10.Text = "شماره سند: ";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(272, 185);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(51, 17);
            this.labelControl9.TabIndex = 66;
            this.labelControl9.Text = "وضعیت: ";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(27, 124);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(22, 17);
            this.labelControl8.TabIndex = 65;
            this.labelControl8.Text = "ریال";
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Location = new System.Drawing.Point(398, 149);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegistrationDate.Size = new System.Drawing.Size(238, 24);
            this.txtRegistrationDate.TabIndex = 61;
            this.txtRegistrationDate.UsePersianFormat = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(57, 122);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Maximum = new decimal(new int[] {
            1215752182,
            23,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(208, 23);
            this.txtAmount.TabIndex = 64;
            this.txtAmount.ThousandsSeparator = true;
            // 
            // cmbAccountNumber
            // 
            this.cmbAccountNumber.Location = new System.Drawing.Point(398, 68);
            this.cmbAccountNumber.Name = "cmbAccountNumber";
            this.cmbAccountNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAccountNumber.Properties.ImmediatePopup = true;
            this.cmbAccountNumber.Properties.NullText = "";
            this.cmbAccountNumber.Properties.PopupView = this.gridLookUpEdit1View;
            this.cmbAccountNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbAccountNumber.Size = new System.Drawing.Size(238, 22);
            this.cmbAccountNumber.TabIndex = 63;
            this.cmbAccountNumber.EditValueChanged += new System.EventHandler(this.cmbAccountNumber_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(27, 213);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(609, 102);
            this.txtDescription.TabIndex = 62;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // txtPayer
            // 
            this.txtPayer.Location = new System.Drawing.Point(27, 93);
            this.txtPayer.Name = "txtPayer";
            this.txtPayer.Properties.ReadOnly = true;
            this.txtPayer.Size = new System.Drawing.Size(238, 22);
            this.txtPayer.TabIndex = 60;
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(27, 65);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Properties.ReadOnly = true;
            this.txtAccountType.Size = new System.Drawing.Size(238, 22);
            this.txtAccountType.TabIndex = 59;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(398, 96);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.ReadOnly = true;
            this.txtBankName.Size = new System.Drawing.Size(238, 22);
            this.txtBankName.TabIndex = 58;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(642, 156);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 17);
            this.labelControl7.TabIndex = 57;
            this.labelControl7.Text = "تاریخ ثبت: ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(642, 216);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 17);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "توضیحات: ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(272, 124);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 17);
            this.labelControl5.TabIndex = 55;
            this.labelControl5.Text = "مبلغ: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(271, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 17);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "نام پرداخت کننده: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(642, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 17);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "نام بانک: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(271, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "نوع حساب: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(642, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 17);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "شماره حساب: ";
            // 
            // PaymentDocumentErrorProvider
            // 
            this.PaymentDocumentErrorProvider.ContainerControl = this;
            // 
            // PaymentDocumentErrorProvider2
            // 
            this.PaymentDocumentErrorProvider2.ContainerControl = this;
            // 
            // frmPaymentRegistration
            // 
            this.AcceptButton = this.btnInsertOrUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 370);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmPaymentRegistration.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaymentRegistration";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت اسناد پرداختی";
            this.Load += new System.EventHandler(this.frmPaymentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDocumentErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDocumentErrorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private Atf.UI.DateTimeSelector txtDueDate;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtDocumentNumber;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Atf.UI.DateTimeSelector txtRegistrationDate;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private DevExpress.XtraEditors.GridLookUpEdit cmbAccountNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.TextEdit txtPayer;
        private DevExpress.XtraEditors.TextEdit txtAccountType;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnInsertOrUpdate;
        private System.Windows.Forms.ComboBox cmbSituation;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider PaymentDocumentErrorProvider;
        private System.Windows.Forms.ErrorProvider PaymentDocumentErrorProvider2;
    }
}