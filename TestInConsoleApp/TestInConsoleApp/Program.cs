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
           LastStoneWeight_Test test=new LastStoneWeight_Test();
           Console.WriteLine(test.LastStoneWeight(new[] {1, 3, 45, 6, 12}));
            Console.Read();
        }


       
    }
}
