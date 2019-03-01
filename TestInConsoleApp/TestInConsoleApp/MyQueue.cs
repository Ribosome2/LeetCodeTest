using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class MyQueue
    {
        
            private Queue<int> mQueue=new Queue<int>();
            /** Initialize your data structure here. */
            public MyQueue()
            {

            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                mQueue.Enqueue(x);
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                int count = mQueue.Count;
                while (count>0)
                {
                    mQueue.Enqueue(mQueue.Dequeue());
                    count--;
                }
                int result= mQueue.Dequeue();
            
                count = mQueue.Count;
                while (count > 0)
                {
                    mQueue.Enqueue(mQueue.Dequeue());
                    count--;
                }

                return result;
            }

            /** Get the front element. */
            public int Peek()
            {
                int count = mQueue.Count;
                while (count > 0)
                {
                    mQueue.Enqueue(mQueue.Dequeue());
                    count--;
                }

                int result = mQueue.Peek();
                count = mQueue.Count;
                while (count > 0)
                {
                    mQueue.Enqueue(mQueue.Dequeue());
                    count--;
                }
            return result;
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return mQueue.Count == 0;
            }
    }
}