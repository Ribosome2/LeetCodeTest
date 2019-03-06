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
            var test = new Array_FindRelativeRanks();
            Console.WriteLine(test.FindRelativeRanks(new int[]
            {
                5,4,3,2,1
            }));

            Console.Read();
        }
    }
}
