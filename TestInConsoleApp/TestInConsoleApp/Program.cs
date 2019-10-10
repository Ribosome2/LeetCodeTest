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

            var test = new DistanceBetweenBusStops_Test();
            ;
            var arr = new int[] {14, 13, 4, 7, 10, 17, 8, 3, 2, 13,};

        Console.WriteLine(test.DistanceBetweenBusStops(arr,2,9 ));
            Console.Read();
        }


       
    }
}
