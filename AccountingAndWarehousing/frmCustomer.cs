﻿using System;
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
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        int selectedID = 0;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
                LoadGrdCustomer();
            }
        }

        /// <summary>
        /// حذف مشتری
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteRow(int selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Customer_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Customer" +
                    "ID", selectedID);
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

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadGrdCustomer();
        }

        /// <summary>
        /// نمایش اطلاعات مشتری ها
        /// </summary>
        public void LoadGrdCustomer()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Customer_SelectAll]";
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

        private void grdCustomer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = grdCustomer.GetDataRow(e.RowHandle);
            selectedID = Convert.ToInt32(dr["CustomerID"]);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmCustomerRegistration frmCustomerRegistration = new frmCustomerRegistration();
            DialogResult result = frmCustomerRegistration.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadGrdCustomer();
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
                frmCustomerRegistration frmCustomerRegistration = new frmCustomerRegistration(selectedID);
                DialogResult result = frmCustomerRegistration.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadGrdCustomer();
                }
            }
        }
    }
}