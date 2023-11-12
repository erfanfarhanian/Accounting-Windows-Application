namespace AccountingAndWarehousing
{
    partial class frmWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouse));
            this.grpWarehouse = new DevExpress.XtraEditors.GroupControl();
            this.txtWarehouseAddress = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtWarehouseName = new DevExpress.XtraEditors.TextEdit();
            this.txtWarehouseCode = new DevExpress.XtraEditors.TextEdit();
            this.lblWarehouseName = new DevExpress.XtraEditors.LabelControl();
            this.lblWarehouseCode = new DevExpress.XtraEditors.LabelControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdWarehouse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ClmnWarehouseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnWarehouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnWarehouseAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WarehouseErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpWarehouse)).BeginInit();
            this.grpWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWarehouse
            // 
            this.grpWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWarehouse.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpWarehouse.CaptionImageOptions.SvgImage")));
            this.grpWarehouse.Controls.Add(this.txtWarehouseAddress);
            this.grpWarehouse.Controls.Add(this.labelControl1);
            this.grpWarehouse.Controls.Add(this.btnEdit);
            this.grpWarehouse.Controls.Add(this.btnNew);
            this.grpWarehouse.Controls.Add(this.btnInsert);
            this.grpWarehouse.Controls.Add(this.btnDelete);
            this.grpWarehouse.Controls.Add(this.txtWarehouseName);
            this.grpWarehouse.Controls.Add(this.txtWarehouseCode);
            this.grpWarehouse.Controls.Add(this.lblWarehouseName);
            this.grpWarehouse.Controls.Add(this.lblWarehouseCode);
            this.grpWarehouse.Location = new System.Drawing.Point(12, 12);
            this.grpWarehouse.Name = "grpWarehouse";
            this.grpWarehouse.Size = new System.Drawing.Size(544, 198);
            this.grpWarehouse.TabIndex = 0;
            this.grpWarehouse.Text = "اطلاعات انبار";
            // 
            // txtWarehouseAddress
            // 
            this.txtWarehouseAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWarehouseAddress.Location = new System.Drawing.Point(234, 115);
            this.txtWarehouseAddress.Multiline = true;
            this.txtWarehouseAddress.Name = "txtWarehouseAddress";
            this.txtWarehouseAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWarehouseAddress.Size = new System.Drawing.Size(226, 67);
            this.txtWarehouseAddress.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(466, 115);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "آدرس انبار: ";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Location = new System.Drawing.Point(24, 50);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 40);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
            this.btnNew.Location = new System.Drawing.Point(118, 50);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 40);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "جدید";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInsert.ImageOptions.SvgImage")));
            this.btnInsert.Location = new System.Drawing.Point(24, 142);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(182, 40);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "ثبت";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(24, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWarehouseName.Location = new System.Drawing.Point(234, 87);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(226, 22);
            this.txtWarehouseName.TabIndex = 3;
            this.txtWarehouseName.Validating += new System.ComponentModel.CancelEventHandler(this.txtWarehouseName_Validating);
            // 
            // txtWarehouseCode
            // 
            this.txtWarehouseCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWarehouseCode.Enabled = false;
            this.txtWarehouseCode.Location = new System.Drawing.Point(344, 59);
            this.txtWarehouseCode.Name = "txtWarehouseCode";
            this.txtWarehouseCode.Size = new System.Drawing.Size(116, 22);
            this.txtWarehouseCode.TabIndex = 2;
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarehouseName.Location = new System.Drawing.Point(466, 90);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Size = new System.Drawing.Size(50, 17);
            this.lblWarehouseName.TabIndex = 1;
            this.lblWarehouseName.Text = "نام انبار: ";
            // 
            // lblWarehouseCode
            // 
            this.lblWarehouseCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarehouseCode.Location = new System.Drawing.Point(466, 62);
            this.lblWarehouseCode.Name = "lblWarehouseCode";
            this.lblWarehouseCode.Size = new System.Drawing.Size(49, 17);
            this.lblWarehouseCode.TabIndex = 0;
            this.lblWarehouseCode.Text = "کد انبار: ";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(2, 41);
            this.grd.MainView = this.grdWarehouse;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(540, 226);
            this.grd.TabIndex = 7;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdWarehouse});
            // 
            // grdWarehouse
            // 
            this.grdWarehouse.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdWarehouse.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdWarehouse.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdWarehouse.Appearance.OddRow.Options.UseBackColor = true;
            this.grdWarehouse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ClmnWarehouseID,
            this.clmnWarehouseName,
            this.clmnWarehouseAddress});
            this.grdWarehouse.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdWarehouse.GridControl = this.grd;
            this.grdWarehouse.Name = "grdWarehouse";
            this.grdWarehouse.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdWarehouse.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdWarehouse.OptionsBehavior.Editable = false;
            this.grdWarehouse.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdWarehouse.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdWarehouse.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdWarehouse.OptionsView.EnableAppearanceEvenRow = true;
            this.grdWarehouse.OptionsView.EnableAppearanceOddRow = true;
            this.grdWarehouse.OptionsView.RowAutoHeight = true;
            this.grdWarehouse.RowHeight = 50;
            this.grdWarehouse.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grmWarehouse_RowClick);
            // 
            // ClmnWarehouseID
            // 
            this.ClmnWarehouseID.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnWarehouseID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnWarehouseID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnWarehouseID.Caption = "مشخصه انبار";
            this.ClmnWarehouseID.FieldName = "WarehouseID";
            this.ClmnWarehouseID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ClmnWarehouseID.ImageOptions.SvgImage")));
            this.ClmnWarehouseID.MinWidth = 25;
            this.ClmnWarehouseID.Name = "ClmnWarehouseID";
            this.ClmnWarehouseID.Visible = true;
            this.ClmnWarehouseID.VisibleIndex = 0;
            this.ClmnWarehouseID.Width = 94;
            // 
            // clmnWarehouseName
            // 
            this.clmnWarehouseName.Caption = "نام انبار";
            this.clmnWarehouseName.FieldName = "WarehouseName";
            this.clmnWarehouseName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnWarehouseName.ImageOptions.SvgImage")));
            this.clmnWarehouseName.MinWidth = 25;
            this.clmnWarehouseName.Name = "clmnWarehouseName";
            this.clmnWarehouseName.Visible = true;
            this.clmnWarehouseName.VisibleIndex = 1;
            this.clmnWarehouseName.Width = 94;
            // 
            // clmnWarehouseAddress
            // 
            this.clmnWarehouseAddress.Caption = "آدرس انبار";
            this.clmnWarehouseAddress.FieldName = "WarehouseAddress";
            this.clmnWarehouseAddress.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("clmnWarehouseAddress.ImageOptions.SvgImage")));
            this.clmnWarehouseAddress.MinWidth = 25;
            this.clmnWarehouseAddress.Name = "clmnWarehouseAddress";
            this.clmnWarehouseAddress.Visible = true;
            this.clmnWarehouseAddress.VisibleIndex = 2;
            this.clmnWarehouseAddress.Width = 94;
            // 
            // WarehouseErrorProvider
            // 
            this.WarehouseErrorProvider.ContainerControl = this;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.grd);
            this.groupControl1.Location = new System.Drawing.Point(12, 216);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(544, 269);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "لیست انبار";
            // 
            // frmWarehouse
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 497);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grpWarehouse);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmWarehouse.IconOptions.SvgImage")));
            this.Name = "frmWarehouse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انبار";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpWarehouse)).EndInit();
            this.grpWarehouse.ResumeLayout(false);
            this.grpWarehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpWarehouse;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdWarehouse;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit txtWarehouseName;
        private DevExpress.XtraEditors.TextEdit txtWarehouseCode;
        private DevExpress.XtraEditors.LabelControl lblWarehouseName;
        private DevExpress.XtraEditors.LabelControl lblWarehouseCode;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnWarehouseID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnWarehouseName;
        private System.Windows.Forms.TextBox txtWarehouseAddress;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn clmnWarehouseAddress;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider WarehouseErrorProvider;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}