using System;
using System.Collections.Generic;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _1931
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Meeting> m = new();
            int result = 0;
            int end = 0;

            for (int i = 0; i < n; i++)
            {
                var temp = Console.ReadLine().Split(' ');
                m.Add(new Meeting() { Start = int.Parse(temp[0]), End = int.Parse(temp[1]) });
            }

            m.Sort((a, b) =>
            {
                if (a.End == b.End)
                    return a.Start < b.Start ? -1 : 1;
                else
                    return a.End < b.End ? -1 : 1;
            });

            for (int i = 0; i < m.Count; i++)
            {
                if (end <= m[i].Start)
                {
                    end = m[i].End;
                    result++;
                }
            }

            Console.WriteLine(result);
        }

        class Meeting
        {
            public int Start;
            public int End;
        }
    }
}
