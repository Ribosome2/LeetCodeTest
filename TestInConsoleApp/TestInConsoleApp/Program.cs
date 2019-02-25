using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test=new Array_RottingOrange();
            var arr =new int[][]
            {
                new int[] {2, 1, 1},
                new int[] {1, 1, 0},
                new int[] {0, 1, 1},
            };
            Console.WriteLine(test.OrangesRotting(arr));
           
            Console.Read();
        }
    }
}
