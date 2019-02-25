using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Str_WordPattern
    {
        //        给定一种 pattern(模式) 和一个字符串 str ，判断 str 是否遵循相同的模式。
        //        这里的遵循指完全匹配，例如， pattern 里的每个字母和字符串 str 中的每个非空单词之间存在着双向连接的对应模式。
//        示例1:
//
//        输入: pattern = "abba", str = "dog cat cat dog"
//        输出: true
        public bool WordPattern(string pattern, string str)
        {
            var words = str.Split(' ');
            if (pattern.Length != words.Length)
            {
                return false;
            }

            Dictionary<char,string> chaDict=new Dictionary<char, string>();
            Dictionary<string, char> wordDict = new Dictionary<string, char>();
            for (int i = 0; i < pattern.Length; i++)
            {
                var c = pattern[i];
                if (chaDict.ContainsKey(c))
                {
                    if (chaDict[c] != words[i])
                    {
                        return false;
                    }
                }
                else
                {
                    chaDict[c] = words[i];
                    //重复了，不合法
                    if (wordDict.ContainsKey(words[i]))
                    {
                        return false;
                    }
                    wordDict[words[i]] = c;
                }
            }
            return true;
        }

        public bool WordPattern2(string pattern, string str)
        {
            var words = str.Split(' ');
            if (pattern.Length != words.Length)
            {
                return false;
            }

            Dictionary<char, string> chaDict = new Dictionary<char, string>();
            for (int i = 0; i < pattern.Length; i++)
            {
                var c = pattern[i];
                if (chaDict.ContainsKey(c))
                {
                    if (chaDict[c] != words[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (chaDict.ContainsValue(words[i]))
                    {
                        return false;
                    }
                    chaDict[c] = words[i];
                    //这里也可以只用一个字典
                    
                }
            }
            return true;
        }
    }
}