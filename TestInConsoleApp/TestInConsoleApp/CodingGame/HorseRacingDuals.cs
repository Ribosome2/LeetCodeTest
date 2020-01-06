using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp.CodingGame
{
    class HorseRacingDuals
    {
        static void Main_No(string[] args)
        {
            int minDif = Int32.MaxValue;
            int N = int.Parse(Console.ReadLine());
            List<int> dataList = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int pi = int.Parse(Console.ReadLine());
                dataList.Add(pi);
            }

            dataList.Sort();
            for (int i = 1; i < dataList.Count; i++)
            {
                int dif = dataList[i] - dataList[i - 1];
                if (dif < minDif)
                {
                    minDif = dif;
                }
            }
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(minDif.ToString());
        }
    }
}
