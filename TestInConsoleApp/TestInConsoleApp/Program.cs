using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts;

namespace TestInConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new String_ValidPalindrome();;
            //var arr = new int[,]{{44, 35, 39},{15, 44, 35},{17, 15, 44},{80, 17, 15},{43, 80, 0},{77, 43, 80}};
            var arr = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};

            string str = "rrr";
            TestStr(ref str);
            Console.WriteLine(str);
            Console.Read();
        }


        static void TestStr(ref string ttt)
        {
            ttt += "ddd";
        }
    }
}
