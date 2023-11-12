namespace AccountingAndWarehousing
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.grpDeposit = new DevExpress.XtraEditors.GroupControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtPaymentDate = new Atf.UI.DateTimeSelector();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbAccountNumber = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdPayment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnPaymentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPaymentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PaymentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDeposit)).BeginInit();
            this.grpDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentErrorProvider)).BeginInit();
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
            this.grpDeposit.Controls.Add(this.txtPaymentDate);
            this.grpDeposit.Controls.Add(this.btnNew);
            this.grpDeposit.Controls.Add(this.txtPaymentAmount);
            this.grpDeposit.Controls.Add(this.cmbAccountNumber);
            this.grpDeposit.Controls.Add(this.btnDelete);
            this.grpDeposit.Controls.Add(this.btnOK);
            this.grpDeposit.Controls.Add(this.txtDescription);
            this.grpDeposit.Controls.Add(this.txtPayer);
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
            this.grpDeposit.Size = new System.Drawing.Size(1087, 269);
            this.grpDeposit.TabIndex = 1;
            this.grpDeposit.Text = "اطلاعات پرداخت";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Location = new System.Drawing.Point(39, 76);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 37);
            this.btnEdit.TabIndex = 51;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Location = new System.Drawing.Point(737, 124);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(22, 17);
            this.labelControl8.TabIndex = 50;
            this.labelControl8.Text = "ریال";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(39, 207);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(220, 38);
            this.simpleButton1.TabIndex = 49;
            this.simpleButton1.Text = "لیست حساب های مالی";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentDate.Location = new System.Drawing.Point(366, 121);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPaymentDate.Size = new System.Drawing.Size(238, 24);
            this.txtPaymentDate.TabIndex = 10;
            this.txtPaymentDate.UsePersianFormat = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
            this.btnNew.Location = new System.Drawing.Point(152, 76);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(107, 37);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "جدید";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentAmount.Location = new System.Drawing.Point(766, 120);
            this.txtPaymentAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentAmount.Maximum = new decimal(new int[] {
            1215752182,
            23,
            0,
            0});
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(208, 23);
            this.txtPaymentAmount.TabIndex = 48;
            this.txtPaymentAmount.ThousandsSeparator = true;
            // 
            // cmbAccountNumber
            // 
            this.cmbAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccountNumber.Location = new System.Drawing.Point(737, 65);
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
            this.btnDelete.Location = new System.Drawing.Point(39, 119);
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
            this.btnOK.Location = new System.Drawing.Point(39, 163);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(220, 38);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "ثبت";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(366, 152);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(609, 102);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // txtPayer
            // 
            this.txtPayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayer.Location = new System.Drawing.Point(366, 93);
            this.txtPayer.Name = "txtPayer";
            this.txtPayer.Properties.ReadOnly = true;
            this.txtPayer.Size = new System.Drawing.Size(238, 22);
            this.txtPayer.TabIndex = 9;
            // 
            // txtAccountType
            // 
            this.txtAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountType.Location = new System.Drawing.Point(366, 65);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Properties.ReadOnly = true;
            this.txtAccountType.Size = new System.Drawing.Size(238, 22);
            this.txtAccountType.TabIndex = 8;
            // 
            // txtBankName
            // 
            this.txtBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBankName.Location = new System.Drawing.Point(737, 93);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.ReadOnly = true;
            this.txtBankName.Size = new System.Drawing.Size(238, 22);
            this.txtBankName.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(610, 124);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 17);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "تاریخ پرداخت: ";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(981, 155);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 17);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "توضیحات: ";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(981, 124);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 17);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "مبلغ پرداختی: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(610, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 17);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "نام پرداخت کننده: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(981, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "نام بانک: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(610, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "نوع حساب: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(981, 68);
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
            this.groupControl1.Size = new System.Drawing.Size(1087, 289);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "نمایش اطلاعات";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(2, 41);
            this.grd.MainView = this.grdPayment;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.grd.Size = new System.Drawing.Size(1083, 246);
            this.grd.TabIndex = 0;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdPayment});
            // 
            // grdPayment
            // 
            this.grdPayment.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdPayment.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdPayment.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdPayment.Appearance.OddRow.Options.UseBackColor = true;
            this.grdPayment.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdPayment.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            this.grdPayment.Appearance.Row.BorderColor = System.Drawing.Color.Transparent;
            this.grdPayment.Appearance.Row.Options.UseBackColor = true;
            this.grdPayment.Appearance.Row.Options.UseBorderColor = true;
            this.grdPayment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnPaymentID,
            this.clmnAccountNumber,
            this.clmnAccountOwner,
            this.clmnAccountType,
            this.clmnBankName,
            this.clmnPaymentAmount,
            this.clmnPaymentDate,
            this.clmnDescription});
            this.grdPayment.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdPayment.GridControl = this.grd;
            this.grdPayment.Name = "grdPayment";
            this.grdPayment.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdPayment.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdPayment.OptionsBehavior.Editable = false;
            this.grdPayment.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdPayment.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdPayment.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdPayment.OptionsView.EnableAppearanceEvenRow = true;
            this.grdPayment.OptionsView.EnableAppearanceOddRow = true;
            this.grdPayment.OptionsView.RowAutoHeight = true;
            this.grdPayment.RowHeight = 50;
            this.grdPayment.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdPayment_RowClick);
            // 
            // clmnPaymentID
            // 
            this.clmnPaymentID.AppearanceCell.Options.UseTextOptions = true;
            this.clmnPaymentID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnPaymentID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnPaymentID.Caption = "شناسه پرداخت";
            this.clmnPaymentID.FieldName = "PaymentID";
            this.clmnPaymentID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnPaymentID.ImageOptions.SvgImage")));
            this.clmnPaymentID.MinWidth = 25;
            this.clmnPaymentID.Name = "clmnPaymentID";
            this.clmnPaymentID.Visible = true;
            this.clmnPaymentID.VisibleIndex = 0;
            this.clmnPaymentID.Width = 90;
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
            // clmnPaymentAmount
            // 
            this.clmnPaymentAmount.AppearanceCell.Options.UseTextOptions = true;
            this.clmnPaymentAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnPaymentAmount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnPaymentAmount.Caption = "مبلغ پرداختی(ریال)";
            this.clmnPaymentAmount.DisplayFormat.FormatString = "n0";
            this.clmnPaymentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.clmnPaymentAmount.FieldName = "PaymentAmount";
            this.clmnPaymentAmount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnPaymentAmount.ImageOptions.SvgImage")));
            this.clmnPaymentAmount.MinWidth = 25;
            this.clmnPaymentAmount.Name = "clmnPaymentAmount";
            this.clmnPaymentAmount.Visible = true;
            this.clmnPaymentAmount.VisibleIndex = 5;
            this.clmnPaymentAmount.Width = 115;
            // 
            // clmnPaymentDate
            // 
            this.clmnPaymentDate.AppearanceCell.Options.UseTextOptions = true;
            this.clmnPaymentDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnPaymentDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnPaymentDate.Caption = "تاریخ پرداخت";
            this.clmnPaymentDate.FieldName = "PaymentDateShamsi";
            this.clmnPaymentDate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnPaymentDate.ImageOptions.SvgImage")));
            this.clmnPaymentDate.MinWidth = 25;
            this.clmnPaymentDate.Name = "clmnPaymentDate";
            this.clmnPaymentDate.Visible = true;
            this.clmnPaymentDate.VisibleIndex = 6;
            this.clmnPaymentDate.Width = 115;
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
            // PaymentErrorProvider
            // 
            this.PaymentErrorProvider.ContainerControl = this;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 588);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grpDeposit);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmPayment.IconOptions.SvgImage")));
            this.Name = "frmPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پرداخت مبلغ به حساب";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpDeposit)).EndInit();
            this.grpDeposit.ResumeLayout(false);
            this.grpDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpDeposit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Atf.UI.DateTimeSelector txtPaymentDate;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private System.Windows.Forms.NumericUpDown txtPaymentAmount;
        private DevExpress.XtraEditors.GridLookUpEdit cmbAccountNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnOK;
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdPayment;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPaymentID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountOwner;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn clmnBankName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPaymentAmount;
        private DevExpress.XtraGrid.Columns.GridColumn clmnPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDescription;
        private System.Windows.Forms.ErrorProvider PaymentErrorProvider;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}