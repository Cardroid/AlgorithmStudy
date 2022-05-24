using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmStudy.Problems._2106_4w_019
{
    class _11651
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Tuple<int, int>> XYList = new();

            for (int i = 0; i < count; i++)
            {
                var temp = Console.ReadLine().Split();
                XYList.Add(new(int.Parse(temp[0]), int.Parse(temp[1])));
            }

            XYList.Sort((a, b) => a.Item2 == b.Item2 ? a.Item1.CompareTo(b.Item1) : a.Item2.CompareTo(b.Item2));

            StringBuilder result = new();

            for (int i = 0; i < XYList.Count; i++)
            {
                result.Append(XYList[i].Item1);
                result.Append(' ');
                result.Append(XYList[i].Item2);
                result.AppendLine();
            }

            Console.WriteLine(result);
        }
    }
}
