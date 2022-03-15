using System;
using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_RepeatedNTimes
    {
//        大小为 2N 的数组 A 中有 N+1 个不同的元素，其中有一个元素重复了 N 次。
//        返回重复了 N 次的那个元素。
        public int RepeatedNTimes(int[] A)
        {
            Dictionary<int,int> dict=new Dictionary<int, int>();
            int N = A.Length / 2;
            for (int i = 0; i < A.Length; i++)
            {
                int key = A[i];
                if (dict.ContainsKey(key))
                {
                    dict[key] = dict[key] + 1;
                }
                else
                {
                    dict[key] = 1;
                }

                if (dict[key] == N)
                {
                    return key;
                }
            }

            return 0;
        }
        
        public int RepeatedNTimes1(int[] A)
        {
            Dictionary<int,int> dict=new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                int key = A[i];
//                大小为 2N 的数组 A 中有 N+1 个不同的元素，其中有一个元素重复了 N 次。
                //根据这这句话可得只有一个重复的元素
                if (dict.ContainsKey(key))
                {
                    return key;
                } else
                {
                    dict[key] = 1;
                }
            }

            return 0;
        }
        
        //大小为 2N 的数组 A 中有 N+1 个不同的元素，其中有一个元素重复了 N 次。
        //根据这这句话可得只有一个重复的元素
        public int RepeatedNTimes2(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] == A[i])
                    {
                        return A[i];
                    }
                }
            }

            return 0;
        }
    }
}