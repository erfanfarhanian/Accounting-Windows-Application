using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingAndWarehousing.Classes
{
    public class PersianClass
    {
        private static string GetPersianNames(DayOfWeek days)
        {
            switch (days)
            {
                case DayOfWeek.Friday:
                    return "جمعه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "یک شنبه";
                case DayOfWeek.Thursday:
                    return "پنجشنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                default:
                    return "";
            }
        }

        private static string GetPersianMonthNames(int num)
        {
            switch (num)
            {
                case 01:
                    return "فروردین";
                case 02:
                    return "اردیبهشت";
                case 03:
                    return "خرداد";
                case 04:
                    return "تیر";
                case 05:
                    return "مرداد";
                case 06:
                    return "شهریور";
                case 07:
                    return "مهر";
                case 08:
                    return "آبان";
                case 09:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
                default:
                    return "";
            }
        }

        public static string GetPersianDate()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime now = DateTime.Now;
            int day = pc.GetDayOfMonth(now);
            int month = pc.GetMonth(now);
            int year = pc.GetYear(now);

            return "امروز : " + GetPersianNames(now.Date.DayOfWeek) +
                          " " + day + " " + GetPersianMonthNames(month) +
                          " " + year;
        }

        /// <summary>
        /// تاریخ شمسی 
        /// </summary>
        /// <returns></returns>
        public string GetPersianShortDate()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime now = DateTime.Now;
            int day = pc.GetDayOfMonth(now);
            int month = pc.GetMonth(now);
            int year = pc.GetYear(now);

            return year + "-" + month.ToString().PadLeft(2, '0') + "-" + day.ToString().PadLeft(2, '0');
        }
    }
}
