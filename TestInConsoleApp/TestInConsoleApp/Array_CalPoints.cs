using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Array_CalPoints
    {
//        你现在是棒球比赛记录员。
//        给定一个字符串列表，每个字符串可以是以下四种类型之一：
//        1.整数（一轮的得分）：直接表示您在本轮中获得的积分数。
//        2. "+"（一轮的得分）：表示本轮获得的得分是前两轮有效 回合得分的总和。
//        3. "D"（一轮的得分）：表示本轮获得的得分是前一轮有效 回合得分的两倍。
//        4. "C"（一个操作，这不是一个回合的分数）：表示您获得的最后一个有效 回合的分数是无效的，应该被移除。
//
//        每一轮的操作都是永久性的，可能会对前一轮和后一轮产生影响。
//        你需要返回你在所有回合中得分的总和。
        public int CalPoints(string[] ops)
        {
            int re = 0;
            List<int> opList=new List<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                var  ch = ops[i];
                if (ch == "C")
                {

                }
                if (ch == "+")
                {
                    int num= opList[opList.Count - 1]+ opList[opList.Count - 2];
                    re += num;
                    opList.Add(num);
                }else if (ch == "D")
                {
                    int num= (opList[opList.Count - 1] * 2);
                    re += num;
                    opList.Add(num);
                }else if (ch == "C")
                {
                    re -= opList[opList.Count - 1];
                    opList.RemoveAt(opList.Count-1);
                }
                else
                {
                    int num = int.Parse(ch);
                    opList.Add(num);
                    re += num;
                }
            }
            return re;
        }
    }
}