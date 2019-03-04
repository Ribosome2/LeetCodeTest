using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_AddToArrayForm
    {
        //对于非负整数 X 而言，X 的数组形式是每位数字按从左到右的顺序形成的数组。例如，如果 X = 1231，那么其数组形式为[1, 2, 3, 1]。
        //给定非负整数 X 的数组形式 A，返回整数 X+K 的数组形式
        public List<int> AddToArrayForm(int[] A, int K)
        {
            List<int> result=new List<int>();
            Stack<int> numStack=new Stack<int>();
            int temp = 0;
            for (int i = A.Length-1; i >= 0; i--)
            {
                int num = A[i];
                if (K > 0)
                {
                    int n1 = K % 10;
                    K /= 10;
                    num += n1;
                }
                num += temp;
                if (num < 10)
                {
                    temp = 0;
                }
                else
                {
                    temp = 1;
                    num -= 10;
                }
                numStack.Push(num);
            }

            while (K>0)
            {
                int num = K % 10;
                K /= 10;
                num += temp;
                if (num < 10)
                {
                    temp = 0;
                }
                else
                {
                    temp = 1;
                    num -= 10;
                }

                numStack.Push(num);
            }

            if (temp > 0)
            {
                numStack.Push(1);
            }

            while (numStack.Count>0)
            {
                result.Add(numStack.Pop());
            }
            return result;
        }
    }
}