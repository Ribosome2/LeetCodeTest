using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test=new Array_MergeTowArray();;
           test.Merge(new int[]{1,2,3,0,0,0},3,new int[]{2,5,6}, 3);
            Console.Read();
        }
    }
}
