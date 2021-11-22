using System;

namespace BAEKJOON.Problems._2105_2w_017
{
    class _7567
    {
        static void Main()
        {
            string value = Console.ReadLine();
            int result = 0;

            char temp = '\0';
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == temp)
                    result += 5;
                else
                    result += 10;

                temp = value[i];
            }

            Console.WriteLine(result);
        }
    }
}
