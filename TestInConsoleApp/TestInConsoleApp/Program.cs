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
            var test = new Int_HammingDistance();
            Console.WriteLine(test.HammingDistance1(1,4));
            Console.WriteLine(Math.Sqrt(int.MaxValue));
            Console.Read();
        }
    }
}
