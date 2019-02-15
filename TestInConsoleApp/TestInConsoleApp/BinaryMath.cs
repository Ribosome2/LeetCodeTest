using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class BinaryMath
    {
        public string addBinary(string a, string b)
        {
            string strLong;
            string strShort;
            if (a.Length > b.Length)
            {
                strLong = a;
                strShort = b;
            }
            else
            {
                strLong = b;
                strShort = a;
            }
            int temp=0;
            LinkedList<char> numLinkedList=new LinkedList<char>();
            //用十进制立竖式的方法去算
            for (int i = 0; i < strLong.Length; i++)
            {
                int index = strLong.Length-1 - i;
                char num = strLong[index];
                if (i < strShort.Length)
                {
                    var num2 = strShort[strShort.Length-1-i];
                    int sum = 0;
                    if (num2=='1' && num=='1')
                    {
                        sum = 2;
                    }else if ((num == '0' && num2 == '1') || (num == '1' && num2 == '0'))
                    {
                        sum = 1;
                    }

                    sum += temp;
                    temp = 0;
                    switch (sum)
                    {
                        case 0:
                            numLinkedList.AddFirst('0');
                            break;
                        case 1:
                            numLinkedList.AddFirst('1');
                            break;
                        case 2:
                            numLinkedList.AddFirst('0');
                            temp = 1;
                            break;
                        case 3:
                            numLinkedList.AddFirst('1');
                            temp = 1;
                            break;
                    }
                }
                else
                {
                    
                   
                    if (temp > 0)
                    {
                        if (num == '1')
                        {
                            numLinkedList.AddFirst('0');
                            temp = 1;
                        }
                        else
                        {
                            numLinkedList.AddFirst('1');
                            temp = 0;
                        }
                    }
                    else
                    {
                        numLinkedList.AddFirst(num);
                    }
                }
              
            }
            if (temp > 0)
            {
                numLinkedList.AddFirst('1');
            }
            StringBuilder sb=new StringBuilder();
            var node = numLinkedList.First;
            while (node!=null)
            {
                sb.Append( node.Value);
                node = node.Next;
            }
            
            return sb.ToString();
        }
    }
}
