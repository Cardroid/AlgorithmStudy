
// 메모리 초과로 실패

using System;

namespace AlgorithmStudy.Problems._2109
{
    class _9935
    {
        static void Main()
        {
            var str = Console.ReadLine();
            var exp = Console.ReadLine();

            while (str.Contains(exp))
            {
                str = str.Replace(exp, "");
            }

            if (string.IsNullOrEmpty(str))
                Console.WriteLine("FRULA");
            else
                Console.WriteLine(str);
        }
    }
}
