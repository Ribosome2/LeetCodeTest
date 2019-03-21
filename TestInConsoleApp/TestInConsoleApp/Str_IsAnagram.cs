using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Str_IsAnagram
    {
        //给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的一个字母异位词。
        //public bool IsAnagram(string s, string t)
        //{
        //    if (s.Length != t.Length)
        //    {
        //        return false;
        //    }

        //    int num = 0;
        //    int sum = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        num ^= s[i];
        //        sum += s[i];
        //    }
        //    for (int i = 0; i < t.Length; i++)
        //    {
        //        num ^= t[i];
        //        sum -= t[i];
        //    }
        //    return num == 0 && sum==0;

        //    //因为有
        //    //"xaaddy"
        //    //"xbbccy"
        //}

        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char,int> dict=new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (dict.ContainsKey(c) == false)
                {
                    dict[c] = 1;
                }
                else
                {
                    dict[c] = dict[c] + 1;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                var c = t[i];
                if (dict.ContainsKey(c) == false || dict[c] == 0)
                {
                    return false;
                }

                dict[c] = dict[c] - 1;
            }

            return true;


        }

    }
}