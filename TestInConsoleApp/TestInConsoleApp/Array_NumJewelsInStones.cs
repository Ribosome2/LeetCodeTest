using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_NumJewelsInStones
    {
//        给定字符串J 代表石头中宝石的类型，和字符串 S代表你拥有的石头。 S 中每个字符代表了一种你拥有的石头的类型，你想知道你拥有的石头中有多少是宝石。
//        J 中的字母不重复，J 和 S中的所有字符都是字母。字母区分大小写，因此"a"和"A"是不同类型的石头
        public int NumJewelsInStones(string J, string S) {
            Dictionary<char,bool> dict=new Dictionary<char, bool>();
            for (int i = 0; i < J.Length; i++)
            {
                dict[J[i]] = true;
            }

            int num = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (dict.ContainsKey(S[i]))
                {
                    num++;
                }
            }
            return num;
        }
        
        public int NumJewelsInStones1(string J, string S) {
            bool[] jewlArrLower=new bool[26];
            bool[] jewlArrUppper=new bool[26];
            
            for (int i = 0; i < J.Length; i++)
            {
                var ch = J[i];
                if (ch > 'Z')
                {
                    jewlArrLower[ch - 97] = true;
                }
                else
                {
                    jewlArrUppper[ch - 65] = true;
                }
                
                
            }

            int num = 0;
            for (int i = 0; i < S.Length; i++)
            {
                var ch = S[i];
                if (ch > 'Z')
                {
                    if (jewlArrLower[ch - 97])
                    {
                        num++;
                    }
                }
                else
                {
                    if (jewlArrUppper[ch - 65])
                    {
                        num++;
                    }
                }
            }
            return num;
        }
    }
}