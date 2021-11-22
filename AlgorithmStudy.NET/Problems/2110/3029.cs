using System;

namespace AlgorithmStudy.Problems._2110
{
    class _3029
    {
        static void Main()
        {
            DateTime time1 = DateTime.Parse(Console.ReadLine());
            DateTime time2 = DateTime.Parse(Console.ReadLine());

            if (time1 >= time2)
                time2 = time2.AddDays(1);

            TimeSpan result = (time1 - time2).Duration();
            if (result.Days == 1)
                Console.WriteLine("24:00:00");
            else
                Console.WriteLine(result.ToString(@"hh\:mm\:ss"));
        }
    }
}
