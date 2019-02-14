using System.Collections;
using System.Collections.Generic;
public class IsBracketsValid  {

    public bool IsValid(string s)
    {

        Stack bStack=new Stack();
        for (int i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            if (ch == '(' || ch == '{' || ch == '[')
            {
                bStack.Push(ch);
            }else if (ch == ')' || ch == '}' || ch == ']')
            {
                if (bStack.Count == 0)
                {
                    return false;
                }
                else
                {
                    var last =(char) bStack.Pop();
                    if (ch == ')' && last != '(')
                    {
                        return false;
                    }
                    else if (ch == '}' && last != '{')
                    {
                        return false;
                    }
                    else if (ch == ']' && last != '[')
                    {
                        return false;
                    }
                }
            }
        }

       
        return bStack.Count==0;
    }
}
