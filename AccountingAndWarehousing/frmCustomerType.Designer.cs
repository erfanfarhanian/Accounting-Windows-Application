namespace AccountingAndWarehousing
{
    partial class frmCustomerType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerType));
            this.grpCustomerType = new DevExpress.XtraEditors.GroupControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertAndUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtCustomerTypeTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomerTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.lblGroupName = new DevExpress.XtraEditors.LabelControl();
            this.lblGroupID = new DevExpress.XtraEditors.LabelControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdCustomerType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ClmnCustomerTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnCustomerTypeTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerTypeErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerType)).BeginInit();
            this.grpCustomerType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerTypeTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTypeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerType
            // 
            this.grpCustomerType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomerType.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpCustomerType.CaptionImageOptions.SvgImage")));
            this.grpCustomerType.Controls.Add(this.btnEdit);
            this.grpCustomerType.Controls.Add(this.btnNew);
            this.grpCustomerType.Controls.Add(this.btnInsertAndUpdate);
            this.grpCustomerType.Controls.Add(this.btnCancel);
            this.grpCustomerType.Controls.Add(this.btnDelete);
            this.grpCustomerType.Controls.Add(this.txtCustomerTypeTitle);
            this.grpCustomerType.Controls.Add(this.txtCustomerTypeCode);
            this.grpCustomerType.Controls.Add(this.lblGroupName);
            this.grpCustomerType.Controls.Add(this.lblGroupID);
            this.grpCustomerType.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerType.Name = "grpCustomerType";
            this.grpCustomerType.Size = new System.Drawing.Size(522, 193);
            this.grpCustomerType.TabIndex = 2;
            this.grpCustomerType.Text = "انواع مشتری";
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
            // btnInsertAndUpdate
            // 
            this.btnInsertAndUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertAndUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInsertAndUpdate.ImageOptions.SvgImage")));
            this.btnInsertAndUpdate.Location = new System.Drawing.Point(24, 142);
            this.btnInsertAndUpdate.Name = "btnInsertAndUpdate";
            this.btnInsertAndUpdate.Size = new System.Drawing.Size(182, 40);
            this.btnInsertAndUpdate.TabIndex = 6;
            this.btnInsertAndUpdate.Text = "ثبت";
            this.btnInsertAndUpdate.Click += new System.EventHandler(this.btnInsertAndUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(118, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(24, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCustomerTypeTitle
            // 
            this.txtCustomerTypeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerTypeTitle.Location = new System.Drawing.Point(225, 108);
            this.txtCustomerTypeTitle.Name = "txtCustomerTypeTitle";
            this.txtCustomerTypeTitle.Properties.MaxLength = 50;
            this.txtCustomerTypeTitle.Size = new System.Drawing.Size(201, 22);
            this.txtCustomerTypeTitle.TabIndex = 3;
            // 
            // txtCustomerTypeCode
            // 
            this.txtCustomerTypeCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerTypeCode.Enabled = false;
            this.txtCustomerTypeCode.Location = new System.Drawing.Point(310, 80);
            this.txtCustomerTypeCode.Name = "txtCustomerTypeCode";
            this.txtCustomerTypeCode.Size = new System.Drawing.Size(116, 22);
            this.txtCustomerTypeCode.TabIndex = 2;
            this.txtCustomerTypeCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerTypeCode_Validating);
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupName.Location = new System.Drawing.Point(432, 111);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(76, 17);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "نوع مشتری: ";
            // 
            // lblGroupID
            // 
            this.lblGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupID.Location = new System.Drawing.Point(432, 83);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(73, 17);
            this.lblGroupID.TabIndex = 0;
            this.lblGroupID.Text = "کد مشتری: ";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(2, 41);
            this.grd.MainView = this.grdCustomerType;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(518, 215);
            this.grd.TabIndex = 7;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdCustomerType});
            // 
            // grdCustomerType
            // 
            this.grdCustomerType.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdCustomerType.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdCustomerType.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdCustomerType.Appearance.OddRow.Options.UseBackColor = true;
            this.grdCustomerType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ClmnCustomerTypeID,
            this.clmnCustomerTypeTitle});
            this.grdCustomerType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdCustomerType.GridControl = this.grd;
            this.grdCustomerType.Name = "grdCustomerType";
            this.grdCustomerType.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdCustomerType.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdCustomerType.OptionsBehavior.Editable = false;
            this.grdCustomerType.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdCustomerType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdCustomerType.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdCustomerType.OptionsView.EnableAppearanceEvenRow = true;
            this.grdCustomerType.OptionsView.EnableAppearanceOddRow = true;
            this.grdCustomerType.OptionsView.RowAutoHeight = true;
            this.grdCustomerType.RowHeight = 50;
            this.grdCustomerType.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdCustomerType_RowClick);
            // 
            // ClmnCustomerTypeID
            // 
            this.ClmnCustomerTypeID.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnCustomerTypeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnCustomerTypeID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnCustomerTypeID.Caption = "مشخصه نوع مشتری";
            this.ClmnCustomerTypeID.FieldName = "CustomerTypeID";
            this.ClmnCustomerTypeID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ClmnCustomerTypeID.ImageOptions.SvgImage")));
            this.ClmnCustomerTypeID.MinWidth = 25;
            this.ClmnCustomerTypeID.Name = "ClmnCustomerTypeID";
            this.ClmnCustomerTypeID.Visible = true;
            this.ClmnCustomerTypeID.VisibleIndex = 0;
            this.ClmnCustomerTypeID.Width = 94;
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
            this.clmnCustomerTypeTitle.VisibleIndex = 1;
            this.clmnCustomerTypeTitle.Width = 94;
            // 
            // CustomerTypeErrorProvider
            // 
            this.CustomerTypeErrorProvider.ContainerControl = this;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.grd);
            this.groupControl1.Location = new System.Drawing.Point(12, 211);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(522, 258);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "لیست انواع مشتری";
            // 
            // frmCustomerType
            // 
            this.AcceptButton = this.btnInsertAndUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 481);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grpCustomerType);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmCustomerType.IconOptions.SvgImage")));
            this.Name = "frmCustomerType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نوع مشتری";
            this.Load += new System.EventHandler(this.frmCustomerType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpCustomerType)).EndInit();
            this.grpCustomerType.ResumeLayout(false);
            this.grpCustomerType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerTypeTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTypeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCustomerType;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdCustomerType;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnCustomerTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnCustomerTypeTitle;
        private DevExpress.XtraEditors.SimpleButton btnInsertAndUpdate;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit txtCustomerTypeTitle;
        private DevExpress.XtraEditors.TextEdit txtCustomerTypeCode;
        private DevExpress.XtraEditors.LabelControl lblGroupName;
        private DevExpress.XtraEditors.LabelControl lblGroupID;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider CustomerTypeErrorProvider;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}