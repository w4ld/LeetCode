using System;
using System.Runtime.InteropServices.ComTypes;

namespace LeetCode
{
    public partial class LeetCodeLibrary
    {
    public static string DayOfTheWeek(int day, int month, int year)
    {
            //EPOCH Thursday, January 1, 1970 12:00:00 AM and constraint is 1971
            string[] strArr = { "Thursday", "Friday", "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday" };
            int[] monthDay = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //int[] yearDay = { 365, 366 };
            int days = 0;
            for (int i = 0; i < year; i++)
                if (i % 4 == 0)
                    days += 366;
                else
                    days += 365;
            for (int i = 0; i < month; i++)
                days += monthDay[i];
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0) && month > 1)
                if (month > 2)
                    days += 1 + day;
                else
                    days += day;


            return strArr[days % 7];
    }
        //Easy version
    public static string DayOfTheWeek2(int day, int month, int year)
    {
        return new DateTime(year, month, day).DayOfWeek.ToString();
    }

        #region DayOfTheWeek Testing
        public static void DayOfTheWeekTest()
        {
            Console.WriteLine(DayOfTheWeek(7,7,2000));
            Console.WriteLine(DayOfTheWeek2(7,7,2000));
            Console.WriteLine(DayOfTheWeek(7, 7, 2001));
            Console.WriteLine(DayOfTheWeek2(7, 7, 2001));

        }
            #endregion

    }
}