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
                    re -= opList[opList.Count - 1];
                    opList.RemoveAt(opList.Count - 1);
                }
                else
                {
                    int num;
                    if (ch == "+")
                    {
                         num = opList[opList.Count - 1] + opList[opList.Count - 2];
                    }
                    else if (ch == "D")
                    {
                         num = (opList[opList.Count - 1] * 2);
                    }
                    else
                    {
                         num = int.Parse(ch);
                    }
                    re += num;
                    opList.Add(num);
                }
                
            }
            return re;
        }


        public int CalPoints1(string[] ops)
        {
            int re = 0;
            Stack<int> opStack = new Stack<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                var str = ops[i];
                if (str == "+")
                {
                    //这是是细节关键，前两个回合也是可以用栈的
                    int oldTop = opStack.Pop();
                    int num = oldTop + opStack.Peek();
                    opStack.Push(oldTop);
                    opStack.Push(num);
                }else if (str == "D")
                {
                    opStack.Push(opStack.Peek()*2);
                }else if (str == "C")
                {
                    opStack.Pop();
                }
                else
                {
                    opStack.Push(int.Parse(str));
                }
            }

            while (opStack.Count>0)
            {
                re += opStack.Pop();
            }

            return re;
        }
    }
}