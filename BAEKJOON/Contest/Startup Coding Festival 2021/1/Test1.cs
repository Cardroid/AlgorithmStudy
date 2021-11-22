using System;
using System.Collections.Generic;
using System.Linq;

namespace BAEKJOON.Contest.Startup_Coding_Festival_2021._1
{

	// 대여 시간을 추천해드립니다

	class Test1
    {
		static void Main()
		{
			int totalLength = int.Parse(Console.ReadLine());

			List<DateTime> startTimes = new List<DateTime>();
			List<DateTime> endTimes = new List<DateTime>();

			for (int i = 0; i < totalLength; i++)
			{
				DateTime[] t = Console.ReadLine().Split('~').Select(te => DateTime.Parse(te.Trim())).ToArray();

				startTimes.Add(t[0]);
				endTimes.Add(t[1]);
			}

			DateTime lStartTime = DateTime.MinValue;
			DateTime lEndTime = DateTime.MaxValue;

			for (int i = 0; i < startTimes.Count; i++)
			{
				if (lStartTime < startTimes[i])
					lStartTime = startTimes[i];
			}
			for (int i = 0; i < endTimes.Count; i++)
			{
				if (lEndTime > endTimes[i])
					lEndTime = endTimes[i];
			}

			if (lStartTime < lEndTime)
				Console.WriteLine($"{lStartTime:HH:mm} ~ {lEndTime:HH:mm}");
			else
				Console.WriteLine(-1);
		}
	}
}