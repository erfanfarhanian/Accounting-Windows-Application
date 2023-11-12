namespace AccountingAndWarehousing
{
    partial class frmGrouping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrouping));
            this.grpGrouping = new DevExpress.XtraEditors.GroupControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtGroupName = new DevExpress.XtraEditors.TextEdit();
            this.txtGroupCode = new DevExpress.XtraEditors.TextEdit();
            this.lblGroupName = new DevExpress.XtraEditors.LabelControl();
            this.lblGroupID = new DevExpress.XtraEditors.LabelControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdGrouping = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ClmnGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupingErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrouping)).BeginInit();
            this.grpGrouping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrouping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupingErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGrouping
            // 
            this.grpGrouping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGrouping.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("grpGrouping.CaptionImageOptions.SvgImage")));
            this.grpGrouping.Controls.Add(this.btnEdit);
            this.grpGrouping.Controls.Add(this.btnNew);
            this.grpGrouping.Controls.Add(this.btnInsert);
            this.grpGrouping.Controls.Add(this.btnDelete);
            this.grpGrouping.Controls.Add(this.txtGroupName);
            this.grpGrouping.Controls.Add(this.txtGroupCode);
            this.grpGrouping.Controls.Add(this.lblGroupName);
            this.grpGrouping.Controls.Add(this.lblGroupID);
            this.grpGrouping.Location = new System.Drawing.Point(12, 12);
            this.grpGrouping.Name = "grpGrouping";
            this.grpGrouping.Size = new System.Drawing.Size(522, 193);
            this.grpGrouping.TabIndex = 1;
            this.grpGrouping.Text = "دسته بندی ها";
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
            // txtGroupName
            // 
            this.txtGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupName.Location = new System.Drawing.Point(228, 110);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Properties.MaxLength = 100;
            this.txtGroupName.Size = new System.Drawing.Size(226, 22);
            this.txtGroupName.TabIndex = 3;
            this.txtGroupName.Validating += new System.ComponentModel.CancelEventHandler(this.txtGroupName_Validating);
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupCode.Enabled = false;
            this.txtGroupCode.Location = new System.Drawing.Point(338, 82);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.Size = new System.Drawing.Size(116, 22);
            this.txtGroupCode.TabIndex = 2;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupName.Location = new System.Drawing.Point(460, 113);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(55, 17);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "نام گروه: ";
            // 
            // lblGroupID
            // 
            this.lblGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupID.Location = new System.Drawing.Point(460, 85);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(54, 17);
            this.lblGroupID.TabIndex = 0;
            this.lblGroupID.Text = "کد گروه: ";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(2, 41);
            this.grd.MainView = this.grdGrouping;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(518, 215);
            this.grd.TabIndex = 7;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdGrouping});
            // 
            // grdGrouping
            // 
            this.grdGrouping.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdGrouping.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdGrouping.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdGrouping.Appearance.OddRow.Options.UseBackColor = true;
            this.grdGrouping.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ClmnGroupID,
            this.clmnGroupName});
            this.grdGrouping.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdGrouping.GridControl = this.grd;
            this.grdGrouping.Name = "grdGrouping";
            this.grdGrouping.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdGrouping.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdGrouping.OptionsBehavior.Editable = false;
            this.grdGrouping.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdGrouping.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdGrouping.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdGrouping.OptionsView.EnableAppearanceEvenRow = true;
            this.grdGrouping.OptionsView.EnableAppearanceOddRow = true;
            this.grdGrouping.OptionsView.RowAutoHeight = true;
            this.grdGrouping.RowHeight = 50;
            this.grdGrouping.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdGrouping_RowClick);
            // 
            // ClmnGroupID
            // 
            this.ClmnGroupID.AppearanceCell.Options.UseTextOptions = true;
            this.ClmnGroupID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ClmnGroupID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ClmnGroupID.Caption = "مشخصه گروه";
            this.ClmnGroupID.FieldName = "GroupID";
            this.ClmnGroupID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ClmnGroupID.ImageOptions.SvgImage")));
            this.ClmnGroupID.MinWidth = 25;
            this.ClmnGroupID.Name = "ClmnGroupID";
            this.ClmnGroupID.Visible = true;
            this.ClmnGroupID.VisibleIndex = 0;
            this.ClmnGroupID.Width = 94;
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
            this.clmnGroupName.VisibleIndex = 1;
            this.clmnGroupName.Width = 94;
            // 
            // GroupingErrorProvider
            // 
            this.GroupingErrorProvider.ContainerControl = this;
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
            this.groupControl1.Text = "لیست دسته بندی ها";
            // 
            // frmGrouping
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 481);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grpGrouping);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmGrouping.IconOptions.SvgImage")));
            this.Name = "frmGrouping";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دسته بندی کالاها";
            this.Load += new System.EventHandler(this.frmGrouping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrouping)).EndInit();
            this.grpGrouping.ResumeLayout(false);
            this.grpGrouping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrouping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupingErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpGrouping;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdGrouping;
        private DevExpress.XtraGrid.Columns.GridColumn ClmnGroupID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnGroupName;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit txtGroupName;
        private DevExpress.XtraEditors.TextEdit txtGroupCode;
        private DevExpress.XtraEditors.LabelControl lblGroupName;
        private DevExpress.XtraEditors.LabelControl lblGroupID;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider GroupingErrorProvider;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}