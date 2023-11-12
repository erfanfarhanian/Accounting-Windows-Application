namespace AccountingAndWarehousing
{
    partial class frmDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposit));
            this.grpDeposit = new DevExpress.XtraEditors.GroupControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtDepositDate = new Atf.UI.DateTimeSelector();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtDepositAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbAccountNumber = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdDeposit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnDepositID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnDepositAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnDepositDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepositErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDeposit)).BeginInit();
            this.grpDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepositAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepositor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDeposit
            // 
            this.grpDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDeposit.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpDeposit.CaptionImageOptions.SvgImage")));
            this.grpDeposit.Controls.Add(this.btnEdit);
            this.grpDeposit.Controls.Add(this.labelControl8);
            this.grpDeposit.Controls.Add(this.simpleButton1);
            this.grpDeposit.Controls.Add(this.txtDepositDate);
            this.grpDeposit.Controls.Add(this.btnNew);
            this.grpDeposit.Controls.Add(this.txtDepositAmount);
            this.grpDeposit.Controls.Add(this.cmbAccountNumber);
            this.grpDeposit.Controls.Add(this.btnDelete);
            this.grpDeposit.Controls.Add(this.btnOK);
            this.grpDeposit.Controls.Add(this.txtDescription);
            this.grpDeposit.Controls.Add(this.txtDepositor);
            this.grpDeposit.Controls.Add(this.txtAccountType);
            this.grpDeposit.Controls.Add(this.txtBankName);
            this.grpDeposit.Controls.Add(this.labelControl7);
            this.grpDeposit.Controls.Add(this.labelControl6);
            this.grpDeposit.Controls.Add(this.labelControl5);
            this.grpDeposit.Controls.Add(this.labelControl4);
            this.grpDeposit.Controls.Add(this.labelControl3);
            this.grpDeposit.Controls.Add(this.labelControl2);
            this.grpDeposit.Controls.Add(this.labelControl1);
            this.grpDeposit.Location = new System.Drawing.Point(12, 12);
            this.grpDeposit.Name = "grpDeposit";
            this.grpDeposit.Size = new System.Drawing.Size(1053, 269);
            this.grpDeposit.TabIndex = 0;
            this.grpDeposit.Text = "اطلاعات واریز";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Location = new System.Drawing.Point(40, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 37);
            this.btnEdit.TabIndex = 52;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Location = new System.Drawing.Point(703, 124);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(22, 17);
            this.labelControl8.TabIndex = 50;
            this.labelControl8.Text = "ریال";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(40, 199);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(220, 38);
            this.simpleButton1.TabIndex = 49;
            this.simpleButton1.Text = "لیست حساب های مالی";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtDepositDate
            // 
            this.txtDepositDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepositDate.Location = new System.Drawing.Point(364, 121);
            this.txtDepositDate.Name = "txtDepositDate";
            this.txtDepositDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDepositDate.Size = new System.Drawing.Size(238, 24);
            this.txtDepositDate.TabIndex = 10;
            this.txtDepositDate.UsePersianFormat = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
            this.btnNew.Location = new System.Drawing.Point(153, 68);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(107, 37);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "جدید";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepositAmount.Location = new System.Drawing.Point(732, 122);
            this.txtDepositAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepositAmount.Maximum = new decimal(new int[] {
            1215752182,
            23,
            0,
            0});
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(208, 23);
            this.txtDepositAmount.TabIndex = 48;
            this.txtDepositAmount.ThousandsSeparator = true;
            // 
            // cmbAccountNumber
            // 
            this.cmbAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccountNumber.Location = new System.Drawing.Point(703, 65);
            this.cmbAccountNumber.Name = "cmbAccountNumber";
            this.cmbAccountNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAccountNumber.Properties.ImmediatePopup = true;
            this.cmbAccountNumber.Properties.NullText = "";
            this.cmbAccountNumber.Properties.PopupView = this.gridLookUpEdit1View;
            this.cmbAccountNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbAccountNumber.Size = new System.Drawing.Size(238, 22);
            this.cmbAccountNumber.TabIndex = 12;
            this.cmbAccountNumber.EditValueChanged += new System.EventHandler(this.cmbAccountNumber_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(40, 111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 38);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(40, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(220, 38);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "ثبت";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(364, 152);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(577, 102);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // txtDepositor
            // 
            this.txtDepositor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepositor.Location = new System.Drawing.Point(364, 93);
            this.txtDepositor.Name = "txtDepositor";
            this.txtDepositor.Properties.ReadOnly = true;
            this.txtDepositor.Size = new System.Drawing.Size(238, 22);
            this.txtDepositor.TabIndex = 9;
            // 
            // txtAccountType
            // 
            this.txtAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountType.Location = new System.Drawing.Point(364, 65);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Properties.ReadOnly = true;
            this.txtAccountType.Size = new System.Drawing.Size(238, 22);
            this.txtAccountType.TabIndex = 8;
            // 
            // txtBankName
            // 
            this.txtBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankName.Location = new System.Drawing.Point(703, 93);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.ReadOnly = true;
            this.txtBankName.Size = new System.Drawing.Size(238, 22);
            this.txtBankName.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(608, 124);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 17);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "تاریخ واریز: ";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(947, 155);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 17);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "توضیحات: ";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(947, 124);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 17);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "مبلغ واریزی: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(608, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 17);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "نام واریزکننده: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(947, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "نام بانک: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(608, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "نوع حساب: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(947, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "شماره حساب: ";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.grd);
            this.groupControl1.Location = new System.Drawing.Point(12, 287);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1053, 289);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "نمایش اطلاعات";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(2, 41);
            this.grd.MainView = this.grdDeposit;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.grd.Size = new System.Drawing.Size(1049, 246);
            this.grd.TabIndex = 0;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdDeposit});
            // 
            // grdDeposit
            // 
            this.grdDeposit.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdDeposit.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdDeposit.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdDeposit.Appearance.OddRow.Options.UseBackColor = true;
            this.grdDeposit.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdDeposit.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            this.grdDeposit.Appearance.Row.BorderColor = System.Drawing.Color.Transparent;
            this.grdDeposit.Appearance.Row.Options.UseBackColor = true;
            this.grdDeposit.Appearance.Row.Options.UseBorderColor = true;
            this.grdDeposit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnDepositID,
            this.clmnAccountNumber,
            this.clmnAccountOwner,
            this.clmnAccountType,
            this.clmnBankName,
            this.clmnDepositAmount,
            this.clmnDepositDate,
            this.clmnDescription});
            this.grdDeposit.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdDeposit.GridControl = this.grd;
            this.grdDeposit.Name = "grdDeposit";
            this.grdDeposit.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdDeposit.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdDeposit.OptionsBehavior.Editable = false;
            this.grdDeposit.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdDeposit.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdDeposit.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdDeposit.OptionsView.EnableAppearanceEvenRow = true;
            this.grdDeposit.OptionsView.EnableAppearanceOddRow = true;
            this.grdDeposit.OptionsView.RowAutoHeight = true;
            this.grdDeposit.RowHeight = 50;
            this.grdDeposit.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdDeposit_RowClick);
            // 
            // clmnDepositID
            // 
            this.clmnDepositID.AppearanceCell.Options.UseTextOptions = true;
            this.clmnDepositID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnDepositID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnDepositID.Caption = "شناسه واریز";
            this.clmnDepositID.FieldName = "DepositID";
            this.clmnDepositID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnDepositID.ImageOptions.SvgImage")));
            this.clmnDepositID.MinWidth = 25;
            this.clmnDepositID.Name = "clmnDepositID";
            this.clmnDepositID.Visible = true;
            this.clmnDepositID.VisibleIndex = 0;
            this.clmnDepositID.Width = 90;
            // 
            // clmnAccountNumber
            // 
            this.clmnAccountNumber.AppearanceCell.Options.UseTextOptions = true;
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
            // clmnDepositAmount
            // 
            this.clmnDepositAmount.AppearanceCell.Options.UseTextOptions = true;
            this.clmnDepositAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnDepositAmount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnDepositAmount.Caption = "مبلغ واریزی(ریال)";
            this.clmnDepositAmount.DisplayFormat.FormatString = "n0";
            this.clmnDepositAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.clmnDepositAmount.FieldName = "DepositAmount";
            this.clmnDepositAmount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnDepositAmount.ImageOptions.SvgImage")));
            this.clmnDepositAmount.MinWidth = 25;
            this.clmnDepositAmount.Name = "clmnDepositAmount";
            this.clmnDepositAmount.Visible = true;
            this.clmnDepositAmount.VisibleIndex = 5;
            this.clmnDepositAmount.Width = 115;
            // 
            // clmnDepositDate
            // 
            this.clmnDepositDate.AppearanceCell.Options.UseTextOptions = true;
            this.clmnDepositDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnDepositDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnDepositDate.Caption = "تاریخ واریز";
            this.clmnDepositDate.FieldName = "DepositDateShamsi";
            this.clmnDepositDate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnDepositDate.ImageOptions.SvgImage")));
            this.clmnDepositDate.MinWidth = 25;
            this.clmnDepositDate.Name = "clmnDepositDate";
            this.clmnDepositDate.Visible = true;
            this.clmnDepositDate.VisibleIndex = 6;
            this.clmnDepositDate.Width = 115;
            // 
            // clmnDescription
            // 
            this.clmnDescription.AppearanceCell.Options.UseTextOptions = true;
            this.clmnDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clmnDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.clmnDescription.Caption = "توضیحات";
            this.clmnDescription.ColumnEdit = this.repositoryItemMemoEdit1;
            this.clmnDescription.FieldName = "Description";
            this.clmnDescription.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnDescription.ImageOptions.SvgImage")));
            this.clmnDescription.MinWidth = 25;
            this.clmnDescription.Name = "clmnDescription";
            this.clmnDescription.Visible = true;
            this.clmnDescription.VisibleIndex = 7;
            this.clmnDescription.Width = 131;
            // 
            // DepositErrorProvider
            // 
            this.DepositErrorProvider.ContainerControl = this;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // frmDeposit
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 588);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grpDeposit);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmDeposit.IconOptions.SvgImage")));
            this.Name = "frmDeposit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "واریز مبلغ به حساب";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpDeposit)).EndInit();
            this.grpDeposit.ResumeLayout(false);
            this.grpDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepositAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepositor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpDeposit;
        private DevExpress.XtraEditors.GridLookUpEdit cmbAccountNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
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
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdDeposit;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDepositID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountOwner;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBankName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDepositAmount;
        private Atf.UI.DateTimeSelector txtDepositDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDepositDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDescription;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.ErrorProvider DepositErrorProvider;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        public System.Windows.Forms.NumericUpDown txtDepositAmount;
        public System.Windows.Forms.TextBox txtDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}