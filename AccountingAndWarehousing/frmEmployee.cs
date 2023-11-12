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
using AccountingAndWarehousing.Classes;

namespace AccountingAndWarehousing
{
    public partial class frmEmployee : DevExpress.XtraEditors.XtraForm
    {
        private Int16 SelectedID = 0;
        private String SelectedName = string.Empty;
        private String SelectedFamil = string.Empty;
        private String SelectedUsername = string.Empty;

        private String SelectedEmployeeCode = string.Empty;

        private DateTime SelectedBirthDate;
        private DateTime SelectedHireDate;

        private Int16 SelectedEmployeeGroupID = 0;
        private Int32 SelectedRowIndex = 0;

        private Boolean IsEditMode = false;
        private byte[] ImageBinary;
        private byte[] SelectedImageBinary;
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadComboEmployeeGroup();
            LoadGridEmployee();
        }

        /// <summary>
        /// نمایش کومبو گروه کارمند
        /// </summary>
        private void LoadComboEmployeeGroup()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_EmployeeGroup_SelectAll]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet dsEmployeeGroup = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsEmployeeGroup);

                cmbEmployeeGroup.DataSource = dsEmployeeGroup.Tables[0];
                cmbEmployeeGroup.DisplayMember = "EmployeeGroupTitle";
                cmbEmployeeGroup.ValueMember = "EmployeeGroupID";

            }
            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با دیتایس" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex.LogToTextFile(this);
            }

            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "\n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex.LogToTextFile(this);
            }

            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// نمایش لیست کارمندان
        /// </summary>
        private void LoadGridEmployee()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Employee_SelectAll]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet dsEmployee = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsEmployee);
                gridEmployee.DataSource = dsEmployee.Tables[0];
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        /// <summary>
        /// خالی کردن فیلدهای موجود
        /// </summary>
        private void New()
        {
            SelectedID = 0;
            IsEditMode = false;
            txtEmployeeCode.Text = txtFamil.Text = txtName.Text = string.Empty;
            cmbEmployeeGroup.SelectedIndex = 0;
            EmployeeErrorProvider.ClearErrors();
            txtPassword.Enabled = txtUsername.Enabled = true;
            //picBox.Image = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedID == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtBirthDate.Value = SelectedBirthDate.Equals(new DateTime(1, 1, 1)) ? null : (DateTime?)SelectedBirthDate;
            txtHireDate.Value = SelectedHireDate.Equals(new DateTime(1, 1, 1)) ? null : (DateTime?)SelectedHireDate;

            txtEmployeeCode.Text = SelectedEmployeeCode;
            txtFamil.Text = SelectedFamil;
            txtName.Text = SelectedName;

            txtUsername.Text = SelectedUsername;

            cmbEmployeeGroup.SelectedValue = SelectedEmployeeGroupID;

            picBox.Image = SelectedImageBinary == null ? null : Image.FromStream(new MemoryStream(SelectedImageBinary));

            IsEditMode = true;
            txtUsername.Enabled = txtPassword.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا از حذف رکورد جاری مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteData();
                New();
            }
            else
            {
                MessageBox.Show("عملیات حذف کنسل شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// حذف کارمند انتخاب شده
        /// </summary>
        private void DeleteData()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                if (SelectedID == 0)
                {
                    MessageBox.Show("ردیفی انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";

                string query = "[dbo].[usp_Tbl_Employee_DeleteRow]";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", SelectedID);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    LoadGridEmployee();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtFamil.Text == "" || txtEmployeeCode.Text == "" || txtUsername.Text ==  "" || txtHireDate.Value == null || txtBirthDate.Value == null)
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveData();
            LoadGridEmployee();
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// افزودن و ویرایش کارمند
        /// </summary>
        private void SaveData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
            try
            {
                
                string query = "";

                if (IsEditMode)
                    query = "[dbo].[usp_Tbl_Employee_UpdateRow]";

                else
                    query = "[dbo].[usp_Tbl_Employee_InsertRow]";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmployeeGroupID", cmbEmployeeGroup.SelectedValue);
                cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtFamil.Text);

                cmd.Parameters.AddWithValue("@BirthDate", txtBirthDate.Value); // از نوع DateTime
                cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Value);  // از نوع DateTime
                cmd.Parameters.AddWithValue("@EmployeeImage", ImageBinary);

                cmd.Parameters.AddWithValue("@ShamsiBirthDate", txtBirthDate.GetText("yyyy/MM/dd")); // از نوع رشته
                cmd.Parameters.AddWithValue("@ShamsiHireDate", txtHireDate.GetText("yyyy/MM/dd")); // از نوع رشته


                if (IsEditMode)
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", SelectedID);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    string hashPasswordForStoringInDatabase = txtPassword.Text.GetMd5();
                    cmd.Parameters.AddWithValue("@Password", hashPasswordForStoringInDatabase);
                }

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    LoadGridEmployee();
                    gridViewEmployee.TopRowIndex = SelectedRowIndex;
                }
                New();
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

        //ارور پر کردن تکست باکس ها
        private bool IsNameValid()
        {
            return txtName.Text.Length > 0;
        }

        private bool IsFamilValid()
        {
            return txtFamil.Text.Length > 0;
        }

        private bool IsEmployeeCodeValid()
        {
            return txtEmployeeCode.Text.Length > 0;
        }

        private bool IsUsernameValid()
        {
            return txtUsername.Text.Length > 0;
        }

        private bool IsPasswordValid()
        {
            return txtPassword.Text.Length > 0;
        }

        /// <summary>
        /// ذخیره عکس به صورت باینری
        /// </summary>
        /// <param name="fileName">عکس انتخاب شده</param>
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            MemoryStream ms = null;
            Image img = null;
            try
            {
                if (imgOpenFile.ShowDialog() == DialogResult.OK)
                {
                    ImageBinary = CreateImageBinary(imgOpenFile.FileName);
                    ms = new MemoryStream(ImageBinary);
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

        private void gridViewEmployee_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridViewEmployee.GetDataRow(e.RowHandle);
            SelectedID = Convert.ToInt16(dr["EmployeeID"]);
            SelectedEmployeeGroupID = Convert.ToInt16(dr["EmployeeGroupID"]);

            SelectedRowIndex = e.RowHandle;

            SelectedName = dr["FirstName"].ToString();
            SelectedFamil = dr["LastName"].ToString();
            SelectedEmployeeCode = dr["EmployeeCode"].ToString();

            DateTime.TryParse(dr["BirthDate"].ToString(), out SelectedBirthDate);
            DateTime.TryParse(dr["HireDate"].ToString(), out SelectedHireDate);

            SelectedUsername = dr["Username"].ToString();


            SelectedImageBinary = dr["EmployeeImage"].ToString() == "" ? null : (byte[])dr["EmployeeImage"];
        }

        private void btnShowEmployeeGroupForm_Click(object sender, EventArgs e)
        {
            frmEmployeeGroup frm = new frmEmployeeGroup();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                LoadComboEmployeeGroup();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsNameValid())
            {
                EmployeeErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                EmployeeErrorProvider.SetError((Control)sender, "لطفا نام را وارد کنید");
            }
            else
            {
                EmployeeErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtFamil_Validating(object sender, CancelEventArgs e)
        {
            if (!IsFamilValid())
            {
                EmployeeErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                EmployeeErrorProvider.SetError((Control)sender, "لطفا نام خانوادگی را وارد کنید");
            }
            else
            {
                EmployeeErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtEmployeeCode_Validating(object sender, CancelEventArgs e)
        {
            if (!IsEmployeeCodeValid())
            {
                EmployeeErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                EmployeeErrorProvider.SetError((Control)sender, "لطفا کد کارمندی را وارد کنید");
            }
            else
            {
                EmployeeErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (!IsUsernameValid())
            {
                EmployeeErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                EmployeeErrorProvider.SetError((Control)sender, "لطفا نام کاربری را وارد کنید");
            }
            else
            {
                EmployeeErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!IsPasswordValid())
            {
                EmployeeErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                EmployeeErrorProvider.SetError((Control)sender, "لطفا کلمه عبور را وارد کنید");
            }
            else
            {
                EmployeeErrorProvider.SetError((Control)sender, "");
            }
        }
    }
}