using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_SortArrayByParity
    {

        //Given an array A of non-negative integers, return an array consisting of all the even elements of A,
        //followed by all the odd elements of A.
        //You may return any answer array that satisfies this condition.
        public int[] SortArrayByParity(int[] A)
        {
            Queue<int> oddQueue=new Queue<int>();
            Queue<int> evenQueque=new Queue<int>();
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
            }
            while (oddQueue.Count>0)
            {
                A[index] = oddQueue.Dequeue();
                index++;
            }

            

            return A;
        }

        public int[] SortArrayByParity1(int[] A)
        {
            if (A == null || A.Length == 1)
                return A;
            //左、右指针初始化
            int left = 0;
            int right = A.Length - 1;
            int tem;
            while (left < right)
            {
                //左指针对应偶数值，右指针对应奇数值，进行交换
                if ((A[left] & 1) == 1 && (A[right] & 1) == 0)
                {
                    tem = A[left];
                    A[left] = A[right];
                    A[right] = tem;
                }
                else if ((A[left] & 1) == 0)
                {
                    //左指针对应的是偶数值，符合题意，继续向右移动
                    left++;
                }
                else if ((A[right] & 1) == 1)
                {
                    //右指针对应的是奇数值，符合题意，继续向左移动
                    right--;
                }
            }
            return A;
        }
    }
}