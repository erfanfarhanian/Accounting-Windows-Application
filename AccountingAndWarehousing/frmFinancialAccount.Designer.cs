namespace AccountingAndWarehousing
{
    partial class frmFinancialAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinancialAccount));
            this.grpّFinancialAcc = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdFinancialAcc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnFinancialAccReport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpّFinancialAcc)).BeginInit();
            this.grpّFinancialAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancialAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpّFinancialAcc
            // 
            this.grpّFinancialAcc.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpّFinancialAcc.CaptionImageOptions.SvgImage")));
            this.grpّFinancialAcc.Controls.Add(this.groupControl1);
            this.grpّFinancialAcc.Controls.Add(this.grd);
            this.grpّFinancialAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpّFinancialAcc.Location = new System.Drawing.Point(0, 0);
            this.grpّFinancialAcc.Name = "grpّFinancialAcc";
            this.grpّFinancialAcc.Size = new System.Drawing.Size(1191, 518);
            this.grpّFinancialAcc.TabIndex = 1;
            this.grpّFinancialAcc.Text = "اطلاعات حساب های مالی";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnFinancialAccReport);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnInsert);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 460);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1187, 56);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(810, 2);
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
            this.btnUpdate.Location = new System.Drawing.Point(935, 2);
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
            this.btnInsert.Location = new System.Drawing.Point(1060, 2);
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
            this.grd.MainView = this.grdFinancialAcc;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.grd.Size = new System.Drawing.Size(1187, 475);
            this.grd.TabIndex = 1;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdFinancialAcc});
            // 
            // grdFinancialAcc
            // 
            this.grdFinancialAcc.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdFinancialAcc.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdFinancialAcc.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdFinancialAcc.Appearance.OddRow.Options.UseBackColor = true;
            this.grdFinancialAcc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnAccountID,
            this.clmnAccountOwner,
            this.clmnAccountName,
            this.clmnAccountNumber,
            this.clmnBankName,
            this.clmnBalance,
            this.clmnDescription});
            this.grdFinancialAcc.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdFinancialAcc.GridControl = this.grd;
            this.grdFinancialAcc.Name = "grdFinancialAcc";
            this.grdFinancialAcc.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdFinancialAcc.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdFinancialAcc.OptionsBehavior.Editable = false;
            this.grdFinancialAcc.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdFinancialAcc.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdFinancialAcc.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdFinancialAcc.OptionsView.EnableAppearanceEvenRow = true;
            this.grdFinancialAcc.OptionsView.EnableAppearanceOddRow = true;
            this.grdFinancialAcc.OptionsView.RowAutoHeight = true;
            this.grdFinancialAcc.RowHeight = 50;
            this.grdFinancialAcc.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdFinancialAcc_RowClick);
            // 
            // clmnAccountID
            // 
            this.clmnAccountID.AppearanceCell.Options.UseTextOptions = true;
            this.clmnAccountID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnAccountID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnAccountID.Caption = "شناسه حساب";
            this.clmnAccountID.FieldName = "AccountID";
            this.clmnAccountID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnAccountID.ImageOptions.SvgImage")));
            this.clmnAccountID.MinWidth = 25;
            this.clmnAccountID.Name = "clmnAccountID";
            this.clmnAccountID.Visible = true;
            this.clmnAccountID.VisibleIndex = 0;
            this.clmnAccountID.Width = 106;
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
            this.clmnAccountOwner.VisibleIndex = 1;
            this.clmnAccountOwner.Width = 160;
            // 
            // clmnAccountName
            // 
            this.clmnAccountName.AppearanceCell.Options.UseTextOptions = true;
            this.clmnAccountName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnAccountName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnAccountName.Caption = "نام حساب";
            this.clmnAccountName.FieldName = "AccountType";
            this.clmnAccountName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnAccountName.ImageOptions.SvgImage")));
            this.clmnAccountName.MinWidth = 25;
            this.clmnAccountName.Name = "clmnAccountName";
            this.clmnAccountName.Visible = true;
            this.clmnAccountName.VisibleIndex = 2;
            this.clmnAccountName.Width = 160;
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
            this.clmnAccountNumber.VisibleIndex = 3;
            this.clmnAccountNumber.Width = 145;
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
            this.clmnBankName.VisibleIndex = 4;
            this.clmnBankName.Width = 145;
            // 
            // clmnBalance
            // 
            this.clmnBalance.AppearanceCell.Options.UseTextOptions = true;
            this.clmnBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnBalance.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnBalance.Caption = "موجودی (ریال)";
            this.clmnBalance.DisplayFormat.FormatString = "n0";
            this.clmnBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.clmnBalance.FieldName = "Balance";
            this.clmnBalance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnBalance.ImageOptions.SvgImage")));
            this.clmnBalance.MinWidth = 25;
            this.clmnBalance.Name = "clmnBalance";
            this.clmnBalance.Visible = true;
            this.clmnBalance.VisibleIndex = 5;
            this.clmnBalance.Width = 145;
            // 
            // clmnDescription
            // 
            this.clmnDescription.Caption = "توضیحات";
            this.clmnDescription.FieldName = "Description";
            this.clmnDescription.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnDescription.ImageOptions.SvgImage")));
            this.clmnDescription.MinWidth = 25;
            this.clmnDescription.Name = "clmnDescription";
            this.clmnDescription.Visible = true;
            this.clmnDescription.VisibleIndex = 6;
            this.clmnDescription.Width = 145;
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
            // btnFinancialAccReport
            // 
            this.btnFinancialAccReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFinancialAccReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFinancialAccReport.ImageOptions.SvgImage")));
            this.btnFinancialAccReport.Location = new System.Drawing.Point(2, 2);
            this.btnFinancialAccReport.Name = "btnFinancialAccReport";
            this.btnFinancialAccReport.Size = new System.Drawing.Size(200, 52);
            this.btnFinancialAccReport.TabIndex = 3;
            this.btnFinancialAccReport.Text = "گزارش حساب های مالی";
            this.btnFinancialAccReport.Click += new System.EventHandler(this.btnFinancialAccReport_Click);
            // 
            // frmFinancialAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 518);
            this.Controls.Add(this.grpّFinancialAcc);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmFinancialAccount.IconOptions.SvgImage")));
            this.Name = "frmFinancialAccount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست حساب های مالی";
            this.Load += new System.EventHandler(this.frmFinancialAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpّFinancialAcc)).EndInit();
            this.grpّFinancialAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancialAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpّFinancialAcc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdFinancialAcc;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountOwner;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBankName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBalance;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnFinancialAccReport;
    }
}