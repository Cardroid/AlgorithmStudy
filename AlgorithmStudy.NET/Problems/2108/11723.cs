using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmStudy.Problems._2108
{
    class _11723
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());
            StringBuilder result = new();

            for (int i = 0; i < testCase; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                int x = 0;
                if (input.Length > 1 && !string.IsNullOrEmpty(input[1]))
                    x = int.Parse(input[1]);

                switch (command)
                {
                    case "add":
                        Add(x);
                        break;
                    case "remove":
                        Remove(x);
                        break;
                    case "check":
                        if (Check(x))
                            result.AppendLine("1");
                        else
                            result.AppendLine("0");
                        break;
                    case "toggle":
                        Toggle(x);
                        break;
                    case "all":
                        All();
                        break;
                    case "empty":
                        Empty();
                        break;
                }
            }

            Console.WriteLine(result.ToString());
        }

        private static List<int> S { get; } = new();

        private static void Add(int x)
        {
            if (!Check(x))
                S.Add(x);
        }

        private static void Remove(int x)
        {
            if (Check(x))
                S.Remove(x);
        }

        private static bool Check(int x)
            => S.Contains(x);

        private static void Toggle(int x)
        {
            if (Check(x))
                S.Remove(x);
            else
                S.Add(x);
        }

        private static void All()
        {
            S.Clear();
            for (int i = 0; i <= 20; i++)
                S.Add(i);
        }

        private static void Empty()
            => S.Clear();
    }
}
