using System;

namespace BAEKJOON.Contest.Startup_Coding_Festival_2021
{

    // 사은품 교환하기

    class MockTest2
    {
        static void Main()
        {
            int testCount = int.Parse(Console.ReadLine());

            for (int testCaseIndex = 0; testCaseIndex < testCount; testCaseIndex++)
            {
                string[] tStr = Console.ReadLine().Split(' ');
                long n = long.Parse(tStr[0]);
                long m = long.Parse(tStr[1]);

                Console.WriteLine(Math.Min(n / 5, (m + n) / 12));
            }

            Console.ReadLine();
        }
    }
}
