using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class StrUncommonFromSentences
    {
        public  string[] UncommonFromSentences(string A, string B)
        {
            List<string> list=new List<string>();
            Dictionary<string,int> dictA=new Dictionary<string,int>();
            Dictionary<string, int> dictB = new Dictionary<string, int>();
            InitDict(A, dictA);
            InitDict(B, dictB);

            CheckFillList(dictA, dictB, list);
            CheckFillList(dictB,dictA,list);

            return list.ToArray();
        }
        public string[] UncommonFromSentences2(string A, string B)
        {
            List<string> list = new List<string>();
            Dictionary<string, int> dictA = new Dictionary<string, int>();
            //可以两个字符合成一个，找出总共出现过一次的就可以
            InitDict(A+" "+B, dictA);
            var iter = dictA.GetEnumerator();
            while (iter.MoveNext())
            {
                if (iter.Current.Value < 2)
                {
                    list.Add(iter.Current.Key);
                }
            }

            iter.Dispose();
            return list.ToArray();
        }

        /// <summary>
        /// 跟2的区别是我们用LinkList替换List 更快一点
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public string[] UncommonFromSentences3(string A, string B)
        {
            Dictionary<string, int> dictA = new Dictionary<string, int>();
            //可以两个字符合成一个，找出总共出现过一次的就可以
            InitDict(A + " " + B, dictA);
            var iter = dictA.GetEnumerator();
            LinkedList<string> list = new LinkedList<string>();
            while (iter.MoveNext())
            {
                if (iter.Current.Value < 2)
                {
                    list.AddLast(iter.Current.Key);
                }
            }

            iter.Dispose();
            return list.ToArray();
        }


        private void CheckFillList(Dictionary<string, int> dictA, Dictionary<string, int> dictB, List<string> list)
        {
            var iter = dictA.GetEnumerator();
            while (iter.MoveNext())
            {
                if (dictB.ContainsKey(iter.Current.Key) != true && iter.Current.Value < 2)
                {
                    list.Add(iter.Current.Key);
                }
                else
                {
                    dictB.Remove(iter.Current.Key);
                }
            }

            iter.Dispose();
        }

        private  void InitDict(string A, Dictionary<string, int> dictA)
        {
            string[] wordsA = A.Split(' ');
            for (int i = 0; i < wordsA.Length; i++)
            {
                if (dictA.ContainsKey(wordsA[i]))
                {
                    dictA[wordsA[i]] = dictA[wordsA[i]] + 1;
                }
                else
                {
                    dictA[wordsA[i]] = 1;
                }
            }
        }
    }
}
