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
            ListNode node=new ListNode(1);
            var node2=node.next=new ListNode(2);
            var node3=node.next.next=new ListNode(3);
            var node4=node.next.next.next=new ListNode(4);
            LinkListRemoveElement.DeleteNode(node4);
            Console.WriteLine(node.ToStr());
            Console.Read();
        }
    }
}
