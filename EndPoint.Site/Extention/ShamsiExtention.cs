using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace EndPoint.Site.Extention
{
    public static class ShamsiExtention
    {
        public static string toShamsi(this DateTime d)
        {
            PersianCalendar p = new PersianCalendar();
            return (p.GetYear(d).ToString() + "/" + p.GetMonth(d).ToString("00") + "/" + p.GetDayOfMonth(d).ToString("00"));



        }
        public static DateTime toMiladi(this string date)
        {
            PersianCalendar p = new PersianCalendar();
            // Convert to Miladi
            DateTime dt = DateTime.Parse(date, new CultureInfo("fa-IR"));
            // Get Utc Date
            var dt_utc = dt.ToUniversalTime();
            return dt_utc;

        }
    }
}
