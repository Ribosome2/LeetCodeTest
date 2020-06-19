using System.Collections.Generic;

namespace 剑指Offer
{
    public class MinStack_Test
    {
        public class MinStack
        {
            private Stack<int> dataStack;
            private Stack<int> minStack;

            /** initialize your data structure here. */
            public MinStack()
            {
                dataStack =new Stack<int>();
                minStack = new Stack<int>();
            }
            

            public void Push(int x)
            {
                dataStack.Push(x);
                if (minStack.Count > 0 && minStack.Peek() < x)
                {
                    minStack.Push(minStack.Peek());
                }
                else
                {
                    minStack.Push(x);
                }
            }

            public void Pop()
            {
                dataStack.Pop();
                minStack.Pop();
            }

            public int Top()
            {
                return dataStack.Peek();
            }

            public int Min()
            {
                return minStack.Peek();
            }
        }
    }
}