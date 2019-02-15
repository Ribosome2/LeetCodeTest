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
            BinaryMath math=new BinaryMath();
            Console.WriteLine(math.addBinary("11", "1"));
            Console.Read();
        }
    }
}
