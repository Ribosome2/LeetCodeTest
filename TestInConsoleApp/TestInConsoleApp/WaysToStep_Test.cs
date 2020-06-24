namespace TestInConsoleApp
{
    public class WaysToStep_Test
    {
//        三步问题。有个小孩正在上楼梯，楼梯有n阶台阶，小孩一次可以上1阶、2阶或3阶。实现一种方法，计算小孩有多少种上楼梯的方式。结果可能很大，你需要对结果模1000000007
//
//            来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/three-steps-problem-lcci
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int WaysToStep(int n)
        {
            if (n == 1)
            {
                return 1;
            }else if (n == 2)
            {
                return 2;
            }else if (n == 3)
            {
                return 4;
            }

            int[] result = new int[n];
            result[0] = 1;
            result[1] = 2;
            result[2] = 4;
            for (int i = 3; i < n; i++)
            {
                result[i] = (result[i - 1] + result[i - 2]) % 1000000007 + result[i - 3];
                //这里三个数相加，第二个不取模的话加第三个数就会数值溢出了
                result[i] = result[i] % 1000000007;
            }

            return result[n-1];

        }

        public int WaysToStep1(int n)
        {
            if (n<=2)
            {
                return n;
            }
            else if (n == 3)
            {
                return 4;
            }

           
            //因为每次相加只跟前三个数有关系，所以，可以不用数组存
            int first = 1;
            int second = 2;
            int third = 4;
            for (int i = 3; i < n; i++)
            {
                result[i] = (result[i - 1] + result[i - 2]) % 1000000007 + result[i - 3];
                //这里三个数相加，第二个不取模的话加第三个数就会数值溢出了
                result[i] = result[i] % 1000000007;
            }

            return result[n - 1];

        }
    }
}