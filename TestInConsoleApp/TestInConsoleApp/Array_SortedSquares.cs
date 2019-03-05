using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_SortedSquares
    {
        //给定一个按非递减顺序排序的整数数组 A，返回每个数字的平方组成的新数组，要求也按非递减顺序排序。
        public int[] SortedSquares(int[] A)
        {
            int[] result=new int[A.Length];
            LinkedList<int> linkList=new LinkedList<int>();
            for (int i = 0; i < A.Length; i++)
            {
                int num = A[i];
                AddToLinkList(linkList,num*num);
            }

            var node = linkList.First;
            int index = 0;
            while (node != null)
            {
                result[index] = node.Value;
                node = node.Next;
                index++;
            }
            return result;
        }

        void AddToLinkList(LinkedList<int> list, int num)
        {
            var node = list.First;
            while (node!=null)
            {
                 if (node.Value >= num)
                {
                    list.AddBefore(node, num);
                    return;
                }

                node = node.Next;
            }
            list.AddLast(num);
        }


        //思路
        //    因为数组 A 已经排好序了， 所以可以说数组中的负数已经按照平方值降序排好了，数组中的非负数已经按照平方值升序排好了。
        //举一个例子，若给定数组为[-3, -2, -1, 4, 5, 6]，数组中负数部分[-3, -2, -1] 的平方为[9, 4, 1]，数组中非负部分[4, 5, 6] 的平方为[16, 25, 36]。
        //我们的策略就是从前向后遍历数组中的非负数部分，并且反向遍历数组中的负数部分。
        //算法
        //    我们可以使用两个指针分别读取数组的非负部分与负数部分 —— 指针 i 反向读取负数部分，指针 j 正向读取非负数部分。
        //那么，现在我们就在使用两个指针分别读取两个递增的数组了（按元素的平方排序）。接下来，我们可以使用双指针的技巧合并这两个数组。
        public int[] SortedSquares1(int[] A)
        {
            int N = A.Length;
            int positive = 0;
            while (positive < N && A[positive] < 0)
            {
                positive++;
            }
               
            int negetive = positive - 1;

            int[] ans = new int[N];
            int curIndex = 0;

            while (negetive >= 0 && positive < N)
            {
                int left = A[negetive] * A[negetive];
                int right = A[positive] * A[positive];
                //负数部分和正数部分，那边的平方小就取那边的填
                if ( left< right)
                {
                    ans[curIndex++] = left;
                    negetive--;
                }
                else
                {
                    ans[curIndex++] = right;
                    positive++;
                }
            }

            while (negetive >= 0)
            {
                ans[curIndex++] = A[negetive] * A[negetive];
                negetive--;
            }
            while (positive < N)
            {
                ans[curIndex++] = A[positive] * A[positive];
                positive++;
            }

            return ans;

        }
    }
}