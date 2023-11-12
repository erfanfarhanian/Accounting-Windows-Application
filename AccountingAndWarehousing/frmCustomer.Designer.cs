namespace AccountingAndWarehousing
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.grpCustomer = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnCustomerTypeTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ClmnMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomer)).BeginInit();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpCustomer.CaptionImageOptions.SvgImage")));
            this.grpCustomer.Controls.Add(this.groupControl1);
            this.grpCustomer.Controls.Add(this.grd);
            this.grpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCustomer.Location = new System.Drawing.Point(0, 0);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(1191, 518);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.Text = "اطلاعات مشتری";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnReturn);
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
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReturn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReturn.ImageOptions.SvgImage")));
            this.btnReturn.Location = new System.Drawing.Point(685, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 52);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "بازگشت";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.grd.MainView = this.grdCustomer;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemTextEdit1});
            this.grd.Size = new System.Drawing.Size(1187, 475);
            this.grd.TabIndex = 1;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdCustomer});
            // 
            // grdCustomer
            // 
            this.grdCustomer.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdCustomer.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdCustomer.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdCustomer.Appearance.OddRow.Options.UseBackColor = true;
            this.grdCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnCustomerID,
            this.clmnFirstName,
            this.clmnLastName,
            this.clmnCustomerTypeTitle,
            this.clmnTel,
            this.ClmnMobile,
            this.clmnAddress});
            this.grdCustomer.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdCustomer.GridControl = this.grd;
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdCustomer.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdCustomer.OptionsBehavior.Editable = false;
            this.grdCustomer.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdCustomer.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdCustomer.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdCustomer.OptionsView.EnableAppearanceEvenRow = true;
            this.grdCustomer.OptionsView.EnableAppearanceOddRow = true;
            this.grdCustomer.OptionsView.RowAutoHeight = true;
            this.grdCustomer.RowHeight = 50;
            this.grdCustomer.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdCustomer_RowClick);
            // 
            // clmnCustomerID
            // 
            this.clmnCustomerID.AppearanceCell.Options.UseTextOptions = true;
            this.clmnCustomerID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnCustomerID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnCustomerID.Caption = "شناسه مشتری";
            this.clmnCustomerID.FieldName = "CustomerID";
            this.clmnCustomerID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnCustomerID.ImageOptions.SvgImage")));
            this.clmnCustomerID.MinWidth = 25;
            this.clmnCustomerID.Name = "clmnCustomerID";
            this.clmnCustomerID.Visible = true;
            this.clmnCustomerID.VisibleIndex = 0;
            this.clmnCustomerID.Width = 120;
            // 
            // clmnFirstName
            // 
            this.clmnFirstName.AppearanceCell.Options.UseTextOptions = true;
            this.clmnFirstName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnFirstName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnFirstName.Caption = "نام";
            this.clmnFirstName.FieldName = "FirstName";
            this.clmnFirstName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnFirstName.ImageOptions.SvgImage")));
            this.clmnFirstName.MinWidth = 25;
            this.clmnFirstName.Name = "clmnFirstName";
            this.clmnFirstName.Visible = true;
            this.clmnFirstName.VisibleIndex = 1;
            this.clmnFirstName.Width = 140;
            // 
            // clmnLastName
            // 
            this.clmnLastName.AppearanceCell.Options.UseTextOptions = true;
            this.clmnLastName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnLastName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnLastName.Caption = "نام خانوادگی";
            this.clmnLastName.FieldName = "LastName";
            this.clmnLastName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnLastName.ImageOptions.SvgImage")));
            this.clmnLastName.MinWidth = 25;
            this.clmnLastName.Name = "clmnLastName";
            this.clmnLastName.Visible = true;
            this.clmnLastName.VisibleIndex = 2;
            this.clmnLastName.Width = 190;
            // 
            // clmnCustomerTypeTitle
            // 
            this.clmnCustomerTypeTitle.AppearanceCell.Options.UseTextOptions = true;
            this.clmnCustomerTypeTitle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnCustomerTypeTitle.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnCustomerTypeTitle.Caption = "نوع مشتری";
            this.clmnCustomerTypeTitle.FieldName = "CustomerTypeTitle";
            this.clmnCustomerTypeTitle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnCustomerTypeTitle.ImageOptions.SvgImage")));
            this.clmnCustomerTypeTitle.MinWidth = 25;
            this.clmnCustomerTypeTitle.Name = "clmnCustomerTypeTitle";
            this.clmnCustomerTypeTitle.Visible = true;
            this.clmnCustomerTypeTitle.VisibleIndex = 3;
            this.clmnCustomerTypeTitle.Width = 172;
            // 
            // clmnTel
            // 
            this.clmnTel.AppearanceCell.Options.UseTextOptions = true;
            this.clmnTel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnTel.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnTel.Caption = "تلفن ثابت";
            this.clmnTel.FieldName = "Tel";
            this.clmnTel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnTel.ImageOptions.SvgImage")));
            this.clmnTel.MinWidth = 25;
            this.clmnTel.Name = "clmnTel";
            this.clmnTel.Visible = true;
            this.clmnTel.VisibleIndex = 4;
            this.clmnTel.Width = 172;
            // 
            // ClmnMobile
            // 
            this.ClmnMobile.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnMobile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnMobile.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnMobile.Caption = "تلفن همراه";
            this.ClmnMobile.FieldName = "Mobile";
            this.ClmnMobile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ClmnMobile.ImageOptions.SvgImage")));
            this.ClmnMobile.MinWidth = 25;
            this.ClmnMobile.Name = "ClmnMobile";
            this.ClmnMobile.Visible = true;
            this.ClmnMobile.VisibleIndex = 5;
            this.ClmnMobile.Width = 172;
            // 
            // clmnAddress
            // 
            this.clmnAddress.AppearanceCell.Options.UseTextOptions = true;
            this.clmnAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnAddress.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnAddress.Caption = "آدرس";
            this.clmnAddress.FieldName = "Address";
            this.clmnAddress.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnDept.ImageOptions.SvgImage")));
            this.clmnAddress.MinWidth = 25;
            this.clmnAddress.Name = "clmnAddress";
            this.clmnAddress.Visible = true;
            this.clmnAddress.VisibleIndex = 6;
            this.clmnAddress.Width = 200;
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
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "0";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 518);
            this.Controls.Add(this.grpCustomer);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmCustomer.IconOptions.SvgImage")));
            this.MinimizeBox = false;
            this.Name = "frmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست مشتری ها";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomer)).EndInit();
            this.grpCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCustomer;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCustomerTypeTitle;
        private DevExpress.XtraGrid.Columns.GridColumn clmnFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnTel;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnMobile;
        private DevExpress.XtraGrid.Columns.GridColumn clmnAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraGrid.Columns.GridColumn clmnLastName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}