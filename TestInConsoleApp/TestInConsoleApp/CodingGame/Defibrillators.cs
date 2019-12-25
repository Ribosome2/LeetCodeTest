using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp.CodingGame
{
    class Defibrillators
    {
        static void Test()
        {
            string LON = Console.ReadLine();
            string LAT = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            var longA =float.Parse(LON.Replace(',', '.'));
            var latA = float.Parse(LAT.Replace(',', '.'));

            double minDist = double.MaxValue;
            string answer ="None";
            for (int i = 0; i < N; i++)
            {
                string DEFIB = Console.ReadLine();
                var arr = DEFIB.Split(';');
                var defName = arr[1];
                var longPos =float.Parse(arr[4].Replace(',', '.'));
                var laPos = float.Parse(arr[5].Replace(',', '.'));
                var dist = GetDist(longA, longPos, latA, laPos);
                if (dist < minDist)
                {
                    minDist = dist;
                    answer = defName;
                }
                Console.Error.WriteLine("Debug messages..." + DEFIB);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(answer);
        }

        static double GetDist(float longA,float longB, float latA,float latB)
        {
            var x = (longB - longA) * Math.Cos(latA + latB);
            var y = latB - latA;
            return Math.Sqrt(x * x + y * y) * 6371;
        }
    }
}
