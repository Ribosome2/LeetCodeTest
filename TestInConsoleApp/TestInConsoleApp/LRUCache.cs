using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{

    //        运用你所掌握的数据结构，设计和实现一个 LRU(最近最少使用) 缓存机制。它应该支持以下操作： 获取数据 get 和 写入数据 put 。
    //
    //        获取数据 get(key) - 如果密钥(key) 存在于缓存中，则获取密钥的值（总是正数），否则返回 -1。
    //        写入数据 put(key, value) - 如果密钥不存在，则写入其数据值。当缓存容量达到上限时，它应该在写入新数据之前删除最近最少使用的数据值，从而为新的数据值留出空间。
    //
    //        进阶:
    //
    //        你是否可以在 O(1) 时间复杂度内完成这两种操作？
    //
    //        来源：力扣（LeetCode）
    //        链接：https://leetcode-cn.com/problems/lru-cache
    //        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

    public class LRUCache
    {
        class DLinkedNode
        {
            public int key;
            public int value;
            public DLinkedNode prev;
            public DLinkedNode next;
        }
        private DLinkedNode head, tail;

        void AddNode(DLinkedNode node)
        {
            node.prev = head;
            node.next = head.next;

            head.next.prev = node;
            head.next = node;
        }

        void RemoveNode(DLinkedNode node)
        {
            DLinkedNode prev = node.prev;
            DLinkedNode next = node.next;

            prev.next = next;
            next.prev = prev;
        }

        void MoveToHead(DLinkedNode node)
        {
            RemoveNode(node);
            AddNode(node);
        }

       DLinkedNode PopTail()
        {
            DLinkedNode res = tail.prev;
            RemoveNode(res);
            return res;
        }

        Dictionary<int,DLinkedNode> cache = new Dictionary<int, DLinkedNode>();
        private int size = 0;
        private int mCapacity = 0;
        public LRUCache(int capacity)
        {
            this.size = 0;
            mCapacity = capacity;

            head =new  DLinkedNode();
            tail = new DLinkedNode();
            head.next = tail;
            tail.prev = head;
        }


        /// <summary>
        /// 没有进返回默认值，有的话就就把这个值移到最前面
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Get(int key)
        {
            DLinkedNode node = null;
            cache.TryGetValue(key, out node);
            if (node == null)
            {
                return -1;
            }
            MoveToHead(node);
            return node.value;
        }


        /// <summary>
        /// 如果之前没有要写入的Key就新增，已经有的话就移到最前面
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Put(int key, int value)
        {
            DLinkedNode node;
            cache.TryGetValue(key, out node);
            if (node == null)
            {
                DLinkedNode newNode = new DLinkedNode();
                newNode.key = key;
                newNode.value = value;
                cache.Add(key,newNode);
                AddNode(newNode);
                ++size;
                if (size > mCapacity)
                {
                    //pop the tail 
                    DLinkedNode tail = PopTail();
                    cache.Remove(tail.key);
                    --size;
                }
            }
            else
            {
                //Update the value
                node.value = value;
                MoveToHead(node);
            }
        }
    }
}
