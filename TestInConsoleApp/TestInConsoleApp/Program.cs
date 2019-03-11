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
            var test = new Array_DistributeCandies();
            Console.WriteLine(test.DistributeCandies(new int[]{1, 1, 14, 1, 10, 1, 1, 1}));
            

            Console.Read();
        }
    }
}
