using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _11728 // Unsolved
    {
        static void Main()
        {
            Console.ReadLine();

            string[] temp = Console.ReadLine().Split(' ');
            temp = Console.ReadLine().Split(' ');

            List<int> list = new();

            for (int i = 0; i < temp.Length; i++)
                list.Add(int.Parse(temp[i]));

            int bIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (i == b.Length || bIndex == b.Length)
                    break;
                else if (list[i] >= b[bIndex])
                    list.Insert(i, b[bIndex++]);
            }

            if (bIndex < b.Length)
            {
                for (; bIndex < b.Length; bIndex++)
                    list.Add(b[bIndex]);
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
