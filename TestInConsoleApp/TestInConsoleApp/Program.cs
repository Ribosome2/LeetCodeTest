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
           var  test=new WordDictionary();
            test.AddWord("a");
//            test.AddWord("mad");
//            test.AddWord("pad");
            //            test.AddWord("runner");
            //            Console.WriteLine(test.Search("pad"));
            //            Console.WriteLine(test.Search("bad"));
            //            Console.WriteLine(test.Search(".ad"));
            //            Console.WriteLine(test.Search("b.."));
            //            Console.WriteLine(test.Search("a.d."));
            Console.WriteLine(test.Search(".a"));
            Console.Read();
        }


       
    }
}
