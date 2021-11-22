using System;
using System.Linq;
using System.Text;

namespace AlgorithmStudy.Problems._2110
{
    class _1244
    {
        static void Main()
        {
            void SwitchSwitch(ref int state) => state = state == 1 ? 0 : 1;

            Console.ReadLine();
            int[] switchArray = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                int[] human = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

                if (human[0] == 1)
                {
                    for (int j = human[1] - 1; j < switchArray.Length; j += human[1])
                        SwitchSwitch(ref switchArray[j]);
                }
                else
                {
                    human[1]--;

                    int head = human[1];
                    int tail = human[1];

                    while (true)
                    {
                        head--;
                        tail++;

                        if (switchArray.Length <= tail || head < 0 || switchArray[tail] != switchArray[head])
                        {
                            head++;
                            tail--;
                            break;
                        }
                    }

                    for (int j = head; j <= tail; j++)
                        SwitchSwitch(ref switchArray[j]);
                }
            }

            if (switchArray.Length == 1)
                Console.WriteLine(switchArray[0]);
            else
            {
                StringBuilder result = new();
                result.Append(switchArray[0]);
                for (int i = 1; i < switchArray.Length; i++)
                {
                    if (i % 20 == 0)
                        result.AppendLine().Append(switchArray[i]);
                    else
                        result.Append(' ').Append(switchArray[i]);
                }
                Console.WriteLine(result);
            }
        }
    }
}
