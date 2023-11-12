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
    public partial class frmEmployeeGroup : DevExpress.XtraEditors.XtraForm
    {
        private int selectedID = 0;
        private int selectedRowIndex = 0;

        private string selectedEmployeeGroupTitle = string.Empty;

        private bool isEditMode = false;

        public frmEmployeeGroup()
        {
            InitializeComponent();
        }

        private void frmEmployeeGroup_Load(object sender, EventArgs e)
        {
            LoadGrdEmployeeGroup();
        }

        /// <summary>
        /// نمایش اطلاعات گروه کارمندان
        /// </summary>
        private void LoadGrdEmployeeGroup()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_EmployeeGroup_SelectAll]";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            EmployeeGroupErrorProvider.ClearErrors();
            txtCode.Text = Convert.ToString(selectedID);
            txtGroupTitle.Text = selectedEmployeeGroupTitle;
            isEditMode = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            isEditMode = false;
            txtCode.Text = string.Empty;
            txtGroupTitle.Text = string.Empty;
            EmployeeGroupErrorProvider.ClearErrors();
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
                LoadGrdEmployeeGroup();
            }
        }

        /// <summary>
        /// حذف گروه کارمندان
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteRow(int selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_EmployeeGroup_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("EmployeeGroupID", selectedID);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtGroupTitle.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveData();
            LoadGrdEmployeeGroup();
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
                    query = "[dbo].[usp_Tbl_EmployeeGroup_UpdateRow]";

                else
                    query = "[dbo].[usp_Tbl_EmployeeGroup_InsertRow]";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmployeeGroupTitle", txtGroupTitle.Text);

                if (isEditMode)
                {
                    cmd.Parameters.AddWithValue("EmployeeGroupID", selectedID);
                }
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    LoadGrdEmployeeGroup();
                    gridViewEmployeeGroup.TopRowIndex = selectedRowIndex;
                }
                selectedID = 0;
                txtCode.Text = string.Empty;
                txtGroupTitle.Text = string.Empty;
                EmployeeGroupErrorProvider.ClearErrors();
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

        private void gridViewEmployeeGroup_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridViewEmployeeGroup.GetDataRow(e.RowHandle);
            selectedID = Convert.ToInt32(dr["EmployeeGroupID"]);
            selectedEmployeeGroupTitle = dr["EmployeeGroupTitle"].ToString();

            selectedRowIndex = e.RowHandle;
        }

        // ارور پر کردن تکست باکس ها
        private bool IsEmployeeGroupTitleValid()
        {
            return txtGroupTitle.Text.Length > 0;
        }

        private void txtGroupTitle_Validating(object sender, CancelEventArgs e)
        {
            if (!IsEmployeeGroupTitleValid())
            {
                EmployeeGroupErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                EmployeeGroupErrorProvider.SetError((Control)sender, "لطفا نام گروه را وارد کنید");
            }
            else
            {
                EmployeeGroupErrorProvider.SetError((Control)sender, "");
            }
        }
    }
}