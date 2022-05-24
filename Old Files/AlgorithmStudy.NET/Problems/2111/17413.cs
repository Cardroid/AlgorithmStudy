using System;
using System.Linq;
using System.Text;

namespace AlgorithmStudy.NET.Problems._2111
{
    class _17413
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder buffer = new();
            StringBuilder stringBuilder = new();

            bool isTag = false;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '<':
                        isTag = true;
                        break;
                    case '>':
                        isTag = false;
                        break;
                }

                if (isTag || input[i] == '>')
                {
                    if (buffer.Length > 0)
                    {
                        stringBuilder.Append(new string(buffer.ToString().Reverse().ToArray()));
                        buffer.Clear();
                    }
                    stringBuilder.Append(input[i]);
                }
                else
                {
                    if (input[i] == ' ')
                    {
                        if (buffer.Length > 0)
                        {
                            stringBuilder.Append(new string(buffer.ToString().Reverse().ToArray()));
                            buffer.Clear();
                        }

                        stringBuilder.Append(' ');
                    }
                    else
                        buffer.Append(input[i]);
                }
            }

            if (buffer.Length > 0)
                stringBuilder.Append(new string(buffer.ToString().Reverse().ToArray()));

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
