using System;
using System.Text.RegularExpressions;

namespace AlgorithmStudy.Problems._2108
{
    class _1013
    {
        static void Main()
        {
            Regex regex = new(@"^(100+1+|01)+$");

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
