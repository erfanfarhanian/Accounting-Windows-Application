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
using AccountingAndWarehousing.Classes;

namespace AccountingAndWarehousing
{
    public partial class frmShowOrders : DevExpress.XtraEditors.XtraForm
    {
        public frmShowOrders()
        {
            InitializeComponent();
            gridViewOrders.OptionsView.RowAutoHeight = true;
        }

        private void frmShowOrders_Load(object sender, EventArgs e)
        {
            gridViewOrders.OptionsView.RowAutoHeight = true;
            LoadGrid();
            LoadStatistics();
        }

        /// <summary>
        /// نمایش سفارشات
        /// </summary>
        private void LoadGrid()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_OrderHeader_SelectAll]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet dsOrders = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsOrders);
                gridOrders.DataSource = dsOrders.Tables[0];
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

        private void LoadStatistics()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Orders_Statistics]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                DataSet dsStatistics = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsStatistics);

                lblOrderCount.Text += dsStatistics.ReturnFieldValue(0, "OrderCount");
                lblOrderTotal.Text += dsStatistics.ReturnFieldValue(1, "OrderTotal");

                if (dsStatistics.ReturnFieldValue(0, "OrderCount").Equals("0"))
                    return;

                lblMaxOrder.Text += dsStatistics.ReturnFieldValue(2, "MaxOrder");
                lblMinOrder.Text += dsStatistics.ReturnFieldValue(3, "MinOrder");
                lblFirstOrder.Text += dsStatistics.ReturnFieldValue(4, "FirstOrder");
                lblLastOrder.Text += dsStatistics.ReturnFieldValue(5, "LastOrder");
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

        private void gridViewOrders_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            object obj = gridViewOrders.GetFocusedRow();

            if (obj == null)
                return;

            DataRowView drView = (DataRowView)obj;
            object[] currentRowValues = drView.Row.ItemArray;

            string codeNameFamil = currentRowValues[1] + " " + currentRowValues[0];
            string date = currentRowValues[3].ToString();
            int orderID = (int)currentRowValues[2];

            frmShowDetailOrders frm = new frmShowDetailOrders(orderID, codeNameFamil, date);
            frm.ShowDialog();
        }
    }
}