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

            var test = new IsLongPressedName_Test();;
          
            Console.WriteLine(test.IsLongPressedName("alex","aaleex"));
            Console.ReadKey();
        }


       
    }
}
