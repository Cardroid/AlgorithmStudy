using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmStudy.Problems._2110
{
    class _16165
    {
        static void Main()
        {
            var temp = Console.ReadLine().Split();
            int dataCount = int.Parse(temp[0]);
            int quizCount = int.Parse(temp[1]);

            Dictionary<string, string> Dic = new();

            for (int i = 0; i < dataCount; i++)
            {
                string group = Console.ReadLine();
                int count = int.Parse(Console.ReadLine());

                for (int j = 0; j < count; j++)
                {
                    Dic[Console.ReadLine()] = group;
                }
            }

            StringBuilder result = new();

            for (int i = 0; i < quizCount; i++)
            {
                string quizData = Console.ReadLine();
                int quizKind = int.Parse(Console.ReadLine());

                if (quizKind == 0)
                {
                    var col = Dic.Where(d => d.Value == quizData).Select(d => d.Key).ToList();
                    col.Sort();
                    result.AppendLine(string.Join('\n', col));
                }
                else
                    result.AppendLine(Dic[quizData]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
