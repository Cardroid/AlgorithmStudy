using System;
using System.Text;

namespace BAEKJOON.Problems._2105_3w_018
{
    class _2902
    {
        static void Main()
        {
            string[] value = Console.ReadLine().Split('-');
            StringBuilder @string = new StringBuilder();

            foreach (var item in value)
                @string.Append(item[0]);

            Console.WriteLine(@string.ToString());
        }
    }
}
