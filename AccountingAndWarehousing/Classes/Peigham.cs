using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingAndWarehousing.Classes
{
    public static class Peigham
    {
        /// <summary>
        /// این متد برای نمایش اطلاعات است
        /// </summary>
        /// <param name="caption">برای متن بالای پنجره</param>
        /// <param name="text">متن اصلی</param>
        public static void ShowInformation(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult AskQuestion(string text, string caption)
        {
            return MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
