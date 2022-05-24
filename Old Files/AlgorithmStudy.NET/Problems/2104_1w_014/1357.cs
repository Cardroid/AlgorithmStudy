using System;
using System.Linq;

namespace BAEKJOON.Problems._2104_1w
{
    class _1357
    {
        static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ').ToArray();
            int a = Rev(temp[0]);
            int b = Rev(temp[1]);
            Console.WriteLine(Rev((a + b).ToString()));
        }
        static int Rev(string v) => int.Parse(new string(v.Reverse().ToArray()));
    }
}
