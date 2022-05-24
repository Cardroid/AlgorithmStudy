using System;
using System.Text;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _11944
    {
        static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ');
            int n = int.Parse(temp[0]);
            int m = int.Parse(temp[1]);
            StringBuilder sb = new();

            for (int i = 0; i < n; i++)
                sb.Append(n);

            string result = sb.ToString();

            Console.WriteLine(result.Length > m ? result[0..m] : result);
        }
    }
}
