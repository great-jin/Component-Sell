using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComponentSell
{
    public static class MySeal
    {
        public static string TransTime(string time)
        {
            string strDate = "";
            strDate = time.ToString();
            int j = strDate.LastIndexOf("日");
            strDate = strDate.Substring(0, j + 1);
            return strDate;
        }

        public static int CountDate(string time1, string time2)
        {
            DateTime start = Convert.ToDateTime(time1);
            DateTime end = Convert.ToDateTime(time2);
            TimeSpan sp = end.Subtract(start);
            int days = sp.Days;
            return days;
        }
    }
}
