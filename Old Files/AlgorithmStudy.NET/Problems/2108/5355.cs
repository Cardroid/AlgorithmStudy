using System;

namespace AlgorithmStudy.Problems._2108
{
    class _5355
    {
        static void Main()
        {
            int testCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                double num = double.Parse(input[0]);

                for (int j = 1; j < input.Length; j++)
                {
                    switch (input[j])
                    {
                        case "@":
                            num *= 3;
                            break;
                        case "%":
                            num += 5;
                            break;
                        case "#":
                            num -= 7;
                            break;
                    }
                }

                Console.WriteLine(num.ToString("f2"));
            }
        }
    }
}
