using System;

namespace AlgorithmStudy.NET.Problems._2112
{
    class _13985
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            //string calc = input[1];

            int num1 = int.Parse(input[0]);
            int num2 = int.Parse(input[2]);
            int result = int.Parse(input[4]);

            Console.WriteLine(num1 + num2 == result ? "YES" : "NO");
        }
    }
}
