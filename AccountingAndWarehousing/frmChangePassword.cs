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
using AccountingAndWarehousing.Classes;
using System.Data.SqlClient;

namespace AccountingAndWarehousing
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Login.Username;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == string.Empty || txtRepeatPass.Text == string.Empty || txtUsername.Text == string.Empty)
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به صورت کامل وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPass.Text == txtRepeatPass.Text)
            {
                UpdatePassword();
                MessageBox.Show("کلمه عبور با موفقیت تغییر کرد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("کلمه عبور و تکرار آن باهم برابر نیستند", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// ویرایش کلمه عبور
        /// </summary>
        private void UpdatePassword()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";
                conn.Open();

                string query = "[dbo].[usp_Tbl_Employee_ChangePassword]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Username", Login.Username);
                cmd.Parameters.AddWithValue("Password", txtPass.Text.GetMd5());
                
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("هیچ داده ای ویرایش نشد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // ارور پر کردن تکست باکس ها
        private bool IsPasswordValid()
        {
            return txtPass.Text.Length > 0;
        }

        private bool IsRepeatPasswordValid()
        {
            return txtRepeatPass.Text.Length > 0;
        }
        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (!IsPasswordValid())
            {
                ChangePassErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                ChangePassErrorProvider.SetError((Control)sender, "لطفا کلمه عبور را وارد کنید");
            }
            else
            {
                ChangePassErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtRepeatPass_Validating(object sender, CancelEventArgs e)
        {
            if (!IsRepeatPasswordValid())
            {
                ChangePassErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                ChangePassErrorProvider.SetError((Control)sender, "لطفا تکرار کلمه عبور را وارد کنید");
            }
            else
            {
                ChangePassErrorProvider.SetError((Control)sender, "");
            }
        }
    }
}