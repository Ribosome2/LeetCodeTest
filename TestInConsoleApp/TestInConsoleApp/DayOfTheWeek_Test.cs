using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
   
    class DayOfTheWeek_Test
    {
//        给你一个日期，请你设计一个算法来判断它是对应一周中的哪一天。
//
//        输入为三个整数：day、month 和year，分别表示日、月、年。
//
//        您返回的结果必须是这几个值中的一个 {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}。
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/day-of-the-week
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

        static string[] WeekStr = new string[] { "Sunday", "Monday", "Tuesday",
            "Wednesday", "Thursday", "Friday", "Saturday" };

        public string DayOfTheWeek(int day, int month, int year)
        {
            var date =new DateTime(year,month,day);
           return date.DayOfWeek.ToString();
        }
    }
}
