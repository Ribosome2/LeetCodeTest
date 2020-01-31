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

            var test = new VideoStitching_Test();
            var arr = new int[][] {new []{0,2},new []{4,6},new []{8,10},new []{1,9},new []{1,5},new []{5,9}};
            Console.WriteLine(test.VideoStitching(arr,10));
            Console.ReadKey();
        }


       
    }
}
