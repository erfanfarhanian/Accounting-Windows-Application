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
    public partial class frmOrders : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// مشتری انتخاب شده از کمبو
        /// </summary>
        private Int32 CurrentCustomerID = 0;

        /// <summary>
        /// محصول انتخاب شده از کمبو
        /// </summary>
        private Int32 CurrentProductID = 0;

        /// <summary>
        /// لیست سفارشات جاری که هنوز در دیتابیس ثبت نشده اند
        /// </summary>
        List<OrdersView> OrdersList = new List<OrdersView>();

        /// <summary>
        /// ردیف انتخاب شده از گرید
        /// </summary>
        private Int32 SelectedProductID = 0;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadCmbCustomer();
            LoadCmbProduct();
        }

        /// <summary>
        /// لود کردن مشتری در کومبو
        /// </summary>
        private void LoadCmbCustomer()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Customer_SelectNameAndAddress]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                //---------- gridLookUpEdit کنترل -------------
                cmbCustomer.Properties.DataSource = ds.Tables[0];
                cmbCustomer.Properties.DisplayMember = "IDFullName";
                cmbCustomer.Properties.ValueMember = "CustomerID";


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
        /// لود کردن محصول در کومبو
        /// </summary>
        private void LoadCmbProduct()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Product_SelectNameCodePrice]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                //---------- gridLookUpEdit کنترل -------------
                cmbProduct.Properties.DataSource = ds.Tables[0];
                cmbProduct.Properties.DisplayMember = "CodeName";
                cmbProduct.Properties.ValueMember = "ProductID";


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

        private void cmbCustomer_EditValueChanged(object sender, EventArgs e) //نمایش آدرس مشتری
        {
           
            object obj = cmbCustomer.GetSelectedDataRow();

            if (obj == null)
                return;

            DataRowView drView = (DataRowView)obj;
            object[] currentRowValues = drView.Row.ItemArray;
            CurrentCustomerID = Convert.ToInt32(currentRowValues[0]);
            txtAddress.Text = currentRowValues[2].ToString();
        } 

        private void cmbProduct_EditValueChanged(object sender, EventArgs e) //نمایش قیمت واحد کالا
        {
            
            object obj = cmbProduct.GetSelectedDataRow();

            if (obj == null)
                return;

            DataRowView drView = (DataRowView)obj;
            object[] currentRowValues = drView.Row.ItemArray;
            CurrentProductID = Convert.ToInt32(currentRowValues[0]);
            txtPrice.Text = currentRowValues[2].ToString();

            txtCount.Value = 1;
        } 

        private void txtPriceOrCount_ValueChanged(object sender, EventArgs e)  // محاسبه و نمایش تخفیف
        {
            int price = int.Parse(txtPrice.Value.ToString());
            int count = Convert.ToInt16(txtCount.Value);
            int discount = Convert.ToInt32((price * count) * 0.1);
            txtDiscount.Text = discount.ToString();
        }

        private void btnAddToOrders_Click(object sender, EventArgs e) //اضافه کردن به لیست
        {
            if (txtAddress.Text == string.Empty ||  cmbProduct.Text == string.Empty)
            {
                MessageBox.Show("لطفا مقادیر خواسته شده را به صورت کامل و صحیح وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BindingSource source = new BindingSource();
            OrdersList.Add(new OrdersView()
            {
                ProductID = CurrentProductID,
                ProductCodeName = cmbProduct.SelectedText,
                UnitPrice = Convert.ToInt32(txtPrice.Value),
                Quantity = Convert.ToInt16(txtCount.Value),
                Discount = Convert.ToInt32(txtDiscount.Text)
            });

            source.DataSource = OrdersList;
            gridOrders.DataSource = source;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsAddressValid())
                return;

            DialogResult res = MessageBox.Show("سفارش پس از ثبت نهایی شدن قابل تغییر نمی باشد" + "\n" + "آیا از ثبت نهایی این داده اطمینان دارید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;

            int currentOrderID = SaveData();

            if (currentOrderID == 0)
                return;

            int totalSum = GetTotalSum(currentOrderID);

            int totalPay = totalSum + Convert.ToInt32(txtFreight.Value);

            lblTotalSum.Text = totalSum.ToString();
            lblFreight.Text = txtFreight.Value.ToString();
            lblTotalPay.Text = totalPay.ToString();
        }

        /// <summary>
        /// ثبت سفارش و جزییات سفارش در دیتابیس
        /// </summary>
        /// <returns>کد سفارش برگشت داده میشود</returns>
        private int SaveData()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_OrderHeader_InsertRow]";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //---------- Order Header ----------------------

                cmd.Parameters.AddWithValue("@CustomerID", CurrentCustomerID);
                cmd.Parameters.AddWithValue("@ShipAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Freight", Convert.ToInt32(txtFreight.Value));

                SqlParameter returnValue = cmd.Parameters.Add("@OrderHeaderID", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                int OrderHeaderID = (int)cmd.Parameters["@OrderHeaderID"].Value;
                conn.Close();

                //----------------------------------------------

                foreach (OrdersView item in OrdersList)
                {
                    SqlCommand cmd2 = new SqlCommand("[dbo].[usp_Tbl_OrderDetail_InsertRow]", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.AddWithValue("@OrderHeaderID", OrderHeaderID);
                    cmd2.Parameters.AddWithValue("@ProductID", item.ProductID);
                    cmd2.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                    cmd2.Parameters.AddWithValue("@Quantity", item.Quantity);
                    cmd2.Parameters.AddWithValue("@Discount", item.Discount);
                    cmd2.Parameters.AddWithValue("@RowTotalPrice", item.RowTotalPrice);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    cmd2.ExecuteNonQuery();
                }

                return OrderHeaderID;

            }

            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "/n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// مجموع آیتم های یک سفارش را حساب میکند
        /// </summary>
        /// <param name="orderHeaderID">کد سفارش</param>
        /// <returns>مجموع آیتم های یک سفارش</returns>
        private Int32 GetTotalSum(int orderHeaderID)
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_OrderDetail_SumOfOrder]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderHeaderID", orderHeaderID);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "/n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            finally
            {
                conn.Close();
            }
        }

        //چک کردن پر بودن تکست باکس
        private bool IsAddressValid()
        {
            return txtAddress.Text.Length > 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا از حذف این داده اطمینان دارید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;

            if (result == DialogResult.No)
                return;

            DeleteData();
        }

        /// <summary>
        /// حذف آیتم مورد نظر از لیست 
        /// قبل از اینکه در دیتابیس ذخیره شود
        /// </summary>
        private void DeleteData()
        {
            //Lambda Expressions
            // OrdersList.RemoveAll(x => x.ProductID == SelectedProductID);

            OrdersList.RemoveAll(o => o.ProductID == SelectedProductID);
            gridOrders.DataSource = OrdersList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// آیتم های لیست پاک میشوند - گرید خالی میشود 
        /// </summary>
        private void New()
        {
            txtFreight.Value = 0;
            txtCount.Value = txtPrice.Value = 1;

            cmbProduct.EditValue = cmbCustomer.EditValue =
            cmbCustomer.Text = cmbProduct.Text =
            txtAddress.Text = txtDiscount.Text = "";

            CurrentCustomerID = CurrentProductID =
            SelectedProductID = 0;

            OrdersList.Clear();
            gridOrders.DataSource = OrdersList;
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (!IsAddressValid())
            {
                OrdersErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                OrdersErrorProvider.SetError((Control)sender, "لطفا آدرس را وارد کنید");
            }
            else
            {
                OrdersErrorProvider.SetError((Control)sender, "");
            }
        }

        private void gridViewOrders_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            object focusedRow = gridViewOrders.GetFocusedRow();
            OrdersView currentOrderView = (OrdersView)focusedRow;
            SelectedProductID = currentOrderView.ProductID;
        }

        private void frmOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult res = MessageBox.Show("در صورت بسته شدن فرم اگر سفارش نهایی نشده باشد حذف خواهد شد" + "\n" + "آیا از بستن این فرم اطمینان دارید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (res == System.Windows.Forms.DialogResult.No)
            //    e.Cancel = true;

            //OrdersList.Clear();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("با کلیک برروی این گزینه سفارش جاری لغو می شود" + "\n" + "آیا مطمعن هستید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;
            else
                New();
        }
    }
}