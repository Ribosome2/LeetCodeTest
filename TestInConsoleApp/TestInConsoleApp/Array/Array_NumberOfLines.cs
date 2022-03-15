using System;

namespace TestInConsoleApp
{
    public class Array_NumberOfLines
    {
        //我们要把给定的字符串 S 从左到右写到每一行上，每一行的最大宽度为100个单位，如果我们在写某个字母的时候会使这行超过了100 个单位，那么我们应该把这个字母写到下一行。我们给定了一个数组 widths ，这个数组 widths[0] 代表 'a' 需要的单位， widths[1] 代表 'b' 需要的单位，...， widths[25] 代表 'z' 需要的单位。

//        现在回答两个问题：至少多少行能放下S，以及最后一行使用的宽度是多少个单位？将你的答案作为长度为2的整数列表返回。
        public int[] NumberOfLines(int[] widths, string S)
        {
            int line = 0;
            int lastWidth = 0;
            for (int i = 0; i < S.Length; i++)
            {
                int index = S[i]-'a';
                int width = widths[index];
                if (width > lastWidth)
                {
                    lastWidth = 100;
                    line++;
                }
                lastWidth -= width;
            }
            return new[] {line, 100-lastWidth};
        }

        public int[] NumberOfLines1(int[] widths, string S)
        {
            int[] arr = new int[] { 0, 0 };
            for (int i = 0; i < S.Length; i++)
            {
                int width = widths[S[i] - 'a'];
                if (width > arr[1])
                {
                    arr[1] = 100;
                    arr[0]++;
                }
                arr[1] -= width;
            }

            arr[1] = 100 - arr[1];
            return arr;
        }
    }
}