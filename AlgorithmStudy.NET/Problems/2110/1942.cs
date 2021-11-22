using System;

namespace AlgorithmStudy.Problems._2110
{
    class _1942
    {
        static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                DateTime time1 = DateTime.Parse(input[0]);
                DateTime time2 = DateTime.Parse(input[1]);

                if (time1 == time2)
                {
                    Console.WriteLine(0);
                    continue;
                }

                int h = time2.Hour;

                if (time1 >= time2)
                    h += 24;

                int m = time2.Minute;
                int s = time2.Second;

                int min = time1.Hour * 10000 + time1.Minute * 100 + time1.Second;

                int count = 0;

                while (true)
                {
                    int timeNum = h * 10000 + m * 100 + s;

                    if (timeNum % 3 == 0)
                        count++;

                    if (timeNum <= min)
                        break;

                    if (s == 0)
                    {
                        if (m == 0)
                        {
                            h--;
                            m = 59;
                        }
                        else
                            m--;
                        s = 59;
                    }
                    else
                        s--;
                }

                Console.WriteLine(count);
            }
        }
    }
}
