using System;
using System.Collections.Generic;

namespace AlgorithmStudy.NET.Problems._2112
{
    class _5363
    {
        static void Main()
        {
            var tCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < tCase; i++)
            {
                Queue<string> words = new(Console.ReadLine().Split(' '));

                words.Enqueue(words.Dequeue());
                words.Enqueue(words.Dequeue());

                Console.WriteLine(string.Join(' ', words));
            }
        }
    }
}
