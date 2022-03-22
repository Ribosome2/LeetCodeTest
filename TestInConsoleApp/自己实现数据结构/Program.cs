using System;
using CustomData;

namespace 自己实现数据结构
{
    class Program
    {
        static void Main(string[] args)
        {
            KyleDictionary<int,int> myDictionary =new KyleDictionary<int,int>();
            Console.WriteLine("Hello HashMap");
            Console.WriteLine("ContainKey  " + myDictionary.ContainsKey(2));
            myDictionary[2] = 5;
            Console.WriteLine("ContainKey  " + myDictionary.ContainsKey(2));
            myDictionary.Remove(2);
            Console.WriteLine("after remove ContainKey  " + myDictionary.ContainsKey(2));
            Console.WriteLine("Dict "+myDictionary[2]);
            Console.WriteLine("Dict "+myDictionary[1]);
        }
    }
}
