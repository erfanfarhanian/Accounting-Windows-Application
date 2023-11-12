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
    public partial class frmPaymentDocuments : DevExpress.XtraEditors.XtraForm
    {
        int selectedID = 0;
        public int selectedAmount = 0;

        private string selectedAccountNumber = string.Empty;
        private string selectedSituation = string.Empty;

        public static bool isPaymentDoc = false;

        public frmPaymentDocuments()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnShowFinancialAccount_Click(object sender, EventArgs e)
        {
            new frmFinancialAccount().ShowDialog();
        }

        private void frmPaymentDocuments_Load(object sender, EventArgs e)
        {
            LoadGrdPaymentDocument();
        }

        /// <summary>
        /// نمایش اطلاعات اسناد پرداختی
        /// </summary>
        public void LoadGrdPaymentDocument()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_PaymentDocument_SelectAll]";
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
                LoadGrdPaymentDocument();
            }
        }

        /// <summary>
        /// حذف سند پرداختی
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteRow(int selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_PaymentDocument_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("PaymentDocID", selectedID);
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

        private void grdPaymentDoc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = grdPaymentDoc.GetDataRow(e.RowHandle);
            selectedID = Convert.ToInt32(dr["PaymentDocID"]);
            selectedAmount = Convert.ToInt32(dr["Amount"]);
            selectedAccountNumber = dr["AccountNumber"].ToString();
            selectedSituation = dr["Situation"].ToString();
            if (selectedSituation == "وصول شده")
            {
                btnReceipt.Enabled = false;
            }
            else
                btnReceipt.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmPaymentRegistration frmPaymentRegistration = new frmPaymentRegistration();
            DialogResult result = frmPaymentRegistration.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadGrdPaymentDocument();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0)
            {
                MessageBox.Show("هیچ داده ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                frmPaymentRegistration frmPaymentRegistration = new frmPaymentRegistration(selectedID);
                DialogResult result = frmPaymentRegistration.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadGrdPaymentDocument();
                }
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {            
            Receipt();
        }

        /// <summary>
        /// وصول سند پرداختی
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void Receipt()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string str = "";
                int str2 = 0;
                conn.Open();
                SqlCommand cmd = new SqlCommand("select Balance from Tbl_FinancialAccount where AccountNumber = '" + selectedAccountNumber + "'", conn);
                str = Convert.ToString((int)cmd.ExecuteScalar());
                str2 = Convert.ToInt32(selectedAmount);
                int a = 0;
                if (str2 > Convert.ToInt32(str))
                {
                    MessageBox.Show("موجودی حساب برای وصول این سند کافی نمی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                    a = Int32.Parse(str) - str2;
                string updatequery = "update Tbl_FinancialAccount set Balance ='" + a + "' where AccountNumber= '" + selectedAccountNumber + "'";
                SqlCommand cmd2 = new SqlCommand(updatequery, conn);
                cmd2.ExecuteNonQuery();

                string updateSitaution = "update Tbl_PaymentDocument set Situation = N'" + "وصول شده" + "' where PaymentDocID= '" + selectedID + "'";
                SqlCommand cmd3 = new SqlCommand(updateSitaution, conn);
                cmd3.ExecuteNonQuery();
                LoadGrdPaymentDocument();
                
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

        private void btnPaymentDocReport_Click(object sender, EventArgs e)
        {
            isPaymentDoc = true;
            frmPaymentOrDepositDocByDate frm = new frmPaymentOrDepositDocByDate();
            frm.ShowDialog();
        }
    }
}