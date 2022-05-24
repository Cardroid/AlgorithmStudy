using System;
using System.Collections.Generic;

namespace AlgorithmStudy.Problems._2107_1w_020
{
    class _20001
    {
        static void Main()
        {
            Console.ReadLine();

            Stack<int> stack = new();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "문제")
                    stack.Push(0);
                else if (input == "고무오리")
                {
                    if (stack.Count > 0)
                        stack.Pop();
                    else
                    {
                        stack.Push(0);
                        stack.Push(0);
                    }
                }
                else
                    break;
            }
            Console.WriteLine(stack.Count > 0 ? "힝구" : "고무오리야 사랑해");
        }
    }
}
