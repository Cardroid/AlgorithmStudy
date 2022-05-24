using System;
using System.Collections.Generic;

namespace BAEKJOON.Problems._2103_2w
{
    class _1935
    {
        static void Main()
        {
            int numLineLength = int.Parse(Console.ReadLine());
            string fValue = Console.ReadLine();

            int[] n = new int[numLineLength];

            for (int line = 0; line < numLineLength; line++)
            {
                string temp = Console.ReadLine();

                n[line] = int.Parse(temp);
            }

            Stack<double> e = new Stack<double>();

            for (int i = 0; i < fValue.Length; i++)
            {
                if (64 < fValue[i] && fValue[i] < 91)
                {
                    e.Push(n[Decode(fValue[i])]);
                }
                else
                {
                    double b = e.Pop();
                    double a = e.Pop();

                    if (fValue[i] == '+')
                    {
                        e.Push(a + b);
                    }
                    else if (fValue[i] == '-')
                    {
                        e.Push(a - b);
                    }
                    else if (fValue[i] == '*')
                    {
                        e.Push(a * b);
                    }
                    else if (fValue[i] == '/')
                    {
                        e.Push(a / b);
                    }
                }
            }

            Console.WriteLine($"{e.Pop():f2}");
            Console.ReadLine();
        }

        static int Decode(char value) => value - 65;
    }
}
