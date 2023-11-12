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
    public partial class frmCustomerType : DevExpress.XtraEditors.XtraForm
    {
        private int selectedID = 0;
        private int selectedRowIndex = 0;

        private string selectedCustomerTypeTitle = string.Empty;

        private bool isEditMode = false;

        public frmCustomerType()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void grdCustomerType_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = grdCustomerType.GetDataRow(e.RowHandle);
            selectedID = Convert.ToInt32(dr["CustomerTypeID"]);
            selectedCustomerTypeTitle = dr["CustomerTypeTitle"].ToString();

            selectedRowIndex = e.RowHandle;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            isEditMode = false;
            txtCustomerTypeCode.Text = string.Empty;
            txtCustomerTypeTitle.Text = string.Empty;
            CustomerTypeErrorProvider.ClearErrors();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CustomerTypeErrorProvider.ClearErrors();
            txtCustomerTypeCode.Text = Convert.ToString(selectedID);
            txtCustomerTypeTitle.Text = selectedCustomerTypeTitle;
            isEditMode = true;
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
                LoadGrdCustomerType();
            }
        }

        /// <summary>
        /// حذف نوع مشتری
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteRow(int selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_CustomerType_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CustomerTypeID" +
                    "", selectedID);
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

        /// <summary>
        /// نمایش اطلاعات انواع مشتری
        /// </summary>
        private void LoadGrdCustomerType()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_CustomerType_SelectAll]";
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

        private void btnInsertAndUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerTypeTitle.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveData();
            LoadGrdCustomerType();
        }

        /// <summary>
        /// افزودن و ویرایش انواع مشتری ها
        /// </summary>
        private void SaveData()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "";

                if (isEditMode)
                    query = "[dbo].[usp_Tbl_CustomerType_UpdateRow]";

                else
                    query = "[dbo].[usp_Tbl_CustomerType_InsertRow]";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerTypeTitle", txtCustomerTypeTitle.Text);

                if (isEditMode)
                {
                    cmd.Parameters.AddWithValue("CustomerTypeID", selectedID);
                }
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    LoadGrdCustomerType();
                    grdCustomerType.TopRowIndex = selectedRowIndex;
                }
                selectedID = 0;
                txtCustomerTypeCode.Text = string.Empty;
                txtCustomerTypeTitle.Text = string.Empty;
                CustomerTypeErrorProvider.ClearErrors();
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

        // ارور پر کردن تکست باکس ها
        private bool IsCustomerTypeTitleValid()
        {
            return txtCustomerTypeTitle.Text.Length > 0;
        }

        private void txtCustomerTypeCode_Validating(object sender, CancelEventArgs e)
        {
            if (!IsCustomerTypeTitleValid())
            {
                CustomerTypeErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                CustomerTypeErrorProvider.SetError((Control)sender, "لطفا نوع مشتری را وارد کنید");
            }
            else
            {
                CustomerTypeErrorProvider.SetError((Control)sender, "");
            }
        }

        private void frmCustomerType_Load(object sender, EventArgs e)
        {
            LoadGrdCustomerType();
        }
    }
}