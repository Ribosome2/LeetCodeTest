using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RotateMatrix roteMatrix=new RotateMatrix();
            var m = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
            };
//            m = new int[,]
//            {
//                {1, 2, },
//                {3, 4,},
//            };

//            m=new int[,]
//            {
//                {5,1,9,11},
//                {2,4,8,10},
//                {13,3,6,7},
//                { 15,14,12,16}
//            }
//            ;

            roteMatrix.Rotate(m);
            Console.Write(m);
            Console.Read();
        }
    }
}
