using System;
using System.Text;

namespace AlgorithmStudy.Problems._2110
{
    class _5637
    {
        static void Main()
        {
            string longStr = string.Empty;
            StringBuilder sb = new();

            while (true)
            {
                string input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    if ((input[i] >= 65 && input[i] <= 114) || (input[i] >= 97 && input[i] <= 122) || input[i] == 45)
                        sb.Append(input[i]);
                    else
                    {
                        if (sb.Length > longStr.Length)
                            longStr = sb.ToString();

                        sb.Clear();
                    }
                }

                if (input.EndsWith("E-N-D"))
                    break;
            }

            Console.WriteLine(longStr.ToLower());
        }
    }
}
