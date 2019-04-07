using System;
using System.Collections.Generic;
using System.Text;

namespace TestInConsoleApp
{
    public class Str_LetterCasePermutation
    {

        public List<String> LetterCasePermutation(String S)
        {
            List<string> result = new List<string>();
            char[] c = S.ToCharArray();
            Permuta(result, c, 0);
            return result;
        }
        //回溯
        private void Permuta(List<String> list, char[] a, int n)
        {
            if (n >= a.Length)
            {
                list.Add(new String(a));
                return;
            }
            char c = a[n];
            if (c >= 'a' && c <= 'z')
            {
                a[n] = (char)(c - 32);
                Permuta(list, a, n + 1);
                //递归完了后数组复原
                a[n] = c;
            }
            else if (c >= 'A' && c <= 'Z')
            {
                a[n] = (char)(c + 32);
                Permuta(list, a, n + 1);
                a[n] = c;
            }
            Permuta(list, a, n + 1);

        }
    }
}