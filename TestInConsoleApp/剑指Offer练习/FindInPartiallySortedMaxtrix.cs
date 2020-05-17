using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 剑指Offer练习
{
    public class FindInPartiallySortedMaxtrix
    {
        public void Test()
        {
            var arr = new int[,] { { 1, 3, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            Console.WriteLine("Result " + Find(arr, 5));
        }

        bool Find(int[,] matrix, int number)
        {
            bool found=false;
            if(matrix!=null )
            {
                var columns = matrix.GetLength(1);
                var rows = matrix.GetLength(0);
                if (columns>0 && rows>0)
                {
                    int row = 0;
                    int col = columns-1;
                    while(row<rows && col>=0 && row<rows && col<columns)
                    {
                        int curNum = matrix[row, col];
                        if (curNum == number)
                        {
                            found = true;
                            break;
                        }else if (matrix[row, col] > number)
                        {
                            col--;
                        }
                        else
                        {
                            row++;
                        }
                    }
                }
               
            }

            return found;

        }
    }
}
