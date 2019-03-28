namespace TestInConsoleApp
{
    public class Array_NumPairsDivisibleBy60
    {
        //在歌曲列表中，第 i 首歌曲的持续时间为 time[i] 秒。
        //返回其总持续时间（以秒为单位）可被 60 整除的歌曲对的数量。形式上，我们希望索引的数字 i<j 且有 (time[i] + time[j]) % 60 == 0。
        public int NumPairsDivisibleBy60(int[] time)
        {
            //可以运行，但是复杂度太高，数量大的时候会超时，需优化
            int count = 0;
            for (int i = 0; i < time.Length; i++)
            {
                for (int j = i + 1; j < time.Length; j++)
                {
                    if ((time[i] + time[j]) % 60 == 0)
                    {
                        count++;
                    }
                }
            }

            return count;


        }
    }
}