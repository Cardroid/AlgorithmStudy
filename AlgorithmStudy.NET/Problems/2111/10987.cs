using System;
using System.Linq;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _10987
    {
        static void Main()
        {
            Console.WriteLine(Console.ReadLine().Select(c => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ? 1 : 0).Sum(c => int.Parse(c.ToString())));
        }
    }
}
