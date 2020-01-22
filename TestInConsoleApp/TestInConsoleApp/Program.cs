using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts;

namespace TestInConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var test = new FreqAlphabets_Test();;
            ;
            var arr = new int[] {14, 13, 4, 7, 10, 17, 8, 3, 2, 13,};

        Console.WriteLine(new ComputeArena_Test().ComputeArea(-3,0,3,4,0,-1,9,2));
            LRUCache cache = new LRUCache(2);
            cache.Put(1,1);
            cache.Put(2,2);
            Console.WriteLine(cache.Get(1));
            cache.Put(3,3);
            Console.WriteLine(cache.Get(2));
            cache.Put(4,4);
            cache.Get(1);
            cache.Get(3);
            cache.Get(4);
            Console.Read();
        }


       
    }
}
