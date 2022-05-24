using System;
using System.Text;

namespace AlgorithmStudy.Problems._2109
{
    class _5430
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            for (int count = 0; count < testCase; count++)
            {
                string command = Console.ReadLine();
                int arrayLength = int.Parse(Console.ReadLine());
                int[] array = new int[arrayLength];
                string[] arrayStr = Console.ReadLine().Split(',');
                bool isError = false;

                bool isReverse = false;
                int start = 0;
                int end = arrayLength;

                if (arrayLength == 1)
                    array[0] = int.Parse(arrayStr[0][1..^1]);
                else
                {
                    for (int i = 0; i < arrayLength; i++)
                    {
                        int num;

                        if (i == 0)
                            num = int.Parse(arrayStr[i][1..]);
                        else if (i == arrayStr.Length - 1)
                            num = int.Parse(arrayStr[i][..^1]);
                        else
                            num = int.Parse(arrayStr[i]);

                        array[i] = num;
                    }
                }

                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] == 'R')
                        isReverse = !isReverse;
                    else
                    {
                        if (start == end)
                        {
                            isError = true;
                            break;
                        }

                        if (isReverse)
                            end--;
                        else
                            start++;
                    }
                }

                if (isError)
                    result.AppendLine("error");
                else
                {
                    result.Append('[');

                    if (isReverse)
                    {
                        if (end - start == 1)
                            result.Append(array[--end].ToString());
                        else if (end - start > 1)
                        {
                            StringBuilder stringBuilder = new();

                            stringBuilder.Append(array[--end]);

                            for (int i = end - 1; i >= start; i--)
                                stringBuilder.Append(',').Append(array[i]);

                            result.Append(stringBuilder.ToString());
                        }
                    }
                    else
                    {
                        if (end - start == 1)
                            result.Append(array[start].ToString());
                        else if (end - start > 1)
                        {
                            StringBuilder stringBuilder = new();

                            stringBuilder.Append(array[start++]);

                            for (int i = start; i < end; i++)
                                stringBuilder.Append(',').Append(array[i]);

                            result.Append(stringBuilder.ToString());
                        }
                    }

                    result.AppendLine("]");
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
