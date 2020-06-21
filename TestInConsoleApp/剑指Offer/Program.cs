using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 剑指Offer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("offer !!!!!!!!");
            var arr = new int[] {1, 3, -1, -3, 5, 3, 6, 7};
            new MaxSlidingWindow_Test().MaxSlidingWindow(arr,3);


            Console.ReadKey();
        }
    }
}
