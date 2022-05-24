using System;

namespace AlgorithmStudy.Problems._2108
{
    class _10162
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            int[] button = new int[] { 300, 60, 10 };
            int[] result = new int[3];

            if (T % button[2] != 0)
                Console.WriteLine(-1);
            else
            {
                for (int i = 0; i < button.Length;)
                {
                    if (button[i] <= T)
                    {
                        T -= button[i];
                        result[i]++;
                    }
                    else
                        i++;
                }

                Console.Write(result[0]);
                Console.Write(' ');
                Console.Write(result[1]);
                Console.Write(' ');
                Console.WriteLine(result[2]);
            }
        }
    }
}
