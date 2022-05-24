using System;
using System.Linq;

namespace AlgorithmStudy.Problems._2109
{
    class _10807
    {
        static void Main()
        {
            Console.ReadLine();
            var a = Console.ReadLine().Split(' ');
            var t = Console.ReadLine();
            Console.WriteLine(a.Count(i => i == t));
        }
    }
}
