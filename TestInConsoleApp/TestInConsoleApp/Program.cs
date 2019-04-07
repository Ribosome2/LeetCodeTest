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
            var test = new Array_FlipAndInvertImage();
            int[][] arr = new int[3][];
            arr[0]=new int[]{1,1,0};
            arr[1] = new int[] { 1, 0, 1 };
            arr[2] = new int[] { 0, 0, 0 };
            test.FlipAndInvertImage1(arr);
          
         

            Console.Read();
        }


       
    }
}
