using System;

namespace AlgorithmStudy.Problems.Other
{
    class _2884
    {
        static void Main()
        {
            string[] temp = Console.ReadLine().Split();
            int hour = int.Parse(temp[0]);
            int minute = int.Parse(temp[1]);

            if (minute < 45)
            {
                minute += 60;
                if (hour == 0)
                    hour = 23;
                else
                    hour--;
            }

            minute -= 45;

            Console.WriteLine($"{hour} {minute}");
        }
    }
}
