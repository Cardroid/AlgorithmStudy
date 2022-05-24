using System;

namespace AlgorithmStudy.NET.Problems._2112
{
    class _11098
    {
        static void Main()
        {
            var tCase = int.Parse(Console.ReadLine());

            for (int t = 0; t < tCase; t++)
            {
                int max = 0;
                int index = 0;
                int innerCase = int.Parse(Console.ReadLine());

                Tuple<int, string>[] list = new Tuple<int, string>[innerCase];
                for (int i = 0; i < innerCase; i++)
                {
                    var temp = Console.ReadLine().Split(' ');
                    list[i] = new Tuple<int, string>(int.Parse(temp[0]), temp[1]);

                    if (max < list[i].Item1)
                    {
                        index = i;
                        max = list[i].Item1;
                    }
                }

                Console.WriteLine(list[index].Item2);
            }
        }
    }
}
