using System;
using System.Linq;

namespace AlgorithmStudy.Problems._2110
{
    class _10769
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] temp = input.Split(":-");

            int happyCount = temp.Where(str => str.StartsWith(')')).Count();
            int sadCount = temp.Where(str => str.StartsWith('(')).Count();

            if (happyCount == 0 && sadCount == 0)
                Console.WriteLine("none");
            else if (happyCount > sadCount)
                Console.WriteLine("happy");
            else if (happyCount < sadCount)
                Console.WriteLine("sad");
            else
                Console.WriteLine("unsure");
        }
    }
}
