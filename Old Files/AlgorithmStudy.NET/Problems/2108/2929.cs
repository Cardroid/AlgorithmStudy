using System;
using System.Text.RegularExpressions;

namespace AlgorithmStudy.Problems._2108
{
    class _2929
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int result = 0;

            Regex regex = new(@"[A-Z]");

            foreach (Match match in regex.Matches(input))
            {
                int temp = (match.Index + result) % 4;

                if (temp != 0)
                    result += 4 - temp;
            }

            Console.WriteLine(result);
        }
    }
}
