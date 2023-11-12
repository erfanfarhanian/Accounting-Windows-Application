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
    public partial class frmAccountRegistration : DevExpress.XtraEditors.XtraForm
    {
        int selectedID = 0;

        public frmAccountRegistration()
        {
            InitializeComponent();
        }

        public frmAccountRegistration(int SelectedID) : this()
        {
            selectedID = SelectedID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmAccountRegistration_Load(object sender, EventArgs e)
        {
            if (selectedID != 0)
            {
                LoadCurrentFinancialAccount(selectedID);
            }
        }

        /// <summary>
        /// نمایش اطلاعات انتخاب شده
        /// </summary>
        /// <param name="
        /// AccountID">شناسه داده</param>
        private void LoadCurrentFinancialAccount(int SelectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "usp_Tbl_FinancialAccount_SelectRow";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("AccountID", SelectedID);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("هیچ داده ای وجود ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtAccountOwner.Text = ds.Tables[0].Rows[0]["AccountOwner"].ToString();
                txtAccountType.Text = ds.Tables[0].Rows[0]["AccountType"].ToString();
                txtAccountNumber.Text = ds.Tables[0].Rows[0]["AccountNumber"].ToString();
                txtBalance.Value = Convert.ToUInt32(ds.Tables[0].Rows[0]["Balance"]);
                txtBankName.Text = ds.Tables[0].Rows[0]["BankName"].ToString();
                txtDescription.Text = ds.Tables[0].Rows[0]["Description"].ToString();
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

        private void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
            if (txtAccountOwner.Text == "" || txtAccountType.Text == "" || txtAccountNumber.Text == "" || txtBankName.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل و درست وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedID == 0)
            {
                InsertFinancialAccount();
            }
            else
                UpdateCurrentFinancialAccount();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// افزودن حساب مالی جدید
        /// </summary>
        private void InsertFinancialAccount()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_FinancialAccount_InsertRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("AccountOwner", txtAccountOwner.Text);
                cmd.Parameters.AddWithValue("AccountType", txtAccountType.Text);
                cmd.Parameters.AddWithValue("BankName", txtBankName.Text);
                cmd.Parameters.AddWithValue("AccountNumber", txtAccountNumber.Text);
                cmd.Parameters.AddWithValue("Balance", txtBalance.Value);
                cmd.Parameters.AddWithValue("Description", txtDescription.Text);
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
        /// ویرایش حساب مالی
        /// </summary>
        private void UpdateCurrentFinancialAccount()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_FinancialAccount_UpdateRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("AccountID", selectedID);
                cmd.Parameters.AddWithValue("AccountOwner", txtAccountOwner.Text);
                cmd.Parameters.AddWithValue("AccountType", txtAccountType.Text);
                cmd.Parameters.AddWithValue("BankName", txtBankName.Text);
                cmd.Parameters.AddWithValue("AccountNumber", txtAccountNumber.Text);
                cmd.Parameters.AddWithValue("Balance", txtBalance.Value);
                cmd.Parameters.AddWithValue("Description", txtDescription.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("هیچ تعرفه ای ویرایش نشد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private bool IsAccountOwnerValid()
        {
            return txtAccountOwner.Text.Length > 0;
        }

        private bool IsAccountTypeValid()
        {
            return txtAccountType.Text.Length > 0;
        }

        private bool IsAccountNumberValid()
        {
            return txtAccountNumber.Text.Length > 0;
        }

        private bool IsBankNameValid()
        {
            return txtBankName.Text.Length > 0;
        }

        private void txtAccountOwner_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAccountOwnerValid())
            {
                FinancialAccountErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                FinancialAccountErrorProvider.SetError((Control)sender, "لطفا نام صاحب حساب را وارد کنید");
            }
            else
            {
                FinancialAccountErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtAccountType_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAccountTypeValid())
            {
                FinancialAccountErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                FinancialAccountErrorProvider.SetError((Control)sender, "لطفا نوع حساب را وارد کنید");
            }
            else
            {
                FinancialAccountErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtBankName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsBankNameValid())
            {
                FinancialAccountErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                FinancialAccountErrorProvider.SetError((Control)sender, "لطفا نام بانک را وارد کنید");
            }
            else
            {
                FinancialAccountErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAccountNumberValid())
            {
                FinancialAccountErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                FinancialAccountErrorProvider.SetError((Control)sender, "لطفا شماره حساب را وارد کنید");
            }
            else
            {
                FinancialAccountErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}