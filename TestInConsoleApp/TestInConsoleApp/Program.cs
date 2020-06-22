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

            var test = new UniquePaths_Test();;
          
            Console.WriteLine(test.UniquePaths(51,9));
            Console.ReadKey();
        }


       
    }
}
