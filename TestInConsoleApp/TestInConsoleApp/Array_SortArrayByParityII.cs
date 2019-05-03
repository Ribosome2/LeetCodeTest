using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_SortArrayByParityII
    {
//        给定一个非负整数数组 A， A 中一半整数是奇数，一半整数是偶数。
//        对数组进行排序，以便当 A[i] 为奇数时，i 也是奇数；当 A[i] 为偶数时， i 也是偶数。
//        你可以返回任何满足上述条件的数组作为答案。
        public int[] SortArrayByParityII(int[] A)
        {
            Queue<int> oddQueue = new Queue<int>();//record
            Queue<int> evenQueque = new Queue<int>();
            for (int i = 0; i < A.Length; i++)
            {
                int num = A[i];
                if ((num & 1) == 0) 
                {
                    if ((i & 1) != 0)
                    {
                        evenQueque.Enqueue(i);
                    }
                }
                else
                {
                    if ((i & 1) == 0)
                    {
                        oddQueue.Enqueue(i);
                    }
                }
            }

            while (evenQueque.Count > 0)
            {
                int oddIndex= evenQueque.Dequeue();
                int evenIndex = oddQueue.Dequeue();
                int tem = A[oddIndex];
                A[oddIndex] = A[evenIndex];
                A[evenIndex] = tem;
            }
            return A;
        }

        public int[] SortArrayByParity2(int[] A)
        {
            Queue<int> oddQueue = new Queue<int>();
            Queue<int> evenQueque = new Queue<int>();
            for (int i = 0; i < A.Length; i++)
            {
                int num = A[i];
                if (num % 2 == 0)
                {
                    evenQueque.Enqueue(num);
                }
                else
                {
                    oddQueue.Enqueue(num);
                }
            }

            int index = 0;
            while (evenQueque.Count > 0)
            {
                A[index] = evenQueque.Dequeue();
                index++;

                A[index] = oddQueue.Dequeue();
                index++;
            }
            return A;
        }
    }
}