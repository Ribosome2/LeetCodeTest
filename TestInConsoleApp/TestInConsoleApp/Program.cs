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
           var  test=new Trie();
            test.Insert("apple");
            Console.WriteLine(test.Search("apple"));
            Console.WriteLine(test.Search("app"));
            Console.WriteLine(test.StartsWith("app"));
            test.Insert("app");
            Console.WriteLine(test.Search("app"));
            Console.Read();
        }


       
    }
}
