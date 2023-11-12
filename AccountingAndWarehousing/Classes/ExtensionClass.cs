using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingAndWarehousing.Classes
{
    public static class ExtensionClass
    {
        /// <summary>
        /// تبدیل متن به فرمت MD5
        /// </summary>
        /// <param name="input">کلمه عبور</param>
        /// <returns>فرمت MD5</returns>
        public static string GetMd5(this string input)
        {

            MD5 md5Hash = MD5.Create();

            // تبدیل متن ورودی به آرایه ای از بایت ها و
            //ایجاد Hash
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // استفاده از کلاس StringBuilder
            // برای نگه داشتن بایت ها و ساخت رشته ی خروجی
            StringBuilder sb = new StringBuilder();


            // داخل این حلقه به ازای هر کدام از بایت های
            // رمز نگاری شده آنها را به فرمت هگزادسیمال تبدیل میکند
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            // برگرداندن رشته ی هگزادسیمال
            return sb.ToString();
        }

        /// <summary>
        /// آیا دیتاست خالی است
        /// </summary>
        /// <param name="ds">نام دیتاست</param>
        /// <returns></returns>
        public static bool IsNull(this DataSet ds)
        {
            return (ds == null ||
                   ds.Tables[0] == null ||
                   ds.Tables[0].Rows == null ||
                   ds.Tables[0].Rows.Count == 0);
        }

        /// <summary>
        /// برگرداندن محتوای ستون های دیتاست برای ردیف اول
        /// </summary>
        /// <param name="ds">نام دیتاست</param>
        /// <param name="columnName">نام ستون</param>
        /// <returns>مقدار ستون مورد نظر</returns>
        public static string ReturnFieldValue(this DataSet ds, string columnName)
        {
            if (ds.IsNull())
                return "";
            return ds.Tables[0].Rows[0][columnName].ToString();
        }

        /// <summary>
        /// برگرداندن محتوای ستون های دیتاست برای ردیف مورد نظر
        /// </summary>
        /// <param name="ds">نام دیتاست</param>
        /// <param name="rowsIndex">شماره ردیف</param>
        /// <param name="columnName">نام ستون</param>
        /// <returns>مقدار ستون مورد نظر</returns>
        public static string ReturnFieldValue(this DataSet ds, string columnName, int rowsIndex)
        {
            if (ds.IsNull())
                return "";
            return ds.Tables[0].Rows[rowsIndex][columnName].ToString();
        }

        /// <summary>
        /// برگرداندن محتوای ستون های دیتاست برای جدول مورد نظر
        /// </summary>
        /// <param name="ds">نام دیتاست</param>
        /// <param name="tableIndex">اندیس جدول</param>
        /// <param name="columnName">نام ستون</param>
        /// <returns></returns>
        public static string ReturnFieldValue(this DataSet ds, int tableIndex, string columnName)
        {
            if (ds.IsNull())
                return "";
            return ds.Tables[tableIndex].Rows[0][columnName].ToString();
        }

        /// <summary>
        /// ثبت خطاها
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="form"> فرم جاری</param>
        public static void LogToTextFile(this Exception ex, Form form)
        {
            string fileName = new PersianClass().GetPersianShortDate();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine();

            sb.AppendLine(" -------------------- " + DateTime.Now.ToString("hh:mm:ss") + "-----------------------");

            if (form != null)
            {
                sb.AppendLine("Form : ");
                sb.AppendLine("" + form.Name + " | " + form.Text);
                sb.AppendLine();
            }

            sb.AppendLine("User : ");

            sb.AppendLine("" + Login.LoginnedEmployeeFullName + " | " + Login.Username);

            sb.AppendLine();

            sb.AppendLine("Data : ");

            sb.AppendLine("" + ex.Data);

            sb.AppendLine();

            sb.AppendLine("InnerException :");

            sb.AppendLine("" + ex.InnerException);

            sb.AppendLine();

            sb.AppendLine("Message : ");

            sb.AppendLine(ex.Message);

            sb.AppendLine();

            sb.AppendLine("Source : ");

            sb.AppendLine(ex.Source);

            sb.AppendLine();

            sb.AppendLine("StackTrace : ");

            sb.AppendLine(ex.StackTrace);

            sb.AppendLine();

            sb.AppendLine();

            string currentDir = System.IO.Directory.GetCurrentDirectory();

            string path = currentDir + @"\LogFiles\" + fileName + ".txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, sb.ToString());
            }
            else
            {
                File.WriteAllText(path, File.ReadAllText(path) + sb.ToString());
            }
        }
    }
}
