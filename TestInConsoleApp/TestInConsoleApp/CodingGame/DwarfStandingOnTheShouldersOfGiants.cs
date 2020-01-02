using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp.CodingGame
{
    class DwarfStandingOnTheShouldersOfGiants
    {
        protected class ParentNode
        {
            public ParentNode(int id)
            {
                Id = id;
            }
            public int Id;
            public List<ParentNode> ParentNodes =new List<ParentNode>();
        }
        static void TestMain(string[] args)
        {
            var nodeDict = new Dictionary<int, ParentNode>();
            int n = int.Parse(Console.ReadLine()); // the number of relationships of influence
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int x = int.Parse(inputs[0]); // a relationship of influence between two people (x influences y)
                int y = int.Parse(inputs[1]);
                if (nodeDict.ContainsKey(y) == false)
                {
                    nodeDict[y]= new ParentNode(y);
                }

                if (nodeDict.ContainsKey(x) == false)
                {
                    nodeDict[x]= new ParentNode(x);
                }

                nodeDict[y].ParentNodes.Add(nodeDict[x]);
            }

            int maxNode = 0;
            var iter = nodeDict.GetEnumerator();
            while (iter.MoveNext())
            {
                int depth = GetDepth(iter.Current.Value);
                maxNode = Math.Max(depth, maxNode);
                Console.Error.WriteLine("Debug messages..."+iter.Current.Key+"Count "+ iter.Current.Value.ParentNodes.Count);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // The number of people involved in the longest succession of influences
            Console.WriteLine(maxNode);
        }

        static int GetDepth(ParentNode node)
        {
            if (node.ParentNodes.Count==0 )
            {
                return 1;
            }
            else
            {
                int depth = 0;
                for (int i = 0; i < node.ParentNodes.Count; i++)
                {
                   depth= Math.Max(depth, 1+GetDepth(node.ParentNodes[i]));
                }

                return depth;
            }
        }
    }
}
