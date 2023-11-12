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
using Stimulsoft.Report;

namespace AccountingAndWarehousing
{
    public partial class frmPhoneBook : DevExpress.XtraEditors.XtraForm
    {
        private int selectedID = 0;
        private int selectedRowIndex = 0;

        private string selectFullName = string.Empty;
        private string selectedTel = string.Empty;
        private string selectedMobile = string.Empty;
        private string selectedAddress = string.Empty;

        private bool isEditMode = false;
        public frmPhoneBook()
        {
            InitializeComponent();
        }

        private void frmPhoneBook_Load(object sender, EventArgs e)
        {
            LoadGrdPhoneBook();
        }

        /// <summary>
        /// نمایش اطلاعات دفترچه تلفن
        /// </summary>
        private void LoadGrdPhoneBook()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_PhoneBook_SelectAll]";
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

        private void grdPhoneBook_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = grdPhoneBook.GetDataRow(e.RowHandle);
            selectedID = Convert.ToInt32(dr["PhoneBookID"]);
            selectFullName = dr["FullName"].ToString();
            selectedTel = dr["Tel"].ToString();
            selectedMobile = dr["Mobile"].ToString();
            selectedAddress = dr["Address"].ToString();

            selectedRowIndex = e.RowHandle;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            isEditMode = false;
            txtFullName.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtAddress.Text = string.Empty;
            PhoneBookErrorProvider.ClearErrors();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PhoneBookErrorProvider.ClearErrors();
            txtFullName.Text = selectFullName;
            txtMobile.Text = selectedMobile;
            txtTel.Text = selectedTel;
            txtAddress.Text = selectedAddress;
            isEditMode = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
                LoadGrdPhoneBook();
            }
        }

        /// <summary>
        /// حذف اطلاعات دفترچه تلفن
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteRow(long selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_PhoneBook_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("PhoneBookID", selectedID);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveData();
            LoadGrdPhoneBook();
        }

        /// <summary>
        /// افزودن و ویرایش دفترچه تلفن
        /// </summary>
        private void SaveData()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "";

                if (isEditMode)
                    query = "[dbo].[usp_Tbl_PhoneBook_UpdateRow]";

                else
                    query = "[dbo].[usp_Tbl_PhoneBook_InsertRow]";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                if (isEditMode)
                {
                    cmd.Parameters.AddWithValue("PhoneBookID", selectedID);
                }
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    LoadGrdPhoneBook();
                    grdPhoneBook.TopRowIndex = selectedRowIndex;
                }
                selectedID = 0;
                txtFullName.Text = string.Empty;
                txtTel.Text = string.Empty;
                txtMobile.Text = string.Empty;
                txtAddress.Text = string.Empty;
                PhoneBookErrorProvider.ClearErrors();
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
        private bool IsFullNameValid()
        {
            return txtFullName.Text.Length > 0;
        }

        

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFullNameValid())
            {
                PhoneBookErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                PhoneBookErrorProvider.SetError((Control)sender, "لطفا نام و نام خانوادگی را وارد کنید");
            }
            else
            {
                PhoneBookErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMobile_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPhoneBookReport_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(@"ReportFiles\RptPhoneBook.mrt");
            report.Compile();
            report.ShowWithRibbonGUI();
        }
    }
}