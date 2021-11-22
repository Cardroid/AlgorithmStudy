using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy.Problems._2107_2w_021
{
    class _7568
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            List<Tuple<int, int>> HW = new();

            for (int i = 0; i < length; i++)
            {
                int[] tempArray = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
                HW.Add(new(tempArray[0], tempArray[1]));
            }

            for (int i = 0; i < length; i++)
            {
                int d = 1;

                for (int j = 0; j < length; j++)
                {
                    if (HW[i].Item1 < HW[j].Item1 && HW[i].Item2 < HW[j].Item2)
                        d++;
                }
                Console.Write($"{d} ");
            }
        }
    }
}
