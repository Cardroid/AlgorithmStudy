using System;

namespace BAEKJOON.Problems._2103_3w
{
    class _16968
    {
        static void Main()
        {
            string value = Console.ReadLine();

            int result = 0;

            // -1 = 초기, 0 = 문자열, 1 = 숫자
            int fdState = -1;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == 'd')
                {
                    if (fdState == -1)
                        result = 10;
                    else if (fdState == 1)
                        result *= 9;
                    else
                        result *= 10;
                    fdState = 1;
                }
                else
                {
                    if (fdState == -1)
                        result = 26;
                    else if (fdState == 0)
                        result *= 25;
                    else
                        result *= 26;
                    fdState = 0;
                }
            }

            Console.WriteLine(result);
        }
    }
}
