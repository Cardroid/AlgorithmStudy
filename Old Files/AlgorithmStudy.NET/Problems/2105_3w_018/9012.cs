using System;
using System.Collections.Generic;
using System.Linq;

namespace BAEKJOON.Problems._2105_3w_018
{
    class _9012
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Stack<char> stack = new Stack<char>();

                foreach (var item in Console.ReadLine().Reverse())
                    stack.Push(item);

                int eval = 0;
                bool result = true;

                while (stack.Count > 0)
                {
                    char temp =  stack.Pop();

                    if (temp == '(')
                        eval++;
                    else if (temp == ')')
                    {
                        if (eval <= 0)
                        {
                            result = false;
                            break;
                        }

                        eval--;
                    }
                }

                if (result && eval != 0)
                    result = false;

                Console.WriteLine(result ? "YES" : "NO");
            }
        }
    }
}
