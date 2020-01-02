using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInConsoleApp.CodingGame
{
    class SkynetRevolutionEpisode1
    {

        public class SkyNetNode
        {
            public SkyNetNode(int index)
            {
                Id = index;
            }

            

            public int Id;
            public List<SkyNetNode> Links =new List<SkyNetNode>();
            public bool IsGateWay;
        }

        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]); // the total number of nodes in the level, including the gateways
            int L = int.Parse(inputs[1]); // the number of links
            int E = int.Parse(inputs[2]); // the number of exit gateways

            SkyNetNode[] nodes = new SkyNetNode[N];
            for (int i = 0; i < N; i++)
            {
                nodes[i]=new SkyNetNode(i);
            }

            for (int i = 0; i < L; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int N1 = int.Parse(inputs[0]); // N1 and N2 defines a link between these nodes
                int N2 = int.Parse(inputs[1]);
                nodes[N1].Links.Add(nodes[N2]);
                nodes[N2].Links.Add(nodes[N1]);
            }
            for (int i = 0; i < E; i++)
            {
                int EI = int.Parse(Console.ReadLine()); // the index of a gateway node
                nodes[EI].IsGateWay = true;
            }

            // game loop
            while (true)
            {
                int SI = int.Parse(Console.ReadLine()); // The index of the node on which the Skynet agent is positioned this turn

                int otherIndex = -1;
                var agentLinks = nodes[SI].Links;
                foreach (var node in agentLinks)
                {
                    if (node.IsGateWay)
                    {
                        otherIndex = node.Id;
                        break;
                    }
                }

                //没有直接连接到gateway的，只在周围连接里面随便断一个
                if (otherIndex < 0)
                {
                    otherIndex = nodes[SI].Links[0].Id;
                }

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");


                // Example: 0 1 are the indices of the nodes you wish to sever the link between
                Console.WriteLine(SI+" "+otherIndex);
            }
        }

      
    }
}
