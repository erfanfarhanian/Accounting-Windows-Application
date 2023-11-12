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
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        int selectedID = 0;
        //public static int selectedGroupID = 0;        
        //public static int selectedRowIndex = 0;

        //public static string selectedPurchasePrice = string.Empty;
        //public static string selectedSellingPrice = string.Empty;
        //public static string selectedProductNumber = string.Empty;
        //public static string selectedProductName = string.Empty;
        //public static string selectedProductCode = string.Empty;
        //public static string selectedUnit = string.Empty;

        //public static byte[] ImageBinary;
        //public static byte[] selectedImageBinary;

        //public static Boolean IsEditMode = false;

        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadGrdProduct();
        }

        /// <summary>
        /// نمایش اطلاعات کالاها
        /// </summary>
        public void LoadGrdProduct()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Product_SelectAll]";
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

        private void grdProduct_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = grdProduct.GetDataRow(e.RowHandle);
            selectedID = Convert.ToInt32(dr["ProductID"]);            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmGoodsRegistration frmGoodsRegistration = new frmGoodsRegistration();
            DialogResult result = frmGoodsRegistration.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadGrdProduct();               
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
                frmGoodsRegistration frmGoodsRegistration = new frmGoodsRegistration(selectedID);
                DialogResult result = frmGoodsRegistration.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadGrdProduct();
                }
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
                LoadGrdProduct();
            }
        }

        /// <summary>
        /// حذف کالا
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteRow(int selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Product_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ProductID", selectedID);
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

        private void btnProductReport_Click(object sender, EventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(@"ReportFiles\RptProduct.mrt");
            report.Compile();
            report.ShowWithRibbonGUI();
        }
    }
}