namespace TestInConsoleApp
{
    public class Int_ReachNumber
    {
        //在一根无限长的数轴上，你站在0的位置。终点在target的位置。
        //每次你可以选择向左或向右移动。第 n 次移动（从 1 开始），可以走 n 步。
        //返回到达终点需要的最小移动次数。
        public int ReachNumber(int target)
        {
            int curPos = 0;
            int step = 0;

            while (curPos!=target)
            {
                if (curPos == target)
                {
                    return step;
                }
                else
                {
                    step++;
                    if (curPos + step == target)
                    {
                        return step;
                    }else if (curPos + step > target)
                    {
                        curPos -= step;
                    }
                    else
                    {
                        curPos += step;
                    }
                }
            }
            

            return step;
        }
    }
}