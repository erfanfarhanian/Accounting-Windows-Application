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
    public partial class frmCustomerRegistration : DevExpress.XtraEditors.XtraForm
    {
        int selectedID = 0;

        public frmCustomerRegistration()
        {
            InitializeComponent();
        }

        public frmCustomerRegistration(int SelectedID) : this()
        {
            selectedID = SelectedID;
        }

        private void frmCustomerRegistration_Load(object sender, EventArgs e)
        {
            LoadComboCustomerType();
            if (selectedID != 0)
            {
                LoadCurrentCustomer(selectedID);
            }
        }

        /// <summary>
        /// نمایش کومبو باکس نوع مشتری
        /// </summary>
        private void LoadComboCustomerType()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_CustomerType_SelectAll]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet dsProductGroup = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProductGroup);

                cmbCustomerType.DataSource = dsProductGroup.Tables[0];
                cmbCustomerType.DisplayMember = "CustomerTypeTitle";
                cmbCustomerType.ValueMember = "CustomerTypeID";

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
        /// نمایش اطلاعات انتخاب شده
        /// </summary>
        /// <param name="
        /// CustomerID">شناسه داده</param>
        private void LoadCurrentCustomer(int SelectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "usp_Tbl_Customer_SelectRow";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CustomerID", SelectedID);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("هیچ داده ای وجود ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtFirstName.Text = ds.Tables[0].Rows[0]["FirstName"].ToString();
                txtLastName.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
                txtTel.Text = ds.Tables[0].Rows[0]["Tel"].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0]["Mobile"].ToString();
                txtAddrress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                cmbCustomerType.SelectedValue = ds.Tables[0].Rows[0]["CustomerTypeID"];
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

        private void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtTel.Text == "" || txtMobile.Text == "" || txtAddrress.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل و درست وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedID == 0)
            {
                InsertCustomer();
            }
            else
                UpdateCurrentCustomer();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// افزودن مشتری جدید
        /// </summary>
        private void InsertCustomer()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Customer_InsertRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("CustomerTypeID", cmbCustomerType.SelectedValue);
                cmd.Parameters.AddWithValue("Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("Tel", txtTel.Text);
                cmd.Parameters.AddWithValue("Address", txtAddrress.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("هیچ داده ای اضافه نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// ویرایش مشتری
        /// </summary>
        private void UpdateCurrentCustomer()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Customer_UpdateRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CustomerID", selectedID);
                cmd.Parameters.AddWithValue("FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("CustomerTypeID", cmbCustomerType.SelectedValue);
                cmd.Parameters.AddWithValue("Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("Tel", txtTel.Text);
                cmd.Parameters.AddWithValue("Address", txtAddrress.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("هیچ داده ای ویرایش نشد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnShowCustomerTypeForm_Click(object sender, EventArgs e)
        {
            DialogResult result = new frmCustomerType().ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadComboCustomerType();
            }
        }

        // ارور پر کردن تکست باکس ها
        private bool IsFirstNameValid()
        {
            return txtFirstName.Text.Length > 0;
        }

        private bool IsLastNameValid()
        {
            return txtLastName.Text.Length > 0;
        }

        private bool IsTelValid()
        {
            return txtTel.Text.Length > 0;
        }

        private bool IsMobileValid()
        {
            return txtLastName.Text.Length > 0;
        }

        private bool IsAddressValid()
        {
            return txtAddrress.Text.Length > 0;
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFirstNameValid())
            {
                CustomerErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                CustomerErrorProvider.SetError((Control)sender, "لطفا نام را وارد کنید");
            }
            else
            {
                CustomerErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsLastNameValid())
            {
                CustomerErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                CustomerErrorProvider.SetError((Control)sender, "لطفا نام خانوادگی را وارد کنید");
            }
            else
            {
                CustomerErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtTel_Validating(object sender, CancelEventArgs e)
        {
            if (!IsTelValid())
            {
                CustomerErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                CustomerErrorProvider.SetError((Control)sender, "لطفا تلفن ثابت را وارد کنید");
            }
            else
            {
                CustomerErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtMobile_Validating(object sender, CancelEventArgs e)
        {
            if (!IsMobileValid())
            {
                CustomerErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                CustomerErrorProvider.SetError((Control)sender, "لطفا تلفن همراه را وارد کنید");
            }
            else
            {
                CustomerErrorProvider.SetError((Control)sender, "");
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

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grpGoodsRegistration_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddrress_Validating(object sender, CancelEventArgs e)
        {
            if (!IsMobileValid())
            {
                CustomerErrorProvider2.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                CustomerErrorProvider2.SetError((Control)sender, "لطفا آدرس را وارد کنید");
            }
            else
            {
                CustomerErrorProvider2.SetError((Control)sender, "");
            }
        }
    }
}