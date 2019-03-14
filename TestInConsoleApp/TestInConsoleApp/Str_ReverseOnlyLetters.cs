using System.Collections.Generic;
using System.Text;

namespace TestInConsoleApp
{
    public class Str_ReverseOnlyLetters
    {
        //给定一个字符串 S，返回 “反转后的” 字符串，其中不是字母的字符都保留在原地，而所有字母的位置发生反转。
        public string ReverseOnlyLetters(string S)
        {
            char[] arr=new  char[S.Length];
            List<int> indexList=new List<int>();
            for (int i = 0; i < S.Length; i++)
            {
                var c = S[i];
                if ((c >= 'a' && c <= 'z' ) || (c>='A' && c<='Z'))
                {
                    indexList.Add(i);
                }
                else
                {
                    arr[i] = c;
                }
            }

            int left = 0;
            int right = indexList.Count - 1;
            while (left<right)
            {
                arr[indexList[left]] = arr[indexList[right]];
                arr[indexList[right]] = arr[indexList[left]];
                left++;
                right--;
            }
            return  new string(arr);
        }
    }
}