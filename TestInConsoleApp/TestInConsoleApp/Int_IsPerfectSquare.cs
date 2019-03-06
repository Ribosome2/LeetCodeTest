namespace TestInConsoleApp
{
    public class Int_IsPerfectSquare
    {
        //给定一个正整数 num，编写一个函数，如果 num 是一个完全平方数，则返回 True，否则返回 False。

        //说明：不要使用任何内置的库函数，如 sqrt。
        public bool IsPerfectSquare(int num)
        {
            int left = 1;
           
            int right = num < 46340 ? num : 46340; //要考虑超出Int范围的情况  Math.Sqrt(int.MaxValue) 可以得到46340
            while (left<=right)
            {
                int mid = left + (right - left) / 2;
                int n = mid * mid;
                if (n == num)
                {
                    return true;
                }else if (n < num)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }

       
    }
}