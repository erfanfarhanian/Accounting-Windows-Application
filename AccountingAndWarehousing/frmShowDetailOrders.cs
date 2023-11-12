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
    public partial class frmShowDetailOrders : DevExpress.XtraEditors.XtraForm
    {
        public int CurrentOrderID { get; set; }

        int sum = 0;

        public frmShowDetailOrders(int currentOrderID, string personCodeName, string date)
        {
            InitializeComponent();
            CurrentOrderID = currentOrderID;

            lblCurrentPersonCodeName.Text += personCodeName;
            lblDate.Text += date;
            lblOrderID.Text += currentOrderID;
        }

        private void frmShowDetailOrders_Load(object sender, EventArgs e)
        {
            LoadGridByOrderID(CurrentOrderID);
            GetTotalSum(CurrentOrderID);
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);
                sum += Convert.ToInt32(dr["RowTotalPrice"]);
            }
        }

        /// <summary>
        /// نمایش جزییات سفارش
        /// </summary>
        /// <param name="orderID">سفارش انتخاب شده</param>
        private void LoadGridByOrderID(int orderID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_OrderDetail_SelectByOrderID]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OrderID", orderID);

                conn.Open();

                DataSet dsOrders = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsOrders);
                gridOrderDetails.DataSource = dsOrders.Tables[0];
            }

            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "/n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// مجموع آیتم های یک سفارش را حساب میکند
        /// </summary>
        /// <param name="orderID">کد سفارش</param>
        private void GetTotalSum(int orderID)
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_OrderDetail_SumOfOrder]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderHeaderID", orderID);
                conn.Open();
                lblTotal.Text += cmd.ExecuteScalar();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "/n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            frmDeposit frm = new frmDeposit();
            frm.txtDepositAmount.Value = sum;
            frm.txtDescription.Text = "پرداخت صورت حساب به  " + lblOrderID.Text;
            frm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(@"ReportFiles\RptCustomerInvoiceSelectByID.mrt");
            report.Compile();
            report["OrderHeaderID"] = CurrentOrderID;
            report.ShowWithRibbonGUI();
        }
    }
}