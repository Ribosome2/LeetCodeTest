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
            var test = new Int_FindComplement();
            //var arr = new int[,]{{44, 35, 39},{15, 44, 35},{17, 15, 44},{80, 17, 15},{43, 80, 0},{77, 43, 80}};
            var arr = new int[,] { { 1, 2, 3,4 }, { 5, 1,2,3 }, { 9,5,1,2 } };
            Console.WriteLine(test.FindComplement(5));
            Console.Read();
        }
    }
}
