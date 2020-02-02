using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class MaxSatisfied_Test
    {

//        今天，书店老板有一家店打算试营业 customers.length分钟。每分钟都有一些顾客（customers[i]）会进入书店，所有这些顾客都会在那一分钟结束后离开。
//
//        在某些时候，书店老板会生气。 如果书店老板在第 i 分钟生气，那么 grumpy[i] = 1，否则 grumpy[i] = 0。 当书店老板生气时，那一分钟的顾客就会不满意，不生气则他们是满意的。
//
//        书店老板知道一个秘密技巧，能抑制自己的情绪，可以让自己连续 X 分钟不生气，但却只能使用一次。
//
//        请你返回这一天营业下来，最多有多少客户能够感到满意的数量。
//
//
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/grumpy-bookstore-owner
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int MaxSatisfied(int[] customers, int[] grumpy, int X)
        {
            //找出每个X区间内，保持连续不生气和原来状态能增加多少满意人M， 选择M最大的区间去保持不生气
           
            int totalNum = 0;

            for (int i = 0; i < X; i++)
            {
                totalNum += GetAddNum(ref customers, ref grumpy, i);
            }
           
            int maxTotal = totalNum;
            int startIndex = 0;
            for (int i = 1; i < grumpy.Length - X+1; i++)
            {
                int prevAdd = GetAddNum(ref customers, ref grumpy, i - 1);
                int nextAdd = GetAddNum(ref customers, ref grumpy, i-1+X);
                int tempTotal =totalNum - prevAdd +nextAdd;
                if (tempTotal > maxTotal)
                {
                    startIndex = i;
                    maxTotal = tempTotal;
                }
                totalNum = tempTotal;
            }

            //把X范围全部标记为不生气
            for (int i = 0; i < X; i++)
            {
                grumpy[startIndex + i] = 0;
            }

            int count = 0;
            for (int i = 0; i < customers.Length; i++)
            {
                if (grumpy[i] == 0)
                {
                    count += customers[i];
                }
            }

            return count;
        }
        public int MaxSatisfied1(int[] customers, int[] grumpy, int X)
        {
            var totalNum = 0;
            int maxAddNum = 0;
            int tempAddNum = 0;
            int tempIndex = 0;
            for (int i = 0; i < grumpy.Length; i++)
            {
                tempIndex++;
                //不生气的时间内的人数直接累增
                if (grumpy[i] == 0)
                {
                    totalNum += customers[i];
                    customers[i] = 0;  //这是为了后面的滑动窗口直接可以减去左边的
                }
                else
                {
                    tempAddNum += customers[i];
                }
                //一个滑动窗口
                if (tempIndex == X)
                {
                    maxAddNum = Math.Max(maxAddNum, tempAddNum);
                    
                    //满了一个滑动窗口之后，后面的每一次移动都是一个滑动窗口
                    //后面的等于右边加的值减去左边加的值
                    int leftIndex = i - X+1;
                    tempAddNum -= customers[leftIndex];
                    tempIndex--;
                }
            }
            return totalNum+maxAddNum;
        }
        int GetAddNum(ref int[] customers,ref  int[] grumpy,int index )
        {
            if (grumpy[index]==1) //只有生气的那一分钟改变可以增加满意人数
            {
                return customers[index];
            }
            return 0;
        }
    }
}
