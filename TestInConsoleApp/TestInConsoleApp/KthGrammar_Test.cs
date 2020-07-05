using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class KthGrammar_Test
    {
//        在第一行我们写上一个 0。接下来的每一行，将前一行中的0替换为01，1替换为10。
//        给定行数 N 和序数 K，返回第 N 行中第 K个字符。（K从1开始）
        public int KthGrammar(int N, int K)
        {
            //可以看做是0作为根节点的树，每个节点的0会分化出0和1，1会分化出1和0
            //要返回值得根节点分化了N次后，在第N层从左到右数第N个的数
            //下面的暴力算法可以算出结果，但是复杂度太高，会超时
            Queue<int> queque = new Queue<int>();
           queque.Enqueue(0);
            while (N>1)
            {
                int childCount = queque.Count;
                while (childCount>0)
                {
                    var nodeValue = queque.Dequeue();
                    if (nodeValue == 0)
                    {
                        queque.Enqueue(0);
                        queque.Enqueue(1);
                    }
                    else
                    {
                        queque.Enqueue(1);
                        queque.Enqueue(0);
                    }
                    childCount--;
                }

                N--;
            }

            int result = 0;
            while (K>0)
            {
                result = queque.Dequeue();
                K--;
            }

            return result;

        }
//
//        据此可以总结出规律，第 K 个数字是上一行第(K+1) / 2 个数字生成的。如果上一行的数字为 0，被生成的数字为 1 - (K%2)，如果上一行的数字为 1，被生成的数字为 K%2
//
//        作者：LeetCode
//            链接：https://leetcode-cn.com/problems/k-th-symbol-in-grammar/solution/di-kge-yu-fa-fu-hao-by-leetcode/
//        来源：力扣（LeetCode）
//        著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
        public int KthGrammar1(int N, int K)
        {
            if(N == 1) return 0;
            return (~K & 1) ^ KthGrammar(N - 1, (K + 1) / 2);

        }
    }
}