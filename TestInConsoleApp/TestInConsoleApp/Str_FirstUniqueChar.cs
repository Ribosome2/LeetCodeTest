using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Str_FirstUniqueChar
    {
        //        给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1
        //注意事项：您可以假定该字符串只包含小写字母。
        public int FirstUniqChar(string s)
        {
            Dictionary<char,bool> checkDict=new Dictionary<char, bool>();
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (checkDict.ContainsKey(ch))
                {
                    continue;
                }
                bool met = false;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[j] == ch)
                    {
                        met = true;
                        break;
                    }
                }

                if (met == false)
                {
                    return i;
                }
                else
                {
                    checkDict[ch] = true;
                }
            }

            return -1;
        }
    }
}