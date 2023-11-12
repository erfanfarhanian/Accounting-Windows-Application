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
    public partial class frmIncomeRegistration : DevExpress.XtraEditors.XtraForm
    {
        //ذخیره آی دی برای کومبو
        private int currentAccountID = 0;

        //برای نمایش در فیلدهای مربوطه
        int selectedID = 0;
        DateTime selectedIncomeDate;
        int selectedAmount = 0;

        public frmIncomeRegistration()
        {
            InitializeComponent();
        }

        public frmIncomeRegistration(int SelectedID) : this()
        {
            selectedID = SelectedID;
        }

        private void frmIncomeRegistration_Load(object sender, EventArgs e)
        {
            LoadCmbAccountNumber();
            if (selectedID != 0)
            {
                LoadCurrentIncome(selectedID);
            }
        }

        /// <summary>
        /// لود کردن شماره حساب ها
        /// </summary>
        private void LoadCmbAccountNumber()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "usp_Tbl_FinancialAccount_SelectNameAndAccount";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                //---------- gridLookUpEdit کنترل -------------
                cmbAccountNumber.Properties.DataSource = ds.Tables[0];
                cmbAccountNumber.Properties.DisplayMember = "AccInfo";
                cmbAccountNumber.Properties.ValueMember = "AccountID";


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
        /// نمایش اطلاعات انتخاب شده
        /// </summary>
        /// <param name="
        /// selectedID">شناسه داده</param>
        private void LoadCurrentIncome(int SelectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "usp_Tbl_Income_SelectRow";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IncomeID", SelectedID);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("هیچ داده ای وجود ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmbAccountNumber.Properties.NullText = ds.Tables[0].Rows[0]["AccountNumber"].ToString();
                cmbAccountNumber.Enabled = false;
                txtAccountType.Text = ds.Tables[0].Rows[0]["AccountType"].ToString();
                txtDepositor.Text = ds.Tables[0].Rows[0]["AccountOwner"].ToString();
                txtBankName.Text = ds.Tables[0].Rows[0]["BankName"].ToString();
                txtAmount.Value = Convert.ToUInt32(ds.Tables[0].Rows[0]["Amount"]);
                selectedAmount = Convert.ToInt32(txtAmount.Value);
                txtDescription.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                DateTime.TryParse(ds.Tables[0].Rows[0]["IncomeDate"].ToString().Trim(), out selectedIncomeDate);
                txtIncomeDate.Value = selectedIncomeDate.Equals(new DateTime(1, 1, 1)) ? null : (DateTime?)selectedIncomeDate;
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

        private void cmbAccountNumber_EditValueChanged(object sender, EventArgs e)
        {
            object obj = cmbAccountNumber.GetSelectedDataRow();

            if (obj == null)
                return;

            DataRowView drView = (DataRowView)obj;
            object[] currentRowValues = drView.Row.ItemArray;
            currentAccountID = Convert.ToInt32(currentRowValues[0]);
            txtDepositor.Text = currentRowValues[2].ToString();
            txtBankName.Text = currentRowValues[3].ToString();
            txtAccountType.Text = currentRowValues[4].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
            if (txtAmount.Value == 0 || txtIncomeDate.Value == null || txtDescription.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل و درست وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedID == 0)
            {
                InsertIncome();
            }
            else
                UpdateCurrentIncome();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// افزودن درآمد جدید
        /// </summary>
        private void InsertIncome()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                //افزایش موجودی حساب مالی
                string str = "";
                int str2 = 0;
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select Balance from Tbl_FinancialAccount where AccountNumber = '" + cmbAccountNumber.Text + "'", conn);
                str = Convert.ToString((int)cmd2.ExecuteScalar());
                str2 = Convert.ToInt32(txtAmount.Value);
                int a = 0;
                a = Int32.Parse(str) + str2;
                string updatequery = "update Tbl_FinancialAccount set Balance ='" + a + "' where AccountNumber= '" + cmbAccountNumber.Text + "'";
                SqlCommand cmd3 = new SqlCommand(updatequery, conn);
                cmd3.ExecuteNonQuery();

                string query = "[dbo].[usp_Tbl_Income_InsertRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("AccountID", currentAccountID);
                cmd.Parameters.AddWithValue("Amount", txtAmount.Value);
                cmd.Parameters.AddWithValue("IncomeDate", txtIncomeDate.Value);
                cmd.Parameters.AddWithValue("IncomeDateShamsi", txtIncomeDate.GetText("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("Description", txtDescription.Text);

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
        /// ویرایش هزینه
        /// </summary>
        private void UpdateCurrentIncome()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                conn.Open();
                if (txtAmount.Value != selectedAmount)
                {
                    //افزایش موجودی حساب مالی
                    string str = "";
                    int str2 = 0;
                    SqlCommand cmd2 = new SqlCommand("select Balance from Tbl_FinancialAccount where AccountNumber = '" + cmbAccountNumber.Text + "'", conn);
                    str = Convert.ToString((int)cmd2.ExecuteScalar());
                    str2 = Convert.ToInt32(txtAmount.Value);
                    int a = 0;
                    a = (Int32.Parse(str) - selectedAmount) + str2;
                    string updatequery = "update Tbl_FinancialAccount set Balance ='" + a + "' where AccountNumber = '" + cmbAccountNumber.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(updatequery, conn);
                    cmd3.ExecuteNonQuery();
                }
                
                string query = "[dbo].[usp_Tbl_Income_UpdateRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IncomeID", selectedID);
                cmd.Parameters.AddWithValue("Amount", txtAmount.Value);
                cmd.Parameters.AddWithValue("IncomeDate", txtIncomeDate.Value);
                cmd.Parameters.AddWithValue("IncomeDateShamsi", txtIncomeDate.GetText("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("Description", txtDescription.Text);

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

        // ارور پر کردن تکست باکس ها
        private bool IsDescriptionValid()
        {
            return txtDescription.Text.Length > 0;
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (!IsDescriptionValid())
            {
                IncomeErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                IncomeErrorProvider.SetError((Control)sender, "لطفا توضیحات درآمد را وارد کنید");
            }
            else
            {
                IncomeErrorProvider.SetError((Control)sender, "");
            }
        }
    }
}