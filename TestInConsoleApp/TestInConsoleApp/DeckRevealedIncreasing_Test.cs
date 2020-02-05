using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class DeckRevealedIncreasing_Test
    {
//        牌组中的每张卡牌都对应有一个唯一的整数。你可以按你想要的顺序对这套卡片进行排序。
//
//        最初，这些卡牌在牌组里是正面朝下的（即，未显示状态）。
//
//        现在，重复执行以下步骤，直到显示所有卡牌为止：
//
//        从牌组顶部抽一张牌，显示它，然后将其从牌组中移出。
//        如果牌组中仍有牌，则将下一张处于牌组顶部的牌放在牌组的底部。
//        如果仍有未显示的牌，那么返回步骤 1。否则，停止行动。
//        返回能以递增顺序显示卡牌的牌组顺序。
//
//        答案中的第一张牌被认为处于牌堆顶部。
//
//        来源：力扣（LeetCode）
//        链接：https://leetcode-cn.com/problems/reveal-cards-in-increasing-order
//        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            
            Array.Sort(deck);
            LinkedList<int> linkList =new LinkedList<int>();
            //通过逆推的方式，最后留在链表里面的一定是最大的数
            int index = deck.Length - 1;
            while (index>0)
            {
                linkList.AddFirst(deck[index]);
                if (linkList.Count > 1 )
                {
                    //把底部的放到顶部
                    var last = linkList.Last.Value;
                    linkList.RemoveLast();
                    linkList.AddFirst(last);
                }

                index--;
            }

            //第一个一定是最小的
            linkList.AddFirst(deck[0]);
            index = 0;
            while (linkList.Count>0)
            {
                deck[index] = linkList.First.Value;
                linkList.RemoveFirst();
                index++;
            }
            
            return deck;
        }
    }
}
