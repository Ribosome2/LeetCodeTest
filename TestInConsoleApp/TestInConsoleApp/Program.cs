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
           var  test=new Tree_Connect();
           Console.WriteLine(test.Connect(new Tree_Connect.Node(1,
               new Tree_Connect.Node(2,new Tree_Connect.Node(4),new Tree_Connect.Node(5) ),
               new Tree_Connect.Node(3,new Tree_Connect.Node(6),new Tree_Connect.Node(7)))));
            Console.Read();
        }


       
    }
}
