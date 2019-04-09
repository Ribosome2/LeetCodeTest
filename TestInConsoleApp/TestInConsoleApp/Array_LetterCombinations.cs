using System;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_LetterCombinations
    {
        //给定一个仅包含数字 2-9 的字符串，返回所有它能表示的字母组合。
        //给出数字到字母的映射如下（与电话按键相同）。注意 1 不对应任何字母。
        public static  Dictionary<char,string> NumDict=new Dictionary<char, string>()
        {
            {'2',"abc"},
            {'3',"def"},
            {'4',"ghi"},
            {'5',"jkl"},
            {'6',"mno"},
            {'7',"pqrs"},
            {'8',"tuv"},
            {'9',"wxyz"},

        };
        public IList<string> LetterCombinations(string digits)
        {
            List<string> list = new List<string>();
            if (digits == null || digits.Length == 0)
            {
                return list;
            }
           
            char[] chArr=new char[digits.Length];
            SearchToEnd(list, chArr, ref digits, 0);
            return list;
        }

        void SearchToEnd(List<string> list, char[] chArr, ref string digits,int index)
        {
            if (index >= digits.Length)
            {
                list.Add(new string(chArr));
                return;
            }
            string str = NumDict[digits[index]];
            for (int j = 0; j < str.Length; j++)
            {
                chArr[index] = str[j];
                SearchToEnd(list, chArr, ref digits, index+1);
            }
        }
    }
}