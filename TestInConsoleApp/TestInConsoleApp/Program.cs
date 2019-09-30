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
           var  test=new Str_MutiplyNumber();
            Console.WriteLine(test.Multiply("123", "24"));
            Console.Read();
        }


       
    }
}
