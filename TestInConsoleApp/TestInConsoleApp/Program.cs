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
            var test = new Array_MaxProfit();
            //var arr = new int[,]{{44, 35, 39},{15, 44, 35},{17, 15, 44},{80, 17, 15},{43, 80, 0},{77, 43, 80}};
            var arr = new int[] {7, 1, 5, 3,6,4};
            Console.WriteLine(test.MaxProfit2(arr));
            Console.Read();
        }
    }
}
