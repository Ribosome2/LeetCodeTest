namespace TestInConsoleApp
{
    public class Int_Fib
    {
        //斐波那契数，通常用 F(n) 表示，形成的序列称为斐波那契数列。该数列由 0 和 1 开始，后面的每一项数字都是前面两项数字的和。也就是：
        //F(0) = 0,   F(1) = 1
        //F(N) = F(N - 1) + F(N - 2), 其中 N > 1.
        public int Fib(int N)
        {
            //暴力递归;
            if (N == 0)
            {
                return 0;
            }
            if (N == 1)
            {
                return 1;
            }

            return Fib(N - 1) + Fib(N - 2);
        }

        public int Fib1(int N)
        {
            //减少重复计算的方法
            if (N == 0)
            {
                return 0;
            }
            if (N == 1)
            {
                return 1;
            }
           
            int prev = 1;
            int prePrev = 0;
            int loopCount = N - 2;
            while (loopCount>0)
            {
                int temp = prev;
                prev = prePrev + prev;
                prePrev = temp;
                loopCount--;
            }

            return prev + prePrev;
        }
    }
}