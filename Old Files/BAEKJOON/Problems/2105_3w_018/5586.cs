using System;
using System.Text.RegularExpressions;

namespace BAEKJOON.Problems._2105_3w_018
{
    class _5586
    {
        static void Main()
        {
            string input = Console.ReadLine().Replace("I", "II");

            Console.WriteLine(new Regex("JOI").Matches(input).Count);
            Console.WriteLine(new Regex("IOI").Matches(input).Count);
        }
    }
}
