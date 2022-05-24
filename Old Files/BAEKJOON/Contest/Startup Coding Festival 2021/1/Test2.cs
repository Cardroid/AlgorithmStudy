using System;
using System.Linq;

namespace BAEKJOON.Contest.Startup_Coding_Festival_2021._1
{

    // 배송 전략 실험

    class Test2
    {
        static void Main()
        {
            Console.ReadLine();
            int[] array = Console.ReadLine().Select(n => int.Parse(n.ToString())).ToArray();

            int result = 0;

            int oneCount = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] == 1)
                {
                    if (i > 2)
                        result += oneCount++;
                    else
                        result++;
                }
                else
                {
                    oneCount = 0;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
