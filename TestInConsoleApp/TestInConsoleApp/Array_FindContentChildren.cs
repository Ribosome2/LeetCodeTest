using System;

namespace TestInConsoleApp
{
    public class Array_FindContentChildren
    {

//        假设你是一位很棒的家长，想要给你的孩子们一些小饼干。但是，每个孩子最多只能给一块饼干。对每个孩子 i ，都有一个胃口值 gi ，这是能让孩子们满足胃口的饼干的最小尺寸；并且每块饼干 j ，都有一个尺寸 sj 。如果 sj >= gi ，我们可以将这个饼干 j 分配给孩子 i ，这个孩子会得到满足。你的目标是尽可能满足越多数量的孩子，并输出这个最大数值。
//
//        注意：
//
//        你可以假设胃口值为正。
//        一个小朋友最多只能拥有一块饼干。
        public int FindContentChildren(int[] g, int[] s)
        {
            int count = 0;
            Array.Sort(g);
            Array.Sort(s);
            for (int i = g.Length - 1; i >= 0; i--)
            {
                int gNum = g[i];
                for (int j = s.Length - 1; j >= 0; j--)
                {
                    if (s[i] >= gNum)
                    {
                        s[i] = 0;
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
    }
}