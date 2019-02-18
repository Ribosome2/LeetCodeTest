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
            Int_PlusOne test=new Int_PlusOne();
            test.PlusOne(new int[] {9, 9});
            Console.Read();
        }
    }
}
