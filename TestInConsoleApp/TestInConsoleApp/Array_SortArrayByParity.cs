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