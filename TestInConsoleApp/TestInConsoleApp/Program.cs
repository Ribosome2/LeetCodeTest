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
            var test = new Array_SortedSquares();
            Console.WriteLine(test.SortedSquares(new int[]
            {
                -4, -1, 0, 3, 10
            }));

            Console.Read();
        }
    }
}
