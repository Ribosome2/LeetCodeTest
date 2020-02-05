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

            var test = new DeckRevealedIncreasing_Test();;
          
            Console.WriteLine(test.DeckRevealedIncreasing(new []{17,13,11,2,3,5,7}));
            Console.ReadKey();
        }


       
    }
}
