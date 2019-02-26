namespace TestInConsoleApp
{
    public class Int_GuessNum
    {
        //这里是题目给的，不用自己实现
        //你调用一个预先定义好的接口 guess(int num)，它会返回 3 个可能的结果（-1，1 或 0）：
        //-1 : 我的数字比较小
        //1 : 我的数字比较大
        //0 : 恭喜！你猜对了！
        private int guess(int num)
        {
            int MyNum=2;
            if (MyNum == num)
            {
                return 0;
            }else if (MyNum < num)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        public int guessNumber(int n)
        {
            int left = 1;
            int right = n;
            while (left<right)
            {
                int mid = left + (right-left)/2;
                int re = guess(mid);
                if ( re== 0)
                {
                    return mid;
                }else if (re == 1) //大了
                {
                    left = mid+1;
                }
                else
                {
                    right = mid-1;
                }
            }

            return left;
        }
    }
}