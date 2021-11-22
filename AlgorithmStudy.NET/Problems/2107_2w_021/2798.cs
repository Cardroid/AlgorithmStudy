using System;
using System.Linq;

namespace AlgorithmStudy.Problems._2107_2w_021
{
    class _2798
    {
        static void Main()
        {
            int M = int.Parse(Console.ReadLine().Split()[1]);
            int[] cards = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            int sumResult = 0;

            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    for (int k = 0; k < cards.Length; k++)
                    {
                        if (i == j || j == k || i == k)
                            continue;

                        int temp = Math.Max(cards[i] + cards[j] + cards[k], sumResult);

                        if (M >= temp)
                            sumResult = temp;
                    }
                }
            }

            Console.WriteLine(sumResult);
        }
    }
}
