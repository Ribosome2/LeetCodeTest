﻿using System.Text;

namespace TestInConsoleApp
{
    public class Int_ExcelTitleToNumber
    {
        //给定一个Excel表格中的列名称，返回其相应的列序号。
        //例如，

        //A -> 1
        //B -> 2
        //C -> 3
        //...
        //Z -> 26
        //AA -> 27
        //AB -> 28 
        //...

        public int TitleToNumber(string s)
        {
            //其实就是26进制转10进制的问题
            int num = s[s.Length-1] - 64;
            int b = 1;
            for (int i = s.Length - 2; i >= 0; i--)
            {
                //A-Z (65-90)
                var chaNum = s[i]-64;
                b = 26 * b;
                num = b*chaNum+num;
            }
            return num;
        }
        public int TitleToNumber1(string s)
        {
            //其实就是26进制转10进制的问题
            int num = 0;
            int b = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                //A-Z (65-90)
                var chaNum = s[i] - 64;
                num=num+chaNum * b;
                b = 26 * b;
            }
            return num;
        }
//        给定一个正整数，返回它在 Excel 表中相对应的列名称。
        public string ConvertToTitle(int n)
        {
            StringBuilder sb=new StringBuilder();
            while (n>0)
            {
                int num = n % 27;
                n = n / 26;
                char c = (char)(num + 64);
                sb.Insert(0, c);
            }
            return sb.ToString();
        }
    }
}