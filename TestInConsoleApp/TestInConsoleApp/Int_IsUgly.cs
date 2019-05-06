namespace TestInConsoleApp
{
    public class Int_IsUgly
    {
//        编写一个程序判断给定的数是否为丑数。
//        丑数就是只包含质因数 2, 3, 5 的正整数
        public bool IsUgly(int num)
        {
            if (num<1) return false;
            while (num%5==0)
            {
                num = num / 5;
            }

            while (num%3==0)
            {
                num = num / 3;
            }

            while (num %2==0)
            {
                num=num >> 1;
            }

            return num == 1;
        }
    }
}