using System;
using System.Linq;

namespace AlgorithmStudy.Problems._2109
{
    class _1259
    {
        static void Main()
        {
            do
            {
                var v = Console.ReadLine();

                if (v == "0")
                    break;

                if (new string(v.Reverse().ToArray()) == v)
                    Console.WriteLine("yes");
                else
                    Console.WriteLine("no");
            }
            while (true);
        }
    }
}
