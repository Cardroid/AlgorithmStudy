using System;
using System.Linq;

namespace BAEKJOON.Contest.Startup_Coding_Festival_2021
{

    // 근묵자흑

    class MockTest1
    {
        static void Main()
        {
            string[] tStr = Console.ReadLine().Split(' ');
            //int arrayLength = int.Parse(tStr[0]);
            int numGroupLength = int.Parse(tStr[1]); // 중복되는 수는 빠질 수 있도록 1을 뺌
            int[] array = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            // 모아 둘 수 있는 연속된 수의 길이가 배열과 같거나, 더 길 경우
            if (numGroupLength == array.Length)
            {
                Console.WriteLine(1);
                return;
            }

            int result = 0;

            for (int i = 0; i < array.Length; i += numGroupLength - 1)
            {
                if (i > array.Length - 2 && array[array.Length - 2] == 1)
                    break;

                result++;
                for (int j = i; j < i + numGroupLength - 1 && j < array.Length; j++)
                    array[j] = 1;
            }

            Console.WriteLine(result);
        }
    }
}
