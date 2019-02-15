using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class BinaryMath
    {
        string addBinary(string a, string b)
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
            int temp;
            LinkedList<int> numLinkedList=new LinkedList<int>();
            //用十进制立竖式的方法去算
            for (int i = 0; i < strLong.Length; i++)
            {
                char num = strLong[i];
                char num2 = null;
                if (i < strShort.Length)
                {
                    num2 = strShort[i];
                }

                if (num2 == num)
                {

                }
            }

            
            return numLinkedList.ToArray();
        }
    }
}
