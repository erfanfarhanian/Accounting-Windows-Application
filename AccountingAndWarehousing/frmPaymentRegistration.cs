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
    public partial class frmPaymentRegistration : DevExpress.XtraEditors.XtraForm
    {
        //ذخیره آی دی برای کومبو
        private int currentAccountID = 0;

        //برای نمایش در فیلدهای مربوطه
        int selectedID = 0;
        DateTime selectedRegistrationDate;
        DateTime selectedDueDate;
        int selectedAmount = 0;
        public frmPaymentRegistration()
        {
            InitializeComponent();
        }

        public frmPaymentRegistration(int SelectedID) : this()
        {
            selectedID = SelectedID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
            if (txtRegistrationDate.Value == null || txtDueDate.Value == null || txtDocumentNumber.Text == "" || txtCustomerName.Text == "" || txtDescription.Text == "" || txtAmount.Value == 0 || cmbSituation.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل و درست وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtRegistrationDate.Value > txtDueDate.Value)
            {
                MessageBox.Show("تاریخ ثبت و تاریخ سررسید نامعتبر است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedID == 0)
            {
                InsertPaymentDocument();
            }
            else
                UpdateCurrentPaymentDocument();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// افزودن سند پرداختی جدید
        /// </summary>
        private void InsertPaymentDocument()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                if (cmbSituation.Text == "وصول شده")
                {
                    string str = "";
                    int str2 = 0;
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("select Balance from Tbl_FinancialAccount where AccountNumber = '" + cmbAccountNumber.Text + "'", conn);
                    str = Convert.ToString((int)cmd2.ExecuteScalar());
                    str2 = Convert.ToInt32(txtAmount.Value);
                    int a = 0;
                    if (str2 > Convert.ToInt32(str))
                    {
                        MessageBox.Show("موجودی حساب برای وصول این سند کافی نمی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                        a = Int32.Parse(str) - str2;
                    string updatequery = "update Tbl_FinancialAccount set Balance ='" + a + "' where AccountNumber= '" + cmbAccountNumber.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(updatequery, conn);
                    cmd3.ExecuteNonQuery();

                    string updateSitaution = "update Tbl_PaymentDocument set Situation = N'" + "وصول شده" + "' where PaymentDocID= '" + selectedID + "'";
                    SqlCommand cmd4 = new SqlCommand(updateSitaution, conn);
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                }
                string query = "[dbo].[usp_Tbl_PaymentDocument_InsertRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("AccountID", currentAccountID);
                cmd.Parameters.AddWithValue("DocumentNumber", txtDocumentNumber.Text);
                cmd.Parameters.AddWithValue("CustomerName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("Amount", txtAmount.Value);
                cmd.Parameters.AddWithValue("RegistrationDate", txtRegistrationDate.Value);
                cmd.Parameters.AddWithValue("RegistrationDateShamsi", txtRegistrationDate.GetText("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("DueDate", txtDueDate.Value);
                cmd.Parameters.AddWithValue("DueDateShamsi", txtDueDate.GetText("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("Situation", cmbSituation.Text);
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
        /// ویرایش سند پرداختی
        /// </summary>
        private void UpdateCurrentPaymentDocument()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                if (cmbSituation.Text == "وصول شده")
                {
                    if (txtAmount.Value != selectedAmount)
                    {
                        string str = "";
                        int str2 = 0;
                        conn.Open();
                        SqlCommand cmd2 = new SqlCommand("select Balance from Tbl_FinancialAccount where AccountNumber = '" + cmbAccountNumber.Text + "'", conn);
                        str = Convert.ToString((int)cmd2.ExecuteScalar());
                        str2 = Convert.ToInt32(txtAmount.Value);
                        int a = 0;
                        if (str2 > Convert.ToInt32(str))
                        {
                            MessageBox.Show("موجودی حساب برای وصول این سند کافی نمی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                            a = (selectedAmount + Int32.Parse(str)) - str2;
                        string updatequery = "update Tbl_FinancialAccount set Balance ='" + a + "' where AccountNumber= '" + cmbAccountNumber.Text + "'";
                        SqlCommand cmd3 = new SqlCommand(updatequery, conn);
                        cmd3.ExecuteNonQuery();

                        string updateSitaution = "update Tbl_PaymentDocument set Situation = N'" + "وصول شده" + "' where PaymentDocID= '" + selectedID + "'";
                        SqlCommand cmd4 = new SqlCommand(updateSitaution, conn);
                        cmd4.ExecuteNonQuery();
                        conn.Close();
                    }                    
                }
                string query = "[dbo].[usp_Tbl_PaymentDocument_UpdateRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("PaymentDocID", selectedID);
                cmd.Parameters.AddWithValue("DocumentNumber", txtDocumentNumber.Text);
                cmd.Parameters.AddWithValue("CustomerName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("Amount", txtAmount.Value);
                cmd.Parameters.AddWithValue("RegistrationDate", txtRegistrationDate.Value);
                cmd.Parameters.AddWithValue("RegistrationDateShamsi", txtRegistrationDate.GetText("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("DueDate", txtDueDate.Value);
                cmd.Parameters.AddWithValue("DueDateShamsi", txtDueDate.GetText("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("Situation", cmbSituation.Text);
                cmd.Parameters.AddWithValue("Description", txtDescription.Text);

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

        private void frmPaymentRegistration_Load(object sender, EventArgs e)
        {
            LoadCmbAccountNumber();
            if (selectedID != 0)
            {
                LoadCurrentPaymentDocument(selectedID);
            }
        }

        /// <summary>
        /// نمایش اطلاعات انتخاب شده
        /// </summary>
        /// <param name="
        /// selectedID">شناسه داده</param>
        private void LoadCurrentPaymentDocument(int SelectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "usp_Tbl_PaymentDocument_SelectRow";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("PaymentDocID", SelectedID);
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
                txtPayer.Text = ds.Tables[0].Rows[0]["AccountOwner"].ToString();
                txtDocumentNumber.Text = ds.Tables[0].Rows[0]["DocumentNumber"].ToString();
                txtBankName.Text = ds.Tables[0].Rows[0]["BankName"].ToString();
                txtAmount.Value = Convert.ToUInt32(ds.Tables[0].Rows[0]["Amount"]);
                //txtAmount.Enabled = false;
                selectedAmount = Convert.ToInt32(txtAmount.Value);
                txtCustomerName.Text = ds.Tables[0].Rows[0]["CustomerName"].ToString();
                txtDescription.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                cmbSituation.Text = ds.Tables[0].Rows[0]["Situation"].ToString();
                cmbSituation.Enabled = false;
                DateTime.TryParse(ds.Tables[0].Rows[0]["RegistrationDate"].ToString().Trim(), out selectedRegistrationDate);
                DateTime.TryParse(ds.Tables[0].Rows[0]["DueDate"].ToString(), out selectedDueDate);
                txtRegistrationDate.Value = selectedRegistrationDate.Equals(new DateTime(1, 1, 1)) ? null : (DateTime?)selectedRegistrationDate;
                txtDueDate.Value = selectedDueDate.Equals(new DateTime(1, 1, 1)) ? null : (DateTime?)selectedDueDate;
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

        // ارور پر کردن تکست باکس ها
        private bool IsDescriptionValid()
        {
            return txtDescription.Text.Length > 0;
        }

        private bool IsCustomerNameValid()
        {
            return txtCustomerName.Text.Length > 0;
        }

        private bool IsDocumentNumberValid()
        {
            return txtDocumentNumber.Text.Length > 0;
        }

        private bool IsSituationValid()
        {
            return cmbSituation.Text.Length > 0;
        }

        private void txtDocumentNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!IsDocumentNumberValid())
            {
                PaymentDocumentErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                PaymentDocumentErrorProvider.SetError((Control)sender, "لطفا شماره سند را وارد کنید");
            }
            else
            {
                PaymentDocumentErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsCustomerNameValid())
            {
                PaymentDocumentErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                PaymentDocumentErrorProvider.SetError((Control)sender, "لطفا نام مشتری را وارد کنید");
            }
            else
            {
                PaymentDocumentErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (!IsDescriptionValid())
            {
                PaymentDocumentErrorProvider2.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                PaymentDocumentErrorProvider2.SetError((Control)sender, "لطفا توضیحات پرداخت را وارد کنید");
            }
            else
            {
                PaymentDocumentErrorProvider2.SetError((Control)sender, "");
            }
        }

        private void cmbSituation_Validating(object sender, CancelEventArgs e)
        {
            if (!IsSituationValid())
            {
                PaymentDocumentErrorProvider2.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleLeft);
                PaymentDocumentErrorProvider2.SetError((Control)sender, "لطفا وضعیت را انتخاب کنید");
            }
            else
            {
                PaymentDocumentErrorProvider2.SetError((Control)sender, "");
            }
        }

        private void txtDocumentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}