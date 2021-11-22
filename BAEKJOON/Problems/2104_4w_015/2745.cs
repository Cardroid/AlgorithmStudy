using System;

namespace BAEKJOON.Problems._2104_4w
{
    class _2745
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string value = input[0];
            int baseNum = int.Parse(input[1]);
            long result = 0;

            for (int i = 0; i < value.Length; i++)
                result += (int.TryParse(value[i].ToString(), out int p) ? p : value[i] - 55) * (long)Math.Pow(baseNum, value.Length - (i + 1));

            Console.WriteLine(result);
        }
    }
}
