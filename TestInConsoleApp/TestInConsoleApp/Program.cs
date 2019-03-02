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
            var test = new Str_Compress();
            Console.WriteLine(test.Compress(new char[]
            {
                'a', 'a', 'b', 'b', 'c', 'c', 'c'
            }));

        Console.Read();
        }
    }
}
