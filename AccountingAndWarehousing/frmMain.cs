using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using AccountingAndWarehousing.Classes;
using System.Data.SqlClient;
using System.IO;

namespace AccountingAndWarehousing
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEmployeeGroup frm = new frmEmployeeGroup();
            ShowForm(frm);
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            ShowForm(frm);
           
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmWarehouse frm = new frmWarehouse();
            ShowForm(frm);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGrouping frm = new frmGrouping();
            ShowForm(frm);
        }

        private void btnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmProduct frm = new frmProduct();
            ShowForm(frm);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// بستن همه ی فرم ها
        /// </summary>
        private void CloseForms()
        {
            List<Form> openForms = new List<Form>();

            foreach (Form item in Application.OpenForms)
            {
                openForms.Add(item);
            }

            foreach (Form item in openForms)
            {
                if (item.Name != "frmMain" && item.Name != "frmLogin")
                {
                    item.Close();
                }
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {            
        }

        private void btnCusotmer_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            ShowForm(frm);
        }

        private void btnCustomerType_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomerType frm = new frmCustomerType();
            ShowForm(frm);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmFinancialAccount frm = new frmFinancialAccount();
            ShowForm(frm);
        }

        private void btnDeposit_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDeposit frm = new frmDeposit();
            ShowForm(frm);
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPayment frm = new frmPayment();
            ShowForm(frm);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPaymentDocuments frm = new frmPaymentDocuments();
            ShowForm(frm);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDepositDocuments frm = new frmDepositDocuments();
            ShowForm(frm);
        }

        private void btnCost_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCost frm = new frmCost();
            ShowForm(frm);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmIncome frm = new frmIncome();
            ShowForm(frm);
        }

        private void btnTax_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnPurchaseInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOrders frm = new frmOrders();
            ShowForm(frm);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmShowOrders frm = new frmShowOrders();
            ShowForm(frm);
        }

        /// <summary>
        /// چک کردن لاگین بودن کاربر و عدم نمایش تکرای فرم
        /// </summary>
        /// <param name="frm">فرم ورودی</param>
        private void ShowForm(Form frm)
        {
            if (Login.LoginnedEmployeeID.Equals(0))
                return;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == frm.Name)
                {
                    item.Focus();
                    return;
                }
            }

            frm.MdiParent = this;
            frm.Show();
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا مطمئن هستید؟", "خروج از سیستم", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Login.LoginnedEmployeeID = 0;
                Login.LoginnedEmployeeFullName = "";
                this.Close();
                Application.Exit();
            }
        }

        private void btnChangeUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            // بدون چک کردن شروط ، همیشه باز میشود تا امکان لاگین مجدد به نرم افزار وجود داشته باشد

            DialogResult result = MessageBox.Show("تمام فرم ها بسته خواهند شد یا مطمئن هستید؟", "تعویض کاربر", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            CloseForms();

            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPhoneBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhoneBook frm = new frmPhoneBook();
            ShowForm(frm);
        }

        private void btnCalculator_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnNote_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad.exe");
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Login.LoginnedEmployeeID.Equals(0))
                return;
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Backup Files (*.bak)|*.bak";
                    saveDialog.FilterIndex = 1;
                    saveDialog.RestoreDirectory = true;
                    saveDialog.Title = "تهیه نسخه پشتیبان";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveDialog.FileName;
                        BackupDatabase(path);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "/n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex.LogToTextFile(this);
            }
        }

        /// <summary>
        /// گرفتن نسخه پشتیبان
        /// </summary>
        /// <param name="destinationPath">مسیر مقصد</param>
        /// <param name="isAuto">زمانیکه خود نرم افزار قبل از بازیابی بکاپ میگیرد</param>
        private void BackupDatabase(string destinationPath, bool isAuto = false)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";

                string backupCommand =
                    "BACKUP DATABASE AccountingDB TO  DISK = N'" + destinationPath +
                    "' WITH NOFORMAT, INIT,  NAME = N'AccountingDB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                SqlCommand cmd = new SqlCommand(backupCommand, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                if (isAuto)
                    MessageBox.Show("قبل از بازیابی، از اطلاعات شما در مسیر زیر نسخه پشتیبان تهیه گردید" + "/n" + destinationPath, "پشتیبان", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("تهیه نسخه پشتیبان با موفقیت انجام گردید", "پشتیبان", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex.LogToTextFile(this);
            }

            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "/n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex.LogToTextFile(this);
            }

            finally
            {
                conn.Close();
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult res = MessageBox.Show("تمام فرم ها بسته خواهند شد یا مطمئن هستید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;

            CloseForms();

            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Backup Files (*.bak)|*.bak";
                openDialog.FilterIndex = 1;
                openDialog.RestoreDirectory = true;
                openDialog.Title = "بازیابی نسخه پشتیبان";
                if (openDialog.ShowDialog() == DialogResult.OK)
                    try
                    {
                        string pathStr = openDialog.FileName;
                        DialogResult res2 = MessageBox.Show("---------- - توجه---------- -\n.پس از انجام بازيابي، اطلاعات موجود پاك خواهد شد\nآيا مايل به تهيه نسخه پشتيبان از اطلاعات موجود قبل از بازيابي هستيد؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res2 == DialogResult.Yes)
                        {
                            string backupPath = Application.StartupPath + "\\BackupFiles\\" +
                                            new PersianClass().GetPersianShortDate() + "-" +
                                            DateTime.Now.Hour +
                                            DateTime.Now.Minute +
                                            DateTime.Now.Second + ".bak";

                            BackupDatabase(backupPath, true);
                        }

                        RestoreDatabase("AccountingDB", pathStr);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        /// <summary>
        /// بازیابی دیتابیس
        /// </summary>
        /// <param name="databaseName">نام دیتابیس</param>
        /// <param name="filePath">مسیر</param>
        public void RestoreDatabase(String databaseName, String filePath)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string physicalNameQuery = "SELECT  physical_name FROM  sys.database_files WHERE type = 0;";

                conn.ConnectionString = "data source = . ; initial catalog = AccountingDB ; integrated security = true";

                SqlCommand cmd = new SqlCommand(physicalNameQuery, conn);
                conn.Open();

                string filePathSQL = cmd.ExecuteScalar().ToString();

                filePathSQL = new FileInfo(filePathSQL).Directory.FullName;
                conn.Close();

                //-------------------------------------------------------------------------

                conn.ConnectionString = "data source = . ; initial catalog = Master ; integrated security = true";
                cmd.Connection = conn;
                conn.Open();

                string restoreCommand =
                    "RESTORE DATABASE " + databaseName + " FROM  DISK = N'" + filePath + "' WITH  FILE = 1,  MOVE N'" +
                     databaseName + "' TO N'" + filePathSQL + "\\AccountingDB.mdf',  MOVE N'" + databaseName +
                    "_log' TO N'" + filePathSQL + "\\AccountingDB_log.ldf',  NOUNLOAD,  REPLACE,  STATS = 5";

                cmd.CommandText = "ALTER DATABASE " + databaseName + " SET OFFLINE WITH ROLLBACK IMMEDIATE";
                cmd.ExecuteNonQuery();

                cmd.CommandText = restoreCommand;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "ALTER DATABASE " + databaseName + " SET ONLINE WITH ROLLBACK IMMEDIATE";
                cmd.ExecuteNonQuery();

                MessageBox.Show("نسخه پشتیبان با موفقیت بازیابی گردید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex.LogToTextFile(this);
            }

            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "/n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex.LogToTextFile(this);
            }

            finally
            {
                conn.Close();
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            ShowForm(frm);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("به امید دیدار", "خروج", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}