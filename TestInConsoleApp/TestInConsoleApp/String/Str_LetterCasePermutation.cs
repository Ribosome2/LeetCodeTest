using System;
using System.Collections.Generic;
using System.Text;

namespace TestInConsoleApp
{
    public class Str_LetterCasePermutation
    {

        public List<string> LetterCasePermutation(String S)
        {
            List<string> result = new List<string>();
            char[] c = S.ToCharArray();
            Permuta(result, c, 0);
            return result;
        }
        //回溯
        private void Permuta(List<String> list, char[] chArr, int n)
        {
            if (n >= chArr.Length)
            {
                list.Add(new string(chArr));
                return;
            }
            char c = chArr[n];
            int flipNum = 0;
            if (c >= 'a' && c <= 'z')
            {
                flipNum = -32;
            }
            else if (c >= 'A' && c <= 'Z')
            {
                flipNum = 32;
            }

            if (flipNum != 0)
            {
                chArr[n] = (char)(c + flipNum);
                Permuta(list, chArr, n + 1);
                chArr[n] = c;
            }

            Permuta(list, chArr, n + 1);

        }
    }
}