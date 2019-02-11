using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseInt  {
    public static int Reverse(int x)
    {
        int rev = 0;
        while (x!=0)
        {
            int pop = x % 10;
            x /= 10;

            if (rev > int.MaxValue / 10 || rev  < int.MinValue / 10)
            {
                return 0;
            }
            //官方给出的溢出判断是因为MAX_VALUE: 2147483647 MIN_VALUE: -2147483648 他要判断最后一位不要大于 7 和 不要小于8
            if ((rev == int.MaxValue / 10 && pop > 7) || (rev==int.MinValue/10 && pop<-8))
            {
                return 0;
            }

            
            rev = rev * 10 + pop;
        }

        return rev;
    }
    
}
