using System;
using System.Linq;
using System.Text;

namespace AlgorithmStudy.Problems._2110
{
    class _5026
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());
            StringBuilder result = new();

            for (int i = 0; i < testCase; i++)
            {
                string input = Console.ReadLine();

                if (input == "P=NP")
                    result.AppendLine("skipped");
                else
                {
                    int[] nums = input.Split('+').Select(n => int.Parse(n)).ToArray();
                    result.AppendLine((nums[0] + nums[1]).ToString());
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
