using System;

namespace BAEKJOON.Problems._2103_4w
{

    // 1120번 문자열

    class _1120
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split(' ');
              
              // 문자열 변경할 필요없음
              
              // ex) adaabc aababbc 각각 비교후 최솟값을 출력
              // 1 번째    | 2 번째
              // adaabc(c) | (a)adaabc
              // aababb c  |  a ababbc
              // = 3       | = 2
              
              // 2 번째가 답
              
            int result = int.MaxValue;
            
            for (int i = 0; i <= strArray[1].Length - strArray[0].Length; i++)
            {
                int count = 0;
                for (int j = 0; j < strArray[0].Length; j++)
                {
                    if (strArray[0][j] != strArray[1][i + j])
                        count++;
                }

                result = Math.Min(result, count);
            }

            Console.WriteLine(result);
        }
    }
}
