using System.Collections.Generic;

namespace TestInConsoleApp
{
    public class Queque_TwoQuequeAsStack
    {
        public class MyStack
        {
            Queue<int> queque1;
            Queue<int> queque2;
            /** Initialize your data structure here. */
            public MyStack()
            {
                queque1 = new Queue<int>();
                queque2 = new Queue<int>();
            }

            /** Push element x onto stack. */
            public void Push(int x)
            {
                PutBack();
                queque1.Enqueue(x);
            }

            /** Removes the element on top of the stack and returns that element. */
            public int Pop()
            {
                while (queque1.Count>1)
                {
                    queque2.Enqueue(queque1.Dequeue());
                }
                int result = queque1.Dequeue();
                PutBack();
                return result ;
            }

            void PutBack()
            {
                while (queque2.Count > 0)
                {
                    queque1.Enqueue(queque2.Dequeue());
                }
            }

            /** Get the top element. */
            public int Top()
            {
                while (queque1.Count > 1)
                {
                    queque2.Enqueue(queque1.Dequeue());
                }

                if (queque1.Count == 0)
                {
                    PutBack();
                }
                return queque1.Peek();
            }

            /** Returns whether the stack is empty. */
            public bool Empty()
            {
                return (queque1.Count == 0 && queque2.Count==0) ;
            }
        }

    }
}