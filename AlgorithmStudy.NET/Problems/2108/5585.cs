using System;

namespace AlgorithmStudy.Problems._2108
{
    class _5585
    {
        static void Main()
        {
            int money = 1000 - int.Parse(Console.ReadLine());
            int[] changes = new int[] { 500, 100, 50, 10, 5, 1 };

            int result = 0;

            for (int i = 0; i < changes.Length;)
            {
                if (money >= changes[i])
                {
                    money -= changes[i];
                    result++;
                }
                else
                    i++;
            }

            Console.WriteLine(result);
        }
    }
}
