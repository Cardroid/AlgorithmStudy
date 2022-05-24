using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmStudy.Problems._2109
{
    class _1874
    {
        static void Main()
        {
            int testCount = int.Parse(Console.ReadLine());
            Stack<int> stack = new();
            int count = 1;
            StringBuilder result = new();

            for (int i = 0; i < testCount; i++)
            {
                int n = int.Parse(Console.ReadLine());

                while (count <= n)
                {
                    stack.Push(count);
                    count++;
                    result.AppendLine("+");
                }

                if (stack.Peek() == n)
                {
                    stack.Pop();
                    result.AppendLine("-");
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
