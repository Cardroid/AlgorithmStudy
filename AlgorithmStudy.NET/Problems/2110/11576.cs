using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy.Problems._2110
{
    class _11576
    {
        static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ');
            int baseA = int.Parse(temp[0]);
            int baseB = int.Parse(temp[1]);
            Console.ReadLine();

            List<int> nums = new();
            var n = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            for (int i = 0; i < n.Length; i++)
            {
                nums.Add((int)(n[i] * Math.Pow(baseA, n.Length - (i + 1))));
            }

            int sum10 = nums.Sum();

            nums.Clear();

            while (sum10 >= baseB)
            {
                nums.Insert(0, sum10 % baseB);
                sum10 /= baseB;
            }
            nums.Insert(0, sum10);

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
