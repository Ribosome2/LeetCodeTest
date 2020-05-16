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

            var test = new FindContinuousSequence_Test();;
          
            Console.WriteLine(test.FindContinuousSequence(9));
            Console.ReadKey();
        }


       
    }
}
