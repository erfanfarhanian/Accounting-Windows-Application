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
    public partial class frmPayment : DevExpress.XtraEditors.XtraForm
    {
        //ذخیره آی دی برای کومبو
        private int currentAccountID = 0;

        //برای نمایش گرید
        private int selectedID = 0;
        private int selectedRowIndex = 0;
        private int selectedPaymentAmount = 0;

        private string selectedDescription = string.Empty;
        private string selectedAccountType = string.Empty;
        private string selectedBankName = string.Empty;
        private string selectedAccountOwner = string.Empty;
        private string selectedAccountNumber = string.Empty;

        private DateTime selectedPaymentDate;

        private bool isEditMode = false;
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            new frmFinancialAccount().ShowDialog();
        }

        private void grdPayment_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = grdPayment.GetDataRow(e.RowHandle);
            selectedID = Convert.ToInt32(dr["PaymentID"]);
            selectedPaymentAmount = Convert.ToInt32(dr["PaymentAmount"]);

            selectedAccountOwner = dr["AccountOwner"].ToString();
            selectedBankName = dr["BankName"].ToString();
            selectedAccountType = dr["AccountType"].ToString();
            selectedDescription = dr["Description"].ToString();
            selectedAccountNumber = dr["AccountNumber"].ToString();

            DateTime.TryParse(dr["PaymentDate"].ToString(), out selectedPaymentDate);

            selectedRowIndex = e.RowHandle;
        }

        private void cmbAccountNumber_EditValueChanged(object sender, EventArgs e)
        {
            object obj = cmbAccountNumber.GetSelectedDataRow();

            if (obj == null)
                return;

            DataRowView drView = (DataRowView)obj;
            object[] currentRowValues = drView.Row.ItemArray;
            currentAccountID = Convert.ToInt32(currentRowValues[0]);
            txtPayer.Text = currentRowValues[2].ToString();
            txtBankName.Text = currentRowValues[3].ToString();
            txtAccountType.Text = currentRowValues[4].ToString();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            LoadCmbAccountNumber();
            LoadGrdPayment();
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
        /// نمایش اطلاعات پرداخت ها
        /// </summary>
        private void LoadGrdPayment()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Payment_SelectAll]";
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
                LoadGrdPayment();
            }
        }

        /// <summary>
        /// حذف اطلاعات پرداخت ها
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteRow(int selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Payment_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("PaymentID", selectedID);
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
            if (txtPaymentAmount.Value == 0 || txtPaymentDate.Value == null || txtDescription.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل و صحیح وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveData();
            LoadGrdPayment();

            selectedID = 0;
            PaymentErrorProvider.Clear();
            cmbAccountNumber.Properties.NullText = string.Empty;
            cmbAccountNumber.Enabled = true;
            txtAccountType.Text = string.Empty;
            txtBankName.Text = string.Empty;
            txtPayer.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPaymentDate.Value = null;
            txtPaymentAmount.Value = 0;
            isEditMode = false;
        }

        /// <summary>
        /// افزودن و ویرایش پرداختی جدید
        /// </summary>
        private void SaveData()
        {
            SqlConnection conn = new SqlConnection();

            try
            {

                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                conn.Open();
                if (txtPaymentAmount.Value != selectedPaymentAmount && isEditMode)
                {
                    // ویرایش موجودی حساب های مالی
                    string str = "";
                    int str1 = 0;
                    SqlCommand cmd = new SqlCommand("select Balance from Tbl_FinancialAccount where AccountNumber = N'" + cmbAccountNumber.Text + "'", conn);
                    str = Convert.ToString((int)cmd.ExecuteScalar());
                    str1 = Convert.ToInt32(txtPaymentAmount.Value);
                    if (txtPaymentAmount.Value > Convert.ToInt32(str))
                    {
                        MessageBox.Show("موجودی حساب برای پرداخت این مبلغ کافی نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int a = 0;
                    a = (selectedPaymentAmount + Int32.Parse(str)) - str1;

                    string updatequery = "update Tbl_FinancialAccount set Balance ='" + a + "' where AccountNumber= '" + cmbAccountNumber.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(updatequery, conn);
                    cmd2.ExecuteNonQuery();
                }
                else if (!isEditMode)
                {
                    // ویرایش موجودی حساب های مالی
                    string str = "";
                    int str1 = 0;
                    SqlCommand cmd = new SqlCommand("select Balance from Tbl_FinancialAccount where AccountNumber = N'" + cmbAccountNumber.Text + "'", conn);
                    str = Convert.ToString((int)cmd.ExecuteScalar());
                    str1 = Convert.ToInt32(txtPaymentAmount.Value);
                    if (txtPaymentAmount.Value > Convert.ToInt32(str))
                    {
                        MessageBox.Show("موجودی حساب برای پرداخت این مبلغ کافی نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int a = 0;
                    a = Int32.Parse(str) - str1;

                    string updatequery = "update Tbl_FinancialAccount set Balance ='" + a + "' where AccountNumber= '" + cmbAccountNumber.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(updatequery, conn);
                    cmd2.ExecuteNonQuery();
                }

                string query = "";

                if (isEditMode)
                    query = "[dbo].[usp_Tbl_Payment_UpdateRow]";
                else
                    query = "[dbo].[usp_Tbl_Payment_InsertRow]";

                SqlCommand cmd3 = new SqlCommand(query, conn);
                cmd3.CommandType = CommandType.StoredProcedure;
                if (!isEditMode)
                {
                    cmd3.Parameters.AddWithValue("@AccountID", currentAccountID);
                }

                cmd3.Parameters.AddWithValue("@PaymentDate", txtPaymentDate.Value); // از نوع DateTime
                cmd3.Parameters.AddWithValue("@PaymentDateShamsi", txtPaymentDate.GetText("yyyy/MM/dd")); // از نوع رشته
                cmd3.Parameters.AddWithValue("@PaymentAmount", txtPaymentAmount.Value);
                cmd3.Parameters.AddWithValue("@Description", txtDescription.Text);
                if (isEditMode)
                {
                    cmd3.Parameters.AddWithValue("PaymentID", selectedID);
                }
                int rowsAffected = cmd3.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    LoadGrdPayment();
                    grdPayment.TopRowIndex = selectedRowIndex;
                }


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
        private bool IsDescriptionValid()
        {
            return txtDescription.Text.Length > 0;
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (!IsDescriptionValid())
            {
                PaymentErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                PaymentErrorProvider.SetError((Control)sender, "لطفا توضیحات پرداخت را وارد کنید");
            }
            else
            {
                PaymentErrorProvider.SetError((Control)sender, "");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            txtPaymentAmount.Value = 0;
            selectedRowIndex = 0;
            cmbAccountNumber.Properties.NullText = string.Empty;
            txtPayer.Text = string.Empty;
            txtBankName.Text = string.Empty;
            txtAccountType.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPaymentDate.Value = null;
            PaymentErrorProvider.Clear();
            cmbAccountNumber.Enabled = true;
            isEditMode = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PaymentErrorProvider.Clear();
            txtBankName.Text = selectedBankName;
            txtAccountType.Text = selectedAccountType;
            txtPayer.Text = selectedAccountOwner;
            txtPaymentAmount.Value = selectedPaymentAmount;
            txtDescription.Text = selectedDescription;
            cmbAccountNumber.Properties.NullText = selectedAccountNumber;
            cmbAccountNumber.Enabled = false;
            txtPaymentDate.Value = selectedPaymentDate.Equals(new DateTime(1, 1, 1)) ? null : (DateTime?)selectedPaymentDate;
            isEditMode = true;
        }
    }
}