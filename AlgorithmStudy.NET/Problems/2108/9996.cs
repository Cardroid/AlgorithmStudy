using System;
using System.Text.RegularExpressions;

namespace AlgorithmStudy.Problems._2108
{
    class _9996
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            Regex regex = new("^" + Console.ReadLine().Replace("*", ".*") + "$");

            for (int i = 0; i < count; i++)
            {
                if (regex.IsMatch(Console.ReadLine()))
                    Console.WriteLine("DA");
                else
                    Console.WriteLine("NE");
            }
        }
    }
}
