using System;

namespace AlgorithmStudy.NET.Problems._2112
{
    class _2712
    {
        static void Main()
        {
            var tCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < tCase; i++)
            {
                var temp = Console.ReadLine().Split(' ');
                float input = float.Parse(temp[0]);
                string ext = temp[1];

                switch (ext)
                {
                    case "kg":
                        input = input * 2.2046f;
                        ext = "lb";
                        break;
                    case "lb":
                        input = input * 0.4536f;
                        ext = "kg";
                        break;
                    case "l":
                        input = input * 0.2642f;
                        ext = "g";
                        break;
                    case "g":
                        input = input * 3.7854f;
                        ext = "l";
                        break;
                }

                Console.WriteLine($"{Math.Round(input, 4):F4} {ext}");
            }
        }
    }
}
