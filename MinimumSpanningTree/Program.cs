using System;

namespace MinimumSpanningTree
{
    class Program
    {
        /// <summary>
        /// The input to the program will be a file named vstup.txt. The first input line will contain 
        /// the number of cities N, and the second will contain the number of roads M. Each of the following 
        /// M lines will contain three integers characterizing a single road. The first two numbers represent 
        /// the cities connected by the road and the third number is the road's length. There will be at most 
        /// 100 cities and 1000 roads.
        /// 
        /// Write a list of roads that must be cleared to the output file vystup.txt. Write each such road 
        /// as a pair of numbers representing the cities that it connects. The last output line should contain 
        /// the total number of kilometers of roads to be cleared.
        /// </summary>

        static void Main(string[] args)
        {
            int verticesCount = int.Parse(Console.ReadLine());
            int edgesCount = int.Parse(Console.ReadLine());
            MST.Graph graph = MST.CreateGraph(verticesCount, edgesCount);

            for (int i = 0; i < edgesCount; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                graph.edge[i].Source = int.Parse(s[0])-1;
                graph.edge[i].Destination = int.Parse(s[1])-1;
                graph.edge[i].Weight = int.Parse(s[2]);
            }
            
            MST.Kruskal(graph);
        }
    }
}
