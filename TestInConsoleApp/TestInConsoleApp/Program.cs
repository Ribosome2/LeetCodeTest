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
//            new Str_ReverseChaArray().ReverseCharArr(ref str, arr, 0, 2);
//            Console.WriteLine(new string(arr));
            Console.WriteLine(new Str_ReverseChaArray().ReverseStr("abcdefg",2));
            Console.Read();
        }


       
    }
}
