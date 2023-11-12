namespace AccountingAndWarehousing
{
    partial class frmCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCost));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdCost = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnCostID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnCostDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnShowFinancialAccount = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnCostReport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.grd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1055, 503);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "نمایش اطلاعات";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(2, 41);
            this.grd.MainView = this.grdCost;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(1051, 460);
            this.grd.TabIndex = 0;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdCost});
            // 
            // grdCost
            // 
            this.grdCost.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdCost.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdCost.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdCost.Appearance.OddRow.Options.UseBackColor = true;
            this.grdCost.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdCost.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            this.grdCost.Appearance.Row.BorderColor = System.Drawing.Color.Transparent;
            this.grdCost.Appearance.Row.Options.UseBackColor = true;
            this.grdCost.Appearance.Row.Options.UseBorderColor = true;
            this.grdCost.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnCostID,
            this.clmnAccountNumber,
            this.clmnAccountOwner,
            this.clmnAccountType,
            this.clmnBankName,
            this.clmnAmount,
            this.clmnCostDate,
            this.clmnDescription});
            this.grdCost.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdCost.GridControl = this.grd;
            this.grdCost.Name = "grdCost";
            this.grdCost.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdCost.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdCost.OptionsBehavior.Editable = false;
            this.grdCost.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdCost.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdCost.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdCost.OptionsView.EnableAppearanceEvenRow = true;
            this.grdCost.OptionsView.EnableAppearanceOddRow = true;
            this.grdCost.OptionsView.RowAutoHeight = true;
            this.grdCost.OptionsView.ShowFooter = true;
            this.grdCost.RowHeight = 50;
            this.grdCost.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdPayment_RowClick);
            // 
            // clmnCostID
            // 
            this.clmnCostID.AppearanceCell.Options.UseTextOptions = true;
            this.clmnCostID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnCostID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnCostID.Caption = "شناسه هزینه";
            this.clmnCostID.FieldName = "CostID";
            this.clmnCostID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnCostID.ImageOptions.SvgImage")));
            this.clmnCostID.MinWidth = 25;
            this.clmnCostID.Name = "clmnCostID";
            this.clmnCostID.Visible = true;
            this.clmnCostID.VisibleIndex = 0;
            this.clmnCostID.Width = 90;
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
            this.clmnAccountNumber.VisibleIndex = 1;
            this.clmnAccountNumber.Width = 115;
            // 
            // clmnAccountOwner
            // 
            this.clmnAccountOwner.AppearanceCell.Options.UseTextOptions = true;
            this.clmnAccountOwner.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnAccountOwner.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnAccountOwner.Caption = "نام صاحب حساب";
            this.clmnAccountOwner.FieldName = "AccountOwner";
            this.clmnAccountOwner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnAccountOwner.ImageOptions.SvgImage")));
            this.clmnAccountOwner.MinWidth = 25;
            this.clmnAccountOwner.Name = "clmnAccountOwner";
            this.clmnAccountOwner.Visible = true;
            this.clmnAccountOwner.VisibleIndex = 2;
            this.clmnAccountOwner.Width = 115;
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
            this.clmnAccountType.VisibleIndex = 3;
            this.clmnAccountType.Width = 115;
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
            this.clmnBankName.Width = 115;
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
            this.clmnAmount.VisibleIndex = 5;
            this.clmnAmount.Width = 115;
            // 
            // clmnCostDate
            // 
            this.clmnCostDate.AppearanceCell.Options.UseTextOptions = true;
            this.clmnCostDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnCostDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnCostDate.Caption = "تاریخ ثبت";
            this.clmnCostDate.FieldName = "CostDateShamsi";
            this.clmnCostDate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnCostDate.ImageOptions.SvgImage")));
            this.clmnCostDate.MinWidth = 25;
            this.clmnCostDate.Name = "clmnCostDate";
            this.clmnCostDate.Visible = true;
            this.clmnCostDate.VisibleIndex = 6;
            this.clmnCostDate.Width = 115;
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
            this.clmnDescription.VisibleIndex = 7;
            this.clmnDescription.Width = 131;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl2.CaptionImageOptions.SvgImage")));
            this.groupControl2.Controls.Add(this.btnCostReport);
            this.groupControl2.Controls.Add(this.btnShowFinancialAccount);
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnUpdate);
            this.groupControl2.Controls.Add(this.btnInsert);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 447);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1055, 56);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "groupControl2";
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
            this.btnDelete.Location = new System.Drawing.Point(678, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 52);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(803, 2);
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
            this.btnInsert.Location = new System.Drawing.Point(928, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 52);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "افزودن";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCostReport
            // 
            this.btnCostReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCostReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIncomeReport.ImageOptions.SvgImage")));
            this.btnCostReport.Location = new System.Drawing.Point(225, 2);
            this.btnCostReport.Name = "btnCostReport";
            this.btnCostReport.Size = new System.Drawing.Size(148, 52);
            this.btnCostReport.TabIndex = 7;
            this.btnCostReport.Text = "گزارش هزینه ها";
            this.btnCostReport.Click += new System.EventHandler(this.btnCostReport_Click);
            // 
            // frmCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 503);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmCost.IconOptions.SvgImage")));
            this.Name = "frmCost";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "هزینه ها";
            this.Load += new System.EventHandler(this.frmCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdCost;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCostID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountOwner;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBankName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAmount;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCostDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDescription;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnShowFinancialAccount;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnCostReport;
    }
}