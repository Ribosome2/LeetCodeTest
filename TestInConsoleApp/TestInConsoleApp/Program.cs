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
            var test = new NumArray(new int[]{-2, 0, 3, -5, 2, -1});
            Console.WriteLine(test.SumRange(0,1));
            

            Console.Read();
        }
    }
}
