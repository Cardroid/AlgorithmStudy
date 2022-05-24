using System;
using System.Text.RegularExpressions;

namespace AlgorithmStudy.Problems._2108
{
    class _3447
    {
        static void Main()
        {
            Regex regex = new(@"BUG");

            string sourceCode = "";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == null)
                    break;

                sourceCode += string.Concat(input, '\n');
            }

            while (regex.IsMatch(sourceCode))
            {
                sourceCode = sourceCode.Replace("BUG", "");
            }

            Console.Write(sourceCode);
        }
    }
}
