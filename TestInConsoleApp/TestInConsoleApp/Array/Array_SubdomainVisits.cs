﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestInConsoleApp
{
    public class Array_SubdomainVisits
    {
//        一个网站域名，如"discuss.leetcode.com"，包含了多个子域名。作为顶级域名，常用的有"com"，下一级则有"leetcode.com"，最低的一级为"discuss.leetcode.com"。当我们访问域名"discuss.leetcode.com"时，
//        也同时访问了其父域名"leetcode.com"以及顶级域名 "com"。
//        给定一个带访问次数和域名的组合，要求分别计算每个域名被访问的次数。其格式为访问次数+空格+地址，例如："9001 discuss.leetcode.com"。
//        接下来会给出一组访问次数和域名组合的列表cpdomains 。要求解析出所有域名的访问次数，输出格式和输入格式相同，不限定先后顺序。
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string,int> countDict=new Dictionary<string, int>();
            for (int i = 0; i < cpdomains.Length; i++)
            {
                var words = cpdomains[i].Split(' ');
                int count = int.Parse(words[0]);
                StringBuilder sb=new StringBuilder();
                for (int index = words[1].Length - 1; index >= 0; index--)
                {
                 
                    var ch = words[1][index];
                    if (ch == '.' || index==0)
                    {
                        if (index == 0)
                        {
                            sb.Insert(0, ch);
                        }
                        var key = sb.ToString();
                        if (countDict.ContainsKey(key))
                        {
                            countDict[key] = countDict[key] + count;
                        }
                        else
                        {
                            countDict[key] = count;
                        }

                        if (index != 0)
                        {
                            sb.Insert(0, ch);
                        }
                    }
                    else
                    {
                        sb.Insert(0, ch);
                    }
                }
            }
            List<string> reList = new List<string>();
            var iter = countDict.GetEnumerator();
            while (iter.MoveNext())
            {
                reList.Add(string.Format("{0} {1}",iter.Current.Value,iter.Current.Key));
            }
            iter.Dispose();
           
            return reList;
        }


    }
}