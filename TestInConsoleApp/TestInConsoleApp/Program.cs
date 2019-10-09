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
           var  test=new IntegerReplacement_Test();
            Console.WriteLine(test.IntegerReplacement(2147483647));
            Console.Read();
        }


       
    }
}
