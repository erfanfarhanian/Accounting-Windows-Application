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
using System.IO;

namespace AccountingAndWarehousing
{
    public partial class frmGoodsRegistration : DevExpress.XtraEditors.XtraForm
    {
        int selectedID = 0;
        //private Boolean IsEditMode = false;
        private byte[] imageBinary;
        public frmGoodsRegistration()
        {
            InitializeComponent();
        }

        public frmGoodsRegistration(int SelectedID) : this()
        {
            selectedID = SelectedID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmGoodsRegistration_Load(object sender, EventArgs e)
        {
            LoadComboGrouping();
            LoadComboWarehouse();
            if (selectedID != 0)
            {
                LoadCurrentProduct(selectedID);
            }

        }

        /// <summary>
        /// نمایش اطلاعات انتخاب شده
        /// </summary>
        /// <param name="
        /// productID">شناسه داده</param>
        private void LoadCurrentProduct(int SelectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "usp_Tbl_Product_SelectRow";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ProductID", SelectedID);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("هیچ داده ای وجود ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtProductName.Text = ds.Tables[0].Rows[0]["ProductName"].ToString();
                txtProductCode.Text = ds.Tables[0].Rows[0]["ProductCode"].ToString();
                txtUnit.Text = ds.Tables[0].Rows[0]["Unit"].ToString();
                txtUnitPrice.Value = Convert.ToUInt32(ds.Tables[0].Rows[0]["UnitPrice"]);
                cmbGrouping.SelectedValue = ds.Tables[0].Rows[0]["GroupID"];
                cmbWarehouse.SelectedValue = ds.Tables[0].Rows[0]["WarehouseID"];
                picBox.Image = (ds.Tables[0].Rows[0]["ProductImage"].ToString() == "" ? null : (byte[])ds.Tables[0].Rows[0]["ProductImage"]) == null ? null : Image.FromStream(new MemoryStream(ds.Tables[0].Rows[0]["ProductImage"].ToString() == "" ? null : (byte[])ds.Tables[0].Rows[0]["ProductImage"]));
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
        /// نمایش کومبو باکس دسته بندی کالاها
        /// </summary>
        private void LoadComboGrouping()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Grouping_SelectAll]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet dsProductGroup = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsProductGroup);

                cmbGrouping.DataSource = dsProductGroup.Tables[0];
                cmbGrouping.DisplayMember = "GroupName";
                cmbGrouping.ValueMember = "GroupID";

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
        /// نمایش کومبو باکس انبار کالاها
        /// </summary>
        private void LoadComboWarehouse()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Warehouse_SelectAll]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet dsWarehouse = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsWarehouse);

                cmbWarehouse.DataSource = dsWarehouse.Tables[0];
                cmbWarehouse.DisplayMember = "WarehouseName";
                cmbWarehouse.ValueMember = "WarehouseID";

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

        private void btnShowProductGroupForm_Click(object sender, EventArgs e)
        {
            DialogResult result = new frmGrouping().ShowDialog();
            if (result == DialogResult.Cancel)
            {
                LoadComboGrouping();
            }
        }

        private void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
            
            if (txtProductName.Text == "" || txtProductCode.Text == "" || txtUnitPrice.Value == 0)
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل و درست وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedID == 0)
            {
                InsertProduct();
            }
            else
                UpdateCurrentProduct();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// افزودن کالای جدید
        /// </summary>
        private void InsertProduct()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Product_InsertRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ProductName", txtProductName.Text);
                cmd.Parameters.AddWithValue("ProductCode", txtProductCode.Text);
                cmd.Parameters.AddWithValue("GroupID", cmbGrouping.SelectedValue);
                cmd.Parameters.AddWithValue("WarehouseID", cmbWarehouse.SelectedValue);
                cmd.Parameters.AddWithValue("Unit", txtUnit.Text);
                cmd.Parameters.AddWithValue("UnitPrice", txtUnitPrice.Value); 
                cmd.Parameters.AddWithValue("ProductImage", imageBinary);
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
        /// ویرایش کالا
        /// </summary>
        private void UpdateCurrentProduct()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Product_UpdateRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ProductID", selectedID);
                cmd.Parameters.AddWithValue("ProductName", txtProductName.Text);
                cmd.Parameters.AddWithValue("ProductCode", txtProductCode.Text);
                cmd.Parameters.AddWithValue("GroupID", cmbGrouping.SelectedValue);
                cmd.Parameters.AddWithValue("WarehouseID", cmbWarehouse.SelectedValue);
                cmd.Parameters.AddWithValue("Unit", txtUnit.Text);
                cmd.Parameters.AddWithValue("UnitPrice", txtUnitPrice.Value);
                cmd.Parameters.AddWithValue("ProductImage", imageBinary);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("هیچ تعرفه ای ویرایش نشد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            MemoryStream ms = null;
            Image img = null;
            try
            {
                if (imgOpenFile.ShowDialog() == DialogResult.OK)
                {
                    imageBinary = CreateImageBinary(imgOpenFile.FileName);
                    ms = new MemoryStream(imageBinary);
                    img = Image.FromStream(ms);
                    picBox.Image = img;
                    ms.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "\n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// اضافه کردن تصویر
        /// </summary>
        /// <param name="fileName">نام فایل</param>
        /// <returns></returns>
        private byte[] CreateImageBinary(string fileName)
        {
            FileInfo fi = new FileInfo(fileName);
            FileStream fs = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read);
            BinaryReader rdr = new BinaryReader(fs);
            byte[] fileData = rdr.ReadBytes((int)fs.Length);
            rdr.Close();
            fs.Close();
            return fileData;
        }

        // ارور پر کردن تکست باکس ها
        private bool IsProductNameValid()
        {
            return txtProductName.Text.Length > 0;
        }

        private bool IsProductCodeValid()
        {
            return txtProductCode.Text.Length > 0;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsProductNameValid())
            {
                ProductErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                ProductErrorProvider.SetError((Control)sender, "لطفا نام کالا را وارد کنید");
            }
            else
            {
                ProductErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtProductCode_Validating(object sender, CancelEventArgs e)
        {
            if (!IsProductCodeValid())
            {
                ProductErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                ProductErrorProvider.SetError((Control)sender, "لطفا کد کالا را وارد کنید");
            }
            else
            {
                ProductErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtUnit_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShowWarehouseForm_Click(object sender, EventArgs e)
        {
            DialogResult result = new frmWarehouse().ShowDialog();
            if (result == DialogResult.Cancel)
            {
                LoadComboWarehouse();
            }
        }
    }
}