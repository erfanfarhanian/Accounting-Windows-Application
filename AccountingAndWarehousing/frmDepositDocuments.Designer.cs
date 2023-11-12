namespace AccountingAndWarehousing
{
    partial class frmDepositDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositDocuments));
            this.grpShowDocuments = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnReceipt = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowFinancialAccount = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdPaymentDoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnDepositDocID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnDocumentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnRegistrationgDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnSituation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnِDepositDocReport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpShowDocuments)).BeginInit();
            this.grpShowDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPaymentDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpShowDocuments
            // 
            this.grpShowDocuments.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpShowDocuments.CaptionImageOptions.SvgImage")));
            this.grpShowDocuments.Controls.Add(this.groupControl1);
            this.grpShowDocuments.Controls.Add(this.grd);
            this.grpShowDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShowDocuments.Location = new System.Drawing.Point(0, 0);
            this.grpShowDocuments.Name = "grpShowDocuments";
            this.grpShowDocuments.Size = new System.Drawing.Size(1484, 560);
            this.grpShowDocuments.TabIndex = 2;
            this.grpShowDocuments.Text = "اطلاعات اسناد دریافتی";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnِDepositDocReport);
            this.groupControl1.Controls.Add(this.btnReceipt);
            this.groupControl1.Controls.Add(this.btnShowFinancialAccount);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnInsert);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 502);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1480, 56);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnReceipt
            // 
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReceipt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReceipt.ImageOptions.SvgImage")));
            this.btnReceipt.Location = new System.Drawing.Point(225, 2);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(125, 52);
            this.btnReceipt.TabIndex = 6;
            this.btnReceipt.Text = "وصول";
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnShowFinancialAccount
            // 
            this.btnShowFinancialAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowFinancialAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShowFinancialAccount.ImageOptions.SvgImage")));
            this.btnShowFinancialAccount.Location = new System.Drawing.Point(2, 2);
            this.btnShowFinancialAccount.Name = "btnShowFinancialAccount";
            this.btnShowFinancialAccount.Size = new System.Drawing.Size(223, 52);
            this.btnShowFinancialAccount.TabIndex = 5;
            this.btnShowFinancialAccount.Text = "نمایش حساب های مالی";
            this.btnShowFinancialAccount.Click += new System.EventHandler(this.btnShowFinancialAccount_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(1103, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 52);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(1228, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 52);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsert.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInsert.ImageOptions.SvgImage")));
            this.btnInsert.Location = new System.Drawing.Point(1353, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 52);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "افزودن";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(2, 41);
            this.grd.MainView = this.grdPaymentDoc;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.grd.Size = new System.Drawing.Size(1480, 517);
            this.grd.TabIndex = 0;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdPaymentDoc});
            // 
            // grdPaymentDoc
            // 
            this.grdPaymentDoc.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdPaymentDoc.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdPaymentDoc.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdPaymentDoc.Appearance.OddRow.Options.UseBackColor = true;
            this.grdPaymentDoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnDepositDocID,
            this.clmnAccountNumber,
            this.clmnAccountOwner,
            this.clmnBankName,
            this.clmnAccountType,
            this.clmnDocumentNumber,
            this.clmnCustomerName,
            this.clmnAmount,
            this.clmnRegistrationgDate,
            this.clmnDueDate,
            this.clmnSituation,
            this.clmnDescription});
            this.grdPaymentDoc.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdPaymentDoc.GridControl = this.grd;
            this.grdPaymentDoc.Name = "grdPaymentDoc";
            this.grdPaymentDoc.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdPaymentDoc.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdPaymentDoc.OptionsBehavior.Editable = false;
            this.grdPaymentDoc.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdPaymentDoc.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdPaymentDoc.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdPaymentDoc.OptionsView.EnableAppearanceEvenRow = true;
            this.grdPaymentDoc.OptionsView.EnableAppearanceOddRow = true;
            this.grdPaymentDoc.OptionsView.RowAutoHeight = true;
            this.grdPaymentDoc.OptionsView.ShowFooter = true;
            this.grdPaymentDoc.RowHeight = 50;
            this.grdPaymentDoc.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdPaymentDoc_RowClick);
            // 
            // clmnDepositDocID
            // 
            this.clmnDepositDocID.AppearanceCell.Options.UseTextOptions = true;
            this.clmnDepositDocID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnDepositDocID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnDepositDocID.Caption = "شناسه سند";
            this.clmnDepositDocID.FieldName = "DepositDocID";
            this.clmnDepositDocID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnDepositDocID.ImageOptions.SvgImage")));
            this.clmnDepositDocID.MinWidth = 25;
            this.clmnDepositDocID.Name = "clmnDepositDocID";
            this.clmnDepositDocID.Visible = true;
            this.clmnDepositDocID.VisibleIndex = 0;
            this.clmnDepositDocID.Width = 89;
            // 
            // clmnAccountNumber
            // 
            this.clmnAccountNumber.AppearanceCell.Options.UseTextOptions = true;
            this.clmnAccountNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnAccountNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnAccountNumber.Caption = "شماره حساب";
            this.clmnAccountNumber.FieldName = "AccountNumber";
            this.clmnAccountNumber.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnAccountNumber.ImageOptions.SvgImage")));
            this.clmnAccountNumber.MinWidth = 25;
            this.clmnAccountNumber.Name = "clmnAccountNumber";
            this.clmnAccountNumber.Visible = true;
            this.clmnAccountNumber.VisibleIndex = 4;
            this.clmnAccountNumber.Width = 142;
            // 
            // clmnAccountOwner
            // 
            this.clmnAccountOwner.AppearanceCell.Options.UseTextOptions = true;
            this.clmnAccountOwner.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnAccountOwner.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnAccountOwner.Caption = "صاحب حساب";
            this.clmnAccountOwner.FieldName = "AccountOwner";
            this.clmnAccountOwner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnAccountOwner.ImageOptions.SvgImage")));
            this.clmnAccountOwner.MinWidth = 25;
            this.clmnAccountOwner.Name = "clmnAccountOwner";
            this.clmnAccountOwner.Visible = true;
            this.clmnAccountOwner.VisibleIndex = 2;
            this.clmnAccountOwner.Width = 142;
            // 
            // clmnBankName
            // 
            this.clmnBankName.AppearanceCell.Options.UseTextOptions = true;
            this.clmnBankName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnBankName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnBankName.Caption = "نام بانک";
            this.clmnBankName.FieldName = "BankName";
            this.clmnBankName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnBankName.ImageOptions.SvgImage")));
            this.clmnBankName.MinWidth = 25;
            this.clmnBankName.Name = "clmnBankName";
            this.clmnBankName.Visible = true;
            this.clmnBankName.VisibleIndex = 3;
            this.clmnBankName.Width = 99;
            // 
            // clmnAccountType
            // 
            this.clmnAccountType.AppearanceCell.Options.UseTextOptions = true;
            this.clmnAccountType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnAccountType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnAccountType.Caption = "نوع حساب";
            this.clmnAccountType.FieldName = "AccountType";
            this.clmnAccountType.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnAccountType.ImageOptions.SvgImage")));
            this.clmnAccountType.MinWidth = 25;
            this.clmnAccountType.Name = "clmnAccountType";
            this.clmnAccountType.Visible = true;
            this.clmnAccountType.VisibleIndex = 1;
            this.clmnAccountType.Width = 105;
            // 
            // clmnDocumentNumber
            // 
            this.clmnDocumentNumber.AppearanceCell.Options.UseTextOptions = true;
            this.clmnDocumentNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnDocumentNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnDocumentNumber.Caption = "شماره سند";
            this.clmnDocumentNumber.FieldName = "DocumentNumber";
            this.clmnDocumentNumber.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnDocumentNumber.ImageOptions.SvgImage")));
            this.clmnDocumentNumber.MinWidth = 25;
            this.clmnDocumentNumber.Name = "clmnDocumentNumber";
            this.clmnDocumentNumber.Visible = true;
            this.clmnDocumentNumber.VisibleIndex = 5;
            this.clmnDocumentNumber.Width = 125;
            // 
            // clmnCustomerName
            // 
            this.clmnCustomerName.AppearanceCell.Options.UseTextOptions = true;
            this.clmnCustomerName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnCustomerName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnCustomerName.Caption = "نام مشتری";
            this.clmnCustomerName.FieldName = "CustomerName";
            this.clmnCustomerName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnCustomerName.ImageOptions.SvgImage")));
            this.clmnCustomerName.MinWidth = 25;
            this.clmnCustomerName.Name = "clmnCustomerName";
            this.clmnCustomerName.Visible = true;
            this.clmnCustomerName.VisibleIndex = 6;
            this.clmnCustomerName.Width = 142;
            // 
            // clmnAmount
            // 
            this.clmnAmount.AppearanceCell.Options.UseTextOptions = true;
            this.clmnAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnAmount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnAmount.Caption = "مبلغ(ریال)";
            this.clmnAmount.DisplayFormat.FormatString = "n0";
            this.clmnAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.clmnAmount.FieldName = "Amount";
            this.clmnAmount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnAmount.ImageOptions.SvgImage")));
            this.clmnAmount.MinWidth = 25;
            this.clmnAmount.Name = "clmnAmount";
            this.clmnAmount.Visible = true;
            this.clmnAmount.VisibleIndex = 7;
            this.clmnAmount.Width = 127;
            // 
            // clmnRegistrationgDate
            // 
            this.clmnRegistrationgDate.AppearanceCell.Options.UseTextOptions = true;
            this.clmnRegistrationgDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnRegistrationgDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnRegistrationgDate.Caption = "تاریخ ثبت";
            this.clmnRegistrationgDate.FieldName = "RegistrationDateShamsi";
            this.clmnRegistrationgDate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnRegistrationgDate.ImageOptions.SvgImage")));
            this.clmnRegistrationgDate.MinWidth = 25;
            this.clmnRegistrationgDate.Name = "clmnRegistrationgDate";
            this.clmnRegistrationgDate.Visible = true;
            this.clmnRegistrationgDate.VisibleIndex = 8;
            this.clmnRegistrationgDate.Width = 125;
            // 
            // clmnDueDate
            // 
            this.clmnDueDate.AppearanceCell.Options.UseTextOptions = true;
            this.clmnDueDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnDueDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnDueDate.Caption = "تاریخ سررسید";
            this.clmnDueDate.FieldName = "DueDateShamsi";
            this.clmnDueDate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnDueDate.ImageOptions.SvgImage")));
            this.clmnDueDate.MinWidth = 27;
            this.clmnDueDate.Name = "clmnDueDate";
            this.clmnDueDate.OptionsColumn.AllowEdit = false;
            this.clmnDueDate.Visible = true;
            this.clmnDueDate.VisibleIndex = 9;
            this.clmnDueDate.Width = 125;
            // 
            // clmnSituation
            // 
            this.clmnSituation.AppearanceCell.Options.UseTextOptions = true;
            this.clmnSituation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnSituation.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnSituation.Caption = "وضعیت";
            this.clmnSituation.FieldName = "Situation";
            this.clmnSituation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnSituation.ImageOptions.SvgImage")));
            this.clmnSituation.MinWidth = 25;
            this.clmnSituation.Name = "clmnSituation";
            this.clmnSituation.Visible = true;
            this.clmnSituation.VisibleIndex = 10;
            this.clmnSituation.Width = 95;
            // 
            // clmnDescription
            // 
            this.clmnDescription.AppearanceCell.Options.UseTextOptions = true;
            this.clmnDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnDescription.Caption = "توضیحات";
            this.clmnDescription.FieldName = "Description";
            this.clmnDescription.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnDescription.ImageOptions.SvgImage")));
            this.clmnDescription.MinWidth = 25;
            this.clmnDescription.Name = "clmnDescription";
            this.clmnDescription.Visible = true;
            this.clmnDescription.VisibleIndex = 11;
            this.clmnDescription.Width = 136;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.NullText = "ندارد";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemPictureEdit1.ShowScrollBars = true;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.repositoryItemPictureEdit1.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;
            // 
            // btnِDepositDocReport
            // 
            this.btnِDepositDocReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnِDepositDocReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPaymentDocReport.ImageOptions.SvgImage")));
            this.btnِDepositDocReport.Location = new System.Drawing.Point(350, 2);
            this.btnِDepositDocReport.Name = "btnِDepositDocReport";
            this.btnِDepositDocReport.Size = new System.Drawing.Size(199, 52);
            this.btnِDepositDocReport.TabIndex = 8;
            this.btnِDepositDocReport.Text = "گزارش چک های دریافتی";
            this.btnِDepositDocReport.Click += new System.EventHandler(this.btnِDepositDocReport_Click);
            // 
            // frmDepositDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 560);
            this.Controls.Add(this.grpShowDocuments);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmDepositDocuments.IconOptions.SvgImage")));
            this.Name = "frmDepositDocuments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اسناد دریافتی";
            this.Load += new System.EventHandler(this.frmDepositDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpShowDocuments)).EndInit();
            this.grpShowDocuments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPaymentDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpShowDocuments;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnReceipt;
        private DevExpress.XtraEditors.SimpleButton btnShowFinancialAccount;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdPaymentDoc;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDepositDocID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountOwner;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBankName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDocumentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAmount;
        private DevExpress.XtraGrid.Columns.GridColumn clmnRegistrationgDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnSituation;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnِDepositDocReport;
    }
}