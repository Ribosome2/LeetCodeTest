using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class RecentCounterTest
    {
        public class RecentCounter
        {
            Queue<int> pinQueue=new Queue<int>();
            public RecentCounter()
            {

            }

            public int Ping(int t)
            {
                while (true)
                {
                    if (pinQueue.Count == 0)
                    {
                        break;
                    }
                    if (t - pinQueue.Peek() <= 3000)
                    {
                        break;
                    }

                    pinQueue.Dequeue();
                }
                
                pinQueue.Enqueue(t);
                return pinQueue.Count;
            }
        }
    }
}