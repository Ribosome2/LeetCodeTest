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

            var test = new MinCostClimbingStairs_Test();
          
            Console.WriteLine(test.MinCostClimbingStairs(new int[]{0,0,0,0}));
            Console.ReadKey();
        }


       
    }
}
