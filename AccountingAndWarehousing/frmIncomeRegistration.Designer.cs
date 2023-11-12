namespace AccountingAndWarehousing
{
    partial class frmIncomeRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncomeRegistration));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtIncomeDate = new Atf.UI.DateTimeSelector();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbAccountNumber = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDepositor = new DevExpress.XtraEditors.TextEdit();
            this.txtAccountType = new DevExpress.XtraEditors.TextEdit();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.IncomeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepositor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnInsertOrUpdate);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtIncomeDate);
            this.groupControl1.Controls.Add(this.txtAmount);
            this.groupControl1.Controls.Add(this.cmbAccountNumber);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.txtDepositor);
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
            this.groupControl1.Size = new System.Drawing.Size(748, 311);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ثبت اطلاعات درآمد";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(256, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 39);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertOrUpdate
            // 
            this.btnInsertOrUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInsertOrUpdate.ImageOptions.SvgImage")));
            this.btnInsertOrUpdate.Location = new System.Drawing.Point(371, 257);
            this.btnInsertOrUpdate.Name = "btnInsertOrUpdate";
            this.btnInsertOrUpdate.Size = new System.Drawing.Size(109, 39);
            this.btnInsertOrUpdate.TabIndex = 76;
            this.btnInsertOrUpdate.Text = "ثبت";
            this.btnInsertOrUpdate.Click += new System.EventHandler(this.btnInsertOrUpdate_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(401, 121);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(22, 17);
            this.labelControl8.TabIndex = 65;
            this.labelControl8.Text = "ریال";
            // 
            // txtIncomeDate
            // 
            this.txtIncomeDate.Location = new System.Drawing.Point(23, 118);
            this.txtIncomeDate.Name = "txtIncomeDate";
            this.txtIncomeDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIncomeDate.Size = new System.Drawing.Size(238, 24);
            this.txtIncomeDate.TabIndex = 61;
            this.txtIncomeDate.UsePersianFormat = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(430, 118);
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
            this.cmbAccountNumber.Location = new System.Drawing.Point(401, 62);
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
            this.txtDescription.Location = new System.Drawing.Point(23, 149);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(618, 102);
            this.txtDescription.TabIndex = 62;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // txtDepositor
            // 
            this.txtDepositor.Location = new System.Drawing.Point(21, 90);
            this.txtDepositor.Name = "txtDepositor";
            this.txtDepositor.Properties.ReadOnly = true;
            this.txtDepositor.Size = new System.Drawing.Size(238, 22);
            this.txtDepositor.TabIndex = 60;
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(21, 62);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Properties.ReadOnly = true;
            this.txtAccountType.Size = new System.Drawing.Size(238, 22);
            this.txtAccountType.TabIndex = 59;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(401, 90);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.ReadOnly = true;
            this.txtBankName.Size = new System.Drawing.Size(238, 22);
            this.txtBankName.TabIndex = 58;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(265, 121);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 17);
            this.labelControl7.TabIndex = 57;
            this.labelControl7.Text = "تاریخ ثبت: ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(645, 152);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 17);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "توضیحات: ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(645, 121);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 17);
            this.labelControl5.TabIndex = 55;
            this.labelControl5.Text = "مبلغ:  ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(265, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 17);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "نام واریز کننده: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(645, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 17);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "نام بانک: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(265, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "نوع حساب: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(645, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 17);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "شماره حساب: ";
            // 
            // IncomeErrorProvider
            // 
            this.IncomeErrorProvider.ContainerControl = this;
            // 
            // frmIncomeRegistration
            // 
            this.AcceptButton = this.btnInsertOrUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 311);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmIncomeRegistration.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIncomeRegistration";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت درآمد ها";
            this.Load += new System.EventHandler(this.frmIncomeRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepositor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnInsertOrUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Atf.UI.DateTimeSelector txtIncomeDate;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private DevExpress.XtraEditors.GridLookUpEdit cmbAccountNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.TextEdit txtDepositor;
        private DevExpress.XtraEditors.TextEdit txtAccountType;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ErrorProvider IncomeErrorProvider;
    }
}