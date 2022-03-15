using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts;
using TestInConsoleApp.LinkList;

namespace TestInConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList_Reverse test = new LinkedList_Reverse();
            test.TestReverseLinkList();
            Console.ReadKey();
        }
       
    }
}
