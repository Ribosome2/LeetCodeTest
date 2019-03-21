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
        public bool IsAnagram1(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            //建立一个26个字母的数组记录,题目说了只包含小写字母
            int[] letterArray=new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                //一个加一个减，如果字母内容都是一样的话，对应字母位的值一定是0
                letterArray[s[i] - 'a'] += 1;
                letterArray[t[i] - 'a'] -= 1;
            }

            for (int i = 0; i < letterArray.Length; i++)
            {
                if (letterArray[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}