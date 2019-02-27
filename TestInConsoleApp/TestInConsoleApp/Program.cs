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
            var test=new Str_AddStrings();
            Console.WriteLine(test.AddStrings("98","9"));
           
            Console.Read();
        }
    }
}
