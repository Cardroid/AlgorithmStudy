using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmStudy.Problems._2109
{
    class _3047
    {
        static void Main()
        {
            List<int> temp = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToList();
            temp.Sort();

            string order = Console.ReadLine();
            StringBuilder result = new();

            for (int i = 0; i < order.Length; i++)
            {
                result.Append(temp[order[i] - 65].ToString() + ' ');
            }

            Console.WriteLine(result.ToString());
        }
    }
}
