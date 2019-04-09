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
            var test = new Array_RepeatedNTimes();

          
           
            Console.WriteLine(test.RepeatedNTimes(new int[]{2,1,2,5,3,2}));

            Console.Read();
        }


       
    }
}
