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

            var test = new MaxSatisfied_Test();
          
            Console.WriteLine(test.MaxSatisfied1(new []{1,0,1,2,1,1,7,5},new []{0,1,0,1,0,1,0,1},3));
            Console.ReadKey();
        }


       
    }
}
