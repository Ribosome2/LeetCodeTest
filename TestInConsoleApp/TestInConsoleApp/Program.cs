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
            string str="abc";
            char[] arr=new char[3];

            Console.WriteLine(new Array_SortArrayByParityII().SortArrayByParityII(new int[]{ 4, 2, 5, 7 }));
            Console.Read();
        }


       
    }
}
