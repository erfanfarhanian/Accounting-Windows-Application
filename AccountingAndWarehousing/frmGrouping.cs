using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace AccountingAndWarehousing
{
    public partial class frmGrouping : DevExpress.XtraEditors.XtraForm
    {
        private int selectedID = 0;
        private int selectedRowIndex = 0;

        private string selectedGroupName = string.Empty;

        private bool isEditMode = false;
        public frmGrouping()
        {
            InitializeComponent();
        }

        private void grdGrouping_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = grdGrouping.GetDataRow(e.RowHandle);
            selectedID = Convert.ToInt32(dr["GroupID"]);
            selectedGroupName = dr["GroupName"].ToString();

            selectedRowIndex = e.RowHandle;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            isEditMode = false;
            txtGroupCode.Text = string.Empty;
            txtGroupName.Text = string.Empty;
            GroupingErrorProvider.ClearErrors();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            GroupingErrorProvider.ClearErrors();
            txtGroupCode.Text = Convert.ToString(selectedID);
            txtGroupName.Text = selectedGroupName;
            isEditMode = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveData();
            LoadGrdGrouping();
        }

        /// <summary>
        /// افزودن و ویرایش کروهبندی کالاها
        /// </summary>
        private void SaveData()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "";

                if (isEditMode)
                    query = "[dbo].[usp_Tbl_Grouping_UpdateRow]";

                else
                    query = "[dbo].[usp_Tbl_Grouping_InsertRow]";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@GroupName", txtGroupName.Text);

                if (isEditMode)
                {
                    cmd.Parameters.AddWithValue("GroupID", selectedID);
                }
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    LoadGrdGrouping();
                    grdGrouping.TopRowIndex = selectedRowIndex;
                }
                selectedID = 0;
                txtGroupCode.Text = string.Empty;
                txtGroupName.Text = string.Empty;
                GroupingErrorProvider.ClearErrors();
                isEditMode = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با دیتایس" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "\n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// نمایش اطلاعات گروهبندی ها
        /// </summary>
        private void LoadGrdGrouping()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Grouping_SelectAll]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                grd.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "/n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGrouping_Load(object sender, EventArgs e)
        {
            LoadGrdGrouping();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("هیچ داده ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult res = MessageBox.Show("با حذف این داده تمام اطلاعات مربوط به آن حذف می شود" + "\n" + "آیا از حذف این داده اطمینان دارید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                DeleteRow(selectedID);
                LoadGrdGrouping();
            }
        }

        /// <summary>
        /// حذف گروهبندی
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteRow(int selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Grouping_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("GroupID", selectedID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("هیچ داده ای انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "\n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // ارور پر کردن تکست باکس ها
        private bool IsGroupNameValid()
        {
            return txtGroupName.Text.Length > 0;
        }

        private void txtGroupName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsGroupNameValid())
            {
                GroupingErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                GroupingErrorProvider.SetError((Control)sender, "لطفا نام دسته بندی را وارد کنید");
            }
            else
            {
                GroupingErrorProvider.SetError((Control)sender, "");
            }
        }
    }
}