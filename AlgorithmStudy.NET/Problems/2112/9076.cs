using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy.NET.Problems._2112
{
    class _9076
    {
        static void Main()
        {
            var tCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < tCase; i++)
            {
                List<int> words = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                words.Sort();

                words.RemoveAt(0);
                words.RemoveAt(words.Count - 1);

                if (Math.Abs(words[0] - words[words.Count - 1]) > 3)
                    Console.WriteLine("KIN");
                else
                    Console.WriteLine(words.Sum());
            }
        }
    }
}
