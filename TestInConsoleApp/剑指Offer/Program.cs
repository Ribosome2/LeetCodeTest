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
            int[][] arr = new int[][]
            {
                new int[]{1,4,7,11,15},
                new int[] {2,5,8,12,19},
                new int[] {3,6,9,16,22},
                new int[] {18,21,23,26,30},
            };
            Console.WriteLine(new MajorityElement_Test().MajorityElement1(new int[]{ 1, 2, 3, 2, 2, 2, 5, 4, 2 }));
            Console.ReadKey();
        }
    }
}
