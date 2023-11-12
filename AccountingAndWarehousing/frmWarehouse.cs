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
    public partial class frmWarehouse : DevExpress.XtraEditors.XtraForm
    {
        private int selectedID = 0;
        private int selectedRowIndex = 0;

        private string selectedWarehouseName = string.Empty;
        private string selectedWarehouseAddress = string.Empty;

        private bool isEditMode = false;

        public frmWarehouse()
        {
            InitializeComponent();
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            LoadGrdWarehouse();
        }

        /// <summary>
        /// نمایش اسامی انبارها
        /// </summary>
        private void LoadGrdWarehouse()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Warehouse_SelectAll]";
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            txtWarehouseCode.Text = string.Empty;
            txtWarehouseName.Text = string.Empty;
            txtWarehouseAddress.Text = string.Empty;
            WarehouseErrorProvider.ClearErrors();
            isEditMode = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            WarehouseErrorProvider.ClearErrors();
            txtWarehouseCode.Text = selectedID.ToString();
            txtWarehouseName.Text = selectedWarehouseName;
            txtWarehouseAddress.Text = selectedWarehouseAddress;
            isEditMode = true;
        }

        private void grmWarehouse_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = grdWarehouse.GetDataRow(e.RowHandle);
            selectedID = Convert.ToInt32(dr["WarehouseID"]);
            selectedWarehouseName = dr["WarehouseName"].ToString();
            selectedWarehouseAddress = dr["WarehouseAddress"].ToString();

            selectedRowIndex = e.RowHandle;
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
                LoadGrdWarehouse();
            }
        }

        /// <summary>
        /// حذف انبار
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteRow(long selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Warehouse_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("WarehouseID", selectedID);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtWarehouseName.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveData();
            LoadGrdWarehouse();
        }

        /// <summary>
        /// افزودن و ویرایش انبار
        /// </summary>
        private void SaveData()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "";

                if (isEditMode)
                    query = "[dbo].[usp_Tbl_Warehouse_UpdateRow]";

                else
                    query = "[dbo].[usp_Tbl_Warehouse_InsertRow]";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@WarehouseName", txtWarehouseName.Text);
                cmd.Parameters.AddWithValue("@WarehouseAddress", txtWarehouseAddress.Text);

                if (isEditMode)
                {
                    cmd.Parameters.AddWithValue("WarehouseID", selectedID);
                }
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    LoadGrdWarehouse();
                    grdWarehouse.TopRowIndex = selectedRowIndex;
                }
                selectedID = 0;
                txtWarehouseCode.Text = string.Empty;
                txtWarehouseName.Text = string.Empty;
                txtWarehouseAddress.Text = string.Empty;
                WarehouseErrorProvider.ClearErrors();
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

        // ارور پر کردن تکست باکس ها
        private bool IsWarehouseNameValid()
        {
            return txtWarehouseName.Text.Length > 0;
        }

        private void txtWarehouseName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsWarehouseNameValid())
            {
                WarehouseErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                WarehouseErrorProvider.SetError((Control)sender, "لطفا نام انبار را وارد کنید");
            }
            else
            {
                WarehouseErrorProvider.SetError((Control)sender, "");
            }
        }
    }
}