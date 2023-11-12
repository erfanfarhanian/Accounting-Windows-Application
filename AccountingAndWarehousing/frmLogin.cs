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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login.LoginnedEmployeeID = 0;
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.grpLogin.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) && LoginErrorProvider.GetError(ctrl) != string.Empty)
                    return;
            }
            CheckLogin();
        }

        // ارور پر کردن تکست باکس ها
        private bool IsUsernameValid()
        {
            return txtUsername.Text.Length > 0;
        }

        private bool IsPasswordValid()
        {
            return txtPassword.Text.Length > 0;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (!IsUsernameValid())
            {
                LoginErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                LoginErrorProvider.SetError((Control)sender, "لطفا نام کاربری را وارد کنید");
            }
            else
            {
                LoginErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!IsPasswordValid())
            {
                LoginErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                LoginErrorProvider.SetError((Control)sender, "لطفا کلمه عبور را وارد کنید");
            }
            else
            {
                LoginErrorProvider.SetError((Control)sender, "");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            Login.LoginnedEmployeeID = 0;
            Login.LoginnedEmployeeFullName = "";
            StatusStrip strip = (StatusStrip)this.MdiParent.Controls["mainStatusStrip"];
            strip.Items["lblCurrentEmployee"].Text = "کاربری لاگین نشده است";
            strip.Items["lblCurrentEmployee"].BackColor = Color.MediumVioletRed;
            strip.Items["lblDateTime"].Text = PersianClass.GetPersianDate();
        }

        /// <summary>
        /// چک کردن رمز عبور و نام کاربری
        /// </summary>
        private void CheckLogin()
        {
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                string query = "[dbo].[usp_Tbl_Employee_Login]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                string hashPassword = txtPassword.Text.GetMd5();

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", hashPassword);

                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                StatusStrip strip = (StatusStrip)this.MdiParent.Controls["mainStatusStrip"];

                if (ds.Tables[0].Rows.Count.Equals(0))
                {
                    MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است", "ورود ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Login.LoginnedEmployeeID = 0;
                    strip.Items["lblCurrentEmployee"].Text = "کاربری لاگین نشده است";
                    strip.Items["lblCurrentEmployee"].BackColor = Color.Red;
                    return;
                }
                else
                {
                    Login.LoginnedEmployeeID = Convert.ToInt32(ds.Tables[0].Rows[0]["EmployeeID"]);
                    Login.LoginnedEmployeeFullName = ds.Tables[0].Rows[0]["FullName"].ToString();
                    Login.Username = ds.Tables[0].Rows[0]["Username"].ToString();
                    strip.Items["lblCurrentEmployee"].Text = Login.LoginnedEmployeeFullName;
                    strip.Items["lblCurrentEmployee"].BackColor = Color.LightSeaGreen;
                    MessageBox.Show(Login.LoginnedEmployeeFullName + "\n" + "خوش آمدید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

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
    }
}