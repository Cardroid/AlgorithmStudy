using System;
using System.Text.RegularExpressions;

namespace AlgorithmStudy.Problems._2108
{
    class _9342
    {
        static void Main()
        {
            Regex regex = new(@"^[A-F]?A+F+C+[A-F]?$");

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                    Console.WriteLine("Infected!");
                else
                    Console.WriteLine("Good");
            }
        }
    }
}
