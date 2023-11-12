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
    public partial class frmDeposit : DevExpress.XtraEditors.XtraForm
    {
        //ذخیره آی دی برای کومبو
        private int currentAccountID = 0;

        //برای نمایش گرید
        private int selectedID = 0;
        private int selectedDepositAmount = 0;
        private int selectedRowIndex = 0;

        private string selectedAccountNumber = string.Empty;
        private string selectedAccountOwner = string.Empty;
        private string selectedBankName = string.Empty;
        private string selectedAccountType = string.Empty;
        private string selectedDescription = string.Empty;

        DateTime selectedDepositDate;

        private bool isEditMode = false;
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            LoadCmbAccountNumber();
            LoadGrdDeposit();
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

        private void grdDeposit_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = grdDeposit.GetDataRow(e.RowHandle);
            selectedID = Convert.ToInt32(dr["DepositID"]);
            selectedDepositAmount = Convert.ToInt32(dr["DepositAmount"]);

            selectedAccountType = dr["AccountType"].ToString();
            selectedAccountOwner = dr["AccountOwner"].ToString();
            selectedBankName = dr["BankName"].ToString();
            selectedAccountNumber = dr["AccountNumber"].ToString();
            selectedDescription = dr["Description"].ToString();

            DateTime.TryParse(dr["DepositDate"].ToString(), out selectedDepositDate);

            selectedRowIndex = e.RowHandle;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            txtDepositAmount.Value = 0;
            selectedRowIndex = 0;
            cmbAccountNumber.Properties.NullText = string.Empty;
            cmbAccountNumber.Enabled = true;
            txtDepositor.Text = string.Empty;
            txtBankName.Text = string.Empty;
            txtAccountType.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtDepositDate.Value = null;
            DepositErrorProvider.Clear();
            isEditMode = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (selectedID == 0)
            //{
            //    MessageBox.Show("ردیفی انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //txtAccountType.Text = selectedAccountType;
            //txtBankName.Text = selectedBankName;
            //txtDepositor.Text = selectedAccountOwner;
            //cmbAccountNumber.Text = selectedAccountNumber;
            //txtDepositAmount.Value = selectedDepositAmount;
            //txtDescription.Text = selectedDescription;
            //txtDepositDate.Value = selectedDepositDate.Equals(new DateTime(1, 1, 1)) ? null : (DateTime?)selectedDepositDate;
            //isEditMode = true;
            //cmbAccountNumber.ReadOnly = true;
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
                LoadGrdDeposit();
            }
        }

        /// <summary>
        /// نمایش اطلاعات واریزها
        /// </summary>
        private void LoadGrdDeposit()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Deposit_SelectAll]";
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

        /// <summary>
        /// حذف اطلاعات واریزها
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteRow(int selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Deposit_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("DepositID", selectedID);
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
            if (txtDepositAmount.Value == 0 || txtDepositDate.Value == null || txtDescription.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل و صحیح وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveData();
            LoadGrdDeposit();
            UpdateAccountBalance();

            selectedID = 0;
            cmbAccountNumber.Properties.NullText = string.Empty;
            cmbAccountNumber.Enabled = true;
            txtAccountType.Text = string.Empty;
            txtBankName.Text = string.Empty;
            txtDepositor.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtDepositDate.Value = null;
            txtDepositAmount.Value = 0;
            isEditMode = false;
        }

        /// <summary>
        /// افزودن و ویرایش واریزی جدید
        /// </summary>
        private void SaveData()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                conn.Open();
                if (txtDepositAmount.Value != selectedDepositAmount && isEditMode)
                {
                    string str = "";
                    int str1 = 0;
                    SqlCommand cmd2 = new SqlCommand("select Balance from Tbl_FinancialAccount where AccountNumber = N'" + cmbAccountNumber.Text + "'", conn);
                    str = Convert.ToString((int)cmd2.ExecuteScalar());
                    str1 = Convert.ToInt32(txtDepositAmount.Value);
                    int a = 0; a = Int32.Parse(str) + str1;

                    a = (Int32.Parse(str) - selectedDepositAmount) + str1;

                    string updatequery = "update Tbl_FinancialAccount set Balance ='" + a + "' where AccountNumber= '" + cmbAccountNumber.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(updatequery, conn);
                    cmd3.ExecuteNonQuery();
                }
                else if (!isEditMode)
                {
                    string str = "";
                    int str1 = 0;
                    SqlCommand cmd2 = new SqlCommand("select Balance from Tbl_FinancialAccount where AccountNumber = N'" + cmbAccountNumber.Text + "'", conn);
                    str = Convert.ToString((int)cmd2.ExecuteScalar());
                    str1 = Convert.ToInt32(txtDepositAmount.Value);
                    int a = 0; a = Int32.Parse(str) + str1;

                    a = Int32.Parse(str) + str1;

                    string updatequery = "update Tbl_FinancialAccount set Balance ='" + a + "' where AccountNumber= '" + cmbAccountNumber.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(updatequery, conn);
                    cmd3.ExecuteNonQuery();
                }
                string query = "";
                if (isEditMode)
                    query = "[dbo].[usp_Tbl_Deposit_UpdateRow]";

                else
                    query = "[dbo].[usp_Tbl_Deposit_InsertRow]";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (!isEditMode)
                {
                    cmd.Parameters.AddWithValue("@AccountID", currentAccountID);
                }
                cmd.Parameters.AddWithValue("@DepositAmount", txtDepositAmount.Value);
                cmd.Parameters.AddWithValue("@DepositDate", txtDepositDate.Value); // از نوع DateTime
                cmd.Parameters.AddWithValue("@DepositDateShamsi", txtDepositDate.GetText("yyyy/MM/dd")); // از نوع رشته
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);


                if (isEditMode)
                {
                    cmd.Parameters.AddWithValue("DepositID", selectedID);
                }
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    LoadGrdDeposit();
                    grdDeposit.TopRowIndex = selectedRowIndex;
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

        /// <summary>
        /// ویرایش موجودی حساب های مالی
        /// </summary>
        private void UpdateAccountBalance()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                conn.Open();



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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            new frmFinancialAccount().ShowDialog();
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
                DepositErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                DepositErrorProvider.SetError((Control)sender, "لطفا توضیحات واریز را وارد کنید");
            }
            else
            {
                DepositErrorProvider.SetError((Control)sender, "");
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DepositErrorProvider.Clear();
            txtBankName.Text = selectedBankName;
            txtAccountType.Text = selectedAccountType;
            txtDepositor.Text = selectedAccountOwner;
            txtDepositAmount.Value = selectedDepositAmount;
            txtDescription.Text = selectedDescription;
            cmbAccountNumber.Properties.NullText = selectedAccountNumber;
            cmbAccountNumber.Enabled = false;
            txtDepositDate.Value = selectedDepositDate.Equals(new DateTime(1, 1, 1)) ? null : (DateTime?)selectedDepositDate;
            isEditMode = true;
        }
    }
}