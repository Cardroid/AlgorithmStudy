using System;
using System.Linq;

namespace BAEKJOON.Problems._2103_4w
{
    class _1145
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
            int result = 1;

            while (true)
            {
                int count = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (result % array[i] == 0)
                        count++;
                }

                if (count > 2)
                    break;

                result++;
            }

            Console.WriteLine(result);
        }
    }
}
