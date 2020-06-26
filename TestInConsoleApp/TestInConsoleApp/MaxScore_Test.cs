using System;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class MaxScore_Test
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            //F(m,n)=max(a[m]+f(m+1), a[n]+ f(n-1)
            //当m==n 或(m-n)==1 是边界条件
            int result = 0;
            if (k >= cardPoints.Length)
            {
                for (int i = 0; i < cardPoints.Length; i++)
                {
                    result += cardPoints[i];
                }
            }
            else
            {
                //考虑k左右分配的问题
                //sum(k)= sum(left)+sum(k-left)
                int max = 0;
                int leftSum = 0;
                //这里注意，左边有k+1中和，右边也有k+1种和
                int[] rightArr = new int[k+1];
                rightArr[0] = 0;
                for (int i = 0; i < rightArr.Length-1; i++)
                {
                    rightArr[i + 1] = rightArr[i] + cardPoints[cardPoints.Length - 1 - i];
                }
                for (int left = 0; left < k+1; left++)
                {
                    int rightSum = rightArr[k - left ];
                    max = Math.Max(leftSum + rightSum, max);
                    leftSum += cardPoints[left];
                }
                return max;
            }
            return result;
        }

      
    }
}