using System;
using System.Collections.Generic;
using System.Linq;

namespace BAEKJOON.Problems._2104_1w
{
    class _2857
    {
        static void Main()
        {
            List<Tuple<int, string>> fbiList = new List<Tuple<int, string>>();

            for (int i = 1; i <= 5; i++)
            {
                string temp = Console.ReadLine();

                if (temp.Contains("FBI"))
                    fbiList.Add(new Tuple<int, string>(i, temp));
            }

            if (fbiList.Count == 0)
                Console.WriteLine("HE GOT AWAY!");
            else
                Console.WriteLine(string.Join(" ", fbiList.Select(n => n.Item1)));
        }
    }
}
