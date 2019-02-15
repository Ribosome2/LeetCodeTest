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
            StringBuilder sb = new StringBuilder();
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
                            sb.Insert(0,'0');
                            break;
                        case 1:
                            sb.Insert(0, '1');
                            break;
                        case 2:
                            sb.Insert(0, '0');
                            temp = 1;
                            break;
                        case 3:
                            sb.Insert(0, '1');
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
                            sb.Insert(0, '0');
                            temp = 1;
                        }
                        else
                        {
                            sb.Insert(0, '1');
                            temp = 0;
                        }
                    }
                    else
                    {
                        sb.Insert(0, num);
                    }
                }
              
            }
            if (temp > 0)
            {
                sb.Insert(0, '1');
            }
            
            return sb.ToString();
        }
    }
}
