using System;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _1991
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());

            Node[] tree = new Node[26];

            for (int i = 0; i < testCase; i++)
            {
                var temp = Console.ReadLine().Split(' ');

                int index = temp[0][0] - 'A';
                tree[index] = new();
                tree[index].Left = temp[1][0] - 'A';
                tree[index].Right = temp[2][0] - 'A';
            }

            PreOrder(tree, 0);
            Console.WriteLine();
            InOrder(tree, 0);
            Console.WriteLine();
            PostOrder(tree, 0);
        }

        static void PreOrder(Node[] tree, int node)
        {
            if (node + 'A' == '.')
                return;

            Console.Write((char)(node + 'A'));
            PreOrder(tree, tree[node].Left);
            PreOrder(tree, tree[node].Right);
        }

        static void InOrder(Node[] tree, int node)
        {
            if (node + 'A' == '.')
                return;

            InOrder(tree, tree[node].Left);
            Console.Write((char)(node + 'A'));
            InOrder(tree, tree[node].Right);
        }

        static void PostOrder(Node[] tree, int node)
        {
            if (node + 'A' == '.')
                return;

            PostOrder(tree, tree[node].Left);
            PostOrder(tree, tree[node].Right);
            Console.Write((char)(node + 'A'));
        }

        class Node
        {
            public int Left;
            public int Right;
        }
    }
}
