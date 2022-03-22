using System;
using CustomData;

namespace 自己实现数据结构
{
    class Program
    {
        static void Main(string[] args)
        {
            KyleDictionary<int,int> myDictionary =new KyleDictionary<int,int>();
            myDictionary[2] = 5;
            Console.WriteLine("Hello HashMap");
            Console.WriteLine("Dict "+myDictionary[2]);
        }
    }
}
