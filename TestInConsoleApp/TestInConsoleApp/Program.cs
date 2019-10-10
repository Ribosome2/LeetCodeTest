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
            
           var  test=new GetMaximumGold_Test();
            var arr = new int[][] {new int[] {0, 6, 0}, new int[] { 5, 8, 7}, new int[] { 0, 9, 0}};
            Console.WriteLine(test.GetMaximumGold(arr));
            Console.Read();
        }


       
    }
}
