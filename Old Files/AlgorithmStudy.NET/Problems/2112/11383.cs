using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy.NET.Problems._2112
{
    class _11383
    {
        static void Main()
        {
            var lineCount = int.Parse(Console.ReadLine().Split(' ')[0]);

            List<string> lines = new();
            List<string> compareLines = new();

            for (int i = 0; i < lineCount; i++)
                lines.Add(Console.ReadLine());
            for (int i = 0; i < lineCount; i++)
                compareLines.Add(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                string line = string.Join("", lines[i].Select(n => new string(n, 2)).ToArray());

                if (line != compareLines[i])
                {
                    Console.WriteLine("Not Eyfa");
                    return;
                }
            }

            Console.WriteLine("Eyfa");
        }
    }
}
