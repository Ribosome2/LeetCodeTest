using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 剑指Offer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("offer !!!!!!!!");
            var test = new SpiralOrder_Test();
            var arr = new int[][]
            {
               new [] {1, 2, 3, 4},
                new [] {5, 6, 7, 8},
                new[] { 9, 10, 11, 12},
            };
            test.SpiralOrder(arr);
            Console.ReadKey();
        }
    }
}
