using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmStudy.Problems._2109
{
    class _1755
    {
        static Dictionary<int, string> Dic = new()
        {
            { 8, "eight" },
            { 5, "five" },
            { 4, "four" },
            { 9, "nine" },
            { 1, "one" },
            { 7, "seven" },
            { 6, "six" },
            { 3, "three" },
            { 2, "two" },
            { 0, "zero" },
        };

        static void Main()
        {
            var t = Console.ReadLine().Split(' ');
            StringBuilder resultStr = new();

            int start = int.Parse(t[0]);
            int end = int.Parse(t[1]);

            List<int> result = new();

            for (int i = start; i <= end; i++)
                result.Add(i);

            result.Sort((a, b) => Calc(a).CompareTo(Calc(b)));

            for (int i = 0; i < result.Count; i++)
            {
                if (i != 0 && i % 10 == 0)
                    resultStr.AppendLine();

                resultStr.Append(result[i].ToString() + ' ');
            }

            Console.WriteLine(resultStr.ToString());
        }

        static string Calc(int v)
        {
            List<string> result = new();
            var vStr = v.ToString();

            for (int i = 0; i < vStr.Length; i++)
            {
                result.Add(Dic[int.Parse(vStr[i].ToString())]);
            }

            return string.Join(' ', result);
        }
    }
}
