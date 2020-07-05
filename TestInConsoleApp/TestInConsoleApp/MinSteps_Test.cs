namespace TestInConsoleApp
{
    public class MinSteps_Test
    {
//        最初在一个记事本上只有一个字符 'A'。你每次可以对这个记事本进行两种操作：
//
//        Copy All(复制全部) : 你可以复制这个记事本中的所有字符(部分的复制是不允许的)。
//        Paste(粘贴) : 你可以粘贴你上一次复制的字符。
//        给定一个数字 n 。你需要使用最少的操作次数，在记事本中打印出恰好 n个 'A'。输出能够打印出 n个 'A' 的最少操作次数
//
//            来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/2-keys-keyboard
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int MinSteps(int n)
        {
//            假设 g_1, g_2, ... 就是 N 的素数分解，则需要的最少操作等于这些素数之和。
            int ans = 0;
            int d = 2;
            while (n > 1)
            {
                while (n % d == 0)
                {
                    ans += d;
                    n /= d;
                }
                d += 1;
            }
            return ans;
        }
    }
}