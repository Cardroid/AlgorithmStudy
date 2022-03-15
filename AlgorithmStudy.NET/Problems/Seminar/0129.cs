using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy.NET.Problems.Seminar
{
    public class _0129
    {
        static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ');

            int N = int.Parse(temp[0]);
            int M = int.Parse(temp[1]);
            int V = int.Parse(temp[2]);

            bool[,] graph = new bool[N + 1, N + 1];

            for (int i = 0; i < M; i++)
            {
                temp = Console.ReadLine().Split(' ');
                graph[int.Parse(temp[0]), int.Parse(temp[1])] = true;
            }

            DFS(graph, N, V);
            BFS(graph, N, V);
        }

        static void DFS(bool[,] graph, int N, int V)
        {
            bool[,] board = new bool[N, N];

            Stack<int> stack = new Stack<int>();

            stack.Push(V);
        }

        static void BFS(bool[,] graph, int N, int V)
        {
            bool[,] board = new bool[N, N];

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(V);

            while (queue.Count > 0)
            {
                graph[]
            }
        }
    }
}
