using System;
using System.Collections.Generic;
using System.Text;

namespace TestInConsoleApp
{
    public class Str_LetterCasePermutation
    {
        //给定一个字符串S，通过将字符串S中的每个字母转变大小写，我们可以获得一个新的字符串。返回所有可能得到的字符串集合。
        public IList<string> LetterCasePermutation(string S)
        {
            List<string> list = new List<string>();

            var chArray = S.ToCharArray();
            int flipNum = 0;
            for (int i = 0; i < chArray.Length; i++)
            {
               
                var ch = chArray[i];
                flipNum = GetFlipNum(ch);
                if (flipNum != 0)
                {
                    if (SearchToEnd(i, chArray, list))
                    {
                        chArray[i] = (char)(ch + flipNum);
                        SearchToEnd(i, chArray, list);
                    }
                    else  //后面已经没有字母了
                    {
                        if (list.Count == 0)
                        {
                            list.Add(new string(chArray));
                            chArray[i] = (char)(ch + flipNum);
                            list.Add(new string(chArray));
                        }
                    }
                    break;
                   
                }
            }

            if (list.Count == 0)  //说明没有字母，只要字符串原型一种排列
            {
                list.Add(S);
            }
            return list;
        }

        private static bool SearchToEnd(int startIndex, char[] chArray, List<string> list)
        {
            bool hasLetter = false;
            for (int j = startIndex + 1; j < chArray.Length; j++)
            {
                int curFlip = GetFlipNum(chArray[j]);
                if (curFlip != 0)
                {
                    hasLetter = true;
                    list.Add(new string(chArray));
                    chArray[j] = (char) (chArray[j] + curFlip);
                    list.Add(new string(chArray));
                }
            }

            return hasLetter;
        }

        private static int GetFlipNum(char ch)
        {
            int flipNum;
            flipNum = 0;
            if (ch >= 'a' && ch <= 'z')
            {
                flipNum =- 32;
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                flipNum = 32;
            }

            return flipNum;
        }
    }
}