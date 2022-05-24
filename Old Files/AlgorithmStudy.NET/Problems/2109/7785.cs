using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmStudy.Problems._2109
{
    class _7785
    {
        static void Main()
        {
            int testCount = int.Parse(Console.ReadLine());
            Dictionary<string, bool> logDic = new();

            for (int i = 0; i < testCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (logDic.TryGetValue(input[0], out bool isEnter))
                {
                    if (isEnter && input[1] == "leave")
                        logDic[input[0]] = false;
                    else if (!isEnter && input[1] == "enter")
                        logDic[input[0]] = true;
                }
                else
                {
                    if (input[1] == "leave")
                        logDic[input[0]] = false;
                    else if (input[1] == "enter")
                        logDic[input[0]] = true;
                }
            }

            var temp = logDic.Where(kp => kp.Value).Select(k => k.Key).ToList();
            temp.Sort();
            temp.Reverse();
            Console.WriteLine(string.Join('\n', temp));
        }
    }
}
