using System;
using System.Collections.Generic;
using System.Linq;

namespace BAEKJOON.Problems._2105_1w
{
    class _2947
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(n => int.Parse(n)).ToList();

            bool isSorted = false;
            string currentState = string.Join(" ", list);

            while (!isSorted)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        int temp = list[i];
                        list.RemoveAt(i);
                        list.Insert(i + 1, temp);
                        currentState = string.Join(" ", list);
                        Console.WriteLine(currentState);
                    }
                }

                if (currentState == "1 2 3 4 5")
                    isSorted = true;
            }
        }
    }
}
