using System;
using System.Text;

namespace AlgorithmStudy.Problems._2109
{
    class _21734
    {
        static void Main()
        {
            var str = Console.ReadLine();
            var result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                var c = str[i];
                var cs = ((int)c).ToString();

                int s = 0;

                for (int j = 0; j < cs.Length; j++)
                    s += int.Parse(cs[j].ToString());

                result.Append(c, s)
                    .AppendLine();
            }

            Console.WriteLine(result);
        }
    }
}
