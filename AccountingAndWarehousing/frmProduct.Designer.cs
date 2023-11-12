namespace AccountingAndWarehousing
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.grpShowProduct = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnProductReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnWarehouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnProductImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpShowProduct)).BeginInit();
            this.grpShowProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpShowProduct
            // 
            this.grpShowProduct.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpShowProduct.CaptionImageOptions.SvgImage")));
            this.grpShowProduct.Controls.Add(this.groupControl1);
            this.grpShowProduct.Controls.Add(this.grd);
            this.grpShowProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShowProduct.Location = new System.Drawing.Point(0, 0);
            this.grpShowProduct.Name = "grpShowProduct";
            this.grpShowProduct.Size = new System.Drawing.Size(1191, 518);
            this.grpShowProduct.TabIndex = 0;
            this.grpShowProduct.Text = "اطلاعات کالا";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnProductReport);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnInsert);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 460);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1187, 56);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnProductReport
            // 
            this.btnProductReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProductReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProductReport.ImageOptions.SvgImage")));
            this.btnProductReport.Location = new System.Drawing.Point(2, 2);
            this.btnProductReport.Name = "btnProductReport";
            this.btnProductReport.Size = new System.Drawing.Size(167, 52);
            this.btnProductReport.TabIndex = 4;
            this.btnProductReport.Text = "گزارش کالاهای انبار";
            this.btnProductReport.Click += new System.EventHandler(this.btnProductReport_Click);
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
            this.grd.MainView = this.grdProduct;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.grd.Size = new System.Drawing.Size(1187, 475);
            this.grd.TabIndex = 0;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdProduct});
            // 
            // grdProduct
            // 
            this.grdProduct.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdProduct.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdProduct.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdProduct.Appearance.OddRow.Options.UseBackColor = true;
            this.grdProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnProductID,
            this.clmnGroupName,
            this.clmnProductCode,
            this.clmnProductName,
            this.clmnWarehouseName,
            this.clmnUnitPrice,
            this.clmnUnit,
            this.clmnProductImage});
            this.grdProduct.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdProduct.GridControl = this.grd;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdProduct.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdProduct.OptionsBehavior.Editable = false;
            this.grdProduct.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdProduct.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdProduct.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdProduct.OptionsView.EnableAppearanceEvenRow = true;
            this.grdProduct.OptionsView.EnableAppearanceOddRow = true;
            this.grdProduct.OptionsView.RowAutoHeight = true;
            this.grdProduct.RowHeight = 50;
            this.grdProduct.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdProduct_RowClick);
            // 
            // clmnProductID
            // 
            this.clmnProductID.AppearanceCell.Options.UseTextOptions = true;
            this.clmnProductID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnProductID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnProductID.Caption = "شناسه کالا";
            this.clmnProductID.FieldName = "ProductID";
            this.clmnProductID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnProductID.ImageOptions.SvgImage")));
            this.clmnProductID.MinWidth = 25;
            this.clmnProductID.Name = "clmnProductID";
            this.clmnProductID.Visible = true;
            this.clmnProductID.VisibleIndex = 0;
            this.clmnProductID.Width = 65;
            // 
            // clmnGroupName
            // 
            this.clmnGroupName.AppearanceCell.Options.UseTextOptions = true;
            this.clmnGroupName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnGroupName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnGroupName.Caption = "نام گروه";
            this.clmnGroupName.FieldName = "GroupName";
            this.clmnGroupName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnGroupName.ImageOptions.SvgImage")));
            this.clmnGroupName.MinWidth = 25;
            this.clmnGroupName.Name = "clmnGroupName";
            this.clmnGroupName.Visible = true;
            this.clmnGroupName.VisibleIndex = 3;
            this.clmnGroupName.Width = 90;
            // 
            // clmnProductCode
            // 
            this.clmnProductCode.AppearanceCell.Options.UseTextOptions = true;
            this.clmnProductCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnProductCode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnProductCode.Caption = "کدکالا";
            this.clmnProductCode.FieldName = "ProductCode";
            this.clmnProductCode.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnProductCode.ImageOptions.SvgImage")));
            this.clmnProductCode.MinWidth = 25;
            this.clmnProductCode.Name = "clmnProductCode";
            this.clmnProductCode.Visible = true;
            this.clmnProductCode.VisibleIndex = 2;
            this.clmnProductCode.Width = 98;
            // 
            // clmnProductName
            // 
            this.clmnProductName.AppearanceCell.Options.UseTextOptions = true;
            this.clmnProductName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnProductName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnProductName.Caption = "نام کالا";
            this.clmnProductName.FieldName = "ProductName";
            this.clmnProductName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnProductName.ImageOptions.SvgImage")));
            this.clmnProductName.MinWidth = 25;
            this.clmnProductName.Name = "clmnProductName";
            this.clmnProductName.Visible = true;
            this.clmnProductName.VisibleIndex = 1;
            this.clmnProductName.Width = 123;
            // 
            // clmnWarehouseName
            // 
            this.clmnWarehouseName.AppearanceCell.Options.UseTextOptions = true;
            this.clmnWarehouseName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnWarehouseName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnWarehouseName.Caption = "انبار";
            this.clmnWarehouseName.FieldName = "WarehouseName";
            this.clmnWarehouseName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnWarehouseName.ImageOptions.SvgImage")));
            this.clmnWarehouseName.MinWidth = 25;
            this.clmnWarehouseName.Name = "clmnWarehouseName";
            this.clmnWarehouseName.Visible = true;
            this.clmnWarehouseName.VisibleIndex = 4;
            this.clmnWarehouseName.Width = 94;
            // 
            // clmnUnitPrice
            // 
            this.clmnUnitPrice.AppearanceCell.Options.UseTextOptions = true;
            this.clmnUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnUnitPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnUnitPrice.Caption = "قیمت واحد(ریال)";
            this.clmnUnitPrice.FieldName = "UnitPrice";
            this.clmnUnitPrice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnUnitPrice.ImageOptions.SvgImage")));
            this.clmnUnitPrice.MinWidth = 25;
            this.clmnUnitPrice.Name = "clmnUnitPrice";
            this.clmnUnitPrice.Visible = true;
            this.clmnUnitPrice.VisibleIndex = 5;
            this.clmnUnitPrice.Width = 90;
            // 
            // clmnUnit
            // 
            this.clmnUnit.AppearanceCell.Options.UseTextOptions = true;
            this.clmnUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnUnit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnUnit.Caption = "واحد";
            this.clmnUnit.FieldName = "Unit";
            this.clmnUnit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnUnit.ImageOptions.SvgImage")));
            this.clmnUnit.MinWidth = 25;
            this.clmnUnit.Name = "clmnUnit";
            this.clmnUnit.Visible = true;
            this.clmnUnit.VisibleIndex = 6;
            this.clmnUnit.Width = 90;
            // 
            // clmnProductImage
            // 
            this.clmnProductImage.AppearanceCell.Options.UseTextOptions = true;
            this.clmnProductImage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clmnProductImage.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clmnProductImage.Caption = "تصویر";
            this.clmnProductImage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.clmnProductImage.FieldName = "ProductImage";
            this.clmnProductImage.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnProductImage.ImageOptions.SvgImage")));
            this.clmnProductImage.MinWidth = 27;
            this.clmnProductImage.Name = "clmnProductImage";
            this.clmnProductImage.OptionsColumn.AllowEdit = false;
            this.clmnProductImage.Visible = true;
            this.clmnProductImage.VisibleIndex = 7;
            this.clmnProductImage.Width = 148;
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
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 518);
            this.Controls.Add(this.grpShowProduct);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmProduct.IconOptions.SvgImage")));
            this.Name = "frmProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست کالاها";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpShowProduct)).EndInit();
            this.grpShowProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpShowProduct;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraGrid.Columns.GridColumn clmnProductID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnProductName;
        private DevExpress.XtraGrid.Columns.GridColumn clmnUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn clmnUnit;
        private DevExpress.XtraGrid.Columns.GridColumn clmnProductImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clmnProductCode;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdProduct;
        private DevExpress.XtraGrid.Columns.GridColumn clmnWarehouseName;
        private DevExpress.XtraEditors.SimpleButton btnProductReport;
    }
}