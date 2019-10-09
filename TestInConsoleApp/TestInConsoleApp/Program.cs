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
           var  test=new Str_DecodeString();
            Console.WriteLine(test.DecodeString("3[a]2[bc]"));
            Console.Read();
        }


       
    }
}
