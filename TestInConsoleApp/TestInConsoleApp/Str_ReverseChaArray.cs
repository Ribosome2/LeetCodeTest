using System;

namespace TestInConsoleApp
{
    public class Str_ReverseChaArray
    {
        public void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left<right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
        }
        // 给定一个字符串和一个整数 k，你需要对从字符串开头算起的每个 2k 个字符的前k个字符进行反转。如果剩余少于 k 个字符，
        // 则将剩余的所有全部反转。如果有小于 2k 但大于或等于 k 个字符，则反转前 k 个字符，并将剩余的字符保持原样。
        public string ReverseStr(string s, int k)
        {
            var chaArr = new char[s.Length];
            int index = 0;
            int reverseCount = k;
            //每累计K个进行一次翻转
            while (index<s.Length)
            {
                if (reverseCount < k)
                {
                    reverseCount++;
                    chaArr[index] = s[index];
                    index++;
                }
                else
                {
                    reverseCount = 0;
                    ReverseCharArr(ref s, chaArr, index, Math.Min(index + k-1,s.Length-1));
                    index += k;
                }
            }
            return new string(chaArr);
        }

        public void ReverseCharArr(ref string str,char[] chArr, int left, int right)
        {
            while (left < right)
            {
                chArr[left] = str[right];
                chArr[right] = str[left];
                left++;
                right--;
            }
            chArr[left] = str[left];
        }
    }
}