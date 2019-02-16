using System;

namespace TestInConsoleApp
{
    public class RomanStrToInt
    {

        public int RomanToInt(string s)
        {
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var cha = s[i];
                char next = ' ';
                if (i < s.Length - 1)
                {
                    next = s[i + 1];
                }
                switch (cha)
                {
                    case 'I':
                    {
                        //I 可以放在 V (5) 和 X (10) 的左边，来表示 4 和 9。
                        if (next == 'V')
                        {
                            num += 4;
                            i++;
                        }else if (next == 'X')
                        {
                            num += 9;
                            i++;
                            }
                        else
                        {
                            num += 1;
                        }
                        break;
                    }
                    case 'V':
                        num += 5;
                        break;
                    case 'X':
                        //X 可以放在 L (50) 和 C (100) 的左边，来表示 40 和 90。
                        if (next == 'L')
                        {
                            num += 40;
                            i++;
                        }
                        else if (next == 'C')
                        {
                            num += 90;
                            i++;
                        }
                        else
                        {
                            num += 10;
                        }
                        
                        break;
                    case 'L':
                        num += 50;
                        break;
                    case 'C':
                        //C 可以放在 D (500) 和 M (1000) 的左边，来表示 400 和 900。
                        
                        if (next == 'D')
                        {
                            num += 400;
                            i++;
                        }
                        else if (next == 'M')
                        {
                            num += 900;
                            i++;
                        }
                        else
                        {
                            num += 100;
                        }

                        break;
                    case 'D':
                        num += 500;
                        break;
                    case 'M':
                        num += 1000;
                        break;
                    default:
                        throw new ArgumentException("不能识别的符号 "+cha);
                        break;
                }
            }
            return num;
        }
    }
}