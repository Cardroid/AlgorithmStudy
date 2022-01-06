using System;

namespace AlgorithmStudy.NET.Problems._2112
{
    class _2935
    {
        static void Main()
        {
            string num1 = Console.ReadLine();
            string calc = Console.ReadLine();
            string num2 = Console.ReadLine();

            if (num1.Length < num2.Length)
            {
                var temp = num1;
                num1 = num2;
                num2 = temp;
            }

            if (calc == "+")
            {
                var temp = num1.ToCharArray();
                temp[^num2.Length] = char.Parse((int.Parse(temp[^num2.Length].ToString()) + 1).ToString());
                num1 = new string(temp);
            }
            else
            {
                num1 += num2[1..];
            }

            Console.WriteLine(num1);
        }
    }
}
