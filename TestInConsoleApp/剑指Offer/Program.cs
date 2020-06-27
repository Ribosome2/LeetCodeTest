using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 剑指Offer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("offer !!!!!!!!");
            var test = new WordExistInMatrix();

            var matrix = new char[][] { new Char[]{'a'}};
            Console.WriteLine(test.Exist(matrix,"ab" ));
            Console.ReadKey();
        }
    }
}
