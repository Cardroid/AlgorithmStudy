using System;
using System.Collections.Generic;

namespace AlgorithmStudy.Problems._2109
{
    class _17219
    {
        static void Main()
        {
            string[] t = Console.ReadLine().Split(' ');
            int inputCount = int.Parse(t[0]);
            int testCount = int.Parse(t[1]);
            Dictionary<string, string> pwDic = new();

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                pwDic[input[0]] = input[1];
            }
            
            for (int i = 0; i < testCount; i++)
            {
                Console.WriteLine(pwDic[Console.ReadLine()]);
            }
        }
    }
}
