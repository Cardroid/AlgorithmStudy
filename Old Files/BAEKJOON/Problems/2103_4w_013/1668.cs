using System;

namespace BAEKJOON.Problems._2103_4w
{
    class _1668
    {
        static void Main()
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
                array[i] = int.Parse(Console.ReadLine());

            int fResult = 0;
            int lResult = 0;

            int temp = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > temp)
                {
                    temp = array[i];
                    fResult++;
                }
            }

            temp = int.MinValue;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > temp)
                {
                    temp = array[i];
                    lResult++;
                }
            }

            Console.WriteLine($"{fResult}\n{lResult}");
        }
    }
}
