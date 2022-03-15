using System;
using System.Collections;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Str_CommonChars
    {

//        给定仅有小写字母组成的字符串数组 A，返回列表中的每个字符串中都显示的全部字符（包括重复字符）组成的列表。
//        例如，如果一个字符在每个字符串中出现 3 次，但不是 4 次，则需要在最终答案中包含该字符 3 次。
//
//        你可以按任意顺序返回答案。
        public IList<string> CommonChars(string[] A)
        {
            //每个字符串一个字典，记录每个字符出现的次数
            List<string> res = new List<string>();
            List<Dictionary<char ,int>> DictLis= new List<Dictionary<char, int>>();
            for (int i = 0; i < A.Length; i++)
            {
                var dict = new Dictionary<char, int>();
                var str = A[i];
                for (int index = 0; index < str.Length; index++)
                {
                    var key = str[index];
                    if (dict.ContainsKey(key) == false)
                    {
                        dict[key] = 1;
                    }
                    else
                    {
                        dict[key] = dict[key] + 1;
                    }
                }
                DictLis.Add(dict);
            }

            var firstDict = DictLis[0];
            var iter = firstDict.GetEnumerator();
            while (iter.MoveNext())
            {
                int count = iter.Current.Value;
                if (iter.Current.Value>0)
                {
                    bool allMet = true;
                    for (int i = 1; i < DictLis.Count; i++)
                    {
                        var dict = DictLis[i];
                        if (dict.ContainsKey(iter.Current.Key) == false )
                        {
                            allMet = false;
                            break;
                        }
                        else
                        {
                            //这个字符出现的次数等于，所有字典中出现次数的最小值
                            count = Math.Min(dict[iter.Current.Key], count);
                        }
                    }

                    if (allMet)
                    {
                        
                        for (int i = 0; i < count; i++)
                        {
                            res.Add(iter.Current.Key.ToString());
                        }
                    }

                }
            }
            iter.Dispose();


            
            return res;
        }
    }
}