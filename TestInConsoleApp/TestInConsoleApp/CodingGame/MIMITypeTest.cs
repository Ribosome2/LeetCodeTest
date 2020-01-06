using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp.CodingGame
{
    class MIMITypeTest
    {

        static void Main_No(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
            int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
            Dictionary<string, string> mDict = new Dictionary<string, string>();
            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string EXT = inputs[0].ToLower(); // file extension
                string MT = inputs[1]; // MIME type.
                if (string.IsNullOrEmpty(EXT) == false)
                {
                    mDict[EXT] = MT;
                }
                Console.Error.WriteLine("kv : " + EXT + "  " + MT);
            }
            for (int i = 0; i < Q; i++)
            {
                string FNAME = Console.ReadLine(); // One file name per line.
                Console.Error.WriteLine("fileName " + FNAME);
                string[] inputs = FNAME.Split('.');
                if (inputs.Length > 1)
                {
                    var key = inputs[inputs.Length-1].ToLower();
                    Console.Error.WriteLine("key  " + key);
                    if (mDict.ContainsKey(key))
                    {
                        Console.WriteLine(mDict[key]);
                    }
                    else
                    {
                        Console.WriteLine("UNKNOWN");
                    }

                }
                else
                {
                    Console.WriteLine("UNKNOWN");
                }
            }


            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // For each of the Q filenames, display on a line the corresponding MIME type. If there is no corresponding type, then display UNKNOWN.
            Console.WriteLine("UNKNOWN");
        }
    }
}
