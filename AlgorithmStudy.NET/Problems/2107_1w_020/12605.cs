using System;
using System.Text;

namespace AlgorithmStudy.Problems._2107_1w_020
{
    class _12605
    {
        static void Main()
        {
            int caseCount = int.Parse(Console.ReadLine());

            StringBuilder @string = new();

            for (int i = 0; i < caseCount; i++)
            {
                var array = Console.ReadLine().Split();

                @string.Append("Case #")
                    .Append(i + 1)
                    .Append(": ");

                for (int j = array.Length - 1; j >= 0; j--)
                {
                    @string.Append(array[j])
                        .Append(' ');
                }

                Console.WriteLine(@string);
                @string.Clear();
            }
        }
    }
}
