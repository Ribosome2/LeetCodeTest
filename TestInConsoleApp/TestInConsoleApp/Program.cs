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
            ListNode listNode=new ListNode(1);
            listNode.next=new ListNode(2);
            listNode.next.next=new ListNode(2);
            listNode.next.next.next=new ListNode(2);
            listNode.next.next.next.next=new ListNode(5);
            Console.WriteLine(new LinkList_DeleteDuplicates().DeleteDuplicates(listNode));
            Console.Read();
        }


       
    }
}
