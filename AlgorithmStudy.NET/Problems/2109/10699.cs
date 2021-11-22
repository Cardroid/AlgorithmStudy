using System;

namespace AlgorithmStudy.Problems._2109
{
    class _10699
    {
        static void Main()
        {
            Console.WriteLine((DateTime.UtcNow + TimeSpan.FromHours(9)).ToString("yyyy-MM-dd"));
            //Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time")).ToString("yyyy-MM-dd"));
        }
    }
}
