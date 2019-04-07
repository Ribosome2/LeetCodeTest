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
            var test = new Array_SubdomainVisits();
            test.SubdomainVisits(new string[]{"9001 discuss.leetcode.com"});
         

            Console.Read();
        }


       
    }
}
