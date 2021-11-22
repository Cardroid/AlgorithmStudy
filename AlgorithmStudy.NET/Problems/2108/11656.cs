using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmStudy.Problems._2108
{
    class _11656
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> inputDic = new();
            StringBuilder result = new();

            for (int i = 0; i < input.Length; i++)
                inputDic.Add(input[i..input.Length]);

            inputDic.Sort();

            for (int i = 0; i < inputDic.Count; i++)
                result.AppendLine(inputDic[i]);

            Console.WriteLine(result.ToString());
        }
    }
}
