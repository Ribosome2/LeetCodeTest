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
            var test = new Str_RepeatedSubstringPattern();
            Console.WriteLine(test.RepeatedSubstringPattern("abab"));

            Console.Read();
        }
    }
}
