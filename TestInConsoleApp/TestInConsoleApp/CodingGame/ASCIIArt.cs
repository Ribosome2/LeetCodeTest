using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp.CodingGame
{
    class ASCIIArt
    {
        static void Main_No(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            string T = Console.ReadLine().ToUpper();
            Console.Error.WriteLine("L  " + L + "  H " + H + "  T " + T);

            string[] strRows =new string[H]; 
            for (int i = 0; i < H; i++)
            {
                string ROW = Console.ReadLine();
                strRows[i] = ROW;
                Console.Error.WriteLine("row " + ROW);
                //  Console.WriteLine(ROW);
            }


            int[] indexArray = new int[T.Length];
            for (int i = 0; i < T.Length; i++)
            {
                var ch = T[i];
                int letterIndex;
                if (ch < 'A' || ch > 'Z')
                {
                    letterIndex = 26;
                }
                else
                {
                    letterIndex = ch - 'A';
                }
                indexArray[i]=letterIndex;
            }

            for (int i = 0; i < H; i++)
            {
               StringBuilder lineBuilder =new StringBuilder();
                for (int j = 0; j < indexArray.Length; j++)
                {
                    int letterIndex = indexArray[j];
                    var subRow = strRows[i].Substring(letterIndex * L, L);
                    lineBuilder.Append(subRow);
                }
                Console.WriteLine(lineBuilder.ToString());
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            // Console.WriteLine("answer");
        }
    }
}
