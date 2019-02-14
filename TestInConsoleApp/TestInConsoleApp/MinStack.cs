using System.Collections;
using System.Collections.Generic;

public class MinStack
{
    private Stack<int> mStack;
    private int minCount = 0;
    private int mMinValue = int.MaxValue;
    /** initialize your data structure here. */
    public MinStack()
    {
        mStack=new Stack<int>();
    }

    public void Push(int x)
    {
        if (x < mMinValue)
        {
            mMinValue = x;
            minCount=1;
        }else if (x == mMinValue)
        {
            minCount++;
        }

        mStack.Push(x);
        
    }

    public void Pop()
    {
        int value=(int)mStack.Pop();
        if (value == mMinValue)
        {
            minCount--;
            if (minCount == 0)
            {
                Stack<int> tempStack=new Stack<int>();
                mMinValue = int.MaxValue;
                while (mStack.Count>0)
                {
                    var tempValue = mStack.Pop();
                    if (tempValue <= mMinValue)
                    {
                        mMinValue = tempValue;
                        minCount++;
                    }
                    tempStack.Push(tempValue);
                }

                while (tempStack.Count>0)
                {
                    mStack.Push(tempStack.Pop());
                }
            }
        }
        
    }

    public int Top()
    {
        return (int)mStack.Peek();
    }

    public int GetMin()
    {
        return mMinValue;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
