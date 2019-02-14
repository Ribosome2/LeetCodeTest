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
            int loopCount = 1000;
            LinkedList<string> linkedList=new LinkedList<string>(); 
            for (int i = 0; i < loopCount; i++)
            {
                linkedList.AddLast("LongStrddddddddddddddddddddddddddddddddddddddddddd");
            }
            var str=linkedList.ToString();
            Console.Read();
        }
    }
}
