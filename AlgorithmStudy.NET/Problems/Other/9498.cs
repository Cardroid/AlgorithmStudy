using System;

namespace AlgorithmStudy.Problems.Other
{
    class _9498
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());

            if (100 >= score && score >= 90)
                Console.WriteLine('A');
            else if (90 > score && score >= 80)
                Console.WriteLine('B');
            else if (80 > score && score >= 70)
                Console.WriteLine('C');
            else if (70 > score && score >= 60)
                Console.WriteLine('D');
            else
                Console.WriteLine('F');
        }
    }
}
